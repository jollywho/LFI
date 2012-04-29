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
            this.statusStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.progBar = new System.Windows.Forms.ToolStripProgressBar();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuAddItem = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.saveItem = new System.Windows.Forms.MenuItem();
            this.titleEditItem = new System.Windows.Forms.MenuItem();
            this.cancelItem = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuTitleItem = new System.Windows.Forms.MenuItem();
            this.menuFolderItem = new System.Windows.Forms.MenuItem();
            this.menuDiscItem = new System.Windows.Forms.MenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStripLabel,
            this.progBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 640);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(524, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusStripLabel
            // 
            this.statusStripLabel.Name = "statusStripLabel";
            this.statusStripLabel.Size = new System.Drawing.Size(27, 17);
            this.statusStripLabel.Text = "JPN";
            this.statusStripLabel.Click += new System.EventHandler(this.statusStripLabel_Click);
            // 
            // progBar
            // 
            this.progBar.MarqueeAnimationSpeed = 5;
            this.progBar.Name = "progBar";
            this.progBar.Size = new System.Drawing.Size(100, 16);
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem2,
            this.menuItem3});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuAddItem,
            this.menuItem4,
            this.menuItem5});
            this.menuItem1.Text = "File";
            this.menuItem1.Popup += new System.EventHandler(this.menuItem1_Popup);
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
            this.saveItem,
            this.titleEditItem,
            this.cancelItem});
            this.menuItem2.Text = "Edit";
            this.menuItem2.Popup += new System.EventHandler(this.menuItem2_Popup);
            // 
            // saveItem
            // 
            this.saveItem.Index = 0;
            this.saveItem.Shortcut = System.Windows.Forms.Shortcut.CtrlS;
            this.saveItem.Text = "Save";
            this.saveItem.Click += new System.EventHandler(this.saveItem_Click);
            // 
            // titleEditItem
            // 
            this.titleEditItem.Index = 1;
            this.titleEditItem.Shortcut = System.Windows.Forms.Shortcut.CtrlE;
            this.titleEditItem.Text = "Details";
            this.titleEditItem.Click += new System.EventHandler(this.titleEditItem_Click);
            // 
            // cancelItem
            // 
            this.cancelItem.Index = 2;
            this.cancelItem.Shortcut = System.Windows.Forms.Shortcut.CtrlC;
            this.cancelItem.Text = "Cancel";
            this.cancelItem.Click += new System.EventHandler(this.cancelItem_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 2;
            this.menuItem3.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuTitleItem,
            this.menuFolderItem,
            this.menuDiscItem});
            this.menuItem3.Text = "Window";
            // 
            // menuTitleItem
            // 
            this.menuTitleItem.Index = 0;
            this.menuTitleItem.Shortcut = System.Windows.Forms.Shortcut.Ctrl1;
            this.menuTitleItem.Text = "Title";
            this.menuTitleItem.Click += new System.EventHandler(this.menuTitleItem_Click);
            // 
            // menuFolderItem
            // 
            this.menuFolderItem.Index = 1;
            this.menuFolderItem.Shortcut = System.Windows.Forms.Shortcut.Ctrl2;
            this.menuFolderItem.Text = "Folder";
            this.menuFolderItem.Click += new System.EventHandler(this.menuFolderItem_Click);
            // 
            // menuDiscItem
            // 
            this.menuDiscItem.Index = 2;
            this.menuDiscItem.Shortcut = System.Windows.Forms.Shortcut.Ctrl3;
            this.menuDiscItem.Text = "Disc";
            this.menuDiscItem.Click += new System.EventHandler(this.menuDiscItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 620);
            this.panel1.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::LFI.Properties.Resources.bannerOrig;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(524, 662);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(540, 700);
            this.Menu = this.mainMenu1;
            this.MinimumSize = new System.Drawing.Size(540, 700);
            this.Name = "MainForm";
            this.Text = "LFI 0.2.9";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusStripLabel;
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuTitleItem;
        private System.Windows.Forms.MenuItem menuFolderItem;
        private System.Windows.Forms.MenuItem menuDiscItem;


    }
}