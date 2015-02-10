namespace Spellman
{
    partial class SplmControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplmControl));
            this.rBtn_Reset = new System.Windows.Forms.RadioButton();
            this.Off_Btn = new System.Windows.Forms.RadioButton();
            this.On_Btn = new System.Windows.Forms.RadioButton();
            this.Accept_btn = new System.Windows.Forms.Button();
            this.FilamentCur_txtbx = new System.Windows.Forms.TextBox();
            this.Power_txtbx = new System.Windows.Forms.TextBox();
            this.Current_txtbx = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Voltage_txtbx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.out_txtBx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Send = new System.Windows.Forms.Button();
            this.tmr_UpdInterface = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxOn = new System.Windows.Forms.PictureBox();
            this.pictureBoxOff = new System.Windows.Forms.PictureBox();
            this.label_VoltageInfo = new System.Windows.Forms.Label();
            this.label_Volt = new System.Windows.Forms.Label();
            this.label_filamentCurrent = new System.Windows.Forms.Label();
            this.label_Current = new System.Windows.Forms.Label();
            this.tmr_Query = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOff)).BeginInit();
            this.SuspendLayout();
            // 
            // rBtn_Reset
            // 
            resources.ApplyResources(this.rBtn_Reset, "rBtn_Reset");
            this.rBtn_Reset.Name = "rBtn_Reset";
            this.rBtn_Reset.UseVisualStyleBackColor = true;
            this.rBtn_Reset.CheckedChanged += new System.EventHandler(this.rBtn_Reset_CheckedChanged);
            // 
            // Off_Btn
            // 
            resources.ApplyResources(this.Off_Btn, "Off_Btn");
            this.Off_Btn.Checked = true;
            this.Off_Btn.Name = "Off_Btn";
            this.Off_Btn.TabStop = true;
            this.Off_Btn.UseVisualStyleBackColor = true;
            this.Off_Btn.CheckedChanged += new System.EventHandler(this.Off_Btn_CheckedChanged);
            // 
            // On_Btn
            // 
            resources.ApplyResources(this.On_Btn, "On_Btn");
            this.On_Btn.Name = "On_Btn";
            this.On_Btn.UseVisualStyleBackColor = true;
            this.On_Btn.CheckedChanged += new System.EventHandler(this.On_Btn_CheckedChanged);
            // 
            // Accept_btn
            // 
            resources.ApplyResources(this.Accept_btn, "Accept_btn");
            this.Accept_btn.Name = "Accept_btn";
            this.Accept_btn.UseVisualStyleBackColor = true;
            this.Accept_btn.Click += new System.EventHandler(this.Accept_btn_Click);
            // 
            // FilamentCur_txtbx
            // 
            resources.ApplyResources(this.FilamentCur_txtbx, "FilamentCur_txtbx");
            this.FilamentCur_txtbx.Name = "FilamentCur_txtbx";
            // 
            // Power_txtbx
            // 
            resources.ApplyResources(this.Power_txtbx, "Power_txtbx");
            this.Power_txtbx.Name = "Power_txtbx";
            // 
            // Current_txtbx
            // 
            resources.ApplyResources(this.Current_txtbx, "Current_txtbx");
            this.Current_txtbx.Name = "Current_txtbx";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // Voltage_txtbx
            // 
            resources.ApplyResources(this.Voltage_txtbx, "Voltage_txtbx");
            this.Voltage_txtbx.Name = "Voltage_txtbx";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // out_txtBx
            // 
            resources.ApplyResources(this.out_txtBx, "out_txtBx");
            this.out_txtBx.Name = "out_txtBx";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // btn_Send
            // 
            resources.ApplyResources(this.btn_Send, "btn_Send");
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // tmr_UpdInterface
            // 
            this.tmr_UpdInterface.Enabled = true;
            this.tmr_UpdInterface.Interval = 10;
            this.tmr_UpdInterface.Tick += new System.EventHandler(this.tmr_UpdInterface_Tick);
            // 
            // pictureBoxOn
            // 
            resources.ApplyResources(this.pictureBoxOn, "pictureBoxOn");
            this.pictureBoxOn.Name = "pictureBoxOn";
            this.pictureBoxOn.TabStop = false;
            // 
            // pictureBoxOff
            // 
            resources.ApplyResources(this.pictureBoxOff, "pictureBoxOff");
            this.pictureBoxOff.Name = "pictureBoxOff";
            this.pictureBoxOff.TabStop = false;
            // 
            // label_VoltageInfo
            // 
            resources.ApplyResources(this.label_VoltageInfo, "label_VoltageInfo");
            this.label_VoltageInfo.Name = "label_VoltageInfo";
            // 
            // label_Volt
            // 
            resources.ApplyResources(this.label_Volt, "label_Volt");
            this.label_Volt.Name = "label_Volt";
            // 
            // label_filamentCurrent
            // 
            resources.ApplyResources(this.label_filamentCurrent, "label_filamentCurrent");
            this.label_filamentCurrent.Name = "label_filamentCurrent";
            // 
            // label_Current
            // 
            resources.ApplyResources(this.label_Current, "label_Current");
            this.label_Current.Name = "label_Current";
            // 
            // tmr_Query
            // 
            this.tmr_Query.Interval = 150;
            this.tmr_Query.Tick += new System.EventHandler(this.tmr_Query_Tick);
            // 
            // SplmControl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_Current);
            this.Controls.Add(this.label_filamentCurrent);
            this.Controls.Add(this.label_Volt);
            this.Controls.Add(this.label_VoltageInfo);
            this.Controls.Add(this.pictureBoxOff);
            this.Controls.Add(this.pictureBoxOn);
            this.Controls.Add(this.Accept_btn);
            this.Controls.Add(this.btn_Send);
            this.Controls.Add(this.rBtn_Reset);
            this.Controls.Add(this.Off_Btn);
            this.Controls.Add(this.On_Btn);
            this.Controls.Add(this.FilamentCur_txtbx);
            this.Controls.Add(this.Power_txtbx);
            this.Controls.Add(this.Current_txtbx);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Voltage_txtbx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.out_txtBx);
            this.Controls.Add(this.label2);
            this.Name = "SplmControl";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rBtn_Reset;
        private System.Windows.Forms.RadioButton Off_Btn;
        private System.Windows.Forms.RadioButton On_Btn;
        private System.Windows.Forms.Button Accept_btn;
        private System.Windows.Forms.TextBox FilamentCur_txtbx;
        private System.Windows.Forms.TextBox Power_txtbx;
        private System.Windows.Forms.TextBox Current_txtbx;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Voltage_txtbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox out_txtBx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.Timer tmr_UpdInterface;
        private System.Windows.Forms.PictureBox pictureBoxOn;
        private System.Windows.Forms.PictureBox pictureBoxOff;
        private System.Windows.Forms.Label label_VoltageInfo;
        private System.Windows.Forms.Label label_Volt;
        private System.Windows.Forms.Label label_filamentCurrent;
        private System.Windows.Forms.Label label_Current;
        private System.Windows.Forms.Timer tmr_Query;
    }
}
