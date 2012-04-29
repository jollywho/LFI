using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LFI
{
    public partial class discView : UserControl
    {
        private int currentPage = 1;
        const int DISCS_PER_PAGE = 8;
        private int max_pages = 0;
        private DataTable dtView;
        VLabel[] dLabels = new VLabel[DISCS_PER_PAGE];

        public discView()
        {
            InitializeComponent();
            DataTable locations = DB_Handle.GetDataTable(string.Format(
                @"Select location_id from locations order by location_id"));
            ddLocation.DisplayMember = "location_id";
            ddLocation.DataSource = locations;
            
            
            DataTable titles = DB_Handle.GetDataTable(string.Format(
                @"Select title_id from titles order by title_id"));
            ddInsTitle.DataSource = titles;
            ddInsTitle.DisplayMember = "title_id";

            //Rectangle cropRect = new Rectangle();
            //Bitmap src = Image.FromFile("image\\Air TV.jpg") as Bitmap;
            //Bitmap target = new Bitmap(cropRect.Width, cropRect.Height);
            //using (Graphics g = Graphics.FromImage(target))
            //{
            //    g.DrawImage(src, new Rectangle(0, 0, target.Width, target.Height),
            //        cropRect,
            //        GraphicsUnit.Pixel);
            //}

            Image src = Image_IO.resize_Image(Image.FromFile("image\\Air TV.jpg"), btn1.Width, btn1.Height/2);
            Image src2 = Image_IO.resize_Image(Image.FromFile("image\\Air TV.jpg"), btn1.Width, btn1.Height / 2);

            btn1.BackgroundImage = Image_IO.merge_Images(src, src2, btn1.Width, btn1.Height);

            for (int i = 1; i <= DISCS_PER_PAGE; i++)
            {
                Button btn = (Button)this.Controls[("btn" + i).ToString()];
                dLabels[i-1] = createVertLabel(btn, copyLabel, "");
                Controls.Add(dLabels[i - 1]);
            }

            loadView();
        }

        private void loadView()
        {
            dtView = DB_Handle.GetDataTable(string.Format(@"select * from discs
                where location_id='{0}'", ddLocation.Text));
            if (dtView.Rows.Count % DISCS_PER_PAGE != 0 && dtView.Rows.Count > 0)
                max_pages = dtView.Rows.Count / 8;
            else
                max_pages = (dtView.Rows.Count / 8) + 1;
            scrlPage.Maximum = max_pages;
            loadPage();
        }

        private void loadPage()
        {
            for (int i = 1; i <= DISCS_PER_PAGE; i++)
            {
                DataTable temp = DB_Handle.GetDataTable(string.Format(@"select * from discs
                    where location_id='{0}' and page_number='{1}' and slot_number='{2}'",
                     ddLocation.Text, txtPageNo.Text, i.ToString()));
                if (temp.Rows.Count != 0)
                    dLabels[i-1].Text = temp.Rows[0][0].ToString();
                else
                    dLabels[i-1].Text = "Empty";
            }
        }

        private VLabel createVertLabel(Button btn, Label copylabel, string text)
        {
            VLabel lbl = new VLabel();
            lbl.Text = text;
            lbl.Font = copylabel.Font;
            lbl.ForeColor = copylabel.ForeColor;
            lbl.Size = new System.Drawing.Size(18, btn.Height);
            Point point = btn.Location;
            point.X -= lbl.Size.Width;
            lbl.Location = point;
            return lbl;
        }

        private void numericTextbox_keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                e.Handled = e.SuppressKeyPress = true;
        }

        private void ddInsRangeType_SelectedValueChanged(object sender, EventArgs e)
        {
            txtInsRangeStart.Hide();
            txtInsRangeEnd.Hide();
            lblStart.Hide();
            lblEnd.Hide();
            lblRange.Hide();
            txtInsRangeStart.Clear();
            txtInsRangeEnd.Clear();

            if (ddInsRangeType.Text == "Item")
            {
                txtInsRangeStart.Show();
                lblStart.Show();
                lblStart.Text = "Ep #";
            }
            else if (ddInsRangeType.Text == "Range")
            {
                txtInsRangeStart.Show();
                txtInsRangeEnd.Show();
                lblStart.Text = "Start";
                lblEnd.Text = "End";
                lblRange.Show();
                lblStart.Show();
                lblEnd.Show();
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string error = "";
            if (ddInsTitle.Text.Length > 0 && ddInsTitle.FindStringExact(ddInsTitle.Text) != -1)
            {
                if (ddInsRangeType.Text == "")
                    error += "Range type required\n";
                if (ddInsRangeType.Text == "Item" && txtInsRangeStart.Text.Length < 3)
                    error += "Item required\n";
                if (ddInsRangeType.Text == "Range" &&
                    txtInsRangeStart.Text.Length < 3 && txtInsRangeEnd.Text.Length < 3)
                    error += "range required\n";
                if (txtSeason.Text.Length < 2)
                    error += "Season required\n";

                if (error != "")
                {
                    MessageBox.Show(error, "Validation Error");
                    return;
                }
                else
                {
                    switch (ddInsRangeType.Text)
                    {
                        case "Item":
                            lstContents.Items.Add(ddInsTitle.Text + "," +
                                txtSeason.Text + "," + txtInsRangeStart.Text);
                            break;
                        case "Range":
                            lstContents.Items.Add(ddInsTitle.Text + "," +
                                txtSeason.Text + "," + txtInsRangeStart.Text +
                                "-" + txtInsRangeEnd.Text);

                            break;
                        case "Full":
                            lstContents.Items.Add(ddInsTitle.Text + "," +
                                txtSeason.Text + "," + "Full");
                            break;
                    }

                    txtSeason.Clear();
                    ddInsTitle.SelectedText = "";
                    txtInsRangeStart.Clear();
                    txtInsRangeEnd.Clear();
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstContents.Items.Count > 0)
                lstContents.Items.RemoveAt(lstContents.SelectedIndex);
        }

        private void btnSaveClick(object sender, EventArgs e)
        {
            string error = "";
            bool rollbackpos = false;

            if (txtDisc.Text.Length < 1)
                error += "Disc required\n";
            if (txtPage.Text.Length < 3)
                error += "Page required\n";
            if (ddLocation.Text.Length < 1)
                error += "Location required\n";
            if (lstContents.Items.Count < 1)
                error += "Content required\n";

            if (error.Length != 0)
            {
                MessageBox.Show(error, "Validation Error");
            }
            else
            {
                try
                {
                    DB_Handle.UpdateTable(string.Format(
                        @"INSERT INTO DISCS 
                        (disc_id, page_number, location_id)
                        VALUES ('{0:000}','{1:000}','{2:000}');",
                        txtDisc.Text, txtPage.Text, ddLocation.Text));
                    rollbackpos = true;

                    foreach (string str in lstContents.Items)
                    {
                        string[] item = str.Split(',');
                        DB_Handle.UpdateTable(string.Format(
                            @"INSERT INTO DISC_CONTENTS 
                            (disc_id, title_id, season, range)
                            VALUES ('{0:000}','{1:000}','{2:000}','{3}');",
                            txtDisc.Text, item[0], item[1], item[2]));
                    }
                    MessageBox.Show("Saved", "Success");
                }
                catch (Exception ex)
                {
                    if (rollbackpos)
                        DB_Handle.UpdateTable(string.Format(
                            @"DELETE FROM DISCS WHERE
                            disc_id = '{0:000}' AND location_id = '{1:000}'",
                            txtDisc.Text, ddLocation.Text));
                    MessageBox.Show(ex.Message, "Error");
                }
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = DB_Handle.GetDataTable(string.Format(
                    @"select max(disc_id) from discs 
                    where location_id = '{0}'", ddLocation.Text));
                    txtDisc.Text = (Convert.ToInt32(dt.Rows[0][0]) + 1).ToString("000");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void ddLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDisc.Clear();
        }

        private void btn_Click(object sender, EventArgs e)
        {

        }



        private void ddLocation_SelectedValueChanged(object sender, EventArgs e)
        {
            //reload
        }

        private void scrlPage_Scroll(object sender, ScrollEventArgs e)
        {
            currentPage = e.NewValue;
            txtPageNo.Text = e.NewValue.ToString();
            loadPage();
        }

        private void disc_btn_Click(object sender, EventArgs e)
        {
        }
    }
}
