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
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace Origins_Editor
{

    public partial class MainPageEditor : Form
    {
        private DataTable MobNameDatatable = new DataTable();
        public DataTable NPCTemplateDatatable = new DataTable();

        public MainPageEditor()
        {

            InitializeComponent();

            bool Flag = false;

            try
            {
                using (MySqlConnection con = Util.Connection)
                {
                    con.Open();
                }
            }
            catch (MySqlException s)
            {
                //MessageBox.Show(s.Message);
                Flag = true;
            }
            finally
            {
                if (Flag)
                {
                    LoadPreferences fm = new LoadPreferences();
                    fm.StartPosition = FormStartPosition.CenterScreen;
                    fm.TopMost = true;
                    fm.Show();
                }
                else
                    this.Load += new EventHandler(Form1_Load);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetRaceComboBoxValue("select * from race ORDER BY name ASC");
            GetFactionComboBoxValue("select * from faction ORDER BY name ASC");
            GetNPCTemplateComboBoxValue("select * from npctemplate ORDER BY name ASC");
            GetMobNameComboBoxValue("select distinct name from mob ORDER BY name ASC");

            this.FactioncomboBox.Text = "None";
            this.RacecomboBox.Text = "None";
            this.BodyTypecomboBox.Text = "None";
            this.NPCTemplatecomboBox.Text = "None";

            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(this.SetAggroLevelto0checkBox, "0 AggroLevel for take advantage of Faction Aggro.");
        }

        private void GetMobNameComboBoxValue(string selectCommand)
        {
            try
            {

                MySqlDataAdapter MobNamedataAdapter = new MySqlDataAdapter(selectCommand, Util.Connection);
                MySqlCommandBuilder commandBuilderMobName = new MySqlCommandBuilder(MobNamedataAdapter);
                MobNameDatatable = new DataTable();
                MobNameDatatable.Clear();
                MobNamedataAdapter.Fill(MobNameDatatable);
                this.MobNamebindingSource.DataSource = MobNameDatatable;

                this.MobNamecomboBox.ValueMember = "Name";
                this.MobNamecomboBox.DisplayMember = "Name";

            }
            catch (MySqlException s)
            {
                MessageBox.Show(s.Message);
            }
        }

        private void GetNPCTemplateComboBoxValue(string selectCommand)
        {
            try
            {

                MySqlDataAdapter NPCTemplatedataAdapter = new MySqlDataAdapter(selectCommand, Util.Connection);
                MySqlCommandBuilder commandBuilderNPCTemplate = new MySqlCommandBuilder(NPCTemplatedataAdapter);
                NPCTemplateDatatable = new DataTable();
                NPCTemplateDatatable.Clear();
                NPCTemplatedataAdapter.Fill(NPCTemplateDatatable);
                this.NPCTemplatebindingSource.DataSource = NPCTemplateDatatable;

                DataRow NPCTemplatedatarow = NPCTemplateDatatable.NewRow();

                NPCTemplatedatarow["Name"] = "None";
                NPCTemplatedatarow["templateid"] = "-1";

                NPCTemplateDatatable.Rows.Add(NPCTemplatedatarow);

                this.NPCTemplatecomboBox.ValueMember = "templateid";
                this.NPCTemplatecomboBox.DisplayMember = "Name";

            }
            catch (MySqlException s)
            {
                MessageBox.Show(s.Message);
            }
        }

        private void GetFactionComboBoxValue(string selectCommand)
        {
            try
            {
                MySqlDataAdapter FactiondataAdapter = new MySqlDataAdapter(selectCommand, Util.Connection);
                MySqlCommandBuilder commandBuilderRace = new MySqlCommandBuilder(FactiondataAdapter);
                DataTable FactionDatatable = new DataTable();
                FactiondataAdapter.Fill(FactionDatatable);
                this.FactionbindingSource.DataSource = FactionDatatable;

                DataRow Factiondatarow = FactionDatatable.NewRow();

                Factiondatarow["Name"] = "None";
                Factiondatarow["ID"] = "0";

                FactionDatatable.Rows.Add(Factiondatarow);

                this.FactioncomboBox.ValueMember = "ID";
                this.FactioncomboBox.DisplayMember = "Name";

            }
            catch (MySqlException s)
            {
                MessageBox.Show(s.Message);
            }
        }

        private void GetRaceComboBoxValue(string selectCommand)
        {
            try
            {
                MySqlDataAdapter RacedataAdapter = new MySqlDataAdapter(selectCommand, Util.Connection);
                MySqlCommandBuilder commandBuilderRace = new MySqlCommandBuilder(RacedataAdapter);
                DataTable RaceDatatable = new DataTable();
                RacedataAdapter.Fill(RaceDatatable);
                this.RacebindingSource.DataSource = RaceDatatable;

                DataRow Racedatarow = RaceDatatable.NewRow();

                Racedatarow["Name"] = "None";
                Racedatarow["ID"] = "0";

                RaceDatatable.Rows.Add(Racedatarow);

                this.RacecomboBox.ValueMember = "ID";
                this.RacecomboBox.DisplayMember = "Name";

            }
            catch (MySqlException s)
            {
                MessageBox.Show(s.Message);
            }
        }
    
        void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadPreferences fm = new LoadPreferences();
            fm.Show();
        }

        private void areaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadArea fm = new LoadArea();
            fm.Show();
        }

        private void spellToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LoadSpell fm = new LoadSpell();
            fm.Show();
        }

        private void styleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LoadStyle fm = new LoadStyle();
            fm.Show();
        }

        private void battleGroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadBattleGround fm = new LoadBattleGround();
            fm.Show();
        }

        private void regionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadRegion fm = new LoadRegion();
            fm.Show();
        }

        private void zoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadZone fm = new LoadZone();
            fm.Show();
        }

        private void CraftedItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadCraft fm = new LoadCraft();
            fm.Show();
        }

        private void NPCTemplateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadNPCTemplate fm = new LoadNPCTemplate(this);
            fm.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadAbout fm = new LoadAbout();
            fm.Show();
        }

        private void UpdateMobNameButton_Click(object sender, EventArgs e)
        {
            if (Util.IsEmpty(MobNamecomboBox.Text))
            {
                MessageBox.Show(" WARNING: Name to be Changed can't be null.");
                return;
            }
            if (Util.IsEmpty(ChangedNametextBox.Text))
            {
                MessageBox.Show(" WARNING: Name to Set can't be null.");
                return;
            }

            int MobrowsAffected = 0;
            int MobxAmbientBehaviourrowsAffected = 0;
            int DataquestrowsAffected = 0;
            int DropTemplateXItemTemplaterowsAffected = 0;
            int MobDropTemplaterowsAffected = 0;
            int NPCTemplaterowsAffected = 0;
            int InventoryCreatorrowsAffected = 0;
            int LootTemplaterowsAffected = 0;
            int MobXLootTemplaterowsAffected = 0;
            int LootOTDrowsAffected = 0;
            int LootGeneratorAffected = 0;

            try
            {
                Util.Connection.Open();

                MySqlDataAdapter MobNameVerifdataAdapter = new MySqlDataAdapter();
                string selectCommand = "select * from mob  where name = '" + ChangedNametextBox.Text.Replace("'", "''") + "'";
                // Create a new data adapter based on the specified query.
                MobNameVerifdataAdapter = new MySqlDataAdapter(selectCommand, Util.Connection);
                // Create a command builder to generate SQL update, insert, and 
                // delete commands based on selectCommand. These are used to 
                // update the database.
                MySqlCommandBuilder commandBuilderMobNameVerif = new MySqlCommandBuilder(MobNameVerifdataAdapter);
                DataTable MobNameVerifData = new DataTable();
                MobNameVerifData.Clear();
                // Populate a new data table.
                MobNameVerifData.Locale = System.Globalization.CultureInfo.InvariantCulture;
                MobNameVerifdataAdapter.Fill(MobNameVerifData);

                if (MobNameVerifData.Rows.Count > 0)
                {
                    if (MessageBox.Show(MobNameVerifData.Rows.Count + " Mobs already have this name. Ignore and rename it?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        Util.Connection.Close();
                        return;
                    }
                }

                MySqlCommand MobCommand = Util.Connection.CreateCommand();

                MobCommand.CommandText = "update Mob set name='" + ChangedNametextBox.Text.Replace("'", "''") + "' where name ='" + MobNamecomboBox.Text.Replace("'", "''") + "'";
                MobrowsAffected = MobCommand.ExecuteNonQuery();

                //Update Mob Name combobox value
                foreach (DataRow myRow in MobNameDatatable.Rows)
                {
                    if (myRow["name"].ToString() == MobNamecomboBox.Text.ToString())
                        myRow["name"] = ChangedNametextBox.Text;
                }

                MobNamecomboBox.SelectedText = ChangedNametextBox.Text;

                if (UpdateMobxAmbientBehaviourcheckBox.Checked)
                {

                    MySqlCommand MobxAmbientBehaviourCommand = Util.Connection.CreateCommand();

                    MobxAmbientBehaviourCommand.CommandText = "update MobxAmbientBehaviour set source='" + ChangedNametextBox.Text.Replace("'", "''") + "' where source ='" + MobNamecomboBox.Text.Replace("'", "''") + "'";
                    MobxAmbientBehaviourrowsAffected = MobxAmbientBehaviourCommand.ExecuteNonQuery();
                }

                if (UpdateDataquestcheckBox.Checked)
                {

                    MySqlCommand DataquestCommand = Util.Connection.CreateCommand();

                    DataquestCommand.CommandText = "update dataquest set startname='" + ChangedNametextBox.Text.Replace("'", "''") + "' where startname ='" + MobNamecomboBox.Text.Replace("'", "''") + "'";
                    DataquestrowsAffected = DataquestCommand.ExecuteNonQuery();

                    //Todo replace sourcename too
                }

                if (UpdateDropTemplateXItemTemplatecheckBox.Checked)
                {
                    MySqlCommand DropTemplateXItemTemplateCommand = Util.Connection.CreateCommand();

                    DropTemplateXItemTemplateCommand.CommandText = "update DropTemplateXItemTemplate set templatename='" + ChangedNametextBox.Text.Replace("'", "''") + "' where templatename ='" + MobNamecomboBox.Text.Replace("'", "''") + "'";
                    DropTemplateXItemTemplaterowsAffected = DropTemplateXItemTemplateCommand.ExecuteNonQuery();

                    MySqlCommand MobDropTemplateCommand = Util.Connection.CreateCommand();

                    MobDropTemplateCommand.CommandText = "update MobDropTemplate set mobname='" + ChangedNametextBox.Text.Replace("'", "''") + "' where mobname ='" + MobNamecomboBox.Text.Replace("'", "''") + "'";
                    MobDropTemplaterowsAffected = MobDropTemplateCommand.ExecuteNonQuery();

                    MySqlCommand MobDropTemplateCommand2 = Util.Connection.CreateCommand();

                    MobDropTemplateCommand2.CommandText = "update MobDropTemplate set loottemplatename='" + ChangedNametextBox.Text.Replace("'", "''") + "' where loottemplatename ='" + MobNamecomboBox.Text.Replace("'", "''") + "'";
                    MobDropTemplateCommand2.ExecuteNonQuery();

                }

                if (UpdateNPCTemplatecheckBox.Checked)
                {
                    MySqlCommand NPCTemplateCommand = Util.Connection.CreateCommand();

                    NPCTemplateCommand.CommandText = "update npctemplate set name='" + ChangedNametextBox.Text.Replace("'", "''") + "' where name ='" + MobNamecomboBox.Text.Replace("'", "''") + "'";
                    NPCTemplaterowsAffected = NPCTemplateCommand.ExecuteNonQuery();

                    //Update NPCTemplate Name combobox value
                    foreach (DataRow myRow in NPCTemplateDatatable.Rows)
                    {
                        if (myRow["name"].ToString() == MobNamecomboBox.Text.ToString())
                            myRow["name"] = ChangedNametextBox.Text;
                    }

                }

                if (UpdateInventoryCreatorcheckBox.Checked)
                {

                    MySqlCommand InventoryCreatorCommand = Util.Connection.CreateCommand();

                    InventoryCreatorCommand.CommandText = "update inventory set creator='" + ChangedNametextBox.Text.Replace("'", "''") + "' where creator ='" + MobNamecomboBox.Text.Replace("'", "''") + "'";
                    InventoryCreatorrowsAffected = InventoryCreatorCommand.ExecuteNonQuery();
                }

                if (UpdateMobXLootTemplatecheckBox.Checked)
                {
                    MySqlCommand DropTemplateXItemTemplateCommand = Util.Connection.CreateCommand();

                    DropTemplateXItemTemplateCommand.CommandText = "update loottemplate set templatename='" + ChangedNametextBox.Text.Replace("'", "''") + "' where templatename ='" + MobNamecomboBox.Text.Replace("'", "''") + "'";
                    LootTemplaterowsAffected = DropTemplateXItemTemplateCommand.ExecuteNonQuery();

                    MySqlCommand MobXLootTemplateCommand = Util.Connection.CreateCommand();

                    MobXLootTemplateCommand.CommandText = "update MobXLootTemplate set mobname='" + ChangedNametextBox.Text.Replace("'", "''") + "' where mobname ='" + MobNamecomboBox.Text.Replace("'", "''") + "'";
                    MobXLootTemplaterowsAffected = MobXLootTemplateCommand.ExecuteNonQuery();

                    MySqlCommand MobXLootTemplateCommand2 = Util.Connection.CreateCommand();

                    MobXLootTemplateCommand2.CommandText = "update MobXLootTemplate set loottemplatename='" + ChangedNametextBox.Text.Replace("'", "''") + "' where loottemplatename ='" + MobNamecomboBox.Text.Replace("'", "''") + "'";
                    MobXLootTemplateCommand2.ExecuteNonQuery();
                }

                if (UpdateLootOTDcheckBox.Checked)
                {
                    MySqlCommand LootOTDCommand = Util.Connection.CreateCommand();

                    LootOTDCommand.CommandText = "update loototd set mobname='" + ChangedNametextBox.Text.Replace("'", "''") + "' where mobname ='" + MobNamecomboBox.Text.Replace("'", "''") + "'";
                    LootOTDrowsAffected = LootOTDCommand.ExecuteNonQuery();
                }

                if (UpdateLootGeneratorcheckBox.Checked)
                {
                    MySqlCommand LootGeneratorCommand = Util.Connection.CreateCommand();

                    LootGeneratorCommand.CommandText = "update lootgenerator set mobname='" + ChangedNametextBox.Text.Replace("'", "''") + "' where mobname ='" + MobNamecomboBox.Text.Replace("'", "''") + "'";
                    LootGeneratorAffected = LootGeneratorCommand.ExecuteNonQuery();
                }

                Util.Connection.Close();
            }
            catch (MySqlException s)
            {
                MessageBox.Show(s.Message);
            }

            MessageBox.Show(string.Format(" Table Mob rows affected: {0}\n Table MobxAmbientBehaviour rows affected: {1}\n Table Dataquest rows affected: {2}\n Table DropTemplateXItemTemplate rows affected: {3}\n Table MobDropTemplate rows affected: {4}\n Table NPCTemplate rows affected: {5}\n Table Inventory rows affected: {6}\n Table LootTemplate rows affected: {7}\n Table MobXLootTemplate rows affected: {8}\n Table LootOTD rows affected: {9}\n Table LootGenerator rows affected: {10}\n ", 
                MobrowsAffected, MobxAmbientBehaviourrowsAffected, DataquestrowsAffected, DropTemplateXItemTemplaterowsAffected, MobDropTemplaterowsAffected, NPCTemplaterowsAffected, InventoryCreatorrowsAffected, LootTemplaterowsAffected, MobXLootTemplaterowsAffected, LootOTDrowsAffected, LootGeneratorAffected));
        }

        private void UpdateMassFactionbutton_Click(object sender, EventArgs e)
        {
            if (Util.IsEmpty(MobNameMassFactiontextBox.Text))
            {
                MessageBox.Show(" WARNING: Name to assign this faction can't be null.");
                return;
            }

            int MobrowsAffected = 0;
            int FactionAggroNPCTemplaterowsAffected = 0;
            int FactionAggroMobrowsAffected = 0;

            try
            {
                Util.Connection.Open();

                MySqlCommand MobCommand = Util.Connection.CreateCommand();

                MobCommand.CommandText = "update Mob set factionid='" + FactioncomboBox.SelectedValue + "' where name ='" + MobNameMassFactiontextBox.Text.Replace("'", "''") + "'";
                MobrowsAffected = MobCommand.ExecuteNonQuery();

                if (SetAggroLevelto0checkBox.Checked)
                {
                    MySqlCommand FactionNPCtemplateAggroCommand = Util.Connection.CreateCommand();

                    FactionNPCtemplateAggroCommand.CommandText = "update npctemplate set aggrolevel='0' where name ='" + MobNameMassFactiontextBox.Text.Replace("'", "''") + "'";
                    FactionAggroNPCTemplaterowsAffected = FactionNPCtemplateAggroCommand.ExecuteNonQuery();

                }

                if (SetAggroLevelto0checkBox.Checked)
                {
                    MySqlCommand FactionMobAggroCommand = Util.Connection.CreateCommand();

                    FactionMobAggroCommand.CommandText = "update mob set aggrolevel='0' where name ='" + MobNameMassFactiontextBox.Text.Replace("'", "''") + "'";
                    FactionAggroMobrowsAffected = FactionMobAggroCommand.ExecuteNonQuery();

                }
                Util.Connection.Close();
            }
            catch (MySqlException s)
            {
                MessageBox.Show(s.Message);
            }

            MessageBox.Show(string.Format(" Table Mob rows affected: {0}\n Table NPCTemplate Aggro rows affected: {1}\n Table Mob Aggro rows affected: {2}",
                MobrowsAffected, FactionAggroNPCTemplaterowsAffected, FactionAggroMobrowsAffected));
        }

        private void RaceMassUpdatebutton_Click(object sender, EventArgs e)
        {
            if (Util.IsEmpty(MobNameMassRacetextBox.Text))
            {
                MessageBox.Show(" WARNING: Name to assign this race can't be null.");
                return;
            }

            int MobrowsAffected = 0;
            int NPCTemplaterowsAffected = 0;

            try
            {
                Util.Connection.Open();

                MySqlCommand MobCommand = Util.Connection.CreateCommand();

                MobCommand.CommandText = "update Mob set race='" + RacecomboBox.SelectedValue + "' where name ='" + MobNameMassRacetextBox.Text.Replace("'", "''") + "'";
                MobrowsAffected = MobCommand.ExecuteNonQuery();

                if (UpdateMassRaceNPCTemplatecheckBox.Checked)
                {
                    MySqlCommand RaceCommand = Util.Connection.CreateCommand();

                    RaceCommand.CommandText = "update npctemplate set race='" + RacecomboBox.SelectedValue + "' where name ='" + MobNameMassRacetextBox.Text.Replace("'", "''") + "'";
                    NPCTemplaterowsAffected = RaceCommand.ExecuteNonQuery();

                }
                Util.Connection.Close();
            }
            catch (MySqlException s)
            {
                MessageBox.Show(s.Message);
            }

            MessageBox.Show(string.Format(" Table Mob rows affected: {0}\n Table NPCTemplate rows affected: {1}\n ", MobrowsAffected, NPCTemplaterowsAffected));
        }

        private void UpdateMassBodyTypebutton_Click(object sender, EventArgs e)
        {
            if (Util.IsEmpty(MobNameUpdateMassBodyTypetextBox.Text))
            {
                MessageBox.Show(" WARNING: Name to assign this bodytype can't be null.");
                return;
            }

            int MobrowsAffected = 0;
            int NPCTemplaterowsAffected = 0;

            try
            {
                Util.Connection.Open();

                MySqlCommand MobCommand = Util.Connection.CreateCommand();

                MobCommand.CommandText = "update Mob set bodytype='" + Util.Find_BodyType_Value(BodyTypecomboBox.Text) + "' where name ='" + MobNameUpdateMassBodyTypetextBox.Text.Replace("'", "''") + "'";
                MobrowsAffected = MobCommand.ExecuteNonQuery();

                if (UpdateMassNPCTemplateBodyTypecheckBox.Checked)
                {
                    MySqlCommand RaceCommand = Util.Connection.CreateCommand();

                    RaceCommand.CommandText = "update npctemplate set bodytype='" + Util.Find_BodyType_Value(BodyTypecomboBox.Text) + "' where name ='" + MobNameUpdateMassBodyTypetextBox.Text.Replace("'", "''") + "'";
                    NPCTemplaterowsAffected = RaceCommand.ExecuteNonQuery();

                }
                Util.Connection.Close();
            }
            catch (MySqlException s)
            {
                MessageBox.Show(s.Message);
            }

            MessageBox.Show(string.Format(" Table Mob rows affected: {0}\n Table NPCTemplate rows affected: {1}\n ", MobrowsAffected, NPCTemplaterowsAffected));
        }

        private void UpdateMassNPCTemplatebutton_Click(object sender, EventArgs e)
        {
            if (Util.IsEmpty(MobNameMassNPCTemplatetextBox.Text))
            {
                MessageBox.Show(" WARNING: Name to assign this npctemplate can't be null.");
                return;
            }

            int MobrowsAffected = 0;

            try
            {
                Util.Connection.Open();
                MySqlCommand MobCommand = Util.Connection.CreateCommand();

                MobCommand.CommandText = "update Mob set npctemplateid='" + NPCTemplatecomboBox.SelectedValue + "' where name ='" + MobNameMassNPCTemplatetextBox.Text.Replace("'", "''") + "'";
                MobrowsAffected = MobCommand.ExecuteNonQuery();

                Util.Connection.Close();
            }
            catch (MySqlException s)
            {
                MessageBox.Show(s.Message);
            }

            MessageBox.Show(string.Format(" Table Mob rows affected: {0}", MobrowsAffected));
        }

        private void factionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadFaction fm = new LoadFaction();
            fm.Show();
        }

        private void lootOTDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadLootOTD fm = new LoadLootOTD();
            fm.Show();
        }

        private void mobToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadMob fm = new LoadMob(this);
            fm.Show();
        }
    }
}
