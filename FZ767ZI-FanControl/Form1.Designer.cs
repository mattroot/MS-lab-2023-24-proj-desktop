namespace F767ZI_FanControl
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.fanCalibrator2 = new F767ZI_FanControl.FanCalibrator();
            this.fanCalibrator1 = new F767ZI_FanControl.FanCalibrator();
            this.fanController2 = new F767ZI_FanControl.FanController();
            this.fanController1 = new F767ZI_FanControl.FanController();
            this.fanStats2 = new F767ZI_FanControl.FanStats();
            this.fanStats1 = new F767ZI_FanControl.FanStats();
            this.LBTemperature = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.COMCmdGroupBox = new System.Windows.Forms.GroupBox();
            this.RawSerialPostButton = new System.Windows.Forms.Button();
            this.rawCommandTextBox = new System.Windows.Forms.TextBox();
            this.DevDebugGroupBox = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.COMDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.CBDisconnect = new System.Windows.Forms.Button();
            this.BConnect = new System.Windows.Forms.Button();
            this.CBHandshake = new System.Windows.Forms.ComboBox();
            this.CBStopBits = new System.Windows.Forms.ComboBox();
            this.CBDataBits = new System.Windows.Forms.ComboBox();
            this.CBParity = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CBBaudRate = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CBSerialPortNumber = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.LBConnectionStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.COMCmdGroupBox.SuspendLayout();
            this.DevDebugGroupBox.SuspendLayout();
            this.COMDetailsGroupBox.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(512, 530);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.fanCalibrator2);
            this.tabPage1.Controls.Add(this.fanCalibrator1);
            this.tabPage1.Controls.Add(this.fanController2);
            this.tabPage1.Controls.Add(this.fanController1);
            this.tabPage1.Controls.Add(this.fanStats2);
            this.tabPage1.Controls.Add(this.fanStats1);
            this.tabPage1.Controls.Add(this.LBTemperature);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(504, 504);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Control";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // fanCalibrator2
            // 
            this.fanCalibrator2.CalibrationButtonEnabled = true;
            this.fanCalibrator2.Location = new System.Drawing.Point(271, 354);
            this.fanCalibrator2.MaxSpeed = 0;
            this.fanCalibrator2.MinSpeed = 0;
            this.fanCalibrator2.Name = "fanCalibrator2";
            this.fanCalibrator2.Size = new System.Drawing.Size(225, 115);
            this.fanCalibrator2.StartDuty = 0F;
            this.fanCalibrator2.TabIndex = 2;
            // 
            // fanCalibrator1
            // 
            this.fanCalibrator1.CalibrationButtonEnabled = true;
            this.fanCalibrator1.Location = new System.Drawing.Point(24, 354);
            this.fanCalibrator1.MaxSpeed = 0;
            this.fanCalibrator1.MinSpeed = 0;
            this.fanCalibrator1.Name = "fanCalibrator1";
            this.fanCalibrator1.Size = new System.Drawing.Size(225, 115);
            this.fanCalibrator1.StartDuty = 0F;
            this.fanCalibrator1.TabIndex = 2;
            this.fanCalibrator1.Load += new System.EventHandler(this.fanCalibrator1_Load);
            // 
            // fanController2
            // 
            this.fanController2.IsSetModeEnabled = true;
            this.fanController2.Location = new System.Drawing.Point(271, 206);
            this.fanController2.MaxRPM = 3000;
            this.fanController2.MinRPM = 0;
            this.fanController2.Name = "fanController2";
            this.fanController2.Size = new System.Drawing.Size(225, 142);
            this.fanController2.TabIndex = 1;
            // 
            // fanController1
            // 
            this.fanController1.IsSetModeEnabled = true;
            this.fanController1.Location = new System.Drawing.Point(24, 206);
            this.fanController1.MaxRPM = 3000;
            this.fanController1.MinRPM = 0;
            this.fanController1.Name = "fanController1";
            this.fanController1.Size = new System.Drawing.Size(225, 142);
            this.fanController1.TabIndex = 1;
            // 
            // fanStats2
            // 
            this.fanStats2.DutyCycle = ((byte)(0));
            this.fanStats2.FanName = "2";
            this.fanStats2.Location = new System.Drawing.Point(271, 58);
            this.fanStats2.Mode = "None";
            this.fanStats2.Name = "fanStats2";
            this.fanStats2.RequestedValue = 0;
            this.fanStats2.Size = new System.Drawing.Size(225, 142);
            this.fanStats2.Speed = 0;
            this.fanStats2.TabIndex = 0;
            // 
            // fanStats1
            // 
            this.fanStats1.DutyCycle = ((byte)(0));
            this.fanStats1.FanName = "1";
            this.fanStats1.Location = new System.Drawing.Point(8, 58);
            this.fanStats1.Mode = "None";
            this.fanStats1.Name = "fanStats1";
            this.fanStats1.RequestedValue = 0;
            this.fanStats1.Size = new System.Drawing.Size(225, 142);
            this.fanStats1.Speed = 0;
            this.fanStats1.TabIndex = 0;
            // 
            // LBTemperature
            // 
            this.LBTemperature.AutoSize = true;
            this.LBTemperature.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LBTemperature.Location = new System.Drawing.Point(251, 4);
            this.LBTemperature.Name = "LBTemperature";
            this.LBTemperature.Size = new System.Drawing.Size(61, 33);
            this.LBTemperature.TabIndex = 0;
            this.LBTemperature.Text = "0 °C";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Temperature:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.COMCmdGroupBox);
            this.tabPage2.Controls.Add(this.DevDebugGroupBox);
            this.tabPage2.Controls.Add(this.COMDetailsGroupBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(504, 504);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Connection";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // COMCmdGroupBox
            // 
            this.COMCmdGroupBox.Controls.Add(this.RawSerialPostButton);
            this.COMCmdGroupBox.Controls.Add(this.rawCommandTextBox);
            this.COMCmdGroupBox.Location = new System.Drawing.Point(11, 393);
            this.COMCmdGroupBox.Name = "COMCmdGroupBox";
            this.COMCmdGroupBox.Size = new System.Drawing.Size(485, 52);
            this.COMCmdGroupBox.TabIndex = 2;
            this.COMCmdGroupBox.TabStop = false;
            this.COMCmdGroupBox.Text = "Send raw serial command";
            // 
            // RawSerialPostButton
            // 
            this.RawSerialPostButton.Location = new System.Drawing.Point(404, 16);
            this.RawSerialPostButton.Name = "RawSerialPostButton";
            this.RawSerialPostButton.Size = new System.Drawing.Size(75, 23);
            this.RawSerialPostButton.TabIndex = 19;
            this.RawSerialPostButton.Text = "POST";
            this.RawSerialPostButton.UseVisualStyleBackColor = true;
            this.RawSerialPostButton.Click += new System.EventHandler(this.RawSerialPostButton_Click);
            // 
            // rawCommandTextBox
            // 
            this.rawCommandTextBox.Location = new System.Drawing.Point(6, 19);
            this.rawCommandTextBox.Name = "rawCommandTextBox";
            this.rawCommandTextBox.Size = new System.Drawing.Size(392, 20);
            this.rawCommandTextBox.TabIndex = 0;
            // 
            // DevDebugGroupBox
            // 
            this.DevDebugGroupBox.Controls.Add(this.button4);
            this.DevDebugGroupBox.Controls.Add(this.button3);
            this.DevDebugGroupBox.Controls.Add(this.button2);
            this.DevDebugGroupBox.Controls.Add(this.button1);
            this.DevDebugGroupBox.Controls.Add(this.label11);
            this.DevDebugGroupBox.Controls.Add(this.label10);
            this.DevDebugGroupBox.Controls.Add(this.label9);
            this.DevDebugGroupBox.Controls.Add(this.label4);
            this.DevDebugGroupBox.Location = new System.Drawing.Point(11, 233);
            this.DevDebugGroupBox.Name = "DevDebugGroupBox";
            this.DevDebugGroupBox.Size = new System.Drawing.Size(485, 140);
            this.DevDebugGroupBox.TabIndex = 1;
            this.DevDebugGroupBox.TabStop = false;
            this.DevDebugGroupBox.Text = "Device debugging";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(167, 107);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "TEL,1";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(167, 79);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "TEL,0";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(167, 51);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "RSD";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(167, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "RST";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 112);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Enable telemetry posting";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Disable telemetry posting";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Reinitialize I2C display";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Perform soft reset of the device";
            // 
            // COMDetailsGroupBox
            // 
            this.COMDetailsGroupBox.Controls.Add(this.CBDisconnect);
            this.COMDetailsGroupBox.Controls.Add(this.BConnect);
            this.COMDetailsGroupBox.Controls.Add(this.CBHandshake);
            this.COMDetailsGroupBox.Controls.Add(this.CBStopBits);
            this.COMDetailsGroupBox.Controls.Add(this.CBDataBits);
            this.COMDetailsGroupBox.Controls.Add(this.CBParity);
            this.COMDetailsGroupBox.Controls.Add(this.label8);
            this.COMDetailsGroupBox.Controls.Add(this.CBBaudRate);
            this.COMDetailsGroupBox.Controls.Add(this.label7);
            this.COMDetailsGroupBox.Controls.Add(this.CBSerialPortNumber);
            this.COMDetailsGroupBox.Controls.Add(this.label6);
            this.COMDetailsGroupBox.Controls.Add(this.label5);
            this.COMDetailsGroupBox.Controls.Add(this.label2);
            this.COMDetailsGroupBox.Controls.Add(this.label1);
            this.COMDetailsGroupBox.Location = new System.Drawing.Point(8, 6);
            this.COMDetailsGroupBox.Name = "COMDetailsGroupBox";
            this.COMDetailsGroupBox.Size = new System.Drawing.Size(488, 220);
            this.COMDetailsGroupBox.TabIndex = 0;
            this.COMDetailsGroupBox.TabStop = false;
            this.COMDetailsGroupBox.Text = "Connection details";
            // 
            // CBDisconnect
            // 
            this.CBDisconnect.Enabled = false;
            this.CBDisconnect.Location = new System.Drawing.Point(407, 182);
            this.CBDisconnect.Name = "CBDisconnect";
            this.CBDisconnect.Size = new System.Drawing.Size(75, 23);
            this.CBDisconnect.TabIndex = 17;
            this.CBDisconnect.Text = "Disconnect";
            this.CBDisconnect.UseVisualStyleBackColor = true;
            this.CBDisconnect.Click += new System.EventHandler(this.CBDisconnect_Click_1);
            // 
            // BConnect
            // 
            this.BConnect.Location = new System.Drawing.Point(326, 182);
            this.BConnect.Name = "BConnect";
            this.BConnect.Size = new System.Drawing.Size(75, 23);
            this.BConnect.TabIndex = 18;
            this.BConnect.Text = "Connect";
            this.BConnect.UseVisualStyleBackColor = true;
            this.BConnect.Click += new System.EventHandler(this.BConnect_Click_1);
            // 
            // CBHandshake
            // 
            this.CBHandshake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBHandshake.FormattingEnabled = true;
            this.CBHandshake.Items.AddRange(new object[] {
            "None",
            "XOnXOff",
            "RequestToSend",
            "RequestToSendXOnXOff"});
            this.CBHandshake.Location = new System.Drawing.Point(63, 155);
            this.CBHandshake.Name = "CBHandshake";
            this.CBHandshake.Size = new System.Drawing.Size(419, 21);
            this.CBHandshake.TabIndex = 13;
            // 
            // CBStopBits
            // 
            this.CBStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBStopBits.FormattingEnabled = true;
            this.CBStopBits.Items.AddRange(new object[] {
            "1",
            "2",
            "1.5"});
            this.CBStopBits.Location = new System.Drawing.Point(63, 128);
            this.CBStopBits.Name = "CBStopBits";
            this.CBStopBits.Size = new System.Drawing.Size(419, 21);
            this.CBStopBits.TabIndex = 16;
            // 
            // CBDataBits
            // 
            this.CBDataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBDataBits.FormattingEnabled = true;
            this.CBDataBits.Items.AddRange(new object[] {
            "8"});
            this.CBDataBits.Location = new System.Drawing.Point(63, 101);
            this.CBDataBits.Name = "CBDataBits";
            this.CBDataBits.Size = new System.Drawing.Size(419, 21);
            this.CBDataBits.TabIndex = 14;
            // 
            // CBParity
            // 
            this.CBParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBParity.FormattingEnabled = true;
            this.CBParity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.CBParity.Location = new System.Drawing.Point(63, 74);
            this.CBParity.Name = "CBParity";
            this.CBParity.Size = new System.Drawing.Size(419, 21);
            this.CBParity.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(0, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Handshake:";
            // 
            // CBBaudRate
            // 
            this.CBBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBBaudRate.FormattingEnabled = true;
            this.CBBaudRate.Items.AddRange(new object[] {
            "50",
            "75",
            "110",
            "134",
            "150",
            "200",
            "300",
            "600",
            "1200",
            "1800",
            "2400",
            "4800",
            "9600",
            "19200",
            "28800",
            "38400",
            "57600",
            "76800",
            "115200",
            "230400",
            "460800",
            "576000",
            "921600"});
            this.CBBaudRate.Location = new System.Drawing.Point(63, 46);
            this.CBBaudRate.Name = "CBBaudRate";
            this.CBBaudRate.Size = new System.Drawing.Size(419, 21);
            this.CBBaudRate.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Stop bits:";
            // 
            // CBSerialPortNumber
            // 
            this.CBSerialPortNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBSerialPortNumber.FormattingEnabled = true;
            this.CBSerialPortNumber.Location = new System.Drawing.Point(63, 19);
            this.CBSerialPortNumber.Name = "CBSerialPortNumber";
            this.CBSerialPortNumber.Size = new System.Drawing.Size(419, 21);
            this.CBSerialPortNumber.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Data bits:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Parity:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Baud rate:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Serial port:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LBConnectionStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 508);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(512, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // LBConnectionStatus
            // 
            this.LBConnectionStatus.Name = "LBConnectionStatus";
            this.LBConnectionStatus.Size = new System.Drawing.Size(95, 17);
            this.LBConnectionStatus.Text = "Not connected...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 530);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "F767ZI-FanControl - control panel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.COMCmdGroupBox.ResumeLayout(false);
            this.COMCmdGroupBox.PerformLayout();
            this.DevDebugGroupBox.ResumeLayout(false);
            this.DevDebugGroupBox.PerformLayout();
            this.COMDetailsGroupBox.ResumeLayout(false);
            this.COMDetailsGroupBox.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label LBTemperature;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage2;
        private FanStats fanStats2;
        private FanStats fanStats1;
        private FanController fanController1;
        private FanController fanController2;
        private FanCalibrator fanCalibrator2;
        private FanCalibrator fanCalibrator1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel LBConnectionStatus;
        private System.Windows.Forms.GroupBox COMCmdGroupBox;
        private System.Windows.Forms.GroupBox DevDebugGroupBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox COMDetailsGroupBox;
        private System.Windows.Forms.Button CBDisconnect;
        private System.Windows.Forms.Button BConnect;
        private System.Windows.Forms.ComboBox CBHandshake;
        private System.Windows.Forms.ComboBox CBStopBits;
        private System.Windows.Forms.ComboBox CBDataBits;
        private System.Windows.Forms.ComboBox CBParity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CBBaudRate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CBSerialPortNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RawSerialPostButton;
        private System.Windows.Forms.TextBox rawCommandTextBox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

