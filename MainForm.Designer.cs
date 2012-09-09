namespace LFI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolstripLanguage = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolstripJPN = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstripENG = new System.Windows.Forms.ToolStripMenuItem();
            this.progBar = new System.Windows.Forms.ToolStripProgressBar();
            this.slblSize = new System.Windows.Forms.ToolStripStatusLabel();
            this.slblItems = new System.Windows.Forms.ToolStripStatusLabel();
            this.slblItemSize = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuAddItem = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.dropItem = new System.Windows.Forms.MenuItem();
            this.menuItem10 = new System.Windows.Forms.MenuItem();
            this.saveItem = new System.Windows.Forms.MenuItem();
            this.titleEditItem = new System.Windows.Forms.MenuItem();
            this.cancelItem = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuAlwaysTop = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.menuTitleItem = new System.Windows.Forms.MenuItem();
            this.menuFolderItem = new System.Windows.Forms.MenuItem();
            this.menuDiscItem = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.menuItem9 = new System.Windows.Forms.MenuItem();
            this.menuItem8 = new System.Windows.Forms.MenuItem();
            this.bPanel = new LFI.BPanel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.statusStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolstripLanguage,
            this.progBar,
            this.slblSize,
            this.slblItems,
            this.slblItemSize});
            this.statusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.statusStrip1.Location = new System.Drawing.Point(0, 376);
            this.statusStrip1.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(534, 23);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolstripLanguage
            // 
            this.toolstripLanguage.AutoSize = false;
            this.toolstripLanguage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolstripLanguage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolstripJPN,
            this.toolstripENG});
            this.toolstripLanguage.Image = ((System.Drawing.Image)(resources.GetObject("toolstripLanguage.Image")));
            this.toolstripLanguage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolstripLanguage.Name = "toolstripLanguage";
            this.toolstripLanguage.ShowDropDownArrow = false;
            this.toolstripLanguage.Size = new System.Drawing.Size(40, 22);
            this.toolstripLanguage.Text = "JPN";
            this.toolstripLanguage.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // toolstripJPN
            // 
            this.toolstripJPN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolstripJPN.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolstripJPN.Name = "toolstripJPN";
            this.toolstripJPN.ShowShortcutKeys = false;
            this.toolstripJPN.Size = new System.Drawing.Size(152, 22);
            this.toolstripJPN.Text = "JPN";
            this.toolstripJPN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolstripJPN.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.toolstripJPN.Click += new System.EventHandler(this.toolstripJPN_Click);
            // 
            // toolstripENG
            // 
            this.toolstripENG.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolstripENG.Name = "toolstripENG";
            this.toolstripENG.ShowShortcutKeys = false;
            this.toolstripENG.Size = new System.Drawing.Size(152, 22);
            this.toolstripENG.Text = "ENG";
            this.toolstripENG.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolstripENG.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.toolstripENG.Click += new System.EventHandler(this.toolstripENG_Click);
            // 
            // progBar
            // 
            this.progBar.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.progBar.MarqueeAnimationSpeed = 5;
            this.progBar.Name = "progBar";
            this.progBar.Size = new System.Drawing.Size(100, 18);
            // 
            // slblSize
            // 
            this.slblSize.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.slblSize.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.slblSize.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.slblSize.Name = "slblSize";
            this.slblSize.Size = new System.Drawing.Size(76, 19);
            this.slblSize.Text = "Size: 0.00 GB";
            this.slblSize.Visible = false;
            // 
            // slblItems
            // 
            this.slblItems.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.slblItems.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.slblItems.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.slblItems.Name = "slblItems";
            this.slblItems.Size = new System.Drawing.Size(49, 19);
            this.slblItems.Text = "0 Items";
            this.slblItems.Visible = false;
            // 
            // slblItemSize
            // 
            this.slblItemSize.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.slblItemSize.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.slblItemSize.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.slblItemSize.Name = "slblItemSize";
            this.slblItemSize.Size = new System.Drawing.Size(53, 19);
            this.slblItemSize.Text = "0000 GB";
            this.slblItemSize.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.slblItemSize.Visible = false;
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem2,
            this.menuItem3,
            this.menuItem7});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuAddItem,
            this.menuItem4,
            this.menuItem5});
            this.menuItem1.Text = "File";
            // 
            // menuAddItem
            // 
            this.menuAddItem.Index = 0;
            this.menuAddItem.Shortcut = System.Windows.Forms.Shortcut.CtrlN;
            this.menuAddItem.Text = "Add...";
            this.menuAddItem.Click += new System.EventHandler(this.menuAddItem_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 1;
            this.menuItem4.Text = "-";
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 2;
            this.menuItem5.Text = "Exit";
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 1;
            this.menuItem2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.dropItem,
            this.menuItem10,
            this.saveItem,
            this.titleEditItem,
            this.cancelItem});
            this.menuItem2.Text = "Edit";
            // 
            // dropItem
            // 
            this.dropItem.Index = 0;
            this.dropItem.Text = "Image Drop";
            this.dropItem.Click += new System.EventHandler(this.dropItem_Click);
            // 
            // menuItem10
            // 
            this.menuItem10.Index = 1;
            this.menuItem10.Text = "-";
            // 
            // saveItem
            // 
            this.saveItem.Index = 2;
            this.saveItem.Shortcut = System.Windows.Forms.Shortcut.CtrlS;
            this.saveItem.Text = "Save";
            this.saveItem.Click += new System.EventHandler(this.saveItem_Click);
            // 
            // titleEditItem
            // 
            this.titleEditItem.Index = 3;
            this.titleEditItem.Shortcut = System.Windows.Forms.Shortcut.CtrlE;
            this.titleEditItem.Text = "Details";
            this.titleEditItem.Click += new System.EventHandler(this.titleEditItem_Click);
            // 
            // cancelItem
            // 
            this.cancelItem.Index = 4;
            this.cancelItem.Text = "Cancel";
            this.cancelItem.Click += new System.EventHandler(this.cancelItem_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 2;
            this.menuItem3.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuAlwaysTop,
            this.menuItem6,
            this.menuTitleItem,
            this.menuFolderItem,
            this.menuDiscItem});
            this.menuItem3.Text = "Window";
            // 
            // menuAlwaysTop
            // 
            this.menuAlwaysTop.Index = 0;
            this.menuAlwaysTop.Text = "Always on Top";
            this.menuAlwaysTop.Click += new System.EventHandler(this.menuAlwaysTop_Click);
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 1;
            this.menuItem6.Text = "-";
            // 
            // menuTitleItem
            // 
            this.menuTitleItem.Index = 2;
            this.menuTitleItem.Shortcut = System.Windows.Forms.Shortcut.Ctrl1;
            this.menuTitleItem.Text = "Title";
            this.menuTitleItem.Click += new System.EventHandler(this.menuTitleItem_Click);
            // 
            // menuFolderItem
            // 
            this.menuFolderItem.Index = 3;
            this.menuFolderItem.Shortcut = System.Windows.Forms.Shortcut.Ctrl2;
            this.menuFolderItem.Text = "Folder";
            this.menuFolderItem.Click += new System.EventHandler(this.menuFolderItem_Click);
            // 
            // menuDiscItem
            // 
            this.menuDiscItem.Index = 4;
            this.menuDiscItem.Shortcut = System.Windows.Forms.Shortcut.Ctrl3;
            this.menuDiscItem.Text = "Disc";
            this.menuDiscItem.Click += new System.EventHandler(this.menuDiscItem_Click);
            // 
            // menuItem7
            // 
            this.menuItem7.Index = 3;
            this.menuItem7.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem9,
            this.menuItem8});
            this.menuItem7.Text = "Help";
            // 
            // menuItem9
            // 
            this.menuItem9.Index = 0;
            this.menuItem9.Text = "-";
            // 
            // menuItem8
            // 
            this.menuItem8.Index = 1;
            this.menuItem8.Text = "About";
            this.menuItem8.Click += new System.EventHandler(this.menuItem8_Click);
            // 
            // bPanel
            // 
            this.bPanel.BackColor = System.Drawing.Color.Transparent;
            this.bPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bPanel.Location = new System.Drawing.Point(0, 0);
            this.bPanel.Name = "bPanel";
            this.bPanel.Size = new System.Drawing.Size(534, 376);
            this.bPanel.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::LFI.Properties.Resources.bannerOrig;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(534, 399);
            this.Controls.Add(this.bPanel);
            this.Controls.Add(this.statusStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Menu = this.mainMenu1;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "LFI";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.Move += new System.EventHandler(this.MainForm_Move);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuAddItem;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.MenuItem titleEditItem;
        private System.Windows.Forms.MenuItem saveItem;
        private System.Windows.Forms.MenuItem cancelItem;
        private System.Windows.Forms.ToolStripProgressBar progBar;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuTitleItem;
        private System.Windows.Forms.MenuItem menuFolderItem;
        private System.Windows.Forms.MenuItem menuDiscItem;
        private System.Windows.Forms.MenuItem menuAlwaysTop;
        private System.Windows.Forms.MenuItem menuItem6;
        private System.Windows.Forms.MenuItem menuItem7;
        private System.Windows.Forms.MenuItem menuItem9;
        private System.Windows.Forms.MenuItem menuItem8;
        private System.Windows.Forms.MenuItem menuItem10;
        private BPanel bPanel;
        private System.Windows.Forms.MenuItem dropItem;
        private System.Windows.Forms.ToolStripStatusLabel slblSize;
        private System.Windows.Forms.ToolStripStatusLabel slblItems;
        private System.Windows.Forms.ToolStripDropDownButton toolstripLanguage;
        private System.Windows.Forms.ToolStripMenuItem toolstripJPN;
        private System.Windows.Forms.ToolStripMenuItem toolstripENG;
        private System.Windows.Forms.ToolStripStatusLabel slblItemSize;


    }
}