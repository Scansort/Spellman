using System.Drawing;
using System.Windows.Forms;

namespace Spellman
{
    public partial class SpellmanControlUI : Form
    {
        // constructors
        public SpellmanControlUI()
        {
            InitializeComponent();

            // splmControl1
            _splmControl1.Location = new Point(12, 25);
            _splmControl1.Name = "splmControl1";
            _splmControl1.Size = new Size(218, 357);
            _splmControl1.TabIndex = 4;
             
            // splmControl2
            _splmControl2.Location = new Point(235, 25);
            _splmControl2.Name = "splmControl2";
            _splmControl2.Size = new Size(218, 357);
            _splmControl2.TabIndex = 5;
            
            Controls.Add(_splmControl1);
            Controls.Add(_splmControl2);
        }

        // data field
        readonly SplmControl _splmControl1 = new SplmControl("COM1");
        readonly SplmControl _splmControl2 = new SplmControl("COM2");
        
    }
}
