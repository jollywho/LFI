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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lstDivs = new System.Windows.Forms.ListBox();
            this.gvFiles = new System.Windows.Forms.DataGridView();
            this.ddUrl = new System.Windows.Forms.ComboBox();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnShowDiv = new System.Windows.Forms.Button();
            this.btnCheckCRC = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAddCRC = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.check = new System.Windows.Forms.DataGridViewImageColumn();
            this.Text = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hidden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvFiles)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.label1.TabIndex = 43;
            this.label1.Text = "Folder View";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(126)))), ((int)(((byte)(57)))));
            this.lblSize.Location = new System.Drawing.Point(102, 24);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(53, 13);
            this.lblSize.TabIndex = 49;
            this.lblSize.Text = "0.00 GB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(126)))), ((int)(((byte)(57)))));
            this.label3.Location = new System.Drawing.Point(102, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = "Size";
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
            this.lstDivs.TabIndex = 55;
            this.lstDivs.Click += new System.EventHandler(this.lstDivs_Click);
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(126)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(143)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvFiles.DefaultCellStyle = dataGridViewCellStyle2;
            this.gvFiles.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gvFiles.Location = new System.Drawing.Point(0, 193);
            this.gvFiles.MultiSelect = false;
            this.gvFiles.Name = "gvFiles";
            this.gvFiles.ReadOnly = true;
            this.gvFiles.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gvFiles.RowHeadersVisible = false;
            this.gvFiles.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gvFiles.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gvFiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvFiles.Size = new System.Drawing.Size(524, 427);
            this.gvFiles.StandardTab = true;
            this.gvFiles.TabIndex = 56;
            this.gvFiles.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvFiles_RowEnter);
            // 
            // ddUrl
            // 
            this.ddUrl.FormattingEnabled = true;
            this.ddUrl.Location = new System.Drawing.Point(25, 25);
            this.ddUrl.Name = "ddUrl";
            this.ddUrl.Size = new System.Drawing.Size(499, 21);
            this.ddUrl.TabIndex = 52;
            this.ddUrl.Text = "C:\\Users\\Jollyrancher\\Videos\\[BURN]\\Bakuman";
            this.ddUrl.SelectedValueChanged += new System.EventHandler(this.ddUrl_SelectedValueChanged);
            this.ddUrl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ddUrl_KeyDown);
            // 
            // btnDivide
            // 
            this.btnDivide.BackgroundImage = global::LFI.Properties.Resources.divide;
            this.btnDivide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDivide.FlatAppearance.BorderSize = 0;
            this.btnDivide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDivide.ForeColor = System.Drawing.Color.Transparent;
            this.btnDivide.Location = new System.Drawing.Point(260, 70);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(48, 48);
            this.btnDivide.TabIndex = 64;
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            this.btnDivide.MouseEnter += new System.EventHandler(this.btnBack_MouseEnter);
            this.btnDivide.MouseLeave += new System.EventHandler(this.btnBack_MouseLeave);
            // 
            // btnShowDiv
            // 
            this.btnShowDiv.BackgroundImage = global::LFI.Properties.Resources.showdiv;
            this.btnShowDiv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShowDiv.FlatAppearance.BorderSize = 0;
            this.btnShowDiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowDiv.ForeColor = System.Drawing.Color.Transparent;
            this.btnShowDiv.Location = new System.Drawing.Point(260, 8);
            this.btnShowDiv.Name = "btnShowDiv";
            this.btnShowDiv.Size = new System.Drawing.Size(48, 48);
            this.btnShowDiv.TabIndex = 63;
            this.btnShowDiv.UseVisualStyleBackColor = true;
            this.btnShowDiv.Click += new System.EventHandler(this.btnShowDiv_Click);
            this.btnShowDiv.MouseEnter += new System.EventHandler(this.btnBack_MouseEnter);
            this.btnShowDiv.MouseLeave += new System.EventHandler(this.btnBack_MouseLeave);
            // 
            // btnCheckCRC
            // 
            this.btnCheckCRC.BackgroundImage = global::LFI.Properties.Resources.checksum;
            this.btnCheckCRC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCheckCRC.FlatAppearance.BorderSize = 0;
            this.btnCheckCRC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckCRC.ForeColor = System.Drawing.Color.Transparent;
            this.btnCheckCRC.Location = new System.Drawing.Point(101, 95);
            this.btnCheckCRC.Name = "btnCheckCRC";
            this.btnCheckCRC.Size = new System.Drawing.Size(32, 32);
            this.btnCheckCRC.TabIndex = 62;
            this.btnCheckCRC.UseVisualStyleBackColor = true;
            this.btnCheckCRC.Click += new System.EventHandler(this.btnCheckCRC_Click);
            this.btnCheckCRC.MouseEnter += new System.EventHandler(this.btnBack_MouseEnter);
            this.btnCheckCRC.MouseLeave += new System.EventHandler(this.btnBack_MouseLeave);
            // 
            // btnClear
            // 
            this.btnClear.BackgroundImage = global::LFI.Properties.Resources.clear;
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.Transparent;
            this.btnClear.Location = new System.Drawing.Point(197, 14);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(32, 32);
            this.btnClear.TabIndex = 61;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            this.btnClear.MouseEnter += new System.EventHandler(this.btnBack_MouseEnter);
            this.btnClear.MouseLeave += new System.EventHandler(this.btnBack_MouseLeave);
            // 
            // btnAddCRC
            // 
            this.btnAddCRC.BackgroundImage = global::LFI.Properties.Resources.addchecksum;
            this.btnAddCRC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddCRC.FlatAppearance.BorderSize = 0;
            this.btnAddCRC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCRC.ForeColor = System.Drawing.Color.Transparent;
            this.btnAddCRC.Location = new System.Drawing.Point(101, 57);
            this.btnAddCRC.Name = "btnAddCRC";
            this.btnAddCRC.Size = new System.Drawing.Size(32, 32);
            this.btnAddCRC.TabIndex = 60;
            this.btnAddCRC.UseVisualStyleBackColor = true;
            this.btnAddCRC.Click += new System.EventHandler(this.btnAddCRC_Click);
            this.btnAddCRC.MouseEnter += new System.EventHandler(this.btnBack_MouseEnter);
            this.btnAddCRC.MouseLeave += new System.EventHandler(this.btnBack_MouseLeave);
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
            this.btnBack.TabIndex = 59;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnBack.MouseEnter += new System.EventHandler(this.btnBack_MouseEnter);
            this.btnBack.MouseLeave += new System.EventHandler(this.btnBack_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::LFI.Properties.Resources.border;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnShowDiv);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnCheckCRC);
            this.panel1.Controls.Add(this.lstDivs);
            this.panel1.Controls.Add(this.btnDivide);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnAddCRC);
            this.panel1.Controls.Add(this.lblSize);
            this.panel1.Location = new System.Drawing.Point(107, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 135);
            this.panel1.TabIndex = 65;
            // 
            // check
            // 
            this.check.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
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
            // folderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.gvFiles);
            this.Controls.Add(this.ddUrl);
            this.Controls.Add(this.label1);
            this.Name = "folderView";
            this.Size = new System.Drawing.Size(524, 620);
            ((System.ComponentModel.ISupportInitialize)(this.gvFiles)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCheckCRC;
        private System.Windows.Forms.Button btnShowDiv;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewImageColumn check;
        private System.Windows.Forms.DataGridViewTextBoxColumn Text;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hidden;
    }
}
