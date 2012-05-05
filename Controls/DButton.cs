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
        public static string Location_ID = string.Empty;
        public int Page = 0;
        public int Slot = 0;
        discView Caller;

        public DButton(int slot, Label copyLabel, Point loc, discView caller) 
        {
            InitializeComponent();
            Slot = slot;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            FlatAppearance.BorderSize = 0;
            FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            Location = loc;
            Size = new System.Drawing.Size(150, 150);
            TabIndex = 94;
            TabStop = false;
            UseVisualStyleBackColor = true;
            Visible = true;

            createVertLabel(copyLabel, "");
            Caller = caller;
        }

        public void load(int page)
        {
            DataTable dt = DB_Handle.GetDataTable(string.Format(@"select * from discs
                where location_id='{0}' and page_number='{1}' and slot_number='{2}'",
                Location_ID, page, Slot));
            if (dt.Rows.Count != 0)
                setData(dt.Rows[0][0], dt.Rows[0][1]);
            else
                setData(string.Empty, page);
        }

        public void setVisibility(bool vis)
        {
            Visible = vis;
            vlbl.Visible = vis;
        }

        private void setData(object disc, object page)
        {
            Disc = disc.ToString();
            Page = Convert.ToInt32(page);
            vlbl.Text = Disc;
        }

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

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            Caller.popContentPane();

            DataTable temp = DB_Handle.GetDataTable(string.Format(
                @"SELECT * FROM contents WHERE content_id=(SELECT content_id
                from disc_contents where disc_id='{0}' and location_id='{1}');",
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

            Caller.setImagebox(Image_IO.generateDiscImage(Disc, Location_ID, this));
        }

    }
}
