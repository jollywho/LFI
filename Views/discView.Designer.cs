﻿namespace LFI
{
    partial class discView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.scrlPage = new System.Windows.Forms.HScrollBar();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPageNo = new System.Windows.Forms.TextBox();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imgTitle = new System.Windows.Forms.PictureBox();
            this.copyLabel = new System.Windows.Forms.Label();
            this.txtSlot = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDisc = new System.Windows.Forms.MaskedTextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.gvContents = new System.Windows.Forms.DataGridView();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Season = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Start = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.End = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInsRangeEnd = new System.Windows.Forms.MaskedTextBox();
            this.txtInsRangeStart = new System.Windows.Forms.MaskedTextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.btnAddDisc = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.ddInsTitle = new System.Windows.Forms.ComboBox();
            this.lblEnd = new System.Windows.Forms.Label();
            this.txtSeason = new System.Windows.Forms.MaskedTextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblRange = new System.Windows.Forms.Label();
            this.ddLocation = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPage = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgTitle)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvContents)).BeginInit();
            this.SuspendLayout();
            // 
            // scrlPage
            // 
            this.scrlPage.Location = new System.Drawing.Point(0, 354);
            this.scrlPage.Minimum = 1;
            this.scrlPage.Name = "scrlPage";
            this.scrlPage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.scrlPage.Size = new System.Drawing.Size(734, 20);
            this.scrlPage.TabIndex = 82;
            this.scrlPage.Value = 1;
            this.scrlPage.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrlPage_Scroll);
            // 
            // btn2
            // 
            this.btn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn2.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn2.FlatAppearance.BorderSize = 0;
            this.btn2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn2.Location = new System.Drawing.Point(200, 6);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(150, 150);
            this.btn2.TabIndex = 83;
            this.btn2.TabStop = false;
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.disc_btn_Click);
            // 
            // btn3
            // 
            this.btn3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn3.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn3.FlatAppearance.BorderSize = 0;
            this.btn3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn3.Location = new System.Drawing.Point(25, 167);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(150, 150);
            this.btn3.TabIndex = 84;
            this.btn3.TabStop = false;
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.disc_btn_Click);
            // 
            // btn1
            // 
            this.btn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn1.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn1.Location = new System.Drawing.Point(24, 6);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(150, 150);
            this.btn1.TabIndex = 85;
            this.btn1.TabStop = false;
            this.btn1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.disc_btn_Click);
            // 
            // btn4
            // 
            this.btn4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn4.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn4.FlatAppearance.BorderSize = 0;
            this.btn4.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn4.Location = new System.Drawing.Point(200, 167);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(150, 150);
            this.btn4.TabIndex = 86;
            this.btn4.TabStop = false;
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.disc_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(126)))), ((int)(((byte)(57)))));
            this.label2.Location = new System.Drawing.Point(285, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 91;
            this.label2.Text = "Page #";
            // 
            // txtPageNo
            // 
            this.txtPageNo.Location = new System.Drawing.Point(333, 328);
            this.txtPageNo.Name = "txtPageNo";
            this.txtPageNo.Size = new System.Drawing.Size(74, 20);
            this.txtPageNo.TabIndex = 92;
            this.txtPageNo.TabStop = false;
            this.txtPageNo.Text = "1";
            this.txtPageNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPageNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPageNo_KeyDown);
            // 
            // btn8
            // 
            this.btn8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn8.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn8.FlatAppearance.BorderSize = 0;
            this.btn8.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn8.Location = new System.Drawing.Point(563, 167);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(150, 150);
            this.btn8.TabIndex = 96;
            this.btn8.TabStop = false;
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.disc_btn_Click);
            // 
            // btn5
            // 
            this.btn5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn5.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn5.FlatAppearance.BorderSize = 0;
            this.btn5.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn5.Location = new System.Drawing.Point(387, 6);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(150, 150);
            this.btn5.TabIndex = 95;
            this.btn5.TabStop = false;
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.disc_btn_Click);
            // 
            // btn7
            // 
            this.btn7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn7.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn7.FlatAppearance.BorderSize = 0;
            this.btn7.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn7.Location = new System.Drawing.Point(387, 167);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(150, 150);
            this.btn7.TabIndex = 94;
            this.btn7.TabStop = false;
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.disc_btn_Click);
            // 
            // btn6
            // 
            this.btn6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn6.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn6.FlatAppearance.BorderSize = 0;
            this.btn6.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn6.Location = new System.Drawing.Point(563, 6);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(150, 150);
            this.btn6.TabIndex = 93;
            this.btn6.TabStop = false;
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.disc_btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.BackgroundImage = global::LFI.Properties.Resources.borderBigg;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.imgTitle);
            this.panel1.Controls.Add(this.copyLabel);
            this.panel1.Controls.Add(this.txtSlot);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtDisc);
            this.panel1.Controls.Add(this.btnGenerate);
            this.panel1.Controls.Add(this.groupBox6);
            this.panel1.Controls.Add(this.ddLocation);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtPage);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(-10, 374);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 246);
            this.panel1.TabIndex = 97;
            // 
            // imgTitle
            // 
            this.imgTitle.BackColor = System.Drawing.Color.Transparent;
            this.imgTitle.BackgroundImage = global::LFI.Properties.Resources.notavailable;
            this.imgTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgTitle.Location = new System.Drawing.Point(534, 24);
            this.imgTitle.Name = "imgTitle";
            this.imgTitle.Size = new System.Drawing.Size(200, 217);
            this.imgTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgTitle.TabIndex = 92;
            this.imgTitle.TabStop = false;
            // 
            // copyLabel
            // 
            this.copyLabel.AutoSize = true;
            this.copyLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(126)))), ((int)(((byte)(57)))));
            this.copyLabel.Location = new System.Drawing.Point(342, 5);
            this.copyLabel.Name = "copyLabel";
            this.copyLabel.Size = new System.Drawing.Size(0, 22);
            this.copyLabel.TabIndex = 91;
            // 
            // txtSlot
            // 
            this.txtSlot.BackColor = System.Drawing.SystemColors.Control;
            this.txtSlot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSlot.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSlot.ForeColor = System.Drawing.Color.Black;
            this.txtSlot.Location = new System.Drawing.Point(284, 26);
            this.txtSlot.Mask = "000";
            this.txtSlot.Name = "txtSlot";
            this.txtSlot.ReadOnly = true;
            this.txtSlot.Size = new System.Drawing.Size(52, 22);
            this.txtSlot.TabIndex = 89;
            this.txtSlot.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSlot.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numericTextbox_keydown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(126)))), ((int)(((byte)(57)))));
            this.label1.Location = new System.Drawing.Point(293, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 16);
            this.label1.TabIndex = 90;
            this.label1.Text = "Slot";
            // 
            // txtDisc
            // 
            this.txtDisc.BackColor = System.Drawing.SystemColors.Control;
            this.txtDisc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDisc.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisc.ForeColor = System.Drawing.Color.Black;
            this.txtDisc.Location = new System.Drawing.Point(21, 26);
            this.txtDisc.Mask = "000";
            this.txtDisc.Name = "txtDisc";
            this.txtDisc.ReadOnly = true;
            this.txtDisc.Size = new System.Drawing.Size(88, 22);
            this.txtDisc.TabIndex = 88;
            this.txtDisc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.ForeColor = System.Drawing.Color.Black;
            this.btnGenerate.Location = new System.Drawing.Point(124, 26);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 87;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.Transparent;
            this.groupBox6.Controls.Add(this.gvContents);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.txtInsRangeEnd);
            this.groupBox6.Controls.Add(this.txtInsRangeStart);
            this.groupBox6.Controls.Add(this.button5);
            this.groupBox6.Controls.Add(this.btnAddDisc);
            this.groupBox6.Controls.Add(this.button6);
            this.groupBox6.Controls.Add(this.ddInsTitle);
            this.groupBox6.Controls.Add(this.lblEnd);
            this.groupBox6.Controls.Add(this.txtSeason);
            this.groupBox6.Controls.Add(this.label21);
            this.groupBox6.Controls.Add(this.lblStart);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.lblRange);
            this.groupBox6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(126)))), ((int)(((byte)(57)))));
            this.groupBox6.Location = new System.Drawing.Point(18, 58);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(510, 183);
            this.groupBox6.TabIndex = 83;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Contents";
            // 
            // gvContents
            // 
            this.gvContents.AllowUserToAddRows = false;
            this.gvContents.AllowUserToDeleteRows = false;
            this.gvContents.AllowUserToResizeColumns = false;
            this.gvContents.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(126)))), ((int)(((byte)(57)))));
            this.gvContents.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.gvContents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvContents.BackgroundColor = System.Drawing.Color.White;
            this.gvContents.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gvContents.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gvContents.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gvContents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvContents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.Season,
            this.Start,
            this.End});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(126)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(143)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvContents.DefaultCellStyle = dataGridViewCellStyle6;
            this.gvContents.Location = new System.Drawing.Point(6, 60);
            this.gvContents.MultiSelect = false;
            this.gvContents.Name = "gvContents";
            this.gvContents.ReadOnly = true;
            this.gvContents.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gvContents.RowHeadersVisible = false;
            this.gvContents.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gvContents.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gvContents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvContents.Size = new System.Drawing.Size(381, 112);
            this.gvContents.StandardTab = true;
            this.gvContents.TabIndex = 77;
            // 
            // Title
            // 
            this.Title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Title.FillWeight = 65F;
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Season
            // 
            this.Season.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Season.FillWeight = 25.60142F;
            this.Season.HeaderText = "Season";
            this.Season.Name = "Season";
            this.Season.ReadOnly = true;
            this.Season.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Season.Width = 55;
            // 
            // Start
            // 
            this.Start.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Start.FillWeight = 75.52417F;
            this.Start.HeaderText = "Start";
            this.Start.Name = "Start";
            this.Start.ReadOnly = true;
            this.Start.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Start.Width = 40;
            // 
            // End
            // 
            this.End.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.End.FillWeight = 75.52417F;
            this.End.HeaderText = "End";
            this.End.Name = "End";
            this.End.ReadOnly = true;
            this.End.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.End.Width = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(428, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 76;
            this.label3.Text = "Range";
            // 
            // txtInsRangeEnd
            // 
            this.txtInsRangeEnd.BackColor = System.Drawing.SystemColors.Control;
            this.txtInsRangeEnd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInsRangeEnd.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInsRangeEnd.ForeColor = System.Drawing.Color.Black;
            this.txtInsRangeEnd.Location = new System.Drawing.Point(451, 33);
            this.txtInsRangeEnd.Mask = "000";
            this.txtInsRangeEnd.Name = "txtInsRangeEnd";
            this.txtInsRangeEnd.PromptChar = ' ';
            this.txtInsRangeEnd.Size = new System.Drawing.Size(50, 22);
            this.txtInsRangeEnd.TabIndex = 75;
            this.txtInsRangeEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtInsRangeEnd.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtInsRangeEnd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numericTextbox_keydown);
            // 
            // txtInsRangeStart
            // 
            this.txtInsRangeStart.BackColor = System.Drawing.SystemColors.Control;
            this.txtInsRangeStart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInsRangeStart.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInsRangeStart.ForeColor = System.Drawing.Color.Black;
            this.txtInsRangeStart.Location = new System.Drawing.Point(393, 33);
            this.txtInsRangeStart.Mask = "000";
            this.txtInsRangeStart.Name = "txtInsRangeStart";
            this.txtInsRangeStart.PromptChar = ' ';
            this.txtInsRangeStart.Size = new System.Drawing.Size(52, 22);
            this.txtInsRangeStart.TabIndex = 68;
            this.txtInsRangeStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtInsRangeStart.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtInsRangeStart.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numericTextbox_keydown);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(411, 119);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "Remove";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAddDisc
            // 
            this.btnAddDisc.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDisc.ForeColor = System.Drawing.Color.Black;
            this.btnAddDisc.Location = new System.Drawing.Point(411, 148);
            this.btnAddDisc.Name = "btnAddDisc";
            this.btnAddDisc.Size = new System.Drawing.Size(75, 23);
            this.btnAddDisc.TabIndex = 46;
            this.btnAddDisc.Text = "Save";
            this.btnAddDisc.UseVisualStyleBackColor = true;
            this.btnAddDisc.Click += new System.EventHandler(this.btnSaveClick);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Location = new System.Drawing.Point(411, 90);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 4;
            this.button6.Text = "Insert";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // ddInsTitle
            // 
            this.ddInsTitle.BackColor = System.Drawing.SystemColors.Control;
            this.ddInsTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ddInsTitle.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddInsTitle.ForeColor = System.Drawing.Color.Black;
            this.ddInsTitle.FormattingEnabled = true;
            this.ddInsTitle.Location = new System.Drawing.Point(6, 33);
            this.ddInsTitle.Name = "ddInsTitle";
            this.ddInsTitle.Size = new System.Drawing.Size(323, 24);
            this.ddInsTitle.TabIndex = 72;
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnd.Location = new System.Drawing.Point(459, 58);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(35, 16);
            this.lblEnd.TabIndex = 74;
            this.lblEnd.Text = "(End)";
            // 
            // txtSeason
            // 
            this.txtSeason.BackColor = System.Drawing.SystemColors.Control;
            this.txtSeason.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSeason.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeason.ForeColor = System.Drawing.Color.Black;
            this.txtSeason.Location = new System.Drawing.Point(335, 33);
            this.txtSeason.Mask = "00";
            this.txtSeason.Name = "txtSeason";
            this.txtSeason.PromptChar = ' ';
            this.txtSeason.Size = new System.Drawing.Size(52, 22);
            this.txtSeason.TabIndex = 67;
            this.txtSeason.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSeason.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtSeason.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numericTextbox_keydown);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(151, 14);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(32, 16);
            this.label21.TabIndex = 66;
            this.label21.Text = "Title";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.Location = new System.Drawing.Point(399, 58);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(41, 16);
            this.lblStart.TabIndex = 73;
            this.lblStart.Text = "(Start)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(339, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 16);
            this.label9.TabIndex = 71;
            this.label9.Text = "Season";
            // 
            // lblRange
            // 
            this.lblRange.AutoSize = true;
            this.lblRange.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRange.Location = new System.Drawing.Point(443, 33);
            this.lblRange.Name = "lblRange";
            this.lblRange.Size = new System.Drawing.Size(12, 16);
            this.lblRange.TabIndex = 70;
            this.lblRange.Text = "-";
            // 
            // ddLocation
            // 
            this.ddLocation.BackColor = System.Drawing.SystemColors.Control;
            this.ddLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddLocation.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ddLocation.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddLocation.ForeColor = System.Drawing.Color.Black;
            this.ddLocation.FormattingEnabled = true;
            this.ddLocation.Location = new System.Drawing.Point(392, 24);
            this.ddLocation.Name = "ddLocation";
            this.ddLocation.Size = new System.Drawing.Size(136, 24);
            this.ddLocation.TabIndex = 82;
            this.ddLocation.SelectedIndexChanged += new System.EventHandler(this.ddLocation_SelectedIndexChanged);
            this.ddLocation.SelectedValueChanged += new System.EventHandler(this.ddLocation_SelectedValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(126)))), ((int)(((byte)(57)))));
            this.label7.Location = new System.Drawing.Point(435, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 16);
            this.label7.TabIndex = 86;
            this.label7.Text = "Location";
            // 
            // txtPage
            // 
            this.txtPage.BackColor = System.Drawing.SystemColors.Control;
            this.txtPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPage.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPage.ForeColor = System.Drawing.Color.Black;
            this.txtPage.Location = new System.Drawing.Point(215, 26);
            this.txtPage.Mask = "000";
            this.txtPage.Name = "txtPage";
            this.txtPage.ReadOnly = true;
            this.txtPage.Size = new System.Drawing.Size(52, 22);
            this.txtPage.TabIndex = 81;
            this.txtPage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numericTextbox_keydown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(126)))), ((int)(((byte)(57)))));
            this.label8.Location = new System.Drawing.Point(224, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 16);
            this.label8.TabIndex = 84;
            this.label8.Text = "Page";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(126)))), ((int)(((byte)(57)))));
            this.label11.Location = new System.Drawing.Point(42, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 16);
            this.label11.TabIndex = 85;
            this.label11.Text = "Disc ID";
            // 
            // toolTip
            // 
            this.toolTip.AutoPopDelay = 50;
            this.toolTip.BackColor = System.Drawing.Color.Transparent;
            this.toolTip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(126)))), ((int)(((byte)(57)))));
            this.toolTip.InitialDelay = 500;
            this.toolTip.ReshowDelay = 100;
            // 
            // discView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.txtPageNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.scrlPage);
            this.Controls.Add(this.panel1);
            this.Name = "discView";
            this.Size = new System.Drawing.Size(737, 620);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgTitle)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvContents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.HScrollBar scrlPage;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPageNo;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox imgTitle;
        private System.Windows.Forms.Label copyLabel;
        private System.Windows.Forms.MaskedTextBox txtSlot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtDisc;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.MaskedTextBox txtInsRangeEnd;
        private System.Windows.Forms.MaskedTextBox txtInsRangeStart;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnAddDisc;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ComboBox ddInsTitle;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.MaskedTextBox txtSeason;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblRange;
        private System.Windows.Forms.ComboBox ddLocation;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtPage;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView gvContents;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Season;
        private System.Windows.Forms.DataGridViewTextBoxColumn Start;
        private System.Windows.Forms.DataGridViewTextBoxColumn End;
        private System.Windows.Forms.ToolTip toolTip;
    }
}
