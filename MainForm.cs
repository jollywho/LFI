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
        discView dv;
        mainView mv;

        public MainForm()
        {
            DoubleBuffered = true;
            InitializeComponent();
            AppDomain.CurrentDomain.SetData("DataDirectory", @"../../data");
            AppDomain.CurrentDomain.SetData("Image", @"../../image");
            mv = new mainView(mainPanel);
            mainPanel.Controls.Add(mv);   
        }

        private void discToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //bump_menuItem(mainToolStripMenuItem, discToolStripMenuItem);
            //mainPanel.Controls.Clear();
            //discView us = new discView();
            //mainPanel.Controls.Add(us);
        }

        private void mainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bump_menuItem(discToolStripMenuItem, mainToolStripMenuItem);
            mainPanel.Controls.Clear();
            mv = new mainView(mainPanel);
            mainPanel.Controls.Add(mv);
        }

        private void jPJNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bump_menuItem(eNGToolStripMenuItem, jPJNToolStripMenuItem);
        }

        private void eNGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bump_menuItem(jPJNToolStripMenuItem, eNGToolStripMenuItem);
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

        public void switchPanel(Panel panel, Panel caller)
        {
            mainPanel.Controls.Remove(caller);
            mainPanel.Controls.Add(panel);
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (discView.active && e.KeyCode == Keys.Back)
            {

            }
        }
    }
    
}
