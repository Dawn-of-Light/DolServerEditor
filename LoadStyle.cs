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
    public partial class LoadStyle : Form
    {
        MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder();
        MySqlDataAdapter dataAdapterbindingsource1;
        MySqlDataAdapter dataAdapterbindingsource2;
        MySqlDataAdapter LanguageStyledataAdapter;

        public LoadStyle()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load);

        }

        private void GetLanguageStyleData(string selectCommand)
        {
            try
            {
                if (!DolEditor.Properties.Settings.Default.OriginsSettings)
                    return;
                LanguageStyledataAdapter = new MySqlDataAdapter();
                MySqlConnection connection3 = new MySqlConnection("server=" + DolEditor.Properties.Settings.Default.ServerIP + ";uid=" + DolEditor.Properties.Settings.Default.Username + ";pwd=" + DolEditor.Properties.Settings.Default.Password + ";database=" + DolEditor.Properties.Settings.Default.DatabaseName + "");

                // Create a new data adapter based on the specified query.
                LanguageStyledataAdapter = new MySqlDataAdapter(selectCommand, connection3);
                // Create a command builder to generate SQL update, insert, and 
                // delete commands based on selectCommand. These are used to 
                // update the database.
                MySqlCommandBuilder commandBuilderLanguageStyle = new MySqlCommandBuilder(LanguageStyledataAdapter);
                this.languagestyle.Clear();
                // Populate a new data table and bind it to the BindingSource.
                this.languagestyle.Locale = System.Globalization.CultureInfo.InvariantCulture;
                LanguageStyledataAdapter.Fill(languagestyle);
                this.bindingSource3.DataSource = languagestyle;

                this.LanguageStyledataGridView.AutoGenerateColumns = true;
                this.LanguageStyledataGridView.Columns["LanguageStyle_ID"].Visible = false;
                this.LanguageStyledataGridView.Columns["TranslationID"].Visible = false;
                this.LanguageStyledataGridView.AllowUserToDeleteRows = true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
        }
        private void GetStyleXSpellData(string selectCommand)
        {
            try
            {
                MySqlConnection connection3 = new MySqlConnection("server=" + DolEditor.Properties.Settings.Default.ServerIP + ";uid=" + DolEditor.Properties.Settings.Default.Username + ";pwd=" + DolEditor.Properties.Settings.Default.Password + ";database=" + DolEditor.Properties.Settings.Default.DatabaseName + "");

                // Create a new data adapter based on the specified query.
                dataAdapterbindingsource2 = new MySqlDataAdapter(selectCommand, connection3);
                // Create a command builder to generate SQL update, insert, and 
                // delete commands based on selectCommand. These are used to 
                // update the database.
                MySqlCommandBuilder commandBuilderbindingsource2 = new MySqlCommandBuilder(dataAdapterbindingsource2);
                this.StyleXSpell.Clear();
                // Populate a new data table and bind it to the BindingSource.
                this.StyleXSpell.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapterbindingsource2.Fill(StyleXSpell);
                this.bindingSource2.DataSource = StyleXSpell;
                this.StyleXSpelldataGridView.AutoGenerateColumns = true;
                this.StyleXSpelldataGridView.AllowUserToDeleteRows = true;
                this.StyleXSpelldataGridView.Columns["StyleXSpell_ID"].Visible = false;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
        }

        private void GetStyleRequirementComboBoxValue(string selectCommand)
        {
            try
            {
                MySqlConnection connection3 = new MySqlConnection("server=" + DolEditor.Properties.Settings.Default.ServerIP + ";uid=" + DolEditor.Properties.Settings.Default.Username + ";pwd=" + DolEditor.Properties.Settings.Default.Password + ";database=" + DolEditor.Properties.Settings.Default.DatabaseName + "");

                // Create a new data adapter based on the specified query.
                MySqlDataAdapter dataAdapterbindingsourceStyleRequirement = new MySqlDataAdapter(selectCommand, connection3);
                // Create a command builder to generate SQL update, insert, and 
                // delete commands based on selectCommand. These are used to 
                // update the database.
                MySqlCommandBuilder commandBuilderStyleRequirement = new MySqlCommandBuilder(dataAdapterbindingsourceStyleRequirement);
                DataTable StyleRequirementDataTable = new DataTable();

                dataAdapterbindingsourceStyleRequirement.Fill(StyleRequirementDataTable);
                this.OpeningRequirementValuecomboBox.DataSource = StyleRequirementDataTable;

                this.OpeningRequirementValuecomboBox.ValueMember = "ID";
                this.OpeningRequirementValuecomboBox.DisplayMember = "Name";
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
        }

        private void GetData(string selectCommand)
        {
            try
            {
                dataAdapterbindingsource1 = new MySqlDataAdapter();
                MySqlConnection connection3 = new MySqlConnection("server=" + DolEditor.Properties.Settings.Default.ServerIP + ";uid=" + DolEditor.Properties.Settings.Default.Username + ";pwd=" + DolEditor.Properties.Settings.Default.Password + ";database=" + DolEditor.Properties.Settings.Default.DatabaseName + "");

                // Create a new data adapter based on the specified query.
                dataAdapterbindingsource1 = new MySqlDataAdapter(selectCommand, connection3);
                // Create a command builder to generate SQL update, insert, and 
                // delete commands based on selectCommand. These are used to 
                // update the database.
                commandBuilder = new MySqlCommandBuilder(dataAdapterbindingsource1);
                StyleDataTable.Clear();
                // Populate a new data table and bind it to the BindingSource.
                StyleDataTable.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapterbindingsource1.Fill(StyleDataTable);
                bindingSource1.DataSource = StyleDataTable;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.StyleSearchKeyNamecomboBox.SelectedIndex = 0;
            this.ClassIDSearchcomboBox.SelectedIndex = 0;
            this.RandomProccomboBox.SelectedIndex = 0;
            this.StealthRequirementcomboBox.SelectedIndex = 0;
            this.OpeningRequirementTypecomboBox.SelectedIndex = 0;
            this.AttackResultRequirementcomboBox.SelectedIndex = 0;
            this.WeaponTypeRequirementcomboBox.SelectedIndex = 0;
            this.SpecKeyNamecomboBox.SelectedIndex = 0;
            this.LanguageChoicecomboBox.SelectedIndex = 0;

            this.StyleListingButton.Visible = false;
            this.Savebutton.Hide();
            this.SaveNewbutton.Hide();
            this.EditStyleControl.Hide();
            this.dataGridStyle.AutoGenerateColumns = true;
            GetData("select * from style");
            this.dataGridStyle.DataSource = bindingSource1;

            if (DolEditor.Properties.Settings.Default.OriginsSettings)
            {
                groupBox12.Enabled = true;
                TranslationIDtextBox.Enabled = true;
            }
        }

        /// <summary>
        /// Each change on Filter occurs an update.
        /// </summary>
        private void SearchFilters_SelectedChanged(object sender, EventArgs e)
        {
            string select = "SELECT * FROM style";
            bool add = false; ;
            if (this.SearchStyleIDtextBox.Text != "")
            {
                select += " where id='" + this.SearchStyleIDtextBox.Text + "'";
                add = true;
            }

            if (this.SearchByStyleNametextBox.Text != "")
            {
                if (add)
                    select += " and Name like '%" + this.SearchByStyleNametextBox.Text + "%'";
                else
                {
                    select += " where Name like '%" + this.SearchByStyleNametextBox.Text + "%'";
                    add = true;
                }
            }
            string ClassID = " All";
            if (ClassIDSearchcomboBox.Text != null)
                ClassID = Util.ClassNameToID(this.ClassIDSearchcomboBox.Text.ToString()); //ClassID

            if (ClassID != " All")
            {
                if (add)
                    select += " and classid='" + ClassID + "'";
                else
                {
                    select += " where classid='" + ClassID + "'";
                    add = true;
                }
            }
            string SpecName = " All";
            if (StyleSearchKeyNamecomboBox.Text != null)
                SpecName = this.StyleSearchKeyNamecomboBox.Text.ToString(); //Spec Key Name

            if (SpecName != " All")
            {
                if (add)
                    select += " and speckeyname='" + SpecName + "'";
                else
                {
                    select += " where speckeyname='" + SpecName + "'";
                    add = true;
                }
            }

            GetData(select);
        }

        /// <summary>
        /// Load a style with confirmation in editing form.
        /// </summary>
        private void StyledataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            if (MessageBox.Show("Load this style in editor?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.EditStyleControl.Show();
                this.dataGridStyle.Hide();
                this.StyleIDtextBox.Text = this.dataGridStyle.Rows[dataGridStyle.CurrentCell.RowIndex].Cells["ID"].Value.ToString();
                this.ClassIDcomboBox.Text = Util.ClassIDToName(this.dataGridStyle.Rows[dataGridStyle.CurrentCell.RowIndex].Cells["ClassId"].Value.ToString());
                this.StyleNametextBox.Text = this.dataGridStyle.Rows[dataGridStyle.CurrentCell.RowIndex].Cells["Name"].Value.ToString();
                this.SpecKeyNamecomboBox.Text = this.dataGridStyle.Rows[dataGridStyle.CurrentCell.RowIndex].Cells["SpecKeyName"].Value.ToString();
                this.SpecLevelRequirementtextBox.Text = this.dataGridStyle.Rows[dataGridStyle.CurrentCell.RowIndex].Cells["SpecLevelRequirement"].Value.ToString();
                this.IcontextBox.Text = this.dataGridStyle.Rows[dataGridStyle.CurrentCell.RowIndex].Cells["Icon"].Value.ToString();
                this.EnduranceCosttextBox.Text = this.dataGridStyle.Rows[dataGridStyle.CurrentCell.RowIndex].Cells["EnduranceCost"].Value.ToString();
                this.StealthRequirementcomboBox.Text = this.dataGridStyle.Rows[dataGridStyle.CurrentCell.RowIndex].Cells["StealthRequirement"].Value.ToString();
                this.OpeningRequirementTypecomboBox.Text = Util.Find_OpeningRequirementType_String_Value(this.dataGridStyle.Rows[dataGridStyle.CurrentCell.RowIndex].Cells["OpeningRequirementType"].Value.ToString());
                this.OpeningRequirementValuecomboBox.Text = this.dataGridStyle.Rows[dataGridStyle.CurrentCell.RowIndex].Cells["OpeningRequirementValue"].Value.ToString();
                this.AttackResultRequirementcomboBox.Text = Util.Find_AttackResultRequirement_String_Value(this.dataGridStyle.Rows[dataGridStyle.CurrentCell.RowIndex].Cells["AttackResultRequirement"].Value.ToString());
                this.WeaponTypeRequirementcomboBox.Text = Util.ObjectIDToName(this.dataGridStyle.Rows[dataGridStyle.CurrentCell.RowIndex].Cells["WeaponTypeRequirement"].Value.ToString());
                this.GrowthratetextBox.Text = this.dataGridStyle.Rows[dataGridStyle.CurrentCell.RowIndex].Cells["GrowthRate"].Value.ToString();
                this.BonustoHittextBox.Text = this.dataGridStyle.Rows[dataGridStyle.CurrentCell.RowIndex].Cells["BonusToHit"].Value.ToString();
                this.BonustoDefensetextBox.Text = this.dataGridStyle.Rows[dataGridStyle.CurrentCell.RowIndex].Cells["BonusToDefense"].Value.ToString();
                this.TwoHandAnimtextBox.Text = this.dataGridStyle.Rows[dataGridStyle.CurrentCell.RowIndex].Cells["TwoHandAnimation"].Value.ToString();
                this.RandomProccomboBox.Text = this.dataGridStyle.Rows[dataGridStyle.CurrentCell.RowIndex].Cells["RandomProc"].Value.ToString();
                this.ArmorHitLoctextBox.Text = this.dataGridStyle.Rows[dataGridStyle.CurrentCell.RowIndex].Cells["ArmorHitLocation"].Value.ToString();

                if (DolEditor.Properties.Settings.Default.OriginsSettings)
                    this.TranslationIDtextBox.Text = this.dataGridStyle.Rows[dataGridStyle.CurrentCell.RowIndex].Cells["TranslationId"].Value.ToString();
                
                this.SaveNewbutton.Hide();
                this.Savebutton.Show();
                this.ControlMenu.Visible = false;
                this.StyleListingButton.Visible = true;
                this.StyleAddButton.Visible = true;

               // GetStyleXSpellData("SELECT * FROM stylexspell WHERE styleid ='" + this.StyleIDtextBox.Text + "' and (classid = '0' or classid ='" + this.ClassIDtextBox.Text + "')");
            }
        }

        private void SaveLoadedStyle_Click(object sender, EventArgs e)
        {
            if (!ValidStyleData())
                return;

            if (MessageBox.Show("Accept this style update?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.dataGridStyle.ReadOnly = false;

                this.dataGridStyle.Rows[dataGridStyle.CurrentCell.RowIndex].Cells["ID"].Value = this.StyleIDtextBox.Text;
                this.dataGridStyle.Rows[dataGridStyle.CurrentCell.RowIndex].Cells["ClassId"].Value = Util.ClassNameToID(this.ClassIDcomboBox.Text);
                this.dataGridStyle.Rows[dataGridStyle.CurrentCell.RowIndex].Cells["Name"].Value = this.StyleNametextBox.Text;
                this.dataGridStyle.Rows[dataGridStyle.CurrentCell.RowIndex].Cells["SpecKeyName"].Value = this.SpecKeyNamecomboBox.Text;
                this.dataGridStyle.Rows[dataGridStyle.CurrentCell.RowIndex].Cells["SpecLevelRequirement"].Value = this.SpecLevelRequirementtextBox.Text;
                this.dataGridStyle.Rows[dataGridStyle.CurrentCell.RowIndex].Cells["Icon"].Value = this.IcontextBox.Text;
                this.dataGridStyle.Rows[dataGridStyle.CurrentCell.RowIndex].Cells["EnduranceCost"].Value = this.EnduranceCosttextBox.Text;
                this.dataGridStyle.Rows[dataGridStyle.CurrentCell.RowIndex].Cells["StealthRequirement"].Value = this.StealthRequirementcomboBox.Text;
                this.dataGridStyle.Rows[dataGridStyle.CurrentCell.RowIndex].Cells["OpeningRequirementType"].Value = this.OpeningRequirementTypecomboBox.SelectedIndex;
                this.dataGridStyle.Rows[dataGridStyle.CurrentCell.RowIndex].Cells["OpeningRequirementValue"].Value = this.OpeningRequirementValuecomboBox.ValueMember;
                this.dataGridStyle.Rows[dataGridStyle.CurrentCell.RowIndex].Cells["AttackResultRequirement"].Value = this.AttackResultRequirementcomboBox.SelectedIndex;
                this.dataGridStyle.Rows[dataGridStyle.CurrentCell.RowIndex].Cells["WeaponTypeRequirement"].Value = Util.ObjectNameToID(this.WeaponTypeRequirementcomboBox.Text);
                this.dataGridStyle.Rows[dataGridStyle.CurrentCell.RowIndex].Cells["GrowthRate"].Value = this.GrowthratetextBox.Text;
                this.dataGridStyle.Rows[dataGridStyle.CurrentCell.RowIndex].Cells["BonusToHit"].Value = this.BonustoHittextBox.Text;
                this.dataGridStyle.Rows[dataGridStyle.CurrentCell.RowIndex].Cells["BonusToDefense"].Value = this.BonustoDefensetextBox.Text;
                this.dataGridStyle.Rows[dataGridStyle.CurrentCell.RowIndex].Cells["TwoHandAnimation"].Value = this.TwoHandAnimtextBox.Text;
                this.dataGridStyle.Rows[dataGridStyle.CurrentCell.RowIndex].Cells["RandomProc"].Value = this.RandomProccomboBox.Text;
                this.dataGridStyle.Rows[dataGridStyle.CurrentCell.RowIndex].Cells["ArmorHitLocation"].Value = this.ArmorHitLoctextBox.Text;

                if (DolEditor.Properties.Settings.Default.OriginsSettings)
                    this.dataGridStyle.Rows[dataGridStyle.CurrentCell.RowIndex].Cells["TranslationId"].Value = this.TranslationIDtextBox.Text;

                this.Validate();
                this.bindingSource1.EndEdit();

                try
                {
                    dataAdapterbindingsource1.Update(StyleDataTable);
                }
                catch (MySqlException s)
                {
                    System.Windows.MessageBox.Show(s.Message);
                }

                this.dataGridStyle.ReadOnly = true;
                this.EditStyleControl.Hide();
                this.dataGridStyle.Show();
                this.ControlMenu.Visible = true;
                this.StyleAddButton.Visible = true;
                this.StyleListingButton.Visible = false;
                this.Savebutton.Hide();
            }
        }

        private bool ValidStyleData()
        {

            if (this.StyleIDtextBox.Text == "" || this.StyleIDtextBox.Text == null)
            {
                MessageBox.Show("You need to specify a StyleID value.");
                return false;
            }
            int styleid;
            if (!Int32.TryParse(StyleIDtextBox.Text.ToString(), out styleid))
            {
                MessageBox.Show("You need to specify a numeric value for Styleid.");
                return false;
            }
            if (this.ClassIDcomboBox.Text == "" || this.ClassIDcomboBox.Text == null)
            {
                MessageBox.Show("You need to specify a ClassID value.");
                return false;
            }
            if (this.StyleNametextBox.Text == "" || this.StyleNametextBox.Text == null)
            {
                MessageBox.Show("You need to specify a Name value.");
                return false;
            }
            if (this.SpecKeyNamecomboBox.Text == "" || this.SpecKeyNamecomboBox.Text == null)
            {
                MessageBox.Show("You need to specify a SpecKeyName value.");
                return false;
            }
            if (this.SpecLevelRequirementtextBox.Text == "" || this.SpecLevelRequirementtextBox.Text == null)
            {
                MessageBox.Show("You need to specify a SpecLevelRequirement value.");
                return false;
            }
            int speclevelrequirement;
            if (!Int32.TryParse(SpecLevelRequirementtextBox.Text.ToString(), out speclevelrequirement))
            {
                MessageBox.Show("You need to specify a numeric value for SpecLevelRequirement.");
                return false;
            }
            if (this.IcontextBox.Text == "" || this.IcontextBox.Text == null)
            {
                IcontextBox.Text = "0";
            }
            int icon;
            if (!Int32.TryParse(IcontextBox.Text.ToString(), out icon))
            {
                MessageBox.Show("You need to specify a numeric value for icon.");
                return false;
            }
            if (this.EnduranceCosttextBox.Text == "" || this.EnduranceCosttextBox.Text == null)
            {
                EnduranceCosttextBox.Text = "0";
            }
            int endurancecost;
            if (!Int32.TryParse(EnduranceCosttextBox.Text.ToString(), out endurancecost))
            {
                MessageBox.Show("You need to specify a numeric value for endurancecost.");
                return false;
            }
            if (this.StealthRequirementcomboBox.Text == "" || this.StealthRequirementcomboBox.Text == null)
            {
                StealthRequirementcomboBox.Text = "0";
            }
            int stealthrequirement;
            if (!Int32.TryParse(StyleIDtextBox.Text.ToString(), out stealthrequirement))
            {
                MessageBox.Show("You need to specify a numeric value for stealthrequirement.");
                return false;
            }
            if (this.OpeningRequirementTypecomboBox.Text == "" || this.OpeningRequirementTypecomboBox.Text == null)
            {
                OpeningRequirementTypecomboBox.Text = "0";
            }
            if (this.OpeningRequirementValuecomboBox.Text == "" || this.OpeningRequirementValuecomboBox.Text == null)
            {
                OpeningRequirementValuecomboBox.Text = "0";
            }
            if (this.AttackResultRequirementcomboBox.Text == "" || this.AttackResultRequirementcomboBox.Text == null)
            {
                AttackResultRequirementcomboBox.Text = "0";
            }
            if (this.WeaponTypeRequirementcomboBox.Text == "" || this.WeaponTypeRequirementcomboBox.Text == null)
            {
                WeaponTypeRequirementcomboBox.Text = "0";
            }

            if (this.GrowthratetextBox.Text == "" || this.GrowthratetextBox.Text == null)
            {
                GrowthratetextBox.Text = "0,0";
            }
            double growthrate;
            if (!Double.TryParse(StyleIDtextBox.Text.ToString(), out growthrate))
            {
                MessageBox.Show("You need to specify a numeric value for growthrate.0,0.");
                return false;
            }
            if (this.BonustoHittextBox.Text == "" || this.BonustoHittextBox.Text == null)
            {
                BonustoHittextBox.Text = "0";
            }
            int bonustohit;
            if (!Int32.TryParse(BonustoHittextBox.Text.ToString(), out bonustohit))
            {
                MessageBox.Show("You need to specify a numeric value for bonustohit.");
                return false;
            }
            if (this.BonustoDefensetextBox.Text == "" || this.BonustoDefensetextBox.Text == null)
            {
                BonustoDefensetextBox.Text = "0";
            }
            int bonustodefense;
            if (!Int32.TryParse(BonustoDefensetextBox.Text.ToString(), out bonustodefense))
            {
                MessageBox.Show("You need to specify a numeric value for bonustodefense.");
                return false;
            }
            if (this.TwoHandAnimtextBox.Text == "" || this.TwoHandAnimtextBox.Text == null)
            {
                TwoHandAnimtextBox.Text = "0";
            }
            int twohandAnim;
            if (!Int32.TryParse(TwoHandAnimtextBox.Text.ToString(), out twohandAnim))
            {
                MessageBox.Show("You need to specify a numeric value for twohandAnimation.");
                return false;
            }
            if (this.RandomProccomboBox.Text == "" || this.RandomProccomboBox.Text == null)
            {
                RandomProccomboBox.Text = "0";
            }
            if (RandomProccomboBox.Text.ToString().ToLower() != "false")
            {
                if (RandomProccomboBox.Text.ToString().ToLower() != "true")
                {
                    MessageBox.Show("You need to specify false or true for randomproc.");
                    return false;
                }
            }
            if (this.ArmorHitLoctextBox.Text == "" || this.ArmorHitLoctextBox.Text == null)
            {
                ArmorHitLoctextBox.Text = "0";
            }
            int armorhitloc;
            if (!Int32.TryParse(ArmorHitLoctextBox.Text.ToString(), out armorhitloc))
            {
                MessageBox.Show("You need to specify a numeric value for ArmorHitLocation.");
                return false;
            }
            if (this.TranslationIDtextBox.Text == "" || this.TranslationIDtextBox.Text == null)
            {
                TranslationIDtextBox.Text = "";
            }

            return true;
        }

        private void SaveNewStyle_Click(object sender, EventArgs e)
        {
            if (!ValidStyleData())
                return;

            if (MessageBox.Show("Save this new style?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                long i = 1;
                foreach (byte b in Guid.NewGuid().ToByteArray())
                {
                    i *= ((int)b + 1);
                }
                i -= DateTime.Now.Ticks;
                string str = "Origins_Editor_" + i.ToString();

                DataRow datarow = StyleDataTable.NewRow();

                datarow["Style_ID"] = str;
                datarow["ID"] = StyleIDtextBox.Text;
                datarow["ClassId"] = Util.ClassNameToID(this.ClassIDcomboBox.Text);
                datarow["Name"] = StyleNametextBox.Text;
                datarow["SpecKeyName"] = SpecKeyNamecomboBox.Text;
                datarow["SpecLevelRequirement"] = SpecLevelRequirementtextBox.Text;
                datarow["Icon"] = IcontextBox.Text;
                datarow["EnduranceCost"] = EnduranceCosttextBox.Text;
                datarow["StealthRequirement"] = Util.Find_Bool_Value(StealthRequirementcomboBox.Text);
                datarow["OpeningRequirementType"] = OpeningRequirementTypecomboBox.SelectedIndex;
                datarow["OpeningRequirementValue"] = OpeningRequirementValuecomboBox.ValueMember;
                datarow["AttackResultRequirement"] = AttackResultRequirementcomboBox.SelectedIndex;

                datarow["WeaponTypeRequirement"] = Util.ObjectNameToID(WeaponTypeRequirementcomboBox.Text);
                datarow["GrowthRate"] = GrowthratetextBox.Text;
                datarow["BonusToHit"] = BonustoHittextBox.Text;
                datarow["BonusToDefense"] = BonustoDefensetextBox.Text;
                datarow["TwoHandAnimation"] = TwoHandAnimtextBox.Text;
                datarow["RandomProc"] = Util.Find_Bool_Value(RandomProccomboBox.Text);
                datarow["ArmorHitLocation"] = ArmorHitLoctextBox.Text;

                if (DolEditor.Properties.Settings.Default.OriginsSettings)
                    datarow["TranslationId"] = TranslationIDtextBox.Text;

                StyleDataTable.Rows.Add(datarow);

                this.Validate();
                this.bindingSource1.EndEdit();

                try
                {
                    dataAdapterbindingsource1.Update(StyleDataTable);
                }
                catch (MySqlException s)
                {
                    System.Windows.MessageBox.Show(s.Message);
                }

                this.EditStyleControl.Hide();
                this.dataGridStyle.Show();
                this.ControlMenu.Visible = true;
                this.StyleAddButton.Visible = true;
                this.StyleListingButton.Visible = false;
                this.SaveNewbutton.Hide();
            }
        }

        private void StyleXSpellNavigatorDeleteItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete this StyleXSpell?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {           
                this.Validate();
                this.bindingSource2.EndEdit();

                try
                {
                    this.dataAdapterbindingsource2.Update(StyleXSpell);
                }
                catch (MySqlException s)
                {
                    System.Windows.MessageBox.Show(s.Message);
                }
            }

            GetStyleXSpellData("SELECT * FROM stylexspell WHERE styleid ='" + this.StyleIDtextBox.Text + "' and (classid = '0' or classid ='" + Util.ClassNameToID(this.ClassIDcomboBox.Text) + "')");
        }

        private void StyleNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete this Style?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {         
                this.Validate();
                this.bindingSource1.EndEdit();

                try
                {
                    this.dataAdapterbindingsource1.Update(StyleDataTable);
                }
                catch (MySqlException s)
                {
                    System.Windows.MessageBox.Show(s.Message);
                }
            }

            string select = "SELECT * FROM style";
            bool add = false; ;
            if (this.SearchStyleIDtextBox.Text != "")
            {
                select += " where id='" + this.SearchStyleIDtextBox.Text + "'";
                add = true;
            }

            if (this.SearchByStyleNametextBox.Text != "")
            {
                if (add)
                    select += " and Name like '%" + this.SearchByStyleNametextBox.Text + "%'";
                else
                {
                    select += " where Name like '%" + this.SearchByStyleNametextBox.Text + "%'";
                    add = true;
                }
            }
            string ClassID = " A1l";
            if (ClassIDSearchcomboBox.Text != null)
                ClassID = Util.ClassNameToID(this.ClassIDSearchcomboBox.Text.ToString()); //ClassID

            if (ClassID != " All")
            {
                if (add)
                    select += " and classid='" + ClassID + "'";
                else
                {
                    select += " where classid='" + ClassID + "'";
                    add = true;
                }
            }
            string SpecName = " All";
            if (StyleSearchKeyNamecomboBox.Text != null)
                SpecName = this.StyleSearchKeyNamecomboBox.Text.ToString(); //Spec Key Name

            if (SpecName != " All")
            {
                if (add)
                    select += " and speckeyname='" + SpecName + "'";
                else
                {
                    select += " where speckeyname='" + SpecName + "'";
                    add = true;
                }
            }

            GetData(select);
        }

        private void AddStyleXSpell_Click(object sender, EventArgs e)
        {

            if (ClassIDcomboBox.Text.ToString() == "" || ClassIDcomboBox.Text == null)
            {
                MessageBox.Show("The loaded spell don't have a ClassID defined.");
                return;
            }
            if (StyleIDtextBox.Text.ToString() == "" || StyleIDtextBox.Text == null)
            {
                MessageBox.Show("The loaded spell don't have a spellid defined.");
                return;
            }
            if (SpellIDStyleXSpelltextBox.Text.ToString() == "" || SpellIDStyleXSpelltextBox.Text == null)
            {
                MessageBox.Show("You need to specify a SpellID for this StyleXSpell.");
                return;
            }
            if (ChancetextBox.Text.ToString() == "" || ChancetextBox.Text == null)
            {
                MessageBox.Show("You need to specify a % chance for this StyleXSpell.");
                return;
            }
            int spellid;
            if (!Int32.TryParse(SpellIDStyleXSpelltextBox.Text.ToString(), out spellid))
            {
                MessageBox.Show("You need to specify a numeric value for SpellID.");
                return;
            }
            int chance;
            if (!Int32.TryParse(ChancetextBox.Text.ToString(), out chance))
            {
                MessageBox.Show("You need to specify a numeric value for Chance.");
                return;
            }
            int styleid;
            if (!Int32.TryParse(StyleIDtextBox.Text.ToString(), out styleid))
            {
                MessageBox.Show("You need to specify a numeric value for StyleID.");
                return;
            }
            if (MessageBox.Show("Add this StyleXSpell?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                long i = 1;
                foreach (byte b in Guid.NewGuid().ToByteArray())
                {
                    i *= ((int)b + 1);
                }
                i -= DateTime.Now.Ticks;
                string str = "Origins_Editor_" + i.ToString();

                DataRow datarow = StyleXSpell.NewRow();

                datarow["StyleXSpell_ID"] = str;
                datarow["SpellID"] = SpellIDStyleXSpelltextBox.Text;
                datarow["ClassID"] = Util.ClassNameToID(this.ClassIDcomboBox.Text);
                datarow["StyleID"] = StyleIDtextBox.Text;
                datarow["Chance"] = ChancetextBox.Text;


                StyleXSpell.Rows.Add(datarow);
                this.Validate();
                this.bindingSource2.EndEdit();

                try
                {
                    this.dataAdapterbindingsource2.Update(StyleXSpell);
                }
                catch (MySqlException s)
                {
                    System.Windows.MessageBox.Show(s.Message);
                }

                GetStyleXSpellData("SELECT * FROM stylexspell WHERE styleid ='" + this.StyleIDtextBox.Text + "' and (classid = '0' or classid ='" + Util.ClassNameToID(this.ClassIDcomboBox.Text) + "')");
            }
        }

        private void TranslationID_TextChanged(object sender, EventArgs e)
        {
            if (!DolEditor.Properties.Settings.Default.OriginsSettings)
                return;
            GetLanguageStyleData("SELECT * FROM languagestyle WHERE TranslationId ='" + this.TranslationIDtextBox.Text + "'");
        }

        private void AddLanguageStyle_Click(object sender, EventArgs e)
        {
            if (!DolEditor.Properties.Settings.Default.OriginsSettings)
                return;

            if (LanguageChoicecomboBox.Text.ToString() == "" || LanguageChoicecomboBox.Text == null)
            {
                MessageBox.Show("You need to specify a Language for this languagestyle.");
                return;
            }
            if (TranslationIDtextBox.Text.ToString() == "" || TranslationIDtextBox.Text == null)
            {
                MessageBox.Show("The loaded style don't have a translationid defined.");
                return;
            }
            if (NameLanguageStyletextBox.Text.ToString() == "" || NameLanguageStyletextBox.Text == null)
            {
                MessageBox.Show("You need to specify a Name for this languagestyle.");
                return;
            }
            if (DescriptionLanguageStylerichTextBox.Text == null)
            {
                DescriptionLanguageStylerichTextBox.Text = "";
            }
            if (TagLanguagueStyletextBox.Text == null)
            {
                TagLanguagueStyletextBox.Text = "";
            }
            if (MessageBox.Show("Add this LanguageStyle?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                long i = 1;
                foreach (byte b in Guid.NewGuid().ToByteArray())
                {
                    i *= ((int)b + 1);
                }
                i -= DateTime.Now.Ticks;
                string str = "Origins_Editor_" + i.ToString();

                DataRow datarow = languagestyle.NewRow();

                datarow["LanguageStyle_ID"] = str;
                datarow["Language"] = LanguageChoicecomboBox.Text;//.Replace("'", "''");
                datarow["TranslationId"] = TranslationIDtextBox.Text;
                datarow["Name"] = NameLanguageStyletextBox.Text;
                datarow["Description"] = DescriptionLanguageStylerichTextBox.Text;
                datarow["Tag"] = TagLanguagueStyletextBox.Text;

                languagestyle.Rows.Add(datarow);

                this.Validate();
                this.bindingSource3.EndEdit();

                try
                {
                    this.LanguageStyledataAdapter.Update(languagestyle);
                }
                catch (MySqlException s)
                {
                    System.Windows.MessageBox.Show(s.Message);
                }

                GetLanguageStyleData("SELECT * FROM languagestyle WHERE TranslationId ='" + this.TranslationIDtextBox.Text + "'");
            }
        }

        private void LanguageStyleNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (!DolEditor.Properties.Settings.Default.OriginsSettings)
                return;

            if (MessageBox.Show("Delete this LanguageStyle?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Validate();
                this.bindingSource3.EndEdit();

                try
                {
                    this.LanguageStyledataAdapter.Update(languagestyle);
                }
                catch (MySqlException s)
                {
                    System.Windows.MessageBox.Show(s.Message);
                }
            }
            GetLanguageStyleData("SELECT * FROM languagestyle WHERE TranslationId ='" + this.TranslationIDtextBox.Text + "'");
        }

        private void LanguageStyledataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (!DolEditor.Properties.Settings.Default.OriginsSettings)
                return;

            this.Validate();
            this.bindingSource3.EndEdit();

            try
            {
                this.LanguageStyledataAdapter.Update(languagestyle);
            }
            catch (MySqlException s)
            {
                System.Windows.MessageBox.Show(s.Message);
            }
        }

        private void StyleXSpelldataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            this.Validate();
            this.bindingSource2.EndEdit();

            try
            {
                this.dataAdapterbindingsource2.Update(StyleXSpell);
            }
            catch (MySqlException s)
            {
                System.Windows.MessageBox.Show(s.Message);
            }
        }

        private void StyleListing_Click(object sender, EventArgs e)
        {
            this.EditStyleControl.Hide();
            this.dataGridStyle.Show();
            this.Savebutton.Hide();
            this.SaveNewbutton.Hide();
            this.StyleListingButton.Visible = false;
            this.StyleAddButton.Visible = true;
            this.ControlMenu.Visible = true;
        }

        private void AddNewStyle_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Begin add a new style?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.dataGridStyle.Hide();
                this.Savebutton.Hide();
                this.SaveNewbutton.Show();
                this.EditStyleControl.Show();
                this.StyleAddButton.Visible = false;
                this.StyleListingButton.Visible = true;
                this.ControlMenu.Visible = false;
            }
        }

        private void AltercomboBoxValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetStyleXSpellData("SELECT * FROM stylexspell WHERE styleid ='" + this.StyleIDtextBox.Text + "' and (classid = '0' or classid ='" + Util.ClassNameToID(this.ClassIDcomboBox.Text) + "')");
            GetStyleRequirementComboBoxValue("SELECT * FROM style WHERE SpecKeyName ='" + this.SpecKeyNamecomboBox.Text + "' and (classid = '0' or classid ='" + Util.ClassNameToID(this.ClassIDcomboBox.Text) + "')");
        }
    }
}
