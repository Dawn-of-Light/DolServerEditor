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
    public partial class LoadMob : Form
    {
        private MySqlDataAdapter MobTranslationdataAdapter = new MySqlDataAdapter();
        private MySqlDataAdapter MobdataAdapter = new MySqlDataAdapter();
        private MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder();
        private DataTable RaceDatatable = new DataTable();
        private DataTable TranslationDatatable = new DataTable();
        private DataTable NPCTemplateDatatable = new DataTable();
        private MainPageEditor mainpage = null;
        public MobsModelChoice MobsChoiceOpen = null;

        public LoadMob(MainPageEditor form)
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
            this.MobListingButton.Visible = false;
            this.Savebutton.Hide();
            this.SaveNewbutton.Hide();
            this.MobdataGridView.AutoGenerateColumns = true;
            this.MobdataGridView.AllowUserToDeleteRows = true;
            this.IsCharmablecomboBox.SelectedIndex = 0;

            GetFactionComboBoxValue("select * from faction ORDER BY name ASC");
            GetNPCTemplateComboBoxValue("select * from npctemplate ORDER BY name ASC");

            this.flags = 0X00;

            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(this.StrengthtextBox, "0 Strength Means SetAutoStats.");
            toolTip1.SetToolTip(this.AggroLevelUpDown, "0 -> 25 Amical | 26 -> 50 Neutral | 51 -> 75 Hostile | 76 -> 100 Agressive");
            toolTip1.SetToolTip(this.TranslationIDtextBox, "Change this value automatically update the translation block.");

            this.GetMobItemData("select * from mob");

            this.MobdataGridView.Columns["Mob_ID"].Visible = false;

            this.MobdataGridView.DataSource = this.MobbindingSource;

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

                MySqlDataAdapter ClassTypeSearchdataAdapter = new MySqlDataAdapter("select distinct classtype from mob ORDER BY classtype ASC", Util.Connection);
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

                MySqlDataAdapter BraindataAdapter = new MySqlDataAdapter("select distinct brain from mob ORDER BY brain ASC", Util.Connection);
                MySqlCommandBuilder commandBuilderBrainSearch = new MySqlCommandBuilder(BraindataAdapter);
                DataTable BrainDatatable = new DataTable();
                BraindataAdapter.Fill(BrainDatatable);
                this.BraincomboBox.DataSource = BrainDatatable;
                this.BraincomboBox.DisplayMember = "Brain";

                MySqlDataAdapter PackageIDSearchdataAdapter = new MySqlDataAdapter("select distinct packageid from mob ORDER BY packageid ASC", Util.Connection);
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

        private void GetMobItemData(string selectCommand)
        {
            try
            {
                // Create a new data adapter based on the specified query.
                this.MobdataAdapter = new MySqlDataAdapter(selectCommand, Util.Connection);
                // Create a command builder to generate SQL update, insert, and 
                // delete commands based on selectCommand. These are used to 
                // update the database.
                commandBuilder = new MySqlCommandBuilder(this.MobdataAdapter);
                this.MobDatatable.Clear();
                // Populate a new data table and bind it to the BindingSource.
                this.MobDatatable.Locale = System.Globalization.CultureInfo.InvariantCulture;
                this.MobdataAdapter.Fill(this.MobDatatable);
                this.MobbindingSource.DataSource = this.MobDatatable;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
        }

        private void GetMobTranslationItemData(string selectCommand)
        {
            try
            {
                // Create a new data adapter based on the specified query.
                MobTranslationdataAdapter = new MySqlDataAdapter(selectCommand, Util.Connection);
                // Create a command builder to generate SQL update, insert, and 
                // delete commands based on selectCommand. These are used to 
                // update the database.
                MySqlCommandBuilder commandBuilderTranslation = new MySqlCommandBuilder(MobTranslationdataAdapter);
                this.TranslationDatatable.Clear();
                // Populate a new data table and bind it to the BindingSource.
                this.TranslationDatatable.Locale = System.Globalization.CultureInfo.InvariantCulture;
                MobTranslationdataAdapter.Fill(TranslationDatatable);
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
            if (MessageBox.Show("Delete this mob?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Validate();
                this.MobbindingSource.EndEdit();
                this.MobdataAdapter.Update(this.MobDatatable);
            }

            string select = "SELECT * FROM mob";
            bool add = false; ;
            if (this.SearchByNPCTemplateNametextBox.Text != "")
            {
                select += " where Name like '%" + this.SearchByNPCTemplateNametextBox.Text + "%'";
                add = true;
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

            GetMobItemData(select);
        }

        private void AddNewNPCTemplate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Become to add a new mob?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // user clicked yes
                this.MobdataGridView.Hide();

                long i = 1;
                foreach (byte b in Guid.NewGuid().ToByteArray())
                {
                    i *= ((int)b + 1);
                }
                i -= DateTime.Now.Ticks;
                string str = "Dol_Server_Editor_" + i.ToString();
                // TODOthis.TemplateIDtextBox.Text = Util.Find_Free_NPCTemplateID().ToString();

                this.ControlEditor.Show();
                this.Savebutton.Hide();
                this.SaveNewbutton.Show();
                this.MobListingButton.Visible = true;
                this.AddMobButton.Visible = false;
                this.ControlMenu.Visible = false;
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
            this.MobListingButton.Visible = false;
            this.AddMobButton.Visible = true;
            this.ControlMenu.Visible = true;
            this.ControlEditor.Hide();
            this.MobdataGridView.Show();
        }

        private void SaveNewbutton_Click(object sender, EventArgs e)
        {
            if (!ValidMobData())
                return;

            if (MessageBox.Show("Save this new mob?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                try
                {

                        long i = 1;
                        foreach (byte b in Guid.NewGuid().ToByteArray())
                        {
                            i *= ((int)b + 1);
                        }
                        i -= DateTime.Now.Ticks;
                        string str = "Dol_Server_Editor_" + i.ToString();

                        DataRow datarow = this.MobDatatable.NewRow();

                        datarow["Mob_ID"] = str;
                        datarow["ClassType"] = ClassTypecomboBox.Text;
                        datarow["Name"] = NametextBox.Text;

                        if (DolEditor.Properties.Settings.Default.OriginsSettings)
                            datarow["FRName"] = FRNametextBox.Text;

                        datarow["Guild"] = GuildtextBox.Text;
                        datarow["X"] = XtextBox.Text;
                        datarow["Y"] = YtextBox.Text;
                        datarow["Z"] = ZtextBox.Text;
                        datarow["Speed"] = SpeedtextBox.Text;
                        datarow["Heading"] = HeadingtextBox.Text;
                        datarow["Region"] = RegiontextBox.Text;
                        datarow["Model"] = ModeltextBox.Text;
                        datarow["Size"] = SizenumericUpDown.Value;
                        datarow["Level"] =  LevelnumericUpDown.Value;
                        datarow["Realm"] = Util.Find_Realm_Value(RealmcomboBox.Text);
                        datarow["EquipmentTemplateID"] = EquipmentTemplateIDtextBox.Text;
                        datarow["ItemsListTemplateID"] = ItemsListTemplateIDtextBox.Text;

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
                        datarow["AggroLevel"] = AggroLevelUpDown.Text;
                        datarow["AggroRange"] = AggroRangeNumericUpDown.Text;
                        datarow["MeleeDamageType"] = Util.Find_DamageType_Value(MeleeDamageTypecomboBox.Text);
                        datarow["RespawnInterval"] = RespawnIntervalnumericUpDown.Value;
                        datarow["FactionID"] = FactioncomboBox.SelectedValue;
                        datarow["NPCTemplateID"] = NPCTemplatecomboBox.SelectedValue;
                        datarow["Race"] = RacecomboBox.SelectedValue != null && RacecomboBox.SelectedText != "None" ? RacecomboBox.SelectedValue : "0";
                        datarow["BodyType"] = Util.Find_BodyType_Value(BodyTypecomboBox.Text);
                        datarow["HouseNumber"] = HouseNumbertextBox.Text;
                        datarow["Brain"] = BraincomboBox.Text;

                        datarow["MaxDistance"] = MaxDistancetextBox.Text;
                        datarow["OwnerID"] = OwnerIDtextBox.Text;
                        datarow["Strength"] = StrengthtextBox.Text;
                        datarow["Constitution"] = ConstitutiontextBox.Text;
                        datarow["Dexterity"] = DexteritytextBox.Text;
                        datarow["Quickness"] = QuicknesstextBox.Text;
                        datarow["Intelligence"] = IntelligencetextBox.Text;
                        datarow["Piety"] = PietytextBox.Text;
                        datarow["Charisma"] = CharismatextBox.Text;
                        datarow["Empathy"] = EmpathytextBox.Text;
                        datarow["PackageID"] = PackageIDtextBox.Text;
                        datarow["RoamingRange"] = RoamingnumericUpDown.Value;
                        datarow["IsCloakHoodUp"] = Util.Find_Bool_Value(IsCloakHoodUpcomboBox.Text);
                        datarow["Gender"] = GendercomboBox.SelectedIndex;
                        datarow["VisibleWeaponSlots"] = VisibleWeaponSlotstextBox.Text;

                        if (DolEditor.Properties.Settings.Default.OriginsSettings)
                            datarow["IsCharmable"] = Util.Find_Bool_Value(IsCharmablecomboBox.Text);

                        datarow["TranslationId"] = TranslationIDtextBox.Text;
                        datarow["Suffix"] = SuffixtextBox.Text;
                        datarow["ExamineArticle"] = ExamineArticletextBox.Text;
                        datarow["MessageArticle"] = MessageArticletextBox.Text;

                        this.MobDatatable.Rows.Add(datarow);

                        if (MobsChoiceOpen != null)
                        {
                            MobsChoiceOpen.Close();
                            MobsChoiceOpen = null;
                        }

                        this.Validate();
                        this.MobbindingSource.EndEdit();

                        try
                        {
                            MobdataAdapter.Update(this.MobDatatable);
                        }
                        catch (Exception s)
                        {
                            MessageBox.Show(s.Message);
                        }

                        this.ControlEditor.Hide();
                        this.MobdataGridView.Show();
                        this.ControlMenu.Visible = true;
                        this.AddMobButton.Visible = true;
                        this.MobListingButton.Visible = false;
                        this.SaveNewbutton.Hide();
                        this.flags = 0X00;
                }
                catch (MySqlException s)
                {
                    MessageBox.Show(s.Message);
                }
            }
        }

        private void SaveLoadedNPCTemplate_Click(object sender, EventArgs e)
        {
            if (!ValidMobData())
                return;

            if (MessageBox.Show("Save your modifications?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                this.MobdataGridView.ReadOnly = false;
                this.MobdataGridView.Rows[MobdataGridView.CurrentCell.RowIndex].Cells["ClassType"].Value = ClassTypecomboBox.Text;
                this.MobdataGridView.Rows[MobdataGridView.CurrentCell.RowIndex].Cells["Name"].Value = NametextBox.Text;

                if (DolEditor.Properties.Settings.Default.OriginsSettings)
                    this.MobdataGridView.Rows[MobdataGridView.CurrentCell.RowIndex].Cells["FRName"].Value = NametextBox.Text;
               
                this.MobdataGridView.Rows[MobdataGridView.CurrentCell.RowIndex].Cells["Guild"].Value = GuildtextBox.Text;
                this.MobdataGridView.Rows[MobdataGridView.CurrentCell.RowIndex].Cells["X"].Value = XtextBox.Text;
                this.MobdataGridView.Rows[MobdataGridView.CurrentCell.RowIndex].Cells["Y"].Value = YtextBox.Text;
                this.MobdataGridView.Rows[MobdataGridView.CurrentCell.RowIndex].Cells["Z"].Value = ZtextBox.Text;
                this.MobdataGridView.Rows[MobdataGridView.CurrentCell.RowIndex].Cells["Speed"].Value = SpeedtextBox.Text;
                this.MobdataGridView.Rows[MobdataGridView.CurrentCell.RowIndex].Cells["Heading"].Value = HeadingtextBox.Text;
                this.MobdataGridView.Rows[MobdataGridView.CurrentCell.RowIndex].Cells["Region"].Value = RegiontextBox.Text;

                this.MobdataGridView.Rows[MobdataGridView.CurrentCell.RowIndex].Cells["Model"].Value = ModeltextBox.Text;
                this.MobdataGridView.Rows[MobdataGridView.CurrentCell.RowIndex].Cells["Size"].Value = SizenumericUpDown.Value;

                this.MobdataGridView.Rows[MobdataGridView.CurrentCell.RowIndex].Cells["Level"].Value = LevelnumericUpDown.Value;

                this.MobdataGridView.Rows[MobdataGridView.CurrentCell.RowIndex].Cells["Realm"].Value = Util.Find_Realm_Value(RealmcomboBox.Text);
                this.MobdataGridView.Rows[MobdataGridView.CurrentCell.RowIndex].Cells["EquipmentTemplateID"].Value = EquipmentTemplateIDtextBox.Text;
                this.MobdataGridView.Rows[MobdataGridView.CurrentCell.RowIndex].Cells["ItemsListTemplateID"].Value = ItemsListTemplateIDtextBox.Text;


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

                this.MobdataGridView.Rows[MobdataGridView.CurrentCell.RowIndex].Cells["Flags"].Value = flagsToSet;
                this.MobdataGridView.Rows[MobdataGridView.CurrentCell.RowIndex].Cells["AggroLevel"].Value = AggroLevelUpDown.Text;
                this.MobdataGridView.Rows[MobdataGridView.CurrentCell.RowIndex].Cells["AggroRange"].Value = AggroRangeNumericUpDown.Text;
                this.MobdataGridView.Rows[MobdataGridView.CurrentCell.RowIndex].Cells["MeleeDamageType"].Value = Util.Find_DamageType_Value(MeleeDamageTypecomboBox.Text);

                this.MobdataGridView.Rows[MobdataGridView.CurrentCell.RowIndex].Cells["RespawnInterval"].Value = RespawnIntervalnumericUpDown.Value;
                this.MobdataGridView.Rows[MobdataGridView.CurrentCell.RowIndex].Cells["FactionID"].Value = FactioncomboBox.SelectedValue;
                this.MobdataGridView.Rows[MobdataGridView.CurrentCell.RowIndex].Cells["NPCTemplateID"].Value = NPCTemplatecomboBox.SelectedValue;
                this.MobdataGridView.Rows[MobdataGridView.CurrentCell.RowIndex].Cells["Race"].Value = RacecomboBox.SelectedValue != null && RacecomboBox.SelectedText != "None" ? RacecomboBox.SelectedValue : "0";
                this.MobdataGridView.Rows[MobdataGridView.CurrentCell.RowIndex].Cells["BodyType"].Value = Util.Find_BodyType_Value(BodyTypecomboBox.Text);
                this.MobdataGridView.Rows[MobdataGridView.CurrentCell.RowIndex].Cells["HouseNumber"].Value = HouseNumbertextBox.Text;
                this.MobdataGridView.Rows[MobdataGridView.CurrentCell.RowIndex].Cells["Brain"].Value = BraincomboBox.Text;
                this.MobdataGridView.Rows[MobdataGridView.CurrentCell.RowIndex].Cells["PathID"].Value = PathIDtextBox.Text;
                this.MobdataGridView.Rows[MobdataGridView.CurrentCell.RowIndex].Cells["MaxDistance"].Value = MaxDistancetextBox.Text;
                this.MobdataGridView.Rows[MobdataGridView.CurrentCell.RowIndex].Cells["OwnerID"].Value = OwnerIDtextBox.Text;
                this.MobdataGridView.Rows[MobdataGridView.CurrentCell.RowIndex].Cells["Strength"].Value = StrengthtextBox.Text;
                this.MobdataGridView.Rows[MobdataGridView.CurrentCell.RowIndex].Cells["Constitution"].Value = ConstitutiontextBox.Text;
                this.MobdataGridView.Rows[MobdataGridView.CurrentCell.RowIndex].Cells["Dexterity"].Value = DexteritytextBox.Text;
                this.MobdataGridView.Rows[MobdataGridView.CurrentCell.RowIndex].Cells["Quickness"].Value = QuicknesstextBox.Text;
                this.MobdataGridView.Rows[MobdataGridView.CurrentCell.RowIndex].Cells["Intelligence"].Value = IntelligencetextBox.Text;
                this.MobdataGridView.Rows[MobdataGridView.CurrentCell.RowIndex].Cells["Piety"].Value = PietytextBox.Text;
                this.MobdataGridView.Rows[MobdataGridView.CurrentCell.RowIndex].Cells["Charisma"].Value = CharismatextBox.Text;
                this.MobdataGridView.Rows[MobdataGridView.CurrentCell.RowIndex].Cells["Empathy"].Value = EmpathytextBox.Text;
                this.MobdataGridView.Rows[MobdataGridView.CurrentCell.RowIndex].Cells["PackageID"].Value = PackageIDtextBox.Text;
                this.MobdataGridView.Rows[MobdataGridView.CurrentCell.RowIndex].Cells["RoamingRange"].Value = RoamingnumericUpDown.Value;
                this.MobdataGridView.Rows[MobdataGridView.CurrentCell.RowIndex].Cells["IsCloakHoodUp"].Value = Util.Find_Bool_Value(IsCloakHoodUpcomboBox.Text);
                this.MobdataGridView.Rows[MobdataGridView.CurrentCell.RowIndex].Cells["Gender"].Value = GendercomboBox.SelectedIndex;
                this.MobdataGridView.Rows[MobdataGridView.CurrentCell.RowIndex].Cells["VisibleWeaponSlots"].Value = VisibleWeaponSlotstextBox.Text;

                if (DolEditor.Properties.Settings.Default.OriginsSettings)
                    this.MobdataGridView.Rows[MobdataGridView.CurrentCell.RowIndex].Cells["IsCharmable"].Value = Util.Find_Bool_Value(IsCharmablecomboBox.Text);

                this.MobdataGridView.Rows[MobdataGridView.CurrentCell.RowIndex].Cells["TranslationId"].Value = TranslationIDtextBox.Text;
                this.MobdataGridView.Rows[MobdataGridView.CurrentCell.RowIndex].Cells["Suffix"].Value = SuffixtextBox.Text;
                this.MobdataGridView.Rows[MobdataGridView.CurrentCell.RowIndex].Cells["ExamineArticle"].Value = ExamineArticletextBox.Text;
                this.MobdataGridView.Rows[MobdataGridView.CurrentCell.RowIndex].Cells["MessageArticle"].Value = MessageArticletextBox.Text;

                if (MobsChoiceOpen != null)
                {
                    MobsChoiceOpen.Close();
                    MobsChoiceOpen = null;
                }

                this.Validate();
                this.MobbindingSource.EndEdit();

                try
                {
                    MobdataAdapter.Update(this.MobDatatable);
                }
                catch (MySqlException s)
                {
                    MessageBox.Show(s.Message);
                }

                this.MobdataGridView.ReadOnly = true;
                this.Savebutton.Hide();
                this.SaveNewbutton.Hide();
                this.MobListingButton.Visible = false;
                this.AddMobButton.Visible = true;
                this.ControlMenu.Visible = true;
                this.MobdataGridView.Show();
                this.flags = 0X00;
            }
        }

        private bool ValidMobData()
        {

            if (NametextBox.Text.Length > 47)
                MessageBox.Show("WARNING: name length=" + NametextBox.Text.Length + " but only first 47 chars will be shown.");

            if (DolEditor.Properties.Settings.Default.OriginsSettings && FRNametextBox.Text.Length > 47)
                MessageBox.Show("WARNING: name length=" + FRNametextBox.Text.Length + " but only first 47 chars will be shown.");

            if (GuildtextBox.Text.Length > 47)
                MessageBox.Show("WARNING: name length=" + GuildtextBox.Text.Length + " but only first 47 chars will be shown.");

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

            if (Util.IsEmpty(AggroRangeNumericUpDown.Text))
                AggroRangeNumericUpDown.Text = "0";
            else
            {
                int aggroRange;
                try
                {
                    aggroRange = int.Parse(AggroRangeNumericUpDown.Text);
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

            if (Util.IsEmpty(SpeedtextBox.Text))
                SpeedtextBox.Text = "0";
            else
            {
                short maxSpeed;
                try
                {
                    maxSpeed = Convert.ToInt16(SpeedtextBox.Text);
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
                this.MobListingButton.Visible = true;
                this.AddMobButton.Visible = true;
                this.ControlMenu.Visible = false;

                this.ControlEditor.Show();
                this.MobdataGridView.Hide();

                this.ClassTypecomboBox.Text = this.MobdataGridView.Rows[MobdataGridView.CurrentCell.RowIndex].Cells["ClassType"].Value.ToString();

                this.NametextBox.Text = this.MobdataGridView.Rows[MobdataGridView.CurrentCell.RowIndex].Cells["Name"].Value.ToString();
                this.FRNametextBox.Text = this.MobdataGridView.Rows[MobdataGridView.CurrentCell.RowIndex].Cells["FRName"].Value.ToString();

                if (DolEditor.Properties.Settings.Default.OriginsSettings)
                    this.FRNametextBox.Text = this.MobdataGridView.Rows[MobdataGridView.CurrentCell.RowIndex].Cells["FRName"].Value.ToString();

                this.GuildtextBox.Text = this.MobdataGridView.Rows[MobdataGridView.CurrentCell.RowIndex].Cells["Guild"].Value.ToString();
                this.ModeltextBox.Text = this.MobdataGridView.Rows[MobdataGridView.CurrentCell.RowIndex].Cells["Model"].Value.ToString();
                this.XtextBox.Text = this.MobdataGridView.Rows[MobdataGridView.CurrentCell.RowIndex].Cells["X"].Value.ToString();
                this.YtextBox.Text = this.MobdataGridView.Rows[MobdataGridView.CurrentCell.RowIndex].Cells["Y"].Value.ToString();
                this.ZtextBox.Text = this.MobdataGridView.Rows[MobdataGridView.CurrentCell.RowIndex].Cells["Z"].Value.ToString();
                this.SpeedtextBox.Text = this.MobdataGridView.Rows[MobdataGridView.CurrentCell.RowIndex].Cells["Speed"].Value.ToString();
                this.HeadingtextBox.Text = this.MobdataGridView.Rows[MobdataGridView.CurrentCell.RowIndex].Cells["Heading"].Value.ToString();
                this.RegiontextBox.Text = this.MobdataGridView.Rows[MobdataGridView.CurrentCell.RowIndex].Cells["Region"].Value.ToString();
                this.ModeltextBox.Text = this.MobdataGridView.Rows[MobdataGridView.CurrentCell.RowIndex].Cells["Model"].Value.ToString();
                
                int size = 0;
                int.TryParse(this.MobdataGridView.Rows[MobdataGridView.CurrentCell.RowIndex].Cells["Size"].Value.ToString(), out size);
                this.SizenumericUpDown.Value = size;
                
                int level = 0;
                int.TryParse(this.MobdataGridView.Rows[MobdataGridView.CurrentCell.RowIndex].Cells["Level"].Value.ToString(), out level);

                this.LevelnumericUpDown.Value = level;

                if (!Util.IsEmpty(this.MobdataGridView.Rows[MobdataGridView.CurrentCell.RowIndex].Cells["Realm"].Value.ToString()))
                    this.RealmcomboBox.Text = Util.Find_Realm_String_Value(this.MobdataGridView.Rows[MobdataGridView.CurrentCell.RowIndex].Cells["Realm"].Value.ToString());
                else
                    this.RealmcomboBox.Text = "None";

                 this.EquipmentTemplateIDtextBox.Text = this.MobdataGridView.Rows[MobdataGridView.CurrentCell.RowIndex].Cells["EquipmentTemplateID"].Value.ToString();
                 this.ItemsListTemplateIDtextBox.Text = this.MobdataGridView.Rows[MobdataGridView.CurrentCell.RowIndex].Cells["ItemsListTemplateID"].Value.ToString();

                this.flags = 0X00;
                if (!Util.IsEmpty(this.MobdataGridView.Rows[MobdataGridView.CurrentCell.RowIndex].Cells["Flags"].Value.ToString()))
                    this.flags = (Util.eFlags)Convert.ToByte(this.MobdataGridView.Rows[MobdataGridView.CurrentCell.RowIndex].Cells["Flags"].Value);

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

                this.AggroLevelUpDown.Text = this.MobdataGridView.Rows[MobdataGridView.CurrentCell.RowIndex].Cells["AggroLevel"].Value.ToString();
                this.AggroRangeNumericUpDown.Text = this.MobdataGridView.Rows[MobdataGridView.CurrentCell.RowIndex].Cells["AggroRange"].Value.ToString();
                this.MeleeDamageTypecomboBox.Text = Util.Find_DamageType_String_Value(this.MobdataGridView.Rows[MobdataGridView.CurrentCell.RowIndex].Cells["MeleeDamageType"].Value.ToString());
                
                int respawninterval = 0;
                int.TryParse(this.MobdataGridView.Rows[MobdataGridView.CurrentCell.RowIndex].Cells["RespawnInterval"].Value.ToString(), out respawninterval);
                this.RespawnIntervalnumericUpDown.Value = respawninterval;

                this.FactioncomboBox.SelectedValue = this.MobdataGridView.Rows[MobdataGridView.CurrentCell.RowIndex].Cells["FactionID"].Value.ToString();
                this.NPCTemplatecomboBox.SelectedValue = this.MobdataGridView.Rows[MobdataGridView.CurrentCell.RowIndex].Cells["NPCTemplateID"].Value.ToString();

                if (!Util.IsEmpty(this.MobdataGridView.Rows[MobdataGridView.CurrentCell.RowIndex].Cells["Race"].Value.ToString()))
                    this.RacecomboBox.SelectedValue = this.MobdataGridView.Rows[MobdataGridView.CurrentCell.RowIndex].Cells["Race"].Value.ToString();
                else
                    this.RacecomboBox.Text = "None";

                this.BodyTypecomboBox.Text = Util.Find_BodyType_String_Value(this.MobdataGridView.Rows[MobdataGridView.CurrentCell.RowIndex].Cells["BodyType"].Value.ToString());

                this.HouseNumbertextBox.Text = this.MobdataGridView.Rows[MobdataGridView.CurrentCell.RowIndex].Cells["HouseNumber"].Value.ToString();

                if (Util.IsEmpty(this.MobdataGridView.Rows[MobdataGridView.CurrentCell.RowIndex].Cells["Brain"].Value.ToString()))
                    this.BraincomboBox.SelectedText = "DOL.AI.StandardMobBrain";
                else
                    this.BraincomboBox.SelectedText = this.MobdataGridView.Rows[MobdataGridView.CurrentCell.RowIndex].Cells["Brain"].Value.ToString();

                this.PathIDtextBox.Text = this.MobdataGridView.Rows[MobdataGridView.CurrentCell.RowIndex].Cells["PathID"].Value.ToString();
                this.MaxDistancetextBox.Text = this.MobdataGridView.Rows[MobdataGridView.CurrentCell.RowIndex].Cells["MaxDistance"].Value.ToString();
                this.OwnerIDtextBox.Text = this.MobdataGridView.Rows[MobdataGridView.CurrentCell.RowIndex].Cells["OwnerID"].Value.ToString();
                
                this.StrengthtextBox.Text = this.MobdataGridView.Rows[MobdataGridView.CurrentCell.RowIndex].Cells["Strength"].Value.ToString();
                this.ConstitutiontextBox.Text = this.MobdataGridView.Rows[MobdataGridView.CurrentCell.RowIndex].Cells["Constitution"].Value.ToString();
                this.DexteritytextBox.Text = this.MobdataGridView.Rows[MobdataGridView.CurrentCell.RowIndex].Cells["Dexterity"].Value.ToString();
                this.QuicknesstextBox.Text = this.MobdataGridView.Rows[MobdataGridView.CurrentCell.RowIndex].Cells["Quickness"].Value.ToString();
                this.IntelligencetextBox.Text = this.MobdataGridView.Rows[MobdataGridView.CurrentCell.RowIndex].Cells["Intelligence"].Value.ToString();
                this.PietytextBox.Text = this.MobdataGridView.Rows[MobdataGridView.CurrentCell.RowIndex].Cells["Piety"].Value.ToString();
                this.CharismatextBox.Text = this.MobdataGridView.Rows[MobdataGridView.CurrentCell.RowIndex].Cells["Charisma"].Value.ToString();
                this.EmpathytextBox.Text = this.MobdataGridView.Rows[MobdataGridView.CurrentCell.RowIndex].Cells["Empathy"].Value.ToString();

                this.PackageIDtextBox.Text = this.MobdataGridView.Rows[MobdataGridView.CurrentCell.RowIndex].Cells["PackageID"].Value.ToString();
                this.RoamingnumericUpDown.Text = this.MobdataGridView.Rows[MobdataGridView.CurrentCell.RowIndex].Cells["RoamingRange"].Value.ToString();
                this.IsCloakHoodUpcomboBox.Text = Util.Find_Bool_String_Value(this.MobdataGridView.Rows[MobdataGridView.CurrentCell.RowIndex].Cells["IsCloakHoodUp"].Value.ToString());
                this.GendercomboBox.Text = Util.Find_Gender_Value(this.MobdataGridView.Rows[MobdataGridView.CurrentCell.RowIndex].Cells["Gender"].Value.ToString());
                
                this.VisibleWeaponSlotstextBox.Text = this.MobdataGridView.Rows[MobdataGridView.CurrentCell.RowIndex].Cells["VisibleWeaponSlots"].Value.ToString();

                if (DolEditor.Properties.Settings.Default.OriginsSettings)
                    this.IsCharmablecomboBox.Text = Util.Find_Bool_String_Value(this.MobdataGridView.Rows[MobdataGridView.CurrentCell.RowIndex].Cells["IsCharmable"].Value.ToString());

                this.TranslationIDtextBox.Text = this.MobdataGridView.Rows[MobdataGridView.CurrentCell.RowIndex].Cells["TranslationId"].Value.ToString();
                this.SuffixtextBox.Text = this.MobdataGridView.Rows[MobdataGridView.CurrentCell.RowIndex].Cells["Suffix"].Value.ToString();
                this.ExamineArticletextBox.Text = this.MobdataGridView.Rows[MobdataGridView.CurrentCell.RowIndex].Cells["ExamineArticle"].Value.ToString();
                this.MessageArticletextBox.Text = this.MobdataGridView.Rows[MobdataGridView.CurrentCell.RowIndex].Cells["MessageArticle"].Value.ToString();

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
            if (checkBox7.Checked == true && checkBox7.Name != cb.Name)
            {
                checkBox7.Checked = false;
            }
        }

        private void TranslationID_TextChanged(object sender, EventArgs e)
        {
            GetMobTranslationItemData("select * from languagenpc where translationid='" + TranslationIDtextBox.Text + "'");
        }

        private void TranslationdataGridViewbindingNavigatorDeleteItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete this languagenpc?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Validate();
                this.TranslationbindingSource.EndEdit();

                try
                {
                    this.MobTranslationdataAdapter.Update(TranslationDatatable);
                }
                catch (MySqlException s)
                {
                    MessageBox.Show(s.Message);
                }
            }

            GetMobTranslationItemData("select * from languagenpc where translationid='" + TranslationIDtextBox.Text + "'");
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
                this.MobTranslationdataAdapter.Update(TranslationDatatable);
            }
            catch (MySqlException s)
            {
                MessageBox.Show(s.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string select = "SELECT * FROM mob";
            bool add = false; ;

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

            GetMobItemData(select);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            {
                if (MessageBox.Show("Delete this mob?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Validate();
                    this.TranslationbindingSource.EndEdit();

                    try
                    {
                        this.MobdataAdapter.Update(MobDatatable);
                    }
                    catch (MySqlException s)
                    {
                        MessageBox.Show(s.Message);
                    }
                }

                string select = "SELECT * FROM mob";
                bool add = false; ;

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

                GetMobItemData(select);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete this languagenpc?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Validate();
                this.TranslationbindingSource.EndEdit();

                try
                {
                    this.MobTranslationdataAdapter.Update(TranslationDatatable);
                }
                catch (MySqlException s)
                {
                    MessageBox.Show(s.Message);
                }
            }

            GetMobTranslationItemData("select * from languagenpc where translationid='" + TranslationIDtextBox.Text + "'");
        }
    }
}
