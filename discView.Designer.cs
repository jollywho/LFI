namespace LFI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gvDisc = new System.Windows.Forms.DataGridView();
            this.lblDisc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvDisc)).BeginInit();
            this.SuspendLayout();
            // 
            // gvDisc
            // 
            this.gvDisc.AllowUserToAddRows = false;
            this.gvDisc.AllowUserToDeleteRows = false;
            this.gvDisc.AllowUserToResizeColumns = false;
            this.gvDisc.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvDisc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.gvDisc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvDisc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.gvDisc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvDisc.DefaultCellStyle = dataGridViewCellStyle15;
            this.gvDisc.Location = new System.Drawing.Point(0, 41);
            this.gvDisc.MultiSelect = false;
            this.gvDisc.Name = "gvDisc";
            this.gvDisc.ReadOnly = true;
            this.gvDisc.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvDisc.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.gvDisc.RowHeadersVisible = false;
            this.gvDisc.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gvDisc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gvDisc.Size = new System.Drawing.Size(587, 196);
            this.gvDisc.TabIndex = 0;
            // 
            // lblDisc
            // 
            this.lblDisc.AutoSize = true;
            this.lblDisc.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisc.Location = new System.Drawing.Point(3, 0);
            this.lblDisc.Name = "lblDisc";
            this.lblDisc.Size = new System.Drawing.Size(0, 38);
            this.lblDisc.TabIndex = 1;
            // 
            // discView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblDisc);
            this.Controls.Add(this.gvDisc);
            this.Name = "discView";
            this.Size = new System.Drawing.Size(587, 465);
            this.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.discView_ControlAdded);
            this.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.discView_ControlRemoved);
            ((System.ComponentModel.ISupportInitialize)(this.gvDisc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvDisc;
        private System.Windows.Forms.Label lblDisc;




    }
}
