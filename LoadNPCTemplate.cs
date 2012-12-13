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
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;

namespace Origins_Editor
{
    public partial class LoadNPCTemplate : Form
    {
        private MySqlDataAdapter NPCTemplateTranslationdataAdapter = new MySqlDataAdapter();
        private MySqlDataAdapter NPCTemplatedataAdapter = new MySqlDataAdapter();
        private MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder();
        private DataTable RaceDatatable = new DataTable();
        private DataTable TranslationDatatable = new DataTable();
        private bool loaded;
        private MainPageEditor mainpage = null;
        public MobsModelChoice MobsChoiceOpen = null;

        public LoadNPCTemplate(MainPageEditor form)
        {
            InitializeComponent();
            //Assign the Main Page
            mainpage = form;

            this.Load += new EventHandler(Form1_Load);

            if (DolEditor.Properties.Settings.Default.OriginsSettings)
            {
                IsCharmablecomboBox.Visible = true;
                IsCharmablelabel.Visible = true;
                FRNamelabel.Visible = true;
                FRNametextBox.Visible = true;
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (MobsChoiceOpen != null)
                MobsChoiceOpen.Close();

            MobsChoiceOpen = null;

            base.OnFormClosing(e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.NPCTemplateListingButton.Visible = false;
            this.Savebutton.Hide();
            this.SaveNewbutton.Hide();
            this.NPCTemplatedataGridView.AutoGenerateColumns = true;
            this.NPCTemplatedataGridView.AllowUserToDeleteRows = true;
            this.IsCharmablecomboBox.SelectedIndex = 0;
            this.ReplaceMobValuescomboBox.SelectedIndex = 0;

            this.flags = 0X00;

            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(this.StrengthtextBox, "0 Strength Means SetAutoStats.");
            toolTip1.SetToolTip(this.groupBox11, "Level, Size and Models can be multiple.");
            toolTip1.SetToolTip(this.AggroLevelUpDown, "0 -> 25 Amical | 26 -> 50 Neutral | 51 -> 75 Hostile | 76 -> 100 Agressive");
            toolTip1.SetToolTip(this.TranslationIDtextBox, "Change this value automatically update the translation block.");

            this.GetNPCTemplateItemData("select * from npctemplate");

            this.NPCTemplatedataGridView.Columns["NPCTemplate_ID"].Visible = false;

            this.NPCTemplatedataGridView.DataSource = this.NPCTemplatebindingSource;

            try
            {

                MySqlDataAdapter RacedataAdapter = new MySqlDataAdapter("select * from race ORDER BY name ASC", Util.Connection);
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

                MySqlDataAdapter ClassTypeSearchdataAdapter = new MySqlDataAdapter("select distinct classtype from npctemplate ORDER BY classtype ASC", Util.Connection);
                MySqlCommandBuilder commandBuilderClassTypeSearch = new MySqlCommandBuilder(ClassTypeSearchdataAdapter);
                DataTable ClassTypeSearchDatatable = new DataTable();
                ClassTypeSearchdataAdapter.Fill(ClassTypeSearchDatatable);
                this.ClassTypeSearchcomboBox.DataSource = ClassTypeSearchDatatable;

                DataRow ClassTypeSearchdatarow = ClassTypeSearchDatatable.NewRow();
                ClassTypeSearchdatarow["ClassType"] = " All";
                ClassTypeSearchDatatable.Rows.Add(ClassTypeSearchdatarow);

                this.ClassTypeSearchcomboBox.ValueMember = "ClassType";
                this.ClassTypeSearchcomboBox.DisplayMember = "ClassType";
                this.ClassTypeSearchcomboBox.Text = " All";

                DataTable ClassTypeDatatable = new DataTable();
                ClassTypeSearchdataAdapter.Fill(ClassTypeDatatable);
                this.ClassTypecomboBox.DataSource = ClassTypeDatatable;

                this.ClassTypecomboBox.ValueMember = "ClassType";
                this.ClassTypecomboBox.DisplayMember = "ClassType";


                MySqlDataAdapter PackageIDSearchdataAdapter = new MySqlDataAdapter("select distinct packageid from npctemplate ORDER BY packageid ASC", Util.Connection);
                MySqlCommandBuilder commandBuilderPackageIDSearch = new MySqlCommandBuilder(PackageIDSearchdataAdapter);
                DataTable PackageIDSearchDatatable = new DataTable();
                PackageIDSearchdataAdapter.Fill(PackageIDSearchDatatable);
                this.PackageIDSearchcomboBox.DataSource = PackageIDSearchDatatable;

                DataRow datarow = PackageIDSearchDatatable.NewRow();
                datarow["PackageID"] = " All";
                PackageIDSearchDatatable.Rows.Add(datarow);

                this.PackageIDSearchcomboBox.ValueMember = "PackageID";
                this.PackageIDSearchcomboBox.DisplayMember = "PackageID";
                this.PackageIDSearchcomboBox.Text = " All";
            }
            catch (MySqlException s)
            {
                MessageBox.Show(s.Message);
            }
        }

        private void GetNPCTemplateItemData(string selectCommand)
        {
            try
            {
                // Create a new data adapter based on the specified query.
                this.NPCTemplatedataAdapter = new MySqlDataAdapter(selectCommand, Util.Connection);
                // Create a command builder to generate SQL update, insert, and 
                // delete commands based on selectCommand. These are used to 
                // update the database.
                commandBuilder = new MySqlCommandBuilder(this.NPCTemplatedataAdapter);
                this.NPCTemplateDatatable.Clear();
                // Populate a new data table and bind it to the BindingSource.
                this.NPCTemplateDatatable.Locale = System.Globalization.CultureInfo.InvariantCulture;
                this.NPCTemplatedataAdapter.Fill(this.NPCTemplateDatatable);
                this.NPCTemplatebindingSource.DataSource = this.NPCTemplateDatatable;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
        }

        private void GetNPCTemplateTranslationItemData(string selectCommand)
        {
            try
            {
                // Create a new data adapter based on the specified query.
                NPCTemplateTranslationdataAdapter = new MySqlDataAdapter(selectCommand, Util.Connection);
                // Create a command builder to generate SQL update, insert, and 
                // delete commands based on selectCommand. These are used to 
                // update the database.
                MySqlCommandBuilder commandBuilderTranslation = new MySqlCommandBuilder(NPCTemplateTranslationdataAdapter);
                this.TranslationDatatable.Clear();
                // Populate a new data table and bind it to the BindingSource.
                this.TranslationDatatable.Locale = System.Globalization.CultureInfo.InvariantCulture;
                NPCTemplateTranslationdataAdapter.Fill(TranslationDatatable);
                this.TranslationbindingSource.DataSource = TranslationDatatable;
                this.TranslationdataGridView.AutoGenerateColumns = true;
                this.TranslationdataGridView.Columns["LanguageNPC_ID"].Visible = false;
                this.TranslationdataGridView.Columns["TranslationID"].Visible = false;
                this.TranslationdataGridView.AllowUserToDeleteRows = true;
            }
            catch (MySqlException ex) 
            { 
                MessageBox.Show("Error " + ex.Message); 
            }
        }

        private void NPCTemplateNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete this NPCTemplate?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Validate();
                this.NPCTemplatebindingSource.EndEdit();
                this.NPCTemplatedataAdapter.Update(this.NPCTemplateDatatable);
            }

            string select = "SELECT * FROM npctemplate";
            bool add = false; ;
            if (this.SearchNPCTemplateIDtextBox.Text != "")
            {
                select += " where Templateid='" + this.SearchNPCTemplateIDtextBox.Text + "'";
                add = true;
            }

            if (this.SearchByNPCTemplateNametextBox.Text != "")
            {
                if (add)
                    select += " and Name like '%" + this.SearchByNPCTemplateNametextBox.Text + "%'";
                else
                {
                    select += " where Name like '%" + this.SearchByNPCTemplateNametextBox.Text + "%'";
                    add = true;
                }
            }
            string PackageID = " All";
            if (this.PackageIDSearchcomboBox.Text != null)
                PackageID = this.PackageIDSearchcomboBox.Text.ToString(); //PackageID

            if (PackageID != " All")
            {
                if (add)
                    select += " and packageid='" + PackageID + "'";
                else
                {
                    select += " where packageid='" + PackageID + "'";
                    add = true;
                }
            }
            string ClassType = " All";
            if (ClassTypeSearchcomboBox.Text != null)
                ClassType = this.ClassTypeSearchcomboBox.Text.ToString(); //ClassType

            if (ClassType != " All")
            {
                if (add)
                    select += " and classtype='" + ClassType + "')";
                else
                {
                    select += " where classtype='" + ClassType + "')";
                    add = true;
                }
            }

            GetNPCTemplateItemData(select);
        }

        private void AddNewNPCTemplate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Become to add a new NPCTemplate?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // user clicked yes
                this.NPCTemplatedataGridView.Hide();

                long i = 1;
                foreach (byte b in Guid.NewGuid().ToByteArray())
                {
                    i *= ((int)b + 1);
                }
                i -= DateTime.Now.Ticks;
                string str = "Dol_Server_Editor_" + i.ToString();
                this.TemplateIDtextBox.Text = Util.Find_Free_NPCTemplateID().ToString();

                this.ControlEditor.Show();
                this.Savebutton.Hide();
                this.SaveNewbutton.Show();
                this.NPCTemplateListingButton.Visible = true;
                this.AddNPCTemplateButton.Visible = false;
                this.ControlMenu.Visible = false;
                loaded = true;
            }
        }

