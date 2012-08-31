using System;
using System.Windows.Forms;
using System.Text;
using System.Text.RegularExpressions;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;

namespace LFI
{
    class RTextBox : TextBox
    {
        char[] invalidChars = Path.GetInvalidFileNameChars();
        private const int EM_SETCUEBANNER = 0x1501;
        private string mCue;
        public string Cue
        {
            get { return mCue; }
            set
            {
                mCue = value;
                SetCue(this, mCue);
            }
        }

        public enum RestrictionType
        {
            File,
            Number,
            None,
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage
          (IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);

        /// <summary>
        /// Sets a text box's cue text.
        /// </summary>
        /// <param name="textBox">The text box.</param>
        /// <param name="cue">The cue text.</param>
        public static void SetCue
          (TextBox textBox,
           string cue)
        {
            SendMessage(textBox.Handle, EM_SETCUEBANNER, 0, cue);
        }

        /// <summary>
        /// Clears a text box's cue text.
        /// </summary>
        /// <param name="textBox">The text box</param>
        public static void ClearCue
          (TextBox textBox)
        {
            SendMessage(textBox.Handle, EM_SETCUEBANNER, 0, string.Empty);
        }

        private RestrictionType mRestriction;

        [Category("Restriction")]
        [Description("asdf")]
        public RestrictionType Restriction
        {
            get { return mRestriction; }
            set { mRestriction = value; }
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
        }

        protected override void OnTextChanged(EventArgs e)
        {
            switch (mRestriction)
            {
                case RestrictionType.File:
                    TextChanged_File();
                    break;
                case RestrictionType.Number:
                    TextChanged_Number();
                    break;
            }
            base.OnTextChanged(e);
        }

        private void TextChanged_File()
        {
            int caretpos = SelectionStart;
            if (Text.IndexOfAny(invalidChars) > -1)
            {
                if (Text.Length > 1)
                    Text = Text.Remove(Text.Length - 1);
                else
                    Text = string.Empty;
            }
            SelectionStart = caretpos;
        }

        private void TextChanged_Number()
        {
            int caretpos = SelectionStart;
            if (!Regex.IsMatch(Text, @"^\d+$"))
            {
                if (Text.Length > 1)
                    Text = Text.Remove(Text.Length - 1);
                else
                    Text = string.Empty;
            }
            SelectionStart = caretpos;
        }
    }
}
