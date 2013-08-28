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

namespace DOL_Editor
{
    public partial class LoadSpell : Form
    {
        private MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder();
        private MySqlDataAdapter SpelldataAdapter;
        private MySqlDataAdapter LineXSpelldataAdapter;
        private MySqlDataAdapter LanguageSpelldataAdapter;

        public LoadSpell()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load);
        }

        private void GetLanguageSpellData(string selectCommand)
        {
            try
            {
                if (!DolEditor.Properties.Settings.Default.OriginsSettings)
                    return;
                // Create a new data adapter based on the specified query.
                LanguageSpelldataAdapter = new MySqlDataAdapter(selectCommand, Util.Connection);
                // Create a command builder to generate SQL update, insert, and 
                // delete commands based on selectCommand. These are used to 
                // update the database.
                MySqlCommandBuilder commandBuilderLanguageSpell = new MySqlCommandBuilder(LanguageSpelldataAdapter);
                this.languagespell.Clear();
                // Populate a new data table and bind it to the BindingSource.
                this.languagespell.Locale = System.Globalization.CultureInfo.InvariantCulture;
                LanguageSpelldataAdapter.Fill(languagespell);
                this.LanguageSpellbindingSource.DataSource = languagespell;

                this.dataGridViewLanguageSpell.AutoGenerateColumns = true;
                this.dataGridViewLanguageSpell.Columns["LanguageSpell_ID"].Visible = false;
                this.dataGridViewLanguageSpell.Columns["TranslationID"].Visible = false;
                this.dataGridViewLanguageSpell.AllowUserToDeleteRows = true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
        }

        private void GetLineXSpellData(string selectCommand)
        {
            try
            {
                // Create a new data adapter based on the specified query.
                LineXSpelldataAdapter = new MySqlDataAdapter(selectCommand, Util.Connection);
                // Create a command builder to generate SQL update, insert, and 
                // delete commands based on selectCommand. These are used to 
                // update the database.
                MySqlCommandBuilder commandBuilderLineXSpell = new MySqlCommandBuilder(LineXSpelldataAdapter);
                this.linexspell.Clear();
                // Populate a new data table and bind it to the BindingSource.
                this.linexspell.Locale = System.Globalization.CultureInfo.InvariantCulture;
                LineXSpelldataAdapter.Fill(linexspell);
                this.LineXSpellbindingSource.DataSource = linexspell;
                this.dataGridViewLineXSpell.AutoGenerateColumns = true;
                this.dataGridViewLineXSpell.Columns["LineXSpell_ID"].Visible = false;
                this.dataGridViewLineXSpell.Columns["SpellID"].Visible = false;
                this.dataGridViewLineXSpell.AllowUserToDeleteRows = true;
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
                // Create a new data adapter based on the specified query.
                SpelldataAdapter = new MySqlDataAdapter(selectCommand, Util.Connection);
                // Create a command builder to generate SQL update, insert, and 
                // delete commands based on selectCommand. These are used to 
                // update the database.
                commandBuilder = new MySqlCommandBuilder(SpelldataAdapter);
                SpellDatatable.Clear();
                // Populate a new data table and bind it to the BindingSource.
                SpellDatatable.Locale = System.Globalization.CultureInfo.InvariantCulture;
                SpelldataAdapter.Fill(SpellDatatable);
                SpellbindingSource.DataSource = SpellDatatable;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.tabControl1.Hide();
            this.dataGridSpell.AutoGenerateColumns = true;
            this.dataGridSpell.AllowUserToDeleteRows = true;
            this.SpellListingButton.Visible = false;
            this.Savebutton.Hide();
            this.SaveNewbutton.Hide();

            GetData("select * from spell");

            LanguageSpellLAnguageChoicecomboBox.SelectedIndex = 0;
            TargetcomboBox.SelectedIndex = 1;
            UninterruptiblecomboBox.SelectedIndex = 0;
            IsPrimarycomboBox.SelectedIndex = 0;
            IsSecondarycomboBox.SelectedIndex = 0;
            AllowBoltcomboBox.SelectedIndex = 0;
            MoveCastcomboBox.SelectedIndex = 0;
            IsFocuscomboBox.SelectedIndex = 0; 
            LineNameSpellSearchcomboBox.SelectedIndex = 0;
            SpellHandlerSearchcomboBox.SelectedIndex = 0;
            LineNameAddLineXSpellcomboBox.SelectedIndex = 58; //Item Effects

            this.dataGridSpell.Columns["Spell_ID"].Visible = false;
            this.spellIDtextBox.Enabled = false;

            try
            {
                Util.Connection.Open();

                //PackageID Datatable
                MySqlDataAdapter PackageIDdataAdapter = new MySqlDataAdapter("select distinct packageid from spell ORDER BY packageid ASC", Util.Connection);
                MySqlCommandBuilder PackageIDDatacommandBuilder = new MySqlCommandBuilder(PackageIDdataAdapter);
                DataTable PackageIDData = new DataTable();
                PackageIDdataAdapter.Fill(PackageIDData);
                this.PackageIDcomboBox.DisplayMember = "PackageID";
                this.PackageIDcomboBox.DataSource = PackageIDData;

                DataTable PackageIDLineXSpellAddData = new DataTable();
                PackageIDdataAdapter.Fill(PackageIDLineXSpellAddData);
                this.PackageIDAddLineXSpellcomboBox.DisplayMember = "PackageID";
                this.PackageIDAddLineXSpellcomboBox.DataSource = PackageIDLineXSpellAddData;

                Util.Connection.Close();

            }
            catch (MySqlException s)
            {
                MessageBox.Show(s.Message);
            }

            if (DolEditor.Properties.Settings.Default.OriginsSettings)
            {
                groupBox12.Enabled = true;
                TranslationIDtextBox.Enabled = true;
            }

        }

        private bool ValidSpellData()
        {

            if (Util.IsEmpty(ClientEffecttextBox.Text))
            {
                ClientEffecttextBox.Text = "0";
            }
            int ClientEffect;
            if (!Int32.TryParse(ClientEffecttextBox.Text.ToString(), out ClientEffect))
            {
                MessageBox.Show("You need to specify a numeric value for ClientEffect.");
                return false;
            }

            if (Util.IsEmpty(IcontextBox.Text))
            {
                IcontextBox.Text = "0";
            }
            int Icon;
            if (!Int32.TryParse(IcontextBox.Text.ToString(), out Icon))
            {
                MessageBox.Show("You need to specify a numeric value for Icon.");
                return false;
            }

            if (Util.IsEmpty(RangetextBox.Text))
            {
                RangetextBox.Text = "0";
            }
            int Range;
            if (!Int32.TryParse(RangetextBox.Text.ToString(), out Range))
            {
                MessageBox.Show("You need to specify a numeric value for Range.");
                return false;
            }

            if (Util.IsEmpty(PowertextBox.Text))
            {
                PowertextBox.Text = "0";
            }
            int Power;
            if (!Int32.TryParse(PowertextBox.Text.ToString(), out Power))
            {
                MessageBox.Show("You need to specify a numeric value for Power.");
                return false;
            }

            if (Util.IsEmpty(CastTimetextBox.Text))
            {
                CastTimetextBox.Text = "0";
            }
            double CastTime;
            if (!Double.TryParse(CastTimetextBox.Text.ToString(), out CastTime))
            {
                MessageBox.Show("You need to specify a double value for CastTime.");
                return false;
            }

            if (Util.IsEmpty(DamagetextBox.Text))
            {
                DamagetextBox.Text = "0";
            }
            double Damage;
            if (!Double.TryParse(DamagetextBox.Text.ToString(), out Damage))
            {
                MessageBox.Show("You need to specify a double value for Damage.");
                return false;
            }

            if (Util.IsEmpty(DurationtextBox.Text))
            {
                DurationtextBox.Text = "0";
            }
            int Duration;
            if (!Int32.TryParse(DurationtextBox.Text.ToString(), out Duration))
            {
                MessageBox.Show("You need to specify a numeric value for Duration.");
                return false;
            }

            if (Util.IsEmpty(FrequencytextBox.Text))
            {
                FrequencytextBox.Text = "0";
            }
            int Frequency;
            if (!Int32.TryParse(FrequencytextBox.Text.ToString(), out Frequency))
            {
                MessageBox.Show("You need to specify a numeric value for Frequency.");
                return false;
            }

            if (Util.IsEmpty(PulsetextBox.Text))
            {
                PulsetextBox.Text = "0";
            }
            int Pulse;
            if (!Int32.TryParse(PulsetextBox.Text.ToString(), out Pulse))
            {
                MessageBox.Show("You need to specify a numeric value for Pulse.");
                return false;
            }

            if (Util.IsEmpty(PulsePowertextBox.Text))
            {
                PulsePowertextBox.Text = "0";
            }
            int PulsePower;
            if (!Int32.TryParse(PulsePowertextBox.Text.ToString(), out PulsePower))
            {
                MessageBox.Show("You need to specify a numeric value for PulsePower.");
                return false;
            }

            if (Util.IsEmpty(RadiustextBox.Text))
            {
                RadiustextBox.Text = "0";
            }
            int Radius;
            if (!Int32.TryParse(RadiustextBox.Text.ToString(), out Radius))
            {
                MessageBox.Show("You need to specify a numeric value for Radius.");
                return false;
            }

            if (Util.IsEmpty(RecastDelaytextBox.Text))
            {
                RecastDelaytextBox.Text = "0";
            }
            int RecastDelay;
            if (!Int32.TryParse(RecastDelaytextBox.Text.ToString(), out RecastDelay))
            {
                MessageBox.Show("You need to specify a numeric value for RecastDelay.");
                return false;
            }

            if (Util.IsEmpty(ResurrectHealthtextBox.Text))
            {
                ResurrectHealthtextBox.Text = "0";
            }
            int ResurrectHealth;
            if (!Int32.TryParse(ResurrectHealthtextBox.Text.ToString(), out ResurrectHealth))
            {
                MessageBox.Show("You need to specify a numeric value for ResurrectHealth.");
                return false;
            }

            if (Util.IsEmpty(ResurrectManatextBox.Text))
            {
                ResurrectManatextBox.Text = "0";
            }
            int ResurrectMana;
            if (!Int32.TryParse(ResurrectManatextBox.Text.ToString(), out ResurrectMana))
            {
                MessageBox.Show("You need to specify a numeric value for ResurrectMana.");
                return false;
            }

            if (Util.IsEmpty(ValuetextBox.Text))
            {
                ValuetextBox.Text = "0";
            }
            double Value;
            if (!Double.TryParse(ValuetextBox.Text.ToString(), out Value))
            {
                MessageBox.Show("You need to specify a numeric value for Value.");
                return false;
            }

            if (Util.IsEmpty(ConcentrationtextBox.Text))
            {
                ConcentrationtextBox.Text = "0";
            }
            int Concentration;
            if (!Int32.TryParse(ConcentrationtextBox.Text.ToString(), out Concentration))
            {
                MessageBox.Show("You need to specify a numeric value for Concentration.");
                return false;
            }

            if (Util.IsEmpty(LifeDrainReturntextBox.Text))
            {
                LifeDrainReturntextBox.Text = "0";
            }
            int LifeDrainReturn;
            if (!Int32.TryParse(LifeDrainReturntextBox.Text.ToString(), out LifeDrainReturn))
            {
                MessageBox.Show("You need to specify a numeric value for LifeDrainReturn.");
                return false;
            }

            if (Util.IsEmpty(AmnesiaChancetextBox.Text))
            {
                AmnesiaChancetextBox.Text = "0";
            }
            int AmnesiaChance;
            if (!Int32.TryParse(AmnesiaChancetextBox.Text.ToString(), out AmnesiaChance))
            {
                MessageBox.Show("You need to specify a numeric value for AmnesiaChance.");
                return false;
            }

            if (Util.IsEmpty(InstrumentRequirementtextBox.Text))
            {
                InstrumentRequirementtextBox.Text = "0";
            }
            int InstrumentRequirement;
            if (!Int32.TryParse(InstrumentRequirementtextBox.Text.ToString(), out InstrumentRequirement))
            {
                MessageBox.Show("You need to specify a numeric value for InstrumentRequirement.");
                return false;
            }

            if (Util.IsEmpty(SpellGrouptextBox.Text))
            {
                SpellGrouptextBox.Text = "0";
            }
            int SpellGroup;
            if (!Int32.TryParse(SpellGrouptextBox.Text.ToString(), out SpellGroup))
            {
                MessageBox.Show("You need to specify a numeric value for SpellGroup.");
                return false;
            }

            if (Util.IsEmpty(EffectGrouptextBox.Text))
            {
                EffectGrouptextBox.Text = "0";
            }
            int EffectGroup;
            if (!Int32.TryParse(EffectGrouptextBox.Text.ToString(), out EffectGroup))
            {
                MessageBox.Show("You need to specify a numeric value for EffectGroup.");
                return false;
            }

            if (Util.IsEmpty(SubSpellIDtextBox.Text))
            {
                SubSpellIDtextBox.Text = "0";
            }
            int SubSpellID;
            if (!Int32.TryParse(SubSpellIDtextBox.Text.ToString(), out SubSpellID))
            {
                MessageBox.Show("You need to specify a numeric value for SubSpellID.");
                return false;
            }

            if (Util.IsEmpty(SharedTimerGrouptextBox.Text))
            {
                SharedTimerGrouptextBox.Text = "0";
            }
            int SharedTimerGroup;
            if (!Int32.TryParse(SharedTimerGrouptextBox.Text.ToString(), out SharedTimerGroup))
            {
                MessageBox.Show("You need to specify a numeric value for SharedTimerGroup.");
                return false;
            }
            if (Util.IsEmpty(NametextBox.Text))
            {
                MessageBox.Show("You need to specify a name for this spell.");
                return false;
            }
            if (Util.IsEmpty(DescriptionTextBox.Text))
            {
                DescriptionTextBox.Text = "";
            }
            if (Util.IsEmpty(Message1richTextBox.Text))
            {
                Message1richTextBox.Text = "";
            }
            if (Util.IsEmpty(Message2richTextBox.Text))
            {
                Message2richTextBox.Text = "";
            }
            if (Util.IsEmpty(Message3richTextBox.Text))
            {
                Message3richTextBox.Text = "";
            }
            if (Util.IsEmpty(Message4richTextBox.Text))
            {
                Message4richTextBox.Text = "";
            }
            if (Util.IsEmpty(PackageIDcomboBox.Text))
            {
                PackageIDcomboBox.Text = "";
            }
            if (DolEditor.Properties.Settings.Default.OriginsSettings)
            {
                if (Util.IsEmpty(TranslationIDtextBox.Text))
                {
                    TranslationIDtextBox.Text = "";
                }
            }
            return true;
        }

        private void dataGridSpell_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            if (MessageBox.Show("Load this spell in editor?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // user clicked yes
                this.SpellListingButton.Visible = true;
                this.AddNewSpellButton.Visible = true;
                this.ControlMenu.Visible = false;

                this.tabControl1.Show();
                this.dataGridSpell.Hide();

                this.spellIDtextBox.Text = this.dataGridSpell.Rows[dataGridSpell.CurrentCell.RowIndex].Cells["SpellID"].Value.ToString();
                this.ClientEffecttextBox.Text = this.dataGridSpell.Rows[dataGridSpell.CurrentCell.RowIndex].Cells["ClientEffect"].Value.ToString();
                this.IcontextBox.Text = this.dataGridSpell.Rows[dataGridSpell.CurrentCell.RowIndex].Cells["Icon"].Value.ToString();
                this.NametextBox.Text = this.dataGridSpell.Rows[dataGridSpell.CurrentCell.RowIndex].Cells["Name"].Value.ToString();
                this.DescriptionTextBox.Text = this.dataGridSpell.Rows[dataGridSpell.CurrentCell.RowIndex].Cells["Description"].Value.ToString();
                this.TargetcomboBox.Text = this.dataGridSpell.Rows[dataGridSpell.CurrentCell.RowIndex].Cells["Target"].Value.ToString();
                this.RangetextBox.Text = this.dataGridSpell.Rows[dataGridSpell.CurrentCell.RowIndex].Cells["Range"].Value.ToString();
                this.PowertextBox.Text = this.dataGridSpell.Rows[dataGridSpell.CurrentCell.RowIndex].Cells["Power"].Value.ToString();
                this.CastTimetextBox.Text = this.dataGridSpell.Rows[dataGridSpell.CurrentCell.RowIndex].Cells["CastTime"].Value.ToString();
                this.DamagetextBox.Text = this.dataGridSpell.Rows[dataGridSpell.CurrentCell.RowIndex].Cells["Damage"].Value.ToString();
                this.DamageTypeComboBox.Text = Util.Find_DamageType_String_Value(this.dataGridSpell.Rows[dataGridSpell.CurrentCell.RowIndex].Cells["DamageType"].Value.ToString());
                this.SpellTypecomboBox.Text = this.dataGridSpell.Rows[dataGridSpell.CurrentCell.RowIndex].Cells["Type"].Value.ToString();
                this.DurationtextBox.Text = this.dataGridSpell.Rows[dataGridSpell.CurrentCell.RowIndex].Cells["Duration"].Value.ToString();
                this.FrequencytextBox.Text = this.dataGridSpell.Rows[dataGridSpell.CurrentCell.RowIndex].Cells["Frequency"].Value.ToString();
                this.PulsetextBox.Text = this.dataGridSpell.Rows[dataGridSpell.CurrentCell.RowIndex].Cells["Pulse"].Value.ToString();
                this.PulsePowertextBox.Text = this.dataGridSpell.Rows[dataGridSpell.CurrentCell.RowIndex].Cells["PulsePower"].Value.ToString();
                this.RadiustextBox.Text = this.dataGridSpell.Rows[dataGridSpell.CurrentCell.RowIndex].Cells["Radius"].Value.ToString();
                this.RecastDelaytextBox.Text = this.dataGridSpell.Rows[dataGridSpell.CurrentCell.RowIndex].Cells["RecastDelay"].Value.ToString();
                this.ResurrectHealthtextBox.Text = this.dataGridSpell.Rows[dataGridSpell.CurrentCell.RowIndex].Cells["ResurrectHealth"].Value.ToString();
                this.ResurrectManatextBox.Text = this.dataGridSpell.Rows[dataGridSpell.CurrentCell.RowIndex].Cells["ResurrectMana"].Value.ToString();
                this.ValuetextBox.Text = this.dataGridSpell.Rows[dataGridSpell.CurrentCell.RowIndex].Cells["Value"].Value.ToString();
                this.ConcentrationtextBox.Text = this.dataGridSpell.Rows[dataGridSpell.CurrentCell.RowIndex].Cells["Concentration"].Value.ToString();
                this.LifeDrainReturntextBox.Text = this.dataGridSpell.Rows[dataGridSpell.CurrentCell.RowIndex].Cells["LifeDrainReturn"].Value.ToString();
                this.AmnesiaChancetextBox.Text = this.dataGridSpell.Rows[dataGridSpell.CurrentCell.RowIndex].Cells["AmnesiaChance"].Value.ToString();
                this.InstrumentRequirementtextBox.Text = this.dataGridSpell.Rows[dataGridSpell.CurrentCell.RowIndex].Cells["InstrumentRequirement"].Value.ToString();
                this.SpellGrouptextBox.Text = this.dataGridSpell.Rows[dataGridSpell.CurrentCell.RowIndex].Cells["SpellGroup"].Value.ToString();
                this.EffectGrouptextBox.Text = this.dataGridSpell.Rows[dataGridSpell.CurrentCell.RowIndex].Cells["EffectGroup"].Value.ToString();
                this.SubSpellIDtextBox.Text = this.dataGridSpell.Rows[dataGridSpell.CurrentCell.RowIndex].Cells["SubSpellID"].Value.ToString();
                this.MoveCastcomboBox.Text = this.dataGridSpell.Rows[dataGridSpell.CurrentCell.RowIndex].Cells["MoveCast"].Value.ToString();
                this.UninterruptiblecomboBox.Text = this.dataGridSpell.Rows[dataGridSpell.CurrentCell.RowIndex].Cells["Uninterruptible"].Value.ToString();
                this.IsPrimarycomboBox.Text = this.dataGridSpell.Rows[dataGridSpell.CurrentCell.RowIndex].Cells["IsPrimary"].Value.ToString();
                this.IsSecondarycomboBox.Text = this.dataGridSpell.Rows[dataGridSpell.CurrentCell.RowIndex].Cells["IsSecondary"].Value.ToString();
                this.AllowBoltcomboBox.Text = this.dataGridSpell.Rows[dataGridSpell.CurrentCell.RowIndex].Cells["AllowBolt"].Value.ToString();
                this.SharedTimerGrouptextBox.Text = this.dataGridSpell.Rows[dataGridSpell.CurrentCell.RowIndex].Cells["SharedTimerGroup"].Value.ToString();
                this.IsFocuscomboBox.SelectedItem = this.dataGridSpell.Rows[dataGridSpell.CurrentCell.RowIndex].Cells["IsFocus"].Value.ToString();
                this.Message1richTextBox.Text = this.dataGridSpell.Rows[dataGridSpell.CurrentCell.RowIndex].Cells["Message1"].Value.ToString();
                this.Message2richTextBox.Text = this.dataGridSpell.Rows[dataGridSpell.CurrentCell.RowIndex].Cells["Message2"].Value.ToString();
                this.Message3richTextBox.Text = this.dataGridSpell.Rows[dataGridSpell.CurrentCell.RowIndex].Cells["Message3"].Value.ToString();
                this.Message4richTextBox.Text = this.dataGridSpell.Rows[dataGridSpell.CurrentCell.RowIndex].Cells["Message4"].Value.ToString();
                this.PackageIDcomboBox.Text = this.dataGridSpell.Rows[dataGridSpell.CurrentCell.RowIndex].Cells["PackageID"].Value.ToString();

                if (DolEditor.Properties.Settings.Default.OriginsSettings)
                    this.TranslationIDtextBox.Text = this.dataGridSpell.Rows[dataGridSpell.CurrentCell.RowIndex].Cells["TranslationId"].Value.ToString();
                
                this.SaveNewbutton.Hide();
                this.Savebutton.Show();
            }
        }

        private void SaveLoadedSpell_Click(object sender, EventArgs e)
        {
            if (!ValidSpellData())
                return;

            if (MessageBox.Show("Save your modifications?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // user clicked yes
                this.dataGridSpell.ReadOnly = false;
                this.dataGridSpell.Rows[dataGridSpell.CurrentCell.RowIndex].Cells["SpellID"].Value = spellIDtextBox.Text;
                this.dataGridSpell.Rows[dataGridSpell.CurrentCell.RowIndex].Cells["ClientEffect"].Value = ClientEffecttextBox.Text;
                this.dataGridSpell.Rows[dataGridSpell.CurrentCell.RowIndex].Cells["Icon"].Value = IcontextBox.Text;

                this.dataGridSpell.Rows[dataGridSpell.CurrentCell.RowIndex].Cells["Name"].Value = NametextBox.Text;
                this.dataGridSpell.Rows[dataGridSpell.CurrentCell.RowIndex].Cells["Description"].Value = DescriptionTextBox.Text;


                this.dataGridSpell.Rows[dataGridSpell.CurrentCell.RowIndex].Cells["Target"].Value = TargetcomboBox.Text;
                this.dataGridSpell.Rows[dataGridSpell.CurrentCell.RowIndex].Cells["Range"].Value = RangetextBox.Text;
                this.dataGridSpell.Rows[dataGridSpell.CurrentCell.RowIndex].Cells["Power"].Value = PowertextBox.Text;
                this.dataGridSpell.Rows[dataGridSpell.CurrentCell.RowIndex].Cells["CastTime"].Value = CastTimetextBox.Text;
                this.dataGridSpell.Rows[dataGridSpell.CurrentCell.RowIndex].Cells["Damage"].Value = DamagetextBox.Text;
                this.dataGridSpell.Rows[dataGridSpell.CurrentCell.RowIndex].Cells["DamageType"].Value = Util.Find_DamageType_Value(DamageTypeComboBox.Text);

                this.dataGridSpell.Rows[dataGridSpell.CurrentCell.RowIndex].Cells["Type"].Value = SpellTypecomboBox.Text;
                this.dataGridSpell.Rows[dataGridSpell.CurrentCell.RowIndex].Cells["Duration"].Value = DurationtextBox.Text;
                this.dataGridSpell.Rows[dataGridSpell.CurrentCell.RowIndex].Cells["Frequency"].Value = FrequencytextBox.Text;
                this.dataGridSpell.Rows[dataGridSpell.CurrentCell.RowIndex].Cells["Pulse"].Value = PulsetextBox.Text;
                this.dataGridSpell.Rows[dataGridSpell.CurrentCell.RowIndex].Cells["PulsePower"].Value = PulsePowertextBox.Text;
                this.dataGridSpell.Rows[dataGridSpell.CurrentCell.RowIndex].Cells["Radius"].Value = RadiustextBox.Text;

                this.dataGridSpell.Rows[dataGridSpell.CurrentCell.RowIndex].Cells["RecastDelay"].Value = RecastDelaytextBox.Text;
                this.dataGridSpell.Rows[dataGridSpell.CurrentCell.RowIndex].Cells["ResurrectHealth"].Value = ResurrectHealthtextBox.Text;
                this.dataGridSpell.Rows[dataGridSpell.CurrentCell.RowIndex].Cells["ResurrectMana"].Value = ResurrectManatextBox.Text;
                this.dataGridSpell.Rows[dataGridSpell.CurrentCell.RowIndex].Cells["Value"].Value = ValuetextBox.Text;
                this.dataGridSpell.Rows[dataGridSpell.CurrentCell.RowIndex].Cells["Concentration"].Value = ConcentrationtextBox.Text;
                this.dataGridSpell.Rows[dataGridSpell.CurrentCell.RowIndex].Cells["LifeDrainReturn"].Value = LifeDrainReturntextBox.Text;

                this.dataGridSpell.Rows[dataGridSpell.CurrentCell.RowIndex].Cells["AmnesiaChance"].Value = AmnesiaChancetextBox.Text;
                this.dataGridSpell.Rows[dataGridSpell.CurrentCell.RowIndex].Cells["InstrumentRequirement"].Value = InstrumentRequirementtextBox.Text;
                this.dataGridSpell.Rows[dataGridSpell.CurrentCell.RowIndex].Cells["SpellGroup"].Value = SpellGrouptextBox.Text;
                this.dataGridSpell.Rows[dataGridSpell.CurrentCell.RowIndex].Cells["EffectGroup"].Value = EffectGrouptextBox.Text;
                this.dataGridSpell.Rows[dataGridSpell.CurrentCell.RowIndex].Cells["SubSpellID"].Value = SubSpellIDtextBox.Text;
                this.dataGridSpell.Rows[dataGridSpell.CurrentCell.RowIndex].Cells["MoveCast"].Value = MoveCastcomboBox.Text;

                this.dataGridSpell.Rows[dataGridSpell.CurrentCell.RowIndex].Cells["Uninterruptible"].Value = UninterruptiblecomboBox.Text;
                this.dataGridSpell.Rows[dataGridSpell.CurrentCell.RowIndex].Cells["IsPrimary"].Value = IsPrimarycomboBox.Text;
                this.dataGridSpell.Rows[dataGridSpell.CurrentCell.RowIndex].Cells["IsSecondary"].Value = IsSecondarycomboBox.Text;
                this.dataGridSpell.Rows[dataGridSpell.CurrentCell.RowIndex].Cells["AllowBolt"].Value = AllowBoltcomboBox.Text;
                this.dataGridSpell.Rows[dataGridSpell.CurrentCell.RowIndex].Cells["SharedTimerGroup"].Value = SharedTimerGrouptextBox.Text;
                this.dataGridSpell.Rows[dataGridSpell.CurrentCell.RowIndex].Cells["IsFocus"].Value = IsFocuscomboBox.Text;

                this.dataGridSpell.Rows[dataGridSpell.CurrentCell.RowIndex].Cells["Message1"].Value = Message1richTextBox.Text;
                this.dataGridSpell.Rows[dataGridSpell.CurrentCell.RowIndex].Cells["Message2"].Value = Message2richTextBox.Text;
                this.dataGridSpell.Rows[dataGridSpell.CurrentCell.RowIndex].Cells["Message3"].Value = Message3richTextBox.Text;
                this.dataGridSpell.Rows[dataGridSpell.CurrentCell.RowIndex].Cells["Message4"].Value = Message4richTextBox.Text;

                this.dataGridSpell.Rows[dataGridSpell.CurrentCell.RowIndex].Cells["PackageID"].Value = PackageIDcomboBox.Text;

                if (DolEditor.Properties.Settings.Default.OriginsSettings)
                    this.dataGridSpell.Rows[dataGridSpell.CurrentCell.RowIndex].Cells["TranslationID"].Value = TranslationIDtextBox.Text;

                this.Validate();
                this.SpellbindingSource.EndEdit();

                try
                {
                    SpelldataAdapter.Update(SpellDatatable);
                }
                catch (MySqlException s)
                {
                    MessageBox.Show(s.Message);
                }

                this.dataGridSpell.ReadOnly = true;
                this.Savebutton.Hide();
                this.SaveNewbutton.Hide();
                this.SpellListingButton.Visible = false;
                this.AddNewSpellButton.Visible = true;
                this.ControlMenu.Visible = true;
                this.dataGridSpell.Show();
            }
        }

        private void SaveNewSpell_Click(object sender, EventArgs e)
        {
            if (!ValidSpellData())
                return;

            if (MessageBox.Show("Save this new spell?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                try
                {

                    // user clicked yes
                    MySqlDataAdapter NewSpellVerifdataAdapter = new MySqlDataAdapter();
                    string selectCommand = "select * from spell  where spellid = '" + spellIDtextBox.Text.ToString() + "'";
                    // Create a new data adapter based on the specified query.
                    NewSpellVerifdataAdapter = new MySqlDataAdapter(selectCommand, Util.Connection);
                    // Create a command builder to generate SQL update, insert, and 
                    // delete commands based on selectCommand. These are used to 
                    // update the database.
                    MySqlCommandBuilder commandBuilderSpellIDData = new MySqlCommandBuilder(NewSpellVerifdataAdapter);
                    DataTable SpellIDData = new DataTable();
                    SpellIDData.Clear();
                    // Populate a new data table.
                    SpellIDData.Locale = System.Globalization.CultureInfo.InvariantCulture;
                    NewSpellVerifdataAdapter.Fill(SpellIDData);
                    if (SpellIDData.Rows.Count > 0)
                    {
                        this.spellIDtextBox.Text = Util.Find_Free_SpellID().ToString();
                        MessageBox.Show("The SpellID defined for this spell is not anymore free.Your data was not updated. You need to save your spell again.");
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

                        DataRow datarow = SpellDatatable.NewRow();

                        datarow["Spell_ID"] = str;
                        datarow["SpellID"] = spellIDtextBox.Text;
                        datarow["ClientEffect"] = ClientEffecttextBox.Text;
                        datarow["Icon"] = IcontextBox.Text;
                        datarow["Name"] = NametextBox.Text;
                        datarow["Description"] = DescriptionTextBox.Text;
                        datarow["Target"] = TargetcomboBox.Text;
                        datarow["Range"] = RangetextBox.Text;
                        datarow["Power"] = PowertextBox.Text;
                        datarow["CastTime"] = CastTimetextBox.Text;
                        datarow["Damage"] = DamagetextBox.Text;
                        datarow["DamageType"] = Util.Find_DamageType_Value(DamageTypeComboBox.Text);
                        datarow["Type"] = SpellTypecomboBox.Text;
                        datarow["Duration"] = DurationtextBox.Text;
                        datarow["Frequency"] = FrequencytextBox.Text;
                        datarow["Pulse"] = PulsetextBox.Text;
                        datarow["PulsePower"] = PulsePowertextBox.Text;
                        datarow["Radius"] = RadiustextBox.Text;
                        datarow["RecastDelay"] = RecastDelaytextBox.Text;
                        datarow["ResurrectHealth"] = ResurrectHealthtextBox.Text;
                        datarow["ResurrectMana"] = ResurrectManatextBox.Text;
                        datarow["Value"] = ValuetextBox.Text;
                        datarow["Concentration"] = ConcentrationtextBox.Text;
                        datarow["LifeDrainReturn"] = LifeDrainReturntextBox.Text;
                        datarow["AmnesiaChance"] = AmnesiaChancetextBox.Text;
                        datarow["Message1"] = Message1richTextBox.Text;
                        datarow["Message2"] = Message2richTextBox.Text;
                        datarow["Message3"] = Message3richTextBox.Text;
                        datarow["Message4"] = Message4richTextBox.Text;
                        datarow["InstrumentRequirement"] = InstrumentRequirementtextBox.Text;
                        datarow["SpellGroup"] = SpellGrouptextBox.Text;
                        datarow["EffectGroup"] = EffectGrouptextBox.Text;
                        datarow["SubSpellID"] = SubSpellIDtextBox.Text;
                        datarow["MoveCast"] = Util.Find_Bool_Value(MoveCastcomboBox.Text);
                        datarow["Uninterruptible"] = Util.Find_Bool_Value(UninterruptiblecomboBox.Text);
                        datarow["IsPrimary"] = Util.Find_Bool_Value(IsPrimarycomboBox.Text);
                        datarow["IsSecondary"] = Util.Find_Bool_Value(IsSecondarycomboBox.Text);
                        datarow["AllowBolt"] = Util.Find_Bool_Value(AllowBoltcomboBox.Text);
                        datarow["SharedTimerGroup"] = SharedTimerGrouptextBox.Text;
                        datarow["PackageID"] = PackageIDcomboBox.Text;
                        datarow["IsFocus"] = Util.Find_Bool_Value(IsFocuscomboBox.Text);

                        if (DolEditor.Properties.Settings.Default.OriginsSettings)
                            datarow["TranslationId"] = TranslationIDtextBox.Text;

                        SpellDatatable.Rows.Add(datarow);

                        this.Validate();
                        this.SpellbindingSource.EndEdit();
                        this.SpelldataAdapter.Update(SpellDatatable);

                        this.SpellListingButton.Visible = false;
                        this.AddNewSpellButton.Visible = true;
                        this.ControlMenu.Visible = true;
                        this.Savebutton.Hide();
                        this.SaveNewbutton.Hide();
                        this.tabControl1.Hide();
                        this.dataGridSpell.Show();
                    }
                }
                catch (MySqlException s)
                {
                    MessageBox.Show(s.Message);
                }
            }
        }

        private bool ValidLineXSpellData()
        {

            if (Util.IsEmpty(LineNameAddLineXSpellcomboBox.Text))
            {
                MessageBox.Show("You need to select a LineName.");
                return false; ;
            }
            if (Util.IsEmpty(spellIDtextBox.Text))
            {
                MessageBox.Show("You need to specify a SpellID on the selected spell.");
                return false;
            }
            return true;
        }

        private void AddLineXSpell_Click(object sender, EventArgs e)
        {
            if (!ValidLineXSpellData())
                return;

            if (MessageBox.Show("Add this LineXSpell?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                long i = 1;
                foreach (byte b in Guid.NewGuid().ToByteArray())
                {
                    i *= ((int)b + 1);
                }
                i -= DateTime.Now.Ticks;
                string str = "Dol_Server_Editor_" + i.ToString();

                DataRow datarow = linexspell.NewRow();

                datarow["LineXSpell_ID"] = str;
                datarow["LineName"] = LineNameAddLineXSpellcomboBox.Text;//.Replace("'", "''");
                datarow["SpellID"] = spellIDtextBox.Text;
                datarow["Level"] = LinexSpellAddLevelNumericUpDown.Value;
                datarow["PackageID"] = PackageIDAddLineXSpellcomboBox.Text;

                linexspell.Rows.Add(datarow);

                this.Validate();
                this.LineXSpellbindingSource.EndEdit();

                try
                {
                    LineXSpelldataAdapter.Update(linexspell);
                }
                catch (MySqlException s)
                {
                    MessageBox.Show(s.Message);
                }
            }
        }

        private void LineXSpellbindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete this LineXSpell?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Validate();
                this.LineXSpellbindingSource.EndEdit();

                try
                {
                    LineXSpelldataAdapter.Update(linexspell);
                }
                catch (MySqlException s)
                {
                    MessageBox.Show(s.Message);
                }
            }
            GetLineXSpellData("select * from linexspell where spellid='" + spellIDtextBox.Text.ToString() + "'");
        }

        private void TranslationID_TextChanged(object sender, EventArgs e)
        {
            if (!DolEditor.Properties.Settings.Default.OriginsSettings)
                return;

            GetLanguageSpellData("SELECT * FROM languagespell WHERE translationid='" + this.TranslationIDtextBox.Text.ToString() + "'");
            return;
        }

        private bool ValidLanguageSpellData()
        {
            if (!DolEditor.Properties.Settings.Default.OriginsSettings)
                return false;

            if (Util.IsEmpty(LanguageSpellLAnguageChoicecomboBox.Text))
            {
                MessageBox.Show("You need to specify a Language for this languagespell.");
                return false;
            }
            if (Util.IsEmpty(TranslationIDtextBox.Text))
            {
                MessageBox.Show("The loaded spell don't have a translationid defined.");
                return false;
            }
            if (Util.IsEmpty(LanguageSpellNametextBox.Text))
            {
                MessageBox.Show("You need to specify a Name for this languagespell.");
                return false;
            }
            if (Util.IsEmpty(LanguageSpellDescriptionrichTextBox.Text))
            {
                LanguageSpellDescriptionrichTextBox.Text = "";
            }
            if (Util.IsEmpty(LanguageSpellMessage1richTextBox.Text))
            {
                LanguageSpellMessage1richTextBox.Text = "";
            }
            if (Util.IsEmpty(LanguageSpellMessage2richTextBox.Text))
            {
                LanguageSpellMessage2richTextBox.Text = "";
            }
            if (Util.IsEmpty(LanguageSpellMessage3richTextBox.Text))
            {
                LanguageSpellMessage3richTextBox.Text = "";
            }
            if (Util.IsEmpty(LanguageSpellMessage4richTextBox.Text))
            {
                LanguageSpellMessage4richTextBox.Text = "";
            }
            if (Util.IsEmpty(LanguageSpellTagtextBox.Text))
            {
                LanguageSpellMessage3richTextBox.Text = "";
            }
            return true;
        }

        private void AddLanguageSpell_Click(object sender, EventArgs e)
        {
            if (!ValidLanguageSpellData())
                return;

            if (MessageBox.Show("Add this LanguageStyle?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                long i = 1;
                foreach (byte b in Guid.NewGuid().ToByteArray())
                {
                    i *= ((int)b + 1);
                }
                i -= DateTime.Now.Ticks;
                string str = "Dol_Server_Editor_" + i.ToString();

                DataRow datarow = languagespell.NewRow();

                datarow["LanguageSpell_ID"] = str;
                datarow["Language"] = LanguageSpellLAnguageChoicecomboBox.Text;
                datarow["TranslationId"] = TranslationIDtextBox.Text;
                datarow["Name"] = LanguageSpellNametextBox.Text;
                datarow["Description"] = LanguageSpellDescriptionrichTextBox.Text;
                datarow["Message1"] = LanguageSpellMessage1richTextBox.Text;
                datarow["Message2"] = LanguageSpellMessage2richTextBox.Text;
                datarow["Message3"] = LanguageSpellMessage3richTextBox.Text;
                datarow["Message4"] = LanguageSpellMessage4richTextBox.Text;
                datarow["Tag"] = LanguageSpellTagtextBox.Text;

                languagespell.Rows.Add(datarow);

                this.Validate();
                this.LanguageSpellbindingSource.EndEdit();

                try
                {
                    LanguageSpelldataAdapter.Update(languagespell);
                }
                catch (MySqlException s)
                {
                    MessageBox.Show(s.Message);
                }
            }
        }

        private void LanguageSpellbindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (!DolEditor.Properties.Settings.Default.OriginsSettings)
                return;

            if (MessageBox.Show("Delete this LanguageSpell?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Validate();
                this.LanguageSpellbindingSource.EndEdit();

                try
                {
                    LanguageSpelldataAdapter.Update(languagespell);
                }
                catch (MySqlException s)
                {
                    MessageBox.Show(s.Message);
                }
            }
            GetLanguageSpellData("select * from languagespell where translationid='" + TranslationIDtextBox.Text.ToString() + "'");
        }

        private void LineXSpelldataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            this.Validate();
            this.LineXSpellbindingSource.EndEdit();

            try
            {
                LineXSpelldataAdapter.Update(linexspell);
            }
            catch (MySqlException s)
            {
                MessageBox.Show(s.Message);
            }
        }

        private void LanguageSpelldataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (!DolEditor.Properties.Settings.Default.OriginsSettings)
                return;

            this.Validate();
            this.LanguageSpellbindingSource.EndEdit();

            try
            {
                LanguageSpelldataAdapter.Update(languagespell);
            }
            catch (MySqlException s)
            {
                MessageBox.Show(s.Message);
            }
        }

        private void SpellNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete this Spell?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SpellbindingSource.RemoveCurrent();
                this.Validate();
                this.SpellbindingSource.EndEdit();

                try
                {
                    this.SpelldataAdapter.Update(SpellDatatable);
                }
                catch (MySqlException s)
                {
                    MessageBox.Show(s.Message);
                }
            }

            string select = "SELECT * FROM spell";
            bool add = false; ;
            if (this.SearchSpellIDtextBox.Text != "")
            {
                select += " where spellid='" + this.SearchSpellIDtextBox.Text + "'";
                add = true;
            }

            if (this.SearchBySpellNametextBox.Text != "")
            {
                if (add)
                    select += " and Name like '%" + this.SearchBySpellNametextBox.Text + "%'";
                else
                {
                    select += " where Name like '%" + this.SearchBySpellNametextBox.Text + "%'";
                    add = true;
                }
            }
            string SpellHandler = " All";
            if (this.SpellHandlerSearchcomboBox.Text != null)
                SpellHandler = this.SpellHandlerSearchcomboBox.Text.ToString(); //SpellHandler

            if (SpellHandler != " All")
            {
                if (add)
                    select += " and type='" + SpellHandler + "'";
                else
                {
                    select += " where type='" + SpellHandler + "'";
                    add = true;
                }
            }
            string LineID = " All";
            if (LineNameSpellSearchcomboBox.Text != null)
                LineID = this.LineNameSpellSearchcomboBox.Text.ToString(); //Spec Key Name

            if (LineID != " All")
            {
                if (add)
                    select += " and spell.spellid IN (SELECT spellid FROM linexspell WHERE linename='" + LineID + "')";
                else
                {
                    select += " where spell.spellid IN (SELECT spellid FROM linexspell WHERE linename='" + LineID + "')";
                    add = true;
                }
            }

            GetData(select);
        }

        private void spellID_TextChanged(object sender, EventArgs e)
        {
            GetLineXSpellData("select * from linexspell where spellid='" + spellIDtextBox.Text.ToString() + "'");
        }

        private void SpellListing_Click(object sender, EventArgs e)
        {
            this.Savebutton.Hide();
            this.SaveNewbutton.Hide();
            this.SpellListingButton.Visible = false;
            this.AddNewSpellButton.Visible = true;
            this.ControlMenu.Visible = true;
            this.tabControl1.Hide();
            this.dataGridSpell.Show();
        }

        private void AddNewSpell_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Become to add a new spell?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // user clicked yes
                this.dataGridSpell.Hide();
                long i = 1;
                foreach (byte b in Guid.NewGuid().ToByteArray())
                {
                    i *= ((int)b + 1);
                }
                i -= DateTime.Now.Ticks;
                string str = "Dol_Server_Editor_" + i.ToString();
                this.spellIDtextBox.Text = Util.Find_Free_SpellID().ToString();
                this.tabControl1.Show();
                this.Savebutton.Hide();
                this.SaveNewbutton.Show();
                this.SpellListingButton.Visible = true;
                this.AddNewSpellButton.Visible = false;
                this.ControlMenu.Visible = false;
            }
        }

        private void Searchbutton_Click(object sender, EventArgs e)
        {
            {
                string select = "SELECT * FROM spell";
                bool add = false; ;
                if (this.SearchSpellIDtextBox.Text != "")
                {
                    select += " where spellid='" + this.SearchSpellIDtextBox.Text + "'";
                    add = true;
                }

                if (this.SearchBySpellNametextBox.Text != "")
                {
                    if (add)
                        select += " and Name like '%" + this.SearchBySpellNametextBox.Text + "%'";
                    else
                    {
                        select += " where Name like '%" + this.SearchBySpellNametextBox.Text + "%'";
                        add = true;
                    }
                }
                string SpellHandler = " All";
                if (this.SpellHandlerSearchcomboBox.Text != null)
                    SpellHandler = this.SpellHandlerSearchcomboBox.Text.ToString(); //SpellHandler

                if (SpellHandler != " All")
                {
                    if (add)
                        select += " and type='" + SpellHandler + "'";
                    else
                    {
                        select += " where type='" + SpellHandler + "'";
                        add = true;
                    }
                }
                string LineID = " All";
                if (LineNameSpellSearchcomboBox.Text != null)
                    LineID = this.LineNameSpellSearchcomboBox.Text.ToString(); //Spec Key Name

                if (LineID != " All")
                {
                    if (add)
                        select += " and spell.spellid IN (SELECT spellid FROM linexspell WHERE linename='" + LineID + "')";
                    else
                    {
                        select += " where spell.spellid IN (SELECT spellid FROM linexspell WHERE linename='" + LineID + "')";
                        add = true;
                    }
                }

                GetData(select);
            }
        }
    }
}
