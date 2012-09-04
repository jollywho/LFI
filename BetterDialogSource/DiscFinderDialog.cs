using System;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LFI
{
    public partial class DiscFinderDialog : Form
    {
        public static string Disc;
        public static string Page;
        public static int Slot;
        public static string Location;

        private DiscFinderDialog()
        {
            InitializeComponent();

            this.TopMost = MainForm.Main.TopMost;

            DataTable locations = DB_Handle.GetDataTable(string.Format(
                @"Select location_id from locations order by location_id"));
            ddLocation.DisplayMember = "location_id";
            ddLocation.DataSource = locations;
        }

        public static DialogResult ShowDialog()
        {
            using (DiscFinderDialog dlg = new DiscFinderDialog())
            {
                return dlg.ShowDialog(MainForm.Main);
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!ValidateFields()) return;
            string filename = string.Empty;
            try
            {
                DataTable dt = DB_Handle.GetDataTable(
                    string.Format(@"SELECT * from DISCS WHERE disc_id='{0}' and location_id='{1}'",
                    txtDisc.Text, ddLocation.Text));
                if (dt.Rows.Count < 1)
                {
                    Error_Handle.TipError("No Results Found.", toolTip, imgError);
                }
                else
                {
                    Disc = dt.Rows[0][0].ToString();
                    Page = dt.Rows[0][1].ToString();
                    Slot = Convert.ToInt32(dt.Rows[0][2]);
                    Location = ddLocation.Text;
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
            catch (Exception ex)
            {
                Error_Handle.TipError("Error Finding Disc : " + ex.Message, toolTip, imgError);
            }
        }

        private bool ValidateFields()
        {
            if (txtDisc.Text.Length < 1)
            {
                Error_Handle.TipError("Disc ID Required\n", toolTip, txtDisc);
                return false;
            }
            return true;
        }

        private void txtDisc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btnOk.PerformClick();
            }
        }
    }
}
