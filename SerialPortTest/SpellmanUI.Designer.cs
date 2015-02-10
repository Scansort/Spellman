using System;
using System.Windows.Forms;

namespace Spellman
{
    partial class SpellmanUI
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_Send = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.out_txtBx = new System.Windows.Forms.TextBox();
            this.Spellman_serialPort = new System.IO.Ports.SerialPort(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.Voltage_txtbx = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Current_txtbx = new System.Windows.Forms.TextBox();
            this.Power_txtbx = new System.Windows.Forms.TextBox();
            this.FilamentCur_txtbx = new System.Windows.Forms.TextBox();
            this.Temp_txbx = new System.Windows.Forms.TextBox();
            this.Accept_btn = new System.Windows.Forms.Button();
            this.Temp1_txbx = new System.Windows.Forms.TextBox();
            this.Temp2_txbx = new System.Windows.Forms.TextBox();
            this.cheksum1_txtBx = new System.Windows.Forms.TextBox();
            this.cheksum2_txtBx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.On_Btn = new System.Windows.Forms.RadioButton();
            this.Off_Btn = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.tmr_UpdInterface = new System.Windows.Forms.Timer(this.components);
            this.rBtn_Reset = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Send
            // 
            this.btn_Send.Location = new System.Drawing.Point(11, 226);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(75, 23);
            this.btn_Send.TabIndex = 0;
            this.btn_Send.Text = "Send";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Output";
      
            // 
            // out_txtBx
            // 
            this.out_txtBx.Location = new System.Drawing.Point(15, 27);
            this.out_txtBx.Name = "out_txtBx";
            this.out_txtBx.Size = new System.Drawing.Size(200, 20);
            this.out_txtBx.TabIndex = 4;
            // 
            // Spellman_serialPort
            // 
            this.Spellman_serialPort.PortName = "COM2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Voltage 0-35 kV";
            // 
            // Voltage_txtbx
            // 
            this.Voltage_txtbx.Location = new System.Drawing.Point(178, 53);
            this.Voltage_txtbx.Name = "Voltage_txtbx";
            this.Voltage_txtbx.Size = new System.Drawing.Size(37, 20);
            this.Voltage_txtbx.TabIndex = 7;
            this.Voltage_txtbx.Text = "35";
            this.Voltage_txtbx.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Voltage_txtbx_KeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Current 0-80 mA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Power limit 0-3000 W";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Filament Current limit 0-5600 mA";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Digital control data";
            // 
            // Current_txtbx
            // 
            this.Current_txtbx.Location = new System.Drawing.Point(178, 79);
            this.Current_txtbx.Name = "Current_txtbx";
            this.Current_txtbx.Size = new System.Drawing.Size(37, 20);
            this.Current_txtbx.TabIndex = 12;
            this.Current_txtbx.Text = "5";
            this.Current_txtbx.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Current_txtbx_KeyUp);
            // 
            // Power_txtbx
            // 
            this.Power_txtbx.Location = new System.Drawing.Point(178, 105);
            this.Power_txtbx.Name = "Power_txtbx";
            this.Power_txtbx.Size = new System.Drawing.Size(37, 20);
            this.Power_txtbx.TabIndex = 13;
            this.Power_txtbx.Text = "2000";
            this.Power_txtbx.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Power_txtbx_KeyUp);
            // 
            // FilamentCur_txtbx
            // 
            this.FilamentCur_txtbx.Location = new System.Drawing.Point(178, 131);
            this.FilamentCur_txtbx.Name = "FilamentCur_txtbx";
            this.FilamentCur_txtbx.Size = new System.Drawing.Size(37, 20);
            this.FilamentCur_txtbx.TabIndex = 14;
            this.FilamentCur_txtbx.Text = "4500";
            this.FilamentCur_txtbx.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FilamentCur_txtbx_KeyUp);
            // 
            // Temp_txbx
            // 
            this.Temp_txbx.Location = new System.Drawing.Point(18, 284);
            this.Temp_txbx.Name = "Temp_txbx";
            this.Temp_txbx.Size = new System.Drawing.Size(86, 20);
            this.Temp_txbx.TabIndex = 16;
            // 
            // Accept_btn
            // 
            this.Accept_btn.Location = new System.Drawing.Point(92, 226);
            this.Accept_btn.Name = "Accept_btn";
            this.Accept_btn.Size = new System.Drawing.Size(75, 23);
            this.Accept_btn.TabIndex = 17;
            this.Accept_btn.Text = "Accept";
            this.Accept_btn.UseVisualStyleBackColor = true;
            this.Accept_btn.Click += new System.EventHandler(this.Accept_btn_Click);
            // 
            // Temp1_txbx
            // 
            this.Temp1_txbx.Location = new System.Drawing.Point(18, 310);
            this.Temp1_txbx.Name = "Temp1_txbx";
            this.Temp1_txbx.Size = new System.Drawing.Size(86, 20);
            this.Temp1_txbx.TabIndex = 18;
            // 
            // Temp2_txbx
            // 
            this.Temp2_txbx.Location = new System.Drawing.Point(18, 336);
            this.Temp2_txbx.Name = "Temp2_txbx";
            this.Temp2_txbx.Size = new System.Drawing.Size(86, 20);
            this.Temp2_txbx.TabIndex = 19;
            // 
            // cheksum1_txtBx
            // 
            this.cheksum1_txtBx.Location = new System.Drawing.Point(119, 284);
            this.cheksum1_txtBx.Name = "cheksum1_txtBx";
            this.cheksum1_txtBx.Size = new System.Drawing.Size(86, 20);
            this.cheksum1_txtBx.TabIndex = 20;
            // 
            // cheksum2_txtBx
            // 
            this.cheksum2_txtBx.Location = new System.Drawing.Point(119, 336);
            this.cheksum2_txtBx.Name = "cheksum2_txtBx";
            this.cheksum2_txtBx.Size = new System.Drawing.Size(86, 20);
            this.cheksum2_txtBx.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "checksumStringPart1";
            // 
            // On_Btn
            // 
            this.On_Btn.AutoSize = true;
            this.On_Btn.Location = new System.Drawing.Point(18, 179);
            this.On_Btn.Name = "On_Btn";
            this.On_Btn.Size = new System.Drawing.Size(64, 17);
            this.On_Btn.TabIndex = 0;
            this.On_Btn.Text = "on X-ray";
            this.On_Btn.UseVisualStyleBackColor = true;
            this.On_Btn.CheckedChanged += new System.EventHandler(this.On_Btn_CheckedChanged);
            // 
            // Off_Btn
            // 
            this.Off_Btn.AutoSize = true;
            this.Off_Btn.Checked = true;
            this.Off_Btn.Location = new System.Drawing.Point(18, 202);
            this.Off_Btn.Name = "Off_Btn";
            this.Off_Btn.Size = new System.Drawing.Size(64, 17);
            this.Off_Btn.TabIndex = 25;
            this.Off_Btn.TabStop = true;
            this.Off_Btn.Text = "off X-ray";
            this.Off_Btn.UseVisualStyleBackColor = true;
            this.Off_Btn.CheckedChanged += new System.EventHandler(this.Off_Btn_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 268);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Temp_txbx";
            // 
            // tmr_UpdInterface
            // 
            this.tmr_UpdInterface.Enabled = true;
            this.tmr_UpdInterface.Interval = 10;
            this.tmr_UpdInterface.Tick += new System.EventHandler(this.tmr_UpdInterface_Tick);
            // 
            // rBtn_Reset
            // 
            this.rBtn_Reset.AutoSize = true;
            this.rBtn_Reset.Location = new System.Drawing.Point(92, 179);
            this.rBtn_Reset.Name = "rBtn_Reset";
            this.rBtn_Reset.Size = new System.Drawing.Size(75, 17);
            this.rBtn_Reset.TabIndex = 27;
            this.rBtn_Reset.Text = "reset X-ray";
            this.rBtn_Reset.UseVisualStyleBackColor = true;
            this.rBtn_Reset.CheckedChanged += new System.EventHandler(this.rBtn_Reset_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "checksumStringPart2";
            // 
            // SpellmanUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 372);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rBtn_Reset);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Off_Btn);
            this.Controls.Add(this.On_Btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cheksum2_txtBx);
            this.Controls.Add(this.cheksum1_txtBx);
            this.Controls.Add(this.Temp2_txbx);
            this.Controls.Add(this.Temp1_txbx);
            this.Controls.Add(this.Accept_btn);
            this.Controls.Add(this.Temp_txbx);
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
            this.Controls.Add(this.btn_Send);
            this.Name = "SpellmanUI";
            this.Text = "Spellman";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox out_txtBx;
        private System.IO.Ports.SerialPort Spellman_serialPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Voltage_txtbx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Current_txtbx;
        private System.Windows.Forms.TextBox Power_txtbx;
        private System.Windows.Forms.TextBox FilamentCur_txtbx;
        private System.Windows.Forms.TextBox Temp_txbx;
        private System.Windows.Forms.Button Accept_btn;
        private System.Windows.Forms.TextBox Temp1_txbx;
        private System.Windows.Forms.TextBox Temp2_txbx;
        private System.Windows.Forms.TextBox cheksum1_txtBx;
        private System.Windows.Forms.TextBox cheksum2_txtBx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton On_Btn;
        private System.Windows.Forms.RadioButton Off_Btn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Timer tmr_UpdInterface;

        private void Voltage_txtbx_KeyUp(object sender, KeyEventArgs e) // Ограничение на ввод
        {
            if (((e.KeyCode < Keys.D0) || (e.KeyCode > Keys.D9)) &&
                ((e.KeyCode < Keys.NumPad0) || (e.KeyCode > Keys.NumPad9))) return;
            var value = Convert.ToDouble(Voltage_txtbx.Text);
            if (((Voltage_txtbx.Text.Length >= 2) && (value < 1) || (value > 35)) ||
                ((Voltage_txtbx.Text.Length < 2) && ((value < 1) || (value > 9))))
                Voltage_txtbx.Text=@"0";
        }

        private void Current_txtbx_KeyUp(object sender, KeyEventArgs e) // Ограничение на ввод
        {
            if (((e.KeyCode < Keys.D0) || (e.KeyCode > Keys.D9)) &&
                ((e.KeyCode < Keys.NumPad0) || (e.KeyCode > Keys.NumPad9))) return;
            var value = Convert.ToDouble(Current_txtbx.Text);
            if (((Current_txtbx.Text.Length >= 2) && (value < 1) || (value > 80)) ||
                ((Current_txtbx.Text.Length < 2) && ((value < 1) || (value > 9))))
                Current_txtbx.Text=@"0";
        }

        private void Power_txtbx_KeyUp(object sender, KeyEventArgs e) // Ограничение на ввод
        {
            if (((e.KeyCode < Keys.D0) || (e.KeyCode > Keys.D9)) &&
                ((e.KeyCode < Keys.NumPad0) || (e.KeyCode > Keys.NumPad9))) return;
            var value = Convert.ToDouble(Power_txtbx.Text);
            if (((Power_txtbx.Text.Length >= 4) && (value < 1) || (value > 3000)) ||
                ((Power_txtbx.Text.Length < 2) && ((value < 1) || (value > 9))))
                Power_txtbx.Text=@"0";
        }

        private void FilamentCur_txtbx_KeyUp(object sender, KeyEventArgs e) // Ограничение на ввод
        {
            if (((e.KeyCode < Keys.D0) || (e.KeyCode > Keys.D9)) &&
                ((e.KeyCode < Keys.NumPad0) || (e.KeyCode > Keys.NumPad9))) return;
            var value = Convert.ToDouble(FilamentCur_txtbx.Text);
            if (((FilamentCur_txtbx.Text.Length >= 4) && (value < 1) || (value > 5600)) ||
                ((FilamentCur_txtbx.Text.Length < 2) && ((value < 1) || (value > 9))))
                FilamentCur_txtbx.Text=@"0";
        }

        private RadioButton rBtn_Reset;
        private Label label1;
    }
}

