using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Spellman
{
    public class HelpClass
    {
        public string Converting(double koef, string value)      
        {
            var tempDouble = Convert.ToDouble(value);
            tempDouble *= koef;
            var tempInt = Convert.ToInt32(tempDouble);
            var tempStr = Convert.ToString(tempInt, 16);
            if (tempStr.Length < 3)
            {
                tempStr = tempStr.Insert(0, "0");
            }
             return tempStr;
        }

        private const int StartOfMessageCharacter = 0x01;
        private const int CommandIdentifierCharacter = 0x53;
        private const int EndOfMessageCharacter = 0x0d;

        public  byte[] Get_Command(string voltage, string current, string power, string filamentCurrent, int digitalControlData)  // Возвращает массив data1 с командой управления 
        {
            const double voltageCoefficient = 68.25;
            const double currentCoefficient = 51.1875;
            const double powerCoefficient = 1.365;
            const double filamentCoefficient = 0.73125;

            var convertingHexToAscii = new Dictionary<string, int>
                {
                    {"SOH", 0x1},
                    {"<CR>", 0xd},
                    {"0", 0x30},
                    {"1", 0x31},
                    {"2", 0x32},
                    {"3", 0x33},
                    {"4", 0x34},
                    {"5", 0x35},
                    {"6", 0x36},
                    {"7", 0x37},
                    {"8", 0x38},
                    {"9", 0x39},
                    {"a", 0x41},
                    {"b", 0x42},
                    {"c", 0x43},
                    {"d", 0x44},
                    {"e", 0x45},
                    {"f", 0x46},
                    {"q", 0x51},
                    {"r", 0x52},
                    {"s", 0x53},
                    {"v", 0x56}
                };
            
            var voltageCommand1 = convertingHexToAscii[Converting(voltageCoefficient, voltage).Substring(0, 1)];
            var voltageCommand2 = convertingHexToAscii[Converting(voltageCoefficient, voltage).Substring(1, 1)];
            var voltageCommand3 = convertingHexToAscii[Converting(voltageCoefficient, voltage).Substring(2, 1)];
            var currentCommand1 = convertingHexToAscii[Converting(currentCoefficient, current).Substring(0, 1)];
            var currentCommand2 = convertingHexToAscii[Converting(currentCoefficient, current).Substring(1, 1)];
            var currentCommand3 = convertingHexToAscii[Converting(currentCoefficient, current).Substring(2, 1)];
            var powerLimitCommand1 = convertingHexToAscii[Converting(powerCoefficient, power).Substring(0, 1)];
            var powerLimitCommand2 = convertingHexToAscii[Converting(powerCoefficient, power).Substring(1, 1)];
            var powerLimitCommand3 = convertingHexToAscii[Converting(powerCoefficient, power).Substring(2, 1)];
            var filamenCurrentLimitCommand1 = convertingHexToAscii[Converting(filamentCoefficient, filamentCurrent).Substring(0, 1)];
            var filamenCurrentLimitCommand2 = convertingHexToAscii[Converting(filamentCoefficient, filamentCurrent).Substring(1, 1)];
            var filamenCurrentLimitCommand3 = convertingHexToAscii[Converting(filamentCoefficient, filamentCurrent).Substring(2, 1)];
            var list = new List<int> { CommandIdentifierCharacter, voltageCommand1, voltageCommand2, voltageCommand3, currentCommand1, currentCommand2, currentCommand3, powerLimitCommand1, powerLimitCommand2, powerLimitCommand3, filamenCurrentLimitCommand1, filamenCurrentLimitCommand2, filamenCurrentLimitCommand3, digitalControlData };
            var sum = list.Sum();
            var checksumString = Convert.ToString(sum, 16);
            var checksumStringPart1 = Convert.ToByte(convertingHexToAscii[checksumString.Substring(1, 1)]);
            var checksumStringPart2 = Convert.ToByte(convertingHexToAscii[checksumString.Substring(2, 1)]);
            var enumeatorOfBytes  = list.Select(Convert.ToByte);
            var listOfBytes = enumeatorOfBytes as IList<byte> ?? enumeatorOfBytes.ToList();
            
            byte[] command = { StartOfMessageCharacter, listOfBytes.ElementAt(0), listOfBytes.ElementAt(1), listOfBytes.ElementAt(2), listOfBytes.ElementAt(3), listOfBytes.ElementAt(4), listOfBytes.ElementAt(5), listOfBytes.ElementAt(6), listOfBytes.ElementAt(7), listOfBytes.ElementAt(8), listOfBytes.ElementAt(9), listOfBytes.ElementAt(10), listOfBytes.ElementAt(11), 
         listOfBytes.ElementAt(12), listOfBytes.ElementAt(13), checksumStringPart1, checksumStringPart2, EndOfMessageCharacter };
            
            Indication(command);
            return command;
        }

        public  string Temp { get; private set; }
        public  string Temp1 { get; private set; }
        public  string Temp2 { get; private set; }
        public  string Cheksum1 { get; private set; }
        public  string Cheksum2 { get; private set; }
       
        private  void Indication(IList<byte> dByte)
        {
            Temp = Convert.ToString(dByte[5], 16);
            Temp1 = Convert.ToString(dByte[6], 16);
            Temp2 = Convert.ToString(dByte[7], 16);
            Cheksum1 = Convert.ToString(dByte[15], 16);
            Cheksum2 = Convert.ToString(dByte[16], 16);
        }

        // добавление функции расшифровки Spellman'a
        public int Decrypt(string chiper, ref double volt, ref double current, ref double filamentCurr)
        {
            // ASCII TABLE
            var converting = new Dictionary<string, string>
                {
                    {"30", "0"},
                    {"31", "1"},
                    {"32", "2"},
                    {"33", "3"},
                    {"34", "4"},
                    {"35", "5"},
                    {"36", "6"},
                    {"37", "7"},
                    {"38", "8"},
                    {"39", "9"},
                    {"41", "a"},
                    {"42", "b"},
                    {"43", "c"},
                    {"44", "d"},
                    {"45", "e"},
                    {"46", "f"},
                    {"52", "R"},
                };
            // END OF ASCII
            const double voltKoeff = 58.65;
            const double currKoeff = 0.078;
            const double filCurrKoef = 0.005;


            List<string> listOfStrings = new List<string>();

            // проверка чексуммы
            int sum = 0;
            for (int i = 1; i < chiper.Length; i += 3)          // first char - space
            {
                if (chiper[i] == 'd')
                    break;
                string temp = chiper.Substring(i, 2);
                if (i > 1 && i < 38)
                    sum += Convert.ToInt32(temp, 16);

                temp = converting[temp];
                listOfStrings.Add(temp);
            }
            sum %= 256;
            string checksum = Convert.ToString(sum, 16);
            string checksum_one = listOfStrings[13];
            string checksum_two = listOfStrings[14];
            if (!(checksum[0] == checksum_one[0] && checksum[1] == checksum_two[0]))
                // добавить исключение
                return -1;


            // разброс по параметрам
            string volt_str = listOfStrings[1] + listOfStrings[2] + listOfStrings[3];
            string curr_str = listOfStrings[4] + listOfStrings[5] + listOfStrings[6];
            string fil_curr = listOfStrings[7] + listOfStrings[8] + listOfStrings[9];
            string xRay_ind = listOfStrings[10];

            // перевод
            volt = Convert.ToInt32(volt_str, 16);
            volt *= voltKoeff;
            current = Convert.ToInt32(curr_str, 16);
            current *= currKoeff;
            filamentCurr = Convert.ToInt32(fil_curr, 16);
            filamentCurr *= filCurrKoef;
            int xrayswitch = Convert.ToInt32(xRay_ind, 16);

            if (Convert.ToBoolean(xrayswitch & 0x04))
                return 1;
            return 0;
        }
    }
}
