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
            AppDomain.CurrentDomain.SetData("DataDirectory", @"data");
            AppDomain.CurrentDomain.SetData("Image", @"../../image");
            mv = new mainView();
            mainPanel.Controls.Add(mv);
            mv.enable();
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
            mv.disable();
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
            mv.populateList();
            mv.enable();
        }

        public void load_formView(object view)
        {
            if (view is folderView)
                menuFolderItem_Click(null, null);
            if (view is addView)
                menuAddItem_Click(null, null);
        }

        private void menuFolderItem_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            mv.disable();
            folderView fv = new folderView(this);
            mainPanel.Controls.Add(fv);
            fv.Focus();
        }

        private void titleEditItem_Click(object sender, EventArgs e)
        {
            mv.load_editPane();
            titleEditItem.Checked = true;   
        }

        private void menuItem2_Popup(object sender, EventArgs e)
        {
            cancelItem.Enabled = false;
            saveItem.Enabled = false;
            titleEditItem.Enabled = false;
            if (mv.enabled && mv.infoPane.active)
            {
                titleEditItem.Enabled = true;
            }
            if (mv.enabled && mv.editPane.active)
            {
                cancelItem.Enabled = true;
                saveItem.Enabled = true;
            }
        }

        private void menuItem1_Popup(object sender, EventArgs e)
        {
            if (titleEditItem.Checked == true)
            {
                menuAddItem.Enabled = false;
                menuFolderItem.Enabled = false;
            }
            else
            {
                menuAddItem.Enabled = true;
                menuFolderItem.Enabled = true;
            }
        }

        private void saveItem_Click(object sender, EventArgs e)
        {
            if (mv.editPane.saveData())
            {
                titleEditItem.Checked = false;
                mv.load_infoPane();
            }
        }

        private void cancelItem_Click(object sender, EventArgs e)
        {
            titleEditItem.Checked = false;
            mv.load_infoPane();
        }

        public void start_progBar() { progBar.Style = ProgressBarStyle.Marquee; }
        public void stop_progBar() { progBar.Style = ProgressBarStyle.Blocks; }
    }
    
}
