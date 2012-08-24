namespace LFI
{
    partial class folderView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.gvFiles = new System.Windows.Forms.DataGridView();
            this.check = new System.Windows.Forms.DataGridViewImageColumn();
            this.Text = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hidden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuFile = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ddUrl = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radCheckItem = new System.Windows.Forms.RadioButton();
            this.btnCheckCRC = new System.Windows.Forms.Button();
            this.btnAddCRC = new System.Windows.Forms.Button();
            this.radCheckAll = new System.Windows.Forms.RadioButton();
            this.btnShowDiv = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lstDivs = new System.Windows.Forms.ListBox();
            this.btnDivide = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnTestReg = new System.Windows.Forms.Button();
            this.radFormatReg = new System.Windows.Forms.RadioButton();
            this.radFormatNumXNum = new System.Windows.Forms.RadioButton();
            this.radFormatS_Num_E_Num = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.gvFiles)).BeginInit();
            this.contextMenuFile.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(126)))), ((int)(((byte)(57)))));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Folder View";
            // 
            // gvFiles
            // 
            this.gvFiles.AllowUserToAddRows = false;
            this.gvFiles.AllowUserToDeleteRows = false;
            this.gvFiles.AllowUserToResizeColumns = false;
            this.gvFiles.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(126)))), ((int)(((byte)(57)))));
            this.gvFiles.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gvFiles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvFiles.BackgroundColor = System.Drawing.Color.White;
            this.gvFiles.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gvFiles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gvFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvFiles.ColumnHeadersVisible = false;
            this.gvFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.check,
            this.Text,
            this.Hidden});
            this.gvFiles.ContextMenuStrip = this.contextMenuFile;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(126)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(143)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvFiles.DefaultCellStyle = dataGridViewCellStyle7;
            this.gvFiles.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gvFiles.Location = new System.Drawing.Point(0, 203);
            this.gvFiles.MultiSelect = false;
            this.gvFiles.Name = "gvFiles";
            this.gvFiles.ReadOnly = true;
            this.gvFiles.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gvFiles.RowHeadersVisible = false;
            this.gvFiles.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gvFiles.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gvFiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvFiles.Size = new System.Drawing.Size(533, 427);
            this.gvFiles.StandardTab = true;
            this.gvFiles.TabIndex = 0;
            this.gvFiles.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvFiles_CellMouseEnter);
            this.gvFiles.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvFiles_RowEnter);
            // 
            // check
            // 
            this.check.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.NullValue = null;
            this.check.DefaultCellStyle = dataGridViewCellStyle3;
            this.check.FillWeight = 10F;
            this.check.HeaderText = "check";
            this.check.Name = "check";
            this.check.ReadOnly = true;
            this.check.Width = 5;
            // 
            // Text
            // 
            this.Text.HeaderText = "Text";
            this.Text.Name = "Text";
            this.Text.ReadOnly = true;
            // 
            // Hidden
            // 
            this.Hidden.HeaderText = "Hidden";
            this.Hidden.Name = "Hidden";
            this.Hidden.ReadOnly = true;
            this.Hidden.Visible = false;
            // 
            // contextMenuFile
            // 
            this.contextMenuFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.contextMenuFile.Name = "contextMenuFile";
            this.contextMenuFile.Size = new System.Drawing.Size(104, 26);
            this.contextMenuFile.Opened += new System.EventHandler(this.contextMenuFile_Opened);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // ddUrl
            // 
            this.ddUrl.FormattingEnabled = true;
            this.ddUrl.Location = new System.Drawing.Point(25, 25);
            this.ddUrl.Name = "ddUrl";
            this.ddUrl.Size = new System.Drawing.Size(499, 21);
            this.ddUrl.TabIndex = 3;
            this.ddUrl.SelectedValueChanged += new System.EventHandler(this.ddUrl_SelectedValueChanged);
            this.ddUrl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ddUrl_KeyDown);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::LFI.Properties.Resources.border;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnShowDiv);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.lstDivs);
            this.panel1.Controls.Add(this.btnDivide);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblSize);
            this.panel1.Location = new System.Drawing.Point(107, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 135);
            this.panel1.TabIndex = 4;
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = global::LFI.Properties.Resources.divide;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.Transparent;
            this.btnCancel.Location = new System.Drawing.Point(276, 90);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(32, 32);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            this.btnCancel.MouseEnter += new System.EventHandler(this.btnBack_MouseEnter);
            this.btnCancel.MouseLeave += new System.EventHandler(this.btnBack_MouseLeave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radCheckItem);
            this.groupBox1.Controls.Add(this.btnCheckCRC);
            this.groupBox1.Controls.Add(this.btnAddCRC);
            this.groupBox1.Controls.Add(this.radCheckAll);
            this.groupBox1.Location = new System.Drawing.Point(102, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(152, 60);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Checksum";
            // 
            // radCheckItem
            // 
            this.radCheckItem.AutoSize = true;
            this.radCheckItem.Checked = true;
            this.radCheckItem.Location = new System.Drawing.Point(79, 15);
            this.radCheckItem.Name = "radCheckItem";
            this.radCheckItem.Size = new System.Drawing.Size(67, 17);
            this.radCheckItem.TabIndex = 2;
            this.radCheckItem.TabStop = true;
            this.radCheckItem.Text = "Selected";
            this.radCheckItem.UseVisualStyleBackColor = true;
            // 
            // btnCheckCRC
            // 
            this.btnCheckCRC.BackgroundImage = global::LFI.Properties.Resources.checksum;
            this.btnCheckCRC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCheckCRC.FlatAppearance.BorderSize = 0;
            this.btnCheckCRC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckCRC.ForeColor = System.Drawing.Color.Transparent;
            this.btnCheckCRC.Location = new System.Drawing.Point(44, 15);
            this.btnCheckCRC.Name = "btnCheckCRC";
            this.btnCheckCRC.Size = new System.Drawing.Size(32, 32);
            this.btnCheckCRC.TabIndex = 1;
            this.btnCheckCRC.UseVisualStyleBackColor = true;
            this.btnCheckCRC.Click += new System.EventHandler(this.btnCheckCRC_Click);
            this.btnCheckCRC.MouseEnter += new System.EventHandler(this.btnBack_MouseEnter);
            this.btnCheckCRC.MouseLeave += new System.EventHandler(this.btnBack_MouseLeave);
            // 
            // btnAddCRC
            // 
            this.btnAddCRC.BackgroundImage = global::LFI.Properties.Resources.addchecksum;
            this.btnAddCRC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddCRC.FlatAppearance.BorderSize = 0;
            this.btnAddCRC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCRC.ForeColor = System.Drawing.Color.Transparent;
            this.btnAddCRC.Location = new System.Drawing.Point(6, 15);
            this.btnAddCRC.Name = "btnAddCRC";
            this.btnAddCRC.Size = new System.Drawing.Size(32, 32);
            this.btnAddCRC.TabIndex = 0;
            this.btnAddCRC.UseVisualStyleBackColor = true;
            this.btnAddCRC.Click += new System.EventHandler(this.btnAddCRC_Click);
            this.btnAddCRC.MouseEnter += new System.EventHandler(this.btnBack_MouseEnter);
            this.btnAddCRC.MouseLeave += new System.EventHandler(this.btnBack_MouseLeave);
            // 
            // radCheckAll
            // 
            this.radCheckAll.AutoSize = true;
            this.radCheckAll.Location = new System.Drawing.Point(79, 30);
            this.radCheckAll.Name = "radCheckAll";
            this.radCheckAll.Size = new System.Drawing.Size(36, 17);
            this.radCheckAll.TabIndex = 3;
            this.radCheckAll.Text = "All";
            this.radCheckAll.UseVisualStyleBackColor = true;
            // 
            // btnShowDiv
            // 
            this.btnShowDiv.BackgroundImage = global::LFI.Properties.Resources.showdiv;
            this.btnShowDiv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShowDiv.FlatAppearance.BorderSize = 0;
            this.btnShowDiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowDiv.ForeColor = System.Drawing.Color.Transparent;
            this.btnShowDiv.Location = new System.Drawing.Point(276, 14);
            this.btnShowDiv.Name = "btnShowDiv";
            this.btnShowDiv.Size = new System.Drawing.Size(32, 32);
            this.btnShowDiv.TabIndex = 4;
            this.btnShowDiv.UseVisualStyleBackColor = true;
            this.btnShowDiv.Click += new System.EventHandler(this.btnShowDiv_Click);
            this.btnShowDiv.MouseEnter += new System.EventHandler(this.btnBack_MouseEnter);
            this.btnShowDiv.MouseLeave += new System.EventHandler(this.btnBack_MouseLeave);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = global::LFI.Properties.Resources.clear;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.Color.Transparent;
            this.btnRefresh.Location = new System.Drawing.Point(224, 24);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(24, 24);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            this.btnRefresh.MouseEnter += new System.EventHandler(this.btnBack_MouseEnter);
            this.btnRefresh.MouseLeave += new System.EventHandler(this.btnBack_MouseLeave);
            // 
            // lstDivs
            // 
            this.lstDivs.BackColor = System.Drawing.Color.White;
            this.lstDivs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstDivs.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDivs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(126)))), ((int)(((byte)(57)))));
            this.lstDivs.FormattingEnabled = true;
            this.lstDivs.HorizontalScrollbar = true;
            this.lstDivs.ItemHeight = 17;
            this.lstDivs.Location = new System.Drawing.Point(7, 8);
            this.lstDivs.Name = "lstDivs";
            this.lstDivs.ScrollAlwaysVisible = true;
            this.lstDivs.Size = new System.Drawing.Size(89, 119);
            this.lstDivs.TabIndex = 0;
            this.lstDivs.Click += new System.EventHandler(this.lstDivs_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.BackColor = System.Drawing.Color.Transparent;
            this.btnDivide.BackgroundImage = global::LFI.Properties.Resources.arrow_divide;
            this.btnDivide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDivide.Enabled = false;
            this.btnDivide.FlatAppearance.BorderSize = 0;
            this.btnDivide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDivide.ForeColor = System.Drawing.Color.Transparent;
            this.btnDivide.Location = new System.Drawing.Point(276, 52);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(32, 32);
            this.btnDivide.TabIndex = 5;
            this.btnDivide.UseVisualStyleBackColor = false;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            this.btnDivide.MouseEnter += new System.EventHandler(this.btnBack_MouseEnter);
            this.btnDivide.MouseLeave += new System.EventHandler(this.btnBack_MouseLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(126)))), ((int)(((byte)(57)))));
            this.label3.Location = new System.Drawing.Point(102, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Size";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(126)))), ((int)(((byte)(57)))));
            this.lblSize.Location = new System.Drawing.Point(102, 24);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(53, 13);
            this.lblSize.TabIndex = 2;
            this.lblSize.Text = "0.00 GB";
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = global::LFI.Properties.Resources.back;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.Color.Transparent;
            this.btnBack.Location = new System.Drawing.Point(1, 25);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(21, 21);
            this.btnBack.TabIndex = 2;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnBack.MouseEnter += new System.EventHandler(this.btnBack_MouseEnter);
            this.btnBack.MouseLeave += new System.EventHandler(this.btnBack_MouseLeave);
            // 
            // btnTestReg
            // 
            this.btnTestReg.Location = new System.Drawing.Point(19, 130);
            this.btnTestReg.Name = "btnTestReg";
            this.btnTestReg.Size = new System.Drawing.Size(75, 23);
            this.btnTestReg.TabIndex = 5;
            this.btnTestReg.Text = "Scan";
            this.btnTestReg.UseVisualStyleBackColor = true;
            this.btnTestReg.Click += new System.EventHandler(this.btnTestReg_Click);
            // 
            // radFormatReg
            // 
            this.radFormatReg.AutoSize = true;
            this.radFormatReg.Checked = true;
            this.radFormatReg.Location = new System.Drawing.Point(9, 58);
            this.radFormatReg.Name = "radFormatReg";
            this.radFormatReg.Size = new System.Drawing.Size(45, 17);
            this.radFormatReg.TabIndex = 6;
            this.radFormatReg.TabStop = true;
            this.radFormatReg.Text = " ## ";
            this.radFormatReg.UseVisualStyleBackColor = true;
            // 
            // radFormatNumXNum
            // 
            this.radFormatNumXNum.AutoSize = true;
            this.radFormatNumXNum.Location = new System.Drawing.Point(9, 80);
            this.radFormatNumXNum.Name = "radFormatNumXNum";
            this.radFormatNumXNum.Size = new System.Drawing.Size(64, 17);
            this.radFormatNumXNum.TabIndex = 7;
            this.radFormatNumXNum.Text = "## x ##";
            this.radFormatNumXNum.UseVisualStyleBackColor = true;
            // 
            // radFormatS_Num_E_Num
            // 
            this.radFormatS_Num_E_Num.AutoSize = true;
            this.radFormatS_Num_E_Num.Location = new System.Drawing.Point(9, 103);
            this.radFormatS_Num_E_Num.Name = "radFormatS_Num_E_Num";
            this.radFormatS_Num_E_Num.Size = new System.Drawing.Size(64, 17);
            this.radFormatS_Num_E_Num.TabIndex = 8;
            this.radFormatS_Num_E_Num.Text = "s##e##";
            this.radFormatS_Num_E_Num.UseVisualStyleBackColor = true;
            // 
            // folderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.radFormatS_Num_E_Num);
            this.Controls.Add(this.radFormatNumXNum);
            this.Controls.Add(this.radFormatReg);
            this.Controls.Add(this.btnTestReg);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.gvFiles);
            this.Controls.Add(this.ddUrl);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "folderView";
            this.Size = new System.Drawing.Size(533, 630);
            ((System.ComponentModel.ISupportInitialize)(this.gvFiles)).EndInit();
            this.contextMenuFile.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstDivs;
        private System.Windows.Forms.DataGridView gvFiles;
        private System.Windows.Forms.ComboBox ddUrl;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAddCRC;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnCheckCRC;
        private System.Windows.Forms.Button btnShowDiv;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radCheckItem;
        private System.Windows.Forms.RadioButton radCheckAll;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewImageColumn check;
        private System.Windows.Forms.DataGridViewTextBoxColumn Text;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hidden;
        private System.Windows.Forms.ContextMenuStrip contextMenuFile;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.Button btnTestReg;
        private System.Windows.Forms.RadioButton radFormatReg;
        private System.Windows.Forms.RadioButton radFormatNumXNum;
        private System.Windows.Forms.RadioButton radFormatS_Num_E_Num;
    }
}
