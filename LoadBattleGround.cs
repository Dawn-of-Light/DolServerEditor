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
    public partial class LoadBattleGround : Form
    {
        MySqlDataAdapter BattleGrounddataAdapter = new MySqlDataAdapter();
        MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder();
        DataTable BattlegroundDatatable = new DataTable();
        private MySqlConnection connection = new MySqlConnection("server=" + DolEditor.Properties.Settings.Default.ServerIP + ";uid=" + DolEditor.Properties.Settings.Default.Username + ";pwd=" + DolEditor.Properties.Settings.Default.Password + ";database=" + DolEditor.Properties.Settings.Default.DatabaseName + "");
           
        public LoadBattleGround()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.ZoneListingButton.Visible = false;
            this.Savebutton.Hide();
            this.SaveNewbutton.Hide();
            this.BattlegrounddataGridView.AutoGenerateColumns = true;
            this.BattlegrounddataGridView.AllowUserToDeleteRows = true;
            this.GetData("select * from battleground");

            this.BattlegrounddataGridView.Columns["BattleGround_ID"].Visible = false;

            this.BattlegrounddataGridView.DataSource = this.BattleGroundbindingSource;
        }

        private void GetData(string selectCommand)
        {
            try
            {
                // Create a new data adapter based on the specified query.
                this.BattleGrounddataAdapter = new MySqlDataAdapter(selectCommand, connection);
                // Create a command builder to generate SQL update, insert, and 
                // delete commands based on selectCommand. These are used to 
                // update the database.
                this.commandBuilder = new MySqlCommandBuilder(this.BattleGrounddataAdapter);
                this.BattlegroundDatatable.Clear();
                // Populate a new data table and bind it to the BindingSource.
                this.BattlegroundDatatable.Locale = System.Globalization.CultureInfo.InvariantCulture;
                this.BattleGrounddataAdapter.Fill(this.BattlegroundDatatable);
                this.BattleGroundbindingSource.DataSource = this.BattlegroundDatatable;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
        }

        private void BattleGroundNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete this BattleGround?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Validate();
                this.BattleGroundbindingSource.EndEdit();

                try
                {
                    this.BattleGrounddataAdapter.Update(this.BattlegroundDatatable);
                }
                catch (MySqlException s)
                {
                    MessageBox.Show(s.Message);
                }
            }
            GetData("select * from battleground");
        }

        private void BattlegrounddataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            if (MessageBox.Show("Load this Battleground in editor?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // user clicked yes
                this.ZoneListingButton.Visible = true;
                this.AddBattleGroundButton.Visible = true;
                this.ControlMenu.Visible = false;

                this.tabControl1.Show();
                this.BattlegrounddataGridView.Hide();

                this.RegionIDtextBox.Text = this.BattlegrounddataGridView.Rows[BattlegrounddataGridView.CurrentCell.RowIndex].Cells["RegionID"].Value.ToString();
                this.MinLeveltextBox.Text = this.BattlegrounddataGridView.Rows[BattlegrounddataGridView.CurrentCell.RowIndex].Cells["MinLevel"].Value.ToString();
                this.MaxLeveltextBox.Text = this.BattlegrounddataGridView.Rows[BattlegrounddataGridView.CurrentCell.RowIndex].Cells["MaxLevel"].Value.ToString();
                this.MaxRealmLeveltextBox.Text = this.BattlegrounddataGridView.Rows[BattlegrounddataGridView.CurrentCell.RowIndex].Cells["MaxRealmLevel"].Value.ToString();

                this.SaveNewbutton.Hide();
                this.Savebutton.Show();
            }
        }
        private bool ValidBattleGroundData()
        {

            if (Util.IsEmpty(RegionIDtextBox.Text))
            {
                MessageBox.Show("WARNING: You need to provide a RegionID value.");
                return false;
            }
            else
            {
                ushort Region;
                try
                {
                    Region = Convert.ToUInt16(RegionIDtextBox.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show(" WARNING: RegionID value is not suitable.");
                    return false;
                }
            }

            if (Util.IsEmpty(MinLeveltextBox.Text))
            {
                MessageBox.Show("WARNING: You need to provide a Minimum Level value.");
                return false;
            }
            else
            {
                byte MinLevel;
                try
                {
                    MinLevel = Convert.ToByte(MinLeveltextBox.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show(" WARNING: Minimum value is not suitable.");
                    return false;
                }
            }

            if (Util.IsEmpty(MaxLeveltextBox.Text))
            {
                MessageBox.Show("WARNING: You need to provide a Maximum Level value.");
                return false;
            }
            else
            {
                byte MaxLevel;
                try
                {
                    MaxLevel = Convert.ToByte(MaxLeveltextBox.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show(" WARNING: MaxLevel value is not suitable.");
                    return false;
                }
            }

            if (Util.IsEmpty(MaxRealmLeveltextBox.Text))
            {
                MessageBox.Show("WARNING: You need to provide a Maximum Realm Level value.");
                return false;
            }
            else
            {
                byte MaxRealmLevel;
                try
                {
                    MaxRealmLevel = Convert.ToByte(MaxRealmLeveltextBox.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show(" WARNING: MaxRealmLevel value is not suitable.");
                    return false;
                }
            }
            return true;
        }

        private void SaveNewBattleGround_Click(object sender, EventArgs e)
        {
            if (!ValidBattleGroundData())
                return;

            if (MessageBox.Show("Save this new battleground?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // user clicked yes
                long i = 1;
                foreach (byte b in Guid.NewGuid().ToByteArray())
                {
                    i *= ((int)b + 1);
                }
                i -= DateTime.Now.Ticks;
                string str = "Dol_Server_Editor_" + i.ToString();

                DataRow datarow = this.BattlegroundDatatable.NewRow();

                datarow["Battleground_ID"] = str;
                datarow["RegionID"] = this.RegionIDtextBox.Text;
                datarow["MinLevel"] = this.MinLeveltextBox.Text;
                datarow["MaxLevel"] = this.MaxLeveltextBox.Text;
                datarow["MaxRealmLevel"] = this.MaxRealmLeveltextBox.Text;

                this.BattlegroundDatatable.Rows.Add(datarow);

                this.Validate();
                this.BattleGroundbindingSource.EndEdit();

                try
                {
                    this.BattleGrounddataAdapter.Update(this.BattlegroundDatatable);
                }
                catch (MySqlException s)
                {
                    MessageBox.Show(s.Message);
                }

                this.ZoneListingButton.Visible = false;
                this.AddBattleGroundButton.Visible = true;
                this.ControlMenu.Visible = true;
                this.Savebutton.Hide();
                this.SaveNewbutton.Hide();
                this.tabControl1.Hide();
                this.BattlegrounddataGridView.Show();
            }
        }

        private void SaveLoadedBattleGround_Click(object sender, EventArgs e)
        {
            if (!ValidBattleGroundData())
                return;

            if (MessageBox.Show("Save your modifications?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // user clicked yes
                this.BattlegrounddataGridView.ReadOnly = false;
                this.BattlegrounddataGridView.Rows[BattlegrounddataGridView.CurrentCell.RowIndex].Cells["RegionID"].Value = this.RegionIDtextBox.Text;
                this.BattlegrounddataGridView.Rows[BattlegrounddataGridView.CurrentCell.RowIndex].Cells["MinLevel"].Value = this.MinLeveltextBox.Text;
                this.BattlegrounddataGridView.Rows[BattlegrounddataGridView.CurrentCell.RowIndex].Cells["MaxLevel"].Value = this.MaxLeveltextBox.Text;
                this.BattlegrounddataGridView.Rows[BattlegrounddataGridView.CurrentCell.RowIndex].Cells["MaxRealmLevel"].Value = this.MaxRealmLeveltextBox.Text;

                this.Validate();
                this.BattleGroundbindingSource.EndEdit();

                try
                {
                    this.BattleGrounddataAdapter.Update(this.BattlegroundDatatable);
                }
                catch (MySqlException s)
                {
                    MessageBox.Show(s.Message);
                }

                this.BattlegrounddataGridView.ReadOnly = true;
                this.Savebutton.Hide();
                this.SaveNewbutton.Hide();
                this.ZoneListingButton.Visible = false;
                this.AddBattleGroundButton.Visible = true;
                this.ControlMenu.Visible = true;
                this.BattlegrounddataGridView.Show();
            }
        }

        private void AddNewZone_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Become to add a new battleground?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // user clicked yes
                this.BattlegrounddataGridView.Hide();

                this.tabControl1.Show();
                this.Savebutton.Hide();
                this.SaveNewbutton.Show();
                this.ZoneListingButton.Visible = true;
                this.AddBattleGroundButton.Visible = false;
                this.ControlMenu.Visible = false;
            }
        }

        private void BattleGroundListing_Click(object sender, EventArgs e)
        {
            this.Savebutton.Hide();
            this.SaveNewbutton.Hide();
            this.ZoneListingButton.Visible = false;
            this.AddBattleGroundButton.Visible = true;
            this.ControlMenu.Visible = true;
            this.tabControl1.Hide();
            this.BattlegrounddataGridView.Show();
        }
    }
}
