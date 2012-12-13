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

namespace Origins_Editor
{
    partial class LoadBattleGround
    {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadBattleGround));
            this.BattlegrounddataGridView = new System.Windows.Forms.DataGridView();
            this.BattleGroundbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BattleGroundbindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.MaxRealmLevelNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.MaxLevelNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.MinLevelNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RegionIDtextBox = new System.Windows.Forms.TextBox();
            this.SaveNewbutton = new System.Windows.Forms.Button();
            this.Savebutton = new System.Windows.Forms.Button();
            this.ControlMenu = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AddBattleGroundButton = new System.Windows.Forms.Button();
            this.ZoneListingButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BattlegrounddataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BattleGroundbindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BattleGroundbindingNavigator)).BeginInit();
            this.BattleGroundbindingNavigator.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxRealmLevelNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxLevelNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinLevelNumericUpDown)).BeginInit();
            this.ControlMenu.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BattlegrounddataGridView
            // 
            this.BattlegrounddataGridView.AllowUserToAddRows = false;
            this.BattlegrounddataGridView.AllowUserToOrderColumns = true;
            this.BattlegrounddataGridView.AutoGenerateColumns = false;
            this.BattlegrounddataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BattlegrounddataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BattlegrounddataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BattlegrounddataGridView.DataSource = this.BattleGroundbindingSource;
            this.BattlegrounddataGridView.Location = new System.Drawing.Point(7, 68);
            this.BattlegrounddataGridView.MultiSelect = false;
            this.BattlegrounddataGridView.Name = "BattlegrounddataGridView";
            this.BattlegrounddataGridView.ReadOnly = true;
            this.BattlegrounddataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BattlegrounddataGridView.Size = new System.Drawing.Size(625, 142);
            this.BattlegrounddataGridView.TabIndex = 0;
            this.BattlegrounddataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BattlegrounddataGridView_CellContentClick);
            // 
            // BattleGroundbindingNavigator
            // 
            this.BattleGroundbindingNavigator.AddNewItem = null;
            this.BattleGroundbindingNavigator.BindingSource = this.BattleGroundbindingSource;
            this.BattleGroundbindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.BattleGroundbindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.BattleGroundbindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.BattleGroundbindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.BattleGroundbindingNavigator.Location = new System.Drawing.Point(4, 16);
            this.BattleGroundbindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.BattleGroundbindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.BattleGroundbindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.BattleGroundbindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.BattleGroundbindingNavigator.Name = "BattleGroundbindingNavigator";
            this.BattleGroundbindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.BattleGroundbindingNavigator.Size = new System.Drawing.Size(232, 25);
            this.BattleGroundbindingNavigator.TabIndex = 1;
            this.BattleGroundbindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.BattleGroundNavigatorDeleteItem_Click);
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(7, 72);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(625, 138);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.MaxRealmLevelNumericUpDown);
            this.tabPage1.Controls.Add(this.MaxLevelNumericUpDown);
            this.tabPage1.Controls.Add(this.MinLevelNumericUpDown);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.RegionIDtextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(617, 112);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Battleground Editor";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // MaxRealmLevelNumericUpDown
            // 
            this.MaxRealmLevelNumericUpDown.Location = new System.Drawing.Point(545, 9);
            this.MaxRealmLevelNumericUpDown.Maximum = new decimal(new int[] {
            51,
            0,
            0,
            0});
            this.MaxRealmLevelNumericUpDown.Name = "MaxRealmLevelNumericUpDown";
            this.MaxRealmLevelNumericUpDown.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MaxRealmLevelNumericUpDown.Size = new System.Drawing.Size(47, 20);
            this.MaxRealmLevelNumericUpDown.TabIndex = 26;
            // 
            // MaxLevelNumericUpDown
            // 
            this.MaxLevelNumericUpDown.Location = new System.Drawing.Point(363, 9);
            this.MaxLevelNumericUpDown.Maximum = new decimal(new int[] {
            51,
            0,
            0,
            0});
            this.MaxLevelNumericUpDown.Name = "MaxLevelNumericUpDown";
            this.MaxLevelNumericUpDown.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MaxLevelNumericUpDown.Size = new System.Drawing.Size(49, 20);
            this.MaxLevelNumericUpDown.TabIndex = 27;
            // 
            // MinLevelNumericUpDown
            // 
            this.MinLevelNumericUpDown.Location = new System.Drawing.Point(203, 8);
            this.MinLevelNumericUpDown.Maximum = new decimal(new int[] {
            51,
            0,
            0,
            0});
            this.MinLevelNumericUpDown.Name = "MinLevelNumericUpDown";
            this.MinLevelNumericUpDown.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MinLevelNumericUpDown.Size = new System.Drawing.Size(49, 20);
            this.MinLevelNumericUpDown.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(457, 11);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Max RealmLevel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(301, 11);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Max Level";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 11);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Min Level";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "RegionID";
            // 
            // RegionIDtextBox
            // 
            this.RegionIDtextBox.Location = new System.Drawing.Point(67, 8);
            this.RegionIDtextBox.Name = "RegionIDtextBox";
            this.RegionIDtextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RegionIDtextBox.Size = new System.Drawing.Size(45, 20);
            this.RegionIDtextBox.TabIndex = 0;
            // 
            // SaveNewbutton
            // 
            this.SaveNewbutton.Location = new System.Drawing.Point(67, 39);
            this.SaveNewbutton.Name = "SaveNewbutton";
            this.SaveNewbutton.Size = new System.Drawing.Size(129, 23);
            this.SaveNewbutton.TabIndex = 23;
            this.SaveNewbutton.Text = "Save New Battleground";
            this.SaveNewbutton.UseVisualStyleBackColor = true;
            this.SaveNewbutton.Click += new System.EventHandler(this.SaveNewBattleGround_Click);
            // 
            // Savebutton
            // 
            this.Savebutton.Location = new System.Drawing.Point(67, 39);
            this.Savebutton.Name = "Savebutton";
            this.Savebutton.Size = new System.Drawing.Size(129, 23);
            this.Savebutton.TabIndex = 22;
            this.Savebutton.Text = "Save Loaded Battleground";
            this.Savebutton.UseVisualStyleBackColor = true;
            this.Savebutton.Click += new System.EventHandler(this.SaveLoadedBattleGround_Click);
            // 
            // ControlMenu
            // 
            this.ControlMenu.Controls.Add(this.BattleGroundbindingNavigator);
            this.ControlMenu.Location = new System.Drawing.Point(16, 0);
            this.ControlMenu.Name = "ControlMenu";
            this.ControlMenu.Size = new System.Drawing.Size(290, 45);
            this.ControlMenu.TabIndex = 24;
            this.ControlMenu.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AddBattleGroundButton);
            this.groupBox2.Controls.Add(this.ZoneListingButton);
            this.groupBox2.Controls.Add(this.SaveNewbutton);
            this.groupBox2.Controls.Add(this.Savebutton);
            this.groupBox2.Location = new System.Drawing.Point(367, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(265, 67);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            // 
            // AddBattleGroundButton
            // 
            this.AddBattleGroundButton.Location = new System.Drawing.Point(6, 10);
            this.AddBattleGroundButton.Name = "AddBattleGroundButton";
            this.AddBattleGroundButton.Size = new System.Drawing.Size(129, 23);
            this.AddBattleGroundButton.TabIndex = 24;
            this.AddBattleGroundButton.Text = "Add New BattleGround";
            this.AddBattleGroundButton.UseVisualStyleBackColor = true;
            this.AddBattleGroundButton.Click += new System.EventHandler(this.AddNewZone_Click);
            // 
            // ZoneListingButton
            // 
            this.ZoneListingButton.Location = new System.Drawing.Point(145, 10);
            this.ZoneListingButton.Name = "ZoneListingButton";
            this.ZoneListingButton.Size = new System.Drawing.Size(111, 23);
            this.ZoneListingButton.TabIndex = 25;
            this.ZoneListingButton.Text = "BattleGround Listing";
            this.ZoneListingButton.UseVisualStyleBackColor = true;
            this.ZoneListingButton.Click += new System.EventHandler(this.BattleGroundListing_Click);
            // 
            // LoadBattleGround
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 217);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ControlMenu);
            this.Controls.Add(this.BattlegrounddataGridView);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoadBattleGround";
            this.Text = "BattleGround Editor";
            ((System.ComponentModel.ISupportInitialize)(this.BattlegrounddataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BattleGroundbindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BattleGroundbindingNavigator)).EndInit();
            this.BattleGroundbindingNavigator.ResumeLayout(false);
            this.BattleGroundbindingNavigator.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxRealmLevelNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxLevelNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinLevelNumericUpDown)).EndInit();
            this.ControlMenu.ResumeLayout(false);
            this.ControlMenu.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView BattlegrounddataGridView;
        private System.Windows.Forms.BindingSource BattleGroundbindingSource;
        private System.Windows.Forms.BindingNavigator BattleGroundbindingNavigator;
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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RegionIDtextBox;
        private System.Windows.Forms.Button SaveNewbutton;
        private System.Windows.Forms.Button Savebutton;
        private System.Windows.Forms.GroupBox ControlMenu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button AddBattleGroundButton;
        private System.Windows.Forms.Button ZoneListingButton;
        private System.Windows.Forms.NumericUpDown MaxRealmLevelNumericUpDown;
        private System.Windows.Forms.NumericUpDown MaxLevelNumericUpDown;
        private System.Windows.Forms.NumericUpDown MinLevelNumericUpDown;
    }
}