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
            this.btnBack = new System.Windows.Forms.Button();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.lstFolders = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstFiles = new System.Windows.Forms.ListBox();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnChecksum = new System.Windows.Forms.Button();
            this.btnFill = new System.Windows.Forms.Button();
            this.lblSize = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(433, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtURL
            // 
            this.txtURL.BackColor = System.Drawing.Color.Black;
            this.txtURL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtURL.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtURL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(83)))));
            this.txtURL.Location = new System.Drawing.Point(16, 55);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(492, 22);
            this.txtURL.TabIndex = 42;
            this.txtURL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(196, 93);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 41;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // lstFolders
            // 
            this.lstFolders.BackColor = System.Drawing.Color.Black;
            this.lstFolders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstFolders.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstFolders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(126)))), ((int)(((byte)(57)))));
            this.lstFolders.FormattingEnabled = true;
            this.lstFolders.ItemHeight = 17;
            this.lstFolders.Location = new System.Drawing.Point(277, 93);
            this.lstFolders.Name = "lstFolders";
            this.lstFolders.ScrollAlwaysVisible = true;
            this.lstFolders.Size = new System.Drawing.Size(89, 102);
            this.lstFolders.TabIndex = 44;
            this.lstFolders.Click += new System.EventHandler(this.lstFolders_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(126)))), ((int)(((byte)(57)))));
            this.label1.Location = new System.Drawing.Point(12, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 22);
            this.label1.TabIndex = 43;
            this.label1.Text = "Folder View";
            // 
            // lstFiles
            // 
            this.lstFiles.BackColor = System.Drawing.Color.Black;
            this.lstFiles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstFiles.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lstFiles.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstFiles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(126)))), ((int)(((byte)(57)))));
            this.lstFiles.FormattingEnabled = true;
            this.lstFiles.ItemHeight = 17;
            this.lstFiles.Location = new System.Drawing.Point(0, 229);
            this.lstFiles.Name = "lstFiles";
            this.lstFiles.ScrollAlwaysVisible = true;
            this.lstFiles.Size = new System.Drawing.Size(524, 238);
            this.lstFiles.TabIndex = 45;
            // 
            // btnDivide
            // 
            this.btnDivide.Enabled = false;
            this.btnDivide.Location = new System.Drawing.Point(196, 171);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(75, 23);
            this.btnDivide.TabIndex = 46;
            this.btnDivide.Text = "Divide";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnChecksum
            // 
            this.btnChecksum.Location = new System.Drawing.Point(115, 93);
            this.btnChecksum.Name = "btnChecksum";
            this.btnChecksum.Size = new System.Drawing.Size(75, 46);
            this.btnChecksum.TabIndex = 47;
            this.btnChecksum.Text = "Add CRC";
            this.btnChecksum.UseVisualStyleBackColor = true;
            this.btnChecksum.Click += new System.EventHandler(this.btbCRC_Click);
            // 
            // btnFill
            // 
            this.btnFill.Location = new System.Drawing.Point(115, 149);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(75, 46);
            this.btnFill.TabIndex = 48;
            this.btnFill.Text = "Add Disc";
            this.btnFill.UseVisualStyleBackColor = true;
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(126)))), ((int)(((byte)(57)))));
            this.lblSize.Location = new System.Drawing.Point(409, 98);
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
            this.label3.Location = new System.Drawing.Point(372, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = "Size";
            // 
            // btnClear
            // 
            this.btnClear.Enabled = false;
            this.btnClear.Location = new System.Drawing.Point(196, 132);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 51;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // folderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.btnFill);
            this.Controls.Add(this.btnChecksum);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.lstFiles);
            this.Controls.Add(this.lstFolders);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnBack);
            this.Name = "folderView";
            this.Size = new System.Drawing.Size(524, 467);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.ListBox lstFolders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstFiles;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnChecksum;
        private System.Windows.Forms.Button btnFill;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClear;
    }
}
