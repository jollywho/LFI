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
        public static string Lmode;
        mainView mv;

        public MainForm()
        {
            Lmode = "JPN";
            DoubleBuffered = true;
            InitializeComponent();
            AppDomain.CurrentDomain.SetData("DataDirectory", @"../../data");
            AppDomain.CurrentDomain.SetData("Image", @"../../image");
            mv = new mainView();
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
            addView av = new addView(this);
            mainPanel.Controls.Add(av);
            av.Focus();
        }

        private void statusStripLabel_Click(object sender, EventArgs e)
        {
            if (Lmode == "JPN")
                Lmode = "ENG";
            else
                Lmode = "JPN";
            statusStripLabel.Text = Lmode;
            mv.populateList();
        }

        public void pushback_formView()
        {
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(mv);
        }

        private void menuFolderItem_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            folderView fv = new folderView(this);
            mainPanel.Controls.Add(fv);
            fv.Focus();
        }
    }
    
}
