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
    public partial class LoadCraft : Form
    {
        private MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder();
        private MySqlDataAdapter CraftedItemdataAdapter;
        private MySqlDataAdapter CraftedXItemdataAdapter;
        private MySqlConnection connection = new MySqlConnection("server=" + DolEditor.Properties.Settings.Default.ServerIP + ";uid=" + DolEditor.Properties.Settings.Default.Username + ";pwd=" + DolEditor.Properties.Settings.Default.Password + ";database=" + DolEditor.Properties.Settings.Default.DatabaseName + "");
           
        public LoadCraft()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CraftedItemdataGridView.AutoGenerateColumns = true;
            this.CraftedItemdataGridView.AllowUserToDeleteRows = true;

            this.CraftedXItemdataGridView.AutoGenerateColumns = true;
            this.CraftedXItemdataGridView.AllowUserToDeleteRows = true;

            this.CraftingSkillTypeSearchcomboBox.SelectedIndex = 1;
            this.CraftingSkillTypecomboBox.SelectedIndex = 0;
            this.MakeTemplatedcomboBox.SelectedIndex = 0;
            this.GetCraftedItemData("select * from crafteditem");

            this.CraftedItemdataGridView.Columns["CraftedItem_ID"].Visible = false;
        }

        private void GetCraftedItemData(string selectCommand)
        {
            try
            {
                // Create a new data adapter based on the specified query.
                this.CraftedItemdataAdapter = new MySqlDataAdapter(selectCommand, connection);
                // Create a command builder to generate SQL update, insert, and 
                // delete commands based on selectCommand. These are used to 
                // update the database.
                commandBuilder = new MySqlCommandBuilder(this.CraftedItemdataAdapter);
                this.CraftedItemDatatable.Clear();
                // Populate a new data table and bind it to the BindingSource.
                this.CraftedItemDatatable.Locale = System.Globalization.CultureInfo.InvariantCulture;
                this.CraftedItemdataAdapter.Fill(this.CraftedItemDatatable);
                this.CraftedItembindingSource.DataSource = this.CraftedItemDatatable;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
        }

        private void GetCraftedXItemData(string selectCommand)
        {
            try
            {
                // Create a new data adapter based on the specified query.
                this.CraftedXItemdataAdapter = new MySqlDataAdapter(selectCommand, connection);
                // Create a command builder to generate SQL update, insert, and 
                // delete commands based on selectCommand. These are used to 
                // update the database.
                commandBuilder = new MySqlCommandBuilder(this.CraftedXItemdataAdapter);
                this.CraftedXItemDatatable.Clear();
                // Populate a new data table and bind it to the BindingSource.
                this.CraftedXItemDatatable.Locale = System.Globalization.CultureInfo.InvariantCulture;
                this.CraftedXItemdataAdapter.Fill(this.CraftedXItemDatatable);
                this.CraftedXItembindingSource.DataSource = this.CraftedXItemDatatable;
                
                this.CraftedXItemdataGridView.Columns["CraftedXItem_ID"].Visible = false;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
        }

        private void LoadCraftedXitem_Click(object sender, EventArgs e)
        {
            if (this.CraftedItemdataGridView.Rows[this.CraftedItemdataGridView.CurrentCell.RowIndex] != null)
            {
                string id_nb = this.CraftedItemdataGridView.Rows[this.CraftedItemdataGridView.CurrentCell.RowIndex].Cells["id_nb"].Value.ToString();

                this.GetCraftedXItemData("select * from craftedxitem where CraftedItemId_nb='" + id_nb + "'");
            }
            else
                MessageBox.Show("Select a CraftedItem first");
        }

        private bool ValidCraftedItemData()
        {

            int CraftedItemID;

            try
            {
                if (Util.IsEmpty(this.CraftedItemIDtextBox.Text))
                {
                    MessageBox.Show("You need to specify a CraftedItemId for this crafteditem.");
                    return false;
                }

                CraftedItemID = Convert.ToInt16(this.CraftedItemIDtextBox.Text);

                if (CraftedItemID > 0)
                {
                    MySqlDataAdapter CraftedItemIDdataAdapter = new MySqlDataAdapter();
                    string selectCommand = "select * from crafteditem  where crafteditemid = '" + CraftedItemIDtextBox.Text.ToString() + "'";
                    // Create a new data adapter based on the specified query.
                    CraftedItemIDdataAdapter = new MySqlDataAdapter(selectCommand, connection);
                    // Create a command builder to generate SQL update, insert, and 
                    // delete commands based on selectCommand. These are used to 
                    // update the database.
                    MySqlCommandBuilder commandBuilderCraftedItemID = new MySqlCommandBuilder(CraftedItemIDdataAdapter);
                    DataTable CraftedItemIDData = new DataTable();
                    CraftedItemIDData.Clear();
                    // Populate a new data table.
                    CraftedItemIDData.Locale = System.Globalization.CultureInfo.InvariantCulture;
                    CraftedItemIDdataAdapter.Fill(CraftedItemIDData);
                    if (CraftedItemIDData.Rows.Count > 0)
                    {
                        MessageBox.Show("The CraftedItemID already exists.Your data was not updated. You need to change the CraftedItemID.");
                        return false;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show(" WARNING: CraftedItemId value is not suitable.");
                return false;
            }

            if (Util.IsEmpty(this.id_nbtextBox.Text))
            {
                MessageBox.Show("You need to specify a id_nbt for this crafteditem.");
                return false;
            }

            int CraftingLevel;

            try
            {
                if (Util.IsEmpty(this.CraftingLeveltextBox.Text))
                {
                    MessageBox.Show("You need to specify a Crafting Level for this crafteditem.");
                    return false;
                }

                CraftingLevel = Convert.ToInt32(this.CraftingLeveltextBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show(" WARNING: CraftingLevel value is not suitable.");
                return false;
            }
            if (Util.IsEmpty(this.CraftingSkillTypecomboBox.Text))
            {
                MessageBox.Show("You need to specify a CraftingSkill Type for this crafteditem.");
                return false;
            }
            return true;
        }

        private void SaveCraftedItem_Click(object sender, EventArgs e)
        {
            if (!ValidCraftedItemData())
                return;

            if (MessageBox.Show("Become to add a new CraftedItem?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                long i = 1;
                foreach (byte b in Guid.NewGuid().ToByteArray())
                {
                    i *= ((int)b + 1);
                }
                i -= DateTime.Now.Ticks;
                string str = "Dol_Server_Editor_" + i.ToString();

                DataRow datarow = this.CraftedItemDatatable.NewRow();

                datarow["CraftedItem_ID"] = str;
                datarow["CraftedItemID"] = this.CraftedItemIDtextBox.Text;
                datarow["Id_nb"] = this.id_nbtextBox.Text;
                datarow["CraftingLevel"] = this.CraftingLeveltextBox.Text;
                datarow["CraftingSkillType"] = Util.CraftNameToID(this.CraftingSkillTypecomboBox.Text);
                datarow["MakeTemplated"] = Util.Find_Bool_Value(this.MakeTemplatedcomboBox.Text);

                this.CraftedItemDatatable.Rows.Add(datarow);

                this.Validate();
                this.CraftedItembindingSource.EndEdit();

                try
                {
                    this.CraftedItemdataAdapter.Update(this.CraftedItemDatatable);
                }
                catch (MySqlException s)
                {
                    MessageBox.Show(s.Message);
                }
            }
        }

        private bool ValidCraftedXItemData()
        {

            if (this.CraftedItemId_nbtextBox.Text == null || this.CraftedItemId_nbtextBox.Text == "")
            {
                MessageBox.Show("You need to specify a CraftedItemId for this craftedxitem.");
                return false;
            }

            if (this.IngredientId_nbtextBox.Text == null || this.IngredientId_nbtextBox.Text == "")
            {
                MessageBox.Show("You need to specify a IngredientId_nb for this craftedxitem.");
                return false;
            }
            if (this.CounttextBox.Text == null || this.CounttextBox.Text == "")
            {
                MessageBox.Show("You need to specify a count for this craftedxitem.");
                return false;
            }

            int RawMaterialsCount;

            try
            {
                RawMaterialsCount = Convert.ToInt32(this.CounttextBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show(" WARNING: Count value is not suitable.");
                return false;
            }
            return true;
        }

        private void SaveCraftedXItem_Click(object sender, EventArgs e)
        {
            if (!ValidCraftedXItemData())
                return;

            if (MessageBox.Show("Become to add a new CraftedXItem?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                long i = 1;
                foreach (byte b in Guid.NewGuid().ToByteArray())
                {
                    i *= ((int)b + 1);
                }
                i -= DateTime.Now.Ticks;
                string str = "Dol_Server_Editor_" + i.ToString();

                DataRow datarow = this.CraftedXItemDatatable.NewRow();

                datarow["CraftedXItem_ID"] = str;
                datarow["CraftedItemId_nb"] = this.CraftedItemId_nbtextBox.Text;
                datarow["IngredientId_nb"] = this.IngredientId_nbtextBox.Text;
                datarow["Count"] = this.CounttextBox.Text;

                this.CraftedXItemDatatable.Rows.Add(datarow);

                this.Validate();
                this.CraftedXItembindingSource.EndEdit();

                try
                {
                    this.CraftedXItemdataAdapter.Update(this.CraftedXItemDatatable);
                }
                catch (MySqlException s)
                {
                    MessageBox.Show(s.Message);
                }
            }
        }

        private void CraftedItemNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete this CraftedItem?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Validate();
                this.CraftedItembindingSource.EndEdit();

                try
                {
                    this.CraftedItemdataAdapter.Update(this.CraftedItemDatatable);
                }
                catch (MySqlException s)
                {
                    MessageBox.Show(s.Message);
                }
            }

            string select = "SELECT * FROM crafteditem";
            bool add = false; ;
            if (this.CraftingSkillTypeSearchcomboBox.Text != null && this.CraftingSkillTypeSearchcomboBox.Text != "All")
            {
                select += " where CraftingSkillType ='" + Util.CraftNameToID(this.CraftingSkillTypeSearchcomboBox.Text) + "'";
                add = true;
            }

            if (CraftedItemIDSearchtextBox.Text != null && CraftedItemIDSearchtextBox.Text != "")
            {
                if (add)
                    select += " and CraftedItemID='" + CraftedItemIDSearchtextBox.Text + "'";
                else
                {
                    select += " where CraftedItemID='" + CraftedItemIDSearchtextBox.Text + "'";
                    add = true;
                }
            }
            if (this.Id_nbSearchtextBox.Text != null && this.Id_nbSearchtextBox.Text != "")
            {
                if (add)
                    select += " and Id_nb='" + this.Id_nbSearchtextBox.Text + "'";
                else
                {
                    select += " where Id_nb='" + this.Id_nbSearchtextBox.Text + "'";
                    add = true;
                }
            }
            if (this.CraftingLevelSearchtextBox.Text != null && this.CraftingLevelSearchtextBox.Text != "")
            {
                if (add)
                    select += " and CraftingLevel='" + this.CraftingLevelSearchtextBox.Text + "'";
                else
                {
                    select += " where CraftingLevel='" + this.CraftingLevelSearchtextBox.Text + "'";
                    add = true;
                }
            }
            GetCraftedItemData(select);
        }

        private void CraftedXItemNavigatorDeleteItem1_Click(object sender, EventArgs e)
        {
            string id_nb = this.CraftedXItemdataGridView.Rows[this.CraftedXItemdataGridView.CurrentCell.RowIndex].Cells["id_nb"].Value.ToString();

            if (MessageBox.Show("Delete this CraftedXItem?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Validate();
                this.CraftedXItembindingSource.EndEdit();

                try
                {
                    this.CraftedXItemdataAdapter.Update(this.CraftedXItemDatatable);
                }
                catch (MySqlException s)
                {
                    MessageBox.Show(s.Message);
                }
            }

            this.GetCraftedXItemData("select * from craftedxitem where CraftedItemId_nb='" + id_nb + "'");
        }

        private void CraftedItemdataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            this.Validate();
            this.CraftedItembindingSource.EndEdit();

            try
            {
                this.CraftedItemdataAdapter.Update(this.CraftedItemDatatable);
            }
            catch (MySqlException s)
            {
                MessageBox.Show(s.Message);
            }
        }

        private void CraftedXItemdataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            this.Validate();
            this.CraftedXItembindingSource.EndEdit();

            try
            {
                this.CraftedXItemdataAdapter.Update(this.CraftedXItemDatatable);
            }
            catch (MySqlException s)
            {
                MessageBox.Show(s.Message);
            }
        }

        private void Searchbutton_Click(object sender, EventArgs e)
        {
            string select = "SELECT * FROM crafteditem";
            bool add = false; ;
            if (this.CraftingSkillTypeSearchcomboBox.Text != null && this.CraftingSkillTypeSearchcomboBox.Text != "All")
            {
                select += " where CraftingSkillType ='" + Util.CraftNameToID(this.CraftingSkillTypeSearchcomboBox.Text) + "'";
                add = true;
            }

            if (CraftedItemIDSearchtextBox.Text != null && CraftedItemIDSearchtextBox.Text != "")
            {
                if (add)
                    select += " and CraftedItemID='" + CraftedItemIDSearchtextBox.Text + "'";
                else
                {
                    select += " where CraftedItemID='" + CraftedItemIDSearchtextBox.Text + "'";
                    add = true;
                }
            }
            if (this.Id_nbSearchtextBox.Text != null && this.Id_nbSearchtextBox.Text != "")
            {
                if (add)
                    select += " and Id_nb='" + this.Id_nbSearchtextBox.Text + "'";
                else
                {
                    select += " where Id_nb='" + this.Id_nbSearchtextBox.Text + "'";
                    add = true;
                }
            }
            if (this.CraftingLevelSearchtextBox.Text != null && this.CraftingLevelSearchtextBox.Text != "")
            {
                if (add)
                    select += " and CraftingLevel='" + this.CraftingLevelSearchtextBox.Text + "'";
                else
                {
                    select += " where CraftingLevel='" + this.CraftingLevelSearchtextBox.Text + "'";
                    add = true;
                }
            }

            GetCraftedItemData(select);
        }
    }
}
