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
        public MySqlConnection connection = new MySqlConnection("server=" + DolEditor.Properties.Settings.Default.ServerIP + ";uid=" + DolEditor.Properties.Settings.Default.Username + ";pwd=" + DolEditor.Properties.Settings.Default.Password + ";database=" + DolEditor.Properties.Settings.Default.DatabaseName + "");

        public MainPageEditor()
        {

            InitializeComponent();

            bool Flag = false;

            try
            {
                using (MySqlConnection con = connection)
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

            this.FactioncomboBox.Text = "None";
            this.RacecomboBox.Text = "None";
            this.BodyTypecomboBox.Text = "None";
            this.NPCTemplatecomboBox.Text = "None";

            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(this.SetAggroLevelto0checkBox, "0 AggroLevel for take advantage of Faction Aggro.");
        }

        private void GetNPCTemplateComboBoxValue(string selectCommand)
        {
            try
            {

                MySqlDataAdapter NPCTemplatedataAdapter = new MySqlDataAdapter(selectCommand, connection);
                MySqlCommandBuilder commandBuilderNPCTemplate = new MySqlCommandBuilder(NPCTemplatedataAdapter);
                DataTable NPCTemplateDatatable = new DataTable();
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
                MySqlDataAdapter FactiondataAdapter = new MySqlDataAdapter(selectCommand, connection);
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
                MySqlDataAdapter RacedataAdapter = new MySqlDataAdapter(selectCommand, connection);
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
            LoadNPCTemplate fm = new LoadNPCTemplate();
            fm.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadAbout fm = new LoadAbout();
            fm.Show();
        }

        private void UpdateMobNameButton_Click(object sender, EventArgs e)
        {
            if (Util.IsEmpty(OriginalNametextBox.Text))
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
                connection.Open();

                MySqlCommand MobCommand = connection.CreateCommand();

                MobCommand.CommandText = "update Mob set name='" + ChangedNametextBox.Text.Replace("'", "''") +"' where name ='" + OriginalNametextBox.Text.Replace("'", "''") +"'";
                MobrowsAffected = MobCommand.ExecuteNonQuery();

                if (UpdateMobxAmbientBehaviourcheckBox.Checked)
                {

                    MySqlCommand MobxAmbientBehaviourCommand = connection.CreateCommand();

                    MobxAmbientBehaviourCommand.CommandText = "update MobxAmbientBehaviour set source='" + ChangedNametextBox.Text.Replace("'", "''") + "' where source ='" + OriginalNametextBox.Text.Replace("'", "''") + "'";
                    MobxAmbientBehaviourrowsAffected = MobxAmbientBehaviourCommand.ExecuteNonQuery();
                }

                if (UpdateDataquestcheckBox.Checked)
                {

                    MySqlCommand DataquestCommand = connection.CreateCommand();

                    DataquestCommand.CommandText = "update dataquest set startname='" + ChangedNametextBox.Text.Replace("'", "''") + "' where startname ='" + OriginalNametextBox.Text.Replace("'", "''") + "'";
                    DataquestrowsAffected = DataquestCommand.ExecuteNonQuery();

                    //Todo replace sourcename too
                }

                if (UpdateDropTemplateXItemTemplatecheckBox.Checked)
                {
                    MySqlCommand DropTemplateXItemTemplateCommand = connection.CreateCommand();

                    DropTemplateXItemTemplateCommand.CommandText = "update DropTemplateXItemTemplate set templatename='" + ChangedNametextBox.Text.Replace("'", "''") + "' where templatename ='" + OriginalNametextBox.Text.Replace("'", "''") + "'";
                    DropTemplateXItemTemplaterowsAffected = DropTemplateXItemTemplateCommand.ExecuteNonQuery();

                    MySqlCommand MobDropTemplateCommand = connection.CreateCommand();

                    MobDropTemplateCommand.CommandText = "update MobDropTemplate set mobname='" + ChangedNametextBox.Text.Replace("'", "''") + "' where mobname ='" + OriginalNametextBox.Text.Replace("'", "''") + "'";
                    MobDropTemplaterowsAffected = MobDropTemplateCommand.ExecuteNonQuery();

                    MySqlCommand MobDropTemplateCommand2 = connection.CreateCommand();

                    MobDropTemplateCommand2.CommandText = "update MobDropTemplate set loottemplatename='" + ChangedNametextBox.Text.Replace("'", "''") + "' where loottemplatename ='" + OriginalNametextBox.Text.Replace("'", "''") + "'";
                    MobDropTemplateCommand2.ExecuteNonQuery();

                }

                if (UpdateNPCTemplatecheckBox.Checked)
                {
                    MySqlCommand NPCTemplateCommand = connection.CreateCommand();

                    NPCTemplateCommand.CommandText = "update npctemplate set name='" + ChangedNametextBox.Text.Replace("'", "''") + "' where name ='" + OriginalNametextBox.Text.Replace("'", "''") + "'";
                    NPCTemplaterowsAffected = NPCTemplateCommand.ExecuteNonQuery();

                }

                if (UpdateInventoryCreatorcheckBox.Checked)
                {

                    MySqlCommand InventoryCreatorCommand = connection.CreateCommand();

                    InventoryCreatorCommand.CommandText = "update inventory set creator='" + ChangedNametextBox.Text.Replace("'", "''") + "' where creator ='" + OriginalNametextBox.Text.Replace("'", "''") + "'";
                    InventoryCreatorrowsAffected = InventoryCreatorCommand.ExecuteNonQuery();
                }

                if (UpdateMobXLootTemplatecheckBox.Checked)
                {
                    MySqlCommand DropTemplateXItemTemplateCommand = connection.CreateCommand();

                    DropTemplateXItemTemplateCommand.CommandText = "update loottemplate set templatename='" + ChangedNametextBox.Text.Replace("'", "''") + "' where templatename ='" + OriginalNametextBox.Text.Replace("'", "''") + "'";
                    LootTemplaterowsAffected = DropTemplateXItemTemplateCommand.ExecuteNonQuery();

                    MySqlCommand MobXLootTemplateCommand = connection.CreateCommand();

                    MobXLootTemplateCommand.CommandText = "update MobXLootTemplate set mobname='" + ChangedNametextBox.Text.Replace("'", "''") + "' where mobname ='" + OriginalNametextBox.Text.Replace("'", "''") + "'";
                    MobXLootTemplaterowsAffected = MobXLootTemplateCommand.ExecuteNonQuery();

                    MySqlCommand MobXLootTemplateCommand2 = connection.CreateCommand();

                    MobXLootTemplateCommand2.CommandText = "update MobXLootTemplate set loottemplatename='" + ChangedNametextBox.Text.Replace("'", "''") + "' where loottemplatename ='" + OriginalNametextBox.Text.Replace("'", "''") + "'";
                    MobXLootTemplateCommand2.ExecuteNonQuery();
                }

                if (UpdateLootOTDcheckBox.Checked)
                {
                    MySqlCommand LootOTDCommand = connection.CreateCommand();

                    LootOTDCommand.CommandText = "update loototd set mobname='" + ChangedNametextBox.Text.Replace("'", "''") + "' where mobname ='" + OriginalNametextBox.Text.Replace("'", "''") + "'";
                    LootOTDrowsAffected = LootOTDCommand.ExecuteNonQuery();
                }

                if (UpdateLootGeneratorcheckBox.Checked)
                {
                    MySqlCommand LootGeneratorCommand = connection.CreateCommand();

                    LootGeneratorCommand.CommandText = "update lootgenerator set mobname='" + ChangedNametextBox.Text.Replace("'", "''") + "' where mobname ='" + OriginalNametextBox.Text.Replace("'", "''") + "'";
                    LootGeneratorAffected = LootGeneratorCommand.ExecuteNonQuery();
                }


                connection.Close();
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
                connection.Open();

                MySqlCommand MobCommand = connection.CreateCommand();

                MobCommand.CommandText = "update Mob set factionid='" + FactioncomboBox.SelectedValue + "' where name ='" + MobNameMassFactiontextBox.Text.Replace("'", "''") + "'";
                MobrowsAffected = MobCommand.ExecuteNonQuery();

                if (SetAggroLevelto0checkBox.Checked)
                {
                    MySqlCommand FactionNPCtemplateAggroCommand = connection.CreateCommand();

                    FactionNPCtemplateAggroCommand.CommandText = "update npctemplate set aggrolevel='0' where name ='" + MobNameMassFactiontextBox.Text.Replace("'", "''") + "'";
                    FactionAggroNPCTemplaterowsAffected = FactionNPCtemplateAggroCommand.ExecuteNonQuery();

                }

                if (SetAggroLevelto0checkBox.Checked)
                {
                    MySqlCommand FactionMobAggroCommand = connection.CreateCommand();

                    FactionMobAggroCommand.CommandText = "update mob set aggrolevel='0' where name ='" + MobNameMassFactiontextBox.Text.Replace("'", "''") + "'";
                    FactionAggroMobrowsAffected = FactionMobAggroCommand.ExecuteNonQuery();

                }
                connection.Close();
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
                connection.Open();

                MySqlCommand MobCommand = connection.CreateCommand();

                MobCommand.CommandText = "update Mob set race='" + RacecomboBox.SelectedValue + "' where name ='" + MobNameMassRacetextBox.Text.Replace("'", "''") + "'";
                MobrowsAffected = MobCommand.ExecuteNonQuery();

                if (UpdateMassRaceNPCTemplatecheckBox.Checked)
                {
                    MySqlCommand RaceCommand = connection.CreateCommand();

                    RaceCommand.CommandText = "update npctemplate set race='" + RacecomboBox.SelectedValue + "' where name ='" + MobNameMassRacetextBox.Text.Replace("'", "''") + "'";
                    NPCTemplaterowsAffected = RaceCommand.ExecuteNonQuery();

                }
                connection.Close();
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
                connection.Open();

                MySqlCommand MobCommand = connection.CreateCommand();

                MobCommand.CommandText = "update Mob set bodytype='" + Util.Find_BodyType_Value(BodyTypecomboBox.Text) + "' where name ='" + MobNameUpdateMassBodyTypetextBox.Text.Replace("'", "''") + "'";
                MobrowsAffected = MobCommand.ExecuteNonQuery();

                if (UpdateMassNPCTemplateBodyTypecheckBox.Checked)
                {
                    MySqlCommand RaceCommand = connection.CreateCommand();

                    RaceCommand.CommandText = "update npctemplate set bodytype='" + Util.Find_BodyType_Value(BodyTypecomboBox.Text) + "' where name ='" + MobNameUpdateMassBodyTypetextBox.Text.Replace("'", "''") + "'";
                    NPCTemplaterowsAffected = RaceCommand.ExecuteNonQuery();

                }
                connection.Close();
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
                connection.Open();
                MySqlCommand MobCommand = connection.CreateCommand();

                MobCommand.CommandText = "update Mob set npctemplateid='" + NPCTemplatecomboBox.SelectedValue + "' where name ='" + MobNameMassNPCTemplatetextBox.Text.Replace("'", "''") + "'";
                MobrowsAffected = MobCommand.ExecuteNonQuery();

                connection.Close();
            }
            catch (MySqlException s)
            {
                MessageBox.Show(s.Message);
            }

            MessageBox.Show(string.Format(" Table Mob rows affected: {0}", MobrowsAffected));
        }
    }
}
