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

namespace Origins_Editor
{
    partial class LoadZone
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        DataTable ZonesDatatable = new DataTable();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadZone));
            this.ZonebindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.ZonebindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.ControlMenu = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ZoneRealmSearchcomboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SearchByZoneNametextBox = new System.Windows.Forms.TextBox();
            this.SearchZoneIDtextBox = new System.Windows.Forms.TextBox();
            this.SaveNewbutton = new System.Windows.Forms.Button();
            this.Savebutton = new System.Windows.Forms.Button();
            this.ZonedataGridView = new System.Windows.Forms.DataGridView();
            this.EditZoneControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DivingFlagcomboBox = new System.Windows.Forms.ComboBox();
            this.IsLavacomboBox = new System.Windows.Forms.ComboBox();
            this.RealmcomboBox = new System.Windows.Forms.ComboBox();
            this.RegionIDtextBox = new System.Windows.Forms.TextBox();
            this.OffSetYtextBox = new System.Windows.Forms.TextBox();
            this.OffSetXtextBox = new System.Windows.Forms.TextBox();
            this.CointextBox = new System.Windows.Forms.TextBox();
            this.ExperiencetextBox = new System.Windows.Forms.TextBox();
            this.BountyPointstextBox = new System.Windows.Forms.TextBox();
            this.RealmPointstextBox = new System.Windows.Forms.TextBox();
            this.NametextBox = new System.Windows.Forms.TextBox();
            this.WaterLeveltextBox = new System.Windows.Forms.TextBox();
            this.WidthtextBox = new System.Windows.Forms.TextBox();
            this.TranslationIDtextBox = new System.Windows.Forms.TextBox();
            this.HeighttextBox = new System.Windows.Forms.TextBox();
            this.ZoneIDtextBox = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AddZoneButton = new System.Windows.Forms.Button();
            this.ZoneListingButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ZonebindingNavigator)).BeginInit();
            this.ZonebindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ZonebindingSource)).BeginInit();
            this.ControlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ZonedataGridView)).BeginInit();
            this.EditZoneControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ZonebindingNavigator
            // 
            this.ZonebindingNavigator.AddNewItem = null;
            this.ZonebindingNavigator.BindingSource = this.ZonebindingSource;
            this.ZonebindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.ZonebindingNavigator.DeleteItem = null;
            this.ZonebindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.ZonebindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.ZonebindingNavigator.Location = new System.Drawing.Point(4, 37);
            this.ZonebindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.ZonebindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.ZonebindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.ZonebindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.ZonebindingNavigator.Name = "ZonebindingNavigator";
            this.ZonebindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.ZonebindingNavigator.Size = new System.Drawing.Size(232, 25);
            this.ZonebindingNavigator.TabIndex = 2;
            this.ZonebindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.ZoneNavigatorDeleteItem_Click);
            // 
            // ControlMenu
            // 
            this.ControlMenu.Controls.Add(this.button1);
            this.ControlMenu.Controls.Add(this.label3);
            this.ControlMenu.Controls.Add(this.label2);
            this.ControlMenu.Controls.Add(this.ZoneRealmSearchcomboBox);
            this.ControlMenu.Controls.Add(this.ZonebindingNavigator);
            this.ControlMenu.Controls.Add(this.label4);
            this.ControlMenu.Controls.Add(this.SearchByZoneNametextBox);
            this.ControlMenu.Controls.Add(this.SearchZoneIDtextBox);
            this.ControlMenu.Location = new System.Drawing.Point(10, -1);
            this.ControlMenu.Name = "ControlMenu";
            this.ControlMenu.Size = new System.Drawing.Size(483, 69);
            this.ControlMenu.TabIndex = 18;
            this.ControlMenu.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Zone Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Zone ID";
            // 
            // ZoneRealmSearchcomboBox
            // 
            this.ZoneRealmSearchcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ZoneRealmSearchcomboBox.FormattingEnabled = true;
            this.ZoneRealmSearchcomboBox.Items.AddRange(new object[] {
            " All",
            "Albion",
            "Midgard",
            "Hibernia"});
            this.ZoneRealmSearchcomboBox.Location = new System.Drawing.Point(40, 12);
            this.ZoneRealmSearchcomboBox.MaxDropDownItems = 15;
            this.ZoneRealmSearchcomboBox.Name = "ZoneRealmSearchcomboBox";
            this.ZoneRealmSearchcomboBox.Size = new System.Drawing.Size(89, 21);
            this.ZoneRealmSearchcomboBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Realm";
            // 
            // SearchByZoneNametextBox
            // 
            this.SearchByZoneNametextBox.Location = new System.Drawing.Point(289, 13);
            this.SearchByZoneNametextBox.Name = "SearchByZoneNametextBox";
            this.SearchByZoneNametextBox.Size = new System.Drawing.Size(123, 20);
            this.SearchByZoneNametextBox.TabIndex = 14;
            // 
            // SearchZoneIDtextBox
            // 
            this.SearchZoneIDtextBox.Location = new System.Drawing.Point(178, 12);
            this.SearchZoneIDtextBox.Name = "SearchZoneIDtextBox";
            this.SearchZoneIDtextBox.Size = new System.Drawing.Size(44, 20);
            this.SearchZoneIDtextBox.TabIndex = 12;
            // 
            // SaveNewbutton
            // 
            this.SaveNewbutton.Location = new System.Drawing.Point(39, 35);
            this.SaveNewbutton.Name = "SaveNewbutton";
            this.SaveNewbutton.Size = new System.Drawing.Size(107, 22);
            this.SaveNewbutton.TabIndex = 21;
            this.SaveNewbutton.Text = "Save New Zone";
            this.SaveNewbutton.UseVisualStyleBackColor = true;
            this.SaveNewbutton.Click += new System.EventHandler(this.SaveNewZone_Click);
            // 
            // Savebutton
            // 
            this.Savebutton.Location = new System.Drawing.Point(39, 35);
            this.Savebutton.Name = "Savebutton";
            this.Savebutton.Size = new System.Drawing.Size(107, 23);
            this.Savebutton.TabIndex = 20;
            this.Savebutton.Text = "Save Loaded Zone";
            this.Savebutton.UseVisualStyleBackColor = true;
            this.Savebutton.Click += new System.EventHandler(this.SaveLoadedZone_Click);
            // 
            // ZonedataGridView
            // 
            this.ZonedataGridView.AllowUserToAddRows = false;
            this.ZonedataGridView.AllowUserToOrderColumns = true;
            this.ZonedataGridView.AutoGenerateColumns = false;
            this.ZonedataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.ZonedataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ZonedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ZonedataGridView.DataSource = this.ZonebindingSource;
            this.ZonedataGridView.Location = new System.Drawing.Point(10, 74);
            this.ZonedataGridView.MultiSelect = false;
            this.ZonedataGridView.Name = "ZonedataGridView";
            this.ZonedataGridView.ReadOnly = true;
            this.ZonedataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ZonedataGridView.Size = new System.Drawing.Size(667, 177);
            this.ZonedataGridView.TabIndex = 19;
            this.ZonedataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ZonedataGridView_CellContentClick);
            // 
            // EditZoneControl
            // 
            this.EditZoneControl.Controls.Add(this.tabPage1);
            this.EditZoneControl.Location = new System.Drawing.Point(10, 74);
            this.EditZoneControl.Name = "EditZoneControl";
            this.EditZoneControl.SelectedIndex = 0;
            this.EditZoneControl.Size = new System.Drawing.Size(667, 177);
            this.EditZoneControl.TabIndex = 20;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(659, 151);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Zone Editor";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DivingFlagcomboBox);
            this.groupBox1.Controls.Add(this.IsLavacomboBox);
            this.groupBox1.Controls.Add(this.RealmcomboBox);
            this.groupBox1.Controls.Add(this.RegionIDtextBox);
            this.groupBox1.Controls.Add(this.OffSetYtextBox);
            this.groupBox1.Controls.Add(this.OffSetXtextBox);
            this.groupBox1.Controls.Add(this.CointextBox);
            this.groupBox1.Controls.Add(this.ExperiencetextBox);
            this.groupBox1.Controls.Add(this.BountyPointstextBox);
            this.groupBox1.Controls.Add(this.RealmPointstextBox);
            this.groupBox1.Controls.Add(this.NametextBox);
            this.groupBox1.Controls.Add(this.WaterLeveltextBox);
            this.groupBox1.Controls.Add(this.WidthtextBox);
            this.groupBox1.Controls.Add(this.TranslationIDtextBox);
            this.groupBox1.Controls.Add(this.HeighttextBox);
            this.groupBox1.Controls.Add(this.ZoneIDtextBox);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(647, 135);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // DivingFlagcomboBox
            // 
            this.DivingFlagcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DivingFlagcomboBox.FormattingEnabled = true;
            this.DivingFlagcomboBox.Items.AddRange(new object[] {
            "False",
            "True"});
            this.DivingFlagcomboBox.Location = new System.Drawing.Point(399, 55);
            this.DivingFlagcomboBox.Name = "DivingFlagcomboBox";
            this.DivingFlagcomboBox.Size = new System.Drawing.Size(74, 21);
            this.DivingFlagcomboBox.TabIndex = 31;
            // 
            // IsLavacomboBox
            // 
            this.IsLavacomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IsLavacomboBox.FormattingEnabled = true;
            this.IsLavacomboBox.Items.AddRange(new object[] {
            "False",
            "True"});
            this.IsLavacomboBox.Location = new System.Drawing.Point(399, 79);
            this.IsLavacomboBox.Name = "IsLavacomboBox";
            this.IsLavacomboBox.Size = new System.Drawing.Size(74, 21);
            this.IsLavacomboBox.TabIndex = 30;
            // 
            // RealmcomboBox
            // 
            this.RealmcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RealmcomboBox.FormattingEnabled = true;
            this.RealmcomboBox.Items.AddRange(new object[] {
            "All",
            "Albion",
            "Midgard",
            "Hibernia"});
            this.RealmcomboBox.Location = new System.Drawing.Point(399, 102);
            this.RealmcomboBox.Name = "RealmcomboBox";
            this.RealmcomboBox.Size = new System.Drawing.Size(74, 21);
            this.RealmcomboBox.TabIndex = 29;
            // 
            // RegionIDtextBox
            // 
            this.RegionIDtextBox.Location = new System.Drawing.Point(68, 54);
            this.RegionIDtextBox.Name = "RegionIDtextBox";
            this.RegionIDtextBox.Size = new System.Drawing.Size(77, 20);
            this.RegionIDtextBox.TabIndex = 28;
            // 
            // OffSetYtextBox
            // 
            this.OffSetYtextBox.Location = new System.Drawing.Point(68, 78);
            this.OffSetYtextBox.Name = "OffSetYtextBox";
            this.OffSetYtextBox.Size = new System.Drawing.Size(77, 20);
            this.OffSetYtextBox.TabIndex = 27;
            // 
            // OffSetXtextBox
            // 
            this.OffSetXtextBox.Location = new System.Drawing.Point(69, 102);
            this.OffSetXtextBox.Name = "OffSetXtextBox";
            this.OffSetXtextBox.Size = new System.Drawing.Size(77, 20);
            this.OffSetXtextBox.TabIndex = 26;
            // 
            // CointextBox
            // 
            this.CointextBox.Location = new System.Drawing.Point(550, 30);
            this.CointextBox.Name = "CointextBox";
            this.CointextBox.Size = new System.Drawing.Size(91, 20);
            this.CointextBox.TabIndex = 25;
            // 
            // ExperiencetextBox
            // 
            this.ExperiencetextBox.Location = new System.Drawing.Point(550, 54);
            this.ExperiencetextBox.Name = "ExperiencetextBox";
            this.ExperiencetextBox.Size = new System.Drawing.Size(91, 20);
            this.ExperiencetextBox.TabIndex = 24;
            // 
            // BountyPointstextBox
            // 
            this.BountyPointstextBox.Location = new System.Drawing.Point(550, 78);
            this.BountyPointstextBox.Name = "BountyPointstextBox";
            this.BountyPointstextBox.Size = new System.Drawing.Size(91, 20);
            this.BountyPointstextBox.TabIndex = 23;
            // 
            // RealmPointstextBox
            // 
            this.RealmPointstextBox.Location = new System.Drawing.Point(550, 102);
            this.RealmPointstextBox.Name = "RealmPointstextBox";
            this.RealmPointstextBox.Size = new System.Drawing.Size(91, 20);
            this.RealmPointstextBox.TabIndex = 22;
            // 
            // NametextBox
            // 
            this.NametextBox.Location = new System.Drawing.Point(222, 31);
            this.NametextBox.Name = "NametextBox";
            this.NametextBox.Size = new System.Drawing.Size(100, 20);
            this.NametextBox.TabIndex = 21;
            // 
            // WaterLeveltextBox
            // 
            this.WaterLeveltextBox.Location = new System.Drawing.Point(399, 32);
            this.WaterLeveltextBox.Name = "WaterLeveltextBox";
            this.WaterLeveltextBox.Size = new System.Drawing.Size(74, 20);
            this.WaterLeveltextBox.TabIndex = 20;
            // 
            // WidthtextBox
            // 
            this.WidthtextBox.Location = new System.Drawing.Point(222, 78);
            this.WidthtextBox.Name = "WidthtextBox";
            this.WidthtextBox.Size = new System.Drawing.Size(100, 20);
            this.WidthtextBox.TabIndex = 19;
            // 
            // TranslationIDtextBox
            // 
            this.TranslationIDtextBox.Location = new System.Drawing.Point(222, 54);
            this.TranslationIDtextBox.Name = "TranslationIDtextBox";
            this.TranslationIDtextBox.Size = new System.Drawing.Size(100, 20);
            this.TranslationIDtextBox.TabIndex = 18;
            // 
            // HeighttextBox
            // 
            this.HeighttextBox.Location = new System.Drawing.Point(222, 102);
            this.HeighttextBox.Name = "HeighttextBox";
            this.HeighttextBox.Size = new System.Drawing.Size(100, 20);
            this.HeighttextBox.TabIndex = 17;
            // 
            // ZoneIDtextBox
            // 
            this.ZoneIDtextBox.Location = new System.Drawing.Point(68, 30);
            this.ZoneIDtextBox.Name = "ZoneIDtextBox";
            this.ZoneIDtextBox.Size = new System.Drawing.Size(77, 20);
            this.ZoneIDtextBox.TabIndex = 16;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(16, 58);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(55, 13);
            this.label19.TabIndex = 14;
            this.label19.Text = "Region ID";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(479, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Experience";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(479, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "RealmPoints";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(328, 35);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 13);
            this.label16.TabIndex = 11;
            this.label16.Text = "Water Level";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(479, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "BountyPoints";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(16, 82);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 13);
            this.label15.TabIndex = 10;
            this.label15.Text = "OffSet Y";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(479, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Coin";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(16, 34);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(46, 13);
            this.label20.TabIndex = 15;
            this.label20.Text = "Zone ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(328, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Diving Flag";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 105);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 13);
            this.label14.TabIndex = 9;
            this.label14.Text = "OffSet X";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(328, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Realm";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(328, 78);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(39, 13);
            this.label17.TabIndex = 12;
            this.label17.Text = "IsLava";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(151, 81);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "Width";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(151, 34);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(35, 13);
            this.label18.TabIndex = 13;
            this.label18.Text = "Name";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(151, 104);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "Height";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(151, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "TranslationID";
            // 
            // AddZoneButton
            // 
            this.AddZoneButton.Location = new System.Drawing.Point(6, 10);
            this.AddZoneButton.Name = "AddZoneButton";
            this.AddZoneButton.Size = new System.Drawing.Size(89, 23);
            this.AddZoneButton.TabIndex = 22;
            this.AddZoneButton.Text = "Add New Zone";
            this.AddZoneButton.UseVisualStyleBackColor = true;
            this.AddZoneButton.Click += new System.EventHandler(this.AddNewZone_Click);
            // 
            // ZoneListingButton
            // 
            this.ZoneListingButton.Location = new System.Drawing.Point(97, 10);
            this.ZoneListingButton.Name = "ZoneListingButton";
            this.ZoneListingButton.Size = new System.Drawing.Size(75, 23);
            this.ZoneListingButton.TabIndex = 23;
            this.ZoneListingButton.Text = "Zone Listing";
            this.ZoneListingButton.UseVisualStyleBackColor = true;
            this.ZoneListingButton.Click += new System.EventHandler(this.ZoneListing_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AddZoneButton);
            this.groupBox2.Controls.Add(this.ZoneListingButton);
            this.groupBox2.Controls.Add(this.SaveNewbutton);
            this.groupBox2.Controls.Add(this.Savebutton);
            this.groupBox2.Location = new System.Drawing.Point(502, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(175, 68);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(418, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Searchbutton_Click);
            // 
            // LoadZone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 259);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ControlMenu);
            this.Controls.Add(this.ZonedataGridView);
            this.Controls.Add(this.EditZoneControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoadZone";
            this.Text = "Zone Editor";
            ((System.ComponentModel.ISupportInitialize)(this.ZonebindingNavigator)).EndInit();
            this.ZonebindingNavigator.ResumeLayout(false);
            this.ZonebindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ZonebindingSource)).EndInit();
            this.ControlMenu.ResumeLayout(false);
            this.ControlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ZonedataGridView)).EndInit();
            this.EditZoneControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource ZonebindingSource;
        private System.Windows.Forms.BindingNavigator ZonebindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.GroupBox ControlMenu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ZoneRealmSearchcomboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SearchByZoneNametextBox;
        private System.Windows.Forms.Button SaveNewbutton;
        private System.Windows.Forms.TextBox SearchZoneIDtextBox;
        private System.Windows.Forms.Button Savebutton;
        private System.Windows.Forms.DataGridView ZonedataGridView;
        private System.Windows.Forms.TabControl EditZoneControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox DivingFlagcomboBox;
        private System.Windows.Forms.ComboBox IsLavacomboBox;
        private System.Windows.Forms.ComboBox RealmcomboBox;
        private System.Windows.Forms.TextBox RegionIDtextBox;
        private System.Windows.Forms.TextBox OffSetYtextBox;
        private System.Windows.Forms.TextBox OffSetXtextBox;
        private System.Windows.Forms.TextBox CointextBox;
        private System.Windows.Forms.TextBox ExperiencetextBox;
        private System.Windows.Forms.TextBox BountyPointstextBox;
        private System.Windows.Forms.TextBox RealmPointstextBox;
        private System.Windows.Forms.TextBox NametextBox;
        private System.Windows.Forms.TextBox WaterLeveltextBox;
        private System.Windows.Forms.TextBox WidthtextBox;
        private System.Windows.Forms.TextBox TranslationIDtextBox;
        private System.Windows.Forms.TextBox HeighttextBox;
        private System.Windows.Forms.TextBox ZoneIDtextBox;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private Button AddZoneButton;
        private Button ZoneListingButton;
        private GroupBox groupBox2;
        private Button button1;
    }
}