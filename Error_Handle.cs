using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LFI
{
    class Error_Handle
    {
        /// <summary>
        /// Display an error messsage from the specified control.
        /// </summary>
        /// <param name="error">message string.</param>
        /// <param name="tp">tooltip.</param>
        /// <param name="ctrl">focus control.</param>
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
