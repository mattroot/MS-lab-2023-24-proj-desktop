using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FZ767ZI_FanControl
{
    static class ComboBoxExtansions
    {
        public static string ItemAtSelected(this System.Windows.Forms.ComboBox box) {
            return box.Items[box.SelectedIndex].ToString();
        }
    }
}
