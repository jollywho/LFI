namespace LFI
{
    partial class mainView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnImg = new System.Windows.Forms.Button();
            this.imgTitle = new System.Windows.Forms.PictureBox();
            this.gvTitles = new System.Windows.Forms.DataGridView();
            this.contextMenuDisc = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuItemDisc = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEpisode = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTitles)).BeginInit();
            this.contextMenuDisc.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.Black;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(126)))), ((int)(((byte)(57)))));
            this.txtSearch.Location = new System.Drawing.Point(6, 19);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(169, 24);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(126)))), ((int)(((byte)(57)))));
            this.groupBox1.Location = new System.Drawing.Point(3, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(181, 53);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // btnImg
            // 
            this.btnImg.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnImg.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImg.ForeColor = System.Drawing.Color.Lime;
            this.btnImg.Location = new System.Drawing.Point(334, 240);
            this.btnImg.Name = "btnImg";
            this.btnImg.Size = new System.Drawing.Size(50, 20);
            this.btnImg.TabIndex = 3;
            this.btnImg.TabStop = false;
            this.btnImg.Text = "...";
            this.btnImg.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnImg.UseVisualStyleBackColor = true;
            this.btnImg.Click += new System.EventHandler(this.btnImg_Click);
            // 
            // imgTitle
            // 
            this.imgTitle.BackgroundImage = global::LFI.Properties.Resources.notfound;
            this.imgTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imgTitle.Location = new System.Drawing.Point(252, 34);
            this.imgTitle.Name = "imgTitle";
            this.imgTitle.Size = new System.Drawing.Size(200, 200);
            this.imgTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgTitle.TabIndex = 19;
            this.imgTitle.TabStop = false;
            // 
            // gvTitles
            // 
            this.gvTitles.AllowUserToAddRows = false;
            this.gvTitles.AllowUserToDeleteRows = false;
            this.gvTitles.AllowUserToResizeColumns = false;
            this.gvTitles.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(126)))), ((int)(((byte)(57)))));
            this.gvTitles.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gvTitles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvTitles.BackgroundColor = System.Drawing.Color.Black;
            this.gvTitles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvTitles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gvTitles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvTitles.ColumnHeadersVisible = false;
            this.gvTitles.ContextMenuStrip = this.contextMenuDisc;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(126)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(143)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvTitles.DefaultCellStyle = dataGridViewCellStyle2;
            this.gvTitles.Location = new System.Drawing.Point(0, 59);
            this.gvTitles.MultiSelect = false;
            this.gvTitles.Name = "gvTitles";
            this.gvTitles.ReadOnly = true;
            this.gvTitles.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gvTitles.RowHeadersVisible = false;
            this.gvTitles.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gvTitles.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gvTitles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gvTitles.Size = new System.Drawing.Size(184, 408);
            this.gvTitles.StandardTab = true;
            this.gvTitles.TabIndex = 1;
            this.gvTitles.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvTitles_RowEnter);
            this.gvTitles.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gvTitles_KeyDown);
            this.gvTitles.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gvTitles_MouseDown);
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
            this.contextMenuItemDisc.Click += new System.EventHandler(this.contextMenuItemDisc_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTitle);
            this.groupBox2.Controls.Add(this.txtCategory);
            this.groupBox2.Controls.Add(this.txtStatus);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtEpisode);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtYear);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(126)))), ((int)(((byte)(57)))));
            this.groupBox2.Location = new System.Drawing.Point(195, 263);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(319, 201);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Details";
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.Color.Black;
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTitle.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(126)))), ((int)(((byte)(57)))));
            this.txtTitle.Location = new System.Drawing.Point(6, 46);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.Size = new System.Drawing.Size(300, 22);
            this.txtTitle.TabIndex = 0;
            this.txtTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCategory
            // 
            this.txtCategory.BackColor = System.Drawing.Color.Black;
            this.txtCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCategory.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(126)))), ((int)(((byte)(57)))));
            this.txtCategory.Location = new System.Drawing.Point(13, 99);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.ReadOnly = true;
            this.txtCategory.Size = new System.Drawing.Size(135, 22);
            this.txtCategory.TabIndex = 1;
            this.txtCategory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtStatus
            // 
            this.txtStatus.BackColor = System.Drawing.Color.Black;
            this.txtStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStatus.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(126)))), ((int)(((byte)(57)))));
            this.txtStatus.Location = new System.Drawing.Point(87, 152);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(138, 22);
            this.txtStatus.TabIndex = 4;
            this.txtStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 35;
            this.label1.Text = "Episodes";
            // 
            // txtEpisode
            // 
            this.txtEpisode.BackColor = System.Drawing.Color.Black;
            this.txtEpisode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEpisode.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEpisode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(126)))), ((int)(((byte)(57)))));
            this.txtEpisode.Location = new System.Drawing.Point(177, 99);
            this.txtEpisode.Mask = "000";
            this.txtEpisode.Name = "txtEpisode";
            this.txtEpisode.ReadOnly = true;
            this.txtEpisode.Size = new System.Drawing.Size(52, 22);
            this.txtEpisode.TabIndex = 2;
            this.txtEpisode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 37;
            this.label3.Text = "Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(136, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 38;
            this.label4.Text = "Status";
            // 
            // txtYear
            // 
            this.txtYear.BackColor = System.Drawing.Color.Black;
            this.txtYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtYear.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(126)))), ((int)(((byte)(57)))));
            this.txtYear.Location = new System.Drawing.Point(242, 99);
            this.txtYear.Mask = "0000";
            this.txtYear.Name = "txtYear";
            this.txtYear.ReadOnly = true;
            this.txtYear.Size = new System.Drawing.Size(52, 22);
            this.txtYear.TabIndex = 3;
            this.txtYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(140, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 36;
            this.label2.Text = "Title";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(253, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 16);
            this.label5.TabIndex = 39;
            this.label5.Text = "Year";
            // 
            // mainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gvTitles);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.imgTitle);
            this.Controls.Add(this.btnImg);
            this.Name = "mainView";
            this.Size = new System.Drawing.Size(524, 467);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTitles)).EndInit();
            this.contextMenuDisc.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnImg;
        private System.Windows.Forms.PictureBox imgTitle;
        private System.Windows.Forms.DataGridView gvTitles;
        private System.Windows.Forms.ContextMenuStrip contextMenuDisc;
        private System.Windows.Forms.ToolStripMenuItem contextMenuItemDisc;
        private System.Windows.Forms.GroupBox groupBox2;
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
    }
}
