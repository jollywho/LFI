using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LFI
{
    class Error_Handle
    {
        public static void TipError(string error, ToolTip tp, Control ctrl)
        {
            ctrl.Focus();
            tp.Show(error, ctrl);
        }

        public static void Clear(ToolTip tp)
        {
            tp.RemoveAll();
        }
    }
}
