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
using System.IO;

namespace Origins_Editor
{
    public partial class MobsModelChoice : Form
    {
        private TextBox form;
        private LoadNPCTemplate loadNPCTemplateWindow= null;
        private DataGridView dataGridView1;

        public MobsModelChoice(LoadNPCTemplate NPCTemplateWindow, TextBox Form)
        {
            form = Form;
            loadNPCTemplateWindow = NPCTemplateWindow;
            InitializeComponent();
        }
        
        private void Form9_Load(object sender, EventArgs e)
        {
            List<int> l = new List<int>();
            string path = Application.StartupPath + "\\mobs\\";
            foreach (string jpg in Directory.GetFiles(path, "*.jpg"))
            {
                string id = jpg.Replace(path, "").Replace(".jpg", "");
                l.Add(int.Parse(id));
            }

            l.Sort();

            foreach (int jpg in l)
            {
                System.Drawing.Bitmap bitmap = new System.Drawing.Bitmap(path + jpg + ".jpg");
                this.dataGridView1.Rows.Add(jpg, bitmap);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Add this model?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string rowvalue = this.dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["ID"].Value.ToString();

                var split = Util.SplitCSV(loadNPCTemplateWindow.ModeltextBox.Text.ToString(), false); ;
                foreach (var spl in split)
                {
                    int id = 0;
                    int.TryParse(spl, out id);
                    if (id.ToString() == rowvalue)
                    {
                        MessageBox.Show("The NPCTemplate already contains this model.");
                        return;
                    }
                }
                string value = "";
                if (loadNPCTemplateWindow.ModeltextBox.Text != null && loadNPCTemplateWindow.ModeltextBox.Text != "")
                    value += ";" + rowvalue;
                else
                    value = rowvalue;

                loadNPCTemplateWindow.ModeltextBox.Text += value;
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            loadNPCTemplateWindow.MobsChoiceOpen = null;

            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;
        }
    }

}
