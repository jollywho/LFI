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

    /// <summary>
    /// Main and only form for the SDI application.
    /// </summary>
    /// <remarks>
    /// Intercepts all keyboard and menu events.
    /// </remarks>
    public partial class MainForm : Form
    {
        public static string Lmode;
        public static bool Longmode = false;
        public static Form Main;
        public Size vertical = new Size(540, 700);
        public Size horizontal = new Size(745, 700);
        private int SnapDist = 20;
        private int BorderWidth = 0;
        MenuItem discEditItem = new MenuItem("Allow DiscId Edit");
        mainView mv;
        folderView fv;
        discView dv = new discView();
        public ViewMode mode;

        /// <summary>
        /// Sets visual styles and form size and adds all controls.
        /// </summary>
        public MainForm()
        {
            Main = this;
            Lmode = "JPN";
            this.DoubleBuffered = true;
            SetStyle(ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.OptimizedDoubleBuffer |
                          ControlStyles.UserPaint, true);
            UpdateStyles();
            InitializeComponent();
            discEditItem.Click += new EventHandler(discEditItem_Click);
            mv = new mainView(this);
            menuTitleItem_Click(null, null);
        }

        /// <summary>
        /// Swaps language mode on click event.
        /// Forces mainview to refresh and checks for empty condition.
        /// </summary>
        private void Load_Language()
        {
            if (mode == ViewMode.Edit)
                return;
            toolstripLanguage.Text = Lmode;
            mv.populateList();
            mv.Force_RowEnter();
        }

        public void EditControlState(bool state)
        {
            if (state)
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

        #region MENU_INTERFACE
        public void SetLabelSize(string size)
        {
            slblSize.Text = "Size: " + size + " GB";
        }
        public void SetLabelItemCount(int items)
        {
            slblItems.Text = items + " items";
        }
        public void SetLabelItemSize(string size)
        {
            slblItemSize.Text = size;
        }
        public void SetMenuEnableState(bool state)
        {
            menuItem3.Enabled = state;
        }
        #endregion MENU_INTERFACE
        #region MENU_CLICK

        /// <summary>
        /// Change View state to Main and resize form vertically.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuTitleItem_Click(object sender, EventArgs e)
        {
            mode = ViewMode.Main;
            bPanel.SuspendLayout();
            this.Size = vertical;
            pushBackMenuStates();
            bPanel.Controls.Clear();
            bPanel.Controls.Add(mv);
            if (Longmode)
            {
                menuItem2.MenuItems.RemoveAt(1);
                menuItem2.MenuItems.Remove(discEditItem);
            }
            Longmode = false;
            mv.Enable();
            bPanel.ResumeLayout();
        }

        /// <summary>
        /// Change View state to Folder and resize form vertically.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuFolderItem_Click(object sender, EventArgs e)
        {
            mode = ViewMode.Folder;
            bPanel.SuspendLayout();
            this.Size = vertical;
            pushBackMenuStates();
            bPanel.Controls.Clear();
            fv = new folderView(this);
            bPanel.Controls.Add(fv);
            if (Longmode)
            {
                menuItem2.MenuItems.RemoveAt(1);
                menuItem2.MenuItems.Remove(discEditItem);
            }
            Longmode = false;
            fv.Focus();
            bPanel.ResumeLayout();
        }

        /// <summary>
        /// Change View state to Disc and resize form horizontally.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuDiscItem_Click(object sender, EventArgs e)
        {
            mode = ViewMode.Disc;
            bPanel.SuspendLayout();
            this.Size = horizontal;
            pushBackMenuStates();
            bPanel.Controls.Clear();
            mv.Disable();
            bPanel.Controls.Add(dv);
            dv.Enable();
            if (!Longmode)
            {
                if (this.Right + BorderWidth > Screen.PrimaryScreen.Bounds.Right)
                    this.Left = Screen.PrimaryScreen.Bounds.Right - Width;
                menuItem2.MenuItems.Add(0, discEditItem);
                menuItem2.MenuItems.Add(1, new MenuItem("-"));
            }
            Longmode = true;
            dv.Focus();
            bPanel.ResumeLayout();
        }

        /// <summary>
        /// Turn edit mode On/Off for Main View.
        /// </summary>
        /// <remarks>OOnly accessible with mode set to Main View.</remarks>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void titleEditItem_Click(object sender, EventArgs e)
        {
            mode = ViewMode.Edit;
            bPanel.SuspendLayout();
            mv.load_editPane();
            titleEditItem.Checked = true;
            pushBackMenuStates();
            bPanel.ResumeLayout();
        }

        /// <summary>
        /// Send message to save the Main View record.
        /// </summary>
        /// <remarks>Only accessible with Main View state.</remarks>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveItem_Click(object sender, EventArgs e)
        {
            if (mv.editPane.saveData())
            {
                titleEditItem.Checked = false;
                bPanel.SuspendLayout();
                mv.load_infoPane();
                mv.Force_RowEnter();
                mode = ViewMode.Main;
                bPanel.ResumeLayout();
            }
            pushBackMenuStates();
        }

        /// <summary>
        /// Tell Main View to cancel editing the active record.
        /// </summary>
        /// <remarks>
        /// Only accessible with both Main View state and Edit enabled
        /// </remarks>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelItem_Click(object sender, EventArgs e)
        {
            mode = ViewMode.Main;
            bPanel.SuspendLayout();
            titleEditItem.Checked = false;
            mv.load_infoPane();
            pushBackMenuStates();
            bPanel.ResumeLayout();
        }

        /// <summary>
        /// Tell Main View to load edit pane with blank record.
        /// </summary>
        /// <remarks>Only accessible with Main View state.</remarks>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuAddItem_Click(object sender, EventArgs e)
        {
            mode = ViewMode.Edit;
            bPanel.SuspendLayout();
            mv.load_blank_editPane();
            titleEditItem.Checked = true;
            pushBackMenuStates();
            bPanel.ResumeLayout();
        }

        /// <summary>
        /// Turn AlwaysOnTop On/Off.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuAlwaysTop_Click(object sender, EventArgs e)
        {
            TopMost = !TopMost;
            menuAlwaysTop.Checked = !menuAlwaysTop.Checked;
        }

        /// <summary>
        /// Show About Form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuItem8_Click(object sender, EventArgs e)
        {
            AboutForm abt = new AboutForm();
            abt.TopMost = TopMost;
            abt.ShowDialog(this);
        }

        /// <summary>
        /// Turn ImageDrop On/Off.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dropItem_Click(object sender, EventArgs e)
        {
            dropItem.Checked = !dropItem.Checked;
            mv.infoPane.AllowDrop = dropItem.Checked;
            dv.allowDbuttonDrop(dropItem.Checked);
        }

        /// <summary>
        /// Tell Disc View to turn SwapDiscID On/Off.
        /// </summary>
        /// <remarks>Only accessible with mode set to Disc View.</remarks>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void discEditItem_Click(object sender, EventArgs e)
        {
            discEditItem.Checked = !discEditItem.Checked;
            dv.SwapDiscIDMode(!discEditItem.Checked);
        }

        #endregion MENU_CLICK

        /// <summary>
        /// Cycle enabled value of menu items based on View state.
        /// </summary>
        private void pushBackMenuStates()
        {
            cancelItem.Enabled = false;
            saveItem.Enabled = false;
            titleEditItem.Enabled = false;
            menuAddItem.Enabled = false;

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
            if (mode == ViewMode.Folder)
            {
                slblItems.Visible = true;
                slblSize.Visible = true;
                slblItemSize.Visible = true;
            }
            else
            {
                slblItems.Visible = false;
                slblSize.Visible = false;
                slblItemSize.Visible = false;
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

        #region Form_Events
        public void start_progBar() { progBar.Style = ProgressBarStyle.Marquee; }
        public void stop_progBar() { progBar.Style = ProgressBarStyle.Blocks; }

        /// <summary>
        /// Intercept form-level keypress events:
        /// Escape - Tell Main View to cancel editing the active record
        /// </summary>
        /// <remarks>All events sent to Disc View when its active</remarks>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape && titleEditItem.Checked)
                cancelItem_Click(null, null);
            if (mode == ViewMode.Disc)
                dv.scrlPage_KeyDown(sender, e);
            if (e.Control & e.KeyCode == Keys.F)
            {
                if (mode == ViewMode.Disc) dv.LoadFinder();
                if (mode == ViewMode.Folder) fv.FocusFilter();
                if (mode == ViewMode.Main) mv.FocusSearch();
            }
        }

        /// <summary>
        /// Load initial form location from SystemInformation and
        /// create image folder in appdata if not already exists.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            BorderWidth = SystemInformation.FrameBorderSize.Width - 1;

            if (Properties.Settings.Default.location == new Point(0, 0))
                return; // state has never been saved

            StartPosition = FormStartPosition.Manual;
            Location = Properties.Settings.Default.location;
            Folder_IO.GetUserImagePath();
            this.Size = vertical;
        }

        /// <summary>
        /// Save current form location to SystemInformation.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.location = Location;
            Properties.Settings.Default.Save();
        }

        /// <summary>
        /// Check for snap distance.
        /// </summary>
        /// <param name="pos">current position.</param>
        /// <param name="edge">window edge.</param>
        /// <returns></returns>
        private bool DoSnap(int pos, int edge)
        {
            int delta = pos - edge;
            return delta > 0 && delta <= SnapDist;
        }

        /// <summary>
        /// Snap form to screen edges when moved close enough.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Move(object sender, EventArgs e)
        {
            Screen scn = Screen.FromPoint(this.Location);
            if (DoSnap(this.Left + BorderWidth, scn.WorkingArea.Left)) this.Left = scn.WorkingArea.Left + BorderWidth;
            if (DoSnap(this.Top + BorderWidth, scn.WorkingArea.Top)) this.Top = scn.WorkingArea.Top + BorderWidth;
            if (DoSnap(scn.WorkingArea.Right, this.Right - BorderWidth)) this.Left = scn.WorkingArea.Right - this.Width - BorderWidth;
            if (DoSnap(scn.WorkingArea.Bottom, this.Bottom - BorderWidth)) this.Top = scn.WorkingArea.Bottom - this.Height - BorderWidth;
        }

        private void toolstripJPN_Click(object sender, EventArgs e)
        {
            if (mode == ViewMode.Edit) return;
            Lmode = toolstripJPN.Text;
            Load_Language();
        }

        private void toolstripENG_Click(object sender, EventArgs e)
        {
            if (mode == ViewMode.Edit) return;
            Lmode = toolstripENG.Text;
            Load_Language();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
                TopMost = false;
            if (WindowState == FormWindowState.Normal)
                TopMost = menuAlwaysTop.Checked;
        }
    }
        #endregion Form_Events
}
