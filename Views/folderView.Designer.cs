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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(folderView));
            this.gvFiles = new System.Windows.Forms.DataGridView();
            this.gvFiles_Check = new System.Windows.Forms.DataGridViewImageColumn();
            this.gvFiles_Icon = new System.Windows.Forms.DataGridViewImageColumn();
            this.gvFiles_File = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvFiles_Hidden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvFiles_Ep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnShowDiv = new System.Windows.Forms.ToolStripButton();
            this.btnDivide = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAddCRC = new System.Windows.Forms.ToolStripButton();
            this.btnCheckCRC = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.ddUrl = new System.Windows.Forms.ToolStripComboBox();
            this.btnBack = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lstDivs = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ddFormat = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTestFormats = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radCheckItem = new System.Windows.Forms.RadioButton();
            this.radCheckAll = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvFiles)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
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
            this.gvFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gvFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gvFiles_Check,
            this.gvFiles_Icon,
            this.gvFiles_File,
            this.gvFiles_Hidden,
            this.gvFiles_Ep});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(126)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(143)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvFiles.DefaultCellStyle = dataGridViewCellStyle4;
            this.gvFiles.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gvFiles.Location = new System.Drawing.Point(0, 155);
            this.gvFiles.MultiSelect = false;
            this.gvFiles.Name = "gvFiles";
            this.gvFiles.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gvFiles.RowHeadersVisible = false;
            this.gvFiles.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gvFiles.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gvFiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvFiles.Size = new System.Drawing.Size(533, 475);
            this.gvFiles.StandardTab = true;
            this.gvFiles.TabIndex = 0;
            this.gvFiles.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvFiles_CellDoubleClick);
            this.gvFiles.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvFiles_CellMouseEnter);
            this.gvFiles.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvFiles_RowEnter);
            // 
            // gvFiles_Check
            // 
            this.gvFiles_Check.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.NullValue = null;
            this.gvFiles_Check.DefaultCellStyle = dataGridViewCellStyle2;
            this.gvFiles_Check.FillWeight = 10F;
            this.gvFiles_Check.HeaderText = "";
            this.gvFiles_Check.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.gvFiles_Check.Name = "gvFiles_Check";
            this.gvFiles_Check.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gvFiles_Check.Width = 5;
            // 
            // gvFiles_Icon
            // 
            this.gvFiles_Icon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.gvFiles_Icon.DefaultCellStyle = dataGridViewCellStyle3;
            this.gvFiles_Icon.FillWeight = 10F;
            this.gvFiles_Icon.HeaderText = "";
            this.gvFiles_Icon.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.gvFiles_Icon.Name = "gvFiles_Icon";
            this.gvFiles_Icon.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gvFiles_Icon.Width = 5;
            // 
            // gvFiles_File
            // 
            this.gvFiles_File.FillWeight = 100.2273F;
            this.gvFiles_File.HeaderText = "File";
            this.gvFiles_File.Name = "gvFiles_File";
            this.gvFiles_File.ReadOnly = true;
            this.gvFiles_File.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // gvFiles_Hidden
            // 
            this.gvFiles_Hidden.HeaderText = "Hidden";
            this.gvFiles_Hidden.Name = "gvFiles_Hidden";
            this.gvFiles_Hidden.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gvFiles_Hidden.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.gvFiles_Hidden.Visible = false;
            // 
            // gvFiles_Ep
            // 
            this.gvFiles_Ep.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.gvFiles_Ep.FillWeight = 39.77273F;
            this.gvFiles_Ep.HeaderText = "Ep";
            this.gvFiles_Ep.MinimumWidth = 50;
            this.gvFiles_Ep.Name = "gvFiles_Ep";
            this.gvFiles_Ep.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gvFiles_Ep.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.gvFiles_Ep.Width = 50;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRefresh,
            this.btnCancel,
            this.toolStripSeparator5,
            this.btnShowDiv,
            this.btnDivide,
            this.toolStripSeparator6,
            this.btnAddCRC,
            this.btnCheckCRC,
            this.toolStripSeparator4,
            this.ddUrl,
            this.btnBack});
            this.toolStrip1.Location = new System.Drawing.Point(1, 0);
            this.toolStrip1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(533, 25);
            this.toolStrip1.TabIndex = 33;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnRefresh
            // 
            this.btnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRefresh.Image = global::LFI.Properties.Resources.refresh;
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(23, 22);
            this.btnRefresh.Text = "toolStripButton1";
            this.btnRefresh.ToolTipText = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(23, 22);
            this.btnCancel.Text = "toolStripButton2";
            this.btnCancel.ToolTipText = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // btnShowDiv
            // 
            this.btnShowDiv.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnShowDiv.Image = global::LFI.Properties.Resources.showdiv;
            this.btnShowDiv.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnShowDiv.Name = "btnShowDiv";
            this.btnShowDiv.Size = new System.Drawing.Size(23, 22);
            this.btnShowDiv.Text = "toolStripButton3";
            this.btnShowDiv.ToolTipText = "Show Divisions";
            this.btnShowDiv.Click += new System.EventHandler(this.btnShowDiv_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDivide.Image = global::LFI.Properties.Resources.arrow_divide;
            this.btnDivide.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(23, 22);
            this.btnDivide.Text = "toolStripButton4";
            this.btnDivide.ToolTipText = "Commit Divisions";
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // btnAddCRC
            // 
            this.btnAddCRC.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddCRC.Image = global::LFI.Properties.Resources.checksum_add;
            this.btnAddCRC.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddCRC.Name = "btnAddCRC";
            this.btnAddCRC.Size = new System.Drawing.Size(23, 22);
            this.btnAddCRC.Text = "toolStripButton5";
            this.btnAddCRC.ToolTipText = "Add CRC";
            this.btnAddCRC.Click += new System.EventHandler(this.btnAddCRC_Click);
            // 
            // btnCheckCRC
            // 
            this.btnCheckCRC.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCheckCRC.Image = global::LFI.Properties.Resources.checksum_check;
            this.btnCheckCRC.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCheckCRC.Name = "btnCheckCRC";
            this.btnCheckCRC.Size = new System.Drawing.Size(23, 22);
            this.btnCheckCRC.Text = "toolStripButton6";
            this.btnCheckCRC.ToolTipText = "Check CRC";
            this.btnCheckCRC.Click += new System.EventHandler(this.btnCheckCRC_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // ddUrl
            // 
            this.ddUrl.BackColor = System.Drawing.Color.White;
            this.ddUrl.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ddUrl.Name = "ddUrl";
            this.ddUrl.Size = new System.Drawing.Size(350, 25);
            // 
            // btnBack
            // 
            this.btnBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBack.Image = global::LFI.Properties.Resources.back;
            this.btnBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(23, 22);
            this.btnBack.Text = "toolStripButton7";
            this.btnBack.ToolTipText = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lstDivs);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(126)))), ((int)(((byte)(57)))));
            this.groupBox4.Location = new System.Drawing.Point(214, 32);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(79, 119);
            this.groupBox4.TabIndex = 36;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Divisions";
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
            this.lstDivs.Location = new System.Drawing.Point(6, 28);
            this.lstDivs.Name = "lstDivs";
            this.lstDivs.ScrollAlwaysVisible = true;
            this.lstDivs.Size = new System.Drawing.Size(63, 85);
            this.lstDivs.TabIndex = 7;
            this.lstDivs.Click += new System.EventHandler(this.lstDivs_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.ddFormat);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.btnTestFormats);
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(126)))), ((int)(((byte)(57)))));
            this.groupBox3.Location = new System.Drawing.Point(3, 32);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(205, 119);
            this.groupBox3.TabIndex = 35;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Reformat";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(126)))), ((int)(((byte)(57)))));
            this.label1.Location = new System.Drawing.Point(6, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Format:";
            // 
            // ddFormat
            // 
            this.ddFormat.FormattingEnabled = true;
            this.ddFormat.Location = new System.Drawing.Point(54, 84);
            this.ddFormat.Name = "ddFormat";
            this.ddFormat.Size = new System.Drawing.Size(93, 21);
            this.ddFormat.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(126)))), ((int)(((byte)(57)))));
            this.label5.Location = new System.Drawing.Point(12, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Suffix:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(126)))), ((int)(((byte)(57)))));
            this.label4.Location = new System.Drawing.Point(19, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(126)))), ((int)(((byte)(57)))));
            this.label2.Location = new System.Drawing.Point(12, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Prefix:";
            // 
            // btnTestFormats
            // 
            this.btnTestFormats.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTestFormats.FlatAppearance.BorderSize = 0;
            this.btnTestFormats.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnTestFormats.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestFormats.ForeColor = System.Drawing.Color.Transparent;
            this.btnTestFormats.Location = new System.Drawing.Point(153, 86);
            this.btnTestFormats.Name = "btnTestFormats";
            this.btnTestFormats.Size = new System.Drawing.Size(45, 19);
            this.btnTestFormats.TabIndex = 3;
            this.btnTestFormats.Text = "Run";
            this.btnTestFormats.UseVisualStyleBackColor = true;
            this.btnTestFormats.Click += new System.EventHandler(this.btnTestReg_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(54, 64);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(144, 20);
            this.textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(54, 44);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(144, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(54, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(144, 20);
            this.textBox1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radCheckItem);
            this.groupBox1.Controls.Add(this.radCheckAll);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(126)))), ((int)(((byte)(57)))));
            this.groupBox1.Location = new System.Drawing.Point(448, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(82, 57);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Run for...";
            // 
            // radCheckItem
            // 
            this.radCheckItem.AutoSize = true;
            this.radCheckItem.Checked = true;
            this.radCheckItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCheckItem.Location = new System.Drawing.Point(5, 15);
            this.radCheckItem.Name = "radCheckItem";
            this.radCheckItem.Size = new System.Drawing.Size(67, 17);
            this.radCheckItem.TabIndex = 2;
            this.radCheckItem.TabStop = true;
            this.radCheckItem.Text = "Selected";
            this.radCheckItem.UseVisualStyleBackColor = true;
            // 
            // radCheckAll
            // 
            this.radCheckAll.AutoSize = true;
            this.radCheckAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCheckAll.Location = new System.Drawing.Point(5, 30);
            this.radCheckAll.Name = "radCheckAll";
            this.radCheckAll.Size = new System.Drawing.Size(36, 17);
            this.radCheckAll.TabIndex = 3;
            this.radCheckAll.Text = "All";
            this.radCheckAll.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(126)))), ((int)(((byte)(57)))));
            this.groupBox2.Location = new System.Drawing.Point(297, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(150, 119);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fix...";
            // 
            // button4
            // 
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Transparent;
            this.button4.Location = new System.Drawing.Point(17, 79);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(117, 19);
            this.button4.TabIndex = 6;
            this.button4.Text = "Checksum (Remove)";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Transparent;
            this.button3.Location = new System.Drawing.Point(17, 54);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 19);
            this.button3.TabIndex = 5;
            this.button3.Text = "Episode";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(17, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 19);
            this.button2.TabIndex = 4;
            this.button2.Text = "Part Files";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(153, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 19);
            this.button1.TabIndex = 3;
            this.button1.Text = "Run";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // folderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gvFiles);
            this.Controls.Add(this.groupBox4);
            this.DoubleBuffered = true;
            this.Name = "folderView";
            this.Size = new System.Drawing.Size(533, 630);
            ((System.ComponentModel.ISupportInitialize)(this.gvFiles)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvFiles;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnShowDiv;
        private System.Windows.Forms.ToolStripButton btnDivide;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnAddCRC;
        private System.Windows.Forms.ToolStripButton btnCheckCRC;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnBack;
        private System.Windows.Forms.ToolStripComboBox ddUrl;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox lstDivs;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ddFormat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTestFormats;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewImageColumn gvFiles_Check;
        private System.Windows.Forms.DataGridViewImageColumn gvFiles_Icon;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvFiles_File;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvFiles_Hidden;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvFiles_Ep;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radCheckItem;
        private System.Windows.Forms.RadioButton radCheckAll;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}
