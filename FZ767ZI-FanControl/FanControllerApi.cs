//#define NO_SERIAL
#define DEBUG

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;


namespace F767ZI_FanControl
{
    public class FanControllerApi
    {
        public FanControllerApi()
        {

        }
        public Form1 Caller { get; set; }
        public bool IsConnected { get; protected set; }
        StringBuilder messages = new StringBuilder();
        SerialPort port;
        System.Threading.Thread bgMessage = null;
        public void Connect(string portName, int baudRate, int dataBits, Parity parity, StopBits stopBits, Handshake handshake) {
            //Fan2ParametersChanged(this, new FanParametersChangedEventArgs(ParseDetails("fan1,424.000,32.0000,4233.000,2")));
            port = new SerialPort();
            port.PortName = portName;
            port.BaudRate = baudRate;
            port.DataBits = dataBits;
            port.Parity = parity;
            port.StopBits = stopBits;
            port.Handshake = handshake;
            port.Encoding = System.Text.Encoding.ASCII;
#if NO_SERIAL
            System.Windows.Forms.MessageBox.Show("Port name: " + portName + 
                "\r\nBaud rate: " + baudRate + 
                "\r\nData bits: " + dataBits + 
                "\r\nParity: " + parity + 
                "\r\nStop bits: " + stopBits + 
                "\r\nHandshake: " + handshake);
#endif
            port.Open();
            bgMessage = new System.Threading.Thread(DispatchMessages);
            bgMessage.IsBackground = true;
            bgMessage.SetApartmentState(System.Threading.ApartmentState.STA);
            bgMessage.Start();
            IsConnected = true;
            
        }
        bool exit = false;
        public FanDetails Fan1Details { get; protected set; }
        public FanDetails Fan2Details { get; protected set; }
        public float Temperature { get; protected set; }
        public event EventHandler<FanParametersChangedEventArgs> Fan1ParametersChanged;
        public event EventHandler<FanParametersChangedEventArgs> Fan2ParametersChanged;
        public event EventHandler<CalibrationResultsEventArgs> Fan1CalibrationChanged;
        public event EventHandler<CalibrationResultsEventArgs> Fan2CalibrationChanged;
        public event EventHandler<ModeSetAcknowledgedEventArgs> SetAcknowledged;
        System.Diagnostics.Stopwatch CalibrationTimeout = new System.Diagnostics.Stopwatch();
        protected virtual void DispatchMessages() {
            while (!exit) {

                if (!IsConnected) continue;
                messages.Append(port.ReadExisting());
                string[] msg = messages.ToString().Split(new char[] {'\n','\r'}, StringSplitOptions.RemoveEmptyEntries);
                FanDetails lastf1det = Fan1Details;
                FanDetails lastf2det = Fan1Details;
                foreach (var item in msg)
                {
                    try
                    {
                        if (item.StartsWith("fan1")) Fan1Details = ParseDetails(item);
                        if (item.StartsWith("fan2")) Fan2Details = ParseDetails(item);
                        if (item.StartsWith("temp")) {
                            string[] tmp = item.Split(',');
                            float temp = float.Parse(tmp[1].Replace(".", System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator));
                            Temperature = temp;
                        }
                        if (item.StartsWith("NAK")) {
                            System.Windows.Forms.MessageBox.Show(null, "Unknown error", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Stop);
                        }

                        //if (item.StartsWith("ACK"))
                        //{
                        //    System.Windows.Forms.MessageBox.Show(null, "W porządku", "Not Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Question);
                        //}
                        if (item.StartsWith("ACK,SET,")) {
                            if (SetAcknowledged != null)
                                SetAcknowledged(this, new ModeSetAcknowledgedEventArgs(item.Substring(8).Trim()));
                        }
                        //if (IsCalibratingFirstStep) { 
                            if (item.StartsWith("ACK,CAL,")){
                                string fanid = item.Substring(8).Trim();
                                switch(fanid){
                                    case "fan1":
                                        //Fan1Calibrating = true;
                                        break;
                                    case "fan2":
                                        //Fan2Calibrating = true;
                                        break;
                                    default:
                                        System.Windows.Forms.MessageBox.Show(null, "Unexpected fan ID at calibration callback", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Stop);
                                        break;

                                }
                            }
                            
                            //if (Fan1AwaitingResults) {
                                if (item.StartsWith("ACK,GCL,fan1,")) {
                                    System.Threading.Thread.Sleep(50);
                                 // 13
                                    string calr = item.Substring(13);
                                    var cr = ParseCalibrationResult(calr);
                                    if (Fan1CalibrationChanged != null)
                                        Fan1CalibrationChanged(this, new CalibrationResultsEventArgs(cr.Item1, cr.Item2, cr.Item3));
                                    //Fan1AwaitingResults = false;
                                    //if (!Fan2AwaitingResults) IsCalibratingFirstStep = false;
                                }
                            //}

                            //if (Fan2AwaitingResults)
                            //{
                                if (item.StartsWith("ACK,GCL,fan2,"))
                                {
                                    System.Threading.Thread.Sleep(50); 
                                    // 13
                                    string calr = item.Substring(13);
                                    var cr = ParseCalibrationResult(calr);
                                    if (Fan2CalibrationChanged != null)
                                        Fan2CalibrationChanged(this, new CalibrationResultsEventArgs(cr.Item1, cr.Item2, cr.Item3));
                                    //Fan2AwaitingResults = false;
                                }
                            //}
                        //}
                    } catch (Exception x) {
                        Console.WriteLine("Exception catched: \r\n" + x);
                        //System.IO.File.AppendAllText("DEBUG.LOG", x.ToString() + "\r\n\r\n\r\n");
                    }
                }
                //if (CalibrationTimeout.ElapsedMilliseconds > 2000)
                //{
                //    //if (IsCalibratingFirstStep && Fan1Calibrating && Fan1Details.Mode == PWM_FAN_CTRL_MODE.PWM_FAN_PCONTROL)
                //    //{
                //        //Fan1Calibrating = false;
                //        WriteASCII("GCL,fan1");
                //        //Fan1AwaitingResults = true;
                //        CalibrationTimeout.Stop();
                //        CalibrationTimeout.Reset();
                //    //}
                //    if (IsCalibratingFirstStep && Fan2Calibrating && Fan2Details.Mode == PWM_FAN_CTRL_MODE.PWM_FAN_PCONTROL)
                //    {
                //        Fan2Calibrating = false;
                //        WriteASCII("GCL,fan2");
                //        Fan2AwaitingResults = true;
                //        CalibrationTimeout.Stop();
                //        CalibrationTimeout.Reset();
                //    }

                //}
                if (lastf1det != Fan1Details && Fan1ParametersChanged != null) 
                    Fan1ParametersChanged(this, new FanParametersChangedEventArgs(Fan1Details));
                if (lastf2det != Fan2Details && Fan2ParametersChanged != null) 
                    Fan2ParametersChanged(this, new FanParametersChangedEventArgs(Fan2Details));
                Console.WriteLine(messages.ToString());
                messages.Clear();
                System.Threading.Thread.Sleep(250);
            }
            exit = false;
        }
        protected Tuple<int, int, float> ParseCalibrationResult(string result) {
            string[] det = result.Split(',');
            int min = 0;
            int max = 0;
            float startDuty = 0F;
            min = int.Parse(det[0].Substring(0, det[0].IndexOf('.')));
            max = int.Parse(det[1].Substring(0, det[1].IndexOf('.')));
            startDuty = float.Parse(det[2].Replace(".", System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator));
            return new Tuple<int, int, float>(min, max, startDuty);
        }
        protected FanDetails ParseDetails(string details) {
            string[] det = details.Split(',');
            FanDetails fd = new FanDetails();
            fd.CurrentSpeed = (int)float.Parse(det[1].Substring(0, det[1].IndexOf('.')));
            fd.DutyCycle = int.Parse(det[2].Substring(0, det[2].IndexOf('.')));
            fd.TargetSpeed = (int)float.Parse(det[3].Substring(0, det[3].IndexOf('.')));
            fd.Mode = (PWM_FAN_CTRL_MODE)int.Parse(det[4]);
            return fd;
        }
        public void SetMode(string fanName, PWM_FAN_CTRL_MODE mode, int value) {
            if (mode != PWM_FAN_CTRL_MODE.PWM_FAN_DIRECT && mode != PWM_FAN_CTRL_MODE.PWM_FAN_PCONTROL) throw new InvalidOperationException();
            if (fanName != "fan1" && fanName != "fan2") throw new InvalidOperationException();
            string query = "SET," + fanName + "," + (int)mode + "," + value.ToString("0000");
            WriteASCII(query);
        }
        public void GetCalibration(string fanName)
        {
            WriteASCII(String.Format("GCL,{0}", fanName)); 
        }
        public void Disconnect() {
            exit = true;
            port.Close();
            port.Dispose();
            IsConnected = false;
        }
        public void ResetDevice()
        {
            WriteASCII("RST");
        }
        public void ResetDisplay()
        {
            WriteASCII("RSD");
        }
        public void EnableTelemetry(bool enable)
        {
            WriteASCII(String.Format("TEL,{0}", enable ? "1" : "0"));
        }
        public void PostRaw(string cmd)
        {
            WriteASCII(cmd);
        }
        public void ScheduleCalibration(string fanName) {
            if (fanName != "fan1" && fanName != "fan2") throw new InvalidOperationException();
            WriteASCII("CAL," + fanName);
            //IsCalibratingFirstStep = true;
            CalibrationTimeout.Stop();
            CalibrationTimeout.Reset();
            CalibrationTimeout.Start();
        }

