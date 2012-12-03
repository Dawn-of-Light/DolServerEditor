using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace Origins_Editor
{
    public partial class LoadFaction : Form
    {
        private MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder();
        private MySqlDataAdapter FactiondataAdapter;
        private MySqlDataAdapter LinkedFactiondataAdapter;
        private MySqlDataAdapter LanguageFactiondataAdapter;
        private DataTable FactionDatatable = new DataTable();
        private DataTable LinkedFactionDatatable = new DataTable();
        private DataTable LanguageFactionDatatable = new DataTable();
        private DataTable LinkedFactionData = new DataTable();
        private DataTable FactionData = new DataTable();
        private DataTable SearchFactionData = new DataTable();

        public LoadFaction()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FactiondataGridView.AutoGenerateColumns = true;
            this.FactiondataGridView.AllowUserToDeleteRows = true;

            this.GetFactionData("select * from faction");

            this.FactiondataGridView.Columns["Faction_ID"].Visible = false;

            this.LanguageChoicecomboBox.SelectedIndex = 0;
            this.IsFriendcomboBox.SelectedIndex = 0;
            this.FactionIDLinkedFactioncomboBox.SelectedIndex = 0;
            this.LinkedFactionIDcomboBox.SelectedIndex = 0;

            this.EditFactionControl.Hide();

            this.FactionListingButton.Visible = false;
            this.Savebutton.Hide();
            this.SaveNewbutton.Hide();

            if (DolEditor.Properties.Settings.Default.OriginsSettings)
            {
                TranslationIDtextBox.Visible = true;
                TranslationIDlabel.Visible = true;
                TranslationgroupBox.Visible = true;
            }

            try
            {
                Util.Connection.Open();

                //Name ComboBox Datatable
                MySqlDataAdapter FactionNamedataAdapter = new MySqlDataAdapter("select * from faction ORDER BY name ASC", Util.Connection);
                MySqlCommandBuilder FactionNameDatacommandBuilder = new MySqlCommandBuilder(FactionNamedataAdapter);
                
                LinkedFactionData = new DataTable();

                FactionNamedataAdapter.Fill(LinkedFactionData);
                this.FactionIDLinkedFactioncomboBox.DisplayMember = "Name";
                this.FactionIDLinkedFactioncomboBox.ValueMember = "ID";
                this.FactionIDLinkedFactioncomboBox.DataSource = LinkedFactionData;

                FactionData = new DataTable();

                FactionNamedataAdapter.Fill(FactionData);
                this.LinkedFactionIDcomboBox.DisplayMember = "Name";
                this.LinkedFactionIDcomboBox.ValueMember = "ID";
                this.LinkedFactionIDcomboBox.DataSource = FactionData;

                SearchFactionData = new DataTable();

                FactionNamedataAdapter.Fill(SearchFactionData);
                this.FactionNameSearchcomboBox.DisplayMember = "Name";
                this.FactionNameSearchcomboBox.ValueMember = "ID";
                this.FactionNameSearchcomboBox.DataSource = SearchFactionData;


                DataRow datarow = SearchFactionData.NewRow();
                datarow["Name"] = "All";
                SearchFactionData.Rows.Add(datarow);
                SearchFactionData.DefaultView.Sort = "Name ASC";
                this.FactionNameSearchcomboBox.Text = "All";
                Util.Connection.Close();

            }
            catch (MySqlException s)
            {
                MessageBox.Show(s.Message);
            }

        }

        private void GetFactionData(string selectCommand)
        {
            try
            {
                // Create a new data adapter based on the specified query.
                this.FactiondataAdapter = new MySqlDataAdapter(selectCommand, Util.Connection);
                // Create a command builder to generate SQL update, insert, and 
                // delete commands based on selectCommand. These are used to 
                // update the database.
                commandBuilder = new MySqlCommandBuilder(this.FactiondataAdapter);
                this.FactionDatatable.Clear();
                // Populate a new data table and bind it to the BindingSource.
                this.FactionDatatable.Locale = System.Globalization.CultureInfo.InvariantCulture;
                this.FactiondataAdapter.Fill(this.FactionDatatable);
                this.FactionbindingSource.DataSource = this.FactionDatatable;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
        }

        private void GetLinkedFactionData(string selectCommand)
        {
            try
            {
                // Create a new data adapter based on the specified query.
                this.LinkedFactiondataAdapter = new MySqlDataAdapter(selectCommand, Util.Connection);
                // Create a command builder to generate SQL update, insert, and 
                // delete commands based on selectCommand. These are used to 
                // update the database.
                commandBuilder = new MySqlCommandBuilder(this.LinkedFactiondataAdapter);
                this.LinkedFactionDatatable.Clear();
                // Populate a new data table and bind it to the BindingSource.
                this.LinkedFactionDatatable.Locale = System.Globalization.CultureInfo.InvariantCulture;
                this.LinkedFactiondataAdapter.Fill(this.LinkedFactionDatatable);
                this.LinkedFactionbindingSource.DataSource = this.LinkedFactionDatatable;

                this.LinkedFactiondataGridView.AutoGenerateColumns = true;
                this.LinkedFactiondataGridView.AllowUserToDeleteRows = true;
                this.LinkedFactiondataGridView.Columns["Linkedfaction_ID"].Visible = false;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
        }

        private void GetLanguageFactionData(string selectCommand)
        {
            try
            {
                // Create a new data adapter based on the specified query.
                this.LanguageFactiondataAdapter = new MySqlDataAdapter(selectCommand, Util.Connection);
                // Create a command builder to generate SQL update, insert, and 
                // delete commands based on selectCommand. These are used to 
                // update the database.
                commandBuilder = new MySqlCommandBuilder(this.LanguageFactiondataAdapter);
                this.LanguageFactionDatatable.Clear();
                // Populate a new data table and bind it to the BindingSource.
                this.LanguageFactionDatatable.Locale = System.Globalization.CultureInfo.InvariantCulture;
                this.LanguageFactiondataAdapter.Fill(this.LanguageFactionDatatable);
                this.TranslationbindingSource.DataSource = this.LanguageFactionDatatable;
                this.TranslationdataGridView.AutoGenerateColumns = true;
                this.TranslationdataGridView.AllowUserToDeleteRows = true;
                this.TranslationdataGridView.Columns["Languagefaction_ID"].Visible = false;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
        }

        private void LinkedFactiondataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            this.Validate();
            this.LinkedFactionbindingSource.EndEdit();

            try
            {
                this.LinkedFactiondataAdapter.Update(this.LinkedFactionDatatable);
            }
            catch (MySqlException s)
            {
                MessageBox.Show(s.Message);
            }
        }

        private void LanguagedataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            this.Validate();
            this.TranslationbindingSource.EndEdit();

            try
            {
                this.LanguageFactiondataAdapter.Update(this.LanguageFactionDatatable);
            }
            catch (MySqlException s)
            {
                MessageBox.Show(s.Message);
            }
        }

        private void LoadLinkedFactionbutton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Load LinkedFaction and Translation for this faction?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (this.FactiondataGridView.Rows[this.FactiondataGridView.CurrentCell.RowIndex] != null)
                {
                    string factionid = this.FactiondataGridView.Rows[this.FactiondataGridView.CurrentCell.RowIndex].Cells["id"].Value.ToString();

                    this.GetLinkedFactionData("select * from linkedfaction where factionId='" + factionid + "'");
                    if (DolEditor.Properties.Settings.Default.OriginsSettings)
                    {
                        string translationid = this.FactiondataGridView.Rows[this.FactiondataGridView.CurrentCell.RowIndex].Cells["translationid"].Value.ToString();

                        if (!Util.IsEmpty(translationid))
                            this.GetLanguageFactionData("select * from languagefaction where translationId='" + translationid + "'");
                    }
                }
                else
                    MessageBox.Show("Select a Faction first");
            }
        }

        private void SearchFactionbutton_Click(object sender, EventArgs e)
        {

            string select = "SELECT * FROM faction";
            bool add = false; ;
            if (!Util.IsEmpty( this.FactionIDSearchtextBox.Text))
            {
                select += " where id='" + this.FactionIDSearchtextBox.Text + "'";
                add = true;
            }

            string FactionID = "All";
            if (this.FactionNameSearchcomboBox.Text != null && this.FactionNameSearchcomboBox.Text != "All")
                FactionID = this.FactionNameSearchcomboBox.SelectedValue.ToString();

            if (FactionID != "All")
            {
                if (add)
                    select += " and id='" + FactionID + "'";
                else
                {
                    select += " where id='" + FactionID + "'";
                    add = true;
                }
            }
            GetFactionData(select);
        }

        private void FactionbindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Delete this Faction?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Validate();
                this.FactionbindingSource.EndEdit();

                try
                {
                    this.FactiondataAdapter.Update(FactionDatatable);
                }
                catch (MySqlException s)
                {
                    MessageBox.Show(s.Message);
                }
            }

            string select = "SELECT * FROM faction";
            bool add = false; ;
            if (!Util.IsEmpty(this.FactionIDSearchtextBox.Text))
            {
                select += " where id='" + this.FactionIDSearchtextBox.Text + "'";
                add = true;
            }

            string FactionID = "All";
            if (this.FactionNameSearchcomboBox.Text != null && this.FactionNameSearchcomboBox.Text != "All")
                FactionID = this.FactionNameSearchcomboBox.SelectedValue.ToString();

            if (FactionID != "All")
            {
                if (add)
                    select += " and id='" + FactionID + "'";
                else
                {
                    select += " where id='" + FactionID + "'";
                    add = true;
                }
            }
            GetFactionData(select);
        }

        private void LinkedFactionbindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Delete this Linked Faction?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Validate();
                this.LinkedFactionbindingSource.EndEdit();

                try
                {
                    this.LinkedFactiondataAdapter.Update(LinkedFactionDatatable);
                }
                catch (MySqlException s)
                {
                    MessageBox.Show(s.Message);
                }
            }
            string factionid = this.FactiondataGridView.Rows[this.FactiondataGridView.CurrentCell.RowIndex].Cells["id"].Value.ToString();

            this.GetLinkedFactionData("select * from linkedfaction where factionId='" + factionid + "'");

        }

        private void FactionTranslationbindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (!DolEditor.Properties.Settings.Default.OriginsSettings)
                return;

            if (MessageBox.Show("Delete this Faction Language?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Validate();
                this.TranslationbindingSource.EndEdit();

                try
                {
                    this.LanguageFactiondataAdapter.Update(LanguageFactionDatatable);
                }
                catch (MySqlException s)
                {
                    MessageBox.Show(s.Message);
                }
            }
            string translationid = this.FactiondataGridView.Rows[this.FactiondataGridView.CurrentCell.RowIndex].Cells["translationid"].Value.ToString();

            if (!Util.IsEmpty(translationid))
                this.GetLanguageFactionData("select * from languagefaction where translationId='" + translationid + "'");
        }

        private void FactiondataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Load this faction in editor?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (this.FactiondataGridView.Rows[this.FactiondataGridView.CurrentCell.RowIndex] != null)
                {
                    this.EditFactionControl.Show();
                    this.FactiondataGridView.Hide();

                    string factionid = this.FactiondataGridView.Rows[this.FactiondataGridView.CurrentCell.RowIndex].Cells["id"].Value.ToString();
                    FactionIDtextBox.Text = factionid;


                    FactionNametextBox.Text = this.FactiondataGridView.Rows[this.FactiondataGridView.CurrentCell.RowIndex].Cells["Name"].Value.ToString();
                    TranslationIDtextBox.Text = this.FactiondataGridView.Rows[this.FactiondataGridView.CurrentCell.RowIndex].Cells["Translationid"].Value.ToString();
                    BaseAggroLevelnumericUpDown.Value = Convert.ToInt16(this.FactiondataGridView.Rows[this.FactiondataGridView.CurrentCell.RowIndex].Cells["baseaggrolevel"].Value);

                    this.GetLinkedFactionData("select * from linkedfaction where factionId='" + factionid + "'");
                    if (DolEditor.Properties.Settings.Default.OriginsSettings)
                    {
                        string translationid = this.FactiondataGridView.Rows[this.FactiondataGridView.CurrentCell.RowIndex].Cells["translationid"].Value.ToString();

                        if (!Util.IsEmpty(translationid))
                            this.GetLanguageFactionData("select * from languagefaction where translationId='" + translationid + "'");
                    }
                    this.SaveNewbutton.Hide();
                    this.Savebutton.Show();
                    this.ControlMenu.Visible = false;
                    this.FactionListingButton.Visible = true;
                    this.AddFactionButton.Visible = true;
                    this.FactionIDLinkedFactioncomboBox.Text = this.FactiondataGridView.Rows[this.FactiondataGridView.CurrentCell.RowIndex].Cells["Name"].Value.ToString();
                }
                else
                    MessageBox.Show("Select a Faction first");
            }
        }

        private void FactionListingButton_Click(object sender, EventArgs e)
        {
            this.Savebutton.Hide();
            this.SaveNewbutton.Hide();
            this.FactionListingButton.Visible = false;
            this.AddFactionButton.Visible = true;
            this.ControlMenu.Visible = true;
            this.EditFactionControl.Hide();
            this.FactiondataGridView.Show();

            //Enable add languagefaction and linked faction add
            this.groupBox2.Visible = true;
            this.LinkedFactionbindingNavigator.Visible = true;
            this.LinkedFactiondataGridView.Visible = true;
            if (DolEditor.Properties.Settings.Default.OriginsSettings)
                this.TranslationgroupBox.Visible = true;
        }

        private void SaveNewbutton_Click(object sender, EventArgs e)
        {
            if (!ValidFactionData())
                return;

            if (MessageBox.Show("Save this new faction?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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

                        DataRow datarow = FactionDatatable.NewRow();
                        int id = Util.Find_Free_FactionID();

                        datarow["Faction_ID"] = id;
                        datarow["ID"] = FactionIDtextBox.Text;
                        datarow["Name"] = FactionNametextBox.Text;
                        datarow["BaseAggroLevel"] = BaseAggroLevelnumericUpDown.Value;

                        if (DolEditor.Properties.Settings.Default.OriginsSettings)
                            datarow["TranslationId"] = TranslationIDtextBox.Text;

                        FactionDatatable.Rows.Add(datarow);

                        this.Validate();
                        this.FactionbindingSource.EndEdit();
                        this.FactiondataAdapter.Update(this.FactionDatatable);

                        this.FactionListingButton.Visible = false;
                        this.AddFactionButton.Visible = true;
                        this.ControlMenu.Visible = true;
                        this.Savebutton.Hide();
                        this.SaveNewbutton.Hide();
                        this.EditFactionControl.Hide();
                        this.FactiondataGridView.Show();
                        //Enable add languagefaction and linked facation add
                        this.groupBox2.Visible = true;
                        this.LinkedFactionbindingNavigator.Visible = true;
                        this.LinkedFactiondataGridView.Visible = true;
                        if (DolEditor.Properties.Settings.Default.OriginsSettings)
                            this.TranslationgroupBox.Visible = true;
                }
                catch (Exception s)
                {
                    MessageBox.Show(s.Message);
                }
            }
        }

        private bool ValidFactionData()
        {

            if (Util.IsEmpty(FactionNametextBox.Text))
            {
                MessageBox.Show("You need to set a Name for this faction.");
                return false; ;
            }
            return true;
        }

        private void AddFactionButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Become to add a new faction?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // user clicked yes
                this.FactiondataGridView.Hide();
                long i = 1;
                foreach (byte b in Guid.NewGuid().ToByteArray())
                {
                    i *= ((int)b + 1);
                }
                i -= DateTime.Now.Ticks;
                string str = "Dol_Server_Editor_" + i.ToString();
                this.FactionIDtextBox.Text = Util.Find_Free_FactionID().ToString();
                this.EditFactionControl.Show();
                this.Savebutton.Hide();
                this.SaveNewbutton.Show();
                this.FactionListingButton.Visible = true;
                this.AddFactionButton.Visible = false;
                this.ControlMenu.Visible = false;

                //Disable add languagefaction and linked facation add
                this.groupBox2.Visible = false;
                this.LinkedFactionbindingNavigator.Visible = false;
                this.LinkedFactiondataGridView.Visible = false;
                this.TranslationgroupBox.Visible = false;
            }
        }

        private void SaveLoadedFaction_Click(object sender, EventArgs e)
        {
            if (!ValidFactionData())
                return;

            if (MessageBox.Show("Save your modifications?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // user clicked yes
                this.FactiondataGridView.ReadOnly = false;
                this.FactiondataGridView.Rows[FactiondataGridView.CurrentCell.RowIndex].Cells["Name"].Value = FactionNametextBox.Text;
                this.FactiondataGridView.Rows[FactiondataGridView.CurrentCell.RowIndex].Cells["baseaggrolevel"].Value = BaseAggroLevelnumericUpDown.Value;

                if (DolEditor.Properties.Settings.Default.OriginsSettings)
                    this.FactiondataGridView.Rows[FactiondataGridView.CurrentCell.RowIndex].Cells["TranslationID"].Value = TranslationIDtextBox.Text;

                this.Validate();
                this.FactionbindingSource.EndEdit();

                try
                {
                    FactiondataAdapter.Update(FactionDatatable);
                }
                catch (Exception s)
                {
                    MessageBox.Show(s.Message);
                }

                this.FactiondataGridView.ReadOnly = true;
                this.Savebutton.Hide();
                this.SaveNewbutton.Hide();
                this.FactionListingButton.Visible = false;
                this.AddFactionButton.Visible = true;
                this.ControlMenu.Visible = true;
                this.FactiondataGridView.Show();
            }
        }

        private bool ValidLinkedFactionData()
        {
            //All is comboBox
            return true;
        }

        private void SaveLinkedFactionbutton_Click(object sender, EventArgs e)
        {
            if (!ValidLinkedFactionData())
                return;

            if (MessageBox.Show("Save your Linked faction?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                long i = 1;
                foreach (byte b in Guid.NewGuid().ToByteArray())
                {
                    i *= ((int)b + 1);
                }
                i -= DateTime.Now.Ticks;
                string str = "Dol_Server_Editor_" + i.ToString();

                DataRow LinkedFactiondatarow = LinkedFactionDatatable.NewRow();

                LinkedFactiondatarow["Linkedfaction_id"] = str;
                LinkedFactiondatarow["factionid"] = FactionIDLinkedFactioncomboBox.SelectedValue;
                LinkedFactiondatarow["linkedfactionid"] = LinkedFactionIDcomboBox.SelectedValue;
                LinkedFactiondatarow["isfriend"] = Util.Find_Bool_Value(IsFriendcomboBox.Text);

                LinkedFactionDatatable.Rows.Add(LinkedFactiondatarow);

                this.Validate();
                this.LinkedFactionbindingSource.EndEdit();

                try
                {
                    LinkedFactiondataAdapter.Update(LinkedFactionDatatable);
                }
                catch (MySqlException s)
                {
                    MessageBox.Show(s.Message);
                }
            }
        }

        private bool ValidFactionLanguageData()
        {

            if (Util.IsEmpty(TranslationIDAddtextBox.Text))
            {
                MessageBox.Show("You need to set a TranslationID for this faction language.");
                return false;
            }
            if (Util.IsEmpty(NameTranslationAddtextBox.Text))
            {
                MessageBox.Show("You need to set a Name for this faction language.");
                return false;
            }
            return true;
        }

        private void SaveTranslationbutton_Click(object sender, EventArgs e)
        {
            if (!ValidFactionLanguageData())
                return;

            if (MessageBox.Show("Save your faction translation?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                long i = 1;
                foreach (byte b in Guid.NewGuid().ToByteArray())
                {
                    i *= ((int)b + 1);
                }
                i -= DateTime.Now.Ticks;
                string str = "Dol_Server_Editor_" + i.ToString();

                DataRow LanguageFactiondatarow = LanguageFactionDatatable.NewRow();

                LanguageFactiondatarow["LanguageFaction_ID"] = str;
                LanguageFactiondatarow["language"] = LanguageChoicecomboBox.Text;

                if (DolEditor.Properties.Settings.Default.OriginsSettings)
                    LanguageFactiondatarow["TranslationId"] = TranslationIDAddtextBox.Text;

                LanguageFactiondatarow["Name"] = NameTranslationAddtextBox.Text;
                LanguageFactiondatarow["Tag"] = TagtextBox.Text;


                LanguageFactionDatatable.Rows.Add(LanguageFactiondatarow);

                this.Validate();
                this.TranslationbindingSource.EndEdit();

                try
                {
                    LanguageFactiondataAdapter.Update(LanguageFactionDatatable);
                }
                catch (MySqlException s)
                {
                    MessageBox.Show(s.Message);
                }
            }
        }
    }
}
