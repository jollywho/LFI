using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LFI
{
    public partial class addView : UserControl
    {
        private MainForm caller;

        public addView(MainForm main)
        {
            InitializeComponent();
            caller = main;
        }

        private void btnAddTitle_Click(object sender, EventArgs e)
        {
            string error = "";
            try
            {
                if (ddTitle.Text.Length == 0)
                    error += "Title required or too short\n";
                if (ddTitle.Text.Contains(','))
                    error += "Illegal Char in title";
                if (ddTitle.FindStringExact(ddTitle.Text) != -1)
                    error += "Title already exists\n";
                if (ddCategory.Text.Length == 0)
                    error += "Category required\n";
                if (ddStatus.Text.Length < 3)
                    error += "Status required\n";
                if (txtYear.Text.Length < 4)
                    error += "Year required\n";
                if (ddLanguage.Text.Length < 1)
                    error += "Language required\n";
                if (txtEpisode.Text.Length < 3)
                    error += "Episode # required\n";

                if (error.Length != 0)
                {
                    MessageBox.Show(error, "Validation Error");
                }
                else
                {
                    //add
                    DB_Handle.UpdateTable(string.Format(@"INSERT INTO TITLES 
                        (title_id, episodes, year, status, language)
                        VALUES ('{0}','{1:000}','{2}','{3}','{4}');",
                        ddTitle.Text, txtEpisode.Text, txtYear.Text,
                        ddStatus.Text, ddLanguage.Text));
                    MessageBox.Show("Saved", "Success");
                    caller.load_formView(this);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void numericTextbox_keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                e.Handled = e.SuppressKeyPress = true;
        }
    }
}
