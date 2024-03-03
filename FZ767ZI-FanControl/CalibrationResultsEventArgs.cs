using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FZ767ZI_FanControl
{
    public class CalibrationResultsEventArgs : EventArgs
    {
        public CalibrationResultsEventArgs(int minSpeed, int maxSpeed, float startDuty)
        {
            MinSpeed = minSpeed;
            MaxSpeed = maxSpeed;
            StartDuty = startDuty;
        }
        public int MinSpeed { get; set; }
        public int MaxSpeed { get; set; }
        public float StartDuty { get; set; }
    }
}
