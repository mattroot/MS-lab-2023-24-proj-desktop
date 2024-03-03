using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace FZ767ZI_FanControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CBParity.SelectedIndex = 0;
            CBBaudRate.SelectedIndex = 18;
            CBSerialPortNumber.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
            CBSerialPortNumber.SelectedIndex = 0;
            CBStopBits.SelectedIndex = 0;
            CBDataBits.SelectedIndex = 0;
            CBHandshake.SelectedIndex = 0;
            fanCalibrator1.CalibrateClicked += new EventHandler(fanCalibrator1_CalibrateClicked);
            fanCalibrator2.CalibrateClicked += new EventHandler(fanCalibrator2_CalibrateClicked);
            fanCalibrator1.EHGetCalibrationClicked += new EventHandler(fanCalibrator1_EHGetCalibrationClicked);
            fanCalibrator2.EHGetCalibrationClicked += new EventHandler(fanCalibrator2_EHGetCalibrationClicked);
            api.Fan1CalibrationChanged += new EventHandler<CalibrationResultsEventArgs>(api_Fan1CalibrationChanged);
            api.Fan2CalibrationChanged += new EventHandler<CalibrationResultsEventArgs>(api_Fan2CalibrationChanged);
            api.Fan1ParametersChanged += api_Fan1ParametersChanged;
            api.Fan2ParametersChanged += api_Fan2ParametersChanged;
            fanController1.ModeChanged += new EventHandler<FanModeChangedEventArgs>(fanController1_ModeChanged);
            fanController2.ModeChanged += new EventHandler<FanModeChangedEventArgs>(fanController2_ModeChanged);
            api.SetAcknowledged += new EventHandler<ModeSetAcknowledgedEventArgs>(api_SetAcknowledged);
            api.Caller = this;
            EnableEverything(false);
        }

        void fanCalibrator2_EHGetCalibrationClicked(object sender, EventArgs e)
        {
            api.GetCalibration("fan2");
        }

        void fanCalibrator1_EHGetCalibrationClicked(object sender, EventArgs e)
        {
            api.GetCalibration("fan1");
        }

        void api_SetAcknowledged(object sender, ModeSetAcknowledgedEventArgs e)
        {
            EnableEverything(true);
        }


        void fanController1_ModeChanged(object sender, FanModeChangedEventArgs e)
        {
            api.SetMode("fan1", e.Mode, e.Value);
            EnableEverything(false);
        }

        void fanController2_ModeChanged(object sender, FanModeChangedEventArgs e)
        {
            api.SetMode("fan2", e.Mode, e.Value);
            EnableEverything(false);
        }

        

        void EnableEverything(bool enable) {
            //// fanCalibrator1.CalibrationButtonEnabled = enable;
            //fanCalibrator1.Enabled = enable;
            //// fanCalibrator2.CalibrationButtonEnabled = enable;
            //fanCalibrator2.Enabled = enable;
            //fanController1.IsSetModeEnabled = enable;
            //fanController2.IsSetModeEnabled = enable;
            return;
        }

        void api_Fan2CalibrationChanged(object sender, CalibrationResultsEventArgs e)
        {
            if (!this.IsDisposed)
                this.Invoke((Action)delegate
                {
                    fanCalibrator2.MinSpeed = e.MinSpeed;
                    fanCalibrator2.MaxSpeed = e.MaxSpeed;
                    fanCalibrator2.StartDuty = e.StartDuty;
                    fanController2.MaxRPM = e.MaxSpeed;
                    fanController2.MinRPM = e.MinSpeed;
                    EnableEverything(true);
                });
        }

        void api_Fan1CalibrationChanged(object sender, CalibrationResultsEventArgs e)
        {
            if (!this.IsDisposed)
                this.Invoke((Action)delegate
                {
                    fanCalibrator1.MinSpeed = e.MinSpeed;
                    fanCalibrator1.MaxSpeed = e.MaxSpeed;
                    fanCalibrator1.StartDuty = e.StartDuty;
                    fanController1.MaxRPM = e.MaxSpeed;
                    fanController1.MinRPM = e.MinSpeed;
                    EnableEverything(true);
                });
        }

        public string Status { get; set; }
        private string ModeToFriendlyName(PWM_FAN_CTRL_MODE mode) {
            switch (mode)
            {
                case PWM_FAN_CTRL_MODE.PWM_FAN_UNCONFIGURED:
                    return "Unconfigured";
                case PWM_FAN_CTRL_MODE.PWM_FAN_DIRECT:
                    return "Direct";
                case PWM_FAN_CTRL_MODE.PWM_FAN_PCONTROL:
                    return "P-Control";
                case PWM_FAN_CTRL_MODE.PWM_FAN_CALIBRATION_START:
                    return "Cal. Start";
                case PWM_FAN_CTRL_MODE.PWM_FAN_CALIBRATION_MAX_START:
                    return "C. Max Strt";
                case PWM_FAN_CTRL_MODE.PWM_FAN_CALIBRATION_MIN_SPEED:
                    return "C. Min. Spd";
                case PWM_FAN_CTRL_MODE.PWM_FAN_CALIBRATION_MAX_SPEED:
                    return "C. Max. Spd";
                case PWM_FAN_CTRL_MODE.PWM_FAN_CALIBRATION_START_DUTY:
                    return "C. Strt Duty";
                default:
                    return "ERROR";
            }
            return null;
        }
        void api_Fan2ParametersChanged(object sender, FanParametersChangedEventArgs e)
        {
            if (!this.IsDisposed)
                this.Invoke((Action)delegate
                {
                    FanDetails fd = e.Parameters;
                    fanStats2.Speed = fd.CurrentSpeed;
                    fanStats2.RequestedValue = fd.TargetSpeed;
                    fanStats2.Mode = ModeToFriendlyName(fd.Mode);
                    fanStats2.DutyCycle = (byte)fd.DutyCycle;
                    LBTemperature.Text = api.Temperature.ToString("0.00") + " °C";
                });
        }

        void api_Fan1ParametersChanged(object sender, FanParametersChangedEventArgs e)
        {
            if (!this.IsDisposed)
                this.Invoke((Action)delegate
                {
                    FanDetails fd = e.Parameters;
                    fanStats1.Speed = fd.CurrentSpeed;
                    fanStats1.RequestedValue = fd.TargetSpeed;
                    fanStats1.Mode = ModeToFriendlyName(fd.Mode);
                    fanStats1.DutyCycle = (byte)fd.DutyCycle;
                    LBTemperature.Text = api.Temperature.ToString("0.00") + " °C";
                });
        }

        void fanCalibrator1_CalibrateClicked(object sender, EventArgs e)
        {
            api.ScheduleCalibration("fan1");
            //EnableEverything(false);
        }

        void fanCalibrator2_CalibrateClicked(object sender, EventArgs e)
        {
            api.ScheduleCalibration("fan2");
            //EnableEverything(false);
        }

        FanControllerApi api = new FanControllerApi();

        private void button3_Click(object sender, EventArgs e)
        {
            api.EnableTelemetry(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            api.ResetDevice();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            api.ResetDisplay();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            api.EnableTelemetry(true);
        }

        private void BConnect_Click_1(object sender, EventArgs e)
        {
            if (api.IsConnected)
            {
                MessageBox.Show(this, "There is already a connection open.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            string portName = CBSerialPortNumber.ItemAtSelected();
            int baudRate = int.Parse(CBBaudRate.ItemAtSelected());
            int dataBits = int.Parse(CBDataBits.ItemAtSelected());
            Parity parity = (Parity)CBParity.SelectedIndex;
            StopBits stopBits = (StopBits)(CBStopBits.SelectedIndex + 1);
            Handshake handshake = (Handshake)CBHandshake.SelectedIndex;
            try
            {
                api.Connect(portName, baudRate, dataBits, parity, stopBits, handshake);
            }
            catch (UnauthorizedAccessException exc)
            {
                System.Windows.Forms.MessageBox.Show(
                    String.Format("Permission denied while connecting to {0}. Please make sure the serial port is not in use.", portName),
                    "Error",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error
                );
                return;
            }
            LBConnectionStatus.Text = "Connected to " + portName + "...";
            CBDisconnect.Enabled = true;
            BConnect.Enabled = false;
            EnableEverything(true);
        }

        private void CBDisconnect_Click_1(object sender, EventArgs e)
        {
            CBDisconnect.Enabled = false;
            api.Disconnect();
            BConnect.Enabled = true;
            LBConnectionStatus.Text = "Disconnected...";
            EnableEverything(false);
        }

        private void RawSerialPostButton_Click(object sender, EventArgs e)
        {
            api.PostRaw(rawCommandTextBox.Text);
        }

        private void fanCalibrator1_Load(object sender, EventArgs e)
        {

        }
    }
}
