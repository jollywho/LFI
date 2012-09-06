namespace LFI
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
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.contextMenuImg = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imgTitle = new System.Windows.Forms.PictureBox();
            this.ddCategory = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ddStatus = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ddLanguage = new System.Windows.Forms.ComboBox();
            this.imgError = new System.Windows.Forms.PictureBox();
            this.btnImg = new System.Windows.Forms.Button();
            this.txtTitle = new LFI.RTextBox();
            this.txtEpisode = new LFI.RTextBox();
            this.txtYear = new LFI.RTextBox();
            this.bPanel1 = new LFI.BPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.contextMenuImg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgError)).BeginInit();
            this.bPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolTip
            // 
            this.toolTip.BackColor = System.Drawing.Color.Transparent;
            this.toolTip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(126)))), ((int)(((byte)(57)))));
            // 
            // contextMenuImg
            // 
            this.contextMenuImg.ImageScalingSize = new System.Drawing.Size(245, 345);
            this.contextMenuImg.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pasteToolStripMenuItem});
            this.contextMenuImg.Name = "contextMenuImg";
            this.contextMenuImg.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuImg.Size = new System.Drawing.Size(103, 26);
            this.contextMenuImg.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuImg_Opening);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // imgTitle
            // 
            this.imgTitle.BackgroundImage = global::LFI.Properties.Resources.notfound;
            this.imgTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgTitle.ContextMenuStrip = this.contextMenuImg;
            this.imgTitle.Location = new System.Drawing.Point(53, 0);
            this.imgTitle.Name = "imgTitle";
            this.imgTitle.Size = new System.Drawing.Size(245, 345);
            this.imgTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgTitle.TabIndex = 31;
            this.imgTitle.TabStop = false;
            // 
            // ddCategory
            // 
            this.ddCategory.BackColor = System.Drawing.SystemColors.Control;
            this.ddCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddCategory.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ddCategory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddCategory.ForeColor = System.Drawing.Color.Black;
            this.ddCategory.FormattingEnabled = true;
            this.ddCategory.Items.AddRange(new object[] {
            "TV",
            "Movie",
            "OVA/ Special"});
            this.ddCategory.Location = new System.Drawing.Point(29, 150);
            this.ddCategory.Name = "ddCategory";
            this.ddCategory.Size = new System.Drawing.Size(126, 23);
            this.ddCategory.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.label2.Location = new System.Drawing.Point(144, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Title";
            // 
            // ddStatus
            // 
            this.ddStatus.BackColor = System.Drawing.SystemColors.Control;
            this.ddStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddStatus.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ddStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddStatus.ForeColor = System.Drawing.Color.Black;
            this.ddStatus.FormattingEnabled = true;
            this.ddStatus.Items.AddRange(new object[] {
            "Unaired",
            "Untouched",
            "Started",
            "Finished",
            "Dropped",
            "Unknown"});
            this.ddStatus.Location = new System.Drawing.Point(163, 150);
            this.ddStatus.Name = "ddStatus";
            this.ddStatus.Size = new System.Drawing.Size(128, 23);
            this.ddStatus.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.label6.Location = new System.Drawing.Point(252, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Language";
            // 
            // ddLanguage
            // 
            this.ddLanguage.BackColor = System.Drawing.SystemColors.Control;
            this.ddLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddLanguage.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ddLanguage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddLanguage.ForeColor = System.Drawing.Color.Black;
            this.ddLanguage.FormattingEnabled = true;
            this.ddLanguage.Items.AddRange(new object[] {
            "JPN",
            "ENG"});
            this.ddLanguage.Location = new System.Drawing.Point(251, 99);
            this.ddLanguage.Name = "ddLanguage";
            this.ddLanguage.Size = new System.Drawing.Size(59, 23);
            this.ddLanguage.TabIndex = 4;
            // 
            // imgError
            // 
            this.imgError.BackgroundImage = global::LFI.Properties.Resources.error;
            this.imgError.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgError.Location = new System.Drawing.Point(285, 24);
            this.imgError.Name = "imgError";
            this.imgError.Size = new System.Drawing.Size(16, 16);
            this.imgError.TabIndex = 74;
            this.imgError.TabStop = false;
            this.imgError.Visible = false;
            // 
            // btnImg
            // 
            this.btnImg.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnImg.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImg.ForeColor = System.Drawing.Color.Lime;
            this.btnImg.Location = new System.Drawing.Point(10, 98);
            this.btnImg.Name = "btnImg";
            this.btnImg.Size = new System.Drawing.Size(78, 25);
            this.btnImg.TabIndex = 1;
            this.btnImg.TabStop = false;
            this.btnImg.Text = "Change Image";
            this.btnImg.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnImg.UseVisualStyleBackColor = true;
            this.btnImg.Click += new System.EventHandler(this.btnImg_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTitle.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtTitle.Cue = "<Title>";
            this.txtTitle.Location = new System.Drawing.Point(10, 46);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Restriction = LFI.RTextBox.RestrictionType.File;
            this.txtTitle.Size = new System.Drawing.Size(299, 20);
            this.txtTitle.TabIndex = 1;
            // 
            // txtEpisode
            // 
            this.txtEpisode.Cue = "<Ep>";
            this.txtEpisode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEpisode.Location = new System.Drawing.Point(94, 99);
            this.txtEpisode.MaxLength = 3;
            this.txtEpisode.Name = "txtEpisode";
            this.txtEpisode.Restriction = LFI.RTextBox.RestrictionType.Number;
            this.txtEpisode.Size = new System.Drawing.Size(52, 23);
            this.txtEpisode.TabIndex = 2;
            // 
            // txtYear
            // 
            this.txtYear.Cue = "<Year>";
            this.txtYear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtYear.Location = new System.Drawing.Point(152, 99);
            this.txtYear.MaxLength = 4;
            this.txtYear.Name = "txtYear";
            this.txtYear.Restriction = LFI.RTextBox.RestrictionType.Number;
            this.txtYear.Size = new System.Drawing.Size(75, 23);
            this.txtYear.TabIndex = 3;
            // 
            // bPanel1
            // 
            this.bPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bPanel1.BackgroundImage = global::LFI.Properties.Resources.border;
            this.bPanel1.Controls.Add(this.label4);
            this.bPanel1.Controls.Add(this.label1);
            this.bPanel1.Controls.Add(this.txtYear);
            this.bPanel1.Controls.Add(this.label2);
            this.bPanel1.Controls.Add(this.txtEpisode);
            this.bPanel1.Controls.Add(this.ddCategory);
            this.bPanel1.Controls.Add(this.txtTitle);
            this.bPanel1.Controls.Add(this.btnImg);
            this.bPanel1.Controls.Add(this.imgError);
            this.bPanel1.Controls.Add(this.ddStatus);
            this.bPanel1.Controls.Add(this.ddLanguage);
            this.bPanel1.Controls.Add(this.label6);
            this.bPanel1.Location = new System.Drawing.Point(15, 350);
            this.bPanel1.Name = "bPanel1";
            this.bPanel1.Size = new System.Drawing.Size(320, 200);
            this.bPanel1.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.label1.Location = new System.Drawing.Point(66, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 75;
            this.label1.Text = "Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.label4.Location = new System.Drawing.Point(207, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 76;
            this.label4.Text = "Status";
            // 
            // editPane
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.bPanel1);
            this.Controls.Add(this.imgTitle);
            this.DoubleBuffered = true;
            this.Name = "editPane";
            this.Size = new System.Drawing.Size(350, 550);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.editPane_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.editPane_DragEnter);
            this.contextMenuImg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgError)).EndInit();
            this.bPanel1.ResumeLayout(false);
            this.bPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgTitle;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ContextMenuStrip contextMenuImg;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ComboBox ddCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ddStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ddLanguage;
        private System.Windows.Forms.PictureBox imgError;
        private System.Windows.Forms.Button btnImg;
        private RTextBox txtTitle;
        private RTextBox txtEpisode;
        private RTextBox txtYear;
        private BPanel bPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}
