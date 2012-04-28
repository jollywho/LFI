namespace LFI
{
    partial class addView
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
            this.contextMenuDisc = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuItemDisc = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ddStatus = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ddCategory = new System.Windows.Forms.ComboBox();
            this.txtYear = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ddLanguage = new System.Windows.Forms.ComboBox();
            this.ddTitle = new System.Windows.Forms.ComboBox();
            this.btnAddTitle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEpisode = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.contextMenuDisc.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuDisc
            // 
            this.contextMenuDisc.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextMenuItemDisc});
            this.contextMenuDisc.Name = "contextMenuDisc";
            this.contextMenuDisc.Size = new System.Drawing.Size(125, 26);
            // 
            // contextMenuItemDisc
            // 
            this.contextMenuItemDisc.Name = "contextMenuItemDisc";
            this.contextMenuItemDisc.Size = new System.Drawing.Size(124, 22);
            this.contextMenuItemDisc.Text = "View Disc";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ddStatus);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.ddCategory);
            this.groupBox2.Controls.Add(this.txtYear);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.ddLanguage);
            this.groupBox2.Controls.Add(this.ddTitle);
            this.groupBox2.Controls.Add(this.btnAddTitle);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtEpisode);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(126)))), ((int)(((byte)(57)))));
            this.groupBox2.Location = new System.Drawing.Point(0, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(524, 152);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Title";
            // 
            // ddStatus
            // 
            this.ddStatus.BackColor = System.Drawing.SystemColors.Control;
            this.ddStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddStatus.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ddStatus.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddStatus.ForeColor = System.Drawing.Color.Black;
            this.ddStatus.FormattingEnabled = true;
            this.ddStatus.Items.AddRange(new object[] {
            "Unaired",
            "Started",
            "Finished",
            "Unknown"});
            this.ddStatus.Location = new System.Drawing.Point(30, 93);
            this.ddStatus.Name = "ddStatus";
            this.ddStatus.Size = new System.Drawing.Size(137, 24);
            this.ddStatus.TabIndex = 69;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(126)))), ((int)(((byte)(57)))));
            this.label4.Location = new System.Drawing.Point(78, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 68;
            this.label4.Text = "Status";
            // 
            // ddCategory
            // 
            this.ddCategory.BackColor = System.Drawing.SystemColors.Control;
            this.ddCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddCategory.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ddCategory.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddCategory.ForeColor = System.Drawing.Color.Black;
            this.ddCategory.FormattingEnabled = true;
            this.ddCategory.Items.AddRange(new object[] {
            "TV",
            "Movie",
            "OVA/ Special"});
            this.ddCategory.Location = new System.Drawing.Point(372, 43);
            this.ddCategory.Name = "ddCategory";
            this.ddCategory.Size = new System.Drawing.Size(126, 24);
            this.ddCategory.TabIndex = 66;
            // 
            // txtYear
            // 
            this.txtYear.BackColor = System.Drawing.Color.Black;
            this.txtYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtYear.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(126)))), ((int)(((byte)(57)))));
            this.txtYear.Location = new System.Drawing.Point(186, 95);
            this.txtYear.Mask = "0000";
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(75, 22);
            this.txtYear.TabIndex = 64;
            this.txtYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtYear.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numericTextbox_keydown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(126)))), ((int)(((byte)(57)))));
            this.label5.Location = new System.Drawing.Point(208, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 16);
            this.label5.TabIndex = 65;
            this.label5.Text = "Year";
            // 
            // ddLanguage
            // 
            this.ddLanguage.BackColor = System.Drawing.SystemColors.Control;
            this.ddLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddLanguage.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ddLanguage.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddLanguage.ForeColor = System.Drawing.Color.Black;
            this.ddLanguage.FormattingEnabled = true;
            this.ddLanguage.Items.AddRange(new object[] {
            "ENG",
            "JPN"});
            this.ddLanguage.Location = new System.Drawing.Point(273, 93);
            this.ddLanguage.Name = "ddLanguage";
            this.ddLanguage.Size = new System.Drawing.Size(59, 24);
            this.ddLanguage.TabIndex = 63;
            // 
            // ddTitle
            // 
            this.ddTitle.BackColor = System.Drawing.SystemColors.Control;
            this.ddTitle.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ddTitle.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddTitle.ForeColor = System.Drawing.Color.Black;
            this.ddTitle.FormattingEnabled = true;
            this.ddTitle.Location = new System.Drawing.Point(27, 43);
            this.ddTitle.Name = "ddTitle";
            this.ddTitle.Size = new System.Drawing.Size(323, 24);
            this.ddTitle.TabIndex = 62;
            // 
            // btnAddTitle
            // 
            this.btnAddTitle.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTitle.ForeColor = System.Drawing.Color.Black;
            this.btnAddTitle.Location = new System.Drawing.Point(423, 124);
            this.btnAddTitle.Name = "btnAddTitle";
            this.btnAddTitle.Size = new System.Drawing.Size(75, 23);
            this.btnAddTitle.TabIndex = 6;
            this.btnAddTitle.Text = "Add";
            this.btnAddTitle.UseVisualStyleBackColor = true;
            this.btnAddTitle.Click += new System.EventHandler(this.btnAddTitle_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(126)))), ((int)(((byte)(57)))));
            this.label6.Location = new System.Drawing.Point(274, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 41;
            this.label6.Text = "Language";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(126)))), ((int)(((byte)(57)))));
            this.label1.Location = new System.Drawing.Point(370, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 35;
            this.label1.Text = "Episode #";
            // 
            // txtEpisode
            // 
            this.txtEpisode.BackColor = System.Drawing.Color.Black;
            this.txtEpisode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEpisode.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEpisode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(126)))), ((int)(((byte)(57)))));
            this.txtEpisode.Location = new System.Drawing.Point(370, 95);
            this.txtEpisode.Mask = "000";
            this.txtEpisode.Name = "txtEpisode";
            this.txtEpisode.Size = new System.Drawing.Size(52, 22);
            this.txtEpisode.TabIndex = 3;
            this.txtEpisode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEpisode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numericTextbox_keydown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(126)))), ((int)(((byte)(57)))));
            this.label3.Location = new System.Drawing.Point(409, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 37;
            this.label3.Text = "Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(126)))), ((int)(((byte)(57)))));
            this.label2.Location = new System.Drawing.Point(196, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 36;
            this.label2.Text = "Title";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(446, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // addView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.groupBox2);
            this.Name = "addView";
            this.Size = new System.Drawing.Size(524, 467);
            this.contextMenuDisc.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuDisc;
        private System.Windows.Forms.ToolStripMenuItem contextMenuItemDisc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtEpisode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAddTitle;
        private System.Windows.Forms.ComboBox ddTitle;
        private System.Windows.Forms.ComboBox ddLanguage;
        private System.Windows.Forms.MaskedTextBox txtYear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ddStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ddCategory;
    }
}
