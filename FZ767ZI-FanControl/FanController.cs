using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FZ767ZI_FanControl
{
    public partial class FanController : UserControl
    {
        public FanController()
        {
            InitializeComponent();
        }
        void UpdateText()
        {
            LBSpeed.Text = trackBar1.Value + (IsInPercent ? "%" : " RPM");
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            UpdateText();
        }
        private int _minRPM = 0;
        private int _maxRPM = 3000;
        public bool IsInPercent = false;
        private void MakeTrackbarWork()
        {
            if (IsInPercent)
            {
                trackBar1.Minimum = 0;
                trackBar1.Maximum = 100;
            }
            else
            {
                trackBar1.Minimum = _minRPM;
                trackBar1.Maximum = _maxRPM;
            }
            UpdateText();
        }
        public int MinRPM
        {
            get
            {
                return trackBar1.Minimum;
            }
            set
            {
                _minRPM = value;

                if (trackBar1.Value < trackBar1.Minimum) trackBar1.Value = trackBar1.Minimum;
                MakeTrackbarWork();
                UpdateText();
            }
        }
        public int MaxRPM
        {
            get
            {
                return trackBar1.Maximum;
            }
            set
            {
                _maxRPM = value;

                if (trackBar1.Value > trackBar1.Maximum) trackBar1.Value = trackBar1.Maximum;
                MakeTrackbarWork();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PWM_FAN_CTRL_MODE mode = RBDirect.Checked ? PWM_FAN_CTRL_MODE.PWM_FAN_DIRECT : PWM_FAN_CTRL_MODE.PWM_FAN_PCONTROL;
            if (ModeChanged != null)
                ModeChanged(this, new FanModeChangedEventArgs(mode, trackBar1.Value));

        }
        public event EventHandler<FanModeChangedEventArgs> ModeChanged;

        private void RBDirect_CheckedChanged(object sender, EventArgs e)
        {
            IsInPercent = RBDirect.Checked;
            MakeTrackbarWork();
        }

        private void RBPControl_CheckedChanged(object sender, EventArgs e)
        {
            IsInPercent = RBDirect.Checked;
            MakeTrackbarWork();

        }
        public bool IsSetModeEnabled
        {
            get
            {
                return button1.Enabled;
            }
            set
            {
                button1.Enabled = value;
            }
        }
    }
}
