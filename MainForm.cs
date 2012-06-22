using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LFI
{
    public enum ViewMode
    {
        Main,
        Disc,
        Folder,
        Edit,
        Empty,
    };

    public partial class MainForm : Form
    {
        public static string Lmode;
        public Size vertical = new Size(540, 700);
        public Size horizontal = new Size(750, 700);
        mainView mv;
        folderView fv;
        public ViewMode mode;

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
            pushBackMenuStates();
        }

        private void statusStripLabel_Click(object sender, EventArgs e)
        {
            if (Lmode == "JPN")
                Lmode = "ENG";
            else
                Lmode = "JPN";
            statusStripLabel.Text = Lmode;
            mv.populateList();
            mv.Force_RowEnter();
            if (mv.IsEmpty())
            {
                cancelItem.Enabled = false;
                saveItem.Enabled = false;
                titleEditItem.Enabled = false;
            }
        }

        public void pushback_formView()
        {
            pushBackMenuStates();
            panel1.Controls.Clear();
            panel1.Controls.Add(mv);
            this.MaximumSize = vertical;
            this.MinimumSize = vertical;
            mv.Enable();
        }

        private void menuTitleItem_Click(object sender, EventArgs e)
        {
            mode = ViewMode.Main;
            pushback_formView();
        }

        private void menuFolderItem_Click(object sender, EventArgs e)
        {
            mode = ViewMode.Folder;
            pushBackMenuStates();
            panel1.Controls.Clear();
            mv.Disable();
            fv = new folderView(this);
            panel1.Controls.Add(fv);
            this.MaximumSize = vertical;
            this.MinimumSize = vertical;
            
            fv.Focus();
        }

        private void menuDiscItem_Click(object sender, EventArgs e)
        {
            mode = ViewMode.Disc;
            pushBackMenuStates();
            panel1.Controls.Clear();
            mv.Disable();
            discView dv = new discView();
            panel1.Controls.Add(dv);
            this.MaximumSize = horizontal;
            this.MinimumSize = horizontal;

            dv.Focus();
        }

        private void pushBackMenuStates()
        {
            cancelItem.Enabled = false;
            saveItem.Enabled = false;
            titleEditItem.Enabled = false;
            menuAddItem.Enabled = false;

            if (fv != null)
            {
                fv.Cancel_MultiRun();
            }
            if (mode == ViewMode.Main)
            {
                titleEditItem.Enabled = true;
                menuAddItem.Enabled = true;
            }
            if (mode == ViewMode.Edit)
            {
                cancelItem.Enabled = true;
                saveItem.Enabled = true;
            }

            if (titleEditItem.Checked == true)
            {
                menuDiscItem.Enabled = false;
                menuFolderItem.Enabled = false;
                menuTitleItem.Enabled = false;
            }
            else
            {
                menuDiscItem.Enabled = true;
                menuFolderItem.Enabled = true;
                menuTitleItem.Enabled = true;
            }

            if (mv.IsEmpty())
            {
                titleEditItem.Enabled = false;
            }
        }

        private void titleEditItem_Click(object sender, EventArgs e)
        {
            mode = ViewMode.Edit;
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
                mode = ViewMode.Main;
            }
            pushBackMenuStates();
        }

        private void cancelItem_Click(object sender, EventArgs e)
        {
            mode = ViewMode.Main;
            titleEditItem.Checked = false;
            mv.load_infoPane();
            pushBackMenuStates();
        }

        private void menuAddItem_Click(object sender, EventArgs e)
        {
            mode = ViewMode.Edit;
            mv.load_blank_editPane();
            titleEditItem.Checked = true;
            pushBackMenuStates();
        }

        public void start_progBar() { progBar.Style = ProgressBarStyle.Marquee; }
        public void stop_progBar() { progBar.Style = ProgressBarStyle.Blocks; }


        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape && titleEditItem.Checked)
                cancelItem_Click(null, null);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.location == new Point(0, 0))
                return; // state has never been saved

            StartPosition = FormStartPosition.Manual;
            Location = Properties.Settings.Default.location;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.location = Location;
            Properties.Settings.Default.Save();
        }

        private void menuAlwaysTop_Click(object sender, EventArgs e)
        {
            TopMost = !TopMost;
            menuAlwaysTop.Checked = !menuAlwaysTop.Checked;
        }
    }
    
}
