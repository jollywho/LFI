﻿namespace LFI
{
    partial class editPane
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
            this.btnImg = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSeasons = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.imgError = new System.Windows.Forms.PictureBox();
            this.ddLanguage = new System.Windows.Forms.ComboBox();
            this.txtEpisode = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ddStatus = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ddTitle = new System.Windows.Forms.ComboBox();
            this.ddCategory = new System.Windows.Forms.ComboBox();
            this.imgTitle = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTitle)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImg
            // 
            this.btnImg.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnImg.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImg.ForeColor = System.Drawing.Color.Lime;
            this.btnImg.Location = new System.Drawing.Point(145, 223);
            this.btnImg.Name = "btnImg";
            this.btnImg.Size = new System.Drawing.Size(50, 20);
            this.btnImg.TabIndex = 30;
            this.btnImg.TabStop = false;
            this.btnImg.Text = "...";
            this.btnImg.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnImg.UseVisualStyleBackColor = true;
            this.btnImg.Click += new System.EventHandler(this.btnImg_Click);
            // 
            // toolTip
            // 
            this.toolTip.BackColor = System.Drawing.Color.Transparent;
            this.toolTip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(126)))), ((int)(((byte)(57)))));
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::LFI.Properties.Resources.border;
            this.panel1.Controls.Add(this.txtSeasons);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.imgError);
            this.panel1.Controls.Add(this.ddLanguage);
            this.panel1.Controls.Add(this.txtEpisode);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.ddStatus);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtYear);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ddTitle);
            this.panel1.Controls.Add(this.ddCategory);
            this.panel1.Location = new System.Drawing.Point(10, 265);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 200);
            this.panel1.TabIndex = 74;
            // 
            // txtSeasons
            // 
            this.txtSeasons.BackColor = System.Drawing.SystemColors.Control;
            this.txtSeasons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSeasons.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeasons.ForeColor = System.Drawing.Color.Black;
            this.txtSeasons.Location = new System.Drawing.Point(32, 99);
            this.txtSeasons.Mask = "000";
            this.txtSeasons.Name = "txtSeasons";
            this.txtSeasons.PromptChar = ' ';
            this.txtSeasons.Size = new System.Drawing.Size(52, 22);
            this.txtSeasons.TabIndex = 76;
            this.txtSeasons.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSeasons.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(126)))), ((int)(((byte)(57)))));
            this.label7.Location = new System.Drawing.Point(32, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 75;
            this.label7.Text = "Seasons";
            // 
            // imgError
            // 
            this.imgError.BackgroundImage = global::LFI.Properties.Resources.error;
            this.imgError.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgError.Location = new System.Drawing.Point(285, 18);
            this.imgError.Name = "imgError";
            this.imgError.Size = new System.Drawing.Size(16, 16);
            this.imgError.TabIndex = 74;
            this.imgError.TabStop = false;
            this.imgError.Visible = false;
            this.imgError.MouseHover += new System.EventHandler(this.imgError_MouseHover);
            // 
            // ddLanguage
            // 
            this.ddLanguage.BackColor = System.Drawing.SystemColors.Control;
            this.ddLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddLanguage.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ddLanguage.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddLanguage.ForeColor = System.Drawing.Color.Black;
            this.ddLanguage.FormattingEnabled = true;
            this.ddLanguage.Items.AddRange(new object[] {
            "ENG",
            "JPN"});
            this.ddLanguage.Location = new System.Drawing.Point(229, 97);
            this.ddLanguage.Name = "ddLanguage";
            this.ddLanguage.Size = new System.Drawing.Size(59, 24);
            this.ddLanguage.TabIndex = 73;
            // 
            // txtEpisode
            // 
            this.txtEpisode.BackColor = System.Drawing.SystemColors.Control;
            this.txtEpisode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEpisode.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEpisode.ForeColor = System.Drawing.Color.Black;
            this.txtEpisode.Location = new System.Drawing.Point(90, 99);
            this.txtEpisode.Mask = "000";
            this.txtEpisode.Name = "txtEpisode";
            this.txtEpisode.PromptChar = ' ';
            this.txtEpisode.Size = new System.Drawing.Size(52, 22);
            this.txtEpisode.TabIndex = 68;
            this.txtEpisode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEpisode.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(126)))), ((int)(((byte)(57)))));
            this.label6.Location = new System.Drawing.Point(230, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 72;
            this.label6.Text = "Language";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(126)))), ((int)(((byte)(57)))));
            this.label5.Location = new System.Drawing.Point(170, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 16);
            this.label5.TabIndex = 39;
            this.label5.Text = "Year";
            // 
            // ddStatus
            // 
            this.ddStatus.BackColor = System.Drawing.SystemColors.Control;
            this.ddStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddStatus.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ddStatus.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddStatus.ForeColor = System.Drawing.Color.Black;
            this.ddStatus.FormattingEnabled = true;
            this.ddStatus.Items.AddRange(new object[] {
            "Unaired",
            "Started",
            "Finished",
            "Unknown"});
            this.ddStatus.Location = new System.Drawing.Point(173, 150);
            this.ddStatus.Name = "ddStatus";
            this.ddStatus.Size = new System.Drawing.Size(137, 24);
            this.ddStatus.TabIndex = 71;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(126)))), ((int)(((byte)(57)))));
            this.label2.Location = new System.Drawing.Point(144, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 36;
            this.label2.Text = "Title";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(126)))), ((int)(((byte)(57)))));
            this.label4.Location = new System.Drawing.Point(221, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 70;
            this.label4.Text = "Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(126)))), ((int)(((byte)(57)))));
            this.label3.Location = new System.Drawing.Point(51, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 37;
            this.label3.Text = "Category";
            // 
            // txtYear
            // 
            this.txtYear.BackColor = System.Drawing.SystemColors.Control;
            this.txtYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtYear.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYear.ForeColor = System.Drawing.Color.Black;
            this.txtYear.Location = new System.Drawing.Point(148, 99);
            this.txtYear.Mask = "0000";
            this.txtYear.Name = "txtYear";
            this.txtYear.PromptChar = ' ';
            this.txtYear.Size = new System.Drawing.Size(75, 22);
            this.txtYear.TabIndex = 69;
            this.txtYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtYear.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(126)))), ((int)(((byte)(57)))));
            this.label1.Location = new System.Drawing.Point(90, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 35;
            this.label1.Text = "Episodes";
            // 
            // ddTitle
            // 
            this.ddTitle.BackColor = System.Drawing.SystemColors.Control;
            this.ddTitle.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ddTitle.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddTitle.ForeColor = System.Drawing.Color.Black;
            this.ddTitle.FormattingEnabled = true;
            this.ddTitle.Location = new System.Drawing.Point(10, 46);
            this.ddTitle.Name = "ddTitle";
            this.ddTitle.Size = new System.Drawing.Size(300, 24);
            this.ddTitle.TabIndex = 63;
            this.ddTitle.TextChanged += new System.EventHandler(this.ddTitle_TextChanged);
            // 
            // ddCategory
            // 
            this.ddCategory.BackColor = System.Drawing.SystemColors.Control;
            this.ddCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddCategory.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ddCategory.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddCategory.ForeColor = System.Drawing.Color.Black;
            this.ddCategory.FormattingEnabled = true;
            this.ddCategory.Items.AddRange(new object[] {
            "TV",
            "Movie",
            "OVA/ Special"});
            this.ddCategory.Location = new System.Drawing.Point(10, 150);
            this.ddCategory.Name = "ddCategory";
            this.ddCategory.Size = new System.Drawing.Size(126, 24);
            this.ddCategory.TabIndex = 67;
            // 
            // imgTitle
            // 
            this.imgTitle.BackgroundImage = global::LFI.Properties.Resources.notfound;
            this.imgTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgTitle.Location = new System.Drawing.Point(68, 17);
            this.imgTitle.Name = "imgTitle";
            this.imgTitle.Size = new System.Drawing.Size(200, 200);
            this.imgTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgTitle.TabIndex = 31;
            this.imgTitle.TabStop = false;
            // 
            // editPane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.imgTitle);
            this.Controls.Add(this.btnImg);
            this.Name = "editPane";
            this.Size = new System.Drawing.Size(340, 482);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTitle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox imgTitle;
        private System.Windows.Forms.Button btnImg;
        private System.Windows.Forms.ComboBox ddTitle;
        private System.Windows.Forms.ComboBox ddCategory;
        private System.Windows.Forms.MaskedTextBox txtEpisode;
        private System.Windows.Forms.MaskedTextBox txtYear;
        private System.Windows.Forms.ComboBox ddStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ddLanguage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox imgError;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MaskedTextBox txtSeasons;
        private System.Windows.Forms.Label label7;
    }
}
