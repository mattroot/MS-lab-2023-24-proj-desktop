﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace F767ZI_FanControl
{
    public class ModeSetAcknowledgedEventArgs : EventArgs
    {
        public ModeSetAcknowledgedEventArgs(string fanId)
        {
            FanID = fanId;
        }
        string FanID { get; set; }
    }
}
