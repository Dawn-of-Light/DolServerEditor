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
    partial class LoadCraft
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        DataTable CraftedItemDatatable = new DataTable();
        DataTable CraftedXItemDatatable = new DataTable();

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadCraft));
            this.CraftedItembindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.CraftedItembindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.CraftedItemdataGridView = new System.Windows.Forms.DataGridView();
            this.CraftedXitembindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.CraftedXItembindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.CraftedXItemdataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.CraftedItemIDtextBox = new System.Windows.Forms.TextBox();
            this.id_nbtextBox = new System.Windows.Forms.TextBox();
            this.CraftingLeveltextBox = new System.Windows.Forms.TextBox();
            this.CraftingSkillTypecomboBox = new System.Windows.Forms.ComboBox();
            this.MakeTemplatedcomboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.CraftedItemId_nbtextBox = new System.Windows.Forms.TextBox();
            this.IngredientId_nbtextBox = new System.Windows.Forms.TextBox();
            this.CounttextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CraftingLevelSearchtextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Id_nbSearchtextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.CraftedItemIDSearchtextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.CraftingSkillTypeSearchcomboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CraftedItembindingNavigator)).BeginInit();
            this.CraftedItembindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CraftedItembindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CraftedItemdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CraftedXitembindingNavigator)).BeginInit();
            this.CraftedXitembindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CraftedXItembindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CraftedXItemdataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // CraftedItembindingNavigator
            // 
            this.CraftedItembindingNavigator.AddNewItem = null;
            this.CraftedItembindingNavigator.BindingSource = this.CraftedItembindingSource;
            this.CraftedItembindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.CraftedItembindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.CraftedItembindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.CraftedItembindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.CraftedItembindingNavigator.Location = new System.Drawing.Point(12, 64);
            this.CraftedItembindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.CraftedItembindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.CraftedItembindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.CraftedItembindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.CraftedItembindingNavigator.Name = "CraftedItembindingNavigator";
            this.CraftedItembindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.CraftedItembindingNavigator.Size = new System.Drawing.Size(232, 25);
            this.CraftedItembindingNavigator.TabIndex = 0;
            this.CraftedItembindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.CraftedItemNavigatorDeleteItem_Click);
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
            // FactiondataGridView
            // 
            this.CraftedItemdataGridView.AllowUserToAddRows = false;
            this.CraftedItemdataGridView.AllowUserToOrderColumns = true;
            this.CraftedItemdataGridView.AutoGenerateColumns = false;
            this.CraftedItemdataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CraftedItemdataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CraftedItemdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CraftedItemdataGridView.DataSource = this.CraftedItembindingSource;
            this.CraftedItemdataGridView.Location = new System.Drawing.Point(12, 92);
            this.CraftedItemdataGridView.MultiSelect = false;
            this.CraftedItemdataGridView.Name = "CraftedItemdataGridView";
            this.CraftedItemdataGridView.Size = new System.Drawing.Size(564, 183);
            this.CraftedItemdataGridView.TabIndex = 1;
            this.CraftedItemdataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.CraftedItemdataGridView_CellValueChanged);
            // 
            // CraftedXitembindingNavigator
            // 
            this.CraftedXitembindingNavigator.AddNewItem = null;
            this.CraftedXitembindingNavigator.BindingSource = this.CraftedXItembindingSource;
            this.CraftedXitembindingNavigator.CountItem = this.bindingNavigatorCountItem1;
            this.CraftedXitembindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem1;
            this.CraftedXitembindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.CraftedXitembindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem1,
            this.bindingNavigatorMovePreviousItem1,
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorSeparator4,
            this.bindingNavigatorMoveNextItem1,
            this.bindingNavigatorMoveLastItem1,
            this.bindingNavigatorSeparator5,
            this.bindingNavigatorDeleteItem1});
            this.CraftedXitembindingNavigator.Location = new System.Drawing.Point(12, 278);
            this.CraftedXitembindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
            this.CraftedXitembindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem1;
            this.CraftedXitembindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.CraftedXitembindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
            this.CraftedXitembindingNavigator.Name = "CraftedXitembindingNavigator";
            this.CraftedXitembindingNavigator.PositionItem = this.bindingNavigatorPositionItem1;
            this.CraftedXitembindingNavigator.Size = new System.Drawing.Size(232, 25);
            this.CraftedXitembindingNavigator.TabIndex = 2;
            this.CraftedXitembindingNavigator.Text = "bindingNavigator2";
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
            this.bindingNavigatorDeleteItem1.Click += new System.EventHandler(this.CraftedXItemNavigatorDeleteItem1_Click);
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
            // LinkedFactiondataGridView
            // 
            this.CraftedXItemdataGridView.AllowUserToAddRows = false;
            this.CraftedXItemdataGridView.AllowUserToOrderColumns = true;
            this.CraftedXItemdataGridView.AutoGenerateColumns = false;
            this.CraftedXItemdataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CraftedXItemdataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CraftedXItemdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CraftedXItemdataGridView.DataSource = this.CraftedXItembindingSource;
            this.CraftedXItemdataGridView.Location = new System.Drawing.Point(12, 305);
            this.CraftedXItemdataGridView.MultiSelect = false;
            this.CraftedXItemdataGridView.Name = "CraftedXItemdataGridView";
            this.CraftedXItemdataGridView.Size = new System.Drawing.Size(564, 182);
            this.CraftedXItemdataGridView.TabIndex = 3;
            this.CraftedXItemdataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.CraftedXItemdataGridView_CellValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.CraftedItemIDtextBox);
            this.groupBox1.Controls.Add(this.id_nbtextBox);
            this.groupBox1.Controls.Add(this.CraftingLeveltextBox);
            this.groupBox1.Controls.Add(this.CraftingSkillTypecomboBox);
            this.groupBox1.Controls.Add(this.MakeTemplatedcomboBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(582, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 211);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CraftedItem Add";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(87, 182);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Save CraftedItem";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.SaveCraftedItem_Click);
            // 
            // CraftedItemIDtextBox
            // 
            this.CraftedItemIDtextBox.Location = new System.Drawing.Point(99, 26);
            this.CraftedItemIDtextBox.Name = "CraftedItemIDtextBox";
            this.CraftedItemIDtextBox.Size = new System.Drawing.Size(158, 20);
            this.CraftedItemIDtextBox.TabIndex = 9;
            // 
            // id_nbtextBox
            // 
            this.id_nbtextBox.Location = new System.Drawing.Point(99, 54);
            this.id_nbtextBox.Name = "id_nbtextBox";
            this.id_nbtextBox.Size = new System.Drawing.Size(158, 20);
            this.id_nbtextBox.TabIndex = 8;
            // 
            // CraftingLeveltextBox
            // 
            this.CraftingLeveltextBox.Location = new System.Drawing.Point(99, 87);
            this.CraftingLeveltextBox.Name = "CraftingLeveltextBox";
            this.CraftingLeveltextBox.Size = new System.Drawing.Size(158, 20);
            this.CraftingLeveltextBox.TabIndex = 7;
            // 
            // CraftingSkillTypecomboBox
            // 
            this.CraftingSkillTypecomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CraftingSkillTypecomboBox.FormattingEnabled = true;
            this.CraftingSkillTypecomboBox.Items.AddRange(new object[] {
            "Alchemy",
            "ArmorCrafting",
            "BasicCrafting",
            "ClothWorking",
            "Fletching",
            "GemCutting",
            "HerbalCrafting",
            "LeatherCrafting",
            "MetalWorking",
            "SiegeCrafting",
            "SpellCrafting",
            "Tailoring",
            "WeaponCrafting",
            "WoodWorking"});
            this.CraftingSkillTypecomboBox.Location = new System.Drawing.Point(99, 120);
            this.CraftingSkillTypecomboBox.Name = "CraftingSkillTypecomboBox";
            this.CraftingSkillTypecomboBox.Size = new System.Drawing.Size(158, 21);
            this.CraftingSkillTypecomboBox.Sorted = true;
            this.CraftingSkillTypecomboBox.TabIndex = 6;
            // 
            // MakeTemplatedcomboBox
            // 
            this.MakeTemplatedcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MakeTemplatedcomboBox.FormattingEnabled = true;
            this.MakeTemplatedcomboBox.Items.AddRange(new object[] {
            "False",
            "True"});
            this.MakeTemplatedcomboBox.Location = new System.Drawing.Point(99, 150);
            this.MakeTemplatedcomboBox.Name = "MakeTemplatedcomboBox";
            this.MakeTemplatedcomboBox.Size = new System.Drawing.Size(53, 21);
            this.MakeTemplatedcomboBox.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Make Templated";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Crafting SkillType";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Crafting Level";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id_nb";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CraftedItemID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.CraftedItemId_nbtextBox);
            this.groupBox2.Controls.Add(this.IngredientId_nbtextBox);
            this.groupBox2.Controls.Add(this.CounttextBox);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(582, 281);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(263, 206);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CraftedXItem Add";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(81, 177);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Save CraftedXItem";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.SaveCraftedXItem_Click);
            // 
            // CraftedItemId_nbtextBox
            // 
            this.CraftedItemId_nbtextBox.Location = new System.Drawing.Point(99, 37);
            this.CraftedItemId_nbtextBox.Name = "CraftedItemId_nbtextBox";
            this.CraftedItemId_nbtextBox.Size = new System.Drawing.Size(158, 20);
            this.CraftedItemId_nbtextBox.TabIndex = 12;
            // 
            // IngredientId_nbtextBox
            // 
            this.IngredientId_nbtextBox.Location = new System.Drawing.Point(99, 65);
            this.IngredientId_nbtextBox.Name = "IngredientId_nbtextBox";
            this.IngredientId_nbtextBox.Size = new System.Drawing.Size(158, 20);
            this.IngredientId_nbtextBox.TabIndex = 11;
            // 
            // CounttextBox
            // 
            this.CounttextBox.Location = new System.Drawing.Point(99, 98);
            this.CounttextBox.Name = "CounttextBox";
            this.CounttextBox.Size = new System.Drawing.Size(53, 20);
            this.CounttextBox.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Count";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "IngredientId_nb";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "CraftedItemId_nb";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.CraftingLevelSearchtextBox);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.Id_nbSearchtextBox);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.CraftedItemIDSearchtextBox);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.CraftingSkillTypeSearchcomboBox);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(833, 46);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filters";
            // 
            // CraftingLevelSearchtextBox
            // 
            this.CraftingLevelSearchtextBox.Location = new System.Drawing.Point(668, 14);
            this.CraftingLevelSearchtextBox.Name = "CraftingLevelSearchtextBox";
            this.CraftingLevelSearchtextBox.Size = new System.Drawing.Size(80, 20);
            this.CraftingLevelSearchtextBox.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(595, 17);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "Crafting Level";
            // 
            // Id_nbSearchtextBox
            // 
            this.Id_nbSearchtextBox.Location = new System.Drawing.Point(436, 14);
            this.Id_nbSearchtextBox.Name = "Id_nbSearchtextBox";
            this.Id_nbSearchtextBox.Size = new System.Drawing.Size(158, 20);
            this.Id_nbSearchtextBox.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(401, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Id_nb";
            // 
            // CraftedItemIDSearchtextBox
            // 
            this.CraftedItemIDSearchtextBox.Location = new System.Drawing.Point(324, 13);
            this.CraftedItemIDSearchtextBox.Name = "CraftedItemIDSearchtextBox";
            this.CraftedItemIDSearchtextBox.Size = new System.Drawing.Size(76, 20);
            this.CraftedItemIDSearchtextBox.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(251, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "CraftedItemID";
            // 
            // CraftingSkillTypeSearchcomboBox
            // 
            this.CraftingSkillTypeSearchcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CraftingSkillTypeSearchcomboBox.FormattingEnabled = true;
            this.CraftingSkillTypeSearchcomboBox.Items.AddRange(new object[] {
            "Alchemy",
            "All",
            "ArmorCrafting",
            "BasicCrafting",
            "ClothWorking",
            "Fletching",
            "GemCutting",
            "HerbalCrafting",
            "LeatherCrafting",
            "MetalWorking",
            "SiegeCrafting",
            "SpellCrafting",
            "Tailoring",
            "WeaponCrafting"});
            this.CraftingSkillTypeSearchcomboBox.Location = new System.Drawing.Point(91, 13);
            this.CraftingSkillTypeSearchcomboBox.Name = "CraftingSkillTypeSearchcomboBox";
            this.CraftingSkillTypeSearchcomboBox.Size = new System.Drawing.Size(158, 21);
            this.CraftingSkillTypeSearchcomboBox.Sorted = true;
            this.CraftingSkillTypeSearchcomboBox.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Crafting SkillType";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(377, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Load selected crafteditem Ingredients";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.LoadCraftedXitem_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(768, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(59, 23);
            this.button4.TabIndex = 24;
            this.button4.Text = "Search";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Searchbutton_Click);
            // 
            // LoadCraft
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 499);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CraftedXItemdataGridView);
            this.Controls.Add(this.CraftedXitembindingNavigator);
            this.Controls.Add(this.CraftedItemdataGridView);
            this.Controls.Add(this.CraftedItembindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoadCraft";
            this.Text = "Craft Editor";
            ((System.ComponentModel.ISupportInitialize)(this.CraftedItembindingNavigator)).EndInit();
            this.CraftedItembindingNavigator.ResumeLayout(false);
            this.CraftedItembindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CraftedItembindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CraftedItemdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CraftedXitembindingNavigator)).EndInit();
            this.CraftedXitembindingNavigator.ResumeLayout(false);
            this.CraftedXitembindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CraftedXItembindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CraftedXItemdataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator CraftedItembindingNavigator;
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
        private System.Windows.Forms.BindingSource CraftedItembindingSource;
        private System.Windows.Forms.DataGridView CraftedItemdataGridView;
        private System.Windows.Forms.BindingNavigator CraftedXitembindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator5;
        private System.Windows.Forms.BindingSource CraftedXItembindingSource;
        private System.Windows.Forms.DataGridView CraftedXItemdataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private Button button1;
        private Button button2;
        private TextBox CraftedItemIDtextBox;
        private TextBox id_nbtextBox;
        private TextBox CraftingLeveltextBox;
        private ComboBox CraftingSkillTypecomboBox;
        private ComboBox MakeTemplatedcomboBox;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button3;
        private TextBox CraftedItemId_nbtextBox;
        private TextBox IngredientId_nbtextBox;
        private TextBox CounttextBox;
        private Label label8;
        private Label label7;
        private Label label6;
        private ComboBox CraftingSkillTypeSearchcomboBox;
        private Label label9;
        private TextBox CraftingLevelSearchtextBox;
        private Label label13;
        private TextBox Id_nbSearchtextBox;
        private Label label12;
        private TextBox CraftedItemIDSearchtextBox;
        private Label label11;
        private Button button4;
    }
}