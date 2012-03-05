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
        discView mv;

        public MainForm()
        {
            DoubleBuffered = true;
            InitializeComponent();
            AppDomain.CurrentDomain.SetData("DataDirectory", @"../../data");
            AppDomain.CurrentDomain.SetData("Image", @"../../image");
            mv = new discView();
            mainPanel.Controls.Add(mv);   
        }

        private void discToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //bump_menuItem(mainToolStripMenuItem, discToolStripMenuItem);
            //mainPanel.Controls.Clear();
            //discView us = new discView();
            //mainPanel.Controls.Add(us);
        }

        private void bump_menuItem(ToolStripMenuItem obj1, ToolStripMenuItem obj2)
        {
            if (obj1.Checked == true)
            {
                obj1.Checked = false;
                obj2.Checked = true;
            }
            else
            {
                obj1.Checked = true;
                obj2.Checked = false;
            }
        }
    }
    
}
