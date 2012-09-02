using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace LFI
{
    /// <summary>
    /// An improved dialog, with OS styling, an icon, a large header, and smaller explanation text.
    /// </summary>
    public partial class BetterDialog : Form
    {
        public enum ImageStyle
        {
            Icon,
            Image,
        }
        /// <summary>
        /// Create a special dialog in the style of Windows XP or Vista. A dialog has a custom icon, an optional large
        /// title in the form, body text, window text, and one or two custom-labeled buttons.
        /// </summary>
        /// <param name="titleString">This string will be displayed in the system window frame.</param>
        /// <param name="bigString">This is the first string to appear in the dialog. It will be most prominent.</param>
        /// <param name="smallString">This string appears either under the big string, or is null, which means it is
        /// not displayed at all.</param>
        /// <param name="leftButton">This is the left button, typically the "accept" button--label it with an
        /// action verb (or "OK").</param>
        /// <param name="rightButton">The right button--typically "Cancel", but could be "No".</param>
        /// <param name="iconSet">An image to be displayed on the left side of the dialog. Should be 32 x 32 pixels.</param>
        static public DialogResult ShowDialog(string title, string largeHeading, string smallExplanation,
            string leftButton, string rightButton, Image iconSet, ImageStyle iconDock)
        {
            using (BetterDialog dialog = new BetterDialog(title, largeHeading, smallExplanation, leftButton,
                rightButton, iconSet, iconDock))
            {
                DialogResult result = dialog.ShowDialog();
                return result;
            }
        }

        /// <summary>
        /// The private constructor. This is only called by the static method ShowDialog.
        /// </summary>
        private BetterDialog(string title, string largeHeading, string smallExplanation,
            string leftButton, string rightButton, Image iconSet, ImageStyle iconDock)
        {
            this.Font = SystemFonts.MessageBoxFont;
            this.ForeColor = SystemColors.WindowText;
            
            InitializeComponent();

            if (iconDock == ImageStyle.Icon)
                this.pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            else
                this.pictureBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left;

            // set our width and height to these values (redundant, but who cares?)
            this.Width = 350;

            using (Graphics graphics = this.CreateGraphics())
            {
                SizeF smallSize;
                SizeF bigSize;

                if (string.IsNullOrEmpty(smallExplanation) == false)
                {
                    if (SystemFonts.MessageBoxFont.FontFamily.Name == "Segoe UI")
                    {
                        // use the special, windows-vista font style if we are running vista (using Segoe UI).
                        label1.ForeColor = Color.FromArgb(0, 51, 153); // [ColorTranslator.FromHtml("#003399")]
                        label1.Font = new Font("Segoe UI", 12.0f, FontStyle.Regular, GraphicsUnit.Point);

                        // bigger for vista/aero
                        this.Width += 50;

                        label1.Width += 50;
                        label2.Width += 50;

                        smallSize = graphics.MeasureString(smallExplanation, this.Font, this.label2.Width);
                        bigSize = graphics.MeasureString(largeHeading, label1.Font, this.label1.Width);
                    }
                    else
                    {
                        // might want to special case the old, MS Sans Serif font.
                        // use the regular font but bold it for XP, etc.
                        label1.Font = new Font(SystemFonts.MessageBoxFont.FontFamily.Name, 8.0f,
                            FontStyle.Bold, GraphicsUnit.Point);

                        smallSize = graphics.MeasureString(smallExplanation, this.Font, this.label2.Width);
                        bigSize = graphics.MeasureString(largeHeading, label1.Font, this.label1.Width);

                        // set our height according to the small string
                        this.Height = (int)smallSize.Height + 166; // went from 164 to 168 to improve bottom space on XP.
                        // removed 2 pixels for XP
                    }

                    // modify our width (clean this up a bit) based on the longest text's width
                    double bigger = (smallSize.Width > bigSize.Width) ? smallSize.Width : bigSize.Width;
                    this.Width = (int)bigger + 100;
                }
                else
                {
                    // do layout for a single-message dialog
                    // reduce size for plain dialog
                    this.Width -= 20;

                    // this is our text's dimensions
                    bigSize = graphics.MeasureString(largeHeading, label1.Font, label1.Width);

                    // remove the top margin from the label (everything is vertically centered)
                    label1.Margin = new Padding(label1.Margin.Left, 0, label1.Margin.Right, label1.Margin.Bottom);

                    // modify our width (clean this up a bit) based on text's physical width
                    this.Width = (int)bigSize.Width + 100;

                    this.Height -= tableLayoutPanel2.Height;
                }
            }

            // expand to be at least 260 pixels
            if (this.Width < 260)
            {
                this.Width = 260;
            }

            // set our text
            this.Text = title;
            label1.Text = largeHeading;
            label2.Text = string.IsNullOrEmpty(smallExplanation) ? string.Empty : smallExplanation;

            // setup our left button (optional)
            if (string.IsNullOrEmpty(leftButton) == false)
            {
                // if we have the button, we are fine
                this.buttonLeft.Text = leftButton;
            }
            else
            {
                // move settings to right button if we don't have the left button
                this.AcceptButton = buttonRight;
                this.buttonLeft.Visible = false;
            }

            // this button must always be present
            this.buttonRight.Text = rightButton;
            pictureBox1.Image = iconSet;
        }
    }
}
