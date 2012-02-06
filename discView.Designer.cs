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
            this.txtCRC = new System.Windows.Forms.TextBox();
            this.btbCRC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCRC
            // 
            this.txtCRC.Location = new System.Drawing.Point(105, 124);
            this.txtCRC.Name = "txtCRC";
            this.txtCRC.Size = new System.Drawing.Size(100, 20);
            this.txtCRC.TabIndex = 0;
            // 
            // btbCRC
            // 
            this.btbCRC.Location = new System.Drawing.Point(353, 103);
            this.btbCRC.Name = "btbCRC";
            this.btbCRC.Size = new System.Drawing.Size(75, 23);
            this.btbCRC.TabIndex = 1;
            this.btbCRC.Text = "button1";
            this.btbCRC.UseVisualStyleBackColor = true;
            this.btbCRC.Click += new System.EventHandler(this.btbCRC_Click);
            // 
            // discView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btbCRC);
            this.Controls.Add(this.txtCRC);
            this.Name = "discView";
            this.Size = new System.Drawing.Size(587, 465);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCRC;
        private System.Windows.Forms.Button btbCRC;

    }
}
