/*
* DAWN OF LIGHT - The first free open source DAoC server emulator
*
* This program is free software; you can redistribute it and/or
* modify it under the terms of the GNU General Public License
* as published by the Free Software Foundation; either version 2
* of the License, or (at your option) any later version.
*
* This program is distributed in the hope that it will be useful,
* but WITHOUT ANY WARRANTY; without even the implied warranty of
* MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
* GNU General Public License for more details.
*
* You should have received a copy of the GNU General Public License
* along with this program; if not, write to the Free Software
* Foundation, Inc., 59 Temple Place - Suite 330, Boston, MA  02111-1307, USA.
*
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Origins_Editor
{
    public partial class LoadZone : Form
    {
        MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder();
        MySqlDataAdapter ZonesdataAdapter;

        public LoadZone()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.EditZoneControl.Hide();
            this.ZoneIDtextBox.Enabled = false;
            this.ZonedataGridView.AutoGenerateColumns = true;
            this.ZonedataGridView.AllowUserToDeleteRows = true;
            this.ZoneListingButton.Visible = false;

            this.ZoneRealmSearchcomboBox.SelectedIndex = 0;
            this.DivingFlagcomboBox.SelectedIndex = 0;
            this.IsLavacomboBox.SelectedIndex = 0;
            this.RealmcomboBox.SelectedIndex = 0;

            this.Savebutton.Hide();
            this.SaveNewbutton.Hide();
            GetData("select * from zones");

            this.ZonedataGridView.Columns["Zones_ID"].Visible = false;
        }

        private void GetData(string selectCommand)
        {
            try
            {
                MySqlConnection connection3 = new MySqlConnection("server=" + DolEditor.Properties.Settings.Default.ServerIP + ";uid=" + DolEditor.Properties.Settings.Default.Username + ";pwd=" + DolEditor.Properties.Settings.Default.Password + ";database=" + DolEditor.Properties.Settings.Default.DatabaseName + "");
                // Create a new data adapter based on the specified query.
                ZonesdataAdapter = new MySqlDataAdapter(selectCommand, connection3);
                // Create a command builder to generate SQL update, insert, and 
                // delete commands based on selectCommand. These are used to 
                // update the database.
                commandBuilder = new MySqlCommandBuilder(ZonesdataAdapter);
                ZonesDatatable.Clear();
                // Populate a new data table and bind it to the BindingSource.
                ZonesDatatable.Locale = System.Globalization.CultureInfo.InvariantCulture;
                ZonesdataAdapter.Fill(ZonesDatatable);
                ZonebindingSource.DataSource = ZonesDatatable;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
        }

        private void ZoneNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete this zone?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ZonebindingSource.RemoveCurrent();
                this.Validate();
                this.ZonebindingSource.EndEdit();
                ZonesdataAdapter.Update(ZonesDatatable);
            }

            string select = "SELECT * FROM zones";
            bool add = false; ;
            if (this.SearchZoneIDtextBox.Text != "")
            {
                select += " where zoneid='" + this.SearchZoneIDtextBox.Text + "'";
                add = true;
            }

            if (this.SearchByZoneNametextBox.Text != "")
            {
                if (add)
                    select += " and Name like '%" + this.SearchByZoneNametextBox.Text + "%'";
                else
                {
                    select += " where Name like '%" + this.SearchByZoneNametextBox.Text + "%'";
                    add = true;
                }
            }

            int RealmID = 0;
            if (ZoneRealmSearchcomboBox.Text != null)
            {
                switch (ZoneRealmSearchcomboBox.Text)
                {
                    case " All":
                        break;
                    case "Albion":
                        RealmID = 1;
                        break;
                    case "Midgard":
                        RealmID = 2;
                        break;
                    case "Hibernia":
                        RealmID = 3;
                        break;
                }

            }

            if (RealmID != 0)
            {
                if (add)
                    select += " and realm='" + RealmID + "'";
                else
                {
                    select += " where realm='" + RealmID + "'";
                    add = true;
                }
            }

            GetData(select);
        }

        private void ZonedataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            if (MessageBox.Show("Load this zone in editor?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // user clicked yes
                this.EditZoneControl.Show();
                this.ZonedataGridView.Hide();
                this.ZoneIDtextBox.Text = this.ZonedataGridView.Rows[ZonedataGridView.CurrentCell.RowIndex].Cells["ZoneID"].Value.ToString();
                this.RegionIDtextBox.Text = this.ZonedataGridView.Rows[ZonedataGridView.CurrentCell.RowIndex].Cells["RegionID"].Value.ToString();
                this.NametextBox.Text = this.ZonedataGridView.Rows[ZonedataGridView.CurrentCell.RowIndex].Cells["Name"].Value.ToString();
                this.IsLavacomboBox.Text = Util.Find_Bool_String_Value(this.ZonedataGridView.Rows[ZonedataGridView.CurrentCell.RowIndex].Cells["IsLava"].Value.ToString());
                this.WaterLeveltextBox.Text = this.ZonedataGridView.Rows[ZonedataGridView.CurrentCell.RowIndex].Cells["WaterLevel"].Value.ToString();
                this.OffSetYtextBox.Text = this.ZonedataGridView.Rows[ZonedataGridView.CurrentCell.RowIndex].Cells["OffsetY"].Value.ToString();
                this.OffSetXtextBox.Text = this.ZonedataGridView.Rows[ZonedataGridView.CurrentCell.RowIndex].Cells["OffsetX"].Value.ToString();
                this.WidthtextBox.Text = this.ZonedataGridView.Rows[ZonedataGridView.CurrentCell.RowIndex].Cells["Width"].Value.ToString();
                this.HeighttextBox.Text = this.ZonedataGridView.Rows[ZonedataGridView.CurrentCell.RowIndex].Cells["Height"].Value.ToString();
                this.ExperiencetextBox.Text = this.ZonedataGridView.Rows[ZonedataGridView.CurrentCell.RowIndex].Cells["Experience"].Value.ToString();
                this.RealmPointstextBox.Text = this.ZonedataGridView.Rows[ZonedataGridView.CurrentCell.RowIndex].Cells["Realmpoints"].Value.ToString();
                this.BountyPointstextBox.Text = this.ZonedataGridView.Rows[ZonedataGridView.CurrentCell.RowIndex].Cells["Bountypoints"].Value.ToString();
                this.CointextBox.Text = this.ZonedataGridView.Rows[ZonedataGridView.CurrentCell.RowIndex].Cells["Coin"].Value.ToString();
                this.DivingFlagcomboBox.Text = Util.Find_Bool_String_Value(this.ZonedataGridView.Rows[ZonedataGridView.CurrentCell.RowIndex].Cells["DivingFlag"].Value.ToString());
                this.RealmcomboBox.Text = Util.Find_Realm_String_Value(this.ZonedataGridView.Rows[ZonedataGridView.CurrentCell.RowIndex].Cells["Realm"].Value.ToString());
                this.TranslationIDtextBox.Text = this.ZonedataGridView.Rows[ZonedataGridView.CurrentCell.RowIndex].Cells["TranslationId"].Value.ToString();
                this.SaveNewbutton.Hide();
                this.Savebutton.Show();
                this.ControlMenu.Visible = false;
                this.ZoneListingButton.Visible = true;
                this.AddZoneButton.Visible = true;
            }
        }

        private bool ValidateNewZone()
        {
            if (this.ZoneIDtextBox.Text == "" || this.ZoneIDtextBox.Text == null)
            {
                MessageBox.Show("You need to specify a ZoneID value.");
                return false;
            }
            int zoneid;
            if (!Int32.TryParse(ZoneIDtextBox.Text.ToString(), out zoneid))
            {
                MessageBox.Show("You need to specify a numeric value for Zone id.");
                return false;
            }

            if (this.RegionIDtextBox.Text == "" || this.RegionIDtextBox.Text == null)
            {
                MessageBox.Show("You need to specify a RegionID value.");
                return false;
            }
            int regionid;
            if (!Int32.TryParse(RegionIDtextBox.Text.ToString(), out regionid))
            {
                MessageBox.Show("You need to specify a numeric value for RegionID.");
                return false;
            }

            if (this.WaterLeveltextBox.Text == "" || this.WaterLeveltextBox.Text == null)
            {
                this.WaterLeveltextBox.Text = "0";
            }
            int waterlevel;
            if (!Int32.TryParse(WaterLeveltextBox.Text.ToString(), out waterlevel))
            {
                MessageBox.Show("You need to specify a numeric value for Water Level.");
                return false;
            }

            return true;

        }
        private void SaveNewZone_Click(object sender, EventArgs e)
        {
            if (!ValidateNewZone())
                return;
            if (MessageBox.Show("Save this new zone?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                long i = 1;
                foreach (byte b in Guid.NewGuid().ToByteArray())
                {
                    i *= ((int)b + 1);
                }
                i -= DateTime.Now.Ticks;
                string str = "Origins_Editor_" + i.ToString();

                DataRow datarow = ZonesDatatable.NewRow();

                datarow["Zones_ID"] = str;
                datarow["ZoneID"] = ZoneIDtextBox.Text;
                datarow["RegionID"] = RegionIDtextBox.Text;
                datarow["Name"] = NametextBox.Text;
                datarow["IsLava"] = Util.Find_Bool_Value(IsLavacomboBox.Text);
                datarow["WaterLevel"] = WaterLeveltextBox.Text;
                datarow["OffsetY"] = OffSetYtextBox.Text;
                datarow["OffsetX"] = OffSetXtextBox.Text;
                datarow["Width"] = WidthtextBox.Text;
                datarow["Height"] = HeighttextBox.Text;
                datarow["Experience"] = ExperiencetextBox.Text;
                datarow["Realmpoints"] = RealmPointstextBox.Text;
                datarow["Bountypoints"] = BountyPointstextBox.Text;
                datarow["Coin"] = CointextBox.Text;
                datarow["DivingFlag"] = Util.Find_Bool_Value(DivingFlagcomboBox.Text);
                datarow["Realm"] = Util.Find_Realm_Value(RealmcomboBox.Text);
                datarow["TranslationId"] = TranslationIDtextBox.Text;

                ZonesDatatable.Rows.Add(datarow);

                this.Validate();
                this.ZonebindingSource.EndEdit();

                try
                {
                    ZonesdataAdapter.Update(ZonesDatatable);
                }
                catch (MySqlException s)
                {
                    System.Windows.MessageBox.Show(s.Message);
                }

                this.EditZoneControl.Hide();
                this.ZonedataGridView.Show();
                this.ControlMenu.Visible = true;
                this.AddZoneButton.Visible = true;
                this.ZoneListingButton.Visible = false;
                this.SaveNewbutton.Hide();

                string select = "SELECT * FROM zones";
                bool add = false; ;
                if (this.SearchZoneIDtextBox.Text != "")
                {
                    select += " where zoneid='" + this.SearchZoneIDtextBox.Text + "'";
                    add = true;
                }

                if (this.SearchByZoneNametextBox.Text != "")
                {
                    if (add)
                        select += " and Name like '%" + this.SearchByZoneNametextBox.Text + "%'";
                    else
                    {
                        select += " where Name like '%" + this.SearchByZoneNametextBox.Text + "%'";
                        add = true;
                    }
                }

                int RealmID = 0;
                if (ZoneRealmSearchcomboBox.Text != null)
                {
                    switch (ZoneRealmSearchcomboBox.Text)
                    {
                        case " All":
                            break;
                        case "Albion":
                            RealmID = 1;
                            break;
                        case "Midgard":
                            RealmID = 2;
                            break;
                        case "Hibernia":
                            RealmID = 3;
                            break;
                    }

                }

                if (RealmID != 0)
                {
                    if (add)
                        select += " and realm='" + RealmID + "'";
                    else
                    {
                        select += " where realm='" + RealmID + "'";
                        add = true;
                    }
                }

                GetData(select);
            }
        }

        private void SaveLoadedZone_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Accept this zone update?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // user clicked yes
                this.ZonedataGridView.ReadOnly = false;


                this.ZonedataGridView.Rows[ZonedataGridView.CurrentCell.RowIndex].Cells["ZoneID"].Value = this.ZoneIDtextBox.Text;
                this.ZonedataGridView.Rows[ZonedataGridView.CurrentCell.RowIndex].Cells["RegionID"].Value = this.RegionIDtextBox.Text;
                this.ZonedataGridView.Rows[ZonedataGridView.CurrentCell.RowIndex].Cells["Name"].Value = this.NametextBox.Text;
                this.ZonedataGridView.Rows[ZonedataGridView.CurrentCell.RowIndex].Cells["IsLava"].Value = Util.Find_Bool_Value(this.IsLavacomboBox.Text);
                this.ZonedataGridView.Rows[ZonedataGridView.CurrentCell.RowIndex].Cells["WaterLevel"].Value = this.WaterLeveltextBox.Text;
                this.ZonedataGridView.Rows[ZonedataGridView.CurrentCell.RowIndex].Cells["OffsetY"].Value = this.OffSetYtextBox.Text;
                this.ZonedataGridView.Rows[ZonedataGridView.CurrentCell.RowIndex].Cells["OffsetX"].Value = this.OffSetXtextBox.Text;
                this.ZonedataGridView.Rows[ZonedataGridView.CurrentCell.RowIndex].Cells["Width"].Value = this.WidthtextBox.Text;
                this.ZonedataGridView.Rows[ZonedataGridView.CurrentCell.RowIndex].Cells["Height"].Value = this.HeighttextBox.Text;
                this.ZonedataGridView.Rows[ZonedataGridView.CurrentCell.RowIndex].Cells["Experience"].Value = this.ExperiencetextBox.Text;
                this.ZonedataGridView.Rows[ZonedataGridView.CurrentCell.RowIndex].Cells["Realmpoints"].Value = this.RealmPointstextBox.Text;
                this.ZonedataGridView.Rows[ZonedataGridView.CurrentCell.RowIndex].Cells["Bountypoints"].Value = this.BountyPointstextBox.Text;
                this.ZonedataGridView.Rows[ZonedataGridView.CurrentCell.RowIndex].Cells["Coin"].Value = this.CointextBox.Text;
                this.ZonedataGridView.Rows[ZonedataGridView.CurrentCell.RowIndex].Cells["DivingFlag"].Value = Util.Find_Bool_Value(this.DivingFlagcomboBox.Text);
                this.ZonedataGridView.Rows[ZonedataGridView.CurrentCell.RowIndex].Cells["Realm"].Value = Util.Find_Realm_Value(this.RealmcomboBox.Text);
                this.ZonedataGridView.Rows[ZonedataGridView.CurrentCell.RowIndex].Cells["TranslationId"].Value = this.TranslationIDtextBox.Text;
                
                this.Validate();
                this.ZonebindingSource.EndEdit();

                try
                {
                    ZonesdataAdapter.Update(ZonesDatatable);
                }
                catch (MySqlException s)
                {
                    System.Windows.MessageBox.Show(s.Message);
                }

                this.ZonedataGridView.ReadOnly = true;
                this.EditZoneControl.Hide();
                this.ZonedataGridView.Show();
                this.ControlMenu.Visible = true;
                this.AddZoneButton.Visible = true;
                this.ZoneListingButton.Visible = false;
                this.Savebutton.Hide();
            }
        }

        private void ZoneListing_Click(object sender, EventArgs e)
        {
            this.EditZoneControl.Hide();
            this.ZonedataGridView.Show();
            this.Savebutton.Hide();
            this.SaveNewbutton.Hide();
            this.ZoneListingButton.Visible = false;
            this.AddZoneButton.Visible = true;
            this.ControlMenu.Visible = true;
        }

        private void AddNewZone_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Begin add a new zone?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // user clicked yes
                this.ZonedataGridView.Hide();
                this.Savebutton.Hide();
                this.SaveNewbutton.Show();
                this.EditZoneControl.Show();
                this.AddZoneButton.Visible = false;
                this.ZoneListingButton.Visible = true;
                this.ControlMenu.Visible = false;
                this.ZoneIDtextBox.Text = Util.Find_Free_Zone_ID().ToString();
            }
        }

        private void Searchbutton_Click(object sender, EventArgs e)
        {
            {
                string select = "SELECT * FROM zones";
                bool add = false; ;
                if (this.SearchZoneIDtextBox.Text != "")
                {
                    select += " where zoneid='" + this.SearchZoneIDtextBox.Text + "'";
                    add = true;
                }

                if (this.SearchByZoneNametextBox.Text != "")
                {
                    if (add)
                        select += " and Name like '%" + this.SearchByZoneNametextBox.Text + "%'";
                    else
                    {
                        select += " where Name like '%" + this.SearchByZoneNametextBox.Text + "%'";
                        add = true;
                    }
                }

                int RealmID = 0;
                if (ZoneRealmSearchcomboBox.Text != null)
                {
                    switch (ZoneRealmSearchcomboBox.Text)
                    {
                        case " All":
                            break;
                        case "Albion":
                            RealmID = 1;
                            break;
                        case "Midgard":
                            RealmID = 2;
                            break;
                        case "Hibernia":
                            RealmID = 3;
                            break;
                    }

                }

                if (RealmID != 0)
                {
                    if (add)
                        select += " and realm='" + RealmID + "'";
                    else
                    {
                        select += " where realm='" + RealmID + "'";
                        add = true;
                    }
                }

                GetData(select);
            }
        }
    }
}
