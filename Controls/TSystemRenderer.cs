using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace LFI
{
    class TSystemRenderer : ToolStripSystemRenderer
    {
        /// <summary>
        /// Remove white line bug in supplied renderer.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
        {
            //do nothing.
        }
    }
}
