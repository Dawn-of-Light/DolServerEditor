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
using System.Drawing;

namespace Origins_Editor
{
    public partial class LoadArea : Form
    {
        MySqlDataAdapter AreadataAdapter = new MySqlDataAdapter();
        MySqlCommandBuilder AreacommandBuilder = new MySqlCommandBuilder();
        MySqlDataAdapter AreaLanguagedataAdapter = new MySqlDataAdapter();
        MySqlCommandBuilder AreaLanguagecommandBuilder = new MySqlCommandBuilder();

        public LoadArea()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.AreaListingButton.Visible = false;
            this.Savebutton.Hide();
            this.SaveNewbutton.Hide();
            this.EditAreaControl.Hide();


            this.LanguagecomboBox.SelectedIndex = 0;
            this.CanBroadCastcomboBox.SelectedIndex = 0;
            this.CheckLoscomboBox.SelectedIndex = 0;

            this.ClassTypeSearchcomboBox.SelectedIndex = 0;

            this.GetData("select * from area");
            this.AreadataGridView.AutoGenerateColumns = true;
            this.AreadataGridView.AllowUserToDeleteRows = true;
            this.AreadataGridView.Columns["Area_ID"].Visible = false;
            this.AreadataGridView.DataSource = this.AreabindingSource;

            this.GetAreaLanguageData("select * from languagearea where translationid='" + this.TranslationIDtextBox.Text.ToString() + "'");
            this.AreaLanguagedataGridView.AutoGenerateColumns = true;
            this.AreaLanguagedataGridView.AllowUserToDeleteRows = true;
            this.AreaLanguagedataGridView.Columns["LanguageArea_ID"].Visible = false;
            this.AreaLanguagedataGridView.DataSource = this.AreaLanguagebindingSource;
        }

