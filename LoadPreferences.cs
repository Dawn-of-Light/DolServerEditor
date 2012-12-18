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
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DOL_Editor
{
    public partial class LoadPreferences : Form
    {
        private bool connectionState = false;

        public LoadPreferences()
        {
            InitializeComponent();

            if (DolEditor.Properties.Settings.Default.OriginsSettings)
                this.OriginsDatabaseSettingscheckBox.Checked = true;
            else
                this.OriginsDatabaseSettingscheckBox.Checked = false;

            if (VerifyConnectivity())
                connectionState = true;
        }

        private void VerifyConnectivity_Tick(object sender, EventArgs e)
        {
            VerifyConnectivity();
        }

        private bool VerifyConnectivity()
        {
            bool Flag = false;
            try
            {
                using (MySqlConnection con = new MySqlConnection("server=" + ServerIPtextBox.Text + ";port=" + PortNumbertextBox.Text + ";uid=" + DatabaseUsertextBox.Text + ";pwd=" + DatabasePWDtextBox.Text + ";database=" + DatabaseNametextBox.Text + ""))
                {
                    con.Open();
                }
            }
            catch (MySqlException s)
            {
                Flag = true;
                TestConnectionbutton.BackColor = Color.Red; 
                MessageBox.Show(s.Message);
            }
            finally
            {
                if (Flag == false)
                {
                    TestConnectionbutton.BackColor = Color.Green;
                }
            }
            if (Flag == false)
                return true;

            return false;
        }

        private void SavePreferences_Click(object sender, EventArgs e)
        {
            if (this.OriginsDatabaseSettingscheckBox.Checked == true)
                DolEditor.Properties.Settings.Default.OriginsSettings = true;
            else
                DolEditor.Properties.Settings.Default.OriginsSettings = false;

            if (this.ServerIPtextBox.Text != DolEditor.Properties.Settings.Default.ServerIP)
                DolEditor.Properties.Settings.Default.ServerIP = this.ServerIPtextBox.Text;

            if (Convert.ToInt32(this.PortNumbertextBox.Text) != DolEditor.Properties.Settings.Default.PortNumber)
                DolEditor.Properties.Settings.Default.PortNumber = Convert.ToInt32(this.PortNumbertextBox.Text);

            if (this.DatabaseNametextBox.Text != DolEditor.Properties.Settings.Default.DatabaseName)
                DolEditor.Properties.Settings.Default.DatabaseName = this.DatabaseNametextBox.Text;

            if (this.DatabaseUsertextBox.Text != DolEditor.Properties.Settings.Default.Username)
                DolEditor.Properties.Settings.Default.Username = this.DatabaseUsertextBox.Text;

            if (this.DatabasePWDtextBox.Text != DolEditor.Properties.Settings.Default.Password)
                DolEditor.Properties.Settings.Default.Password = this.DatabasePWDtextBox.Text;

            DolEditor.Properties.Settings.Default.Save();

            this.Close();

            if (!connectionState && VerifyConnectivity())
            {
                if (MessageBox.Show("Dol Editor Need to be restarted", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) == DialogResult.OK)
                {
                    Application.Restart();
                    Environment.Exit(Environment.ExitCode);
                }
            }
        }
    }
}
