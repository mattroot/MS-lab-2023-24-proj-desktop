using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace F767ZI_FanControl
{
    public sealed class FanParametersChangedEventArgs : EventArgs {
        public FanParametersChangedEventArgs(FanDetails details) {
            Parameters = details;
        }
        public FanDetails Parameters { get; set; }
    }
}
