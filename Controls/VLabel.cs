using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace LFI
{
	public class VLabel : System.Windows.Forms.Label
	{
		private bool bFlip = true;

		public VLabel()
		{
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			Graphics g = e.Graphics;

			StringFormat stringFormat = new StringFormat();
			stringFormat.Alignment = StringAlignment.Center;
			stringFormat.Trimming = StringTrimming.None;
			stringFormat.FormatFlags = StringFormatFlags.DirectionVertical;

			Brush textBrush = new SolidBrush(Color.Black);
		
			Matrix storedState = g.Transform;

			if (bFlip)
			{
				g.RotateTransform(180f);

				g.TranslateTransform(-ClientRectangle.Width, 
									 -ClientRectangle.Height);
			}

			g.DrawString(
				this.Text,
				this.Font,
				textBrush,
				ClientRectangle,
				stringFormat);

			g.Transform = storedState;
		}

		[Description("When this parameter is true the VLabel flips at 180 degrees."),Category("Appearance")]
		public bool Flip180
		{
			get
			{
				return bFlip;
			}
			set
			{
				bFlip = value;
				this.Invalidate();
			}
		}

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // VLabel
            // 
            this.Font = new System.Drawing.Font("Segoe UI Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.ResumeLayout(false);

        }
	}
}
