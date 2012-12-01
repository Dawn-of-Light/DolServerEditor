namespace Origins_Editor
{
    partial class LoadLootOTD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadLootOTD));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.id_nbSearchtextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.MobNameSearchtextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.LootOTDbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LootOTDbindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.LootOTDdataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.MobNametextBox = new System.Windows.Forms.TextBox();
            this.AllowedClasslistView = new System.Windows.Forms.ListView();
            this.ClassNamecolumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.id_nbAddtextBox = new System.Windows.Forms.TextBox();
            this.MinLevelnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LootOTDbindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LootOTDbindingNavigator)).BeginInit();
            this.LootOTDbindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LootOTDdataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinLevelnumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.id_nbSearchtextBox);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.MobNameSearchtextBox);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(7, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(469, 46);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filters";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(399, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(59, 23);
            this.button4.TabIndex = 24;
            this.button4.Text = "Search";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Searchbutton_Click);
            // 
            // id_nbSearchtextBox
            // 
            this.id_nbSearchtextBox.Location = new System.Drawing.Point(299, 14);
            this.id_nbSearchtextBox.Name = "id_nbSearchtextBox";
            this.id_nbSearchtextBox.Size = new System.Drawing.Size(80, 20);
            this.id_nbSearchtextBox.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(233, 17);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "Item id_nb";
            // 
            // MobNameSearchtextBox
            // 
            this.MobNameSearchtextBox.Location = new System.Drawing.Point(66, 14);
            this.MobNameSearchtextBox.Name = "MobNameSearchtextBox";
            this.MobNameSearchtextBox.Size = new System.Drawing.Size(158, 20);
            this.MobNameSearchtextBox.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Mob Name";
            // 
            // LootOTDbindingNavigator
            // 
            this.LootOTDbindingNavigator.AddNewItem = null;
            this.LootOTDbindingNavigator.BindingSource = this.LootOTDbindingSource;
            this.LootOTDbindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.LootOTDbindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.LootOTDbindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.LootOTDbindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.LootOTDbindingNavigator.Location = new System.Drawing.Point(7, 52);
            this.LootOTDbindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.LootOTDbindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.LootOTDbindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.LootOTDbindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.LootOTDbindingNavigator.Name = "LootOTDbindingNavigator";
            this.LootOTDbindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.LootOTDbindingNavigator.Size = new System.Drawing.Size(232, 25);
            this.LootOTDbindingNavigator.TabIndex = 7;
            this.LootOTDbindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
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
            // LootOTDdataGridView
            // 
            this.LootOTDdataGridView.AllowUserToAddRows = false;
            this.LootOTDdataGridView.AllowUserToOrderColumns = true;
            this.LootOTDdataGridView.AutoGenerateColumns = false;
            this.LootOTDdataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LootOTDdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LootOTDdataGridView.DataSource = this.LootOTDbindingSource;
            this.LootOTDdataGridView.Location = new System.Drawing.Point(7, 80);
            this.LootOTDdataGridView.MultiSelect = false;
            this.LootOTDdataGridView.Name = "LootOTDdataGridView";
            this.LootOTDdataGridView.ReadOnly = true;
            this.LootOTDdataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.LootOTDdataGridView.Size = new System.Drawing.Size(469, 150);
            this.LootOTDdataGridView.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.MobNametextBox);
            this.groupBox1.Controls.Add(this.AllowedClasslistView);
            this.groupBox1.Controls.Add(this.id_nbAddtextBox);
            this.groupBox1.Controls.Add(this.MinLevelnumericUpDown);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(7, 236);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(469, 154);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loot OTD Add";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(394, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Save OTD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SaveLootOTDbutton_Click);
            // 
            // MobNametextBox
            // 
            this.MobNametextBox.Location = new System.Drawing.Point(5, 74);
            this.MobNametextBox.Name = "MobNametextBox";
            this.MobNametextBox.Size = new System.Drawing.Size(214, 20);
            this.MobNametextBox.TabIndex = 7;
            // 
            // AllowedClasslistView
            // 
            this.AllowedClasslistView.AllowColumnReorder = true;
            this.AllowedClasslistView.BackColor = System.Drawing.SystemColors.Control;
            this.AllowedClasslistView.CheckBoxes = true;
            this.AllowedClasslistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ClassNamecolumnHeader});
            this.AllowedClasslistView.GridLines = true;
            listViewItem1.StateImageIndex = 0;
            this.AllowedClasslistView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.AllowedClasslistView.Location = new System.Drawing.Point(225, 16);
            this.AllowedClasslistView.MultiSelect = false;
            this.AllowedClasslistView.Name = "AllowedClasslistView";
            this.AllowedClasslistView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AllowedClasslistView.Size = new System.Drawing.Size(164, 132);
            this.AllowedClasslistView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.AllowedClasslistView.TabIndex = 6;
            this.AllowedClasslistView.UseCompatibleStateImageBehavior = false;
            this.AllowedClasslistView.View = System.Windows.Forms.View.Details;
            this.AllowedClasslistView.Visible = false;
            // 
            // ClassNamecolumnHeader
            // 
            this.ClassNamecolumnHeader.Text = "Allowed Class";
            this.ClassNamecolumnHeader.Width = 128;
            // 
            // id_nbAddtextBox
            // 
            this.id_nbAddtextBox.Location = new System.Drawing.Point(5, 35);
            this.id_nbAddtextBox.Name = "id_nbAddtextBox";
            this.id_nbAddtextBox.Size = new System.Drawing.Size(214, 20);
            this.id_nbAddtextBox.TabIndex = 5;
            // 
            // MinLevelnumericUpDown
            // 
            this.MinLevelnumericUpDown.Location = new System.Drawing.Point(89, 119);
            this.MinLevelnumericUpDown.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.MinLevelnumericUpDown.Name = "MinLevelnumericUpDown";
            this.MinLevelnumericUpDown.Size = new System.Drawing.Size(39, 20);
            this.MinLevelnumericUpDown.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mob Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Min Level";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Itemtemplate Id_nb";
            // 
            // LoadLootOTD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 395);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LootOTDdataGridView);
            this.Controls.Add(this.LootOTDbindingNavigator);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoadLootOTD";
            this.Text = "OTD Editor";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LootOTDbindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LootOTDbindingNavigator)).EndInit();
            this.LootOTDbindingNavigator.ResumeLayout(false);
            this.LootOTDbindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LootOTDdataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinLevelnumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox id_nbSearchtextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox MobNameSearchtextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.BindingSource LootOTDbindingSource;
        private System.Windows.Forms.BindingNavigator LootOTDbindingNavigator;
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
        private System.Windows.Forms.DataGridView LootOTDdataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox MobNametextBox;
        private System.Windows.Forms.ListView AllowedClasslistView;
        private System.Windows.Forms.TextBox id_nbAddtextBox;
        private System.Windows.Forms.NumericUpDown MinLevelnumericUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader ClassNamecolumnHeader;
        private System.Windows.Forms.Button button1;
    }
}