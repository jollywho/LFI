using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LFI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            AppDomain.CurrentDomain.SetData("DataDirectory", @"../../data");
            AppDomain.CurrentDomain.SetData("Image", @"../../image");
            mainView us = new mainView();
            mainPanel.Controls.Add(us);
        }

        private void discToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            discView us = new discView();
            mainPanel.Controls.Add(us);
        }

        private void testToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            mainView us = new mainView();
            mainPanel.Controls.Add(us);
        }
    }
    
}
