using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

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
        public static bool Longmode = false;
        public Size vertical = new Size(540, 700);
        public Size horizontal = new Size(745, 700);
        private int SnapDist = 20;
        private int BorderWidth = 0;
        MenuItem discEditItem = new MenuItem("Allow DiscId Edit");
        mainView mv;
        folderView fv;
        discView dv = new discView();
        public ViewMode mode;

        public MainForm()
        {
            Lmode = "JPN";
            this.DoubleBuffered = true;
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            UpdateStyles();
            InitializeComponent();
            discEditItem.Click += new EventHandler(discEditItem_Click);
            mv = new mainView();
            bPanel.Controls.Add(mv);
            mv.Enable();
            pushBackMenuStates();
        }

        private void statusStripLabel_Click(object sender, EventArgs e)
        {
            if (mode == ViewMode.Edit)
                return;
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
            else
            {
                titleEditItem.Enabled = true;
            }
        }

        public void pushback_formView()
        {
            pushBackMenuStates();
            bPanel.Controls.Clear();
            bPanel.Controls.Add(mv);
            this.MaximumSize = vertical;
            this.MinimumSize = vertical;
            if (Longmode)
            {
                this.Left += horizontal.Width - vertical.Width;
                menuItem2.MenuItems.RemoveAt(1);
                menuItem2.MenuItems.Remove(discEditItem);
            }
            Longmode = false;
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
            bPanel.Controls.Clear();
            fv = new folderView(this);
            bPanel.Controls.Add(fv);
            this.MaximumSize = vertical;
            this.MinimumSize = vertical;
            if (Longmode)
            {
                this.Left += horizontal.Width - vertical.Width;
                menuItem2.MenuItems.RemoveAt(1);
                menuItem2.MenuItems.Remove(discEditItem);
            }
            Longmode = false;
            fv.Focus();
        }

        private void menuDiscItem_Click(object sender, EventArgs e)
        {
            mode = ViewMode.Disc;
            pushBackMenuStates();
            bPanel.Controls.Clear();
            mv.Disable();
            bPanel.Controls.Add(dv);
            this.MaximumSize = horizontal;
            this.MinimumSize = horizontal;
            dv.Enable();
            if (!Longmode)
            {
                this.Left -= horizontal.Width - vertical.Width;
                if (this.Left + BorderWidth < 0) this.Left = 0 + BorderWidth;
                menuItem2.MenuItems.Add(0, discEditItem);
                menuItem2.MenuItems.Add(1, new MenuItem("-"));
            }
            Longmode = true;
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
            if (mode == ViewMode.Disc)
                dv.scrlPage_KeyDown(sender, e);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            BorderWidth = SystemInformation.FrameBorderSize.Width - 1;

            if (Properties.Settings.Default.location == new Point(0, 0))
                return; // state has never been saved

            StartPosition = FormStartPosition.Manual;
            Location = Properties.Settings.Default.location;
            Folder_IO.GetUserImagePath();
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

        private void menuItem8_Click(object sender, EventArgs e)
        {
            AboutForm abt = new AboutForm();
            abt.StartPosition = FormStartPosition.CenterParent;
            abt.ShowDialog();
        }

        private void dropItem_Click(object sender, EventArgs e)
        {
            dropItem.Checked = !dropItem.Checked;
            mv.infoPane.AllowDrop = dropItem.Checked;
            dv.allowDbuttonDrop(dropItem.Checked);
        }

        private void discEditItem_Click(object sender, EventArgs e)
        {
            discEditItem.Checked = !discEditItem.Checked;
            dv.SwapDiscIDMode(!discEditItem.Checked);
        }

        private bool DoSnap(int pos, int edge)
        {
            int delta = pos - edge;
            return delta > 0 && delta <= SnapDist;
        }

        private void MainForm_Move(object sender, EventArgs e)
        {
            Screen scn = Screen.FromPoint(this.Location);
            if (DoSnap(this.Left + BorderWidth, scn.WorkingArea.Left)) this.Left = scn.WorkingArea.Left + BorderWidth;
            if (DoSnap(this.Top + BorderWidth, scn.WorkingArea.Top)) this.Top = scn.WorkingArea.Top + BorderWidth;
            if (DoSnap(scn.WorkingArea.Right, this.Right - BorderWidth)) this.Left = scn.WorkingArea.Right - this.Width - BorderWidth;
            if (DoSnap(scn.WorkingArea.Bottom, this.Bottom - BorderWidth)) this.Top = scn.WorkingArea.Bottom - this.Height - BorderWidth;
        }
    }
    
}
