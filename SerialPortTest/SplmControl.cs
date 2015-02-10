using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Spellman
{
    public partial class SplmControl : UserControl
    {
        // constructors
        public SplmControl()
        {
            InitializeComponent();
        }
        public SplmControl(string portName)
        {
            InitializeComponent();
            _spellman = new Spellman(portName);
        }

        // data fields
        private const int XRayOn = 0x31;
        private const int XRayOff = 0x32;
        private const int XRayReset = 0x34;
        private string _voltage;
        private string _current;
        private string _power;
        private string _filamentCurrent;
        private int _digitalControlData = 0x32;
        
        private byte[] _data; // Массив для отправки


        private readonly Spellman _spellman = new Spellman("COM1");

        
        private void btn_Send_Click(object sender, EventArgs e)
        {
            _spellman.SendAndRecieveMessage(_data);
        }

        readonly HelpClass _helpClass = new HelpClass();

        private void tmr_UpdInterface_Tick(object sender, EventArgs e)
        {
            out_txtBx.Text = _spellman.RecieveFromPort;
            _voltage = Voltage_txtbx.Text;
            _current = Current_txtbx.Text;
            _power = Power_txtbx.Text;
            _filamentCurrent = FilamentCur_txtbx.Text;
        }

        private void Accept_btn_Click(object sender, EventArgs e)
        {
            Voltage_txtbx.Text = CheckUserData(Voltage_txtbx.Text, "0", "35", "35");
            Current_txtbx.Text = CheckUserData(Current_txtbx.Text, "0", "80", "5");
            Power_txtbx.Text = CheckUserData(Power_txtbx.Text, "0", "3000", "2000");
            FilamentCur_txtbx.Text = CheckUserData(FilamentCur_txtbx.Text, "0", "5600", "4500");
            _data = _helpClass.Get_Command(_voltage, _current, _power, _filamentCurrent,_digitalControlData);
        }
        
       
        private void On_Btn_CheckedChanged(object sender, EventArgs e)
        {
            //X-ray on--0x31
            _digitalControlData = XRayOn;
        }

        private void Off_Btn_CheckedChanged(object sender, EventArgs e)
        {
            //X-ray off--0x32
            _digitalControlData = XRayOff;
        }

        private void rBtn_Reset_CheckedChanged(object sender, EventArgs e)
        {
            _digitalControlData = XRayReset;
        }

        private static string CheckUserData(string value, string minValue, string maxValue, string defaultValue)
        {
            // функция проверяет данные, вводимые пользователем 
            // minValue - нижний предел, maxValue - верхний предел
            // defaultValue - значение по умолчанию
            var valueInt = Convert.ToInt32(value);
            var lowInt = Convert.ToInt32(minValue);
            var highInt = Convert.ToInt32(maxValue);
            var m = Regex.Match(value, @"^(?:\d{"+minValue+","+maxValue+"})[\r\n]*$");
            if (m.Success && (valueInt >= lowInt && valueInt <= highInt)){return value;}
            MessageBox.Show(string.Format(@"Incorrect input. {0} should be between {1} and {2}", m, minValue, maxValue));
            return defaultValue;
        }

        private void tmr_Query_Tick(object sender, EventArgs e)
        {
            /*----------------------расскоментировать при тесте----------------------------------*/
            // по нажатию на кнопку функция отсылает запрос на состояния спелмана
            byte[] query = { 0x1, 0x51, 0x35, 0x31, 0xd };
            _spellman.SendAndRecieveMessage(query);
            double volt = 0, current = 0, filCurrent = 0;
            var spellmanIndication = _helpClass.Decrypt(_spellman.RecieveFromPort, ref volt, ref current, ref filCurrent);

            label_Volt.Text = volt.ToString(CultureInfo.InvariantCulture);
            label_Current.Text = current.ToString(CultureInfo.InvariantCulture);
            label_filamentCurrent.Text = filCurrent.ToString(CultureInfo.InvariantCulture);

            // установка картинки
            if (spellmanIndication == -1)
                // добавить исключение?
                out_txtBx.Text = @"CHEKSUM ERROR";
            if (spellmanIndication == 1)
            {
                pictureBoxOn.Visible = false;
                pictureBoxOff.Visible = true;
            }
            if (spellmanIndication == 0)
            {
                pictureBoxOn.Visible = true;
                pictureBoxOff.Visible = false;
            }
            /*------------------------------------------------------------------------------------------ */
        }
    }
}