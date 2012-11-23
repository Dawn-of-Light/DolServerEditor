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
    partial class LoadStyle
    {
        private System.Windows.Forms.BindingSource bindingSource1;
        DataTable StyleDataTable = new DataTable();
        DataTable StyleXSpell = new DataTable();
        DataTable languagestyle = new DataTable();
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

        private void dataGrid1_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            //MainWindow form1 = new  MainWindow();
            //form1.ShowDialog();
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadStyle));
            this.ClassIDSearchcomboBox = new System.Windows.Forms.ComboBox();
            this.Classlabel = new System.Windows.Forms.Label();
            this.StyleSearchKeyNamecomboBox = new System.Windows.Forms.ComboBox();
            this.Speclabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchStyleIDtextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SearchByStyleNametextBox = new System.Windows.Forms.TextBox();
            this.ControlMenu = new System.Windows.Forms.GroupBox();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
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
            this.SaveNewbutton = new System.Windows.Forms.Button();
            this.Savebutton = new System.Windows.Forms.Button();
            this.textBox36 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label47 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.EditStyleControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.DescriptionLanguageStylerichTextBox = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.NameLanguageStyletextBox = new System.Windows.Forms.TextBox();
            this.LanguageChoicecomboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TagLanguagueStyletextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.bindingNavigator3 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorDeleteItem2 = new System.Windows.Forms.ToolStripButton();
            this.LanguageStyledataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ChancetextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SpellIDStyleXSpelltextBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.bindingNavigator2 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorDeleteItem1 = new System.Windows.Forms.ToolStripButton();
            this.StyleXSpelldataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.ArmorHitLoclabel = new System.Windows.Forms.Label();
            this.ArmorHitLoctextBox = new System.Windows.Forms.TextBox();
            this.BonustoDefenselabel = new System.Windows.Forms.Label();
            this.TwoHandAnimationlabel = new System.Windows.Forms.Label();
            this.TwoHandAnimtextBox = new System.Windows.Forms.TextBox();
            this.BonustoDefensetextBox = new System.Windows.Forms.TextBox();
            this.SpecLevelRequirementlabel = new System.Windows.Forms.Label();
            this.SpecLevelRequirementtextBox = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.OpeningRequirementValuecomboBox = new System.Windows.Forms.ComboBox();
            this.RandomProccomboBox = new System.Windows.Forms.ComboBox();
            this.WeaponTypeRequirementcomboBox = new System.Windows.Forms.ComboBox();
            this.WeaponTypeRequirementlabel = new System.Windows.Forms.Label();
            this.AttackResultRequirementcomboBox = new System.Windows.Forms.ComboBox();
            this.AttackResultRequirementlabel = new System.Windows.Forms.Label();
            this.RandomProclabel = new System.Windows.Forms.Label();
            this.OpeningRequirementValuelabel = new System.Windows.Forms.Label();
            this.OpeningRequirementTypecomboBox = new System.Windows.Forms.ComboBox();
            this.StealthRequirementcomboBox = new System.Windows.Forms.ComboBox();
            this.OpeningRequirementTypelabel = new System.Windows.Forms.Label();
            this.StealthRequirementlabel = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.SpecKeyNamecomboBox = new System.Windows.Forms.ComboBox();
            this.stylenamelabel = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.TranslationIDtextBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.Growthratelabel = new System.Windows.Forms.Label();
            this.BonustoHitlabel = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.StyleNametextBox = new System.Windows.Forms.TextBox();
            this.GrowthratetextBox = new System.Windows.Forms.TextBox();
            this.EnduranceCosttextBox = new System.Windows.Forms.TextBox();
            this.BonustoHittextBox = new System.Windows.Forms.TextBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.ClassIDcomboBox = new System.Windows.Forms.ComboBox();
            this.label49 = new System.Windows.Forms.Label();
            this.classidlabel = new System.Windows.Forms.Label();
            this.StyleIDtextBox = new System.Windows.Forms.TextBox();
            this.Iconlabel = new System.Windows.Forms.Label();
            this.IcontextBox = new System.Windows.Forms.TextBox();
            this.dataGridStyle = new System.Windows.Forms.DataGridView();
            this.dataAdapterbindingsource1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.commandBuilder = new MySql.Data.MySqlClient.MySqlCommandBuilder();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.StyleListingButton = new System.Windows.Forms.Button();
            this.StyleAddButton = new System.Windows.Forms.Button();
            this.ControlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.EditStyleControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator3)).BeginInit();
            this.bindingNavigator3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LanguageStyledataGridView)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).BeginInit();
            this.bindingNavigator2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StyleXSpelldataGridView)).BeginInit();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStyle)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClassIDSearchcomboBox
            // 
            this.ClassIDSearchcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClassIDSearchcomboBox.FormattingEnabled = true;
            this.ClassIDSearchcomboBox.Items.AddRange(new object[] {
            " All",
            "Acolyte",
            "AlbionRogue",
            "Animist",
            "Armsman",
            "Bainshee",
            "Bard",
            "Berserker",
            "Blademaster",
            "Bonedancer",
            "Cabalist",
            "Champion",
            "Cleric",
            "Disciple",
            "Druid",
            "Eldritch",
            "Elementalist",
            "Enchanter",
            "Fighter",
            "Forester",
            "Friar",
            "Guardian",
            "Healer",
            "Heretic",
            "Hero",
            "Hunter",
            "Infiltrator",
            "Mage",
            "Magician",
            "Mauler_Alb",
            "Mauler_Hib",
            "Mauler_Mid",
            "Mentalist",
            "Mercenary",
            "MidgardRogue",
            "Minstrel",
            "Mystic",
            "Naturalist",
            "Necromancer",
            "Nightshade",
            "Paladin",
            "Ranger",
            "Reaver",
            "Runemaster",
            "Savage",
            "Scout",
            "Seer",
            "Shadowblade",
            "Shaman",
            "Skald",
            "Sorcerer",
            "Spiritmaster",
            "Stalker",
            "Thane",
            "Theurgist",
            "Valewalker",
            "Valkyrie",
            "Vampiir",
            "Viking",
            "Warden",
            "Warlock",
            "Warrior",
            "Wizard"});
            this.ClassIDSearchcomboBox.Location = new System.Drawing.Point(43, 11);
            this.ClassIDSearchcomboBox.MaxDropDownItems = 15;
            this.ClassIDSearchcomboBox.Name = "ClassIDSearchcomboBox";
            this.ClassIDSearchcomboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ClassIDSearchcomboBox.Size = new System.Drawing.Size(121, 21);
            this.ClassIDSearchcomboBox.Sorted = true;
            this.ClassIDSearchcomboBox.TabIndex = 3;
            this.ClassIDSearchcomboBox.SelectedIndexChanged += new System.EventHandler(this.SearchFilters_SelectedChanged);
            // 
            // Classlabel
            // 
            this.Classlabel.AutoSize = true;
            this.Classlabel.Location = new System.Drawing.Point(5, 14);
            this.Classlabel.Name = "Classlabel";
            this.Classlabel.Size = new System.Drawing.Size(32, 13);
            this.Classlabel.TabIndex = 7;
            this.Classlabel.Text = "Class";
            // 
            // StyleSearchKeyNamecomboBox
            // 
            this.StyleSearchKeyNamecomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StyleSearchKeyNamecomboBox.FormattingEnabled = true;
            this.StyleSearchKeyNamecomboBox.Items.AddRange(new object[] {
            " All",
            "Axe",
            "Battlemaster",
            "Blades",
            "Blunt",
            "Celtic Dual",
            "Celtic Spear",
            "Champion Abilities",
            "Critical Strike",
            "Crush",
            "Dual Wield",
            "Fist Wraps",
            "Flexible",
            "Hammer",
            "Hand to Hand",
            "Large Weapons",
            "Left Axe",
            "Mauler Staff",
            "Piercing",
            "Polearm",
            "Scythe",
            "Shields",
            "Slash",
            "Spear",
            "Staff",
            "Sword",
            "Thrust",
            "Two Handed"});
            this.StyleSearchKeyNamecomboBox.Location = new System.Drawing.Point(213, 11);
            this.StyleSearchKeyNamecomboBox.MaxDropDownItems = 15;
            this.StyleSearchKeyNamecomboBox.Name = "StyleSearchKeyNamecomboBox";
            this.StyleSearchKeyNamecomboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StyleSearchKeyNamecomboBox.Size = new System.Drawing.Size(132, 21);
            this.StyleSearchKeyNamecomboBox.TabIndex = 8;
            this.StyleSearchKeyNamecomboBox.SelectedIndexChanged += new System.EventHandler(this.SearchFilters_SelectedChanged);
            // 
            // Speclabel
            // 
            this.Speclabel.AutoSize = true;
            this.Speclabel.Location = new System.Drawing.Point(175, 14);
            this.Speclabel.Name = "Speclabel";
            this.Speclabel.Size = new System.Drawing.Size(32, 13);
            this.Speclabel.TabIndex = 9;
            this.Speclabel.Text = "Spec";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(351, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Style ID";
            // 
            // SearchStyleIDtextBox
            // 
            this.SearchStyleIDtextBox.Location = new System.Drawing.Point(401, 12);
            this.SearchStyleIDtextBox.Name = "SearchStyleIDtextBox";
            this.SearchStyleIDtextBox.Size = new System.Drawing.Size(70, 20);
            this.SearchStyleIDtextBox.TabIndex = 12;
            this.SearchStyleIDtextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.SearchStyleIDtextBox.TextChanged += new System.EventHandler(this.SearchFilters_SelectedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(477, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Style Name";
            // 
            // SearchByStyleNametextBox
            // 
            this.SearchByStyleNametextBox.Location = new System.Drawing.Point(538, 13);
            this.SearchByStyleNametextBox.Name = "SearchByStyleNametextBox";
            this.SearchByStyleNametextBox.Size = new System.Drawing.Size(149, 20);
            this.SearchByStyleNametextBox.TabIndex = 14;
            this.SearchByStyleNametextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.SearchByStyleNametextBox.TextChanged += new System.EventHandler(this.SearchFilters_SelectedChanged);
            // 
            // ControlMenu
            // 
            this.ControlMenu.Controls.Add(this.label2);
            this.ControlMenu.Controls.Add(this.bindingNavigator1);
            this.ControlMenu.Controls.Add(this.SearchByStyleNametextBox);
            this.ControlMenu.Controls.Add(this.Classlabel);
            this.ControlMenu.Controls.Add(this.label5);
            this.ControlMenu.Controls.Add(this.ClassIDSearchcomboBox);
            this.ControlMenu.Controls.Add(this.SearchStyleIDtextBox);
            this.ControlMenu.Controls.Add(this.Speclabel);
            this.ControlMenu.Controls.Add(this.StyleSearchKeyNamecomboBox);
            this.ControlMenu.Location = new System.Drawing.Point(7, 0);
            this.ControlMenu.Name = "ControlMenu";
            this.ControlMenu.Size = new System.Drawing.Size(705, 67);
            this.ControlMenu.TabIndex = 17;
            this.ControlMenu.TabStop = false;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.bindingSource1;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigator1.Location = new System.Drawing.Point(4, 35);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(232, 25);
            this.bindingNavigator1.TabIndex = 20;
            this.bindingNavigator1.Text = "bindingNavigator1";
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
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.StyleNavigatorDeleteItem_Click);
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
            // SaveNewbutton
            // 
            this.SaveNewbutton.Location = new System.Drawing.Point(32, 37);
            this.SaveNewbutton.Name = "SaveNewbutton";
            this.SaveNewbutton.Size = new System.Drawing.Size(111, 23);
            this.SaveNewbutton.TabIndex = 21;
            this.SaveNewbutton.Text = "Save New Style";
            this.SaveNewbutton.UseVisualStyleBackColor = true;
            this.SaveNewbutton.Click += new System.EventHandler(this.SaveNewStyle_Click);
            // 
            // Savebutton
            // 
            this.Savebutton.Location = new System.Drawing.Point(32, 38);
            this.Savebutton.Name = "Savebutton";
            this.Savebutton.Size = new System.Drawing.Size(111, 23);
            this.Savebutton.TabIndex = 20;
            this.Savebutton.Text = "Save Loaded Style";
            this.Savebutton.UseVisualStyleBackColor = true;
            this.Savebutton.Click += new System.EventHandler(this.SaveLoadedStyle_Click);
            // 
            // textBox36
            // 
            this.textBox36.Location = new System.Drawing.Point(83, 62);
            this.textBox36.Name = "textBox36";
            this.textBox36.Size = new System.Drawing.Size(43, 20);
            this.textBox36.TabIndex = 2;
            this.textBox36.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(83, 36);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(43, 20);
            this.textBox7.TabIndex = 1;
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(83, 10);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(43, 20);
            this.textBox3.TabIndex = 0;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(8, 39);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(61, 13);
            this.label47.TabIndex = 18;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(8, 13);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(41, 13);
            this.label46.TabIndex = 19;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(8, 65);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(28, 13);
            this.label45.TabIndex = 20;
            // 
            // EditStyleControl
            // 
            this.EditStyleControl.Controls.Add(this.tabPage1);
            this.EditStyleControl.Location = new System.Drawing.Point(7, 73);
            this.EditStyleControl.Name = "EditStyleControl";
            this.EditStyleControl.SelectedIndex = 0;
            this.EditStyleControl.Size = new System.Drawing.Size(984, 365);
            this.EditStyleControl.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox12);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox8);
            this.tabPage1.Controls.Add(this.groupBox7);
            this.tabPage1.Controls.Add(this.groupBox9);
            this.tabPage1.Controls.Add(this.groupBox10);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(976, 339);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Style Editor";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.groupBox6);
            this.groupBox12.Controls.Add(this.bindingNavigator3);
            this.groupBox12.Controls.Add(this.LanguageStyledataGridView);
            this.groupBox12.Enabled = false;
            this.groupBox12.Location = new System.Drawing.Point(6, 105);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(449, 228);
            this.groupBox12.TabIndex = 30;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Translation";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.DescriptionLanguageStylerichTextBox);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.NameLanguageStyletextBox);
            this.groupBox6.Controls.Add(this.LanguageChoicecomboBox);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.TagLanguagueStyletextBox);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.button1);
            this.groupBox6.Location = new System.Drawing.Point(3, 127);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(444, 95);
            this.groupBox6.TabIndex = 28;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "LanguageStyle Add";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(184, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "Description";
            // 
            // DescriptionLanguageStylerichTextBox
            // 
            this.DescriptionLanguageStylerichTextBox.Location = new System.Drawing.Point(111, 22);
            this.DescriptionLanguageStylerichTextBox.Name = "DescriptionLanguageStylerichTextBox";
            this.DescriptionLanguageStylerichTextBox.Size = new System.Drawing.Size(212, 68);
            this.DescriptionLanguageStylerichTextBox.TabIndex = 34;
            this.DescriptionLanguageStylerichTextBox.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(369, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Name";
            // 
            // NameLanguageStyletextBox
            // 
            this.NameLanguageStyletextBox.Location = new System.Drawing.Point(328, 29);
            this.NameLanguageStyletextBox.Name = "NameLanguageStyletextBox";
            this.NameLanguageStyletextBox.Size = new System.Drawing.Size(110, 20);
            this.NameLanguageStyletextBox.TabIndex = 32;
            this.NameLanguageStyletextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LanguageChoicecomboBox
            // 
            this.LanguageChoicecomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LanguageChoicecomboBox.FormattingEnabled = true;
            this.LanguageChoicecomboBox.Items.AddRange(new object[] {
            "FR",
            "DE"});
            this.LanguageChoicecomboBox.Location = new System.Drawing.Point(61, 22);
            this.LanguageChoicecomboBox.Name = "LanguageChoicecomboBox";
            this.LanguageChoicecomboBox.Size = new System.Drawing.Size(44, 21);
            this.LanguageChoicecomboBox.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Tag";
            // 
            // TagLanguagueStyletextBox
            // 
            this.TagLanguagueStyletextBox.Location = new System.Drawing.Point(61, 63);
            this.TagLanguagueStyletextBox.Name = "TagLanguagueStyletextBox";
            this.TagLanguagueStyletextBox.Size = new System.Drawing.Size(44, 20);
            this.TagLanguagueStyletextBox.TabIndex = 29;
            this.TagLanguagueStyletextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Language";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(328, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Add LanguageStyle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AddLanguageStyle_Click);
            // 
            // bindingNavigator3
            // 
            this.bindingNavigator3.AddNewItem = null;
            this.bindingNavigator3.BindingSource = this.bindingSource3;
            this.bindingNavigator3.CountItem = null;
            this.bindingNavigator3.DeleteItem = this.bindingNavigatorDeleteItem2;
            this.bindingNavigator3.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorDeleteItem2});
            this.bindingNavigator3.Location = new System.Drawing.Point(3, 13);
            this.bindingNavigator3.MoveFirstItem = null;
            this.bindingNavigator3.MoveLastItem = null;
            this.bindingNavigator3.MoveNextItem = null;
            this.bindingNavigator3.MovePreviousItem = null;
            this.bindingNavigator3.Name = "bindingNavigator3";
            this.bindingNavigator3.PositionItem = null;
            this.bindingNavigator3.Size = new System.Drawing.Size(35, 25);
            this.bindingNavigator3.TabIndex = 21;
            this.bindingNavigator3.Text = "bindingNavigator3";
            // 
            // bindingNavigatorDeleteItem2
            // 
            this.bindingNavigatorDeleteItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem2.Image")));
            this.bindingNavigatorDeleteItem2.Name = "bindingNavigatorDeleteItem2";
            this.bindingNavigatorDeleteItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem2.Text = "Delete";
            this.bindingNavigatorDeleteItem2.Click += new System.EventHandler(this.LanguageStyleNavigatorDeleteItem_Click);
            // 
            // LanguageStyledataGridView
            // 
            this.LanguageStyledataGridView.AllowUserToAddRows = false;
            this.LanguageStyledataGridView.AllowUserToOrderColumns = true;
            this.LanguageStyledataGridView.AutoGenerateColumns = false;
            this.LanguageStyledataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.LanguageStyledataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LanguageStyledataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LanguageStyledataGridView.DataSource = this.bindingSource3;
            this.LanguageStyledataGridView.Location = new System.Drawing.Point(3, 39);
            this.LanguageStyledataGridView.MultiSelect = false;
            this.LanguageStyledataGridView.Name = "LanguageStyledataGridView";
            this.LanguageStyledataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.LanguageStyledataGridView.Size = new System.Drawing.Size(441, 88);
            this.LanguageStyledataGridView.TabIndex = 21;
            this.LanguageStyledataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.LanguageStyledataGridView_CellValueChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.bindingNavigator2);
            this.groupBox4.Controls.Add(this.StyleXSpelldataGridView);
            this.groupBox4.Location = new System.Drawing.Point(456, 105);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(373, 229);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "StyleXSpell of this Style";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.ChancetextBox);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.SpellIDStyleXSpelltextBox);
            this.groupBox5.Controls.Add(this.button3);
            this.groupBox5.Location = new System.Drawing.Point(9, 172);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(353, 51);
            this.groupBox5.TabIndex = 27;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "StyleXSpell Add";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(121, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Chance";
            // 
            // ChancetextBox
            // 
            this.ChancetextBox.Location = new System.Drawing.Point(174, 22);
            this.ChancetextBox.Name = "ChancetextBox";
            this.ChancetextBox.Size = new System.Drawing.Size(44, 20);
            this.ChancetextBox.TabIndex = 29;
            this.ChancetextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "SpellID";
            // 
            // SpellIDStyleXSpelltextBox
            // 
            this.SpellIDStyleXSpelltextBox.Location = new System.Drawing.Point(59, 24);
            this.SpellIDStyleXSpelltextBox.Name = "SpellIDStyleXSpelltextBox";
            this.SpellIDStyleXSpelltextBox.Size = new System.Drawing.Size(44, 20);
            this.SpellIDStyleXSpelltextBox.TabIndex = 25;
            this.SpellIDStyleXSpelltextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(240, 22);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 23);
            this.button3.TabIndex = 24;
            this.button3.Text = "Add StyleXSpell";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.AddStyleXSpell_Click);
            // 
            // bindingNavigator2
            // 
            this.bindingNavigator2.AddNewItem = null;
            this.bindingNavigator2.BindingSource = this.bindingSource2;
            this.bindingNavigator2.CountItem = null;
            this.bindingNavigator2.DeleteItem = this.bindingNavigatorDeleteItem1;
            this.bindingNavigator2.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorDeleteItem1});
            this.bindingNavigator2.Location = new System.Drawing.Point(9, 13);
            this.bindingNavigator2.MoveFirstItem = null;
            this.bindingNavigator2.MoveLastItem = null;
            this.bindingNavigator2.MoveNextItem = null;
            this.bindingNavigator2.MovePreviousItem = null;
            this.bindingNavigator2.Name = "bindingNavigator2";
            this.bindingNavigator2.PositionItem = null;
            this.bindingNavigator2.Size = new System.Drawing.Size(35, 25);
            this.bindingNavigator2.TabIndex = 26;
            this.bindingNavigator2.Text = "bindingNavigator2";
            // 
            // bindingNavigatorDeleteItem1
            // 
            this.bindingNavigatorDeleteItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem1.Image")));
            this.bindingNavigatorDeleteItem1.Name = "bindingNavigatorDeleteItem1";
            this.bindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem1.Text = "Delete";
            this.bindingNavigatorDeleteItem1.Click += new System.EventHandler(this.StyleXSpellNavigatorDeleteItem1_Click);
            // 
            // StyleXSpelldataGridView
            // 
            this.StyleXSpelldataGridView.AllowUserToAddRows = false;
            this.StyleXSpelldataGridView.AllowUserToOrderColumns = true;
            this.StyleXSpelldataGridView.AutoGenerateColumns = false;
            this.StyleXSpelldataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StyleXSpelldataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.StyleXSpelldataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StyleXSpelldataGridView.DataSource = this.bindingSource2;
            this.StyleXSpelldataGridView.Location = new System.Drawing.Point(9, 39);
            this.StyleXSpelldataGridView.MultiSelect = false;
            this.StyleXSpelldataGridView.Name = "StyleXSpelldataGridView";
            this.StyleXSpelldataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StyleXSpelldataGridView.Size = new System.Drawing.Size(359, 127);
            this.StyleXSpelldataGridView.TabIndex = 25;
            this.StyleXSpelldataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.StyleXSpelldataGridView_CellValueChanged);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.ArmorHitLoclabel);
            this.groupBox8.Controls.Add(this.ArmorHitLoctextBox);
            this.groupBox8.Controls.Add(this.BonustoDefenselabel);
            this.groupBox8.Controls.Add(this.TwoHandAnimationlabel);
            this.groupBox8.Controls.Add(this.TwoHandAnimtextBox);
            this.groupBox8.Controls.Add(this.BonustoDefensetextBox);
            this.groupBox8.Controls.Add(this.SpecLevelRequirementlabel);
            this.groupBox8.Controls.Add(this.SpecLevelRequirementtextBox);
            this.groupBox8.Location = new System.Drawing.Point(830, 104);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(140, 128);
            this.groupBox8.TabIndex = 6;
            this.groupBox8.TabStop = false;
            // 
            // ArmorHitLoclabel
            // 
            this.ArmorHitLoclabel.AutoSize = true;
            this.ArmorHitLoclabel.Location = new System.Drawing.Point(5, 40);
            this.ArmorHitLoclabel.Name = "ArmorHitLoclabel";
            this.ArmorHitLoclabel.Size = new System.Drawing.Size(71, 13);
            this.ArmorHitLoclabel.TabIndex = 23;
            this.ArmorHitLoclabel.Text = "Armor Hit Loc";
            // 
            // ArmorHitLoctextBox
            // 
            this.ArmorHitLoctextBox.Location = new System.Drawing.Point(94, 37);
            this.ArmorHitLoctextBox.Name = "ArmorHitLoctextBox";
            this.ArmorHitLoctextBox.Size = new System.Drawing.Size(32, 20);
            this.ArmorHitLoctextBox.TabIndex = 22;
            this.ArmorHitLoctextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BonustoDefenselabel
            // 
            this.BonustoDefenselabel.AutoSize = true;
            this.BonustoDefenselabel.Location = new System.Drawing.Point(5, 88);
            this.BonustoDefenselabel.Name = "BonustoDefenselabel";
            this.BonustoDefenselabel.Size = new System.Drawing.Size(92, 13);
            this.BonustoDefenselabel.TabIndex = 23;
            this.BonustoDefenselabel.Text = "Bonus to Defense";
            // 
            // TwoHandAnimationlabel
            // 
            this.TwoHandAnimationlabel.AutoSize = true;
            this.TwoHandAnimationlabel.Location = new System.Drawing.Point(5, 17);
            this.TwoHandAnimationlabel.Name = "TwoHandAnimationlabel";
            this.TwoHandAnimationlabel.Size = new System.Drawing.Size(83, 13);
            this.TwoHandAnimationlabel.TabIndex = 20;
            this.TwoHandAnimationlabel.Text = "Two Hand Anim";
            // 
            // TwoHandAnimtextBox
            // 
            this.TwoHandAnimtextBox.Location = new System.Drawing.Point(94, 14);
            this.TwoHandAnimtextBox.Name = "TwoHandAnimtextBox";
            this.TwoHandAnimtextBox.Size = new System.Drawing.Size(32, 20);
            this.TwoHandAnimtextBox.TabIndex = 9;
            this.TwoHandAnimtextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BonustoDefensetextBox
            // 
            this.BonustoDefensetextBox.Location = new System.Drawing.Point(94, 85);
            this.BonustoDefensetextBox.Name = "BonustoDefensetextBox";
            this.BonustoDefensetextBox.Size = new System.Drawing.Size(32, 20);
            this.BonustoDefensetextBox.TabIndex = 12;
            this.BonustoDefensetextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SpecLevelRequirementlabel
            // 
            this.SpecLevelRequirementlabel.AutoSize = true;
            this.SpecLevelRequirementlabel.Location = new System.Drawing.Point(5, 63);
            this.SpecLevelRequirementlabel.Name = "SpecLevelRequirementlabel";
            this.SpecLevelRequirementlabel.Size = new System.Drawing.Size(81, 13);
            this.SpecLevelRequirementlabel.TabIndex = 38;
            this.SpecLevelRequirementlabel.Text = "SpecLevel Req";
            // 
            // SpecLevelRequirementtextBox
            // 
            this.SpecLevelRequirementtextBox.Location = new System.Drawing.Point(94, 63);
            this.SpecLevelRequirementtextBox.Name = "SpecLevelRequirementtextBox";
            this.SpecLevelRequirementtextBox.Size = new System.Drawing.Size(32, 20);
            this.SpecLevelRequirementtextBox.TabIndex = 34;
            this.SpecLevelRequirementtextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.OpeningRequirementValuecomboBox);
            this.groupBox7.Controls.Add(this.RandomProccomboBox);
            this.groupBox7.Controls.Add(this.WeaponTypeRequirementcomboBox);
            this.groupBox7.Controls.Add(this.WeaponTypeRequirementlabel);
            this.groupBox7.Controls.Add(this.AttackResultRequirementcomboBox);
            this.groupBox7.Controls.Add(this.AttackResultRequirementlabel);
            this.groupBox7.Controls.Add(this.RandomProclabel);
            this.groupBox7.Controls.Add(this.OpeningRequirementValuelabel);
            this.groupBox7.Controls.Add(this.OpeningRequirementTypecomboBox);
            this.groupBox7.Controls.Add(this.StealthRequirementcomboBox);
            this.groupBox7.Controls.Add(this.OpeningRequirementTypelabel);
            this.groupBox7.Controls.Add(this.StealthRequirementlabel);
            this.groupBox7.Location = new System.Drawing.Point(525, 0);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(445, 103);
            this.groupBox7.TabIndex = 15;
            this.groupBox7.TabStop = false;
            // 
            // OpeningRequirementValuecomboBox
            // 
            this.OpeningRequirementValuecomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OpeningRequirementValuecomboBox.FormattingEnabled = true;
            this.OpeningRequirementValuecomboBox.Location = new System.Drawing.Point(114, 63);
            this.OpeningRequirementValuecomboBox.Name = "OpeningRequirementValuecomboBox";
            this.OpeningRequirementValuecomboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.OpeningRequirementValuecomboBox.Size = new System.Drawing.Size(104, 21);
            this.OpeningRequirementValuecomboBox.TabIndex = 55;
            // 
            // RandomProccomboBox
            // 
            this.RandomProccomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RandomProccomboBox.FormattingEnabled = true;
            this.RandomProccomboBox.Items.AddRange(new object[] {
            "False",
            "True"});
            this.RandomProccomboBox.Location = new System.Drawing.Point(114, 10);
            this.RandomProccomboBox.Name = "RandomProccomboBox";
            this.RandomProccomboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RandomProccomboBox.Size = new System.Drawing.Size(62, 21);
            this.RandomProccomboBox.TabIndex = 53;
            // 
            // WeaponTypeRequirementcomboBox
            // 
            this.WeaponTypeRequirementcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WeaponTypeRequirementcomboBox.FormattingEnabled = true;
            this.WeaponTypeRequirementcomboBox.Items.AddRange(new object[] {
            "Generic",
            "Crushing",
            "Slashing",
            "Thrusting",
            "Twohanded",
            "Polearm",
            "Staff",
            "Sword",
            "Hammer",
            "Axe",
            "Spear",
            "Left axe",
            "Blades",
            "Blunt",
            "Piercing",
            "Large",
            "Celtic spear",
            "Flexible",
            "Hand to hand",
            "Scythe",
            "Mauler staff"});
            this.WeaponTypeRequirementcomboBox.Location = new System.Drawing.Point(340, 65);
            this.WeaponTypeRequirementcomboBox.Name = "WeaponTypeRequirementcomboBox";
            this.WeaponTypeRequirementcomboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.WeaponTypeRequirementcomboBox.Size = new System.Drawing.Size(99, 21);
            this.WeaponTypeRequirementcomboBox.TabIndex = 52;
            // 
            // WeaponTypeRequirementlabel
            // 
            this.WeaponTypeRequirementlabel.AutoSize = true;
            this.WeaponTypeRequirementlabel.Location = new System.Drawing.Point(224, 68);
            this.WeaponTypeRequirementlabel.Name = "WeaponTypeRequirementlabel";
            this.WeaponTypeRequirementlabel.Size = new System.Drawing.Size(112, 13);
            this.WeaponTypeRequirementlabel.TabIndex = 51;
            this.WeaponTypeRequirementlabel.Text = "Weapon Type Requir.";
            // 
            // AttackResultRequirementcomboBox
            // 
            this.AttackResultRequirementcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AttackResultRequirementcomboBox.FormattingEnabled = true;
            this.AttackResultRequirementcomboBox.Items.AddRange(new object[] {
            "Any",
            "Miss",
            "Hit",
            "Parry",
            "Block",
            "Evade",
            "Fumble",
            "Style"});
            this.AttackResultRequirementcomboBox.Location = new System.Drawing.Point(340, 38);
            this.AttackResultRequirementcomboBox.Name = "AttackResultRequirementcomboBox";
            this.AttackResultRequirementcomboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AttackResultRequirementcomboBox.Size = new System.Drawing.Size(99, 21);
            this.AttackResultRequirementcomboBox.TabIndex = 50;
            // 
            // AttackResultRequirementlabel
            // 
            this.AttackResultRequirementlabel.AutoSize = true;
            this.AttackResultRequirementlabel.Location = new System.Drawing.Point(228, 41);
            this.AttackResultRequirementlabel.Name = "AttackResultRequirementlabel";
            this.AttackResultRequirementlabel.Size = new System.Drawing.Size(108, 13);
            this.AttackResultRequirementlabel.TabIndex = 49;
            this.AttackResultRequirementlabel.Text = "Attack Result Requir.";
            // 
            // RandomProclabel
            // 
            this.RandomProclabel.AutoSize = true;
            this.RandomProclabel.Location = new System.Drawing.Point(4, 14);
            this.RandomProclabel.Name = "RandomProclabel";
            this.RandomProclabel.Size = new System.Drawing.Size(72, 13);
            this.RandomProclabel.TabIndex = 21;
            this.RandomProclabel.Text = "Random Proc";
            // 
            // OpeningRequirementValuelabel
            // 
            this.OpeningRequirementValuelabel.AutoSize = true;
            this.OpeningRequirementValuelabel.Location = new System.Drawing.Point(1, 67);
            this.OpeningRequirementValuelabel.Name = "OpeningRequirementValuelabel";
            this.OpeningRequirementValuelabel.Size = new System.Drawing.Size(114, 13);
            this.OpeningRequirementValuelabel.TabIndex = 47;
            this.OpeningRequirementValuelabel.Text = "Opening Requir. Value";
            // 
            // OpeningRequirementTypecomboBox
            // 
            this.OpeningRequirementTypecomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OpeningRequirementTypecomboBox.FormattingEnabled = true;
            this.OpeningRequirementTypecomboBox.Items.AddRange(new object[] {
            "Back",
            "Side",
            "Front"});
            this.OpeningRequirementTypecomboBox.Location = new System.Drawing.Point(340, 11);
            this.OpeningRequirementTypecomboBox.Name = "OpeningRequirementTypecomboBox";
            this.OpeningRequirementTypecomboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.OpeningRequirementTypecomboBox.Size = new System.Drawing.Size(99, 21);
            this.OpeningRequirementTypecomboBox.TabIndex = 46;
            // 
            // StealthRequirementcomboBox
            // 
            this.StealthRequirementcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StealthRequirementcomboBox.FormattingEnabled = true;
            this.StealthRequirementcomboBox.Items.AddRange(new object[] {
            "False",
            "True"});
            this.StealthRequirementcomboBox.Location = new System.Drawing.Point(114, 37);
            this.StealthRequirementcomboBox.Name = "StealthRequirementcomboBox";
            this.StealthRequirementcomboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StealthRequirementcomboBox.Size = new System.Drawing.Size(62, 21);
            this.StealthRequirementcomboBox.TabIndex = 45;
            // 
            // OpeningRequirementTypelabel
            // 
            this.OpeningRequirementTypelabel.AutoSize = true;
            this.OpeningRequirementTypelabel.Location = new System.Drawing.Point(224, 14);
            this.OpeningRequirementTypelabel.Name = "OpeningRequirementTypelabel";
            this.OpeningRequirementTypelabel.Size = new System.Drawing.Size(111, 13);
            this.OpeningRequirementTypelabel.TabIndex = 26;
            this.OpeningRequirementTypelabel.Text = "Opening Requir. Type";
            // 
            // StealthRequirementlabel
            // 
            this.StealthRequirementlabel.AutoSize = true;
            this.StealthRequirementlabel.Location = new System.Drawing.Point(4, 40);
            this.StealthRequirementlabel.Name = "StealthRequirementlabel";
            this.StealthRequirementlabel.Size = new System.Drawing.Size(77, 13);
            this.StealthRequirementlabel.TabIndex = 21;
            this.StealthRequirementlabel.Text = "Stealth Requir.";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.SpecKeyNamecomboBox);
            this.groupBox9.Controls.Add(this.stylenamelabel);
            this.groupBox9.Controls.Add(this.label18);
            this.groupBox9.Controls.Add(this.TranslationIDtextBox);
            this.groupBox9.Controls.Add(this.label15);
            this.groupBox9.Controls.Add(this.Growthratelabel);
            this.groupBox9.Controls.Add(this.BonustoHitlabel);
            this.groupBox9.Controls.Add(this.label44);
            this.groupBox9.Controls.Add(this.StyleNametextBox);
            this.groupBox9.Controls.Add(this.GrowthratetextBox);
            this.groupBox9.Controls.Add(this.EnduranceCosttextBox);
            this.groupBox9.Controls.Add(this.BonustoHittextBox);
            this.groupBox9.Location = new System.Drawing.Point(159, 0);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(360, 99);
            this.groupBox9.TabIndex = 11;
            this.groupBox9.TabStop = false;
            // 
            // SpecKeyNamecomboBox
            // 
            this.SpecKeyNamecomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SpecKeyNamecomboBox.FormattingEnabled = true;
            this.SpecKeyNamecomboBox.Items.AddRange(new object[] {
            "Axe",
            "Battlemaster",
            "Blades",
            "Blunt",
            "Celtic Dual",
            "Celtic Spear",
            "Champion Abilities",
            "Critical Strike",
            "Crush",
            "Dual Wield",
            "Fist Wraps",
            "Flexible",
            "Hammer",
            "Hand to Hand",
            "Large Weapons",
            "Left Axe",
            "Mauler Staff",
            "Piercing",
            "Polearm",
            "Scythe",
            "Shields",
            "Slash",
            "Spear",
            "Staff",
            "Sword",
            "Thrust",
            "Two Handed"});
            this.SpecKeyNamecomboBox.Location = new System.Drawing.Point(77, 34);
            this.SpecKeyNamecomboBox.Name = "SpecKeyNamecomboBox";
            this.SpecKeyNamecomboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SpecKeyNamecomboBox.Size = new System.Drawing.Size(163, 21);
            this.SpecKeyNamecomboBox.Sorted = true;
            this.SpecKeyNamecomboBox.TabIndex = 20;
            this.SpecKeyNamecomboBox.SelectedIndexChanged += new System.EventHandler(this.AltercomboBoxValue_SelectedIndexChanged);
            // 
            // stylenamelabel
            // 
            this.stylenamelabel.AutoSize = true;
            this.stylenamelabel.Location = new System.Drawing.Point(1, 13);
            this.stylenamelabel.Name = "stylenamelabel";
            this.stylenamelabel.Size = new System.Drawing.Size(35, 13);
            this.stylenamelabel.TabIndex = 19;
            this.stylenamelabel.Text = "Name";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(1, 63);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(70, 13);
            this.label18.TabIndex = 18;
            this.label18.Text = "TranslationID";
            // 
            // TranslationIDtextBox
            // 
            this.TranslationIDtextBox.Location = new System.Drawing.Point(77, 60);
            this.TranslationIDtextBox.Name = "TranslationIDtextBox";
            this.TranslationIDtextBox.Size = new System.Drawing.Size(163, 20);
            this.TranslationIDtextBox.TabIndex = 5;
            this.TranslationIDtextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TranslationIDtextBox.TextChanged += new System.EventHandler(this.TranslationID_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(242, 13);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(83, 13);
            this.label15.TabIndex = 19;
            this.label15.Text = "Endurance Cost";
            // 
            // Growthratelabel
            // 
            this.Growthratelabel.AutoSize = true;
            this.Growthratelabel.Location = new System.Drawing.Point(242, 36);
            this.Growthratelabel.Name = "Growthratelabel";
            this.Growthratelabel.Size = new System.Drawing.Size(59, 13);
            this.Growthratelabel.TabIndex = 18;
            this.Growthratelabel.Text = "Growthrate";
            // 
            // BonustoHitlabel
            // 
            this.BonustoHitlabel.AutoSize = true;
            this.BonustoHitlabel.Location = new System.Drawing.Point(242, 63);
            this.BonustoHitlabel.Name = "BonustoHitlabel";
            this.BonustoHitlabel.Size = new System.Drawing.Size(65, 13);
            this.BonustoHitlabel.TabIndex = 22;
            this.BonustoHitlabel.Text = "Bonus to Hit";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(1, 37);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(78, 13);
            this.label44.TabIndex = 18;
            this.label44.Text = "SpecKeyName";
            // 
            // StyleNametextBox
            // 
            this.StyleNametextBox.Location = new System.Drawing.Point(77, 11);
            this.StyleNametextBox.Name = "StyleNametextBox";
            this.StyleNametextBox.Size = new System.Drawing.Size(163, 20);
            this.StyleNametextBox.TabIndex = 4;
            this.StyleNametextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // GrowthratetextBox
            // 
            this.GrowthratetextBox.Location = new System.Drawing.Point(325, 36);
            this.GrowthratetextBox.Name = "GrowthratetextBox";
            this.GrowthratetextBox.Size = new System.Drawing.Size(30, 20);
            this.GrowthratetextBox.TabIndex = 8;
            this.GrowthratetextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // EnduranceCosttextBox
            // 
            this.EnduranceCosttextBox.Location = new System.Drawing.Point(325, 10);
            this.EnduranceCosttextBox.Name = "EnduranceCosttextBox";
            this.EnduranceCosttextBox.Size = new System.Drawing.Size(30, 20);
            this.EnduranceCosttextBox.TabIndex = 4;
            this.EnduranceCosttextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BonustoHittextBox
            // 
            this.BonustoHittextBox.Location = new System.Drawing.Point(325, 64);
            this.BonustoHittextBox.Name = "BonustoHittextBox";
            this.BonustoHittextBox.Size = new System.Drawing.Size(30, 20);
            this.BonustoHittextBox.TabIndex = 11;
            this.BonustoHittextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.ClassIDcomboBox);
            this.groupBox10.Controls.Add(this.label49);
            this.groupBox10.Controls.Add(this.classidlabel);
            this.groupBox10.Controls.Add(this.StyleIDtextBox);
            this.groupBox10.Controls.Add(this.Iconlabel);
            this.groupBox10.Controls.Add(this.IcontextBox);
            this.groupBox10.Location = new System.Drawing.Point(6, 0);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(148, 99);
            this.groupBox10.TabIndex = 10;
            this.groupBox10.TabStop = false;
            // 
            // ClassIDcomboBox
            // 
            this.ClassIDcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClassIDcomboBox.FormattingEnabled = true;
            this.ClassIDcomboBox.Items.AddRange(new object[] {
            "Acolyte",
            "AlbionRogue",
            "Animist",
            "Armsman",
            "Bainshee",
            "Bard",
            "Berserker",
            "Blademaster",
            "Bonedancer",
            "Cabalist",
            "Champion",
            "Cleric",
            "Disciple",
            "Druid",
            "Eldritch",
            "Elementalist",
            "Enchanter",
            "Fighter",
            "Forester",
            "Friar",
            "Guardian",
            "Healer",
            "Heretic",
            "Hero",
            "Hunter",
            "Infiltrator",
            "Mage",
            "Magician",
            "Mauler_Alb",
            "Mauler_Hib",
            "Mauler_Mid",
            "Mentalist",
            "Mercenary",
            "MidgardRogue",
            "Minstrel",
            "Mystic",
            "Naturalist",
            "Necromancer",
            "Nightshade",
            "Paladin",
            "Ranger",
            "Reaver",
            "Runemaster",
            "Savage",
            "Scout",
            "Seer",
            "Shadowblade",
            "Shaman",
            "Skald",
            "Sorcerer",
            "Spiritmaster",
            "Stalker",
            "Thane",
            "Theurgist",
            "Valewalker",
            "Valkyrie",
            "Vampiir",
            "Viking",
            "Warden",
            "Warlock",
            "Warrior",
            "Wizard"});
            this.ClassIDcomboBox.Location = new System.Drawing.Point(33, 39);
            this.ClassIDcomboBox.MaxDropDownItems = 15;
            this.ClassIDcomboBox.Name = "ClassIDcomboBox";
            this.ClassIDcomboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ClassIDcomboBox.Size = new System.Drawing.Size(109, 21);
            this.ClassIDcomboBox.Sorted = true;
            this.ClassIDcomboBox.TabIndex = 21;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(2, 16);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(41, 13);
            this.label49.TabIndex = 19;
            this.label49.Text = "StyleID";
            // 
            // classidlabel
            // 
            this.classidlabel.AutoSize = true;
            this.classidlabel.Location = new System.Drawing.Point(2, 42);
            this.classidlabel.Name = "classidlabel";
            this.classidlabel.Size = new System.Drawing.Size(32, 13);
            this.classidlabel.TabIndex = 18;
            this.classidlabel.Text = "Class";
            // 
            // StyleIDtextBox
            // 
            this.StyleIDtextBox.Location = new System.Drawing.Point(59, 14);
            this.StyleIDtextBox.Name = "StyleIDtextBox";
            this.StyleIDtextBox.Size = new System.Drawing.Size(40, 20);
            this.StyleIDtextBox.TabIndex = 0;
            this.StyleIDtextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.StyleIDtextBox.TextChanged += new System.EventHandler(this.AltercomboBoxValue_SelectedIndexChanged);
            // 
            // Iconlabel
            // 
            this.Iconlabel.AutoSize = true;
            this.Iconlabel.Location = new System.Drawing.Point(2, 67);
            this.Iconlabel.Name = "Iconlabel";
            this.Iconlabel.Size = new System.Drawing.Size(28, 13);
            this.Iconlabel.TabIndex = 20;
            this.Iconlabel.Text = "Icon";
            // 
            // IcontextBox
            // 
            this.IcontextBox.Location = new System.Drawing.Point(59, 66);
            this.IcontextBox.Name = "IcontextBox";
            this.IcontextBox.Size = new System.Drawing.Size(40, 20);
            this.IcontextBox.TabIndex = 3;
            this.IcontextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dataGridStyle
            // 
            this.dataGridStyle.AllowUserToAddRows = false;
            this.dataGridStyle.AllowUserToOrderColumns = true;
            this.dataGridStyle.AutoGenerateColumns = false;
            this.dataGridStyle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridStyle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridStyle.DataSource = this.bindingSource1;
            this.dataGridStyle.Location = new System.Drawing.Point(7, 73);
            this.dataGridStyle.MultiSelect = false;
            this.dataGridStyle.Name = "dataGridStyle";
            this.dataGridStyle.ReadOnly = true;
            this.dataGridStyle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridStyle.Size = new System.Drawing.Size(984, 365);
            this.dataGridStyle.TabIndex = 19;
            this.dataGridStyle.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StyledataGridView_CellContentClick);
            // 
            // dataAdapterbindingsource1
            // 
            this.dataAdapterbindingsource1.DeleteCommand = null;
            this.dataAdapterbindingsource1.InsertCommand = null;
            this.dataAdapterbindingsource1.SelectCommand = null;
            this.dataAdapterbindingsource1.UpdateCommand = null;
            // 
            // commandBuilder
            // 
            this.commandBuilder.DataAdapter = this.dataAdapterbindingsource1;
            this.commandBuilder.QuotePrefix = "`";
            this.commandBuilder.QuoteSuffix = "`";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.StyleListingButton);
            this.groupBox1.Controls.Add(this.StyleAddButton);
            this.groupBox1.Controls.Add(this.SaveNewbutton);
            this.groupBox1.Controls.Add(this.Savebutton);
            this.groupBox1.Location = new System.Drawing.Point(816, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(175, 67);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // StyleListingButton
            // 
            this.StyleListingButton.Location = new System.Drawing.Point(94, 11);
            this.StyleListingButton.Name = "StyleListingButton";
            this.StyleListingButton.Size = new System.Drawing.Size(75, 23);
            this.StyleListingButton.TabIndex = 23;
            this.StyleListingButton.Text = "Style Listing";
            this.StyleListingButton.UseVisualStyleBackColor = true;
            this.StyleListingButton.Click += new System.EventHandler(this.StyleListing_Click);
            // 
            // StyleAddButton
            // 
            this.StyleAddButton.Location = new System.Drawing.Point(3, 11);
            this.StyleAddButton.Name = "StyleAddButton";
            this.StyleAddButton.Size = new System.Drawing.Size(87, 22);
            this.StyleAddButton.TabIndex = 22;
            this.StyleAddButton.Text = "Add new style";
            this.StyleAddButton.UseVisualStyleBackColor = true;
            this.StyleAddButton.Click += new System.EventHandler(this.AddNewStyle_Click);
            // 
            // LoadStyle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(994, 443);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridStyle);
            this.Controls.Add(this.EditStyleControl);
            this.Controls.Add(this.ControlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoadStyle";
            this.Text = "Style Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ControlMenu.ResumeLayout(false);
            this.ControlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.EditStyleControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator3)).EndInit();
            this.bindingNavigator3.ResumeLayout(false);
            this.bindingNavigator3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LanguageStyledataGridView)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).EndInit();
            this.bindingNavigator2.ResumeLayout(false);
            this.bindingNavigator2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StyleXSpelldataGridView)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStyle)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private TabPage tabPage1;

        private Button SaveNewbutton;
        private Button Savebutton;

        private TabControl EditStyleControl;
        private TextBox IcontextBox;

        private GroupBox ControlMenu;
        private GroupBox groupBox7;
        private GroupBox groupBox8;
        private GroupBox groupBox10;
        private GroupBox groupBox9;

        private TextBox SearchStyleIDtextBox;
        private TextBox SearchByStyleNametextBox;
        private TextBox textBox36;
        private TextBox textBox7;
        private TextBox textBox3;
        private TextBox BonustoDefensetextBox;
        private TextBox BonustoHittextBox;
        private TextBox EnduranceCosttextBox;
        private TextBox GrowthratetextBox;
        private TextBox TwoHandAnimtextBox;
        private TextBox StyleIDtextBox;
        private TextBox SpecLevelRequirementtextBox;
        private Label label18;
        private Label OpeningRequirementTypelabel;
        private Label StealthRequirementlabel;
        private Label Iconlabel;
        private Label label47;
        private Label label46;
        private Label label45;
        private Label Classlabel;
        private Label Speclabel;
        private Label label2;
        private Label label5;
        private Label stylenamelabel;
        private Label label44;
        private Label SpecLevelRequirementlabel;
        private Label label49;
        private Label classidlabel;
        private Label BonustoDefenselabel;
        private Label BonustoHitlabel;
        private Label RandomProclabel;
        private Label TwoHandAnimationlabel;
        private Label label15;
        private Label Growthratelabel;

        private DataGridView dataGridStyle;

        private ComboBox StyleSearchKeyNamecomboBox;
        private ComboBox ClassIDSearchcomboBox;
        private ComboBox StealthRequirementcomboBox;
        private ComboBox OpeningRequirementTypecomboBox;
        private ComboBox SpecKeyNamecomboBox;
        private TextBox StyleNametextBox;
        private ComboBox WeaponTypeRequirementcomboBox;
        private Label WeaponTypeRequirementlabel;
        private ComboBox AttackResultRequirementcomboBox;
        private Label AttackResultRequirementlabel;
        private Label OpeningRequirementValuelabel;
        private Label ArmorHitLoclabel;
        private TextBox ArmorHitLoctextBox;
        private BindingNavigator bindingNavigator1;
        private ToolStripLabel bindingNavigatorCountItem;
        private ToolStripButton bindingNavigatorDeleteItem;
        private ToolStripButton bindingNavigatorMoveFirstItem;
        private ToolStripButton bindingNavigatorMovePreviousItem;
        private ToolStripSeparator bindingNavigatorSeparator;
        private ToolStripTextBox bindingNavigatorPositionItem;
        private ToolStripSeparator bindingNavigatorSeparator1;
        private ToolStripButton bindingNavigatorMoveNextItem;
        private ToolStripButton bindingNavigatorMoveLastItem;
        private ToolStripSeparator bindingNavigatorSeparator2;
        private ComboBox RandomProccomboBox;
        private GroupBox groupBox4;
        private Button button3;
        private DataGridView StyleXSpelldataGridView;
        private BindingSource bindingSource2;
        private BindingNavigator bindingNavigator2;
        private ToolStripButton bindingNavigatorDeleteItem1;
        private GroupBox groupBox5;
        private Label label6;
        private TextBox ChancetextBox;
        private Label label3;
        private TextBox SpellIDStyleXSpelltextBox;
        private GroupBox groupBox12;
        private TextBox TranslationIDtextBox;
        private BindingNavigator bindingNavigator3;
        private BindingSource bindingSource3;
        private ToolStripButton bindingNavigatorDeleteItem2;
        private DataGridView LanguageStyledataGridView;
        private GroupBox groupBox6;
        private Label label9;
        private RichTextBox DescriptionLanguageStylerichTextBox;
        private Label label8;
        private TextBox NameLanguageStyletextBox;
        private ComboBox LanguageChoicecomboBox;
        private Label label4;
        private TextBox TagLanguagueStyletextBox;
        private Label label7;
        private Button button1;
        private GroupBox groupBox1;
        private Button StyleListingButton;
        private Button StyleAddButton;
        private ComboBox OpeningRequirementValuecomboBox;
        private ComboBox ClassIDcomboBox;

    }
}