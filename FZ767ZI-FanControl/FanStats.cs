using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace F767ZI_FanControl
{
    public partial class FanStats : UserControl
    {
        public FanStats()
        {
            InitializeComponent();
        }
        private string _fanName = "";
        public string FanName
        {
            get
            {
                return _fanName;
            }
            set
            {
                _fanName = value;
                LBFanName.Text = "Fan " + value + ":";
            }
        }
        public string Mode {
            get
            {
                return LBMode.Text;
            }
            set {
                LBMode.Text = value;
            }
        }
        public int RequestedValue
        {
            get
            {
                return int.Parse(LBReqValue.Text.TrimEnd('R', 'P', 'M', ' '));
            }
            set
            {
                LBReqValue.Text = value + " RPM";
            }
        }
        public int Speed {
            get {
                return int.Parse(LBSpeed.Text.TrimEnd('R','P','M',' '));
            }
            set {
                LBSpeed.Text = value + " RPM";
            }
        }
        public byte DutyCycle {
            get {
                return byte.Parse(LBDutyCycle.Text.TrimEnd('%'));
            }
            set {
                LBDutyCycle.Text = value + "%";
            }
        }
    }
}
