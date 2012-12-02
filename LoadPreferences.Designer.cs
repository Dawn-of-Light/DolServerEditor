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
using MySql.Data.MySqlClient;

namespace Origins_Editor
{
    partial class LoadPreferences
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadPreferences));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PortNumbertextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.OriginsDatabaseSettingscheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DatabasePWDtextBox = new System.Windows.Forms.TextBox();
            this.DatabaseUsertextBox = new System.Windows.Forms.TextBox();
            this.DatabaseNametextBox = new System.Windows.Forms.TextBox();
            this.DatabaseUserlabel = new System.Windows.Forms.Label();
            this.DatabaseUserPWDlabel = new System.Windows.Forms.Label();
            this.DatabaseNamelabel = new System.Windows.Forms.Label();
            this.ServerIPtextBox = new System.Windows.Forms.TextBox();
            this.serveriplabel = new System.Windows.Forms.Label();
            this.saveconfigurationbutton = new System.Windows.Forms.Button();
            this.TestConnectionbutton = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.PortNumbertextBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.OriginsDatabaseSettingscheckBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.DatabasePWDtextBox);
            this.groupBox2.Controls.Add(this.DatabaseUsertextBox);
            this.groupBox2.Controls.Add(this.DatabaseNametextBox);
            this.groupBox2.Controls.Add(this.DatabaseUserlabel);
            this.groupBox2.Controls.Add(this.DatabaseUserPWDlabel);
            this.groupBox2.Controls.Add(this.DatabaseNamelabel);
            this.groupBox2.Controls.Add(this.ServerIPtextBox);
            this.groupBox2.Controls.Add(this.serveriplabel);
            this.groupBox2.Location = new System.Drawing.Point(7, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(209, 175);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Server connection";
            // 
            // PortNumbertextBox
            // 
            this.PortNumbertextBox.Location = new System.Drawing.Point(93, 49);
            this.PortNumbertextBox.Name = "PortNumbertextBox";
            this.PortNumbertextBox.Size = new System.Drawing.Size(94, 20);
            this.PortNumbertextBox.TabIndex = 22;
            this.PortNumbertextBox.Text = "3306";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Port Number:";
            // 
            // OriginsDatabaseSettingscheckBox
            // 
            this.OriginsDatabaseSettingscheckBox.AutoSize = true;
            this.OriginsDatabaseSettingscheckBox.Location = new System.Drawing.Point(147, 150);
            this.OriginsDatabaseSettingscheckBox.Name = "OriginsDatabaseSettingscheckBox";
            this.OriginsDatabaseSettingscheckBox.Size = new System.Drawing.Size(15, 14);
            this.OriginsDatabaseSettingscheckBox.TabIndex = 20;
            this.OriginsDatabaseSettingscheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Origins Database Settings:";
            // 
            // DatabasePWDtextBox
            // 
            this.DatabasePWDtextBox.Location = new System.Drawing.Point(93, 126);
            this.DatabasePWDtextBox.Name = "DatabasePWDtextBox";
            this.DatabasePWDtextBox.Size = new System.Drawing.Size(94, 20);
            this.DatabasePWDtextBox.TabIndex = 18;
            this.DatabasePWDtextBox.Text = global::DolEditor.Properties.Settings.Default.Password;
            this.DatabasePWDtextBox.UseSystemPasswordChar = true;
            // 
            // DatabaseUsertextBox
            // 
            this.DatabaseUsertextBox.Location = new System.Drawing.Point(93, 102);
            this.DatabaseUsertextBox.Name = "DatabaseUsertextBox";
            this.DatabaseUsertextBox.Size = new System.Drawing.Size(94, 20);
            this.DatabaseUsertextBox.TabIndex = 17;
            this.DatabaseUsertextBox.Text = global::DolEditor.Properties.Settings.Default.Username;
            // 
            // DatabaseNametextBox
            // 
            this.DatabaseNametextBox.Location = new System.Drawing.Point(93, 76);
            this.DatabaseNametextBox.Name = "DatabaseNametextBox";
            this.DatabaseNametextBox.Size = new System.Drawing.Size(94, 20);
            this.DatabaseNametextBox.TabIndex = 16;
            this.DatabaseNametextBox.Text = global::DolEditor.Properties.Settings.Default.DatabaseName;
            // 
            // DatabaseUserlabel
            // 
            this.DatabaseUserlabel.AutoSize = true;
            this.DatabaseUserlabel.Location = new System.Drawing.Point(12, 105);
            this.DatabaseUserlabel.Name = "DatabaseUserlabel";
            this.DatabaseUserlabel.Size = new System.Drawing.Size(81, 13);
            this.DatabaseUserlabel.TabIndex = 15;
            this.DatabaseUserlabel.Text = "Database User:";
            // 
            // DatabaseUserPWDlabel
            // 
            this.DatabaseUserPWDlabel.AutoSize = true;
            this.DatabaseUserPWDlabel.Location = new System.Drawing.Point(12, 129);
            this.DatabaseUserPWDlabel.Name = "DatabaseUserPWDlabel";
            this.DatabaseUserPWDlabel.Size = new System.Drawing.Size(81, 13);
            this.DatabaseUserPWDlabel.TabIndex = 14;
            this.DatabaseUserPWDlabel.Text = "User Password:";
            // 
            // DatabaseNamelabel
            // 
            this.DatabaseNamelabel.AutoSize = true;
            this.DatabaseNamelabel.Location = new System.Drawing.Point(6, 79);
            this.DatabaseNamelabel.Name = "DatabaseNamelabel";
            this.DatabaseNamelabel.Size = new System.Drawing.Size(87, 13);
            this.DatabaseNamelabel.TabIndex = 13;
            this.DatabaseNamelabel.Text = "Database Name:";
            // 
            // ServerIPtextBox
            // 
            this.ServerIPtextBox.Location = new System.Drawing.Point(93, 23);
            this.ServerIPtextBox.Name = "ServerIPtextBox";
            this.ServerIPtextBox.Size = new System.Drawing.Size(94, 20);
            this.ServerIPtextBox.TabIndex = 11;
            this.ServerIPtextBox.Text = global::DolEditor.Properties.Settings.Default.ServerIP;
            // 
            // serveriplabel
            // 
            this.serveriplabel.AutoSize = true;
            this.serveriplabel.Location = new System.Drawing.Point(73, 26);
            this.serveriplabel.Name = "serveriplabel";
            this.serveriplabel.Size = new System.Drawing.Size(20, 13);
            this.serveriplabel.TabIndex = 10;
            this.serveriplabel.Text = "IP:";
            // 
            // saveconfigurationbutton
            // 
            this.saveconfigurationbutton.Location = new System.Drawing.Point(109, 193);
            this.saveconfigurationbutton.Name = "saveconfigurationbutton";
            this.saveconfigurationbutton.Size = new System.Drawing.Size(107, 23);
            this.saveconfigurationbutton.TabIndex = 3;
            this.saveconfigurationbutton.Text = "Save Configuration";
            this.saveconfigurationbutton.UseVisualStyleBackColor = true;
            this.saveconfigurationbutton.Click += new System.EventHandler(this.SavePreferences_Click);
            // 
            // TestConnectionbutton
            // 
            this.TestConnectionbutton.Location = new System.Drawing.Point(7, 193);
            this.TestConnectionbutton.Name = "TestConnectionbutton";
            this.TestConnectionbutton.Size = new System.Drawing.Size(96, 23);
            this.TestConnectionbutton.TabIndex = 4;
            this.TestConnectionbutton.Text = "Test Connection";
            this.TestConnectionbutton.UseVisualStyleBackColor = true;
            this.TestConnectionbutton.Click += new System.EventHandler(this.VerifyConnectivity_Tick);
            // 
            // LoadPreferences
            // 
            this.AcceptButton = this.saveconfigurationbutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 221);
            this.Controls.Add(this.TestConnectionbutton);
            this.Controls.Add(this.saveconfigurationbutton);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoadPreferences";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Preferences";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label serveriplabel;
        private System.Windows.Forms.TextBox ServerIPtextBox;
        private System.Windows.Forms.Label DatabaseUserlabel;
        private System.Windows.Forms.Label DatabaseUserPWDlabel;
        private System.Windows.Forms.Label DatabaseNamelabel;
        private System.Windows.Forms.TextBox DatabasePWDtextBox;
        private System.Windows.Forms.TextBox DatabaseUsertextBox;
        private System.Windows.Forms.TextBox DatabaseNametextBox;
        private System.Windows.Forms.Button saveconfigurationbutton;
        private Button TestConnectionbutton;
        private CheckBox OriginsDatabaseSettingscheckBox;
        private Label label1;
        private TextBox PortNumbertextBox;
        private Label label2;
    }
}