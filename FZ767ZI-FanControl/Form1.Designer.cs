namespace FZ767ZI_FanControl
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.fanCalibrator2 = new FZ767ZI_FanControl.FanCalibrator();
            this.fanCalibrator1 = new FZ767ZI_FanControl.FanCalibrator();
            this.fanController2 = new FZ767ZI_FanControl.FanController();
            this.fanController1 = new FZ767ZI_FanControl.FanController();
            this.fanStats2 = new FZ767ZI_FanControl.FanStats();
            this.fanStats1 = new FZ767ZI_FanControl.FanStats();
            this.LBTemperature = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
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
            this.tabControl1.Size = new System.Drawing.Size(512, 502);
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
            this.tabPage1.Size = new System.Drawing.Size(504, 476);
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
            this.fanCalibrator2.Size = new System.Drawing.Size(225, 96);
            this.fanCalibrator2.TabIndex = 2;
            // 
            // fanCalibrator1
            // 
            this.fanCalibrator1.CalibrationButtonEnabled = true;
            this.fanCalibrator1.Location = new System.Drawing.Point(24, 354);
            this.fanCalibrator1.MaxSpeed = 0;
            this.fanCalibrator1.MinSpeed = 0;
            this.fanCalibrator1.Name = "fanCalibrator1";
            this.fanCalibrator1.Size = new System.Drawing.Size(225, 96);
            this.fanCalibrator1.TabIndex = 2;
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
            this.tabPage2.Controls.Add(this.CBDisconnect);
            this.tabPage2.Controls.Add(this.BConnect);
            this.tabPage2.Controls.Add(this.CBHandshake);
            this.tabPage2.Controls.Add(this.CBStopBits);
            this.tabPage2.Controls.Add(this.CBDataBits);
            this.tabPage2.Controls.Add(this.CBParity);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.CBBaudRate);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.CBSerialPortNumber);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(504, 476);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Connection";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // CBDisconnect
            // 
            this.CBDisconnect.Enabled = false;
            this.CBDisconnect.Location = new System.Drawing.Point(423, 172);
            this.CBDisconnect.Name = "CBDisconnect";
            this.CBDisconnect.Size = new System.Drawing.Size(75, 23);
            this.CBDisconnect.TabIndex = 4;
            this.CBDisconnect.Text = "Disconnect";
            this.CBDisconnect.UseVisualStyleBackColor = true;
            this.CBDisconnect.Click += new System.EventHandler(this.CBDisconnect_Click);
            // 
            // BConnect
            // 
            this.BConnect.Location = new System.Drawing.Point(342, 172);
            this.BConnect.Name = "BConnect";
            this.BConnect.Size = new System.Drawing.Size(75, 23);
            this.BConnect.TabIndex = 4;
            this.BConnect.Text = "Connect";
            this.BConnect.UseVisualStyleBackColor = true;
            this.BConnect.Click += new System.EventHandler(this.BConnect_Click);
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
            this.CBHandshake.Location = new System.Drawing.Point(71, 145);
            this.CBHandshake.Name = "CBHandshake";
            this.CBHandshake.Size = new System.Drawing.Size(427, 21);
            this.CBHandshake.TabIndex = 2;
            // 
            // CBStopBits
            // 
            this.CBStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBStopBits.FormattingEnabled = true;
            this.CBStopBits.Items.AddRange(new object[] {
            "1",
            "2",
            "1.5"});
            this.CBStopBits.Location = new System.Drawing.Point(71, 118);
            this.CBStopBits.Name = "CBStopBits";
            this.CBStopBits.Size = new System.Drawing.Size(427, 21);
            this.CBStopBits.TabIndex = 2;
            // 
            // CBDataBits
            // 
            this.CBDataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBDataBits.FormattingEnabled = true;
            this.CBDataBits.Items.AddRange(new object[] {
            "8"});
            this.CBDataBits.Location = new System.Drawing.Point(71, 91);
            this.CBDataBits.Name = "CBDataBits";
            this.CBDataBits.Size = new System.Drawing.Size(427, 21);
            this.CBDataBits.TabIndex = 2;
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
            this.CBParity.Location = new System.Drawing.Point(71, 64);
            this.CBParity.Name = "CBParity";
            this.CBParity.Size = new System.Drawing.Size(427, 21);
            this.CBParity.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 0;
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
            this.CBBaudRate.Location = new System.Drawing.Point(71, 36);
            this.CBBaudRate.Name = "CBBaudRate";
            this.CBBaudRate.Size = new System.Drawing.Size(427, 21);
            this.CBBaudRate.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Stop bits:";
            // 
            // CBSerialPortNumber
            // 
            this.CBSerialPortNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBSerialPortNumber.FormattingEnabled = true;
            this.CBSerialPortNumber.Location = new System.Drawing.Point(71, 9);
            this.CBSerialPortNumber.Name = "CBSerialPortNumber";
            this.CBSerialPortNumber.Size = new System.Drawing.Size(427, 21);
            this.CBSerialPortNumber.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Data bits:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Parity:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Baud rate:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Serial port:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LBConnectionStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 480);
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
            this.ClientSize = new System.Drawing.Size(512, 502);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "FZ767ZI Fan Control";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
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
        private System.Windows.Forms.Button BConnect;
        private System.Windows.Forms.ComboBox CBBaudRate;
        private System.Windows.Forms.ComboBox CBSerialPortNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FanStats fanStats2;
        private FanStats fanStats1;
        private FanController fanController1;
        private FanController fanController2;
        private FanCalibrator fanCalibrator2;
        private FanCalibrator fanCalibrator1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel LBConnectionStatus;
        private System.Windows.Forms.ComboBox CBParity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CBStopBits;
        private System.Windows.Forms.ComboBox CBDataBits;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CBHandshake;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button CBDisconnect;
    }
}

