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

using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Windows.Input;

namespace DOL_Editor
{
    partial class LoadRegion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        DataTable RegionDatatable = new DataTable();
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadRegion));
            this.EditRegionControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Translationgroupbox = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.TagLanguageAddtextBox = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.LanguagecomboBox = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.NameLanguageAddtextBox = new System.Windows.Forms.TextBox();
            this.DescriptionLanguageAddtextBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.RegionTranslationbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RegionTranslationbindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.WaterLeveltextBox = new System.Windows.Forms.TextBox();
            this.ClassTypecomboBox = new System.Windows.Forms.ComboBox();
            this.ExpansioncomboBox = new System.Windows.Forms.ComboBox();
            this.IPtextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.PorttextBox = new System.Windows.Forms.TextBox();
            this.HousingEnablecomboBox = new System.Windows.Forms.ComboBox();
            this.DivingEnablecomboBox = new System.Windows.Forms.ComboBox();
            this.IsFrontiercomboBox = new System.Windows.Forms.ComboBox();
            this.RegionIDtextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.NametextBox = new System.Windows.Forms.TextBox();
            this.DescriptiontextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RegiondataGridView = new System.Windows.Forms.DataGridView();
            this.RegionbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RegionbindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ControlMenu = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchByRegionNametextBox = new System.Windows.Forms.TextBox();
            this.Classlabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ClassTypeSearchcomboBox = new System.Windows.Forms.ComboBox();
            this.SearchRegionIDtextBox = new System.Windows.Forms.TextBox();
            this.Speclabel = new System.Windows.Forms.Label();
            this.SearchFrontierscomboBox = new System.Windows.Forms.ComboBox();
            this.SaveNewbutton = new System.Windows.Forms.Button();
            this.Savebutton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RegionListingButton = new System.Windows.Forms.Button();
            this.AddRegionButton = new System.Windows.Forms.Button();
            this.EditRegionControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.Translationgroupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegionTranslationbindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegionTranslationbindingNavigator)).BeginInit();
            this.RegionTranslationbindingNavigator.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RegiondataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegionbindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegionbindingNavigator)).BeginInit();
            this.RegionbindingNavigator.SuspendLayout();
            this.ControlMenu.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // EditRegionControl
            // 
            this.EditRegionControl.Controls.Add(this.tabPage1);
            this.EditRegionControl.Location = new System.Drawing.Point(11, 93);
            this.EditRegionControl.Name = "EditRegionControl";
            this.EditRegionControl.SelectedIndex = 0;
            this.EditRegionControl.Size = new System.Drawing.Size(732, 262);
            this.EditRegionControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Translationgroupbox);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(724, 236);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Region Editor";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Translationgroupbox
            // 
            this.Translationgroupbox.Controls.Add(this.button1);
            this.Translationgroupbox.Controls.Add(this.TagLanguageAddtextBox);
            this.Translationgroupbox.Controls.Add(this.label18);
            this.Translationgroupbox.Controls.Add(this.LanguagecomboBox);
            this.Translationgroupbox.Controls.Add(this.label17);
            this.Translationgroupbox.Controls.Add(this.NameLanguageAddtextBox);
            this.Translationgroupbox.Controls.Add(this.DescriptionLanguageAddtextBox);
            this.Translationgroupbox.Controls.Add(this.label15);
            this.Translationgroupbox.Controls.Add(this.label16);
            this.Translationgroupbox.Controls.Add(this.dataGridView1);
            this.Translationgroupbox.Controls.Add(this.RegionTranslationbindingNavigator);
            this.Translationgroupbox.Location = new System.Drawing.Point(7, 109);
            this.Translationgroupbox.Name = "Translationgroupbox";
            this.Translationgroupbox.Size = new System.Drawing.Size(709, 121);
            this.Translationgroupbox.TabIndex = 19;
            this.Translationgroupbox.TabStop = false;
            this.Translationgroupbox.Text = "Translation";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(608, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 53);
            this.button1.TabIndex = 28;
            this.button1.Text = "Add Language Zone";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // TagLanguageAddtextBox
            // 
            this.TagLanguageAddtextBox.Enabled = false;
            this.TagLanguageAddtextBox.Location = new System.Drawing.Point(493, 94);
            this.TagLanguageAddtextBox.Name = "TagLanguageAddtextBox";
            this.TagLanguageAddtextBox.Size = new System.Drawing.Size(100, 20);
            this.TagLanguageAddtextBox.TabIndex = 27;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Enabled = false;
            this.label18.Location = new System.Drawing.Point(432, 98);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(26, 13);
            this.label18.TabIndex = 26;
            this.label18.Text = "Tag";
            // 
            // LanguagecomboBox
            // 
            this.LanguagecomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LanguagecomboBox.Enabled = false;
            this.LanguagecomboBox.FormattingEnabled = true;
            this.LanguagecomboBox.Items.AddRange(new object[] {
            "FR",
            "DE"});
            this.LanguagecomboBox.Location = new System.Drawing.Point(493, 13);
            this.LanguagecomboBox.Name = "LanguagecomboBox";
            this.LanguagecomboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LanguagecomboBox.Size = new System.Drawing.Size(46, 21);
            this.LanguagecomboBox.TabIndex = 25;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Enabled = false;
            this.label17.Location = new System.Drawing.Point(432, 16);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(55, 13);
            this.label17.TabIndex = 24;
            this.label17.Text = "Language";
            // 
            // NameLanguageAddtextBox
            // 
            this.NameLanguageAddtextBox.Enabled = false;
            this.NameLanguageAddtextBox.Location = new System.Drawing.Point(493, 41);
            this.NameLanguageAddtextBox.Name = "NameLanguageAddtextBox";
            this.NameLanguageAddtextBox.Size = new System.Drawing.Size(100, 20);
            this.NameLanguageAddtextBox.TabIndex = 23;
            // 
            // DescriptionLanguageAddtextBox
            // 
            this.DescriptionLanguageAddtextBox.Enabled = false;
            this.DescriptionLanguageAddtextBox.Location = new System.Drawing.Point(493, 66);
            this.DescriptionLanguageAddtextBox.Name = "DescriptionLanguageAddtextBox";
            this.DescriptionLanguageAddtextBox.Size = new System.Drawing.Size(100, 20);
            this.DescriptionLanguageAddtextBox.TabIndex = 22;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Enabled = false;
            this.label15.Location = new System.Drawing.Point(432, 44);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 13);
            this.label15.TabIndex = 20;
            this.label15.Text = "Name";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Enabled = false;
            this.label16.Location = new System.Drawing.Point(432, 69);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 13);
            this.label16.TabIndex = 21;
            this.label16.Text = "Description";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.RegionTranslationbindingSource;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(3, 44);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(423, 71);
            this.dataGridView1.TabIndex = 19;
            // 
            // RegionTranslationbindingNavigator
            // 
            this.RegionTranslationbindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.RegionTranslationbindingNavigator.CountItem = this.bindingNavigatorCountItem1;
            this.RegionTranslationbindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem1;
            this.RegionTranslationbindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.RegionTranslationbindingNavigator.Enabled = false;
            this.RegionTranslationbindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem1,
            this.bindingNavigatorMovePreviousItem1,
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorSeparator4,
            this.bindingNavigatorMoveNextItem1,
            this.bindingNavigatorMoveLastItem1,
            this.bindingNavigatorSeparator5,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem1});
            this.RegionTranslationbindingNavigator.Location = new System.Drawing.Point(3, 19);
            this.RegionTranslationbindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
            this.RegionTranslationbindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem1;
            this.RegionTranslationbindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.RegionTranslationbindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
            this.RegionTranslationbindingNavigator.Name = "RegionTranslationbindingNavigator";
            this.RegionTranslationbindingNavigator.PositionItem = this.bindingNavigatorPositionItem1;
            this.RegionTranslationbindingNavigator.Size = new System.Drawing.Size(255, 25);
            this.RegionTranslationbindingNavigator.TabIndex = 0;
            this.RegionTranslationbindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem1
            // 
            this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem1";
            this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem1.Text = "of {0}";
            this.bindingNavigatorCountItem1.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem1
            // 
            this.bindingNavigatorDeleteItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem1.Image")));
            this.bindingNavigatorDeleteItem1.Name = "bindingNavigatorDeleteItem1";
            this.bindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem1.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem1
            // 
            this.bindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem1.Image")));
            this.bindingNavigatorMoveFirstItem1.Name = "bindingNavigatorMoveFirstItem1";
            this.bindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem1.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem1
            // 
            this.bindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem1.Image")));
            this.bindingNavigatorMovePreviousItem1.Name = "bindingNavigatorMovePreviousItem1";
            this.bindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem1.Text = "Move previous";
            // 
            // bindingNavigatorSeparator3
            // 
            this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator3";
            this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem1
            // 
            this.bindingNavigatorPositionItem1.AccessibleName = "Position";
            this.bindingNavigatorPositionItem1.AutoSize = false;
            this.bindingNavigatorPositionItem1.Name = "bindingNavigatorPositionItem1";
            this.bindingNavigatorPositionItem1.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem1.Text = "0";
            this.bindingNavigatorPositionItem1.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator4
            // 
            this.bindingNavigatorSeparator4.Name = "bindingNavigatorSeparator4";
            this.bindingNavigatorSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem1
            // 
            this.bindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem1.Image")));
            this.bindingNavigatorMoveNextItem1.Name = "bindingNavigatorMoveNextItem1";
            this.bindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem1.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem1
            // 
            this.bindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem1.Image")));
            this.bindingNavigatorMoveLastItem1.Name = "bindingNavigatorMoveLastItem1";
            this.bindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem1.Text = "Move last";
            // 
            // bindingNavigatorSeparator5
            // 
            this.bindingNavigatorSeparator5.Name = "bindingNavigatorSeparator5";
            this.bindingNavigatorSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.WaterLeveltextBox);
            this.groupBox1.Controls.Add(this.ClassTypecomboBox);
            this.groupBox1.Controls.Add(this.ExpansioncomboBox);
            this.groupBox1.Controls.Add(this.IPtextBox);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.PorttextBox);
            this.groupBox1.Controls.Add(this.HousingEnablecomboBox);
            this.groupBox1.Controls.Add(this.DivingEnablecomboBox);
            this.groupBox1.Controls.Add(this.IsFrontiercomboBox);
            this.groupBox1.Controls.Add(this.RegionIDtextBox);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.NametextBox);
            this.groupBox1.Controls.Add(this.DescriptiontextBox);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(7, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(709, 97);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // WaterLeveltextBox
            // 
            this.WaterLeveltextBox.Location = new System.Drawing.Point(236, 68);
            this.WaterLeveltextBox.Name = "WaterLeveltextBox";
            this.WaterLeveltextBox.Size = new System.Drawing.Size(83, 20);
            this.WaterLeveltextBox.TabIndex = 18;
            this.WaterLeveltextBox.Text = "0";
            // 
            // ClassTypecomboBox
            // 
            this.ClassTypecomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClassTypecomboBox.FormattingEnabled = true;
            this.ClassTypecomboBox.Location = new System.Drawing.Point(550, 18);
            this.ClassTypecomboBox.Name = "ClassTypecomboBox";
            this.ClassTypecomboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ClassTypecomboBox.Size = new System.Drawing.Size(142, 21);
            this.ClassTypecomboBox.Sorted = true;
            this.ClassTypecomboBox.TabIndex = 17;
            // 
            // ExpansioncomboBox
            // 
            this.ExpansioncomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ExpansioncomboBox.FormattingEnabled = true;
            this.ExpansioncomboBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.ExpansioncomboBox.Location = new System.Drawing.Point(550, 43);
            this.ExpansioncomboBox.Name = "ExpansioncomboBox";
            this.ExpansioncomboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ExpansioncomboBox.Size = new System.Drawing.Size(38, 21);
            this.ExpansioncomboBox.Sorted = true;
            this.ExpansioncomboBox.TabIndex = 16;
            // 
            // IPtextBox
            // 
            this.IPtextBox.Location = new System.Drawing.Point(236, 17);
            this.IPtextBox.Name = "IPtextBox";
            this.IPtextBox.Size = new System.Drawing.Size(83, 20);
            this.IPtextBox.TabIndex = 15;
            this.IPtextBox.Text = "127.0.0.1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(490, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Expansion";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(490, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "ClassType";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(173, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Water Level";
            // 
            // PorttextBox
            // 
            this.PorttextBox.Location = new System.Drawing.Point(236, 43);
            this.PorttextBox.Name = "PorttextBox";
            this.PorttextBox.Size = new System.Drawing.Size(83, 20);
            this.PorttextBox.TabIndex = 14;
            this.PorttextBox.Text = "10400";
            // 
            // HousingEnablecomboBox
            // 
            this.HousingEnablecomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HousingEnablecomboBox.FormattingEnabled = true;
            this.HousingEnablecomboBox.Items.AddRange(new object[] {
            "False",
            "True"});
            this.HousingEnablecomboBox.Location = new System.Drawing.Point(422, 17);
            this.HousingEnablecomboBox.Name = "HousingEnablecomboBox";
            this.HousingEnablecomboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HousingEnablecomboBox.Size = new System.Drawing.Size(64, 21);
            this.HousingEnablecomboBox.TabIndex = 13;
            // 
            // DivingEnablecomboBox
            // 
            this.DivingEnablecomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DivingEnablecomboBox.FormattingEnabled = true;
            this.DivingEnablecomboBox.Items.AddRange(new object[] {
            "False",
            "True"});
            this.DivingEnablecomboBox.Location = new System.Drawing.Point(422, 43);
            this.DivingEnablecomboBox.Name = "DivingEnablecomboBox";
            this.DivingEnablecomboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DivingEnablecomboBox.Size = new System.Drawing.Size(64, 21);
            this.DivingEnablecomboBox.TabIndex = 12;
            // 
            // IsFrontiercomboBox
            // 
            this.IsFrontiercomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IsFrontiercomboBox.FormattingEnabled = true;
            this.IsFrontiercomboBox.Items.AddRange(new object[] {
            "False",
            "True"});
            this.IsFrontiercomboBox.Location = new System.Drawing.Point(422, 68);
            this.IsFrontiercomboBox.Name = "IsFrontiercomboBox";
            this.IsFrontiercomboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.IsFrontiercomboBox.Size = new System.Drawing.Size(64, 21);
            this.IsFrontiercomboBox.TabIndex = 11;
            // 
            // RegionIDtextBox
            // 
            this.RegionIDtextBox.Location = new System.Drawing.Point(67, 68);
            this.RegionIDtextBox.Name = "RegionIDtextBox";
            this.RegionIDtextBox.Size = new System.Drawing.Size(100, 20);
            this.RegionIDtextBox.TabIndex = 7;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(334, 71);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 13);
            this.label14.TabIndex = 10;
            this.label14.Text = "IsFrontier";
            // 
            // NametextBox
            // 
            this.NametextBox.Location = new System.Drawing.Point(67, 18);
            this.NametextBox.Name = "NametextBox";
            this.NametextBox.Size = new System.Drawing.Size(100, 20);
            this.NametextBox.TabIndex = 6;
            // 
            // DescriptiontextBox
            // 
            this.DescriptiontextBox.Location = new System.Drawing.Point(67, 43);
            this.DescriptiontextBox.Name = "DescriptiontextBox";
            this.DescriptiontextBox.Size = new System.Drawing.Size(100, 20);
            this.DescriptiontextBox.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(334, 46);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Diving Enable";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(334, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Housing Enable";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Description";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Region ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(173, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "IP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(173, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Port";
            // 
            // RegiondataGridView
            // 
            this.RegiondataGridView.AllowUserToAddRows = false;
            this.RegiondataGridView.AllowUserToOrderColumns = true;
            this.RegiondataGridView.AutoGenerateColumns = false;
            this.RegiondataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RegiondataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RegiondataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RegiondataGridView.DataSource = this.RegionbindingSource;
            this.RegiondataGridView.Location = new System.Drawing.Point(11, 93);
            this.RegiondataGridView.MultiSelect = false;
            this.RegiondataGridView.Name = "RegiondataGridView";
            this.RegiondataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RegiondataGridView.Size = new System.Drawing.Size(732, 262);
            this.RegiondataGridView.TabIndex = 1;
            this.RegiondataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RegiondataGridView_CellContentClick);
            // 
            // RegionbindingNavigator
            // 
            this.RegionbindingNavigator.AddNewItem = null;
            this.RegionbindingNavigator.BindingSource = this.RegionbindingSource;
            this.RegionbindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.RegionbindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.RegionbindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.RegionbindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorDeleteItem});
            this.RegionbindingNavigator.Location = new System.Drawing.Point(4, 39);
            this.RegionbindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.RegionbindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.RegionbindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.RegionbindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.RegionbindingNavigator.Name = "RegionbindingNavigator";
            this.RegionbindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.RegionbindingNavigator.Size = new System.Drawing.Size(232, 25);
            this.RegionbindingNavigator.TabIndex = 2;
            this.RegionbindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.RegionNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // ControlMenu
            // 
            this.ControlMenu.Controls.Add(this.button2);
            this.ControlMenu.Controls.Add(this.label2);
            this.ControlMenu.Controls.Add(this.SearchByRegionNametextBox);
            this.ControlMenu.Controls.Add(this.Classlabel);
            this.ControlMenu.Controls.Add(this.RegionbindingNavigator);
            this.ControlMenu.Controls.Add(this.label5);
            this.ControlMenu.Controls.Add(this.ClassTypeSearchcomboBox);
            this.ControlMenu.Controls.Add(this.SearchRegionIDtextBox);
            this.ControlMenu.Controls.Add(this.Speclabel);
            this.ControlMenu.Controls.Add(this.SearchFrontierscomboBox);
            this.ControlMenu.Location = new System.Drawing.Point(11, -2);
            this.ControlMenu.Name = "ControlMenu";
            this.ControlMenu.Size = new System.Drawing.Size(521, 89);
            this.ControlMenu.TabIndex = 18;
            this.ControlMenu.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(456, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(59, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Searchbutton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Region ID";
            // 
            // SearchByRegionNametextBox
            // 
            this.SearchByRegionNametextBox.Location = new System.Drawing.Point(342, 36);
            this.SearchByRegionNametextBox.Name = "SearchByRegionNametextBox";
            this.SearchByRegionNametextBox.Size = new System.Drawing.Size(100, 20);
            this.SearchByRegionNametextBox.TabIndex = 14;
            this.SearchByRegionNametextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Classlabel
            // 
            this.Classlabel.AutoSize = true;
            this.Classlabel.Location = new System.Drawing.Point(2, 13);
            this.Classlabel.Name = "Classlabel";
            this.Classlabel.Size = new System.Drawing.Size(56, 13);
            this.Classlabel.TabIndex = 7;
            this.Classlabel.Text = "ClassType";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(270, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Region Name";
            // 
            // ClassTypeSearchcomboBox
            // 
            this.ClassTypeSearchcomboBox.DisplayMember = "All";
            this.ClassTypeSearchcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClassTypeSearchcomboBox.FormattingEnabled = true;
            this.ClassTypeSearchcomboBox.Location = new System.Drawing.Point(58, 10);
            this.ClassTypeSearchcomboBox.MaxDropDownItems = 15;
            this.ClassTypeSearchcomboBox.Name = "ClassTypeSearchcomboBox";
            this.ClassTypeSearchcomboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ClassTypeSearchcomboBox.Size = new System.Drawing.Size(121, 21);
            this.ClassTypeSearchcomboBox.Sorted = true;
            this.ClassTypeSearchcomboBox.TabIndex = 3;
            // 
            // SearchRegionIDtextBox
            // 
            this.SearchRegionIDtextBox.Location = new System.Drawing.Point(342, 10);
            this.SearchRegionIDtextBox.Name = "SearchRegionIDtextBox";
            this.SearchRegionIDtextBox.Size = new System.Drawing.Size(51, 20);
            this.SearchRegionIDtextBox.TabIndex = 12;
            this.SearchRegionIDtextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Speclabel
            // 
            this.Speclabel.AutoSize = true;
            this.Speclabel.Location = new System.Drawing.Point(181, 14);
            this.Speclabel.Name = "Speclabel";
            this.Speclabel.Size = new System.Drawing.Size(47, 13);
            this.Speclabel.TabIndex = 9;
            this.Speclabel.Text = "Frontiers";
            // 
            // SearchFrontierscomboBox
            // 
            this.SearchFrontierscomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SearchFrontierscomboBox.FormattingEnabled = true;
            this.SearchFrontierscomboBox.Items.AddRange(new object[] {
            " All",
            "False",
            "True"});
            this.SearchFrontierscomboBox.Location = new System.Drawing.Point(230, 11);
            this.SearchFrontierscomboBox.MaxDropDownItems = 15;
            this.SearchFrontierscomboBox.Name = "SearchFrontierscomboBox";
            this.SearchFrontierscomboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SearchFrontierscomboBox.Size = new System.Drawing.Size(52, 21);
            this.SearchFrontierscomboBox.TabIndex = 8;
            // 
            // SaveNewbutton
            // 
            this.SaveNewbutton.Location = new System.Drawing.Point(38, 52);
            this.SaveNewbutton.Name = "SaveNewbutton";
            this.SaveNewbutton.Size = new System.Drawing.Size(116, 23);
            this.SaveNewbutton.TabIndex = 21;
            this.SaveNewbutton.Text = "Save New Region";
            this.SaveNewbutton.UseVisualStyleBackColor = true;
            this.SaveNewbutton.Click += new System.EventHandler(this.SaveNewRegion_Click);
            // 
            // Savebutton
            // 
            this.Savebutton.Location = new System.Drawing.Point(38, 51);
            this.Savebutton.Name = "Savebutton";
            this.Savebutton.Size = new System.Drawing.Size(116, 23);
            this.Savebutton.TabIndex = 20;
            this.Savebutton.Text = "Save Loaded Region";
            this.Savebutton.UseVisualStyleBackColor = true;
            this.Savebutton.Click += new System.EventHandler(this.SaveLoadedRegion_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RegionListingButton);
            this.groupBox2.Controls.Add(this.AddRegionButton);
            this.groupBox2.Controls.Add(this.SaveNewbutton);
            this.groupBox2.Controls.Add(this.Savebutton);
            this.groupBox2.Location = new System.Drawing.Point(538, -2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(193, 89);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            // 
            // RegionListingButton
            // 
            this.RegionListingButton.Location = new System.Drawing.Point(104, 21);
            this.RegionListingButton.Name = "RegionListingButton";
            this.RegionListingButton.Size = new System.Drawing.Size(86, 23);
            this.RegionListingButton.TabIndex = 23;
            this.RegionListingButton.Text = "Region Listing";
            this.RegionListingButton.UseVisualStyleBackColor = true;
            this.RegionListingButton.Click += new System.EventHandler(this.RegionListing_Click);
            // 
            // AddRegionButton
            // 
            this.AddRegionButton.Location = new System.Drawing.Point(3, 21);
            this.AddRegionButton.Name = "AddRegionButton";
            this.AddRegionButton.Size = new System.Drawing.Size(98, 23);
            this.AddRegionButton.TabIndex = 22;
            this.AddRegionButton.Text = "Add new region";
            this.AddRegionButton.UseVisualStyleBackColor = true;
            this.AddRegionButton.Click += new System.EventHandler(this.AddNewRegion_Click);
            // 
            // LoadRegion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 365);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.RegiondataGridView);
            this.Controls.Add(this.ControlMenu);
            this.Controls.Add(this.EditRegionControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoadRegion";
            this.Text = "Region Editor";
            this.EditRegionControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.Translationgroupbox.ResumeLayout(false);
            this.Translationgroupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegionTranslationbindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegionTranslationbindingNavigator)).EndInit();
            this.RegionTranslationbindingNavigator.ResumeLayout(false);
            this.RegionTranslationbindingNavigator.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RegiondataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegionbindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegionbindingNavigator)).EndInit();
            this.RegionbindingNavigator.ResumeLayout(false);
            this.RegionbindingNavigator.PerformLayout();
            this.ControlMenu.ResumeLayout(false);
            this.ControlMenu.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl EditRegionControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.BindingNavigator RegionbindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView RegiondataGridView;
        private System.Windows.Forms.BindingSource RegionbindingSource;
        private System.Windows.Forms.GroupBox ControlMenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SearchByRegionNametextBox;
        private System.Windows.Forms.Button SaveNewbutton;
        private System.Windows.Forms.Button Savebutton;
        private System.Windows.Forms.Label Classlabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ClassTypeSearchcomboBox;
        private System.Windows.Forms.TextBox SearchRegionIDtextBox;
        private System.Windows.Forms.Label Speclabel;
        private System.Windows.Forms.ComboBox SearchFrontierscomboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox WaterLeveltextBox;
        private System.Windows.Forms.ComboBox ClassTypecomboBox;
        private System.Windows.Forms.ComboBox ExpansioncomboBox;
        private System.Windows.Forms.TextBox IPtextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox PorttextBox;
        private System.Windows.Forms.ComboBox HousingEnablecomboBox;
        private System.Windows.Forms.ComboBox DivingEnablecomboBox;
        private System.Windows.Forms.ComboBox IsFrontiercomboBox;
        private System.Windows.Forms.TextBox RegionIDtextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox NametextBox;
        private System.Windows.Forms.TextBox DescriptiontextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private GroupBox Translationgroupbox;
        private TextBox NameLanguageAddtextBox;
        private TextBox DescriptionLanguageAddtextBox;
        private Label label15;
        private Label label16;
        private DataGridView dataGridView1;
        private BindingSource RegionTranslationbindingSource;
        private BindingNavigator RegionTranslationbindingNavigator;
        private ToolStripButton bindingNavigatorAddNewItem;
        private ToolStripLabel bindingNavigatorCountItem1;
        private ToolStripButton bindingNavigatorDeleteItem1;
        private ToolStripButton bindingNavigatorMoveFirstItem1;
        private ToolStripButton bindingNavigatorMovePreviousItem1;
        private ToolStripSeparator bindingNavigatorSeparator3;
        private ToolStripTextBox bindingNavigatorPositionItem1;
        private ToolStripSeparator bindingNavigatorSeparator4;
        private ToolStripButton bindingNavigatorMoveNextItem1;
        private ToolStripButton bindingNavigatorMoveLastItem1;
        private ToolStripSeparator bindingNavigatorSeparator5;
        private ComboBox LanguagecomboBox;
        private Label label17;
        private Button button1;
        private TextBox TagLanguageAddtextBox;
        private Label label18;
        private GroupBox groupBox2;
        private Button RegionListingButton;
        private Button AddRegionButton;
        private Button button2;
    }
}