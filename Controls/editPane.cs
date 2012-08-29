using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace LFI
{
    public partial class editPane : UserControl
    {
        char[] invalid_chars = { '\\','/',';','@',',','#','$','^','*','~','`',':','"' };
        public bool active = false;
        private string currentTitle = string.Empty;
        private bool isnewrecord = false;
        public editPane()
        {
            InitializeComponent();
        }

        public void Disable()
        {
            toolTip.SetToolTip(this, "");
            toolTip.Hide(this);
            active = false;
            this.Hide();
        }

        public void Enable()
        {
            populateDropDownTitles();
            active = true;
            this.Show();
        }

        private void numericTextbox_keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                e.Handled = e.SuppressKeyPress = true;
        }

        private void numericTextbox_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (txt != null)
            {
                Regex reg = new Regex("[^0-9]");
                int pos = txt.SelectionStart;
                txt.Text = reg.Replace(txt.Text, "");
                txt.Select(pos, 0);
            }
        }

        /// <summary>
        /// Show dialog for saving image with title as file name.
        /// </summary>
        /// <remarks>saves jpeg format.</remarks>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() != DialogResult.Cancel && ddTitle.Text.Length > 0)
            {
                try
                {
                    FileStream fs = new FileStream(dlg.FileName, FileMode.Open);
                    Image img = Image.FromStream(fs);
                    fs.Close();
                    img = Image_IO.resize_Image(img, imgTitle.Width, imgTitle.Height);
                    img.Save(string.Format("{0}\\{1}.jpg", Folder_IO.GetUserImagePath(), ddTitle.Text), 
                        System.Drawing.Imaging.ImageFormat.Jpeg);
                    imgTitle.Image = img;
                }
                catch (Exception ex)
                {
                    toolTip.Show(ex.Message, imgError);
                }
            }
        }

        /// <summary>
        /// Loads ddTitle dropdown with all existing titles.
        /// </summary>
        private void populateDropDownTitles()
        {
            DataTable titles = DB_Handle.GetDataTable(string.Format(
                @"Select title_id from titles order by title_id"));
            ddTitle.DataSource = titles;
            ddTitle.DisplayMember = "title_id";
        }

        public void load_data(DataTable sel)
        {
            populateDropDownTitles();
            try
            {
                isnewrecord = false;
                ddTitle.Text = sel.Rows[0][0].ToString();
                currentTitle = ddTitle.Text;
                txtEpisode.Text = sel.Rows[0][1].ToString();
                ddCategory.Text = sel.Rows[0][2].ToString();
                txtYear.Text = sel.Rows[0][3].ToString();
                ddStatus.Text = sel.Rows[0][4].ToString();
                ddLanguage.Text = sel.Rows[0][5].ToString();
            }
            catch (Exception ex)
            {
                toolTip.Show(ex.Message, txtEpisode);
            }

            setImage(ddTitle.Text);
        }

        private void setImage(string str)
        {
            string path = Folder_IO.GetUserImagePath() + string.Format("\\{0}.jpg", str);

            if (System.IO.File.Exists(path))
            {
                FileStream fs = new FileStream(path, FileMode.Open); 
                Image img = Image.FromStream(fs);
                fs.Close();
                imgTitle.Image = img;
            }
            else
            {
                imgTitle.Image = null;
            }
        }

        /// <summary>
        /// Attempts to update title and information.
        /// Validates information.
        /// Renames image if exists.
        /// </summary>
        /// <remarks>'Insert into' for new records only.</remarks>
        /// <returns>Pass or fail coniditon.</returns>
        public bool saveData()
        {
            bool status = false;
            try
            {
                if (ddTitle.Text.Length == 0)
                    Error_Handle.TipError("Title required\n", toolTip, ddTitle);
                else if (ddTitle.Text.IndexOfAny(invalid_chars) > 0)
                    Error_Handle.TipError("Invalid chars\n", toolTip, ddTitle);
                else if (ddTitle.FindStringExact(ddTitle.Text) != ddTitle.SelectedIndex)
                    Error_Handle.TipError("Title already exists\n", toolTip, ddTitle);
                else if (ddCategory.Text.Length == 0)
                    Error_Handle.TipError("Category required\n", toolTip, ddCategory);
                else if (ddStatus.Text.Length < 1)
                    Error_Handle.TipError("Status required\n", toolTip, ddStatus);
                else if (ddLanguage.Text.Length < 1)
                    Error_Handle.TipError("Language required\n", toolTip, ddLanguage);
                else if (txtYear.Text.Length != 4)
                    Error_Handle.TipError("Year required\n", toolTip, txtYear);
                else if (txtEpisode.Text.Length < 1)
                    Error_Handle.TipError("Episode required\n", toolTip, txtEpisode);
                else
                {
                    if (isnewrecord)
                    {
                        DB_Handle.UpdateTable(string.Format(
                            @"INSERT INTO TITLES VALUES ({0},'{1}','{2}','{3}','{4}','{5}');",
                            "\"" + ddTitle.Text + "\"", txtEpisode.Text.Replace(" ", ""), ddCategory.Text,
                            txtYear.Text, ddStatus.Text, ddLanguage.Text, currentTitle));
                    }
                    else
                    {
                        DB_Handle.UpdateTable(string.Format(
                            @"UPDATE TITLES SET
                            title_id={0}, 
                            episodes='{1}', 
                            category='{2}', 
                            year='{3}', 
                            status='{4}', 
                            language='{5}'
                            WHERE title_id={6};",
                            "\"" + ddTitle.Text + "\"", txtEpisode.Text.Replace(" ", ""), ddCategory.Text,
                            txtYear.Text, ddStatus.Text, ddLanguage.Text, "\"" + currentTitle + "\""));

                        DB_Handle.UpdateTable(string.Format(
                            @"UPDATE CONTENTS SET
                            title_id={0}
                            WHERE title_id={1};",
                            "\"" + ddTitle.Text + "\"", "\"" + currentTitle + "\""));
                    }
                    Image_IO.rename_Image(currentTitle, ddTitle.Text);

                    MessageBox.Show("Saved", "Success");
                    status = true;
                    populateDropDownTitles();
                }
            }
            catch (Exception ex)
            {
                Error_Handle.TipError(ex.Message, toolTip, imgError);
            }
            return status;
        }

        private void ddTitle_TextChanged(object sender, EventArgs e)
        {
            if (ddTitle.Text.IndexOfAny(invalid_chars) > 0)
                toolTip.Show("Invalid Chars", imgError);
            else
                toolTip.Hide(imgError);
        }

        public void Clear_Fields()
        {
            populateDropDownTitles();
            isnewrecord = true;
            ddTitle.Text = string.Empty;
            imgTitle.Image = null;
            txtEpisode.Clear();
            txtYear.Clear();
            ddLanguage.Text = MainForm.Lmode;
            ddCategory.SelectedIndex = 0;
            ddStatus.SelectedIndex = 0;
        }

        private void editPane_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        /// <summary>
        /// Save, resize, and format dragged image with txtTitle filename.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editPane_DragDrop(object sender, DragEventArgs e)
        {
            if (ddTitle.Text.Length < 1)
            {
                toolTip.Show("Title Required!", imgError);
            }
            else
            {
                try
                {
                    int x = this.PointToClient(new Point(e.X, e.Y)).X;

                    int y = this.PointToClient(new Point(e.X, e.Y)).Y;

                    //inside imgTitle boundaries
                    if (x >= imgTitle.Location.X && x <= imgTitle.Location.X + imgTitle.Width
                        && y >= imgTitle.Location.Y && y <= imgTitle.Location.Y + imgTitle.Height)
                    {

                        string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                        FileStream fs = new FileStream(files[0], FileMode.Open);
                        Image img = Image.FromStream(fs);
                        fs.Close();
                        img = Image_IO.resize_Image(img, imgTitle.Width, imgTitle.Height);
                        img.Save(string.Format("{0}\\{1}.jpg", Folder_IO.GetUserImagePath(), ddTitle.Text),
                            System.Drawing.Imaging.ImageFormat.Jpeg);
                        imgTitle.Image = img;
                    }
                }
                catch (Exception ex)
                {
                    toolTip.Show(ex.Message, imgError);
                }
            }
            ParentForm.Activate();
        }
    }
}