        private void NPCTemplateListing_Click(object sender, EventArgs e)
        {

            if (MobsChoiceOpen != null)
            {
                MobsChoiceOpen.Close();
                MobsChoiceOpen = null;
            }

            this.flags = 0X00;
            this.Savebutton.Hide();
            this.SaveNewbutton.Hide();
            this.NPCTemplateListingButton.Visible = false;
            this.AddNPCTemplateButton.Visible = true;
            this.ControlMenu.Visible = true;
            this.ControlEditor.Hide();
            this.NPCTemplatedataGridView.Show();
            loaded = false;
        }

        private void SaveNewbutton_Click(object sender, EventArgs e)
        {
            if (!ValidNPCTemplateData())
                return;

            if (MessageBox.Show("Save this new npctemplate?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                try
                {
                    // user clicked yes
                    MySqlDataAdapter NewNPCTemplateVerifdataAdapter = new MySqlDataAdapter();
                    string selectCommand = "select * from npctemplate  where templateid = '" + TemplateIDtextBox.Text.ToString() + "'";
                    // Create a new data adapter based on the specified query.
                    NewNPCTemplateVerifdataAdapter = new MySqlDataAdapter(selectCommand, Util.Connection);
                    // Create a command builder to generate SQL update, insert, and 
                    // delete commands based on selectCommand. These are used to 
                    // update the database.
                    MySqlCommandBuilder commandBuilderNPCTemplateIDData = new MySqlCommandBuilder(NewNPCTemplateVerifdataAdapter);
                    DataTable NPCTemplateIDData = new DataTable();
                    NPCTemplateIDData.Clear();
                    // Populate a new data table.
                    NPCTemplateIDData.Locale = System.Globalization.CultureInfo.InvariantCulture;
                    NewNPCTemplateVerifdataAdapter.Fill(NPCTemplateIDData);
                    if (NPCTemplateIDData.Rows.Count > 0)
                    {
                        this.TemplateIDtextBox.Text = Util.Find_Free_NPCTemplateID().ToString();
                        MessageBox.Show("The npctemplate was not updated because the template is not anymore free. You need to save your spell again.");
                    }
                    else
                    {

                        long i = 1;
                        foreach (byte b in Guid.NewGuid().ToByteArray())
                        {
                            i *= ((int)b + 1);
                        }
                        i -= DateTime.Now.Ticks;
                        string str = "Dol_Server_Editor_" + i.ToString();

                        DataRow datarow = this.NPCTemplateDatatable.NewRow();

                        datarow["NPCTemplate_ID"] = str;
                        datarow["TemplateID"] = TemplateIDtextBox.Text;
                        datarow["Name"] = NametextBox.Text;
                        datarow["FRName"] = FRNametextBox.Text;
                        datarow["GuildName"] = GuildNametextBox.Text;
                        datarow["Model"] = ModeltextBox.Text;

                        string size = "";

                        if (LowSizenumericUpDown.Value == HightSizenumericUpDown.Value)
                            size = LowSizenumericUpDown.Value.ToString();
                        else
                        {
                            size = LowSizenumericUpDown.Value.ToString() + "-" + HightSizenumericUpDown.Value.ToString();
                        }

                        datarow["Size"] = size;
                        datarow["MaxSpeed"] = MaxSpeedtextBox.Text;
                        datarow["EquipmentTemplateID"] = EquipmentTemplateIDtextBox.Text;

                        uint flagsToSet = 0;
                        if (GhostcheckBox.Checked == true)
                            flagsToSet ^= 0x01;
                        if (StealthcheckBox.Checked == true)
                            flagsToSet ^= 0x02;
                        if (DontShowNamecheckBox.Checked == true)
                            flagsToSet ^= 0x04;
                        if (CantTargetcheckBox.Checked == true)
                            flagsToSet ^= 0x08;
                        if (PeacecheckBox.Checked == true)
                            flagsToSet ^= 0x10;
                        if (FlyingcheckBox.Checked == true)
                            flagsToSet ^= 0x20;
                        if (TorchcheckBox.Checked == true)
                            flagsToSet ^= 0x40;
                        if (StatuecheckBox.Checked == true)
                            flagsToSet ^= 0x80;
                        if (SwimmingcheckBox.Checked == true)
                            flagsToSet ^= 0x100;

                        datarow["Flags"] = flagsToSet;
                        datarow["MeleeDamageType"] = Util.Find_DamageType_Value(MeleeDamageTypecomboBox.Text);
                        datarow["ParryChance"] = ParryChanceNumericUpDown.Value;
                        datarow["EvadeChance"] = EvadeChanceNumericUpDown.Value;
                        datarow["BlockChance"] = BlockChanceNumericUpDown.Value;
                        datarow["LeftHandSwingChance"] = LeftHandSwingChanceNumericUpDown.Value;
                        datarow["Spells"] = SpellsrichTextBox.Text;
                        datarow["Styles"] = StylesrichTextBox.Text;
                        datarow["Strength"] = StrengthtextBox.Text;
                        datarow["Constitution"] = ConstitutiontextBox.Text;
                        datarow["Dexterity"] = DexteritytextBox.Text;
                        datarow["Quickness"] = QuicknesstextBox.Text;
                        datarow["Intelligence"] = IntelligencetextBox.Text;
                        datarow["Piety"] = PietytextBox.Text;
                        datarow["Charisma"] = CharismatextBox.Text;
                        datarow["Empathy"] = EmpathytextBox.Text;
                        datarow["Abilities"] = AbilitiesrichTextBox.Text;
                        datarow["AggroLevel"] = AggroLevelUpDown.Text;
                        datarow["AggroRange"] = AggroRangetextBox.Text;
                        datarow["ClassType"] = ClassTypecomboBox.Text;

                        string level = "";

                        if (LowLevelnumericUpDown.Value == HightLevelnumericUpDown.Value)
                            level = LowLevelnumericUpDown.Value.ToString();
                        else
                        {
                            level = LowLevelnumericUpDown.Value.ToString() + "-" + HightLevelnumericUpDown.Value.ToString();
                        }

                        datarow["Level"] = level;
                        datarow["Race"] = RacecomboBox.SelectedValue != null && RacecomboBox.SelectedText != "None" ? RacecomboBox.SelectedValue : "0";
                        datarow["BodyType"] = Util.Find_BodyType_Value(BodyTypecomboBox.Text);
                        datarow["MaxDistance"] = MaxDistancetextBox.Text;
                        datarow["TetherRange"] = TetherRangetextBox.Text;
                        datarow["PackageID"] = PackageIDtextBox.Text;
                        datarow["VisibleWeaponSlots"] = VisibleWeaponSlotstextBox.Text;
                        datarow["ReplaceMobValues"] = Util.Find_Bool_Value(ReplaceMobValuescomboBox.Text);
                        datarow["ItemsListTemplateID"] = ItemsListTemplateIDtextBox.Text;

                        if (DolEditor.Properties.Settings.Default.OriginsSettings)
                            datarow["IsCharmable"] = Util.Find_Bool_Value(IsCharmablecomboBox.Text);

                        datarow["TranslationId"] = TranslationIDtextBox.Text;
                        datarow["Suffix"] = SuffixtextBox.Text;
                        datarow["ExamineArticle"] = ExamineArticletextBox.Text;
                        datarow["MessageArticle"] = MessageArticletextBox.Text;

                        this.NPCTemplateDatatable.Rows.Add(datarow);

                        if (MobsChoiceOpen != null)
                        {
                            MobsChoiceOpen.Close();
                            MobsChoiceOpen = null;
                        }

                        this.Validate();
                        this.NPCTemplatebindingSource.EndEdit();

                        try
                        {
                            NPCTemplatedataAdapter.Update(this.NPCTemplateDatatable);
                        }
                        catch (Exception s)
                        {
                            MessageBox.Show(s.Message);
                        }

                        this.ControlEditor.Hide();
                        this.NPCTemplatedataGridView.Show();
                        this.ControlMenu.Visible = true;
                        this.AddNPCTemplateButton.Visible = true;
                        this.NPCTemplateListingButton.Visible = false;
                        this.SaveNewbutton.Hide();
                        this.flags = 0X00;
                        loaded = false;
                    }

                }
                catch (MySqlException s)
                {
                    MessageBox.Show(s.Message);
                }
            }
        }

        private void SaveLoadedNPCTemplate_Click(object sender, EventArgs e)
        {
            if (!ValidNPCTemplateData())
                return;

            if (MessageBox.Show("Save your modifications?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                this.NPCTemplatedataGridView.ReadOnly = false;
                this.NPCTemplatedataGridView.Rows[NPCTemplatedataGridView.CurrentCell.RowIndex].Cells["TemplateId"].Value = TemplateIDtextBox.Text;
                this.NPCTemplatedataGridView.Rows[NPCTemplatedataGridView.CurrentCell.RowIndex].Cells["Name"].Value = NametextBox.Text;

                if (DolEditor.Properties.Settings.Default.OriginsSettings)
                    this.NPCTemplatedataGridView.Rows[NPCTemplatedataGridView.CurrentCell.RowIndex].Cells["FRName"].Value = FRNametextBox.Text;
                
                this.NPCTemplatedataGridView.Rows[NPCTemplatedataGridView.CurrentCell.RowIndex].Cells["GuildName"].Value = GuildNametextBox.Text;
                this.NPCTemplatedataGridView.Rows[NPCTemplatedataGridView.CurrentCell.RowIndex].Cells["Model"].Value = ModeltextBox.Text;

                string size = "";

                if (LowSizenumericUpDown.Value == HightSizenumericUpDown.Value)
                    size = LowSizenumericUpDown.Value.ToString();
                else
                {
                    size = LowSizenumericUpDown.Value.ToString() + "-" + HightSizenumericUpDown.Value.ToString();
                }
                this.NPCTemplatedataGridView.Rows[NPCTemplatedataGridView.CurrentCell.RowIndex].Cells["Size"].Value = size;

                this.NPCTemplatedataGridView.Rows[NPCTemplatedataGridView.CurrentCell.RowIndex].Cells["MaxSpeed"].Value = MaxSpeedtextBox.Text;
                this.NPCTemplatedataGridView.Rows[NPCTemplatedataGridView.CurrentCell.RowIndex].Cells["EquipmentTemplateID"].Value = EquipmentTemplateIDtextBox.Text;

                uint flagsToSet = 0;

                if (GhostcheckBox.Checked == true)
                    flagsToSet ^= 0x01;
                if (StealthcheckBox.Checked == true)
                    flagsToSet ^= 0x02;
                if (DontShowNamecheckBox.Checked == true)
                    flagsToSet ^= 0x04;
                if (CantTargetcheckBox.Checked == true)
                    flagsToSet ^= 0x08;
                if (PeacecheckBox.Checked == true)
                    flagsToSet ^= 0x10;
                if (FlyingcheckBox.Checked == true)
                    flagsToSet ^= 0x20;
                if (TorchcheckBox.Checked == true)
                    flagsToSet ^= 0x40;
                if (StatuecheckBox.Checked == true)
                    flagsToSet ^= 0x80;
                if (SwimmingcheckBox.Checked == true)
                    flagsToSet ^= 0x100;

                this.NPCTemplatedataGridView.Rows[NPCTemplatedataGridView.CurrentCell.RowIndex].Cells["Flags"].Value = flagsToSet;
                this.NPCTemplatedataGridView.Rows[NPCTemplatedataGridView.CurrentCell.RowIndex].Cells["MeleeDamageType"].Value = Util.Find_DamageType_Value(MeleeDamageTypecomboBox.Text);
                this.NPCTemplatedataGridView.Rows[NPCTemplatedataGridView.CurrentCell.RowIndex].Cells["ParryChance"].Value = ParryChanceNumericUpDown.Value;
                this.NPCTemplatedataGridView.Rows[NPCTemplatedataGridView.CurrentCell.RowIndex].Cells["EvadeChance"].Value = EvadeChanceNumericUpDown.Value;
                this.NPCTemplatedataGridView.Rows[NPCTemplatedataGridView.CurrentCell.RowIndex].Cells["BlockChance"].Value = BlockChanceNumericUpDown.Value;
                this.NPCTemplatedataGridView.Rows[NPCTemplatedataGridView.CurrentCell.RowIndex].Cells["LeftHandSwingCount"].Value = LeftHandSwingChanceNumericUpDown.Value;
                this.NPCTemplatedataGridView.Rows[NPCTemplatedataGridView.CurrentCell.RowIndex].Cells["Spells"].Value = SpellsrichTextBox.Text;
                this.NPCTemplatedataGridView.Rows[NPCTemplatedataGridView.CurrentCell.RowIndex].Cells["Styles"].Value = StylesrichTextBox.Text;
                this.NPCTemplatedataGridView.Rows[NPCTemplatedataGridView.CurrentCell.RowIndex].Cells["Strength"].Value = StrengthtextBox.Text;
                this.NPCTemplatedataGridView.Rows[NPCTemplatedataGridView.CurrentCell.RowIndex].Cells["Constitution"].Value = ConstitutiontextBox.Text;
                this.NPCTemplatedataGridView.Rows[NPCTemplatedataGridView.CurrentCell.RowIndex].Cells["Dexterity"].Value = DexteritytextBox.Text;
                this.NPCTemplatedataGridView.Rows[NPCTemplatedataGridView.CurrentCell.RowIndex].Cells["Quickness"].Value = QuicknesstextBox.Text;
                this.NPCTemplatedataGridView.Rows[NPCTemplatedataGridView.CurrentCell.RowIndex].Cells["Intelligence"].Value = IntelligencetextBox.Text;
                this.NPCTemplatedataGridView.Rows[NPCTemplatedataGridView.CurrentCell.RowIndex].Cells["Piety"].Value = PietytextBox.Text;

                this.NPCTemplatedataGridView.Rows[NPCTemplatedataGridView.CurrentCell.RowIndex].Cells["Charisma"].Value = CharismatextBox.Text;
                this.NPCTemplatedataGridView.Rows[NPCTemplatedataGridView.CurrentCell.RowIndex].Cells["Empathy"].Value = EmpathytextBox.Text;
                this.NPCTemplatedataGridView.Rows[NPCTemplatedataGridView.CurrentCell.RowIndex].Cells["Abilities"].Value = AbilitiesrichTextBox.Text;
                this.NPCTemplatedataGridView.Rows[NPCTemplatedataGridView.CurrentCell.RowIndex].Cells["AggroLevel"].Value = AggroLevelUpDown.Text;
                this.NPCTemplatedataGridView.Rows[NPCTemplatedataGridView.CurrentCell.RowIndex].Cells["AggroRange"].Value = AggroRangetextBox.Text;
                this.NPCTemplatedataGridView.Rows[NPCTemplatedataGridView.CurrentCell.RowIndex].Cells["ClassType"].Value = ClassTypecomboBox.Text;

                string level = "";

                if (LowLevelnumericUpDown.Value == HightLevelnumericUpDown.Value)
                    level = LowLevelnumericUpDown.Value.ToString();
                else
                {
                    level = LowLevelnumericUpDown.Value.ToString() + "-" + HightLevelnumericUpDown.Value.ToString();
                }

                this.NPCTemplatedataGridView.Rows[NPCTemplatedataGridView.CurrentCell.RowIndex].Cells["Level"].Value = level;
                this.NPCTemplatedataGridView.Rows[NPCTemplatedataGridView.CurrentCell.RowIndex].Cells["Race"].Value = RacecomboBox.SelectedValue != null && RacecomboBox.SelectedText != "None" ? RacecomboBox.SelectedValue : "0";
                this.NPCTemplatedataGridView.Rows[NPCTemplatedataGridView.CurrentCell.RowIndex].Cells["BodyType"].Value = Util.Find_BodyType_Value(BodyTypecomboBox.Text);
                this.NPCTemplatedataGridView.Rows[NPCTemplatedataGridView.CurrentCell.RowIndex].Cells["MaxDistance"].Value = MaxDistancetextBox.Text;
                this.NPCTemplatedataGridView.Rows[NPCTemplatedataGridView.CurrentCell.RowIndex].Cells["TetherRange"].Value = TetherRangetextBox.Text;
                this.NPCTemplatedataGridView.Rows[NPCTemplatedataGridView.CurrentCell.RowIndex].Cells["PackageID"].Value = PackageIDtextBox.Text;
                this.NPCTemplatedataGridView.Rows[NPCTemplatedataGridView.CurrentCell.RowIndex].Cells["VisibleWeaponSlots"].Value = VisibleWeaponSlotstextBox.Text;
                this.NPCTemplatedataGridView.Rows[NPCTemplatedataGridView.CurrentCell.RowIndex].Cells["ReplaceMobValues"].Value = ReplaceMobValuescomboBox.Text;
                this.NPCTemplatedataGridView.Rows[NPCTemplatedataGridView.CurrentCell.RowIndex].Cells["ItemsListTemplateID"].Value = ItemsListTemplateIDtextBox.Text;

                if (DolEditor.Properties.Settings.Default.OriginsSettings)
                    this.NPCTemplatedataGridView.Rows[NPCTemplatedataGridView.CurrentCell.RowIndex].Cells["IsCharmable"].Value = IsCharmablecomboBox.Text;

                this.NPCTemplatedataGridView.Rows[NPCTemplatedataGridView.CurrentCell.RowIndex].Cells["TranslationId"].Value = TranslationIDtextBox.Text;
                this.NPCTemplatedataGridView.Rows[NPCTemplatedataGridView.CurrentCell.RowIndex].Cells["Suffix"].Value = SuffixtextBox.Text;
                this.NPCTemplatedataGridView.Rows[NPCTemplatedataGridView.CurrentCell.RowIndex].Cells["ExamineArticle"].Value = ExamineArticletextBox.Text;
                this.NPCTemplatedataGridView.Rows[NPCTemplatedataGridView.CurrentCell.RowIndex].Cells["MessageArticle"].Value = MessageArticletextBox.Text;
                
                if (MobsChoiceOpen != null)
                {
                    MobsChoiceOpen.Close();
                    MobsChoiceOpen = null;
                }

                this.Validate();
                this.NPCTemplatebindingSource.EndEdit();

                try
                {
                    NPCTemplatedataAdapter.Update(this.NPCTemplateDatatable);
                }
                catch (MySqlException s)
                {
                    MessageBox.Show(s.Message);
                }

                this.NPCTemplatedataGridView.ReadOnly = true;
                this.Savebutton.Hide();
                this.SaveNewbutton.Hide();
                this.NPCTemplateListingButton.Visible = false;
                this.AddNPCTemplateButton.Visible = true;
                this.ControlMenu.Visible = true;
                this.NPCTemplatedataGridView.Show();
                this.flags = 0X00;
                loaded = false;
            }
        }

        private bool ValidNPCTemplateData()
        {
            if (NametextBox.Text.Length > 47)
                MessageBox.Show("WARNING: name length=" + NametextBox.Text.Length + " but only first 47 chars will be shown.");

            if (DolEditor.Properties.Settings.Default.OriginsSettings && FRNametextBox.Text.Length > 47)
                MessageBox.Show("WARNING: name length=" + FRNametextBox.Text.Length + " but only first 47 chars will be shown.");

            if (GuildNametextBox.Text.Length > 47)
                MessageBox.Show("WARNING: name length=" + GuildNametextBox.Text.Length + " but only first 47 chars will be shown.");

            if (Util.IsEmpty(StrengthtextBox.Text))
                StrengthtextBox.Text = "0";
            else
            {
                int strength;
                try
                {
                    strength = int.Parse(StrengthtextBox.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show(" WARNING: Strength value is not suitable.");
                    return false;
                }
            }

            if (Util.IsEmpty(ConstitutiontextBox.Text))
                ConstitutiontextBox.Text = "0";
            else
            {
                int constitution;
                try
                {
                    constitution = int.Parse(ConstitutiontextBox.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show(" WARNING: Constitution value is not suitable.");
                    return false;
                }
            }

            if (Util.IsEmpty(DexteritytextBox.Text))
                DexteritytextBox.Text = "0";
            else
            {
                int dexterity;
                try
                {
                    dexterity = int.Parse(DexteritytextBox.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show(" WARNING: Dexterity value is not suitable.");
                    return false;
                }
            }

            if (Util.IsEmpty(QuicknesstextBox.Text))
                QuicknesstextBox.Text = "0";
            else
            {
                int quickness;
                try
                {
                    quickness = int.Parse(QuicknesstextBox.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show(" WARNING: Quickness value is not suitable.");
                    return false;
                }
            }

            if (Util.IsEmpty(IntelligencetextBox.Text))
                IntelligencetextBox.Text = "0";
            else
            {
                int intelligence;
                try
                {
                    intelligence = int.Parse(IntelligencetextBox.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show(" WARNING: Intelligence value is not suitable.");
                    return false;
                }
            }

            if (Util.IsEmpty(PietytextBox.Text))
                PietytextBox.Text = "0";
            else
            {
                int piety;
                try
                {
                    piety = int.Parse(PietytextBox.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show(" WARNING: Piety value is not suitable.");
                    return false;
                }
            }

            if (Util.IsEmpty(EmpathytextBox.Text))
                EmpathytextBox.Text = "0";
            else
            {
                int empathy;
                try
                {
                    empathy = int.Parse(EmpathytextBox.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show(" WARNING: Empathy value is not suitable.");
                    return false;
                }
            }

            if (Util.IsEmpty(CharismatextBox.Text))
                CharismatextBox.Text = "0";
            else
            {
                int charisma;
                try
                {
                    charisma = int.Parse(CharismatextBox.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show(" WARNING: Charisma value is not suitable.");
                    return false;
                }
            }

            if (Util.IsEmpty(AggroLevelUpDown.Text))
                AggroLevelUpDown.Text = "-1";
            else
            {
                try
                {
                    byte aggroLevel;
                    aggroLevel = Convert.ToByte(AggroLevelUpDown.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show(" WARNING: AggroLevel value is not suitable.");
                    return false;
                }
            }

            if (Util.IsEmpty(AggroRangetextBox.Text))
                AggroRangetextBox.Text = "0";
            else
            {
                int aggroRange;
                try
                {
                    aggroRange = int.Parse(AggroRangetextBox.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show(" WARNING: AggroRange value is not suitable.");
                    return false;
                }
            }

            byte meleeDamageType;
            try
            {
                meleeDamageType = Convert.ToByte(Util.Find_DamageType_Value(MeleeDamageTypecomboBox.Text));
            }
            catch (Exception)
            {
                MessageBox.Show(" WARNING: MeleeDamageType value is not suitable.");
                return false;
            }

            if (RacecomboBox.SelectedValue == null)
                RacecomboBox.SelectedValue = 0;
            else
            {
                int raceID;
                try
                {
                    raceID = Convert.ToInt32(RacecomboBox.SelectedValue.ToString());
                }
                catch (Exception)
                {
                    MessageBox.Show(" WARNING: Race value is not suitable.");
                    return false;
                }
            }

            int bodyType;
            try
            {
                bodyType = Convert.ToInt32(Util.Find_BodyType_Value(BodyTypecomboBox.Text));
            }
            catch (Exception)
            {
                MessageBox.Show(" WARNING: BodyType value is not suitable.");
                return false;
            }

            if (Util.IsEmpty(MaxDistancetextBox.Text))
                MaxDistancetextBox.Text = "0";
            else
            {
                int maxDistance;
                try
                {
                    maxDistance = Convert.ToInt32(MaxDistancetextBox.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show(" WARNING: MaxDistance value is not suitable.");
                    return false;
                }
            }

            if (Util.IsEmpty(MaxSpeedtextBox.Text))
                MaxSpeedtextBox.Text = "0";
            else
            {
                short maxSpeed;
                try
                {
                    maxSpeed = Convert.ToInt16(MaxSpeedtextBox.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show(" WARNING: MaxSpeed value is not suitable.");
                    return false;
                }
            }

            return true;
        }

        private void NPCTemplatedataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            if (MessageBox.Show("Load this npctemplate in editor?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // user clicked yes
                this.NPCTemplateListingButton.Visible = true;
                this.AddNPCTemplateButton.Visible = true;
                this.ControlMenu.Visible = false;

                this.ControlEditor.Show();
                this.NPCTemplatedataGridView.Hide();

                this.TemplateIDtextBox.Text = this.NPCTemplatedataGridView.Rows[NPCTemplatedataGridView.CurrentCell.RowIndex].Cells["TemplateID"].Value.ToString();
                this.NametextBox.Text = this.NPCTemplatedataGridView.Rows[NPCTemplatedataGridView.CurrentCell.RowIndex].Cells["Name"].Value.ToString();

                if (DolEditor.Properties.Settings.Default.OriginsSettings)
                    this.FRNametextBox.Text = this.NPCTemplatedataGridView.Rows[NPCTemplatedataGridView.CurrentCell.RowIndex].Cells["FRName"].Value.ToString();
                
                this.GuildNametextBox.Text = this.NPCTemplatedataGridView.Rows[NPCTemplatedataGridView.CurrentCell.RowIndex].Cells["GuildName"].Value.ToString();
                this.ModeltextBox.Text = this.NPCTemplatedataGridView.Rows[NPCTemplatedataGridView.CurrentCell.RowIndex].Cells["Model"].Value.ToString();

                byte lowSize = 0;
                if (!Util.IsEmpty(this.NPCTemplatedataGridView.Rows[NPCTemplatedataGridView.CurrentCell.RowIndex].Cells["Size"].Value.ToString()))
                {
                    var split = Util.SplitCSV(this.NPCTemplatedataGridView.Rows[NPCTemplatedataGridView.CurrentCell.RowIndex].Cells["Size"].Value.ToString(), true); ;
                    byte.TryParse(split[0], out lowSize);
                }
                if (lowSize > 0)
                    LowSizenumericUpDown.Text = lowSize.ToString();

                byte hightSize = 0;
                if (!Util.IsEmpty(this.NPCTemplatedataGridView.Rows[NPCTemplatedataGridView.CurrentCell.RowIndex].Cells["Size"].Value.ToString()))
                {
                    var split = Util.SplitCSV(this.NPCTemplatedataGridView.Rows[NPCTemplatedataGridView.CurrentCell.RowIndex].Cells["Size"].Value.ToString(), true); ;
                    byte.TryParse(split[split.Count - 1], out hightSize);
                }
                if (hightSize > 0)
                  HightSizenumericUpDown.Text = hightSize.ToString();

                this.MaxSpeedtextBox.Text = this.NPCTemplatedataGridView.Rows[NPCTemplatedataGridView.CurrentCell.RowIndex].Cells["MaxSpeed"].Value.ToString();
                this.EquipmentTemplateIDtextBox.Text = this.NPCTemplatedataGridView.Rows[NPCTemplatedataGridView.CurrentCell.RowIndex].Cells["EquipmentTemplateID"].Value.ToString();

                this.flags = 0X00;
                if (!Util.IsEmpty(this.NPCTemplatedataGridView.Rows[NPCTemplatedataGridView.CurrentCell.RowIndex].Cells["Flags"].Value.ToString()))
                    this.flags = (Util.eFlags)Convert.ToByte(this.NPCTemplatedataGridView.Rows[NPCTemplatedataGridView.CurrentCell.RowIndex].Cells["Flags"].Value);

                if ((flags & Util.eFlags.CANTTARGET) == Util.eFlags.CANTTARGET)
                    CantTargetcheckBox.Checked = true;
                else
                    CantTargetcheckBox.Checked = false;
                if ((flags & Util.eFlags.DONTSHOWNAME) == Util.eFlags.DONTSHOWNAME)
                    DontShowNamecheckBox.Checked = true;
                else
                    DontShowNamecheckBox.Checked = false;
                if ((flags & Util.eFlags.FLYING) == Util.eFlags.FLYING)
                    FlyingcheckBox.Checked = true;
                else
                    FlyingcheckBox.Checked = false;
                if ((flags & Util.eFlags.GHOST) == Util.eFlags.GHOST)
                    GhostcheckBox.Checked = true;
                else
                    GhostcheckBox.Checked = false;
                if ((flags & Util.eFlags.PEACE) == Util.eFlags.PEACE)
                    PeacecheckBox.Checked = true;
                else
                    PeacecheckBox.Checked = false;
                if ((flags & Util.eFlags.STATUE) == Util.eFlags.STATUE)
                    StatuecheckBox.Checked = true;
                else
                    StatuecheckBox.Checked = false;
                if ((flags & Util.eFlags.STEALTH) == Util.eFlags.STEALTH)
                    StealthcheckBox.Checked = true;
                else
                    StealthcheckBox.Checked = false;
                if ((flags & Util.eFlags.SWIMMING) == Util.eFlags.SWIMMING)
                    SwimmingcheckBox.Checked = true;
                else
                    SwimmingcheckBox.Checked = false;
                if ((flags & Util.eFlags.TORCH) == Util.eFlags.TORCH)
                    TorchcheckBox.Checked = true;
                else
                    TorchcheckBox.Checked = false;

                this.MeleeDamageTypecomboBox.Text = Util.Find_DamageType_String_Value(this.NPCTemplatedataGridView.Rows[NPCTemplatedataGridView.CurrentCell.RowIndex].Cells["MeleeDamageType"].Value.ToString());

                int parryChance = 0;
                int.TryParse(this.NPCTemplatedataGridView.Rows[this.NPCTemplatedataGridView.CurrentCell.RowIndex].Cells["ParryChance"].Value.ToString(), out parryChance);

                int evadeChance = 0;
                int.TryParse(this.NPCTemplatedataGridView.Rows[this.NPCTemplatedataGridView.CurrentCell.RowIndex].Cells["EvadeChance"].Value.ToString(), out evadeChance);

                int blockChance = 0;
                int.TryParse(this.NPCTemplatedataGridView.Rows[this.NPCTemplatedataGridView.CurrentCell.RowIndex].Cells["BlockChance"].Value.ToString(), out blockChance);

                int leftHandSwingChance = 0;
                int.TryParse(this.NPCTemplatedataGridView.Rows[this.NPCTemplatedataGridView.CurrentCell.RowIndex].Cells["LeftHandSwingChance"].Value.ToString(), out leftHandSwingChance);

                this.ParryChanceNumericUpDown.Value = parryChance;
                this.EvadeChanceNumericUpDown.Value = evadeChance;
                this.BlockChanceNumericUpDown.Value = blockChance;
                this.LeftHandSwingChanceNumericUpDown.Value = leftHandSwingChance;
                this.SpellsrichTextBox.Text = this.NPCTemplatedataGridView.Rows[NPCTemplatedataGridView.CurrentCell.RowIndex].Cells["Spells"].Value.ToString();
                this.StylesrichTextBox.Text = this.NPCTemplatedataGridView.Rows[NPCTemplatedataGridView.CurrentCell.RowIndex].Cells["Styles"].Value.ToString();
                this.StrengthtextBox.Text = this.NPCTemplatedataGridView.Rows[NPCTemplatedataGridView.CurrentCell.RowIndex].Cells["Strength"].Value.ToString();
                this.ConstitutiontextBox.Text = this.NPCTemplatedataGridView.Rows[NPCTemplatedataGridView.CurrentCell.RowIndex].Cells["Constitution"].Value.ToString();
                this.DexteritytextBox.Text = this.NPCTemplatedataGridView.Rows[NPCTemplatedataGridView.CurrentCell.RowIndex].Cells["Dexterity"].Value.ToString();
                this.QuicknesstextBox.Text = this.NPCTemplatedataGridView.Rows[NPCTemplatedataGridView.CurrentCell.RowIndex].Cells["Quickness"].Value.ToString();
                this.IntelligencetextBox.Text = this.NPCTemplatedataGridView.Rows[NPCTemplatedataGridView.CurrentCell.RowIndex].Cells["Intelligence"].Value.ToString();
                this.PietytextBox.Text = this.NPCTemplatedataGridView.Rows[NPCTemplatedataGridView.CurrentCell.RowIndex].Cells["Piety"].Value.ToString();
                this.CharismatextBox.Text = this.NPCTemplatedataGridView.Rows[NPCTemplatedataGridView.CurrentCell.RowIndex].Cells["Charisma"].Value.ToString();
                this.EmpathytextBox.Text = this.NPCTemplatedataGridView.Rows[NPCTemplatedataGridView.CurrentCell.RowIndex].Cells["Empathy"].Value.ToString();
                this.AbilitiesrichTextBox.Text = this.NPCTemplatedataGridView.Rows[NPCTemplatedataGridView.CurrentCell.RowIndex].Cells["Abilities"].Value.ToString();
                this.AggroLevelUpDown.Text = this.NPCTemplatedataGridView.Rows[NPCTemplatedataGridView.CurrentCell.RowIndex].Cells["AggroLevel"].Value.ToString();
                this.AggroRangetextBox.Text = this.NPCTemplatedataGridView.Rows[NPCTemplatedataGridView.CurrentCell.RowIndex].Cells["AggroRange"].Value.ToString();
                this.ClassTypecomboBox.Text = this.NPCTemplatedataGridView.Rows[NPCTemplatedataGridView.CurrentCell.RowIndex].Cells["ClassType"].Value.ToString();

                byte lowLevel = 0;
                if (!Util.IsEmpty(this.NPCTemplatedataGridView.Rows[NPCTemplatedataGridView.CurrentCell.RowIndex].Cells["Level"].Value.ToString()))
                {
                    var split = Util.SplitCSV(this.NPCTemplatedataGridView.Rows[NPCTemplatedataGridView.CurrentCell.RowIndex].Cells["Level"].Value.ToString(), true); ;
                    byte.TryParse(split[0], out lowLevel);
                }
                if (lowLevel > 0)
                    LowLevelnumericUpDown.Text = lowLevel.ToString();

                byte hightLevel = 0;
                if (!Util.IsEmpty(this.NPCTemplatedataGridView.Rows[NPCTemplatedataGridView.CurrentCell.RowIndex].Cells["Level"].Value.ToString()))
                {
                    var split = Util.SplitCSV(this.NPCTemplatedataGridView.Rows[NPCTemplatedataGridView.CurrentCell.RowIndex].Cells["Level"].Value.ToString(), true); ;
                    byte.TryParse(split[split.Count - 1], out hightLevel);
                }
                if (hightLevel > 0)
                    HightLevelnumericUpDown.Text = hightLevel.ToString();

                if (!Util.IsEmpty(this.NPCTemplatedataGridView.Rows[NPCTemplatedataGridView.CurrentCell.RowIndex].Cells["Race"].Value.ToString()))
                    this.RacecomboBox.SelectedValue = this.NPCTemplatedataGridView.Rows[NPCTemplatedataGridView.CurrentCell.RowIndex].Cells["Race"].Value.ToString();
                else
                    this.RacecomboBox.SelectedText = "None";

                this.BodyTypecomboBox.Text = Util.Find_BodyType_String_Value(this.NPCTemplatedataGridView.Rows[NPCTemplatedataGridView.CurrentCell.RowIndex].Cells["BodyType"].Value.ToString());
                this.MaxDistancetextBox.Text = this.NPCTemplatedataGridView.Rows[NPCTemplatedataGridView.CurrentCell.RowIndex].Cells["MaxDistance"].Value.ToString();
                this.TetherRangetextBox.Text = this.NPCTemplatedataGridView.Rows[NPCTemplatedataGridView.CurrentCell.RowIndex].Cells["TetherRange"].Value.ToString();
                this.PackageIDtextBox.Text = this.NPCTemplatedataGridView.Rows[NPCTemplatedataGridView.CurrentCell.RowIndex].Cells["PackageID"].Value.ToString();
                this.VisibleWeaponSlotstextBox.Text = this.NPCTemplatedataGridView.Rows[NPCTemplatedataGridView.CurrentCell.RowIndex].Cells["VisibleWeaponSlots"].Value.ToString();
                this.ReplaceMobValuescomboBox.Text = this.NPCTemplatedataGridView.Rows[NPCTemplatedataGridView.CurrentCell.RowIndex].Cells["ReplaceMobValues"].Value.ToString();
                this.ItemsListTemplateIDtextBox.Text = this.NPCTemplatedataGridView.Rows[NPCTemplatedataGridView.CurrentCell.RowIndex].Cells["ItemsListTemplateID"].Value.ToString();

                if (DolEditor.Properties.Settings.Default.OriginsSettings)
                    this.IsCharmablecomboBox.Text = this.NPCTemplatedataGridView.Rows[NPCTemplatedataGridView.CurrentCell.RowIndex].Cells["IsCharmable"].Value.ToString();

                this.TranslationIDtextBox.Text = this.NPCTemplatedataGridView.Rows[NPCTemplatedataGridView.CurrentCell.RowIndex].Cells["TranslationId"].Value.ToString();
                this.SuffixtextBox.Text = this.NPCTemplatedataGridView.Rows[NPCTemplatedataGridView.CurrentCell.RowIndex].Cells["Suffix"].Value.ToString();
                this.ExamineArticletextBox.Text = this.NPCTemplatedataGridView.Rows[NPCTemplatedataGridView.CurrentCell.RowIndex].Cells["ExamineArticle"].Value.ToString();
                this.MessageArticletextBox.Text = this.NPCTemplatedataGridView.Rows[NPCTemplatedataGridView.CurrentCell.RowIndex].Cells["MessageArticle"].Value.ToString();

                loaded = true;

                this.SaveNewbutton.Hide();
                this.Savebutton.Show();
            }
        }

        private void VisibleWeaponSlots_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            if (checkBox1.Checked == true && checkBox1.Name != cb.Name)
            {
                checkBox1.Checked = false;
            }
            if (checkBox2.Checked == true && checkBox2.Name != cb.Name)
            {
                checkBox2.Checked = false;
            }
            if (checkBox3.Checked == true && checkBox3.Name != cb.Name)
            {
                checkBox3.Checked = false;
            }
            if (checkBox4.Checked == true && checkBox4.Name != cb.Name)
            {
                checkBox4.Checked = false;
            }
            if (checkBox5.Checked == true && checkBox5.Name != cb.Name)
            {
                checkBox5.Checked = false;
            }
            if (checkBox6.Checked == true && checkBox6.Name != cb.Name)
            {
                checkBox6.Checked = false;
            }
            if (checkBox7.Checked == true && checkBox7.Name != cb.Name)
            {
                checkBox7.Checked = false;
            }
        }

        private void TranslationID_TextChanged(object sender, EventArgs e)
        {
            GetNPCTemplateTranslationItemData("select * from languagenpc where translationid='" + TranslationIDtextBox.Text + "'");
        }

        private void TranslationdataGridViewbindingNavigatorDeleteItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete this languagenpc?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Validate();
                this.TranslationbindingSource.EndEdit();

                try
                {
                    this.NPCTemplateTranslationdataAdapter.Update(TranslationDatatable);
                }
                catch (MySqlException s)
                {
                    MessageBox.Show(s.Message);
                }
            }

            GetNPCTemplateTranslationItemData("select * from languagenpc where translationid='" + TranslationIDtextBox.Text + "'");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ModeltextBox.Text == null)
                ModeltextBox.Text = "";

            if (MobsChoiceOpen != null)
            {
                MobsChoiceOpen.StartPosition = FormStartPosition.CenterScreen;
                MobsChoiceOpen.TopMost = true;
                MobsChoiceOpen.Show();
            }
            else
            {

                MobsModelChoice fm = new MobsModelChoice(this, ModeltextBox);
                MobsChoiceOpen = fm;
                fm.TopMost = true;
                fm.Show();
            }
        }

        private void TranslationdataGridView__CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            this.Validate();
            this.TranslationbindingSource.EndEdit();

            try
            {
                this.NPCTemplateTranslationdataAdapter.Update(TranslationDatatable);
            }
            catch (MySqlException s)
            {
                MessageBox.Show(s.Message);
            }
        }

        private void LowSizenumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown nud = (NumericUpDown)sender;
            if (loaded && nud.Value > HightSizenumericUpDown.Value)
            {
                MessageBox.Show("Minimum Size can't be superior to Maximum Size");
                nud.Value = HightSizenumericUpDown.Value;
            }
        }

        private void HightSizenumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown nud = (NumericUpDown)sender;
            if (loaded && nud.Value < LowSizenumericUpDown.Value)
            {
                MessageBox.Show("Maximum Size can't be inferior to Minimum Size");
                nud.Value = LowSizenumericUpDown.Value;
            }
        }

        private void LowLevelnumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown nud = (NumericUpDown)sender;
            if (loaded && nud.Value > HightLevelnumericUpDown.Value)
            {
                MessageBox.Show("Minimum Level can't be superior to Maximum Level");
                nud.Value = HightLevelnumericUpDown.Value;
            }
        }

        private void HightLevelnumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown nud = (NumericUpDown)sender;
            if (loaded && nud.Value < LowLevelnumericUpDown.Value)
            {
                MessageBox.Show("Maximum Level can't be inferior to Minimum Level");
                nud.Value = LowLevelnumericUpDown.Value;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string select = "SELECT * FROM npctemplate";
            bool add = false; ;
            if (this.SearchNPCTemplateIDtextBox.Text != "")
            {
                select += " where Templateid='" + this.SearchNPCTemplateIDtextBox.Text + "'";
                add = true;
            }

            if (this.SearchByNPCTemplateNametextBox.Text != "")
            {
                if (add)
                    select += " and Name like '%" + this.SearchByNPCTemplateNametextBox.Text + "%'";
                else
                {
                    select += " where Name like '%" + this.SearchByNPCTemplateNametextBox.Text + "%'";
                    add = true;
                }
            }
            string PackageID = " All";
            if (this.PackageIDSearchcomboBox.Text != null)
                PackageID = this.PackageIDSearchcomboBox.Text.ToString(); //PackageID

            if (PackageID != " All")
            {
                if (add)
                    select += " and packageid='" + PackageID + "'";
                else
                {
                    select += " where packageid='" + PackageID + "'";
                    add = true;
                }
            }
            string ClassType = " All";
            if (this.ClassTypeSearchcomboBox.Text != null)
                ClassType = this.ClassTypeSearchcomboBox.Text.ToString(); //ClassType

            if (ClassType != " All")
            {
                if (add)
                    select += " and classtype='" + ClassType + "'";
                else
                {
                    select += " where classtype='" + ClassType + "'";
                    add = true;
                }
            }

            GetNPCTemplateItemData(select);
        }
    }
}
