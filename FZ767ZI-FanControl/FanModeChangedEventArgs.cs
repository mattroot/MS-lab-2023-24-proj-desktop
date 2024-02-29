using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FZ767ZI_FanControl
{
    public class FanModeChangedEventArgs : EventArgs
    {
        public FanModeChangedEventArgs(PWM_FAN_CTRL_MODE mode, int value)
        {
            Mode = mode;
            Value = value;
        }
        public PWM_FAN_CTRL_MODE Mode;
        public int Value;
    }
}