        protected void WriteASCII(string str) {
            if (!IsConnected) {
                System.Windows.Forms.MessageBox.Show(null, "Not connected", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Stop);
                System.Diagnostics.Debug.Assert(port == null);
                return;
            }
            port.Write(str); // .PadRight(20, '\0')

        }
        enum CalibrationMessageResult { 
            None,
            Success,
            Failed
        }
    }
    public struct FanDetails: IEquatable<FanDetails> {
        public int CurrentSpeed;
        public int DutyCycle;
        public int TargetSpeed;
        public PWM_FAN_CTRL_MODE Mode;
        public static bool operator !=(FanDetails left, FanDetails right) {
            return !left.Equals(right);
        }
        public static bool operator ==(FanDetails left, FanDetails right) {
            return left.Equals(right);
        }
        public bool Equals(FanDetails fd) {
            return
                CurrentSpeed == fd.CurrentSpeed &&
                DutyCycle == fd.DutyCycle &&
                TargetSpeed == fd.TargetSpeed &&
                Mode == fd.Mode;
        }
        public override bool Equals(object obj)
        {
            return ((IEquatable<FanDetails>)this).Equals(obj);
        }
    }
    public enum PWM_FAN_CTRL_MODE {
        PWM_FAN_UNCONFIGURED = 0,
        PWM_FAN_DIRECT = 1,
        PWM_FAN_PCONTROL = 2,
        PWM_FAN_CALIBRATION_START = 3,
        PWM_FAN_CALIBRATION_START_DUTY = 7,
        PWM_FAN_CALIBRATION_MIN_SPEED = 5,
        PWM_FAN_CALIBRATION_MAX_START = 4,
        PWM_FAN_CALIBRATION_MAX_SPEED = 6
    }
}
