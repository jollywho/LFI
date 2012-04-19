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
            DoubleBuffered = true;
            InitializeComponent();
            AppDomain.CurrentDomain.SetData("DataDirectory", @"../../data");
            AppDomain.CurrentDomain.SetData("Image", @"../../image");
            mainView mv = new mainView();
            mainPanel.Controls.Add(mv);   
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

        private void menuAddItem_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            addView av = new addView();
            mainPanel.Controls.Add(av);
            av.Focus();
        }

        private void statusStripLabel_Click(object sender, EventArgs e)
        {
            if (statusStripLabel.Text == "JPN")
                statusStripLabel.Text = "ENG";
            else
                statusStripLabel.Text = "JPN";
        }

        private void menuFolderItem_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            folderView fv = new folderView();
            mainPanel.Controls.Add(fv);
            fv.Focus();
        }
    }
    
}
