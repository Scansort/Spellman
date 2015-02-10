using System;
using System.Windows.Forms;

namespace Spellman
{
    public partial class SpellmanUI : Form
    {

        public SpellmanUI(string portName)
        {
            InitializeComponent();
           _spellman = new Spellman(portName);
        }

        public SpellmanUI()
        {
            InitializeComponent();
        }

        private const int XRayOn = 0x31;
        private const int XRayOff = 0x32;
        private const int XRayReset = 0x34;
        private string _voltage;
        private string _current;
        private string _power;
        private string _filamentCurrent;
        private int _digitalControlData = 0x32;
        
        private byte[] _data; // Массив для отправки


        private readonly Spellman _spellman;
        private void btn_Send_Click(object sender, EventArgs e)
        {
            _spellman.SendAndRecieveMessage(_data);
        }

        readonly HelpClass _helpClass=new HelpClass();
        private void tmr_UpdInterface_Tick(object sender, EventArgs e)
        {
         //   out_txtBx.Text = _spellman.ResieveFromPort;
            _voltage = Voltage_txtbx.Text;
            _current = Current_txtbx.Text;
            _power = Power_txtbx.Text;
            _filamentCurrent = FilamentCur_txtbx.Text;


            Temp_txbx.Text=_helpClass.Temp;
            Temp1_txbx.Text = _helpClass.Temp1;
            Temp2_txbx.Text = _helpClass.Temp2;
            cheksum1_txtBx.Text = _helpClass.Cheksum1;
            cheksum2_txtBx.Text = _helpClass.Cheksum2;


        }
        private void Accept_btn_Click(object sender, EventArgs e)
        {
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
      
    }
}
