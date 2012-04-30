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
        public Size vertical = new Size(540, 700);
        public Size horizontal = new Size(750, 700);
        mainView mv;

        public MainForm()
        {
            Lmode = "JPN";
            DoubleBuffered = true;
            InitializeComponent();
            AppDomain.CurrentDomain.SetData("DataDirectory", @"data");
            AppDomain.CurrentDomain.SetData("Image", @"../../image");
            mv = new mainView();
            panel1.Controls.Add(mv);
            mv.Enable();
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
            panel1.Controls.Clear();
            panel1.Controls.Add(mv);
            mv.populateList();
            mv.Enable();
            this.MaximumSize = vertical;
            this.MinimumSize = vertical;
            pushBackMenuStates();
            mv.Focus();
        }

        private void menuTitleItem_Click(object sender, EventArgs e)
        {
            pushback_formView();
        }

        private void menuFolderItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            mv.Disable();
            folderView fv = new folderView(this);
            panel1.Controls.Add(fv);
            this.MaximumSize = vertical;
            this.MinimumSize = vertical;
            pushBackMenuStates();
            fv.Focus();
        }

        private void menuDiscItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            mv.Disable();
            discView dv = new discView();
            panel1.Controls.Add(dv);
            this.MaximumSize = horizontal;
            this.MinimumSize = horizontal;
            pushBackMenuStates();
            dv.Focus();
        }


        private void pushBackMenuStates()
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
            if (titleEditItem.Checked == true)
            {
                menuDiscItem.Enabled = false;
                menuFolderItem.Enabled = false;
            }
            else
            {
                menuDiscItem.Enabled = true;
                menuFolderItem.Enabled = true;
            }
        }

        private void titleEditItem_Click(object sender, EventArgs e)
        {
            mv.load_editPane();
            titleEditItem.Checked = true;
            pushBackMenuStates();
        }

        private void saveItem_Click(object sender, EventArgs e)
        {
            if (mv.editPane.saveData())
            {
                titleEditItem.Checked = false;
                mv.load_infoPane();
            }
            pushBackMenuStates();
        }

        private void cancelItem_Click(object sender, EventArgs e)
        {
            titleEditItem.Checked = false;
            mv.load_infoPane();
            pushBackMenuStates();
        }

        private void menuAddItem_Click(object sender, EventArgs e)
        {
            //check view
            //addnew
        }

        public void start_progBar() { progBar.Style = ProgressBarStyle.Marquee; }
        public void stop_progBar() { progBar.Style = ProgressBarStyle.Blocks; }


        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape && titleEditItem.Checked)
                cancelItem_Click(null, null);
        }
    }
    
}
