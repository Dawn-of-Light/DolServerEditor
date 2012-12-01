using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Origins_Editor
{
    public partial class LoadLootOTD : Form
    {
        private DataTable LootOTDDatatable = new DataTable();
        private MySqlDataAdapter LootOTDdataAdapter;

        public LoadLootOTD()
        {
            InitializeComponent();

            //Load Class ListView
            for (int i = 0; i < 62; i++)
            {
                string classname = Util.ClassIDToName(i.ToString());

                if (classname != "unknow class name")
                    AllowedClasslistView.Items.Add(classname);
            }
            AllowedClasslistView.Items.Add(" All");
            //Remove the first string ""
            AllowedClasslistView.Items[0].Remove();

            this.Load += new EventHandler(Form1_Load);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetLootOTD("select * from loototd");

            this.LootOTDdataGridView.AutoGenerateColumns = true;
            this.LootOTDdataGridView.AllowUserToDeleteRows = true;
            this.LootOTDdataGridView.Columns["LootOTD_ID"].Visible = false;

            if (DolEditor.Properties.Settings.Default.OriginsSettings)
                AllowedClasslistView.Visible = true;
        }

        private void GetLootOTD(string selectCommand)
        {
            try
            {
                LootOTDdataAdapter = new MySqlDataAdapter(selectCommand, Util.Connection);
                MySqlCommandBuilder commandBuilderLootOTD = new MySqlCommandBuilder(LootOTDdataAdapter);
                LootOTDDatatable = new DataTable();
                LootOTDDatatable.Clear();
                LootOTDdataAdapter.Fill(LootOTDDatatable);
                this.LootOTDbindingSource.DataSource = LootOTDDatatable;
            }
            catch (MySqlException s)
            {
                MessageBox.Show(s.Message);
            }
        }

        private bool ValidLootOTDData()
        {
            if (Util.IsEmpty(id_nbAddtextBox.Text))
            {
                MessageBox.Show(" WARNING: id_nb can't be null.");
                return false;
            }
            if (Util.IsEmpty(MobNametextBox.Text))
            {
                MessageBox.Show(" WARNING: Mob Name can't be null.");
                return false;
            }
            return true;
        }

        private void Searchbutton_Click(object sender, EventArgs e)
        {
            string select = "SELECT * FROM loototd";
            bool add = false; ;
            if (!Util.IsEmpty(this.MobNameSearchtextBox.Text))
            {
                select += " where id='" + this.MobNameSearchtextBox.Text.Replace("'", "''") + "'";
                add = true;
            }

            if (!Util.IsEmpty(this.id_nbSearchtextBox.Text))
            {
                if (add)
                    select += " and id='" + id_nbSearchtextBox.Text + "'";
                else
                {
                    select += " where id='" + id_nbSearchtextBox.Text + "'";
                    add = true;
                }
            }
            GetLootOTD(select);
        }

        private void SaveLootOTDbutton_Click(object sender, EventArgs e)
        {
            if (!ValidLootOTDData())
                return;

            if (MessageBox.Show("Save this new OTD?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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

                    DataRow datarow = LootOTDDatatable.NewRow();

                    datarow["LootOTD_ID"] = str;
                    datarow["ItemTemplateID"] = id_nbAddtextBox.Text;
                    datarow["MinLevel"] = MinLevelnumericUpDown.Value;
                    datarow["MobName"] = MobNametextBox.Text;

                    if (DolEditor.Properties.Settings.Default.OriginsSettings)
                    {
                        string allowedClassList = "";
                        bool allclass = false;
                        ListView.CheckedListViewItemCollection checkedItems = AllowedClasslistView.CheckedItems;

                        foreach (ListViewItem item in checkedItems)
                        {
                            if (item.Text == " All")
                            {
                                allowedClassList = "";
                                allclass = true;
                                break;
                            }
                            if (!allclass)
                            {
                                if (allowedClassList != "")
                                {
                                    allowedClassList = allowedClassList + ";" + Util.ClassNameToID(item.Text);
                                }
                                else
                                    allowedClassList = Util.ClassNameToID(item.Text);
                            }
                        }

                        datarow["AllowedClasses"] = allowedClassList;
                    }

                    LootOTDDatatable.Rows.Add(datarow);

                    this.Validate();
                    this.LootOTDbindingSource.EndEdit();
                    this.LootOTDdataAdapter.Update(LootOTDDatatable);

                }
                catch (MySqlException s)
                {
                    MessageBox.Show(s.Message);
                }
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete this OTD?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Validate();
                this.LootOTDbindingSource.EndEdit();

                try
                {
                    this.LootOTDdataAdapter.Update(LootOTDDatatable);
                }
                catch (MySqlException s)
                {
                    MessageBox.Show(s.Message);
                }
            }

            string select = "SELECT * FROM loototd";
            bool add = false; ;
            if (!Util.IsEmpty(this.MobNameSearchtextBox.Text))
            {
                select += " where id='" + this.MobNameSearchtextBox.Text.Replace("'", "''") + "'";
                add = true;
            }

            if (!Util.IsEmpty(this.id_nbSearchtextBox.Text))
            {
                if (add)
                    select += " and id='" + id_nbSearchtextBox.Text + "'";
                else
                {
                    select += " where id='" + id_nbSearchtextBox.Text + "'";
                    add = true;
                }
            }
            GetLootOTD(select);
        }
    }
}