        private void GetData(string selectCommand)
        {
            try
            {
                MySqlConnection connection3 = new MySqlConnection("server=" + DolEditor.Properties.Settings.Default.ServerIP + ";uid=" + DolEditor.Properties.Settings.Default.Username + ";pwd=" + DolEditor.Properties.Settings.Default.Password + ";database=" + DolEditor.Properties.Settings.Default.DatabaseName + "");

                // Create a new data adapter based on the specified query.
                this.AreadataAdapter = new MySqlDataAdapter(selectCommand, connection3);
                // Create a command builder to generate SQL update, insert, and 
                // delete commands based on selectCommand. These are used to 
                // update the database.
                this.AreacommandBuilder = new MySqlCommandBuilder(this.AreadataAdapter);
                this.AreaDatatable.Clear();
                // Populate a new data table and bind it to the BindingSource.
                this.AreaDatatable.Locale = System.Globalization.CultureInfo.InvariantCulture;
                this.AreadataAdapter.Fill(this.AreaDatatable);
                this.AreabindingSource.DataSource = this.AreaDatatable;

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
        }

        private void GetAreaLanguageData(string selectCommand)
        {
            try
            {
                MySqlConnection connection3 = new MySqlConnection("server=" + DolEditor.Properties.Settings.Default.ServerIP + ";uid=" + DolEditor.Properties.Settings.Default.Username + ";pwd=" + DolEditor.Properties.Settings.Default.Password + ";database=" + DolEditor.Properties.Settings.Default.DatabaseName + "");

                // Create a new data adapter based on the specified query.
                this.AreaLanguagedataAdapter = new MySqlDataAdapter(selectCommand, connection3);
                // Create a command builder to generate SQL update, insert, and 
                // delete commands based on selectCommand. These are used to 
                // update the database.
                this.AreaLanguagecommandBuilder = new MySqlCommandBuilder(this.AreaLanguagedataAdapter);
                this.AreaLanguageDatatable.Clear();
                // Populate a new data table and bind it to the BindingSource.
                this.AreaLanguageDatatable.Locale = System.Globalization.CultureInfo.InvariantCulture;
                this.AreaLanguagedataAdapter.Fill(this.AreaLanguageDatatable);
                this.AreaLanguagebindingSource.DataSource = this.AreaLanguageDatatable;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
        }

        private void LanguageAreadataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            this.Validate();
            this.AreaLanguagebindingSource.EndEdit();

            try
            {
                this.AreaLanguagedataAdapter.Update(this.AreaLanguageDatatable);
            }
            catch (MySqlException s)
            {
                System.Windows.MessageBox.Show(s.Message);
            }
        }

        private void AreadataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            if (MessageBox.Show("Load this area in editor?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // user clicked yes
                this.EditAreaControl.Show();
                this.AreadataGridView.Hide();

                this.DescriptiontextBox.Text = this.AreadataGridView.Rows[AreadataGridView.CurrentCell.RowIndex].Cells["Description"].Value.ToString();
                this.XtextBox.Text = this.AreadataGridView.Rows[AreadataGridView.CurrentCell.RowIndex].Cells["X"].Value.ToString();
                this.YtextBox.Text = this.AreadataGridView.Rows[AreadataGridView.CurrentCell.RowIndex].Cells["Y"].Value.ToString();
                this.ZtextBox.Text = this.AreadataGridView.Rows[AreadataGridView.CurrentCell.RowIndex].Cells["Z"].Value.ToString();
                this.RadiustextBox.Text = this.AreadataGridView.Rows[AreadataGridView.CurrentCell.RowIndex].Cells["Radius"].Value.ToString();
                this.RegiontextBox.Text = this.AreadataGridView.Rows[AreadataGridView.CurrentCell.RowIndex].Cells["Region"].Value.ToString();
                this.ClassTypecomboBox.Text = this.AreadataGridView.Rows[AreadataGridView.CurrentCell.RowIndex].Cells["ClassType"].Value.ToString();
                this.CanBroadCastcomboBox.Text = this.AreadataGridView.Rows[AreadataGridView.CurrentCell.RowIndex].Cells["CanBroadcast"].Value.ToString();
                this.SoundtextBox.Text = this.AreadataGridView.Rows[AreadataGridView.CurrentCell.RowIndex].Cells["Sound"].Value.ToString();
                this.CheckLoscomboBox.Text = this.AreadataGridView.Rows[AreadataGridView.CurrentCell.RowIndex].Cells["CheckLOS"].Value.ToString();
                this.PointstextBox.Text = this.AreadataGridView.Rows[AreadataGridView.CurrentCell.RowIndex].Cells["Points"].Value.ToString();
                this.TranslationIDtextBox.Text = this.AreadataGridView.Rows[AreadataGridView.CurrentCell.RowIndex].Cells["TranslationID"].Value.ToString();

                this.SaveNewbutton.Hide();
                this.Savebutton.Show();

                this.ControlMenu.Visible = false;
                this.AreaListingButton.Visible = true;
                this.AddAreaButton.Visible = true;
            }
        }

        private void SaveLoadedArea_Click(object sender, EventArgs e)
        {
            if (!ValidAreaData())
                return;
            if (MessageBox.Show("Save your modifications?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // user clicked yes
                this.AreadataGridView.ReadOnly = false;
                this.AreadataGridView.Refresh();
                this.AreadataGridView.Rows[AreadataGridView.CurrentCell.RowIndex].Cells["Description"].Value = this.DescriptiontextBox.Text;
                this.AreadataGridView.Rows[AreadataGridView.CurrentCell.RowIndex].Cells["X"].Value = this.XtextBox.Text;
                this.AreadataGridView.Rows[AreadataGridView.CurrentCell.RowIndex].Cells["Y"].Value = this.YtextBox.Text;
                this.AreadataGridView.Rows[AreadataGridView.CurrentCell.RowIndex].Cells["Z"].Value = this.ZtextBox.Text;
                this.AreadataGridView.Rows[AreadataGridView.CurrentCell.RowIndex].Cells["Radius"].Value = this.RadiustextBox.Text;
                this.AreadataGridView.Rows[AreadataGridView.CurrentCell.RowIndex].Cells["Region"].Value = this.RegiontextBox.Text;
                this.AreadataGridView.Rows[AreadataGridView.CurrentCell.RowIndex].Cells["ClassType"].Value = this.ClassTypecomboBox.Text;
                this.AreadataGridView.Rows[AreadataGridView.CurrentCell.RowIndex].Cells["CanBroadcast"].Value = this.CanBroadCastcomboBox.Text;
                this.AreadataGridView.Rows[AreadataGridView.CurrentCell.RowIndex].Cells["Sound"].Value = this.SoundtextBox.Text;
                this.AreadataGridView.Rows[AreadataGridView.CurrentCell.RowIndex].Cells["CheckLOS"].Value = this.CheckLoscomboBox.Text;
                this.AreadataGridView.Rows[AreadataGridView.CurrentCell.RowIndex].Cells["Points"].Value = this.PointstextBox.Text;
                this.AreadataGridView.Rows[AreadataGridView.CurrentCell.RowIndex].Cells["TranslationID"].Value = this.TranslationIDtextBox.Text;

                this.Validate();
                this.AreabindingSource.EndEdit();

                try
                {
                    this.AreadataAdapter.Update(AreaDatatable);
                }
                catch (MySqlException s)
                {
                    System.Windows.MessageBox.Show(s.Message);
                }

                this.AreadataGridView.ReadOnly = true;
                this.EditAreaControl.Hide();
                this.AreadataGridView.Show();
                this.ControlMenu.Visible = true;
                this.AddAreaButton.Visible = true;
                this.AreaListingButton.Visible = false;
                this.Savebutton.Hide();
            }
        }

        private bool ValidAreaData()
        {
            if (Util.IsEmpty(DescriptiontextBox.Text))
            {
                MessageBox.Show("WARNING: You need to provide a Description value.");
                return false;
            }
            if (Util.IsEmpty(XtextBox.Text))
            {
                MessageBox.Show("WARNING: You need to provide a X value.");
                return false;
            }
            else
            {
                int X;
                try
                {
                    X = int.Parse(XtextBox.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("WARNING: X value is not suitable.");
                    return false;
                }
            }
            if (Util.IsEmpty(YtextBox.Text))
            {
                MessageBox.Show("WARNING: You need to provide a Y value.");
                return false;
            }
            else
            {
                int Y;
                try
                {
                    Y = int.Parse(YtextBox.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("WARNING: Y value is not suitable.");
                    return false;
                }
            }
            if (Util.IsEmpty(ZtextBox.Text))
            {
                MessageBox.Show("WARNING: You need to provide a Z value.");
                return false;
            }
            else
            {
                int Z;
                try
                {
                    Z = int.Parse(ZtextBox.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("WARNING: Z value is not suitable.");
                    return false;
                }
            }
            if (Util.IsEmpty(RadiustextBox.Text))
            {
                MessageBox.Show("WARNING: You need to provide a radius value.");
                return false;
            }
            else
            {
                int Radius;
                try
                {
                    Radius = int.Parse(RadiustextBox.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("WARNING: Radius value is not suitable.");
                    return false;
                }
            }
            if (Util.IsEmpty(RegiontextBox.Text))
            {
                MessageBox.Show("WARNING: You need to provide a Region value.");
                return false;
            }
            else
            {
                ushort Region;
                try
                {
                    Region = Convert.ToUInt16(RegiontextBox.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show(" WARNING: Region value is not suitable.");
                    return false;
                }
            }
            if (Util.IsEmpty(ClassTypecomboBox.Text))
            {
                MessageBox.Show("WARNING: You need to provide a ClassType value.");
                return false;
            }
            return true;
        }

        private void SaveNewArea_Click(object sender, EventArgs e)
        {
            if (!ValidAreaData())
                return;

            if (MessageBox.Show("Save this new area?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // user clicked yes
                MySqlConnection connection15 = new MySqlConnection("server=" + DolEditor.Properties.Settings.Default.ServerIP + ";uid=" + DolEditor.Properties.Settings.Default.Username + ";pwd=" + DolEditor.Properties.Settings.Default.Password + ";database=" + DolEditor.Properties.Settings.Default.DatabaseName + "");

                long i = 1;
                foreach (byte b in Guid.NewGuid().ToByteArray())
                {
                    i *= ((int)b + 1);
                }
                i -= DateTime.Now.Ticks;
                string str = "Origins_Editor_" + i.ToString();

                DataRow datarow = this.AreaDatatable.NewRow();

                datarow["Area_ID"] = str;
                datarow["Description"] = this.DescriptiontextBox.Text;
                datarow["X"] = this.XtextBox.Text;
                datarow["Y"] = this.YtextBox.Text;
                datarow["Z"] = this.ZtextBox.Text;
                datarow["Radius"] = this.RadiustextBox.Text;
                datarow["Region"] = this.RegiontextBox.Text;
                datarow["ClassType"] = this.ClassTypecomboBox.Text;
                datarow["CanBroadcast"] = Util.Find_Bool_Value(CanBroadCastcomboBox.Text.ToString());
                datarow["Sound"] = this.SoundtextBox.Text;
                datarow["CheckLOS"] = Util.Find_Bool_Value(CheckLoscomboBox.Text.ToString());
                datarow["Points"] = this.PointstextBox.Text;
                datarow["TranslationId"] = this.TranslationIDtextBox.Text;

                this.AreaDatatable.Rows.Add(datarow);

                this.Validate();
                this.AreabindingSource.EndEdit();

                try
                {
                    this.AreadataAdapter.Update(AreaDatatable);
                }
                catch (MySqlException s)
                {
                    System.Windows.MessageBox.Show(s.Message);
                }

                this.EditAreaControl.Hide();
                this.AreadataGridView.Show();
                this.ControlMenu.Visible = true;
                this.AddAreaButton.Visible = true;
                this.AreaListingButton.Visible = false;
                this.SaveNewbutton.Hide();
            }
        }

        private void AreaNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete this Area?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Validate();
                this.AreabindingSource.EndEdit();

                try
                {
                    this.AreadataAdapter.Update(AreaDatatable);
                }
                catch (MySqlException s)
                {
                    System.Windows.MessageBox.Show(s.Message);
                }
            }

            string select = "SELECT * FROM area";
            bool add = false; ;
            if (this.SearchByDescriptiontextBox.Text != "")
            {
                select += " where Description like '%" + this.SearchByDescriptiontextBox.Text + "%'";
                add = true;
            }

            string ClassType = "All";
            if (ClassTypeSearchcomboBox.Text != null && ClassTypeSearchcomboBox.Text != "")
                ClassType = this.ClassTypeSearchcomboBox.Text.ToString(); //ClassID

            if (ClassType != "All")
            {
                if (add)
                    select += " and ClassType='" + ClassType + "'";
                else
                {
                    select += " where ClassType='" + ClassType + "'";
                    add = true;
                }
            }


            GetData(select);
        }

        private void TranslationID_TextChanged(object sender, EventArgs e)
        {
            this.GetAreaLanguageData("SELECT * FROM languagearea WHERE translationid='" + this.TranslationIDtextBox.Text.ToString() + "'");
            this.AreaLanguagedataGridView.Refresh();
            return;
        }

        private void LanguageAreaSaveNew_Click(object sender, EventArgs e)
        {
            if (Util.IsEmpty(this.LanguagecomboBox.Text))
            {
                MessageBox.Show("You need to specify a Language for this language area.");
                return;
            }
            if (Util.IsEmpty(this.TranslationIDtextBox.Text))
            {
                MessageBox.Show("The loaded area don't have a translationid defined.");
                return;
            }
            if (Util.IsEmpty(this.DescriptionLanguageAreatextBox.Text))
            {
                MessageBox.Show("You need to specify a Description for this area.");
                return;
            }
            if (Util.IsEmpty(this.ScreenDescriptiontextBox.Text))
            {
                this.ScreenDescriptiontextBox.Text = "";
            }
            if (Util.IsEmpty(this.TagtextBox.Text))
            {
                this.TagtextBox.Text = "";
            }
            if (MessageBox.Show("Add this Area Language?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                long i = 1;
                foreach (byte b in Guid.NewGuid().ToByteArray())
                {
                    i *= ((int)b + 1);
                }
                i -= DateTime.Now.Ticks;
                string str = "Origins_Editor_" + i.ToString();

                DataRow datarow = this.AreaLanguageDatatable.NewRow();
                datarow["LanguageArea_ID"] = str;
                datarow["Language"] = this.LanguagecomboBox.Text;
                datarow["TranslationId"] = this.TranslationIDtextBox.Text;
                datarow["Description"] = this.DescriptiontextBox.Text;
                datarow["ScreenDescription"] = this.ScreenDescriptiontextBox.Text;
                datarow["Tag"] = this.TagtextBox.Text;
                AreaLanguageDatatable.Rows.Add(datarow);

                this.Validate();
                this.AreaLanguagebindingSource.EndEdit();

                try
                {
                    this.AreaLanguagedataAdapter.Update(this.AreaLanguageDatatable);
                }
                catch (MySqlException s)
                {
                    System.Windows.MessageBox.Show(s.Message);
                }
            }
        }

        private void LanguageAreaNavigatorDeleteItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete this Language area?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Validate();
                this.AreaLanguagebindingSource.EndEdit();

                try
                {
                    this.AreaLanguagedataAdapter.Update(this.AreaLanguageDatatable);
                }
                catch (MySqlException s)
                {
                    System.Windows.MessageBox.Show(s.Message);
                }
            }
            this.GetAreaLanguageData("SELECT * FROM languagearea WHERE translationid='" + this.TranslationIDtextBox.Text.ToString() + "'");
        }

        private void AddNewBattleGround_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Become to add a new area?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // user clicked yes
                this.AreadataGridView.Hide();
                this.Savebutton.Hide();
                this.SaveNewbutton.Show();
                this.EditAreaControl.Show();
                this.AddAreaButton.Visible = false;
                this.AreaListingButton.Visible = true;
                this.ControlMenu.Visible = false;
            }
        }

        private void ZoneListing_Click(object sender, EventArgs e)
        {
            this.EditAreaControl.Hide();
            this.AreadataGridView.Show();
            this.Savebutton.Hide();
            this.SaveNewbutton.Hide();
            this.AreaListingButton.Visible = false;
            this.AddAreaButton.Visible = true;
            this.ControlMenu.Visible = true;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Delete this Language area?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Validate();
                this.AreaLanguagebindingSource.EndEdit();

                try
                {
                    this.AreaLanguagedataAdapter.Update(this.AreaLanguageDatatable);
                }
                catch (MySqlException s)
                {
                    System.Windows.MessageBox.Show(s.Message);
                }
            }
        }

        private void Searchbutton_Click(object sender, EventArgs e)
        {
            string select = "SELECT * FROM area";
            bool add = false; ;
            if (this.SearchByDescriptiontextBox.Text != "")
            {
                select += " where Description like '%" + this.SearchByDescriptiontextBox.Text + "%'";
                add = true;
            }

            string ClassType = "All";
            if (ClassTypeSearchcomboBox.Text != null && ClassTypeSearchcomboBox.Text != "")
                ClassType = this.ClassTypeSearchcomboBox.Text.ToString();

            if (ClassType != "All")
            {
                if (add)
                    select += " and ClassType='" + ClassType + "'";
                else
                {
                    select += " where ClassType='" + ClassType + "'";
                    add = true;
                }
            }


            GetData(select);
        }
    }
}
