using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace LFI
{
    public partial class BPanel : System.Windows.Forms.Panel
    {
        /// <summary>
        /// Enable panel doublebuffering.
        /// </summary>
        public BPanel()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            SetStyle(ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.OptimizedDoubleBuffer |
                          ControlStyles.UserPaint, true);
            UpdateStyles();

            this.BackColor = Color.Transparent;
        }
    }
}
