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
    partial class LoadArea
    {
        DataTable AreaDatatable = new DataTable();
        DataTable AreaLanguageDatatable = new DataTable();

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadArea));
            this.AreabindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.AreabindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.AreadataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.TagtextBox = new System.Windows.Forms.TextBox();
            this.ScreenDescriptiontextBox = new System.Windows.Forms.TextBox();
            this.DescriptionLanguageAreatextBox = new System.Windows.Forms.TextBox();
            this.LanguagecomboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AreaLanguagebindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.AreaLanguagebindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorDeleteItem1 = new System.Windows.Forms.ToolStripButton();
            this.AreaLanguagedataGridView = new System.Windows.Forms.DataGridView();
            this.AreaEditorgroupBox = new System.Windows.Forms.GroupBox();
            this.ClassTypecomboBox = new System.Windows.Forms.ComboBox();
            this.CheckLoscomboBox = new System.Windows.Forms.ComboBox();
            this.CanBroadCastcomboBox = new System.Windows.Forms.ComboBox();
            this.TranslationIDtextBox = new System.Windows.Forms.TextBox();
            this.PointstextBox = new System.Windows.Forms.TextBox();
            this.SoundtextBox = new System.Windows.Forms.TextBox();
            this.TranslationIDlabel = new System.Windows.Forms.Label();
            this.Pointslabel = new System.Windows.Forms.Label();
            this.RadiustextBox = new System.Windows.Forms.TextBox();
            this.RegiontextBox = new System.Windows.Forms.TextBox();
            this.ZtextBox = new System.Windows.Forms.TextBox();
            this.YtextBox = new System.Windows.Forms.TextBox();
            this.CheckLoslabel = new System.Windows.Forms.Label();
            this.Soundlabel = new System.Windows.Forms.Label();
            this.CanBroadCastlabel = new System.Windows.Forms.Label();
            this.ClassTypelabel = new System.Windows.Forms.Label();
            this.XtextBox = new System.Windows.Forms.TextBox();
            this.DescriptiontextBox = new System.Windows.Forms.TextBox();
            this.Radiuslabel = new System.Windows.Forms.Label();
            this.Regionlabel = new System.Windows.Forms.Label();
            this.Zlabel = new System.Windows.Forms.Label();
            this.Ylabel = new System.Windows.Forms.Label();
            this.Xlabel = new System.Windows.Forms.Label();
            this.Descriptionlabel = new System.Windows.Forms.Label();
            this.Savebutton = new System.Windows.Forms.Button();
            this.SaveNewbutton = new System.Windows.Forms.Button();
            this.EditAreaControl = new System.Windows.Forms.TabControl();
            this.ControlMenu = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchByDescriptiontextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ClassTypeSearchcomboBox = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.AddAreaButton = new System.Windows.Forms.Button();
            this.AreaListingButton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AreabindingNavigator)).BeginInit();
            this.AreabindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AreabindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AreadataGridView)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AreaLanguagebindingNavigator)).BeginInit();
            this.AreaLanguagebindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AreaLanguagebindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AreaLanguagedataGridView)).BeginInit();
            this.AreaEditorgroupBox.SuspendLayout();
            this.EditAreaControl.SuspendLayout();
            this.ControlMenu.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // AreabindingNavigator
            // 
            this.AreabindingNavigator.AddNewItem = null;
            this.AreabindingNavigator.BindingSource = this.AreabindingSource;
            this.AreabindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.AreabindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.AreabindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.AreabindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.AreabindingNavigator.Location = new System.Drawing.Point(4, 43);
            this.AreabindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.AreabindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.AreabindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.AreabindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.AreabindingNavigator.Name = "AreabindingNavigator";
            this.AreabindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.AreabindingNavigator.Size = new System.Drawing.Size(232, 25);
            this.AreabindingNavigator.TabIndex = 0;
            this.AreabindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.AreaNavigatorDeleteItem_Click);
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
            // AreadataGridView
            // 
            this.AreadataGridView.AllowUserToAddRows = false;
            this.AreadataGridView.AllowUserToOrderColumns = true;
            this.AreadataGridView.AutoGenerateColumns = false;
            this.AreadataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AreadataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AreadataGridView.DataSource = this.AreabindingSource;
            this.AreadataGridView.Location = new System.Drawing.Point(10, 75);
            this.AreadataGridView.MultiSelect = false;
            this.AreadataGridView.Name = "AreadataGridView";
            this.AreadataGridView.ReadOnly = true;
            this.AreadataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AreadataGridView.Size = new System.Drawing.Size(847, 277);
            this.AreadataGridView.TabIndex = 1;
            this.AreadataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AreadataGridView_CellContentClick);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.AreaEditorgroupBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(839, 251);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Area Editor";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.TagtextBox);
            this.groupBox1.Controls.Add(this.ScreenDescriptiontextBox);
            this.groupBox1.Controls.Add(this.DescriptionLanguageAreatextBox);
            this.groupBox1.Controls.Add(this.LanguagecomboBox);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.AreaLanguagebindingNavigator);
            this.groupBox1.Controls.Add(this.AreaLanguagedataGridView);
            this.groupBox1.Location = new System.Drawing.Point(6, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(827, 151);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Translation";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(704, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 40);
            this.button1.TabIndex = 16;
            this.button1.Text = "Add Language Area";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.LanguageAreaSaveNew_Click);
            // 
            // TagtextBox
            // 
            this.TagtextBox.Location = new System.Drawing.Point(540, 13);
            this.TagtextBox.Name = "TagtextBox";
            this.TagtextBox.Size = new System.Drawing.Size(143, 20);
            this.TagtextBox.TabIndex = 15;
            // 
            // ScreenDescriptiontextBox
            // 
            this.ScreenDescriptiontextBox.Location = new System.Drawing.Point(269, 37);
            this.ScreenDescriptiontextBox.Name = "ScreenDescriptiontextBox";
            this.ScreenDescriptiontextBox.Size = new System.Drawing.Size(233, 20);
            this.ScreenDescriptiontextBox.TabIndex = 14;
            // 
            // DescriptionLanguageAreatextBox
            // 
            this.DescriptionLanguageAreatextBox.Location = new System.Drawing.Point(269, 13);
            this.DescriptionLanguageAreatextBox.Name = "DescriptionLanguageAreatextBox";
            this.DescriptionLanguageAreatextBox.Size = new System.Drawing.Size(233, 20);
            this.DescriptionLanguageAreatextBox.TabIndex = 13;
            // 
            // LanguagecomboBox
            // 
            this.LanguagecomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LanguagecomboBox.FormattingEnabled = true;
            this.LanguagecomboBox.Items.AddRange(new object[] {
            "FR",
            "DE"});
            this.LanguagecomboBox.Location = new System.Drawing.Point(126, 12);
            this.LanguagecomboBox.Name = "LanguagecomboBox";
            this.LanguagecomboBox.Size = new System.Drawing.Size(46, 21);
            this.LanguagecomboBox.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(65, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Language";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(175, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Description";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(175, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "ScreenDescription";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(508, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tag";
            // 
            // AreaLanguagebindingNavigator
            // 
            this.AreaLanguagebindingNavigator.AddNewItem = null;
            this.AreaLanguagebindingNavigator.BindingSource = this.AreaLanguagebindingSource;
            this.AreaLanguagebindingNavigator.CountItem = null;
            this.AreaLanguagebindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem1;
            this.AreaLanguagebindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.AreaLanguagebindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorDeleteItem1});
            this.AreaLanguagebindingNavigator.Location = new System.Drawing.Point(9, 38);
            this.AreaLanguagebindingNavigator.MoveFirstItem = null;
            this.AreaLanguagebindingNavigator.MoveLastItem = null;
            this.AreaLanguagebindingNavigator.MoveNextItem = null;
            this.AreaLanguagebindingNavigator.MovePreviousItem = null;
            this.AreaLanguagebindingNavigator.Name = "AreaLanguagebindingNavigator";
            this.AreaLanguagebindingNavigator.PositionItem = null;
            this.AreaLanguagebindingNavigator.Size = new System.Drawing.Size(35, 25);
            this.AreaLanguagebindingNavigator.TabIndex = 5;
            this.AreaLanguagebindingNavigator.Text = "bindingNavigator2";
            // 
            // bindingNavigatorDeleteItem1
            // 
            this.bindingNavigatorDeleteItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem1.Image")));
            this.bindingNavigatorDeleteItem1.Name = "bindingNavigatorDeleteItem1";
            this.bindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem1.Text = "Delete";
            this.bindingNavigatorDeleteItem1.Click += new System.EventHandler(this.LanguageAreaNavigatorDeleteItem1_Click);
            // 
            // AreaLanguagedataGridView
            // 
            this.AreaLanguagedataGridView.AllowUserToAddRows = false;
            this.AreaLanguagedataGridView.AllowUserToOrderColumns = true;
            this.AreaLanguagedataGridView.AutoGenerateColumns = false;
            this.AreaLanguagedataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AreaLanguagedataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AreaLanguagedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AreaLanguagedataGridView.DataSource = this.AreaLanguagebindingSource;
            this.AreaLanguagedataGridView.Location = new System.Drawing.Point(9, 63);
            this.AreaLanguagedataGridView.MultiSelect = false;
            this.AreaLanguagedataGridView.Name = "AreaLanguagedataGridView";
            this.AreaLanguagedataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.AreaLanguagedataGridView.Size = new System.Drawing.Size(812, 74);
            this.AreaLanguagedataGridView.TabIndex = 4;
            this.AreaLanguagedataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.LanguageAreadataGridView_CellValueChanged);
            // 
            // AreaEditorgroupBox
            // 
            this.AreaEditorgroupBox.Controls.Add(this.ClassTypecomboBox);
            this.AreaEditorgroupBox.Controls.Add(this.CheckLoscomboBox);
            this.AreaEditorgroupBox.Controls.Add(this.CanBroadCastcomboBox);
            this.AreaEditorgroupBox.Controls.Add(this.TranslationIDtextBox);
            this.AreaEditorgroupBox.Controls.Add(this.PointstextBox);
            this.AreaEditorgroupBox.Controls.Add(this.SoundtextBox);
            this.AreaEditorgroupBox.Controls.Add(this.TranslationIDlabel);
            this.AreaEditorgroupBox.Controls.Add(this.Pointslabel);
            this.AreaEditorgroupBox.Controls.Add(this.RadiustextBox);
            this.AreaEditorgroupBox.Controls.Add(this.RegiontextBox);
            this.AreaEditorgroupBox.Controls.Add(this.ZtextBox);
            this.AreaEditorgroupBox.Controls.Add(this.YtextBox);
            this.AreaEditorgroupBox.Controls.Add(this.CheckLoslabel);
            this.AreaEditorgroupBox.Controls.Add(this.Soundlabel);
            this.AreaEditorgroupBox.Controls.Add(this.CanBroadCastlabel);
            this.AreaEditorgroupBox.Controls.Add(this.ClassTypelabel);
            this.AreaEditorgroupBox.Controls.Add(this.XtextBox);
            this.AreaEditorgroupBox.Controls.Add(this.DescriptiontextBox);
            this.AreaEditorgroupBox.Controls.Add(this.Radiuslabel);
            this.AreaEditorgroupBox.Controls.Add(this.Regionlabel);
            this.AreaEditorgroupBox.Controls.Add(this.Zlabel);
            this.AreaEditorgroupBox.Controls.Add(this.Ylabel);
            this.AreaEditorgroupBox.Controls.Add(this.Xlabel);
            this.AreaEditorgroupBox.Controls.Add(this.Descriptionlabel);
            this.AreaEditorgroupBox.Location = new System.Drawing.Point(6, 6);
            this.AreaEditorgroupBox.Name = "AreaEditorgroupBox";
            this.AreaEditorgroupBox.Size = new System.Drawing.Size(827, 82);
            this.AreaEditorgroupBox.TabIndex = 20;
            this.AreaEditorgroupBox.TabStop = false;
            // 
            // ClassTypecomboBox
            // 
            this.ClassTypecomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClassTypecomboBox.FormattingEnabled = true;
            this.ClassTypecomboBox.Items.AddRange(new object[] {
            "DOL.GS.Area+BindArea",
            "DOL.GS.Area+Circle",
            "DOL.GS.Keeps.KeepArea"});
            this.ClassTypecomboBox.Location = new System.Drawing.Point(540, 50);
            this.ClassTypecomboBox.Name = "ClassTypecomboBox";
            this.ClassTypecomboBox.Size = new System.Drawing.Size(142, 21);
            this.ClassTypecomboBox.Sorted = true;
            this.ClassTypecomboBox.TabIndex = 12;
            // 
            // CheckLoscomboBox
            // 
            this.CheckLoscomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CheckLoscomboBox.FormattingEnabled = true;
            this.CheckLoscomboBox.Items.AddRange(new object[] {
            "False",
            "True"});
            this.CheckLoscomboBox.Location = new System.Drawing.Point(762, 53);
            this.CheckLoscomboBox.Name = "CheckLoscomboBox";
            this.CheckLoscomboBox.Size = new System.Drawing.Size(59, 21);
            this.CheckLoscomboBox.TabIndex = 13;
            // 
            // CanBroadCastcomboBox
            // 
            this.CanBroadCastcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CanBroadCastcomboBox.FormattingEnabled = true;
            this.CanBroadCastcomboBox.Items.AddRange(new object[] {
            "False",
            "True"});
            this.CanBroadCastcomboBox.Location = new System.Drawing.Point(762, 25);
            this.CanBroadCastcomboBox.Name = "CanBroadCastcomboBox";
            this.CanBroadCastcomboBox.Size = new System.Drawing.Size(59, 21);
            this.CanBroadCastcomboBox.TabIndex = 14;
            // 
            // TranslationIDtextBox
            // 
            this.TranslationIDtextBox.Location = new System.Drawing.Point(77, 48);
            this.TranslationIDtextBox.Name = "TranslationIDtextBox";
            this.TranslationIDtextBox.Size = new System.Drawing.Size(95, 20);
            this.TranslationIDtextBox.TabIndex = 14;
            this.TranslationIDtextBox.TextChanged += new System.EventHandler(this.TranslationID_TextChanged);
            // 
            // PointstextBox
            // 
            this.PointstextBox.Location = new System.Drawing.Point(540, 25);
            this.PointstextBox.Name = "PointstextBox";
            this.PointstextBox.Size = new System.Drawing.Size(50, 20);
            this.PointstextBox.TabIndex = 13;
            // 
            // SoundtextBox
            // 
            this.SoundtextBox.Location = new System.Drawing.Point(416, 51);
            this.SoundtextBox.Name = "SoundtextBox";
            this.SoundtextBox.Size = new System.Drawing.Size(50, 20);
            this.SoundtextBox.TabIndex = 12;
            // 
            // TranslationIDlabel
            // 
            this.TranslationIDlabel.AutoSize = true;
            this.TranslationIDlabel.Location = new System.Drawing.Point(6, 51);
            this.TranslationIDlabel.Name = "TranslationIDlabel";
            this.TranslationIDlabel.Size = new System.Drawing.Size(70, 13);
            this.TranslationIDlabel.TabIndex = 11;
            this.TranslationIDlabel.Text = "TranslationID";
            // 
            // Pointslabel
            // 
            this.Pointslabel.AutoSize = true;
            this.Pointslabel.Location = new System.Drawing.Point(478, 28);
            this.Pointslabel.Name = "Pointslabel";
            this.Pointslabel.Size = new System.Drawing.Size(36, 13);
            this.Pointslabel.TabIndex = 10;
            this.Pointslabel.Text = "Points";
            // 
            // RadiustextBox
            // 
            this.RadiustextBox.Location = new System.Drawing.Point(416, 25);
            this.RadiustextBox.Name = "RadiustextBox";
            this.RadiustextBox.Size = new System.Drawing.Size(50, 20);
            this.RadiustextBox.TabIndex = 6;
            // 
            // RegiontextBox
            // 
            this.RegiontextBox.Location = new System.Drawing.Point(303, 52);
            this.RegiontextBox.Name = "RegiontextBox";
            this.RegiontextBox.Size = new System.Drawing.Size(52, 20);
            this.RegiontextBox.TabIndex = 7;
            // 
            // ZtextBox
            // 
            this.ZtextBox.Location = new System.Drawing.Point(303, 25);
            this.ZtextBox.Name = "ZtextBox";
            this.ZtextBox.Size = new System.Drawing.Size(52, 20);
            this.ZtextBox.TabIndex = 8;
            // 
            // YtextBox
            // 
            this.YtextBox.Location = new System.Drawing.Point(192, 49);
            this.YtextBox.Name = "YtextBox";
            this.YtextBox.Size = new System.Drawing.Size(55, 20);
            this.YtextBox.TabIndex = 9;
            // 
            // CheckLoslabel
            // 
            this.CheckLoslabel.AutoSize = true;
            this.CheckLoslabel.Location = new System.Drawing.Point(701, 56);
            this.CheckLoslabel.Name = "CheckLoslabel";
            this.CheckLoslabel.Size = new System.Drawing.Size(55, 13);
            this.CheckLoslabel.TabIndex = 9;
            this.CheckLoslabel.Text = "CheckLos";
            // 
            // Soundlabel
            // 
            this.Soundlabel.AutoSize = true;
            this.Soundlabel.Location = new System.Drawing.Point(370, 56);
            this.Soundlabel.Name = "Soundlabel";
            this.Soundlabel.Size = new System.Drawing.Size(38, 13);
            this.Soundlabel.TabIndex = 8;
            this.Soundlabel.Text = "Sound";
            // 
            // CanBroadCastlabel
            // 
            this.CanBroadCastlabel.AutoSize = true;
            this.CanBroadCastlabel.Location = new System.Drawing.Point(681, 28);
            this.CanBroadCastlabel.Name = "CanBroadCastlabel";
            this.CanBroadCastlabel.Size = new System.Drawing.Size(75, 13);
            this.CanBroadCastlabel.TabIndex = 7;
            this.CanBroadCastlabel.Text = "CanBroadCast";
            // 
            // ClassTypelabel
            // 
            this.ClassTypelabel.AutoSize = true;
            this.ClassTypelabel.Location = new System.Drawing.Point(478, 56);
            this.ClassTypelabel.Name = "ClassTypelabel";
            this.ClassTypelabel.Size = new System.Drawing.Size(56, 13);
            this.ClassTypelabel.TabIndex = 6;
            this.ClassTypelabel.Text = "ClassType";
            // 
            // XtextBox
            // 
            this.XtextBox.Location = new System.Drawing.Point(192, 25);
            this.XtextBox.Name = "XtextBox";
            this.XtextBox.Size = new System.Drawing.Size(55, 20);
            this.XtextBox.TabIndex = 4;
            // 
            // DescriptiontextBox
            // 
            this.DescriptiontextBox.Location = new System.Drawing.Point(77, 25);
            this.DescriptiontextBox.Name = "DescriptiontextBox";
            this.DescriptiontextBox.Size = new System.Drawing.Size(95, 20);
            this.DescriptiontextBox.TabIndex = 5;
            // 
            // Radiuslabel
            // 
            this.Radiuslabel.AutoSize = true;
            this.Radiuslabel.Location = new System.Drawing.Point(370, 28);
            this.Radiuslabel.Name = "Radiuslabel";
            this.Radiuslabel.Size = new System.Drawing.Size(40, 13);
            this.Radiuslabel.TabIndex = 5;
            this.Radiuslabel.Text = "Radius";
            // 
            // Regionlabel
            // 
            this.Regionlabel.AutoSize = true;
            this.Regionlabel.Location = new System.Drawing.Point(257, 52);
            this.Regionlabel.Name = "Regionlabel";
            this.Regionlabel.Size = new System.Drawing.Size(41, 13);
            this.Regionlabel.TabIndex = 4;
            this.Regionlabel.Text = "Region";
            // 
            // Zlabel
            // 
            this.Zlabel.AutoSize = true;
            this.Zlabel.Location = new System.Drawing.Point(284, 28);
            this.Zlabel.Name = "Zlabel";
            this.Zlabel.Size = new System.Drawing.Size(14, 13);
            this.Zlabel.TabIndex = 3;
            this.Zlabel.Text = "Z";
            // 
            // Ylabel
            // 
            this.Ylabel.AutoSize = true;
            this.Ylabel.Location = new System.Drawing.Point(178, 52);
            this.Ylabel.Name = "Ylabel";
            this.Ylabel.Size = new System.Drawing.Size(14, 13);
            this.Ylabel.TabIndex = 2;
            this.Ylabel.Text = "Y";
            // 
            // Xlabel
            // 
            this.Xlabel.AutoSize = true;
            this.Xlabel.Location = new System.Drawing.Point(178, 28);
            this.Xlabel.Name = "Xlabel";
            this.Xlabel.Size = new System.Drawing.Size(14, 13);
            this.Xlabel.TabIndex = 1;
            this.Xlabel.Text = "X";
            // 
            // Descriptionlabel
            // 
            this.Descriptionlabel.AutoSize = true;
            this.Descriptionlabel.Location = new System.Drawing.Point(6, 28);
            this.Descriptionlabel.Name = "Descriptionlabel";
            this.Descriptionlabel.Size = new System.Drawing.Size(60, 13);
            this.Descriptionlabel.TabIndex = 0;
            this.Descriptionlabel.Text = "Description";
            // 
            // Savebutton
            // 
            this.Savebutton.Location = new System.Drawing.Point(45, 41);
            this.Savebutton.Name = "Savebutton";
            this.Savebutton.Size = new System.Drawing.Size(109, 21);
            this.Savebutton.TabIndex = 22;
            this.Savebutton.Text = "Save Area";
            this.Savebutton.UseVisualStyleBackColor = true;
            this.Savebutton.Click += new System.EventHandler(this.SaveLoadedArea_Click);
            // 
            // SaveNewbutton
            // 
            this.SaveNewbutton.Location = new System.Drawing.Point(45, 41);
            this.SaveNewbutton.Name = "SaveNewbutton";
            this.SaveNewbutton.Size = new System.Drawing.Size(109, 21);
            this.SaveNewbutton.TabIndex = 20;
            this.SaveNewbutton.Text = "Add New Area";
            this.SaveNewbutton.UseVisualStyleBackColor = true;
            this.SaveNewbutton.Click += new System.EventHandler(this.SaveNewArea_Click);
            // 
            // EditAreaControl
            // 
            this.EditAreaControl.Controls.Add(this.tabPage1);
            this.EditAreaControl.Location = new System.Drawing.Point(10, 75);
            this.EditAreaControl.Name = "EditAreaControl";
            this.EditAreaControl.SelectedIndex = 0;
            this.EditAreaControl.Size = new System.Drawing.Size(847, 277);
            this.EditAreaControl.TabIndex = 20;
            // 
            // ControlMenu
            // 
            this.ControlMenu.Controls.Add(this.button4);
            this.ControlMenu.Controls.Add(this.label2);
            this.ControlMenu.Controls.Add(this.SearchByDescriptiontextBox);
            this.ControlMenu.Controls.Add(this.label3);
            this.ControlMenu.Controls.Add(this.ClassTypeSearchcomboBox);
            this.ControlMenu.Controls.Add(this.AreabindingNavigator);
            this.ControlMenu.Location = new System.Drawing.Point(10, -2);
            this.ControlMenu.Name = "ControlMenu";
            this.ControlMenu.Size = new System.Drawing.Size(637, 71);
            this.ControlMenu.TabIndex = 23;
            this.ControlMenu.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(307, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Description";
            // 
            // SearchByDescriptiontextBox
            // 
            this.SearchByDescriptiontextBox.Location = new System.Drawing.Point(368, 13);
            this.SearchByDescriptiontextBox.Name = "SearchByDescriptiontextBox";
            this.SearchByDescriptiontextBox.Size = new System.Drawing.Size(200, 20);
            this.SearchByDescriptiontextBox.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "ClassType";
            // 
            // ClassTypeSearchcomboBox
            // 
            this.ClassTypeSearchcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClassTypeSearchcomboBox.FormattingEnabled = true;
            this.ClassTypeSearchcomboBox.Items.AddRange(new object[] {
            "All",
            "DOL.GS.Area+BindArea",
            "DOL.GS.Area+Circle",
            "DOL.GS.Keeps.KeepArea"});
            this.ClassTypeSearchcomboBox.Location = new System.Drawing.Point(59, 13);
            this.ClassTypeSearchcomboBox.MaxDropDownItems = 15;
            this.ClassTypeSearchcomboBox.Name = "ClassTypeSearchcomboBox";
            this.ClassTypeSearchcomboBox.Size = new System.Drawing.Size(245, 21);
            this.ClassTypeSearchcomboBox.Sorted = true;
            this.ClassTypeSearchcomboBox.TabIndex = 23;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.AddAreaButton);
            this.groupBox3.Controls.Add(this.AreaListingButton);
            this.groupBox3.Controls.Add(this.Savebutton);
            this.groupBox3.Controls.Add(this.SaveNewbutton);
            this.groupBox3.Location = new System.Drawing.Point(653, -2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 71);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            // 
            // AddAreaButton
            // 
            this.AddAreaButton.Location = new System.Drawing.Point(23, 11);
            this.AddAreaButton.Name = "AddAreaButton";
            this.AddAreaButton.Size = new System.Drawing.Size(84, 23);
            this.AddAreaButton.TabIndex = 26;
            this.AddAreaButton.Text = "Add New Area";
            this.AddAreaButton.UseVisualStyleBackColor = true;
            this.AddAreaButton.Click += new System.EventHandler(this.AddNewBattleGround_Click);
            // 
            // AreaListingButton
            // 
            this.AreaListingButton.Location = new System.Drawing.Point(113, 11);
            this.AreaListingButton.Name = "AreaListingButton";
            this.AreaListingButton.Size = new System.Drawing.Size(81, 23);
            this.AreaListingButton.TabIndex = 27;
            this.AreaListingButton.Text = "Area Listing";
            this.AreaListingButton.UseVisualStyleBackColor = true;
            this.AreaListingButton.Click += new System.EventHandler(this.ZoneListing_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(574, 11);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(59, 23);
            this.button4.TabIndex = 27;
            this.button4.Text = "Search";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Searchbutton_Click);
            // 
            // LoadArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 359);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.AreadataGridView);
            this.Controls.Add(this.ControlMenu);
            this.Controls.Add(this.EditAreaControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoadArea";
            this.Text = "Area Editor";
            ((System.ComponentModel.ISupportInitialize)(this.AreabindingNavigator)).EndInit();
            this.AreabindingNavigator.ResumeLayout(false);
            this.AreabindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AreabindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AreadataGridView)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AreaLanguagebindingNavigator)).EndInit();
            this.AreaLanguagebindingNavigator.ResumeLayout(false);
            this.AreaLanguagebindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AreaLanguagebindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AreaLanguagedataGridView)).EndInit();
            this.AreaEditorgroupBox.ResumeLayout(false);
            this.AreaEditorgroupBox.PerformLayout();
            this.EditAreaControl.ResumeLayout(false);
            this.ControlMenu.ResumeLayout(false);
            this.ControlMenu.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingNavigator AreabindingNavigator;
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
        private System.Windows.Forms.BindingSource AreabindingSource;
        private System.Windows.Forms.DataGridView AreadataGridView;
        private System.Windows.Forms.BindingSource AreaLanguagebindingSource;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingNavigator AreaLanguagebindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem1;
        private System.Windows.Forms.DataGridView AreaLanguagedataGridView;
        private System.Windows.Forms.GroupBox AreaEditorgroupBox;
        private System.Windows.Forms.Button SaveNewbutton;
        private System.Windows.Forms.ComboBox ClassTypecomboBox;
        private System.Windows.Forms.ComboBox CheckLoscomboBox;
        private System.Windows.Forms.ComboBox CanBroadCastcomboBox;
        private System.Windows.Forms.TextBox TranslationIDtextBox;
        private System.Windows.Forms.TextBox PointstextBox;
        private System.Windows.Forms.TextBox SoundtextBox;
        private System.Windows.Forms.Label TranslationIDlabel;
        private System.Windows.Forms.Label Pointslabel;
        private System.Windows.Forms.TextBox RadiustextBox;
        private System.Windows.Forms.TextBox RegiontextBox;
        private System.Windows.Forms.TextBox ZtextBox;
        private System.Windows.Forms.TextBox YtextBox;
        private System.Windows.Forms.Label CheckLoslabel;
        private System.Windows.Forms.Label Soundlabel;
        private System.Windows.Forms.Label CanBroadCastlabel;
        private System.Windows.Forms.Label ClassTypelabel;
        private System.Windows.Forms.TextBox XtextBox;
        private System.Windows.Forms.TextBox DescriptiontextBox;
        private System.Windows.Forms.Label Radiuslabel;
        private System.Windows.Forms.Label Regionlabel;
        private System.Windows.Forms.Label Zlabel;
        private System.Windows.Forms.Label Ylabel;
        private System.Windows.Forms.Label Xlabel;
        private System.Windows.Forms.Label Descriptionlabel;
        private System.Windows.Forms.TabControl EditAreaControl;
        private System.Windows.Forms.GroupBox ControlMenu;
        private Button Savebutton;
        private Button button1;
        private TextBox TagtextBox;
        private TextBox ScreenDescriptiontextBox;
        private TextBox DescriptionLanguageAreatextBox;
        private ComboBox LanguagecomboBox;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label2;
        private TextBox SearchByDescriptiontextBox;
        private Label label3;
        private ComboBox ClassTypeSearchcomboBox;
        private GroupBox groupBox3;
        private Button AddAreaButton;
        private Button AreaListingButton;
        private Button button4;
    }
}