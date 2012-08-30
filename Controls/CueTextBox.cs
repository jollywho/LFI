using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace LFI
{
    class CueTextBox : TextBox
    {
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
    }
}