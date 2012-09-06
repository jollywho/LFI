namespace LFI
{
    partial class infoPane
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
            this.imgTitle = new System.Windows.Forms.PictureBox();
            this.bPanel1 = new LFI.BPanel();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.MaskedTextBox();
            this.txtEpisode = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgTitle)).BeginInit();
            this.bPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgTitle
            // 
            this.imgTitle.BackgroundImage = global::LFI.Properties.Resources.notfound;
            this.imgTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgTitle.Location = new System.Drawing.Point(53, 0);
            this.imgTitle.Name = "imgTitle";
            this.imgTitle.Size = new System.Drawing.Size(245, 345);
            this.imgTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgTitle.TabIndex = 28;
            this.imgTitle.TabStop = false;
            // 
            // bPanel1
            // 
            this.bPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bPanel1.BackgroundImage = global::LFI.Properties.Resources.border;
            this.bPanel1.Controls.Add(this.txtTitle);
            this.bPanel1.Controls.Add(this.txtCategory);
            this.bPanel1.Controls.Add(this.label5);
            this.bPanel1.Controls.Add(this.txtStatus);
            this.bPanel1.Controls.Add(this.label2);
            this.bPanel1.Controls.Add(this.label1);
            this.bPanel1.Controls.Add(this.txtYear);
            this.bPanel1.Controls.Add(this.txtEpisode);
            this.bPanel1.Controls.Add(this.label4);
            this.bPanel1.Controls.Add(this.label3);
            this.bPanel1.Location = new System.Drawing.Point(15, 350);
            this.bPanel1.Name = "bPanel1";
            this.bPanel1.Size = new System.Drawing.Size(320, 200);
            this.bPanel1.TabIndex = 29;
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.SystemColors.Control;
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTitle.ForeColor = System.Drawing.Color.Black;
            this.txtTitle.Location = new System.Drawing.Point(10, 46);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.Size = new System.Drawing.Size(300, 23);
            this.txtTitle.TabIndex = 1;
            this.txtTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCategory
            // 
            this.txtCategory.BackColor = System.Drawing.SystemColors.Control;
            this.txtCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCategory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCategory.ForeColor = System.Drawing.Color.Black;
            this.txtCategory.Location = new System.Drawing.Point(29, 150);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.ReadOnly = true;
            this.txtCategory.Size = new System.Drawing.Size(126, 23);
            this.txtCategory.TabIndex = 7;
            this.txtCategory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.label5.Location = new System.Drawing.Point(174, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Year";
            // 
            // txtStatus
            // 
            this.txtStatus.BackColor = System.Drawing.SystemColors.Control;
            this.txtStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtStatus.ForeColor = System.Drawing.Color.Black;
            this.txtStatus.Location = new System.Drawing.Point(163, 150);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(128, 23);
            this.txtStatus.TabIndex = 9;
            this.txtStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.label2.Location = new System.Drawing.Point(144, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Title";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.label1.Location = new System.Drawing.Point(94, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Episodes";
            // 
            // txtYear
            // 
            this.txtYear.BackColor = System.Drawing.SystemColors.Control;
            this.txtYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtYear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtYear.ForeColor = System.Drawing.Color.Black;
            this.txtYear.Location = new System.Drawing.Point(152, 99);
            this.txtYear.Mask = "0000";
            this.txtYear.Name = "txtYear";
            this.txtYear.ReadOnly = true;
            this.txtYear.Size = new System.Drawing.Size(75, 23);
            this.txtYear.TabIndex = 5;
            this.txtYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEpisode
            // 
            this.txtEpisode.BackColor = System.Drawing.SystemColors.Control;
            this.txtEpisode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEpisode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEpisode.ForeColor = System.Drawing.Color.Black;
            this.txtEpisode.Location = new System.Drawing.Point(94, 99);
            this.txtEpisode.Mask = "000";
            this.txtEpisode.Name = "txtEpisode";
            this.txtEpisode.ReadOnly = true;
            this.txtEpisode.Size = new System.Drawing.Size(52, 23);
            this.txtEpisode.TabIndex = 3;
            this.txtEpisode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.label4.Location = new System.Drawing.Point(207, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.label3.Location = new System.Drawing.Point(66, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Category";
            // 
            // infoPane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.bPanel1);
            this.Controls.Add(this.imgTitle);
            this.DoubleBuffered = true;
            this.Name = "infoPane";
            this.Size = new System.Drawing.Size(350, 550);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.infoPane_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.infoPane_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.imgTitle)).EndInit();
            this.bPanel1.ResumeLayout(false);
            this.bPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtEpisode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtYear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private BPanel bPanel1;

    }
}
