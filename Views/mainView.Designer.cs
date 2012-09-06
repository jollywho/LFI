namespace LFI
{
    partial class mainView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.contextMenuDisc = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.titleInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuItemDisc = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gvTitles = new System.Windows.Forms.DataGridView();
            this.bPanel1 = new LFI.BPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelMain = new LFI.BPanel();
            this.txtSearch = new LFI.RTextBox();
            this.contextMenuDisc.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvTitles)).BeginInit();
            this.bPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuDisc
            // 
            this.contextMenuDisc.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.titleInfoToolStripMenuItem,
            this.contextMenuItemDisc,
            this.toolStripMenuItem1,
            this.deleteToolStripMenuItem});
            this.contextMenuDisc.Name = "contextMenuDisc";
            this.contextMenuDisc.Size = new System.Drawing.Size(110, 76);
            this.contextMenuDisc.Opened += new System.EventHandler(this.contextMenuDisc_Opened);
            // 
            // titleInfoToolStripMenuItem
            // 
            this.titleInfoToolStripMenuItem.Name = "titleInfoToolStripMenuItem";
            this.titleInfoToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.titleInfoToolStripMenuItem.Text = "Info";
            this.titleInfoToolStripMenuItem.Click += new System.EventHandler(this.titleInfoToolStripMenuItem_Click);
            // 
            // contextMenuItemDisc
            // 
            this.contextMenuItemDisc.Name = "contextMenuItemDisc";
            this.contextMenuItemDisc.Size = new System.Drawing.Size(109, 22);
            this.contextMenuItemDisc.Text = "Disc(s)";
            this.contextMenuItemDisc.Click += new System.EventHandler(this.discInfoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(106, 6);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::LFI.Properties.Resources.borderBigg;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.gvTitles);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10, 20, 10, 0);
            this.panel1.Size = new System.Drawing.Size(179, 630);
            this.panel1.TabIndex = 0;
            // 
            // gvTitles
            // 
            this.gvTitles.AllowUserToAddRows = false;
            this.gvTitles.AllowUserToDeleteRows = false;
            this.gvTitles.AllowUserToResizeColumns = false;
            this.gvTitles.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.gvTitles.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gvTitles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvTitles.BackgroundColor = System.Drawing.Color.White;
            this.gvTitles.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gvTitles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gvTitles.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.gvTitles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvTitles.ColumnHeadersVisible = false;
            this.gvTitles.ContextMenuStrip = this.contextMenuDisc;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvTitles.DefaultCellStyle = dataGridViewCellStyle2;
            this.gvTitles.Location = new System.Drawing.Point(0, 59);
            this.gvTitles.MultiSelect = false;
            this.gvTitles.Name = "gvTitles";
            this.gvTitles.ReadOnly = true;
            this.gvTitles.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gvTitles.RowHeadersVisible = false;
            this.gvTitles.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gvTitles.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gvTitles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvTitles.Size = new System.Drawing.Size(180, 570);
            this.gvTitles.StandardTab = true;
            this.gvTitles.TabIndex = 1;
            this.gvTitles.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvTitles_CellMouseEnter);
            this.gvTitles.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvTitles_RowEnter);
            this.gvTitles.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gvTitles_KeyDown);
            this.gvTitles.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gvTitles_KeyPress);
            // 
            // bPanel1
            // 
            this.bPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bPanel1.Controls.Add(this.lblTitle);
            this.bPanel1.Location = new System.Drawing.Point(185, 0);
            this.bPanel1.Name = "bPanel1";
            this.bPanel1.Size = new System.Drawing.Size(349, 54);
            this.bPanel1.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(349, 54);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.Transparent;
            this.panelMain.Location = new System.Drawing.Point(184, 60);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(350, 570);
            this.panelMain.TabIndex = 2;
            // 
            // txtSearch
            // 
            this.txtSearch.Cue = "<Search Here>";
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSearch.Location = new System.Drawing.Point(10, 20);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Restriction = LFI.RTextBox.RestrictionType.None;
            this.txtSearch.Size = new System.Drawing.Size(159, 20);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // mainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.bPanel1);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "mainView";
            this.Size = new System.Drawing.Size(534, 630);
            this.contextMenuDisc.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvTitles)).EndInit();
            this.bPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuDisc;
        private System.Windows.Forms.ToolStripMenuItem contextMenuItemDisc;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ToolStripMenuItem titleInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView gvTitles;
        private BPanel panelMain;
        private RTextBox txtSearch;
        private BPanel bPanel1;
    }
}
