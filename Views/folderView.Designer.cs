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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnAddCRC = new System.Windows.Forms.Button();
            this.btnFill = new System.Windows.Forms.Button();
            this.lblSize = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCheckCRC = new System.Windows.Forms.Button();
            this.lstFolders = new System.Windows.Forms.ListBox();
            this.gvFiles = new System.Windows.Forms.DataGridView();
            this.check = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnShowDiv = new System.Windows.Forms.Button();
            this.ddUrl = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvFiles)).BeginInit();
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
            // btnDivide
            // 
            this.btnDivide.Enabled = false;
            this.btnDivide.Location = new System.Drawing.Point(430, 159);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(75, 31);
            this.btnDivide.TabIndex = 46;
            this.btnDivide.Text = "Divide";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnAddCRC
            // 
            this.btnAddCRC.Location = new System.Drawing.Point(171, 119);
            this.btnAddCRC.Name = "btnAddCRC";
            this.btnAddCRC.Size = new System.Drawing.Size(75, 31);
            this.btnAddCRC.TabIndex = 47;
            this.btnAddCRC.Text = "Add CRC";
            this.btnAddCRC.UseVisualStyleBackColor = true;
            // 
            // btnFill
            // 
            this.btnFill.Location = new System.Drawing.Point(252, 156);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(75, 31);
            this.btnFill.TabIndex = 48;
            this.btnFill.Text = "Add Disc";
            this.btnFill.UseVisualStyleBackColor = true;
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(126)))), ((int)(((byte)(57)))));
            this.lblSize.Location = new System.Drawing.Point(98, 102);
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
            this.label3.Location = new System.Drawing.Point(98, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = "Size";
            // 
            // btnClear
            // 
            this.btnClear.Enabled = false;
            this.btnClear.Location = new System.Drawing.Point(349, 84);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 31);
            this.btnClear.TabIndex = 51;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCheckCRC
            // 
            this.btnCheckCRC.Location = new System.Drawing.Point(171, 156);
            this.btnCheckCRC.Name = "btnCheckCRC";
            this.btnCheckCRC.Size = new System.Drawing.Size(75, 31);
            this.btnCheckCRC.TabIndex = 54;
            this.btnCheckCRC.Text = "Check CRC";
            this.btnCheckCRC.UseVisualStyleBackColor = true;
            this.btnCheckCRC.Click += new System.EventHandler(this.btnCheckCRC_Click);
            // 
            // lstFolders
            // 
            this.lstFolders.BackColor = System.Drawing.Color.White;
            this.lstFolders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstFolders.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstFolders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(126)))), ((int)(((byte)(57)))));
            this.lstFolders.FormattingEnabled = true;
            this.lstFolders.HorizontalScrollbar = true;
            this.lstFolders.ItemHeight = 17;
            this.lstFolders.Location = new System.Drawing.Point(3, 85);
            this.lstFolders.Name = "lstFolders";
            this.lstFolders.ScrollAlwaysVisible = true;
            this.lstFolders.Size = new System.Drawing.Size(89, 102);
            this.lstFolders.TabIndex = 55;
            this.lstFolders.Click += new System.EventHandler(this.lstFolders_Click);
            // 
            // gvFiles
            // 
            this.gvFiles.AllowUserToAddRows = false;
            this.gvFiles.AllowUserToDeleteRows = false;
            this.gvFiles.AllowUserToResizeColumns = false;
            this.gvFiles.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(126)))), ((int)(((byte)(57)))));
            this.gvFiles.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.gvFiles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvFiles.BackgroundColor = System.Drawing.Color.White;
            this.gvFiles.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gvFiles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gvFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvFiles.ColumnHeadersVisible = false;
            this.gvFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.check});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(126)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(143)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvFiles.DefaultCellStyle = dataGridViewCellStyle6;
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
            this.gvFiles.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.gvFiles_DataBindingComplete);
            this.gvFiles.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvFiles_RowEnter);
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
            // btnShowDiv
            // 
            this.btnShowDiv.Enabled = false;
            this.btnShowDiv.Location = new System.Drawing.Point(430, 122);
            this.btnShowDiv.Name = "btnShowDiv";
            this.btnShowDiv.Size = new System.Drawing.Size(75, 31);
            this.btnShowDiv.TabIndex = 57;
            this.btnShowDiv.Text = "Show Divs";
            this.btnShowDiv.UseVisualStyleBackColor = true;
            this.btnShowDiv.Click += new System.EventHandler(this.btnShowDiv_Click);
            // 
            // ddUrl
            // 
            this.ddUrl.FormattingEnabled = true;
            this.ddUrl.Location = new System.Drawing.Point(25, 25);
            this.ddUrl.Name = "ddUrl";
            this.ddUrl.Size = new System.Drawing.Size(499, 21);
            this.ddUrl.TabIndex = 52;
            this.ddUrl.Text = "C:\\Users\\Jollyrancher\\Videos\\[BURN]\\Bakuman";
            this.ddUrl.SelectedIndexChanged += new System.EventHandler(this.ddUrl_SelectedIndexChanged);
            this.ddUrl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ddUrl_KeyDown);
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
            // folderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnShowDiv);
            this.Controls.Add(this.gvFiles);
            this.Controls.Add(this.lstFolders);
            this.Controls.Add(this.btnCheckCRC);
            this.Controls.Add(this.ddUrl);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.btnFill);
            this.Controls.Add(this.btnAddCRC);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.label1);
            this.Name = "folderView";
            this.Size = new System.Drawing.Size(524, 620);
            ((System.ComponentModel.ISupportInitialize)(this.gvFiles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnAddCRC;
        private System.Windows.Forms.Button btnFill;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCheckCRC;
        private System.Windows.Forms.ListBox lstFolders;
        private System.Windows.Forms.DataGridView gvFiles;
        private System.Windows.Forms.DataGridViewImageColumn check;
        private System.Windows.Forms.Button btnShowDiv;
        private System.Windows.Forms.ComboBox ddUrl;
        private System.Windows.Forms.Button btnBack;
    }
}
