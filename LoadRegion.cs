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
    public partial class LoadRegion : Form
    {
        MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder();
        MySqlDataAdapter RegiondataAdapter;

        public LoadRegion()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load);
        }

        private void GetData(string selectCommand)
        {
            try
            {
                MySqlConnection connection3 = new MySqlConnection("server=" + DolEditor.Properties.Settings.Default.ServerIP + ";uid=" + DolEditor.Properties.Settings.Default.Username + ";pwd=" + DolEditor.Properties.Settings.Default.Password + ";database=" + DolEditor.Properties.Settings.Default.DatabaseName + "");

                // Create a new data adapter based on the specified query.
                RegiondataAdapter = new MySqlDataAdapter(selectCommand, connection3);
                // Create a command builder to generate SQL update, insert, and 
                // delete commands based on selectCommand. These are used to 
                // update the database.
                commandBuilder = new MySqlCommandBuilder(RegiondataAdapter);
                RegionDatatable.Clear();
                // Populate a new data table and bind it to the BindingSource.
                RegionDatatable.Locale = System.Globalization.CultureInfo.InvariantCulture;
                RegiondataAdapter.Fill(RegionDatatable);
                RegionbindingSource.DataSource = RegionDatatable;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.EditRegionControl.Hide();
            this.SearchFrontierscomboBox.SelectedIndex = 0;

            this.DivingEnablecomboBox.SelectedIndex = 0;
            this.HousingEnablecomboBox.SelectedIndex = 0;
            this.IsFrontiercomboBox.SelectedIndex = 0;
            this.ExpansioncomboBox.SelectedIndex = 0;
            this.LanguagecomboBox.SelectedIndex = 0;

            this.RegiondataGridView.AutoGenerateColumns = true;
            this.RegiondataGridView.AllowUserToDeleteRows = true;
            this.RegionListingButton.Visible = false;
            this.Savebutton.Hide();
            this.SaveNewbutton.Hide();
            this.RegionIDtextBox.Enabled = false;
            GetData("select * from regions");

            this.RegiondataGridView.Columns["Regions_ID"].Visible = false;
            MySqlConnection connection = new MySqlConnection("server=" + DolEditor.Properties.Settings.Default.ServerIP + ";uid=" + DolEditor.Properties.Settings.Default.Username + ";pwd=" + DolEditor.Properties.Settings.Default.Password + ";database=" + DolEditor.Properties.Settings.Default.DatabaseName + "");

            connection.Open();
            MySqlDataAdapter ClassTypeAdddataAdapter = new MySqlDataAdapter("select distinct ClassType from regions ORDER BY ClassType ASC", connection);
            MySqlCommandBuilder ClassTypeDatacommandBuilder = new MySqlCommandBuilder(ClassTypeAdddataAdapter);
            DataTable ClassTypeComboData = new DataTable();
            ClassTypeAdddataAdapter.Fill(ClassTypeComboData);            
            this.ClassTypeSearchcomboBox.DataSource = ClassTypeComboData;
            this.ClassTypeSearchcomboBox.ValueMember = "ClassType";
            this.ClassTypeSearchcomboBox.DisplayMember = "ClassType";

            DataRow ClassTypedatarow = ClassTypeComboData.NewRow();
            ClassTypedatarow["ClassType"] = " All";
            ClassTypeComboData.Rows.Add(ClassTypedatarow);


            this.ClassTypeSearchcomboBox.Text = " All";
            connection.Close();
        }

        private void RegionNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete this region?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {         
                this.Validate();
                this.RegionbindingSource.EndEdit();
                this.RegiondataAdapter.Update(RegionDatatable);
            }

            string select = "SELECT * FROM regions";
            bool add = false; ;
            if (this.SearchRegionIDtextBox.Text != "")
            {
                select += " where regionid='" + this.SearchRegionIDtextBox.Text + "'";
                add = true;
            }

            if (this.SearchByRegionNametextBox.Text != "")
            {
                if (add)
                    select += " and Description like '%" + this.SearchByRegionNametextBox.Text + "%'";
                else
                {
                    select += " where Description like '%" + this.SearchByRegionNametextBox.Text + "%'";
                    add = true;
                }
            }

            string ClassType = " All";
            if (ClassTypeSearchcomboBox.Text != null && ClassTypeSearchcomboBox.Text != "")
                ClassType = this.ClassTypeSearchcomboBox.Text.ToString();

            if (ClassType != " All")
            {
                if (add)
                    select += " and ClassType='" + ClassType + "'";
                else
                {
                    select += " where ClassType='" + ClassType + "'";
                    add = true;
                }
            }

            string Frontiers = " All";
            if (SearchFrontierscomboBox.Text != null && SearchFrontierscomboBox.Text != "")
                Frontiers = this.SearchFrontierscomboBox.Text.ToString();

            if (Frontiers != " All")
            {
                if (add)
                    select += " and IsFrontier ='" + Util.Find_Bool_Value(Frontiers) + "'";
                else
                {
                    select += " where IsFrontier ='" + Util.Find_Bool_Value(Frontiers) + "'";
                    add = true;
                }
            }

            GetData(select);
        }

        private void RegiondataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            if (MessageBox.Show("Load this region in editor?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.EditRegionControl.Show();
                this.RegiondataGridView.Hide();

                this.RegionIDtextBox.Text = this.RegiondataGridView.Rows[RegiondataGridView.CurrentCell.RowIndex].Cells["RegionID"].Value.ToString();
                this.NametextBox.Text = this.RegiondataGridView.Rows[RegiondataGridView.CurrentCell.RowIndex].Cells["Name"].Value.ToString();
                this.DescriptiontextBox.Text = this.RegiondataGridView.Rows[RegiondataGridView.CurrentCell.RowIndex].Cells["Description"].Value.ToString();
                this.IPtextBox.Text = this.RegiondataGridView.Rows[RegiondataGridView.CurrentCell.RowIndex].Cells["IP"].Value.ToString();
                this.PorttextBox.Text = this.RegiondataGridView.Rows[RegiondataGridView.CurrentCell.RowIndex].Cells["Port"].Value.ToString();
                this.ExpansioncomboBox.Text = this.RegiondataGridView.Rows[RegiondataGridView.CurrentCell.RowIndex].Cells["Expansion"].Value.ToString();
                this.HousingEnablecomboBox.Text = this.RegiondataGridView.Rows[RegiondataGridView.CurrentCell.RowIndex].Cells["HousingEnabled"].Value.ToString();
                this.DivingEnablecomboBox.Text = this.RegiondataGridView.Rows[RegiondataGridView.CurrentCell.RowIndex].Cells["DivingEnabled"].Value.ToString();
                this.WaterLeveltextBox.Text = this.RegiondataGridView.Rows[RegiondataGridView.CurrentCell.RowIndex].Cells["WaterLevel"].Value.ToString();
                this.ClassTypecomboBox.Text = this.RegiondataGridView.Rows[RegiondataGridView.CurrentCell.RowIndex].Cells["ClassType"].Value.ToString();
                this.IsFrontiercomboBox.Text = this.RegiondataGridView.Rows[RegiondataGridView.CurrentCell.RowIndex].Cells["IsFrontier"].Value.ToString();

                this.SaveNewbutton.Hide();
                this.Savebutton.Show();
                this.ControlMenu.Visible = false;
                this.RegionListingButton.Visible = true;
                this.AddRegionButton.Visible = true;
            }
        }

        private void SearchFilters_SelectedChanged(object sender, EventArgs e)
        {
            string select = "SELECT * FROM regions";
            bool add = false; ;
            if (this.SearchRegionIDtextBox.Text != "")
            {
                select += " where regionid='" + this.SearchRegionIDtextBox.Text + "'";
                add = true;
            }

            if (this.SearchByRegionNametextBox.Text != "")
            {
                if (add)
                    select += " and Description like '%" + this.SearchByRegionNametextBox.Text + "%'";
                else
                {
                    select += " where Description like '%" + this.SearchByRegionNametextBox.Text + "%'";
                    add = true;
                }
            }

            string ClassType = " All";
            if (ClassTypeSearchcomboBox.Text != null && ClassTypeSearchcomboBox.Text != "")
                ClassType = this.ClassTypeSearchcomboBox.Text.ToString(); //ClassID

            if (ClassType != " All")
            {
                if (add)
                    select += " and ClassType='" + ClassType + "'";
                else
                {
                    select += " where ClassType='" + ClassType + "'";
                    add = true;
                }
            }

            string Frontiers = " All";
            if (SearchFrontierscomboBox.Text != null && SearchFrontierscomboBox.Text != "")
                Frontiers = this.SearchFrontierscomboBox.Text.ToString();
            if (Frontiers != " All")
            {
                if (add)
                    select += " and IsFrontier ='" + Util.Find_Bool_Value(Frontiers) + "'";
                else
                {
                    select += " where IsFrontier ='" + Util.Find_Bool_Value(Frontiers) + "'";
                    add = true;
                }
            }

            GetData(select);
        }

        private void SaveNewRegion_Click(object sender, EventArgs e)
        {
            #region Check Box Value

            if (this.RegionIDtextBox.Text == "" || this.RegionIDtextBox.Text == null)
            {
                MessageBox.Show("You need to specify a RegionID value.");
                return;
            }
            int styleid;
            if (!Int32.TryParse(RegionIDtextBox.Text.ToString(), out styleid))
            {
                MessageBox.Show("You need to specify a numeric value for RegionID.");
                return;
            }

            if (this.IPtextBox.Text == "" || this.IPtextBox.Text == null)
            {
                MessageBox.Show("You need to specify a IPtextBox value.");
                return;
            }

            if (this.PorttextBox.Text == "" || this.PorttextBox.Text == null)
            {
                MessageBox.Show("You need to specify a Port value.");
                return;
            }
            int port;
            if (!Int32.TryParse(PorttextBox.Text.ToString(), out port))
            {
                MessageBox.Show("You need to specify a numeric value for Port.");
                return;
            }

            int waterLevel;
            if (!Int32.TryParse(WaterLeveltextBox.Text.ToString(), out waterLevel))
            {
                MessageBox.Show("You need to specify a numeric value for water level.");
                return;
            }

            #endregion Check Box Value

            if (MessageBox.Show("Save this new region?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.RegiondataGridView.ReadOnly = false;

                long i = 1;
                foreach (byte b in Guid.NewGuid().ToByteArray())
                {
                    i *= ((int)b + 1);
                }
                i -= DateTime.Now.Ticks;
                string str = "Origins_Editor_" + i.ToString();
                DataRow datarow = RegionDatatable.NewRow();

                datarow["Regions_ID"] = str;
                datarow["RegionID"] = Util.Find_Free_Region_ID();
                datarow["Name"] = NametextBox.Text;
                datarow["Description"] = DescriptiontextBox.Text;
                datarow["IP"] = IPtextBox.Text;
                datarow["Port"] = PorttextBox.Text;
                datarow["Expansion"] = ExpansioncomboBox.Text;
                datarow["HousingEnabled"] = Util.Find_Bool_Value(HousingEnablecomboBox.Text);
                datarow["DivingEnabled"] = Util.Find_Bool_Value(DivingEnablecomboBox.Text);
                datarow["WaterLevel"] = WaterLeveltextBox.Text;
                datarow["ClassType"] = ClassTypecomboBox.Text;
                datarow["IsFrontier"] = Util.Find_Bool_Value(IsFrontiercomboBox.Text);

                RegionDatatable.Rows.Add(datarow);

                this.Validate();
                this.RegionbindingSource.EndEdit();
                this.RegiondataAdapter.Update(RegionDatatable);

                this.RegiondataGridView.ReadOnly = true;
                this.EditRegionControl.Hide();
                this.RegiondataGridView.Show();
                this.ControlMenu.Visible = true;
                this.AddRegionButton.Visible = true;
                this.RegionListingButton.Visible = false;
                this.SaveNewbutton.Hide();
            }
        }

        private void SaveLoadedRegion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Accept this region update?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.RegiondataGridView.ReadOnly = false;

                #region Check Box Value

                if (this.RegionIDtextBox.Text == "" || this.RegionIDtextBox.Text == null)
                {
                    MessageBox.Show("You need to specify a RegionID value.");
                    return;
                }
                int styleid;
                if (!Int32.TryParse(RegionIDtextBox.Text.ToString(), out styleid))
                {
                    MessageBox.Show("You need to specify a numeric value for RegionID.");
                    return;
                }

                if (this.IPtextBox.Text == "" || this.IPtextBox.Text == null)
                {
                    MessageBox.Show("You need to specify a IPtextBox value.");
                    return;
                }

                if (this.PorttextBox.Text == "" || this.PorttextBox.Text == null)
                {
                    MessageBox.Show("You need to specify a Port value.");
                    return;
                }
                int port;
                if (!Int32.TryParse(PorttextBox.Text.ToString(), out port))
                {
                    MessageBox.Show("You need to specify a numeric value for Port.");
                    return;
                }

                int waterLevel;
                if (!Int32.TryParse(WaterLeveltextBox.Text.ToString(), out waterLevel))
                {
                    MessageBox.Show("You need to specify a numeric value for water level.");
                    return;
                }

                #endregion Check Box Value

                this.RegiondataGridView.Rows[RegiondataGridView.CurrentCell.RowIndex].Cells["RegionID"].Value = this.RegionIDtextBox.Text;
                this.RegiondataGridView.Rows[RegiondataGridView.CurrentCell.RowIndex].Cells["Name"].Value = this.NametextBox.Text;
                this.RegiondataGridView.Rows[RegiondataGridView.CurrentCell.RowIndex].Cells["Description"].Value = this.DescriptiontextBox.Text;
                this.RegiondataGridView.Rows[RegiondataGridView.CurrentCell.RowIndex].Cells["IP"].Value = this.IPtextBox.Text;
                this.RegiondataGridView.Rows[RegiondataGridView.CurrentCell.RowIndex].Cells["Port"].Value = this.PorttextBox.Text;
                this.RegiondataGridView.Rows[RegiondataGridView.CurrentCell.RowIndex].Cells["Expansion"].Value = this.ExpansioncomboBox.Text;
                this.RegiondataGridView.Rows[RegiondataGridView.CurrentCell.RowIndex].Cells["HousingEnabled"].Value = this.HousingEnablecomboBox.Text;
                this.RegiondataGridView.Rows[RegiondataGridView.CurrentCell.RowIndex].Cells["DivingEnabled"].Value = this.DivingEnablecomboBox.Text;
                this.RegiondataGridView.Rows[RegiondataGridView.CurrentCell.RowIndex].Cells["WaterLevel"].Value = this.WaterLeveltextBox.Text;
                this.RegiondataGridView.Rows[RegiondataGridView.CurrentCell.RowIndex].Cells["ClassType"].Value = this.ClassTypecomboBox.Text;
                this.RegiondataGridView.Rows[RegiondataGridView.CurrentCell.RowIndex].Cells["IsFrontier"].Value = this.IsFrontiercomboBox.Text;

                this.Validate();
                this.RegionbindingSource.EndEdit();
                RegiondataAdapter.Update(RegionDatatable);

                this.RegiondataGridView.ReadOnly = true;
                this.EditRegionControl.Hide();
                this.RegiondataGridView.Show();
                this.ControlMenu.Visible = true;
                this.RegionListingButton.Visible = false;
                this.Savebutton.Hide();
            }
        }

        private void RegionListing_Click(object sender, EventArgs e)
        {
            this.EditRegionControl.Hide();
            this.RegiondataGridView.Show();
            this.Savebutton.Hide();
            this.SaveNewbutton.Hide();
            this.RegionListingButton.Visible = false;
            this.AddRegionButton.Visible = true;
            this.ControlMenu.Visible = true;
        }

        private void AddNewRegion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Begin add a new region?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.RegiondataGridView.Hide();
                this.Savebutton.Hide();
                this.SaveNewbutton.Show();
                this.EditRegionControl.Show();
                this.AddRegionButton.Visible = false;
                this.RegionListingButton.Visible = true;
                this.ControlMenu.Visible = false;
                this.RegionIDtextBox.Text = Util.Find_Free_Region_ID().ToString();
            }
        }
    }
}
