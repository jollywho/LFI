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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(folderView));
            this.gvFiles = new System.Windows.Forms.DataGridView();
            this.gvFiles_Check = new System.Windows.Forms.DataGridViewImageColumn();
            this.gvFiles_Icon = new System.Windows.Forms.DataGridViewImageColumn();
            this.gvFiles_File = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvFiles_Hidden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvFiles_Group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvFiles_Season = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvFiles_Episode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvFiles_CRC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvFiles_POS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnBack = new System.Windows.Forms.ToolStripButton();
            this.ddUrl = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnShowDiv = new System.Windows.Forms.ToolStripButton();
            this.btnDivide = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAddCRC = new System.Windows.Forms.ToolStripButton();
            this.btnCheckCRC = new System.Windows.Forms.ToolStripButton();
            this.btnRemoveCRC = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lstDivs = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ddFormat_Use = new System.Windows.Forms.ComboBox();
            this.btnRunFormats = new System.Windows.Forms.Button();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.btnShowEstimates = new System.Windows.Forms.Button();
            this.ddFormat = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radCheckItem = new System.Windows.Forms.RadioButton();
            this.radCheckAll = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnMarkFiles = new System.Windows.Forms.Button();
            this.btnPartFiles = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.fileWatcher = new System.IO.FileSystemWatcher();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtFilter = new LFI.CueTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.gvFiles)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileWatcher)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
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
            this.gvFiles.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.gvFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gvFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gvFiles_Check,
            this.gvFiles_Icon,
            this.gvFiles_File,
            this.gvFiles_Hidden,
            this.gvFiles_Group,
            this.gvFiles_Season,
            this.gvFiles_Episode,
            this.gvFiles_CRC,
            this.gvFiles_POS});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvFiles.DefaultCellStyle = dataGridViewCellStyle8;
            this.gvFiles.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gvFiles.Location = new System.Drawing.Point(0, 164);
            this.gvFiles.MultiSelect = false;
            this.gvFiles.Name = "gvFiles";
            this.gvFiles.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gvFiles.RowHeadersVisible = false;
            this.gvFiles.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gvFiles.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gvFiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvFiles.Size = new System.Drawing.Size(533, 466);
            this.gvFiles.StandardTab = true;
            this.gvFiles.TabIndex = 0;
            this.gvFiles.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.gvFiles_CellBeginEdit);
            this.gvFiles.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvFiles_CellDoubleClick);
            this.gvFiles.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvFiles_CellLeave);
            this.gvFiles.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvFiles_CellMouseEnter);
            this.gvFiles.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvFiles_RowEnter);
            this.gvFiles.DragDrop += new System.Windows.Forms.DragEventHandler(this.gvFiles_DragDrop);
            this.gvFiles.DragOver += new System.Windows.Forms.DragEventHandler(this.gvFiles_DragOver);
            this.gvFiles.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gvFiles_KeyDown);
            this.gvFiles.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gvFiles_MouseDown);
            this.gvFiles.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gvFiles_MouseMove);
            this.gvFiles.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gvFiles_MouseUp);
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
            this.gvFiles_File.FillWeight = 94.69651F;
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
            // gvFiles_Group
            // 
            this.gvFiles_Group.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.gvFiles_Group.DefaultCellStyle = dataGridViewCellStyle4;
            this.gvFiles_Group.HeaderText = "Group";
            this.gvFiles_Group.Name = "gvFiles_Group";
            this.gvFiles_Group.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.gvFiles_Group.Visible = false;
            this.gvFiles_Group.Width = 42;
            // 
            // gvFiles_Season
            // 
            this.gvFiles_Season.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.gvFiles_Season.DefaultCellStyle = dataGridViewCellStyle5;
            this.gvFiles_Season.FillWeight = 39.77273F;
            this.gvFiles_Season.HeaderText = "S";
            this.gvFiles_Season.Name = "gvFiles_Season";
            this.gvFiles_Season.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gvFiles_Season.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.gvFiles_Season.Visible = false;
            this.gvFiles_Season.Width = 20;
            // 
            // gvFiles_Episode
            // 
            this.gvFiles_Episode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.gvFiles_Episode.DefaultCellStyle = dataGridViewCellStyle6;
            this.gvFiles_Episode.FillWeight = 39.77273F;
            this.gvFiles_Episode.HeaderText = "E";
            this.gvFiles_Episode.Name = "gvFiles_Episode";
            this.gvFiles_Episode.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gvFiles_Episode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.gvFiles_Episode.Visible = false;
            this.gvFiles_Episode.Width = 20;
            // 
            // gvFiles_CRC
            // 
            this.gvFiles_CRC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.gvFiles_CRC.DefaultCellStyle = dataGridViewCellStyle7;
            this.gvFiles_CRC.HeaderText = "CRC";
            this.gvFiles_CRC.Name = "gvFiles_CRC";
            this.gvFiles_CRC.ReadOnly = true;
            this.gvFiles_CRC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.gvFiles_CRC.Visible = false;
            this.gvFiles_CRC.Width = 35;
            // 
            // gvFiles_POS
            // 
            this.gvFiles_POS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.gvFiles_POS.FillWeight = 10F;
            this.gvFiles_POS.HeaderText = "Pos";
            this.gvFiles_POS.Name = "gvFiles_POS";
            this.gvFiles_POS.ReadOnly = true;
            this.gvFiles_POS.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gvFiles_POS.Visible = false;
            this.gvFiles_POS.Width = 15;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBack,
            this.ddUrl,
            this.toolStripSeparator4,
            this.btnCancel,
            this.toolStripSeparator5,
            this.btnShowDiv,
            this.btnDivide,
            this.toolStripSeparator6,
            this.btnAddCRC,
            this.btnCheckCRC,
            this.btnRemoveCRC});
            this.toolStrip1.Location = new System.Drawing.Point(1, 0);
            this.toolStrip1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(533, 25);
            this.toolStrip1.TabIndex = 33;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnBack
            // 
            this.btnBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBack.Image = global::LFI.Properties.Resources.back;
            this.btnBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(23, 22);
            this.btnBack.ToolTipText = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ddUrl
            // 
            this.ddUrl.BackColor = System.Drawing.Color.White;
            this.ddUrl.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ddUrl.Name = "ddUrl";
            this.ddUrl.Size = new System.Drawing.Size(350, 25);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
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
            // btnRemoveCRC
            // 
            this.btnRemoveCRC.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRemoveCRC.Image = global::LFI.Properties.Resources.eraser;
            this.btnRemoveCRC.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRemoveCRC.Name = "btnRemoveCRC";
            this.btnRemoveCRC.Size = new System.Drawing.Size(23, 22);
            this.btnRemoveCRC.Text = "Remove CRC";
            this.btnRemoveCRC.Click += new System.EventHandler(this.btnRemoveCRC_Click);
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
            this.groupBox4.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBox4.ForeColor = System.Drawing.Color.Black;
            this.groupBox4.Location = new System.Drawing.Point(214, 32);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.groupBox4.Size = new System.Drawing.Size(79, 125);
            this.groupBox4.TabIndex = 36;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Divisions";
            // 
            // lstDivs
            // 
            this.lstDivs.BackColor = System.Drawing.Color.White;
            this.lstDivs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstDivs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstDivs.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDivs.ForeColor = System.Drawing.Color.Black;
            this.lstDivs.FormattingEnabled = true;
            this.lstDivs.ItemHeight = 15;
            this.lstDivs.Location = new System.Drawing.Point(3, 15);
            this.lstDivs.Name = "lstDivs";
            this.lstDivs.ScrollAlwaysVisible = true;
            this.lstDivs.Size = new System.Drawing.Size(73, 107);
            this.lstDivs.TabIndex = 7;
            this.lstDivs.Click += new System.EventHandler(this.lstDivs_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tableLayoutPanel2);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(3, 79);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(5, 5, 5, 3);
            this.groupBox3.Size = new System.Drawing.Size(208, 78);
            this.groupBox3.TabIndex = 35;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Reformat";
            // 
            // ddFormat_Use
            // 
            this.ddFormat_Use.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ddFormat_Use.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddFormat_Use.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ddFormat_Use.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ddFormat_Use.FormattingEnabled = true;
            this.ddFormat_Use.Location = new System.Drawing.Point(3, 30);
            this.ddFormat_Use.Name = "ddFormat_Use";
            this.ddFormat_Use.Size = new System.Drawing.Size(93, 23);
            this.ddFormat_Use.TabIndex = 22;
            // 
            // btnRunFormats
            // 
            this.btnRunFormats.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRunFormats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRunFormats.Enabled = false;
            this.btnRunFormats.FlatAppearance.BorderSize = 0;
            this.btnRunFormats.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRunFormats.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRunFormats.ForeColor = System.Drawing.Color.Transparent;
            this.btnRunFormats.Location = new System.Drawing.Point(102, 30);
            this.btnRunFormats.Name = "btnRunFormats";
            this.btnRunFormats.Size = new System.Drawing.Size(93, 22);
            this.btnRunFormats.TabIndex = 3;
            this.btnRunFormats.Text = "Run";
            this.btnRunFormats.UseVisualStyleBackColor = true;
            this.btnRunFormats.Click += new System.EventHandler(this.btnRunFormats_Click);
            // 
            // txtTitle
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.txtTitle, 2);
            this.txtTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTitle.Location = new System.Drawing.Point(3, 3);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(192, 23);
            this.txtTitle.TabIndex = 1;
            // 
            // btnShowEstimates
            // 
            this.btnShowEstimates.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShowEstimates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnShowEstimates.FlatAppearance.BorderSize = 0;
            this.btnShowEstimates.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnShowEstimates.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowEstimates.ForeColor = System.Drawing.Color.Transparent;
            this.btnShowEstimates.Location = new System.Drawing.Point(102, 3);
            this.btnShowEstimates.Name = "btnShowEstimates";
            this.btnShowEstimates.Size = new System.Drawing.Size(93, 22);
            this.btnShowEstimates.TabIndex = 21;
            this.btnShowEstimates.Text = "Show Fields";
            this.btnShowEstimates.UseVisualStyleBackColor = true;
            this.btnShowEstimates.Click += new System.EventHandler(this.btnShowEstimates_Click);
            // 
            // ddFormat
            // 
            this.ddFormat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ddFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddFormat.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ddFormat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ddFormat.FormattingEnabled = true;
            this.ddFormat.Location = new System.Drawing.Point(3, 3);
            this.ddFormat.Name = "ddFormat";
            this.ddFormat.Size = new System.Drawing.Size(93, 23);
            this.ddFormat.TabIndex = 19;
            this.ddFormat.SelectedValueChanged += new System.EventHandler(this.ddFormat_SelectedValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radCheckItem);
            this.groupBox1.Controls.Add(this.radCheckAll);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(448, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 5, 5, 10);
            this.groupBox1.Size = new System.Drawing.Size(82, 68);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Run";
            // 
            // radCheckItem
            // 
            this.radCheckItem.AutoSize = true;
            this.radCheckItem.Checked = true;
            this.radCheckItem.Dock = System.Windows.Forms.DockStyle.Top;
            this.radCheckItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCheckItem.Location = new System.Drawing.Point(5, 20);
            this.radCheckItem.Name = "radCheckItem";
            this.radCheckItem.Size = new System.Drawing.Size(72, 19);
            this.radCheckItem.TabIndex = 2;
            this.radCheckItem.TabStop = true;
            this.radCheckItem.Text = "Selected";
            this.radCheckItem.UseVisualStyleBackColor = true;
            // 
            // radCheckAll
            // 
            this.radCheckAll.AutoSize = true;
            this.radCheckAll.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.radCheckAll.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCheckAll.Location = new System.Drawing.Point(5, 39);
            this.radCheckAll.Name = "radCheckAll";
            this.radCheckAll.Size = new System.Drawing.Size(72, 19);
            this.radCheckAll.TabIndex = 3;
            this.radCheckAll.Text = "All";
            this.radCheckAll.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnMarkFiles);
            this.groupBox2.Controls.Add(this.btnPartFiles);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(297, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.groupBox2.Size = new System.Drawing.Size(150, 70);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Misc";
            // 
            // btnMarkFiles
            // 
            this.btnMarkFiles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMarkFiles.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnMarkFiles.FlatAppearance.BorderSize = 0;
            this.btnMarkFiles.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnMarkFiles.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarkFiles.ForeColor = System.Drawing.Color.Transparent;
            this.btnMarkFiles.Location = new System.Drawing.Point(5, 42);
            this.btnMarkFiles.Name = "btnMarkFiles";
            this.btnMarkFiles.Size = new System.Drawing.Size(140, 23);
            this.btnMarkFiles.TabIndex = 5;
            this.btnMarkFiles.Text = "Mark Files";
            this.btnMarkFiles.UseVisualStyleBackColor = true;
            // 
            // btnPartFiles
            // 
            this.btnPartFiles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPartFiles.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPartFiles.FlatAppearance.BorderSize = 0;
            this.btnPartFiles.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPartFiles.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPartFiles.ForeColor = System.Drawing.Color.Transparent;
            this.btnPartFiles.Location = new System.Drawing.Point(5, 15);
            this.btnPartFiles.Name = "btnPartFiles";
            this.btnPartFiles.Size = new System.Drawing.Size(140, 23);
            this.btnPartFiles.TabIndex = 4;
            this.btnPartFiles.Text = "Part Files";
            this.btnPartFiles.UseVisualStyleBackColor = true;
            this.btnPartFiles.Click += new System.EventHandler(this.btnPartFiles_Click);
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
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtFilter);
            this.groupBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox5.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBox5.ForeColor = System.Drawing.Color.Black;
            this.groupBox5.Location = new System.Drawing.Point(297, 100);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.groupBox5.Size = new System.Drawing.Size(233, 57);
            this.groupBox5.TabIndex = 40;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Filter";
            // 
            // fileWatcher
            // 
            this.fileWatcher.EnableRaisingEvents = true;
            this.fileWatcher.Path = "C:\\Users\\Jollyrancher\\Downloads";
            this.fileWatcher.SynchronizingObject = this;
            this.fileWatcher.Created += new System.IO.FileSystemEventHandler(this.fileWatcher_Created);
            this.fileWatcher.Deleted += new System.IO.FileSystemEventHandler(this.fileWatcher_Deleted);
            this.fileWatcher.Renamed += new System.IO.RenamedEventHandler(this.fileWatcher_Renamed);
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.Transparent;
            this.groupBox6.Controls.Add(this.tableLayoutPanel1);
            this.groupBox6.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBox6.Location = new System.Drawing.Point(3, 32);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.groupBox6.Size = new System.Drawing.Size(208, 49);
            this.groupBox6.TabIndex = 41;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Detect";
            // 
            // txtFilter
            // 
            this.txtFilter.Cue = "<Search Here>";
            this.txtFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtFilter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilter.Location = new System.Drawing.Point(3, 22);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(227, 23);
            this.txtFilter.TabIndex = 3;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnShowEstimates, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ddFormat, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 18);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(198, 28);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.ddFormat_Use, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnRunFormats, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtTitle, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(5, 20);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(198, 55);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // folderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileWatcher)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvFiles;
        private System.Windows.Forms.ToolStrip toolStrip1;
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
        private System.Windows.Forms.ComboBox ddFormat;
        private System.Windows.Forms.Button btnRunFormats;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radCheckItem;
        private System.Windows.Forms.RadioButton radCheckAll;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPartFiles;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnShowEstimates;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.IO.FileSystemWatcher fileWatcher;
        private System.Windows.Forms.ToolStripButton btnRemoveCRC;
        private System.Windows.Forms.Button btnMarkFiles;
        private System.Windows.Forms.DataGridViewImageColumn gvFiles_Check;
        private System.Windows.Forms.DataGridViewImageColumn gvFiles_Icon;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvFiles_File;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvFiles_Hidden;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvFiles_Group;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvFiles_Season;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvFiles_Episode;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvFiles_CRC;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvFiles_POS;
        private System.Windows.Forms.ComboBox ddFormat_Use;
        private System.Windows.Forms.GroupBox groupBox6;
        private CueTextBox txtFilter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
