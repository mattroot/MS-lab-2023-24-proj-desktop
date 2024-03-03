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
    public partial class FanCalibrator : UserControl
    {
        public FanCalibrator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CalibrateClicked != null)
                CalibrateClicked(this, EventArgs.Empty);
        }
        public event EventHandler CalibrateClicked;
        private int _minSpeed = 0;
        private int _maxSpeed = 0;
        private float _startDuty = 0F;
        public int MinSpeed { 
            get{
                return _minSpeed;
            }
            set {
                _minSpeed = value;
                LBMinSpeed.Text = "Min. speed: " + value;
            }
        }
        public int MaxSpeed
        {
            get
            {
                return _maxSpeed;
            }
            set
            {
                _maxSpeed = value;
                LBMaxSpeed.Text = "Max. speed: " + value;
            }
        }
        public bool CalibrationButtonEnabled { 
            get { 
                return button1.Enabled; 
            }
            set
            {
                button1.Enabled = value;
            }
        }
        public event EventHandler EHGetCalibrationClicked;
        private void button2_Click(object sender, EventArgs e)
        {
            if (EHGetCalibrationClicked != null)
                EHGetCalibrationClicked(this, EventArgs.Empty);
        }

        public float StartDuty
        {
            get
            {
                return _startDuty;
            }
            set
            {
                _startDuty = value;
                fanStartDutyLabel.Text = "Start duty cycle: " + value.ToString() + "%";
            }
        }

    }
}
