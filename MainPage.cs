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
using System.Net;
using System.ComponentModel;
using System.IO;
using System.Windows.Threading;
using System.Threading;

namespace Origins_Editor
{

    public partial class MainPageEditor : Form
    {

        public MainPageEditor()
        {

            InitializeComponent();

            bool Flag = false;

            try
            {
                using (MySqlConnection con = new MySqlConnection("server=" + DolEditor.Properties.Settings.Default.ServerIP + ";uid=" + DolEditor.Properties.Settings.Default.Username + ";pwd=" + DolEditor.Properties.Settings.Default.Password + ";database=" + DolEditor.Properties.Settings.Default.DatabaseName + ""))
                {
                    con.Open();
                }
            }
            catch (MySqlException s)
            {
                System.Windows.MessageBox.Show(s.Message);
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
            MySqlConnection thisConnection = new MySqlConnection("server=" + DolEditor.Properties.Settings.Default.ServerIP + ";uid=" + DolEditor.Properties.Settings.Default.Username + ";pwd=" + DolEditor.Properties.Settings.Default.Password + ";database=" + DolEditor.Properties.Settings.Default.DatabaseName + "");
            
            try
            {
                thisConnection.Open();

                MySqlCommand MobCommand = thisConnection.CreateCommand();
                //Need to solve ' in string
                int MobrowsAffected = 0;
                MobCommand.CommandText = "update Mob set name='" + ChangedNametextBox.Text + "' where name ='" + OriginalNametextBox.Text + "'";
                MobrowsAffected = MobCommand.ExecuteNonQuery();

                int MobxAmbientBehaviourrowsAffected = 0;
                if (UpdateMobxAmbientBehaviourcheckBox.Checked)
                {

                    MySqlCommand MobxAmbientBehaviourCommand = thisConnection.CreateCommand();

                    MobxAmbientBehaviourCommand.CommandText = "update MobxAmbientBehaviour set source='" + ChangedNametextBox.Text + "' where source ='" + OriginalNametextBox.Text + "'";
                    MobxAmbientBehaviourrowsAffected = MobxAmbientBehaviourCommand.ExecuteNonQuery();
                }
                int DataquestrowsAffected = 0;
                if (UpdateDataquestcheckBox.Checked)
                {

                    MySqlCommand DataquestCommand = thisConnection.CreateCommand();

                    DataquestCommand.CommandText = "update dataquest set startname='" + ChangedNametextBox.Text + "' where startname ='" + OriginalNametextBox.Text + "'";
                    DataquestrowsAffected = DataquestCommand.ExecuteNonQuery();

                    //Todo remplacer sourcename aussi
                }
                int DropTemplateXItemTemplaterowsAffected = 0;
                int MobDropTemplaterowsAffected = 0;
                if (UpdateDropTemplateXItemTemplatecheckBox.Checked)
                {
                    MySqlCommand DropTemplateXItemTemplateCommand = thisConnection.CreateCommand();

                    DropTemplateXItemTemplateCommand.CommandText = "update DropTemplateXItemTemplate set templatename='" + ChangedNametextBox.Text + "' where templatename ='" + OriginalNametextBox.Text + "'";
                    DropTemplateXItemTemplaterowsAffected = DropTemplateXItemTemplateCommand.ExecuteNonQuery();

                    MySqlCommand MobDropTemplateCommand = thisConnection.CreateCommand();

                    MobDropTemplateCommand.CommandText = "update MobDropTemplate set mobname='" + ChangedNametextBox.Text + "' where mobname ='" + OriginalNametextBox.Text + "'";
                    MobDropTemplaterowsAffected = MobDropTemplateCommand.ExecuteNonQuery();

                    MySqlCommand MobDropTemplateCommand2 = thisConnection.CreateCommand();

                    MobDropTemplateCommand2.CommandText = "update MobDropTemplate set loottemplatename='" + ChangedNametextBox.Text + "' where loottemplatename ='" + OriginalNametextBox.Text + "'";
                    MobDropTemplateCommand2.ExecuteNonQuery();

                }
                int NPCTemplaterowsAffected = 0;
                if (UpdateNPCTemplatecheckBox.Checked)
                {
                    MySqlCommand NPCTemplateCommand = thisConnection.CreateCommand();

                    NPCTemplateCommand.CommandText = "update npctemplate set name='" + ChangedNametextBox.Text + "' where name ='" + OriginalNametextBox.Text + "'";
                    NPCTemplaterowsAffected = NPCTemplateCommand.ExecuteNonQuery();

                }
                int InventoryCreatorrowsAffected = 0;
                if (UpdateInventoryCreatorcheckBox.Checked)
                {

                    MySqlCommand InventoryCreatorCommand = thisConnection.CreateCommand();

                    InventoryCreatorCommand.CommandText = "update inventory set creator='" + ChangedNametextBox.Text + "' where creator ='" + OriginalNametextBox.Text + "'";
                    InventoryCreatorrowsAffected = InventoryCreatorCommand.ExecuteNonQuery();
                }
                int LootTemplaterowsAffected = 0;
                int MobXLootTemplaterowsAffected = 0;
                if (UpdateMobXLootTemplatecheckBox.Checked)
                {
                    MySqlCommand DropTemplateXItemTemplateCommand = thisConnection.CreateCommand();

                    DropTemplateXItemTemplateCommand.CommandText = "update loottemplate set templatename='" + ChangedNametextBox.Text + "' where templatename ='" + OriginalNametextBox.Text + "'";
                    LootTemplaterowsAffected = DropTemplateXItemTemplateCommand.ExecuteNonQuery();

                    MySqlCommand MobXLootTemplateCommand = thisConnection.CreateCommand();

                    MobXLootTemplateCommand.CommandText = "update MobXLootTemplate set mobname='" + ChangedNametextBox.Text + "' where mobname ='" + OriginalNametextBox.Text + "'";
                    MobXLootTemplaterowsAffected = MobXLootTemplateCommand.ExecuteNonQuery();

                    MySqlCommand MobXLootTemplateCommand2 = thisConnection.CreateCommand();

                    MobXLootTemplateCommand2.CommandText = "update MobXLootTemplate set loottemplatename='" + ChangedNametextBox.Text + "' where loottemplatename ='" + OriginalNametextBox.Text + "'";
                    MobXLootTemplateCommand2.ExecuteNonQuery();
                }
                int LootOTDrowsAffected = 0;
                if (UpdateLootOTDcheckBox.Checked)
                {
                    MySqlCommand LootOTDCommand = thisConnection.CreateCommand();

                    LootOTDCommand.CommandText = "update loototd set mobname='" + ChangedNametextBox.Text + "' where mobname ='" + OriginalNametextBox.Text + "'";
                    LootOTDrowsAffected = LootOTDCommand.ExecuteNonQuery();
                }
                int LootGeneratorAffected = 0;
                if (UpdateLootGeneratorcheckBox.Checked)
                {
                    MySqlCommand LootGeneratorCommand = thisConnection.CreateCommand();

                    LootGeneratorCommand.CommandText = "update lootgenerator set mobname='" + ChangedNametextBox.Text + "' where mobname ='" + OriginalNametextBox.Text + "'";
                    LootGeneratorAffected = LootGeneratorCommand.ExecuteNonQuery();
                }


                thisConnection.Close();
            }
            catch (MySqlException s)
            {
                System.Windows.MessageBox.Show(s.Message);
            }
            MessageBox.Show("Count remplaced templates");
        }
    }
}
