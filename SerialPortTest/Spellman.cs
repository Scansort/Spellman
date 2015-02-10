using System;
using System.IO.Ports;
using System.Threading;

namespace Spellman
{
    class Spellman
    {
        // constructors
        public Spellman(string portName)
        {
      //      var temp = portName;                  // ???
            
            _spellman.BaudRate = 9600;
            _spellman.DiscardNull = true;
    //        _spellman.PortName = temp;            // ???
            _spellman.PortName = portName;
        }

        // data field
        private readonly SerialPort _spellman = new SerialPort();
        
        // properties
        public string RecieveFromPort { get; private set; }

        // methods
        public void  SendAndRecieveMessage(byte[] sendData)
        {
            RecieveFromPort = "";
            if (_spellman == null) return;
            _spellman.Open();
            _spellman.Write(sendData, 0, sendData.Length);
            Thread.Sleep(500);
            var data = new byte[16];
            _spellman.Read(data, 0, data.Length);
            _spellman.Close();
            for (var i = 0; i < 16; i++)                                             // ???
            {
                RecieveFromPort += @" " + Convert.ToString(data[i], 16);
            }
        }
        

        //public string SendCommandAndGetResponse(byte[] command)
        //{
        //    var response = "Error";
        //    if (_spellman == null) return response;
        //    SendCommandToToshiba(command);
        //    Thread.Sleep(2);
        //    response = GetToshibaDataFromPort();
        //    return response;
        //}



        //public void SendCommandToToshiba(byte[] command)
        //{
        //    _spellman.DtrEnable = false;
        //    _spellman.Write(command, 0, command.Length);
        //    Thread.Sleep(2);
        //    _spellman.DtrEnable = true;
        //}

        //readonly byte[] _buffer = new byte[69];
        //public string GetToshibaDataFromPort()
        //{
        //    _spellman.Read(_buffer, 0, _buffer.Length);
        //    return _buffer.Aggregate("", (current, b) => current + (@" " + Convert.ToString(b, 16)));
        //}
    }
}
