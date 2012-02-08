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
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnImg = new System.Windows.Forms.Button();
            this.imgTitle = new System.Windows.Forms.PictureBox();
            this.txtYear = new System.Windows.Forms.MaskedTextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtEpisode = new System.Windows.Forms.MaskedTextBox();
            this.gvTitles = new System.Windows.Forms.DataGridView();
            this.contextMenuDisc = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuItemDisc = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTitles)).BeginInit();
            this.contextMenuDisc.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(326, 257);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.Size = new System.Drawing.Size(219, 22);
            this.txtTitle.TabIndex = 2;
            // 
            // txtCategory
            // 
            this.txtCategory.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategory.Location = new System.Drawing.Point(326, 321);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.ReadOnly = true;
            this.txtCategory.Size = new System.Drawing.Size(219, 22);
            this.txtCategory.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(215, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Eps";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(215, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(215, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(215, 385);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(215, 353);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Year";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(6, 19);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(169, 22);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnImg.Location = new System.Drawing.Point(413, 225);
            this.btnImg.Name = "btnImg";
            this.btnImg.Size = new System.Drawing.Size(50, 20);
            this.btnImg.TabIndex = 18;
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
            this.imgTitle.Location = new System.Drawing.Point(336, 19);
            this.imgTitle.Name = "imgTitle";
            this.imgTitle.Size = new System.Drawing.Size(200, 200);
            this.imgTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgTitle.TabIndex = 19;
            this.imgTitle.TabStop = false;
            // 
            // txtYear
            // 
            this.txtYear.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYear.Location = new System.Drawing.Point(326, 353);
            this.txtYear.Mask = "0000";
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(33, 22);
            this.txtYear.TabIndex = 5;
            // 
            // txtStatus
            // 
            this.txtStatus.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.Location = new System.Drawing.Point(326, 385);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(219, 22);
            this.txtStatus.TabIndex = 6;
            // 
            // txtEpisode
            // 
            this.txtEpisode.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEpisode.Location = new System.Drawing.Point(326, 289);
            this.txtEpisode.Mask = "000";
            this.txtEpisode.Name = "txtEpisode";
            this.txtEpisode.Size = new System.Drawing.Size(33, 22);
            this.txtEpisode.TabIndex = 3;
            // 
            // gvTitles
            // 
            this.gvTitles.AllowUserToAddRows = false;
            this.gvTitles.AllowUserToDeleteRows = false;
            this.gvTitles.AllowUserToResizeColumns = false;
            this.gvTitles.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvTitles.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gvTitles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvTitles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvTitles.ColumnHeadersVisible = false;
            this.gvTitles.ContextMenuStrip = this.contextMenuDisc;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvTitles.DefaultCellStyle = dataGridViewCellStyle2;
            this.gvTitles.Location = new System.Drawing.Point(0, 59);
            this.gvTitles.MultiSelect = false;
            this.gvTitles.Name = "gvTitles";
            this.gvTitles.ReadOnly = true;
            this.gvTitles.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gvTitles.RowHeadersVisible = false;
            this.gvTitles.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gvTitles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gvTitles.Size = new System.Drawing.Size(184, 403);
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
            this.contextMenuDisc.Size = new System.Drawing.Size(153, 48);
            // 
            // contextMenuItemDisc
            // 
            this.contextMenuItemDisc.Name = "contextMenuItemDisc";
            this.contextMenuItemDisc.Size = new System.Drawing.Size(152, 22);
            this.contextMenuItemDisc.Text = "View Disc";
            this.contextMenuItemDisc.Click += new System.EventHandler(this.contextMenuItemDisc_Click);
            // 
            // mainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gvTitles);
            this.Controls.Add(this.txtEpisode);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.btnImg);
            this.Controls.Add(this.imgTitle);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.txtTitle);
            this.Name = "mainView";
            this.Size = new System.Drawing.Size(587, 465);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTitles)).EndInit();
            this.contextMenuDisc.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnImg;
        private System.Windows.Forms.PictureBox imgTitle;
        private System.Windows.Forms.MaskedTextBox txtYear;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.MaskedTextBox txtEpisode;
        private System.Windows.Forms.DataGridView gvTitles;
        private System.Windows.Forms.ContextMenuStrip contextMenuDisc;
        private System.Windows.Forms.ToolStripMenuItem contextMenuItemDisc;
    }
}
