using System;
using System.Drawing;
using System.Windows.Forms;

namespace LFI
{
    public class BPanel : Panel
    {
        public BPanel()
        {
            this.DoubleBuffered = true;

            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            UpdateStyles();

            this.DoubleBuffered = true;
            this.BackColor = Color.Transparent;
        }

    }
}
