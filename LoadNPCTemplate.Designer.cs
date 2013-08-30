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
    partial class LoadNPCTemplate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        DataTable NPCTemplateDatatable = new DataTable();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadNPCTemplate));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.NPCTemplatebindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.NPCTemplatebindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.NPCTemplatedataGridView = new System.Windows.Forms.DataGridView();
            this.ControlMenu = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label45 = new System.Windows.Forms.Label();
            this.PackageIDSearchcomboBox = new System.Windows.Forms.ComboBox();
            this.label42 = new System.Windows.Forms.Label();
            this.SearchByNPCTemplateNametextBox = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.SearchNPCTemplateIDtextBox = new System.Windows.Forms.TextBox();
            this.Classlabel = new System.Windows.Forms.Label();
            this.ClassTypeSearchcomboBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AddNPCTemplateButton = new System.Windows.Forms.Button();
            this.NPCTemplateListingButton = new System.Windows.Forms.Button();
            this.Savebutton = new System.Windows.Forms.Button();
            this.SaveNewbutton = new System.Windows.Forms.Button();
            this.ControlEditor = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.TranslationdataGridView = new System.Windows.Forms.DataGridView();
            this.TranslationbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TranslationbindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.label60 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.label54 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.SwimmingcheckBox = new System.Windows.Forms.CheckBox();
            this.TorchcheckBox = new System.Windows.Forms.CheckBox();
            this.StatuecheckBox = new System.Windows.Forms.CheckBox();
            this.PeacecheckBox = new System.Windows.Forms.CheckBox();
            this.FlyingcheckBox = new System.Windows.Forms.CheckBox();
            this.DontShowNamecheckBox = new System.Windows.Forms.CheckBox();
            this.CantTargetcheckBox = new System.Windows.Forms.CheckBox();
            this.StealthcheckBox = new System.Windows.Forms.CheckBox();
            this.GhostcheckBox = new System.Windows.Forms.CheckBox();
            this.label53 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.label62 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.HightLevelnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.LowLevelnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.HightSizenumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.LowSizenumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label40 = new System.Windows.Forms.Label();
            this.ModeltextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.MessageArticletextBox = new System.Windows.Forms.TextBox();
            this.ExamineArticletextBox = new System.Windows.Forms.TextBox();
            this.SuffixtextBox = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.ReplaceMobValuescomboBox = new System.Windows.Forms.ComboBox();
            this.VisibleWeaponSlotstextBox = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.ClassTypecomboBox = new System.Windows.Forms.ComboBox();
            this.ItemsListTemplateIDtextBox = new System.Windows.Forms.TextBox();
            this.TranslationIDtextBox = new System.Windows.Forms.TextBox();
            this.EquipmentTemplateIDtextBox = new System.Windows.Forms.TextBox();
            this.PackageIDtextBox = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.RacecomboBox = new System.Windows.Forms.ComboBox();
            this.RacebindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MaxSpeedtextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.GendercomboBox = new System.Windows.Forms.ComboBox();
            this.label57 = new System.Windows.Forms.Label();
            this.AggroLevelUpDown = new System.Windows.Forms.NumericUpDown();
            this.MeleeDamageTypecomboBox = new System.Windows.Forms.ComboBox();
            this.IsCharmablecomboBox = new System.Windows.Forms.ComboBox();
            this.IsCharmablelabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BodyTypecomboBox = new System.Windows.Forms.ComboBox();
            this.AggroRangetextBox = new System.Windows.Forms.TextBox();
            this.TetherRangetextBox = new System.Windows.Forms.TextBox();
            this.MaxDistancetextBox = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.CharismatextBox = new System.Windows.Forms.TextBox();
            this.EmpathytextBox = new System.Windows.Forms.TextBox();
            this.PietytextBox = new System.Windows.Forms.TextBox();
            this.IntelligencetextBox = new System.Windows.Forms.TextBox();
            this.QuicknesstextBox = new System.Windows.Forms.TextBox();
            this.DexteritytextBox = new System.Windows.Forms.TextBox();
            this.ConstitutiontextBox = new System.Windows.Forms.TextBox();
            this.StrengthtextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.EvadeChanceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.BlockChanceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.LeftHandSwingChanceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ParryChanceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.AbilitiesrichTextBox = new System.Windows.Forms.RichTextBox();
            this.StylesrichTextBox = new System.Windows.Forms.RichTextBox();
            this.SpellsrichTextBox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GuildNametextBox = new System.Windows.Forms.TextBox();
            this.FRNametextBox = new System.Windows.Forms.TextBox();
            this.NametextBox = new System.Windows.Forms.TextBox();
            this.TemplateIDtextBox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.FRNamelabel = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NPCTemplatebindingNavigator)).BeginInit();
            this.NPCTemplatebindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NPCTemplatebindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NPCTemplatedataGridView)).BeginInit();
            this.ControlMenu.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.ControlEditor.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TranslationdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TranslationbindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TranslationbindingNavigator)).BeginInit();
            this.TranslationbindingNavigator.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HightLevelnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LowLevelnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HightSizenumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LowSizenumericUpDown)).BeginInit();
            this.groupBox10.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RacebindingSource)).BeginInit();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AggroLevelUpDown)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EvadeChanceNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlockChanceNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftHandSwingChanceNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParryChanceNumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NPCTemplatebindingNavigator
            // 
            this.NPCTemplatebindingNavigator.AddNewItem = null;
            this.NPCTemplatebindingNavigator.BindingSource = this.NPCTemplatebindingSource;
            this.NPCTemplatebindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.NPCTemplatebindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.NPCTemplatebindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.NPCTemplatebindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.NPCTemplatebindingNavigator.Location = new System.Drawing.Point(3, 39);
            this.NPCTemplatebindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.NPCTemplatebindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.NPCTemplatebindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.NPCTemplatebindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.NPCTemplatebindingNavigator.Name = "NPCTemplatebindingNavigator";
            this.NPCTemplatebindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.NPCTemplatebindingNavigator.Size = new System.Drawing.Size(232, 25);
            this.NPCTemplatebindingNavigator.TabIndex = 0;
            this.NPCTemplatebindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.NPCTemplateNavigatorDeleteItem_Click);
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
            // NPCTemplatedataGridView
            // 
            this.NPCTemplatedataGridView.AllowUserToAddRows = false;
            this.NPCTemplatedataGridView.AllowUserToOrderColumns = true;
            this.NPCTemplatedataGridView.AutoGenerateColumns = false;
            this.NPCTemplatedataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.NPCTemplatedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NPCTemplatedataGridView.DataSource = this.NPCTemplatebindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.NPCTemplatedataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.NPCTemplatedataGridView.Location = new System.Drawing.Point(0, 74);
            this.NPCTemplatedataGridView.MultiSelect = false;
            this.NPCTemplatedataGridView.Name = "NPCTemplatedataGridView";
            this.NPCTemplatedataGridView.ReadOnly = true;
            this.NPCTemplatedataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.NPCTemplatedataGridView.Size = new System.Drawing.Size(848, 625);
            this.NPCTemplatedataGridView.TabIndex = 1;
            this.NPCTemplatedataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.NPCTemplatedataGridView_CellContentClick);
            this.NPCTemplatedataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.TranslationdataGridView__CellValueChanged);
            // 
            // ControlMenu
            // 
            this.ControlMenu.Controls.Add(this.button2);
            this.ControlMenu.Controls.Add(this.label45);
            this.ControlMenu.Controls.Add(this.PackageIDSearchcomboBox);
            this.ControlMenu.Controls.Add(this.label42);
            this.ControlMenu.Controls.Add(this.SearchByNPCTemplateNametextBox);
            this.ControlMenu.Controls.Add(this.label44);
            this.ControlMenu.Controls.Add(this.SearchNPCTemplateIDtextBox);
            this.ControlMenu.Controls.Add(this.Classlabel);
            this.ControlMenu.Controls.Add(this.ClassTypeSearchcomboBox);
            this.ControlMenu.Controls.Add(this.NPCTemplatebindingNavigator);
            this.ControlMenu.Location = new System.Drawing.Point(9, -1);
            this.ControlMenu.Name = "ControlMenu";
            this.ControlMenu.Size = new System.Drawing.Size(551, 69);
            this.ControlMenu.TabIndex = 2;
            this.ControlMenu.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(486, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(59, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(256, 18);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(61, 13);
            this.label45.TabIndex = 20;
            this.label45.Text = "PackageID";
            // 
            // PackageIDSearchcomboBox
            // 
            this.PackageIDSearchcomboBox.DisplayMember = "All";
            this.PackageIDSearchcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PackageIDSearchcomboBox.FormattingEnabled = true;
            this.PackageIDSearchcomboBox.Location = new System.Drawing.Point(320, 13);
            this.PackageIDSearchcomboBox.MaxDropDownItems = 15;
            this.PackageIDSearchcomboBox.Name = "PackageIDSearchcomboBox";
            this.PackageIDSearchcomboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PackageIDSearchcomboBox.Size = new System.Drawing.Size(162, 21);
            this.PackageIDSearchcomboBox.Sorted = true;
            this.PackageIDSearchcomboBox.TabIndex = 19;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(256, 46);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(18, 13);
            this.label42.TabIndex = 15;
            this.label42.Text = "ID";
            // 
            // SearchByNPCTemplateNametextBox
            // 
            this.SearchByNPCTemplateNametextBox.Location = new System.Drawing.Point(373, 43);
            this.SearchByNPCTemplateNametextBox.Name = "SearchByNPCTemplateNametextBox";
            this.SearchByNPCTemplateNametextBox.Size = new System.Drawing.Size(172, 20);
            this.SearchByNPCTemplateNametextBox.TabIndex = 18;
            this.SearchByNPCTemplateNametextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(332, 46);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(35, 13);
            this.label44.TabIndex = 17;
            this.label44.Text = "Name";
            // 
            // SearchNPCTemplateIDtextBox
            // 
            this.SearchNPCTemplateIDtextBox.Location = new System.Drawing.Point(271, 43);
            this.SearchNPCTemplateIDtextBox.Name = "SearchNPCTemplateIDtextBox";
            this.SearchNPCTemplateIDtextBox.Size = new System.Drawing.Size(58, 20);
            this.SearchNPCTemplateIDtextBox.TabIndex = 16;
            this.SearchNPCTemplateIDtextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Classlabel
            // 
            this.Classlabel.AutoSize = true;
            this.Classlabel.Location = new System.Drawing.Point(2, 16);
            this.Classlabel.Name = "Classlabel";
            this.Classlabel.Size = new System.Drawing.Size(56, 13);
            this.Classlabel.TabIndex = 11;
            this.Classlabel.Text = "ClassType";
            // 
            // ClassTypeSearchcomboBox
            // 
            this.ClassTypeSearchcomboBox.DisplayMember = "All";
            this.ClassTypeSearchcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClassTypeSearchcomboBox.FormattingEnabled = true;
            this.ClassTypeSearchcomboBox.Location = new System.Drawing.Point(58, 13);
            this.ClassTypeSearchcomboBox.MaxDropDownItems = 15;
            this.ClassTypeSearchcomboBox.Name = "ClassTypeSearchcomboBox";
            this.ClassTypeSearchcomboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ClassTypeSearchcomboBox.Size = new System.Drawing.Size(192, 21);
            this.ClassTypeSearchcomboBox.Sorted = true;
            this.ClassTypeSearchcomboBox.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AddNPCTemplateButton);
            this.groupBox2.Controls.Add(this.NPCTemplateListingButton);
            this.groupBox2.Controls.Add(this.Savebutton);
            this.groupBox2.Controls.Add(this.SaveNewbutton);
            this.groupBox2.Location = new System.Drawing.Point(566, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(282, 68);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            // 
            // AddNPCTemplateButton
            // 
            this.AddNPCTemplateButton.Location = new System.Drawing.Point(11, 10);
            this.AddNPCTemplateButton.Name = "AddNPCTemplateButton";
            this.AddNPCTemplateButton.Size = new System.Drawing.Size(138, 23);
            this.AddNPCTemplateButton.TabIndex = 22;
            this.AddNPCTemplateButton.Text = "Add New NPCTemplate";
            this.AddNPCTemplateButton.UseVisualStyleBackColor = true;
            this.AddNPCTemplateButton.Click += new System.EventHandler(this.AddNewNPCTemplate_Click);
            // 
            // NPCTemplateListingButton
            // 
            this.NPCTemplateListingButton.Location = new System.Drawing.Point(155, 10);
            this.NPCTemplateListingButton.Name = "NPCTemplateListingButton";
            this.NPCTemplateListingButton.Size = new System.Drawing.Size(115, 23);
            this.NPCTemplateListingButton.TabIndex = 23;
            this.NPCTemplateListingButton.Text = "NPCTemplate Listing";
            this.NPCTemplateListingButton.UseVisualStyleBackColor = true;
            this.NPCTemplateListingButton.Click += new System.EventHandler(this.NPCTemplateListing_Click);
            // 
            // Savebutton
            // 
            this.Savebutton.Location = new System.Drawing.Point(63, 40);
            this.Savebutton.Name = "Savebutton";
            this.Savebutton.Size = new System.Drawing.Size(156, 23);
            this.Savebutton.TabIndex = 20;
            this.Savebutton.Text = "Save Loaded NPCTemplate";
            this.Savebutton.UseVisualStyleBackColor = true;
            this.Savebutton.Click += new System.EventHandler(this.SaveLoadedNPCTemplate_Click);
            // 
            // SaveNewbutton
            // 
            this.SaveNewbutton.Location = new System.Drawing.Point(74, 41);
            this.SaveNewbutton.Name = "SaveNewbutton";
            this.SaveNewbutton.Size = new System.Drawing.Size(145, 22);
            this.SaveNewbutton.TabIndex = 21;
            this.SaveNewbutton.Text = "Save New NPCTemplate";
            this.SaveNewbutton.UseVisualStyleBackColor = true;
            this.SaveNewbutton.Click += new System.EventHandler(this.SaveNewbutton_Click);
            // 
            // ControlEditor
            // 
            this.ControlEditor.Controls.Add(this.tabPage1);
            this.ControlEditor.Location = new System.Drawing.Point(9, 74);
            this.ControlEditor.Name = "ControlEditor";
            this.ControlEditor.SelectedIndex = 0;
            this.ControlEditor.Size = new System.Drawing.Size(839, 611);
            this.ControlEditor.TabIndex = 24;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox14);
            this.tabPage1.Controls.Add(this.groupBox13);
            this.tabPage1.Controls.Add(this.groupBox12);
            this.tabPage1.Controls.Add(this.groupBox11);
            this.tabPage1.Controls.Add(this.groupBox10);
            this.tabPage1.Controls.Add(this.groupBox9);
            this.tabPage1.Controls.Add(this.groupBox8);
            this.tabPage1.Controls.Add(this.groupBox7);
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(831, 585);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "NPCTemplate Editor";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.TranslationdataGridView);
            this.groupBox14.Controls.Add(this.TranslationbindingNavigator);
            this.groupBox14.Location = new System.Drawing.Point(3, 425);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(823, 154);
            this.groupBox14.TabIndex = 53;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Translation";
            // 
            // TranslationdataGridView
            // 
            this.TranslationdataGridView.AllowUserToAddRows = false;
            this.TranslationdataGridView.AllowUserToOrderColumns = true;
            this.TranslationdataGridView.AutoGenerateColumns = false;
            this.TranslationdataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TranslationdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TranslationdataGridView.DataSource = this.TranslationbindingSource;
            this.TranslationdataGridView.Location = new System.Drawing.Point(3, 44);
            this.TranslationdataGridView.MultiSelect = false;
            this.TranslationdataGridView.Name = "TranslationdataGridView";
            this.TranslationdataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.TranslationdataGridView.Size = new System.Drawing.Size(547, 107);
            this.TranslationdataGridView.TabIndex = 1;
            // 
            // TranslationbindingNavigator
            // 
            this.TranslationbindingNavigator.AddNewItem = null;
            this.TranslationbindingNavigator.BindingSource = this.TranslationbindingSource;
            this.TranslationbindingNavigator.CountItem = this.bindingNavigatorCountItem1;
            this.TranslationbindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem1;
            this.TranslationbindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.TranslationbindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.TranslationbindingNavigator.Location = new System.Drawing.Point(3, 16);
            this.TranslationbindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
            this.TranslationbindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem1;
            this.TranslationbindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.TranslationbindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
            this.TranslationbindingNavigator.Name = "TranslationbindingNavigator";
            this.TranslationbindingNavigator.PositionItem = this.bindingNavigatorPositionItem1;
            this.TranslationbindingNavigator.Size = new System.Drawing.Size(232, 25);
            this.TranslationbindingNavigator.TabIndex = 0;
            this.TranslationbindingNavigator.Text = "bindingNavigator2";
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
            this.bindingNavigatorDeleteItem1.Click += new System.EventHandler(this.TranslationdataGridViewbindingNavigatorDeleteItem1_Click);
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
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.checkBox7);
            this.groupBox13.Controls.Add(this.label60);
            this.groupBox13.Controls.Add(this.checkBox1);
            this.groupBox13.Controls.Add(this.checkBox2);
            this.groupBox13.Controls.Add(this.checkBox3);
            this.groupBox13.Controls.Add(this.checkBox4);
            this.groupBox13.Controls.Add(this.checkBox5);
            this.groupBox13.Controls.Add(this.label54);
            this.groupBox13.Controls.Add(this.label55);
            this.groupBox13.Controls.Add(this.label56);
            this.groupBox13.Controls.Add(this.label58);
            this.groupBox13.Controls.Add(this.label59);
            this.groupBox13.Enabled = false;
            this.groupBox13.Location = new System.Drawing.Point(562, 278);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(264, 146);
            this.groupBox13.TabIndex = 52;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "VisibleWeaponSlots";
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(85, 59);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(15, 14);
            this.checkBox7.TabIndex = 31;
            this.checkBox7.UseVisualStyleBackColor = true;
            this.checkBox7.CheckedChanged += new System.EventHandler(this.VisibleWeaponSlots_CheckedChanged);
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(10, 57);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(57, 13);
            this.label60.TabIndex = 30;
            this.label60.Text = "Two Hand";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(85, 34);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 29;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.VisibleWeaponSlots_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(224, 59);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 28;
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.VisibleWeaponSlots_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(224, 34);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(15, 14);
            this.checkBox3.TabIndex = 27;
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.VisibleWeaponSlots_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(85, 83);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(15, 14);
            this.checkBox4.TabIndex = 26;
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.VisibleWeaponSlots_CheckedChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(224, 84);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(15, 14);
            this.checkBox5.TabIndex = 25;
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.VisibleWeaponSlots_CheckedChanged);
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(6, 34);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(61, 13);
            this.label54.TabIndex = 23;
            this.label54.Text = "Right Hand";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(13, 84);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(54, 13);
            this.label55.TabIndex = 22;
            this.label55.Text = "Left Hand";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(173, 60);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(49, 13);
            this.label56.TabIndex = 21;
            this.label56.Text = "Distance";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(111, 84);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(111, 13);
            this.label58.TabIndex = 19;
            this.label58.Text = "Left and Two Handed";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(119, 34);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(103, 13);
            this.label59.TabIndex = 18;
            this.label59.Text = "Right and Left Hand";
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.SwimmingcheckBox);
            this.groupBox12.Controls.Add(this.TorchcheckBox);
            this.groupBox12.Controls.Add(this.StatuecheckBox);
            this.groupBox12.Controls.Add(this.PeacecheckBox);
            this.groupBox12.Controls.Add(this.FlyingcheckBox);
            this.groupBox12.Controls.Add(this.DontShowNamecheckBox);
            this.groupBox12.Controls.Add(this.CantTargetcheckBox);
            this.groupBox12.Controls.Add(this.StealthcheckBox);
            this.groupBox12.Controls.Add(this.GhostcheckBox);
            this.groupBox12.Controls.Add(this.label53);
            this.groupBox12.Controls.Add(this.label52);
            this.groupBox12.Controls.Add(this.label51);
            this.groupBox12.Controls.Add(this.label50);
            this.groupBox12.Controls.Add(this.label49);
            this.groupBox12.Controls.Add(this.label48);
            this.groupBox12.Controls.Add(this.label47);
            this.groupBox12.Controls.Add(this.label46);
            this.groupBox12.Controls.Add(this.label9);
            this.groupBox12.Location = new System.Drawing.Point(273, 296);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(283, 90);
            this.groupBox12.TabIndex = 51;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Flags";
            // 
            // SwimmingcheckBox
            // 
            this.SwimmingcheckBox.AutoSize = true;
            this.SwimmingcheckBox.Location = new System.Drawing.Point(173, 70);
            this.SwimmingcheckBox.Name = "SwimmingcheckBox";
            this.SwimmingcheckBox.Size = new System.Drawing.Size(15, 14);
            this.SwimmingcheckBox.TabIndex = 17;
            this.SwimmingcheckBox.UseVisualStyleBackColor = true;
            // 
            // TorchcheckBox
            // 
            this.TorchcheckBox.AutoSize = true;
            this.TorchcheckBox.Location = new System.Drawing.Point(52, 69);
            this.TorchcheckBox.Name = "TorchcheckBox";
            this.TorchcheckBox.Size = new System.Drawing.Size(15, 14);
            this.TorchcheckBox.TabIndex = 16;
            this.TorchcheckBox.UseVisualStyleBackColor = true;
            // 
            // StatuecheckBox
            // 
            this.StatuecheckBox.AutoSize = true;
            this.StatuecheckBox.Location = new System.Drawing.Point(256, 69);
            this.StatuecheckBox.Name = "StatuecheckBox";
            this.StatuecheckBox.Size = new System.Drawing.Size(15, 14);
            this.StatuecheckBox.TabIndex = 15;
            this.StatuecheckBox.UseVisualStyleBackColor = true;
            // 
            // PeacecheckBox
            // 
            this.PeacecheckBox.AutoSize = true;
            this.PeacecheckBox.Location = new System.Drawing.Point(256, 22);
            this.PeacecheckBox.Name = "PeacecheckBox";
            this.PeacecheckBox.Size = new System.Drawing.Size(15, 14);
            this.PeacecheckBox.TabIndex = 14;
            this.PeacecheckBox.UseVisualStyleBackColor = true;
            // 
            // FlyingcheckBox
            // 
            this.FlyingcheckBox.AutoSize = true;
            this.FlyingcheckBox.Location = new System.Drawing.Point(256, 46);
            this.FlyingcheckBox.Name = "FlyingcheckBox";
            this.FlyingcheckBox.Size = new System.Drawing.Size(15, 14);
            this.FlyingcheckBox.TabIndex = 13;
            this.FlyingcheckBox.UseVisualStyleBackColor = true;
            // 
            // DontShowNamecheckBox
            // 
            this.DontShowNamecheckBox.AutoSize = true;
            this.DontShowNamecheckBox.Location = new System.Drawing.Point(173, 22);
            this.DontShowNamecheckBox.Name = "DontShowNamecheckBox";
            this.DontShowNamecheckBox.Size = new System.Drawing.Size(15, 14);
            this.DontShowNamecheckBox.TabIndex = 12;
            this.DontShowNamecheckBox.UseVisualStyleBackColor = true;
            // 
            // CantTargetcheckBox
            // 
            this.CantTargetcheckBox.AutoSize = true;
            this.CantTargetcheckBox.Location = new System.Drawing.Point(173, 45);
            this.CantTargetcheckBox.Name = "CantTargetcheckBox";
            this.CantTargetcheckBox.Size = new System.Drawing.Size(15, 14);
            this.CantTargetcheckBox.TabIndex = 11;
            this.CantTargetcheckBox.UseVisualStyleBackColor = true;
            // 
            // StealthcheckBox
            // 
            this.StealthcheckBox.AutoSize = true;
            this.StealthcheckBox.Location = new System.Drawing.Point(52, 45);
            this.StealthcheckBox.Name = "StealthcheckBox";
            this.StealthcheckBox.Size = new System.Drawing.Size(15, 14);
            this.StealthcheckBox.TabIndex = 10;
            this.StealthcheckBox.UseVisualStyleBackColor = true;
            // 
            // GhostcheckBox
            // 
            this.GhostcheckBox.AutoSize = true;
            this.GhostcheckBox.Location = new System.Drawing.Point(52, 21);
            this.GhostcheckBox.Name = "GhostcheckBox";
            this.GhostcheckBox.Size = new System.Drawing.Size(15, 14);
            this.GhostcheckBox.TabIndex = 9;
            this.GhostcheckBox.UseVisualStyleBackColor = true;
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(113, 70);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(54, 13);
            this.label53.TabIndex = 8;
            this.label53.Text = "Swimming";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(206, 70);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(38, 13);
            this.label52.TabIndex = 7;
            this.label52.Text = "Statue";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(11, 70);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(35, 13);
            this.label51.TabIndex = 6;
            this.label51.Text = "Torch";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(207, 48);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(34, 13);
            this.label50.TabIndex = 5;
            this.label50.Text = "Flying";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(206, 24);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(38, 13);
            this.label49.TabIndex = 4;
            this.label49.Text = "Peace";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(107, 48);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(60, 13);
            this.label48.TabIndex = 3;
            this.label48.Text = "CantTarget";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(82, 24);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(85, 13);
            this.label47.TabIndex = 2;
            this.label47.Text = "DontShowName";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(6, 48);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(40, 13);
            this.label46.TabIndex = 1;
            this.label46.Text = "Stealth";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Ghost";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.label62);
            this.groupBox11.Controls.Add(this.label61);
            this.groupBox11.Controls.Add(this.label31);
            this.groupBox11.Controls.Add(this.label15);
            this.groupBox11.Controls.Add(this.HightLevelnumericUpDown);
            this.groupBox11.Controls.Add(this.LowLevelnumericUpDown);
            this.groupBox11.Controls.Add(this.HightSizenumericUpDown);
            this.groupBox11.Controls.Add(this.LowSizenumericUpDown);
            this.groupBox11.Controls.Add(this.button1);
            this.groupBox11.Controls.Add(this.label40);
            this.groupBox11.Controls.Add(this.ModeltextBox);
            this.groupBox11.Controls.Add(this.label12);
            this.groupBox11.Controls.Add(this.label13);
            this.groupBox11.Location = new System.Drawing.Point(3, 317);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(264, 90);
            this.groupBox11.TabIndex = 50;
            this.groupBox11.TabStop = false;
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Location = new System.Drawing.Point(149, 13);
            this.label62.Name = "label62";
            this.label62.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label62.Size = new System.Drawing.Size(60, 13);
            this.label62.TabIndex = 51;
            this.label62.Text = "Max. Value";
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(149, 38);
            this.label61.Name = "label61";
            this.label61.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label61.Size = new System.Drawing.Size(60, 13);
            this.label61.TabIndex = 50;
            this.label61.Text = "Max. Value";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(41, 13);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(57, 13);
            this.label31.TabIndex = 49;
            this.label31.Text = "Min. Value";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(41, 38);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 13);
            this.label15.TabIndex = 48;
            this.label15.Text = "Min. Value";
            // 
            // HightLevelnumericUpDown
            // 
            this.HightLevelnumericUpDown.Location = new System.Drawing.Point(209, 11);
            this.HightLevelnumericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.HightLevelnumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.HightLevelnumericUpDown.Name = "HightLevelnumericUpDown";
            this.HightLevelnumericUpDown.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HightLevelnumericUpDown.Size = new System.Drawing.Size(52, 20);
            this.HightLevelnumericUpDown.TabIndex = 47;
            this.HightLevelnumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.HightLevelnumericUpDown.ValueChanged += new System.EventHandler(this.HightLevelnumericUpDown_ValueChanged);
            // 
            // LowLevelnumericUpDown
            // 
            this.LowLevelnumericUpDown.Location = new System.Drawing.Point(104, 11);
            this.LowLevelnumericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.LowLevelnumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.LowLevelnumericUpDown.Name = "LowLevelnumericUpDown";
            this.LowLevelnumericUpDown.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LowLevelnumericUpDown.Size = new System.Drawing.Size(45, 20);
            this.LowLevelnumericUpDown.TabIndex = 46;
            this.LowLevelnumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.LowLevelnumericUpDown.ValueChanged += new System.EventHandler(this.LowLevelnumericUpDown_ValueChanged);
            // 
            // HightSizenumericUpDown
            // 
            this.HightSizenumericUpDown.Location = new System.Drawing.Point(209, 36);
            this.HightSizenumericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.HightSizenumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.HightSizenumericUpDown.Name = "HightSizenumericUpDown";
            this.HightSizenumericUpDown.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HightSizenumericUpDown.Size = new System.Drawing.Size(52, 20);
            this.HightSizenumericUpDown.TabIndex = 45;
            this.HightSizenumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.HightSizenumericUpDown.ValueChanged += new System.EventHandler(this.HightSizenumericUpDown_ValueChanged);
            // 
            // LowSizenumericUpDown
            // 
            this.LowSizenumericUpDown.Location = new System.Drawing.Point(104, 36);
            this.LowSizenumericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.LowSizenumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.LowSizenumericUpDown.Name = "LowSizenumericUpDown";
            this.LowSizenumericUpDown.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LowSizenumericUpDown.Size = new System.Drawing.Size(45, 20);
            this.LowSizenumericUpDown.TabIndex = 44;
            this.LowSizenumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.LowSizenumericUpDown.ValueChanged += new System.EventHandler(this.LowSizenumericUpDown_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(220, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 23);
            this.button1.TabIndex = 42;
            this.button1.Text = "Find";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(2, 13);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(33, 13);
            this.label40.TabIndex = 39;
            this.label40.Text = "Level";
            // 
            // ModeltextBox
            // 
            this.ModeltextBox.Location = new System.Drawing.Point(42, 60);
            this.ModeltextBox.Name = "ModeltextBox";
            this.ModeltextBox.Size = new System.Drawing.Size(172, 20);
            this.ModeltextBox.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 38);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Size";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 63);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Model";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.MessageArticletextBox);
            this.groupBox10.Controls.Add(this.ExamineArticletextBox);
            this.groupBox10.Controls.Add(this.SuffixtextBox);
            this.groupBox10.Controls.Add(this.label29);
            this.groupBox10.Controls.Add(this.label28);
            this.groupBox10.Controls.Add(this.label43);
            this.groupBox10.Location = new System.Drawing.Point(562, 192);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(264, 84);
            this.groupBox10.TabIndex = 49;
            this.groupBox10.TabStop = false;
            // 
            // MessageArticletextBox
            // 
            this.MessageArticletextBox.Location = new System.Drawing.Point(87, 60);
            this.MessageArticletextBox.Name = "MessageArticletextBox";
            this.MessageArticletextBox.Size = new System.Drawing.Size(171, 20);
            this.MessageArticletextBox.TabIndex = 45;
            // 
            // ExamineArticletextBox
            // 
            this.ExamineArticletextBox.Location = new System.Drawing.Point(87, 36);
            this.ExamineArticletextBox.Name = "ExamineArticletextBox";
            this.ExamineArticletextBox.Size = new System.Drawing.Size(171, 20);
            this.ExamineArticletextBox.TabIndex = 44;
            // 
            // SuffixtextBox
            // 
            this.SuffixtextBox.Location = new System.Drawing.Point(87, 13);
            this.SuffixtextBox.Name = "SuffixtextBox";
            this.SuffixtextBox.Size = new System.Drawing.Size(171, 20);
            this.SuffixtextBox.TabIndex = 43;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(48, 16);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(33, 13);
            this.label29.TabIndex = 28;
            this.label29.Text = "Suffix";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(6, 39);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(76, 13);
            this.label28.TabIndex = 27;
            this.label28.Text = "ExamineArticle";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(3, 62);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(79, 13);
            this.label43.TabIndex = 42;
            this.label43.Text = "MessageArticle";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.ReplaceMobValuescomboBox);
            this.groupBox9.Controls.Add(this.VisibleWeaponSlotstextBox);
            this.groupBox9.Controls.Add(this.label34);
            this.groupBox9.Controls.Add(this.label33);
            this.groupBox9.Controls.Add(this.ClassTypecomboBox);
            this.groupBox9.Controls.Add(this.ItemsListTemplateIDtextBox);
            this.groupBox9.Controls.Add(this.TranslationIDtextBox);
            this.groupBox9.Controls.Add(this.EquipmentTemplateIDtextBox);
            this.groupBox9.Controls.Add(this.PackageIDtextBox);
            this.groupBox9.Controls.Add(this.label41);
            this.groupBox9.Controls.Add(this.label10);
            this.groupBox9.Controls.Add(this.label35);
            this.groupBox9.Controls.Add(this.label32);
            this.groupBox9.Controls.Add(this.label30);
            this.groupBox9.Location = new System.Drawing.Point(562, 6);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(264, 187);
            this.groupBox9.TabIndex = 48;
            this.groupBox9.TabStop = false;
            // 
            // ReplaceMobValuescomboBox
            // 
            this.ReplaceMobValuescomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ReplaceMobValuescomboBox.FormattingEnabled = true;
            this.ReplaceMobValuescomboBox.Items.AddRange(new object[] {
            "False",
            "True"});
            this.ReplaceMobValuescomboBox.Location = new System.Drawing.Point(191, 164);
            this.ReplaceMobValuescomboBox.Name = "ReplaceMobValuescomboBox";
            this.ReplaceMobValuescomboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ReplaceMobValuescomboBox.Size = new System.Drawing.Size(67, 21);
            this.ReplaceMobValuescomboBox.TabIndex = 52;
            // 
            // VisibleWeaponSlotstextBox
            // 
            this.VisibleWeaponSlotstextBox.Location = new System.Drawing.Point(191, 141);
            this.VisibleWeaponSlotstextBox.Name = "VisibleWeaponSlotstextBox";
            this.VisibleWeaponSlotstextBox.Size = new System.Drawing.Size(67, 20);
            this.VisibleWeaponSlotstextBox.TabIndex = 51;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(91, 144);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(101, 13);
            this.label34.TabIndex = 50;
            this.label34.Text = "VisibleWeaponSlots";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(92, 168);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(100, 13);
            this.label33.TabIndex = 49;
            this.label33.Text = "ReplaceMobValues";
            // 
            // ClassTypecomboBox
            // 
            this.ClassTypecomboBox.FormattingEnabled = true;
            this.ClassTypecomboBox.Location = new System.Drawing.Point(61, 11);
            this.ClassTypecomboBox.Name = "ClassTypecomboBox";
            this.ClassTypecomboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ClassTypecomboBox.Size = new System.Drawing.Size(197, 21);
            this.ClassTypecomboBox.Sorted = true;
            this.ClassTypecomboBox.TabIndex = 47;
            // 
            // ItemsListTemplateIDtextBox
            // 
            this.ItemsListTemplateIDtextBox.Location = new System.Drawing.Point(117, 89);
            this.ItemsListTemplateIDtextBox.Name = "ItemsListTemplateIDtextBox";
            this.ItemsListTemplateIDtextBox.Size = new System.Drawing.Size(141, 20);
            this.ItemsListTemplateIDtextBox.TabIndex = 46;
            // 
            // TranslationIDtextBox
            // 
            this.TranslationIDtextBox.Location = new System.Drawing.Point(117, 115);
            this.TranslationIDtextBox.Name = "TranslationIDtextBox";
            this.TranslationIDtextBox.Size = new System.Drawing.Size(141, 20);
            this.TranslationIDtextBox.TabIndex = 45;
            this.TranslationIDtextBox.TextChanged += new System.EventHandler(this.TranslationID_TextChanged);
            // 
            // EquipmentTemplateIDtextBox
            // 
            this.EquipmentTemplateIDtextBox.Location = new System.Drawing.Point(117, 39);
            this.EquipmentTemplateIDtextBox.Name = "EquipmentTemplateIDtextBox";
            this.EquipmentTemplateIDtextBox.Size = new System.Drawing.Size(141, 20);
            this.EquipmentTemplateIDtextBox.TabIndex = 44;
            // 
            // PackageIDtextBox
            // 
            this.PackageIDtextBox.Location = new System.Drawing.Point(117, 65);
            this.PackageIDtextBox.Name = "PackageIDtextBox";
            this.PackageIDtextBox.Size = new System.Drawing.Size(141, 20);
            this.PackageIDtextBox.TabIndex = 41;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(6, 16);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(56, 13);
            this.label41.TabIndex = 40;
            this.label41.Text = "ClassType";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "EquipmentTemplateID";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(57, 68);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(61, 13);
            this.label35.TabIndex = 34;
            this.label35.Text = "PackageID";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(20, 92);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(98, 13);
            this.label32.TabIndex = 31;
            this.label32.Text = "ItemListTemplateID";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(48, 118);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(70, 13);
            this.label30.TabIndex = 29;
            this.label30.Text = "TranslationID";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.RacecomboBox);
            this.groupBox8.Controls.Add(this.MaxSpeedtextBox);
            this.groupBox8.Controls.Add(this.label11);
            this.groupBox8.Controls.Add(this.label39);
            this.groupBox8.Location = new System.Drawing.Point(209, 9);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(157, 72);
            this.groupBox8.TabIndex = 43;
            this.groupBox8.TabStop = false;
            // 
            // RacecomboBox
            // 
            this.RacecomboBox.DataSource = this.RacebindingSource;
            this.RacecomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RacecomboBox.FormattingEnabled = true;
            this.RacecomboBox.Location = new System.Drawing.Point(50, 13);
            this.RacecomboBox.Name = "RacecomboBox";
            this.RacecomboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RacecomboBox.Size = new System.Drawing.Size(104, 21);
            this.RacecomboBox.TabIndex = 43;
            // 
            // MaxSpeedtextBox
            // 
            this.MaxSpeedtextBox.Location = new System.Drawing.Point(73, 45);
            this.MaxSpeedtextBox.Name = "MaxSpeedtextBox";
            this.MaxSpeedtextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MaxSpeedtextBox.Size = new System.Drawing.Size(56, 20);
            this.MaxSpeedtextBox.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "MaxSpeed";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(11, 16);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(33, 13);
            this.label39.TabIndex = 38;
            this.label39.Text = "Race";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.GendercomboBox);
            this.groupBox7.Controls.Add(this.label57);
            this.groupBox7.Controls.Add(this.AggroLevelUpDown);
            this.groupBox7.Controls.Add(this.MeleeDamageTypecomboBox);
            this.groupBox7.Controls.Add(this.IsCharmablecomboBox);
            this.groupBox7.Controls.Add(this.IsCharmablelabel);
            this.groupBox7.Controls.Add(this.label8);
            this.groupBox7.Controls.Add(this.BodyTypecomboBox);
            this.groupBox7.Controls.Add(this.AggroRangetextBox);
            this.groupBox7.Controls.Add(this.TetherRangetextBox);
            this.groupBox7.Controls.Add(this.MaxDistancetextBox);
            this.groupBox7.Controls.Add(this.label38);
            this.groupBox7.Controls.Add(this.label36);
            this.groupBox7.Controls.Add(this.label37);
            this.groupBox7.Controls.Add(this.label19);
            this.groupBox7.Controls.Add(this.label18);
            this.groupBox7.Location = new System.Drawing.Point(3, 121);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(200, 197);
            this.groupBox7.TabIndex = 47;
            this.groupBox7.TabStop = false;
            // 
            // GendercomboBox
            // 
            this.GendercomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GendercomboBox.FormattingEnabled = true;
            this.GendercomboBox.Items.AddRange(new object[] {
            "Neutral",
            "Male",
            "Female"});
            this.GendercomboBox.Location = new System.Drawing.Point(108, 84);
            this.GendercomboBox.Name = "GendercomboBox";
            this.GendercomboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GendercomboBox.Size = new System.Drawing.Size(86, 21);
            this.GendercomboBox.TabIndex = 51;
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(60, 87);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(42, 13);
            this.label57.TabIndex = 50;
            this.label57.Text = "Gender";
            // 
            // AggroLevelUpDown
            // 
            this.AggroLevelUpDown.Location = new System.Drawing.Point(110, 154);
            this.AggroLevelUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.AggroLevelUpDown.Name = "AggroLevelUpDown";
            this.AggroLevelUpDown.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AggroLevelUpDown.Size = new System.Drawing.Size(65, 20);
            this.AggroLevelUpDown.TabIndex = 49;
            this.AggroLevelUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // MeleeDamageTypecomboBox
            // 
            this.MeleeDamageTypecomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MeleeDamageTypecomboBox.FormattingEnabled = true;
            this.MeleeDamageTypecomboBox.Items.AddRange(new object[] {
            "Natural",
            "Crush",
            "Slash",
            "Thrust",
            "Body",
            "Cold",
            "Energy",
            "Heat",
            "Matter",
            "Spirit"});
            this.MeleeDamageTypecomboBox.Location = new System.Drawing.Point(108, 12);
            this.MeleeDamageTypecomboBox.Name = "MeleeDamageTypecomboBox";
            this.MeleeDamageTypecomboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MeleeDamageTypecomboBox.Size = new System.Drawing.Size(86, 21);
            this.MeleeDamageTypecomboBox.TabIndex = 48;
            // 
            // IsCharmablecomboBox
            // 
            this.IsCharmablecomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IsCharmablecomboBox.FormattingEnabled = true;
            this.IsCharmablecomboBox.Items.AddRange(new object[] {
            "False",
            "True"});
            this.IsCharmablecomboBox.Location = new System.Drawing.Point(108, 35);
            this.IsCharmablecomboBox.Name = "IsCharmablecomboBox";
            this.IsCharmablecomboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.IsCharmablecomboBox.Size = new System.Drawing.Size(86, 21);
            this.IsCharmablecomboBox.TabIndex = 47;
            this.IsCharmablecomboBox.Visible = false;
            // 
            // IsCharmablelabel
            // 
            this.IsCharmablelabel.AutoSize = true;
            this.IsCharmablelabel.Location = new System.Drawing.Point(39, 39);
            this.IsCharmablelabel.Name = "IsCharmablelabel";
            this.IsCharmablelabel.Size = new System.Drawing.Size(65, 13);
            this.IsCharmablelabel.TabIndex = 46;
            this.IsCharmablelabel.Text = "IsCharmable";
            this.IsCharmablelabel.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 13);
            this.label8.TabIndex = 45;
            this.label8.Text = "MeleeDamageType";
            // 
            // BodyTypecomboBox
            // 
            this.BodyTypecomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BodyTypecomboBox.FormattingEnabled = true;
            this.BodyTypecomboBox.Items.AddRange(new object[] {
            "None",
            "Animal",
            "Demon",
            "Dragon",
            "Elemental",
            "Giant",
            "Humanoid",
            "Insect",
            "Magical",
            "Reptile",
            "Plant",
            "Undead"});
            this.BodyTypecomboBox.Location = new System.Drawing.Point(108, 59);
            this.BodyTypecomboBox.Name = "BodyTypecomboBox";
            this.BodyTypecomboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BodyTypecomboBox.Size = new System.Drawing.Size(86, 21);
            this.BodyTypecomboBox.TabIndex = 44;
            // 
            // AggroRangetextBox
            // 
            this.AggroRangetextBox.Location = new System.Drawing.Point(110, 175);
            this.AggroRangetextBox.Name = "AggroRangetextBox";
            this.AggroRangetextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AggroRangetextBox.Size = new System.Drawing.Size(65, 20);
            this.AggroRangetextBox.TabIndex = 42;
            // 
            // TetherRangetextBox
            // 
            this.TetherRangetextBox.Location = new System.Drawing.Point(110, 130);
            this.TetherRangetextBox.Name = "TetherRangetextBox";
            this.TetherRangetextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TetherRangetextBox.Size = new System.Drawing.Size(65, 20);
            this.TetherRangetextBox.TabIndex = 40;
            // 
            // MaxDistancetextBox
            // 
            this.MaxDistancetextBox.Location = new System.Drawing.Point(110, 108);
            this.MaxDistancetextBox.Name = "MaxDistancetextBox";
            this.MaxDistancetextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MaxDistancetextBox.Size = new System.Drawing.Size(65, 20);
            this.MaxDistancetextBox.TabIndex = 39;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(47, 63);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(55, 13);
            this.label38.TabIndex = 37;
            this.label38.Text = "BodyType";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(34, 136);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(70, 13);
            this.label36.TabIndex = 35;
            this.label36.Text = "TetherRange";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(35, 112);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(69, 13);
            this.label37.TabIndex = 36;
            this.label37.Text = "MaxDistance";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(42, 156);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(61, 13);
            this.label19.TabIndex = 18;
            this.label19.Text = "AggroLevel";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(36, 180);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(67, 13);
            this.label18.TabIndex = 17;
            this.label18.Text = "AggroRange";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.CharismatextBox);
            this.groupBox5.Controls.Add(this.EmpathytextBox);
            this.groupBox5.Controls.Add(this.PietytextBox);
            this.groupBox5.Controls.Add(this.IntelligencetextBox);
            this.groupBox5.Controls.Add(this.QuicknesstextBox);
            this.groupBox5.Controls.Add(this.DexteritytextBox);
            this.groupBox5.Controls.Add(this.ConstitutiontextBox);
            this.groupBox5.Controls.Add(this.StrengthtextBox);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.label25);
            this.groupBox5.Controls.Add(this.label22);
            this.groupBox5.Controls.Add(this.label26);
            this.groupBox5.Controls.Add(this.label27);
            this.groupBox5.Controls.Add(this.label24);
            this.groupBox5.Controls.Add(this.label21);
            this.groupBox5.Controls.Add(this.label23);
            this.groupBox5.Location = new System.Drawing.Point(209, 89);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(157, 207);
            this.groupBox5.TabIndex = 46;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Stats";
            // 
            // CharismatextBox
            // 
            this.CharismatextBox.Location = new System.Drawing.Point(91, 179);
            this.CharismatextBox.Name = "CharismatextBox";
            this.CharismatextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CharismatextBox.Size = new System.Drawing.Size(57, 20);
            this.CharismatextBox.TabIndex = 34;
            // 
            // EmpathytextBox
            // 
            this.EmpathytextBox.Location = new System.Drawing.Point(91, 156);
            this.EmpathytextBox.Name = "EmpathytextBox";
            this.EmpathytextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.EmpathytextBox.Size = new System.Drawing.Size(57, 20);
            this.EmpathytextBox.TabIndex = 33;
            // 
            // PietytextBox
            // 
            this.PietytextBox.Location = new System.Drawing.Point(91, 132);
            this.PietytextBox.Name = "PietytextBox";
            this.PietytextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PietytextBox.Size = new System.Drawing.Size(57, 20);
            this.PietytextBox.TabIndex = 32;
            // 
            // IntelligencetextBox
            // 
            this.IntelligencetextBox.Location = new System.Drawing.Point(91, 109);
            this.IntelligencetextBox.Name = "IntelligencetextBox";
            this.IntelligencetextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.IntelligencetextBox.Size = new System.Drawing.Size(57, 20);
            this.IntelligencetextBox.TabIndex = 31;
            // 
            // QuicknesstextBox
            // 
            this.QuicknesstextBox.Location = new System.Drawing.Point(91, 83);
            this.QuicknesstextBox.Name = "QuicknesstextBox";
            this.QuicknesstextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.QuicknesstextBox.Size = new System.Drawing.Size(57, 20);
            this.QuicknesstextBox.TabIndex = 30;
            // 
            // DexteritytextBox
            // 
            this.DexteritytextBox.Location = new System.Drawing.Point(91, 60);
            this.DexteritytextBox.Name = "DexteritytextBox";
            this.DexteritytextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DexteritytextBox.Size = new System.Drawing.Size(57, 20);
            this.DexteritytextBox.TabIndex = 29;
            // 
            // ConstitutiontextBox
            // 
            this.ConstitutiontextBox.Location = new System.Drawing.Point(91, 36);
            this.ConstitutiontextBox.Name = "ConstitutiontextBox";
            this.ConstitutiontextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ConstitutiontextBox.Size = new System.Drawing.Size(57, 20);
            this.ConstitutiontextBox.TabIndex = 28;
            // 
            // StrengthtextBox
            // 
            this.StrengthtextBox.Location = new System.Drawing.Point(91, 13);
            this.StrengthtextBox.Name = "StrengthtextBox";
            this.StrengthtextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StrengthtextBox.Size = new System.Drawing.Size(57, 20);
            this.StrengthtextBox.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Strength";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(28, 86);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(57, 13);
            this.label25.TabIndex = 24;
            this.label25.Text = "Quickness";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(35, 183);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(50, 13);
            this.label22.TabIndex = 21;
            this.label22.Text = "Charisma";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(37, 64);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(48, 13);
            this.label26.TabIndex = 25;
            this.label26.Text = "Dexterity";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(23, 40);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(62, 13);
            this.label27.TabIndex = 26;
            this.label27.Text = "Constitution";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(24, 112);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(61, 13);
            this.label24.TabIndex = 23;
            this.label24.Text = "Intelligence";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(37, 160);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(48, 13);
            this.label21.TabIndex = 20;
            this.label21.Text = "Empathy";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(55, 136);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(30, 13);
            this.label23.TabIndex = 22;
            this.label23.Text = "Piety";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.EvadeChanceNumericUpDown);
            this.groupBox4.Controls.Add(this.BlockChanceNumericUpDown);
            this.groupBox4.Controls.Add(this.LeftHandSwingChanceNumericUpDown);
            this.groupBox4.Controls.Add(this.ParryChanceNumericUpDown);
            this.groupBox4.Controls.Add(this.AbilitiesrichTextBox);
            this.groupBox4.Controls.Add(this.StylesrichTextBox);
            this.groupBox4.Controls.Add(this.SpellsrichTextBox);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(373, 9);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(183, 287);
            this.groupBox4.TabIndex = 45;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tweaks";
            // 
            // EvadeChanceNumericUpDown
            // 
            this.EvadeChanceNumericUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.EvadeChanceNumericUpDown.Location = new System.Drawing.Point(123, 38);
            this.EvadeChanceNumericUpDown.Name = "EvadeChanceNumericUpDown";
            this.EvadeChanceNumericUpDown.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.EvadeChanceNumericUpDown.Size = new System.Drawing.Size(54, 20);
            this.EvadeChanceNumericUpDown.TabIndex = 34;
            // 
            // BlockChanceNumericUpDown
            // 
            this.BlockChanceNumericUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.BlockChanceNumericUpDown.Location = new System.Drawing.Point(123, 65);
            this.BlockChanceNumericUpDown.Name = "BlockChanceNumericUpDown";
            this.BlockChanceNumericUpDown.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BlockChanceNumericUpDown.Size = new System.Drawing.Size(54, 20);
            this.BlockChanceNumericUpDown.TabIndex = 33;
            // 
            // LeftHandSwingChanceNumericUpDown
            // 
            this.LeftHandSwingChanceNumericUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.LeftHandSwingChanceNumericUpDown.Location = new System.Drawing.Point(123, 89);
            this.LeftHandSwingChanceNumericUpDown.Name = "LeftHandSwingChanceNumericUpDown";
            this.LeftHandSwingChanceNumericUpDown.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LeftHandSwingChanceNumericUpDown.Size = new System.Drawing.Size(54, 20);
            this.LeftHandSwingChanceNumericUpDown.TabIndex = 32;
            // 
            // ParryChanceNumericUpDown
            // 
            this.ParryChanceNumericUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.ParryChanceNumericUpDown.Location = new System.Drawing.Point(123, 14);
            this.ParryChanceNumericUpDown.Name = "ParryChanceNumericUpDown";
            this.ParryChanceNumericUpDown.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ParryChanceNumericUpDown.Size = new System.Drawing.Size(54, 20);
            this.ParryChanceNumericUpDown.TabIndex = 31;
            // 
            // AbilitiesrichTextBox
            // 
            this.AbilitiesrichTextBox.Location = new System.Drawing.Point(8, 241);
            this.AbilitiesrichTextBox.Name = "AbilitiesrichTextBox";
            this.AbilitiesrichTextBox.Size = new System.Drawing.Size(169, 40);
            this.AbilitiesrichTextBox.TabIndex = 30;
            this.AbilitiesrichTextBox.Text = "";
            // 
            // StylesrichTextBox
            // 
            this.StylesrichTextBox.Location = new System.Drawing.Point(8, 187);
            this.StylesrichTextBox.Name = "StylesrichTextBox";
            this.StylesrichTextBox.Size = new System.Drawing.Size(169, 37);
            this.StylesrichTextBox.TabIndex = 29;
            this.StylesrichTextBox.Text = "";
            // 
            // SpellsrichTextBox
            // 
            this.SpellsrichTextBox.Location = new System.Drawing.Point(8, 131);
            this.SpellsrichTextBox.Name = "SpellsrichTextBox";
            this.SpellsrichTextBox.Size = new System.Drawing.Size(172, 37);
            this.SpellsrichTextBox.TabIndex = 28;
            this.SpellsrichTextBox.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Spells";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Styles";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(70, 226);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(42, 13);
            this.label20.TabIndex = 27;
            this.label20.Text = "Abilities";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "ParryChance";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "LeftHandSwingChance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "BlockChance";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "EvadeChance";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GuildNametextBox);
            this.groupBox1.Controls.Add(this.FRNametextBox);
            this.groupBox1.Controls.Add(this.NametextBox);
            this.groupBox1.Controls.Add(this.TemplateIDtextBox);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.FRNamelabel);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Location = new System.Drawing.Point(3, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 109);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            // 
            // GuildNametextBox
            // 
            this.GuildNametextBox.Location = new System.Drawing.Point(72, 79);
            this.GuildNametextBox.Name = "GuildNametextBox";
            this.GuildNametextBox.Size = new System.Drawing.Size(122, 20);
            this.GuildNametextBox.TabIndex = 20;
            // 
            // FRNametextBox
            // 
            this.FRNametextBox.Location = new System.Drawing.Point(72, 56);
            this.FRNametextBox.Name = "FRNametextBox";
            this.FRNametextBox.Size = new System.Drawing.Size(122, 20);
            this.FRNametextBox.TabIndex = 19;
            this.FRNametextBox.Visible = false;
            // 
            // NametextBox
            // 
            this.NametextBox.Location = new System.Drawing.Point(72, 32);
            this.NametextBox.Name = "NametextBox";
            this.NametextBox.Size = new System.Drawing.Size(122, 20);
            this.NametextBox.TabIndex = 18;
            // 
            // TemplateIDtextBox
            // 
            this.TemplateIDtextBox.Location = new System.Drawing.Point(72, 9);
            this.TemplateIDtextBox.Name = "TemplateIDtextBox";
            this.TemplateIDtextBox.ReadOnly = true;
            this.TemplateIDtextBox.Size = new System.Drawing.Size(56, 20);
            this.TemplateIDtextBox.TabIndex = 17;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 16);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(62, 13);
            this.label17.TabIndex = 16;
            this.label17.Text = "TemplateID";
            // 
            // FRNamelabel
            // 
            this.FRNamelabel.AutoSize = true;
            this.FRNamelabel.Location = new System.Drawing.Point(19, 59);
            this.FRNamelabel.Name = "FRNamelabel";
            this.FRNamelabel.Size = new System.Drawing.Size(49, 13);
            this.FRNamelabel.TabIndex = 14;
            this.FRNamelabel.Text = "FRName";
            this.FRNamelabel.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(33, 36);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 13);
            this.label16.TabIndex = 15;
            this.label16.Text = "Name";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 82);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "GuildName";
            // 
            // LoadNPCTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 697);
            this.Controls.Add(this.NPCTemplatedataGridView);
            this.Controls.Add(this.ControlEditor);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ControlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoadNPCTemplate";
            this.Text = "NPCTemplate Editor";
            ((System.ComponentModel.ISupportInitialize)(this.NPCTemplatebindingNavigator)).EndInit();
            this.NPCTemplatebindingNavigator.ResumeLayout(false);
            this.NPCTemplatebindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NPCTemplatebindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NPCTemplatedataGridView)).EndInit();
            this.ControlMenu.ResumeLayout(false);
            this.ControlMenu.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ControlEditor.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TranslationdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TranslationbindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TranslationbindingNavigator)).EndInit();
            this.TranslationbindingNavigator.ResumeLayout(false);
            this.TranslationbindingNavigator.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HightLevelnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LowLevelnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HightSizenumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LowSizenumericUpDown)).EndInit();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RacebindingSource)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AggroLevelUpDown)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EvadeChanceNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlockChanceNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftHandSwingChanceNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParryChanceNumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Util.eFlags flags;
        private System.Windows.Forms.BindingNavigator NPCTemplatebindingNavigator;
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
        private System.Windows.Forms.BindingSource NPCTemplatebindingSource;
        private System.Windows.Forms.DataGridView NPCTemplatedataGridView;
        private System.Windows.Forms.GroupBox ControlMenu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button AddNPCTemplateButton;
        private System.Windows.Forms.Button NPCTemplateListingButton;
        private System.Windows.Forms.Button Savebutton;
        private System.Windows.Forms.Button SaveNewbutton;
        private TabControl ControlEditor;
        private TabPage tabPage1;
        private Label label17;
        private Label label16;
        private Label FRNamelabel;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label1;
        private GroupBox groupBox10;
        private TextBox MessageArticletextBox;
        private TextBox ExamineArticletextBox;
        private TextBox SuffixtextBox;
        private Label label29;
        private Label label28;
        private Label label43;
        private GroupBox groupBox9;
        private ComboBox ClassTypecomboBox;
        private TextBox ItemsListTemplateIDtextBox;
        private TextBox TranslationIDtextBox;
        private TextBox EquipmentTemplateIDtextBox;
        private TextBox PackageIDtextBox;
        private Label label41;
        private Label label35;
        private Label label32;
        private Label label30;
        private GroupBox groupBox8;
        private Label label39;
        private Label label40;
        private GroupBox groupBox7;
        private TextBox AggroRangetextBox;
        private TextBox TetherRangetextBox;
        private TextBox MaxDistancetextBox;
        private Label label38;
        private Label label36;
        private Label label37;
        private Label label19;
        private Label label18;
        private GroupBox groupBox5;
        private TextBox CharismatextBox;
        private TextBox EmpathytextBox;
        private TextBox PietytextBox;
        private TextBox IntelligencetextBox;
        private TextBox QuicknesstextBox;
        private TextBox DexteritytextBox;
        private TextBox ConstitutiontextBox;
        private TextBox StrengthtextBox;
        private Label label25;
        private Label label22;
        private Label label26;
        private Label label27;
        private Label label24;
        private Label label21;
        private Label label23;
        private GroupBox groupBox4;
        private TextBox MaxSpeedtextBox;
        public TextBox ModeltextBox;
        private GroupBox groupBox1;
        private TextBox GuildNametextBox;
        private TextBox FRNametextBox;
        private TextBox NametextBox;
        private TextBox TemplateIDtextBox;
        private GroupBox groupBox11;
        private Label Classlabel;
        private ComboBox ClassTypeSearchcomboBox;
        private Label label45;
        private ComboBox PackageIDSearchcomboBox;
        private Label label42;
        private TextBox SearchByNPCTemplateNametextBox;
        private Label label44;
        private TextBox SearchNPCTemplateIDtextBox;
        private ComboBox BodyTypecomboBox;
        private GroupBox groupBox12;
        private Label label53;
        private Label label52;
        private Label label51;
        private Label label50;
        private Label label49;
        private Label label48;
        private Label label47;
        private Label label46;
        private Label label9;
        private CheckBox SwimmingcheckBox;
        private CheckBox TorchcheckBox;
        private CheckBox StatuecheckBox;
        private CheckBox PeacecheckBox;
        private CheckBox FlyingcheckBox;
        private CheckBox DontShowNamecheckBox;
        private CheckBox CantTargetcheckBox;
        private CheckBox StealthcheckBox;
        private CheckBox GhostcheckBox;
        private GroupBox groupBox13;
        private CheckBox checkBox7;
        private Label label60;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private Label label54;
        private Label label55;
        private Label label56;
        private Label label58;
        private Label label59;
        private ComboBox RacecomboBox;
        private BindingSource RacebindingSource;
        private GroupBox groupBox14;
        private DataGridView TranslationdataGridView;
        private BindingSource TranslationbindingSource;
        private BindingNavigator TranslationbindingNavigator;
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
        private Button button1;
        private ComboBox MeleeDamageTypecomboBox;
        private ComboBox IsCharmablecomboBox;
        private Label IsCharmablelabel;
        private Label label8;
        private RichTextBox AbilitiesrichTextBox;
        private RichTextBox StylesrichTextBox;
        private RichTextBox SpellsrichTextBox;
        private Label label3;
        private Label label2;
        private Label label20;
        private NumericUpDown HightSizenumericUpDown;
        private NumericUpDown LowSizenumericUpDown;
        private NumericUpDown HightLevelnumericUpDown;
        private NumericUpDown LowLevelnumericUpDown;
        private Label label62;
        private Label label61;
        private Label label31;
        private Label label15;
        private Button button2;
        private NumericUpDown AggroLevelUpDown;
        private NumericUpDown EvadeChanceNumericUpDown;
        private NumericUpDown BlockChanceNumericUpDown;
        private NumericUpDown LeftHandSwingChanceNumericUpDown;
        private NumericUpDown ParryChanceNumericUpDown;
        private ComboBox ReplaceMobValuescomboBox;
        private TextBox VisibleWeaponSlotstextBox;
        private Label label34;
        private Label label33;
        private ComboBox GendercomboBox;
        private Label label57;
    }
}