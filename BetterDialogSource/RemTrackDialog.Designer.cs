namespace LFI
{
    partial class RemTrackDialog
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.imgWorking = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radType_All = new System.Windows.Forms.RadioButton();
            this.radType_Selection = new System.Windows.Forms.RadioButton();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.txtAudio = new LFI.RTextBox();
            this.txtSubtitle = new LFI.RTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgWorking)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnOk.Location = new System.Drawing.Point(176, 72);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "Run";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCancel.Location = new System.Drawing.Point(257, 72);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tableLayoutPanel1.Controls.Add(this.imgWorking, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtAudio, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtSubtitle, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.radType_All, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.radType_Selection, 3, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(344, 107);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // imgWorking
            // 
            this.imgWorking.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.imgWorking.Image = global::LFI.Properties.Resources.progress;
            this.imgWorking.Location = new System.Drawing.Point(133, 72);
            this.imgWorking.Name = "imgWorking";
            this.imgWorking.Size = new System.Drawing.Size(30, 32);
            this.imgWorking.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgWorking.TabIndex = 9;
            this.imgWorking.TabStop = false;
            this.imgWorking.Visible = false;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 42);
            this.label5.TabIndex = 13;
            this.label5.Text = "Audio Track:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.label6.Location = new System.Drawing.Point(169, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 42);
            this.label6.TabIndex = 15;
            this.label6.Text = "Subtitle Track:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.label4.Location = new System.Drawing.Point(79, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Type:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // radType_All
            // 
            this.radType_All.AutoSize = true;
            this.radType_All.Checked = true;
            this.radType_All.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radType_All.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radType_All.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radType_All.Location = new System.Drawing.Point(169, 45);
            this.radType_All.Name = "radType_All";
            this.radType_All.Size = new System.Drawing.Size(63, 20);
            this.radType_All.TabIndex = 5;
            this.radType_All.TabStop = true;
            this.radType_All.Text = "All";
            this.radType_All.UseVisualStyleBackColor = true;
            // 
            // radType_Selection
            // 
            this.radType_Selection.AutoSize = true;
            this.radType_Selection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radType_Selection.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radType_Selection.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radType_Selection.Location = new System.Drawing.Point(238, 45);
            this.radType_Selection.Name = "radType_Selection";
            this.radType_Selection.Size = new System.Drawing.Size(103, 20);
            this.radType_Selection.TabIndex = 6;
            this.radType_Selection.Text = "Selection";
            this.radType_Selection.UseVisualStyleBackColor = true;
            // 
            // toolTip
            // 
            this.toolTip.BackColor = System.Drawing.Color.Transparent;
            this.toolTip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(126)))), ((int)(((byte)(57)))));
            // 
            // txtAudio
            // 
            this.txtAudio.Cue = "<Group>";
            this.txtAudio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAudio.Location = new System.Drawing.Point(79, 3);
            this.txtAudio.Name = "txtAudio";
            this.txtAudio.Restriction = LFI.RTextBox.RestrictionType.File;
            this.txtAudio.Size = new System.Drawing.Size(84, 20);
            this.txtAudio.TabIndex = 0;
            // 
            // txtSubtitle
            // 
            this.txtSubtitle.Cue = "<Season>";
            this.txtSubtitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSubtitle.Location = new System.Drawing.Point(238, 3);
            this.txtSubtitle.Name = "txtSubtitle";
            this.txtSubtitle.Restriction = LFI.RTextBox.RestrictionType.Number;
            this.txtSubtitle.Size = new System.Drawing.Size(103, 20);
            this.txtSubtitle.TabIndex = 1;
            // 
            // RemTrackDialog
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(344, 107);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RemTrackDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mark Files";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgWorking)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton radType_All;
        private System.Windows.Forms.RadioButton radType_Selection;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox imgWorking;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label label5;
        private RTextBox txtAudio;
        private System.Windows.Forms.Label label6;
        private RTextBox txtSubtitle;

    }
}