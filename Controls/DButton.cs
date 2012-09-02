using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Data;

namespace LFI
{
    public partial class DButton : System.Windows.Forms.Button
    {
        public VLabel vlbl = new VLabel();
        public string Disc = string.Empty;
        private static int selSlot = 0;
        private static int selPage = 0;
        private static string selDisc = "0";
        public static string Location_ID = string.Empty;
        public int Page = 0;
        public int Slot = 0;
        discView Caller;
        public static DButton SelBtn;

        public DButton() { }

        public DButton(int slot, Label copyLabel, Point loc, discView caller) 
        {
            InitializeComponent();
            Slot = slot;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            FlatAppearance.BorderSize = 1;
            FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            Location = loc;
            Size = new System.Drawing.Size(150, 150);
            TabStop = false;
            SetStyle(ControlStyles.Selectable, false);
            UseVisualStyleBackColor = true;
            Visible = true;
            ContextMenuStrip menu = new ContextMenuStrip();
            menu.Items.Add("Swap Here");
            menu.Items.Add("Delete");
            menu.Items[0].Click += new EventHandler(this.swapMenuItem_Click);
            menu.Items[1].Click += new EventHandler(this.deleteMenuItem_Click);
            menu.Opening += new CancelEventHandler(swapMenu_Opening);
            this.ContextMenuStrip = menu;
            createVertLabel(copyLabel, "");
            Caller = caller;
        }

        /// <summary>
        /// Load dbutton information based on Location, Page, Slot.
        /// Set selection data if currently selected.
        /// </summary>
        /// <param name="page">page_number.</param>
        public void load(int page)
        {
            DataTable dt = DB_Handle.GetDataTable(string.Format(@"select * from discs
                where location_id='{0}' and page_number='{1}' and slot_number='{2}'",
                Location_ID, page, Slot));
            if (dt.Rows.Count != 0)
                setData(dt.Rows[0][0], dt.Rows[0][1]);
            else
                setData(string.Empty, page);
            Image = Image_IO.generateDiscImage(Disc, Location_ID, this);
            if (selDisc != string.Empty)
                if (selSlot == Slot && selPage == Page)
                    SetClick();
        }

        /// <summary>
        /// Load title into context menu when opening.
        /// Hide if no record available.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void swapMenu_Opening(object sender, CancelEventArgs e)
        {
            this.ContextMenuStrip.Items[0].Visible = true;
            if (selDisc != string.Empty)
                this.ContextMenuStrip.Items[0].Text = "Swap " + selDisc + " Here";
            else if (Disc != string.Empty)
                this.ContextMenuStrip.Items[0].Visible = false;
            else
                e.Cancel = true;
        }

        /// <summary>
        /// Prompt to delete record.
        /// Deletes disc and all content records on disc.
        /// </summary>
        /// <remarks>
        /// no foreign_key support in sqlite version so
        /// records are manually deleted from each table.
        /// </remarks>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dlg = BetterDialog.ShowDialog("Delete Disc",
                "Disc will be deleted permanently. Are you Sure?",
                Location_ID + Disc, "Yes", "No", Image, BetterDialog.ImageStyle.Image);
            if (dlg == DialogResult.Yes)
            {
                try
                {
                    DB_Handle.UpdateTable(string.Format(
                        @"DELETE FROM DISCS WHERE disc_id='{0}' and location_id='{1}'",
                        Disc, Location_ID));

                    DataTable dt = DB_Handle.GetDataTable(string.Format(
                        @"SELECT content_id from disc_contents WHERE disc_id='{0}' and location_id='{1}'",
                        Disc, Location_ID));

                    for (int i = 0; i <= dt.Rows.Count - 1; i++)
                    {
                        DB_Handle.UpdateTable(string.Format(
                        @"DELETE FROM CONTENTS WHERE content_id='{0}'", dt.Rows[i][0])); 
                    }

                    DB_Handle.UpdateTable(string.Format(
                        @"DELETE FROM DISC_CONTENTS WHERE disc_id='{0}' and location_id='{1}'",
                        Disc, Location_ID));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    DButton.SelBtn.PerformClick();
                    Caller.loadPage();
                    OnClick(null);
                }
            }
        }

        /// <summary>
        /// Swap two disc slots in a location.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void swapMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (selDisc != string.Empty)
                {
                    DB_Handle.UpdateTable(string.Format(
                        @"INSERT OR REPLACE INTO DISCS 
                        VALUES ('{0}','{1}','{2}','{3}');",
                        selDisc, Page, Slot, Location_ID));
                }
                if (Disc != string.Empty)
                {
                    DB_Handle.UpdateTable(string.Format(
                        @"INSERT OR REPLACE INTO DISCS 
                        VALUES ('{0}','{1}','{2}','{3}');",
                        Disc, selPage, selSlot, Location_ID));
                }
                Caller.loadPage();
                OnClick(null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error Moving Disc");
            }
        }

        public void setVisibility(bool vis)
        {
            Image = LFI.Properties.Resources.progress;
            Visible = vis;
            vlbl.Visible = vis;
        }

        private void setData(object disc, object page)
        {
            if (InvokeRequired)
            {
                this.Invoke((Action)(() => Disc = disc.ToString()));
                this.Invoke((Action)(() => Page = Convert.ToInt32(page)));
                this.Invoke((Action)(() => vlbl.Text = Disc));
            }
            else
            {
                Disc = disc.ToString();
                Page = Convert.ToInt32(page);
                vlbl.Text = Disc;
            }
        }

        /// <summary>
        /// Creates a vertical label to display disc_id text beside control.
        /// </summary>
        /// <param name="copylabel"></param>
        /// <param name="text"></param>
        private void createVertLabel( Label copylabel, string text)
        {
            vlbl.Text = text;
            vlbl.Font = copylabel.Font;
            vlbl.ForeColor = copylabel.ForeColor;
            vlbl.Size = new System.Drawing.Size(18, base.Height);
            Point point = Location;
            point.X -= vlbl.Size.Width;
            vlbl.Location = point;
            vlbl.Visible = true;
        }

        public void UnClick()
        {
            FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        }

        public void SetClick()
        {
            selPage = Page; selSlot = Slot; selDisc = Disc;
            SelBtn = this;
            FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            FlatAppearance.BorderSize = 4;
        }

        /// <summary>
        /// Sends current dbutton info to Disc View and creates an upscaled
        /// split image of the disc contents.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void DButton_Click(object sender, EventArgs e)
        {
            Caller.popContentPane();
            SetClick();
            DataTable temp = DB_Handle.GetDataTable(string.Format(
                @"SELECT * FROM contents JOIN disc_contents on contents.content_id =
                disc_contents.content_id WHERE disc_id='{0}' and location_id='{1}';",
                Disc, Location_ID));

            if (temp.Rows.Count > 0)
            {
                Caller.isNewRecord = false;
                Caller.setData(Disc, Page, Slot);
                for (int i = 0; i <= temp.Rows.Count - 1; i++)
                {
                    Caller.getContentsGrid().Rows.Add(temp.Rows[i][1], temp.Rows[i][2],
                        temp.Rows[i][3], temp.Rows[i][4], temp.Rows[i][0]);
                }
            }
            else
            {
                Caller.isNewRecord = true;
                Caller.setData(string.Empty, Page, Slot);
            }
            Caller.setImagebox(Image_IO.generateDiscImage(Disc, Location_ID, Caller.getImagebox()));
        }
    }
}
