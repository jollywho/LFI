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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gvTitles = new System.Windows.Forms.DataGridView();
            this.contextMenuDisc = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.titleInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuItemDisc = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvTitles)).BeginInit();
            this.contextMenuDisc.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.Black;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(126)))), ((int)(((byte)(57)))));
            this.txtSearch.Location = new System.Drawing.Point(6, 19);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(169, 24);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(126)))), ((int)(((byte)(57)))));
            this.groupBox1.Location = new System.Drawing.Point(3, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 53);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // gvTitles
            // 
            this.gvTitles.AllowUserToAddRows = false;
            this.gvTitles.AllowUserToDeleteRows = false;
            this.gvTitles.AllowUserToResizeColumns = false;
            this.gvTitles.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(126)))), ((int)(((byte)(57)))));
            this.gvTitles.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gvTitles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvTitles.BackgroundColor = System.Drawing.Color.Black;
            this.gvTitles.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gvTitles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gvTitles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvTitles.ColumnHeadersVisible = false;
            this.gvTitles.ContextMenuStrip = this.contextMenuDisc;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(126)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(143)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvTitles.DefaultCellStyle = dataGridViewCellStyle2;
            this.gvTitles.Location = new System.Drawing.Point(2, 59);
            this.gvTitles.MultiSelect = false;
            this.gvTitles.Name = "gvTitles";
            this.gvTitles.ReadOnly = true;
            this.gvTitles.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gvTitles.RowHeadersVisible = false;
            this.gvTitles.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gvTitles.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gvTitles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gvTitles.Size = new System.Drawing.Size(180, 558);
            this.gvTitles.StandardTab = true;
            this.gvTitles.TabIndex = 1;
            this.gvTitles.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvTitles_CellMouseEnter);
            this.gvTitles.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvTitles_RowEnter);
            this.gvTitles.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gvTitles_KeyDown);
            // 
            // contextMenuDisc
            // 
            this.contextMenuDisc.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.titleInfoToolStripMenuItem,
            this.contextMenuItemDisc,
            this.toolStripMenuItem1,
            this.deleteToolStripMenuItem});
            this.contextMenuDisc.Name = "contextMenuDisc";
            this.contextMenuDisc.Size = new System.Drawing.Size(136, 76);
            this.contextMenuDisc.Opened += new System.EventHandler(this.contextMenuDisc_Opened);
            // 
            // titleInfoToolStripMenuItem
            // 
            this.titleInfoToolStripMenuItem.Name = "titleInfoToolStripMenuItem";
            this.titleInfoToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.titleInfoToolStripMenuItem.Text = "Title Info";
            this.titleInfoToolStripMenuItem.Click += new System.EventHandler(this.titleInfoToolStripMenuItem_Click);
            // 
            // contextMenuItemDisc
            // 
            this.contextMenuItemDisc.Name = "contextMenuItemDisc";
            this.contextMenuItemDisc.Size = new System.Drawing.Size(135, 22);
            this.contextMenuItemDisc.Text = "Find Disc(s)";
            this.contextMenuItemDisc.Click += new System.EventHandler(this.contextMenuItemDisc_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(132, 6);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(126)))), ((int)(((byte)(57)))));
            this.lblTitle.Location = new System.Drawing.Point(184, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(340, 56);
            this.lblTitle.TabIndex = 20;
            // 
            // panelMain
            // 
            this.panelMain.Location = new System.Drawing.Point(184, 59);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(340, 558);
            this.panelMain.TabIndex = 21;
            // 
            // mainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.gvTitles);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelMain);
            this.Name = "mainView";
            this.Size = new System.Drawing.Size(524, 617);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvTitles)).EndInit();
            this.contextMenuDisc.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView gvTitles;
        private System.Windows.Forms.ContextMenuStrip contextMenuDisc;
        private System.Windows.Forms.ToolStripMenuItem contextMenuItemDisc;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.ToolStripMenuItem titleInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}
