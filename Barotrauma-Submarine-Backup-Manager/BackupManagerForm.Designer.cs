using System;

namespace Barotrauma_Submarine_Backup_Manager
{
    partial class BackupManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackupManagerForm));
            this.TabControl = new System.Windows.Forms.TabControl();
            this.BackupPage = new System.Windows.Forms.TabPage();
            this.BackupMsgLabel = new System.Windows.Forms.Label();
            this.BackupPictureBox = new System.Windows.Forms.PictureBox();
            this.BackupButton = new System.Windows.Forms.Button();
            this.SettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.VersioningGroupBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SubNameCheckBox = new System.Windows.Forms.CheckBox();
            this.AutoIncrementCheckBox = new System.Windows.Forms.CheckBox();
            this.MinorRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuffixRichTextBox = new System.Windows.Forms.RichTextBox();
            this.PrefixRichTextBox = new System.Windows.Forms.RichTextBox();
            this.MajorRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuffixLabel = new System.Windows.Forms.Label();
            this.PrefixLabel = new System.Windows.Forms.Label();
            this.MinorLabel = new System.Windows.Forms.Label();
            this.MajorLabel = new System.Windows.Forms.Label();
            this.OutputGroupBox = new System.Windows.Forms.GroupBox();
            this.OutputSelectBrowseButton = new System.Windows.Forms.Button();
            this.BackupPathTextBox = new System.Windows.Forms.TextBox();
            this.SubGroupBox = new System.Windows.Forms.GroupBox();
            this.SubSelectBrowseButton = new System.Windows.Forms.Button();
            this.SubPathTextBox = new System.Windows.Forms.TextBox();
            this.RestorePage = new System.Windows.Forms.TabPage();
            this.RemoveVersionCheckBox = new System.Windows.Forms.CheckBox();
            this.RestoreMsgLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RestoreLocationBrowseButton = new System.Windows.Forms.Button();
            this.RestorePathTextBox = new System.Windows.Forms.TextBox();
            this.RestoreSubNameLabel = new System.Windows.Forms.Label();
            this.RestorePictureBox = new System.Windows.Forms.PictureBox();
            this.SubBackupList = new System.Windows.Forms.ListBox();
            this.RestoreButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BackupLoadFolderBrowseButton = new System.Windows.Forms.Button();
            this.BackupLoadPathTextBox = new System.Windows.Forms.TextBox();
            this.TabControl.SuspendLayout();
            this.BackupPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackupPictureBox)).BeginInit();
            this.SettingsGroupBox.SuspendLayout();
            this.VersioningGroupBox.SuspendLayout();
            this.OutputGroupBox.SuspendLayout();
            this.SubGroupBox.SuspendLayout();
            this.RestorePage.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RestorePictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl.Controls.Add(this.BackupPage);
            this.TabControl.Controls.Add(this.RestorePage);
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(801, 461);
            this.TabControl.TabIndex = 1;
            // 
            // BackupPage
            // 
            this.BackupPage.BackColor = System.Drawing.SystemColors.Control;
            this.BackupPage.Controls.Add(this.BackupMsgLabel);
            this.BackupPage.Controls.Add(this.BackupPictureBox);
            this.BackupPage.Controls.Add(this.BackupButton);
            this.BackupPage.Controls.Add(this.SettingsGroupBox);
            this.BackupPage.Controls.Add(this.OutputGroupBox);
            this.BackupPage.Controls.Add(this.SubGroupBox);
            this.BackupPage.Location = new System.Drawing.Point(4, 25);
            this.BackupPage.Name = "BackupPage";
            this.BackupPage.Padding = new System.Windows.Forms.Padding(3);
            this.BackupPage.Size = new System.Drawing.Size(793, 432);
            this.BackupPage.TabIndex = 0;
            this.BackupPage.Text = "Backup";
            // 
            // BackupMsgLabel
            // 
            this.BackupMsgLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BackupMsgLabel.AutoSize = true;
            this.BackupMsgLabel.Location = new System.Drawing.Point(6, 412);
            this.BackupMsgLabel.Name = "BackupMsgLabel";
            this.BackupMsgLabel.Size = new System.Drawing.Size(0, 17);
            this.BackupMsgLabel.TabIndex = 15;
            // 
            // BackupPictureBox
            // 
            this.BackupPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BackupPictureBox.Location = new System.Drawing.Point(499, 136);
            this.BackupPictureBox.Name = "BackupPictureBox";
            this.BackupPictureBox.Size = new System.Drawing.Size(288, 233);
            this.BackupPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BackupPictureBox.TabIndex = 12;
            this.BackupPictureBox.TabStop = false;
            // 
            // BackupButton
            // 
            this.BackupButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BackupButton.Location = new System.Drawing.Point(602, 396);
            this.BackupButton.Name = "BackupButton";
            this.BackupButton.Size = new System.Drawing.Size(185, 30);
            this.BackupButton.TabIndex = 11;
            this.BackupButton.Text = "Create Backup";
            this.BackupButton.UseVisualStyleBackColor = true;
            this.BackupButton.Click += new System.EventHandler(this.BackupButton_Click);
            // 
            // SettingsGroupBox
            // 
            this.SettingsGroupBox.Controls.Add(this.VersioningGroupBox);
            this.SettingsGroupBox.Location = new System.Drawing.Point(6, 136);
            this.SettingsGroupBox.Name = "SettingsGroupBox";
            this.SettingsGroupBox.Size = new System.Drawing.Size(487, 159);
            this.SettingsGroupBox.TabIndex = 7;
            this.SettingsGroupBox.TabStop = false;
            this.SettingsGroupBox.Text = "Settings";
            // 
            // VersioningGroupBox
            // 
            this.VersioningGroupBox.Controls.Add(this.label3);
            this.VersioningGroupBox.Controls.Add(this.label1);
            this.VersioningGroupBox.Controls.Add(this.label2);
            this.VersioningGroupBox.Controls.Add(this.SubNameCheckBox);
            this.VersioningGroupBox.Controls.Add(this.AutoIncrementCheckBox);
            this.VersioningGroupBox.Controls.Add(this.MinorRichTextBox);
            this.VersioningGroupBox.Controls.Add(this.SuffixRichTextBox);
            this.VersioningGroupBox.Controls.Add(this.PrefixRichTextBox);
            this.VersioningGroupBox.Controls.Add(this.MajorRichTextBox);
            this.VersioningGroupBox.Controls.Add(this.SuffixLabel);
            this.VersioningGroupBox.Controls.Add(this.PrefixLabel);
            this.VersioningGroupBox.Controls.Add(this.MinorLabel);
            this.VersioningGroupBox.Controls.Add(this.MajorLabel);
            this.VersioningGroupBox.Location = new System.Drawing.Point(6, 21);
            this.VersioningGroupBox.Name = "VersioningGroupBox";
            this.VersioningGroupBox.Size = new System.Drawing.Size(473, 129);
            this.VersioningGroupBox.TabIndex = 0;
            this.VersioningGroupBox.TabStop = false;
            this.VersioningGroupBox.Text = "Version";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(291, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "-v";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = ".";
            // 
            // SubNameCheckBox
            // 
            this.SubNameCheckBox.AutoSize = true;
            this.SubNameCheckBox.Checked = true;
            this.SubNameCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SubNameCheckBox.Location = new System.Drawing.Point(8, 92);
            this.SubNameCheckBox.Name = "SubNameCheckBox";
            this.SubNameCheckBox.Size = new System.Drawing.Size(277, 21);
            this.SubNameCheckBox.TabIndex = 10;
            this.SubNameCheckBox.Text = "Put version number in submarine name";
            this.SubNameCheckBox.UseVisualStyleBackColor = true;
            // 
            // AutoIncrementCheckBox
            // 
            this.AutoIncrementCheckBox.AutoSize = true;
            this.AutoIncrementCheckBox.Location = new System.Drawing.Point(8, 65);
            this.AutoIncrementCheckBox.Name = "AutoIncrementCheckBox";
            this.AutoIncrementCheckBox.Size = new System.Drawing.Size(394, 21);
            this.AutoIncrementCheckBox.TabIndex = 9;
            this.AutoIncrementCheckBox.Text = "Automatically increment version number with each backup";
            this.AutoIncrementCheckBox.UseVisualStyleBackColor = true;
            // 
            // MinorRichTextBox
            // 
            this.MinorRichTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.MinorRichTextBox.Location = new System.Drawing.Point(241, 35);
            this.MinorRichTextBox.Multiline = false;
            this.MinorRichTextBox.Name = "MinorRichTextBox";
            this.MinorRichTextBox.Size = new System.Drawing.Size(44, 24);
            this.MinorRichTextBox.TabIndex = 7;
            this.MinorRichTextBox.Text = "";
            this.MinorRichTextBox.TextChanged += new System.EventHandler(this.MinorRichTextBox_TextChanged);
            // 
            // SuffixRichTextBox
            // 
            this.SuffixRichTextBox.Location = new System.Drawing.Point(310, 35);
            this.SuffixRichTextBox.Multiline = false;
            this.SuffixRichTextBox.Name = "SuffixRichTextBox";
            this.SuffixRichTextBox.Size = new System.Drawing.Size(153, 24);
            this.SuffixRichTextBox.TabIndex = 8;
            this.SuffixRichTextBox.Text = "";
            this.SuffixRichTextBox.TextChanged += new System.EventHandler(this.SuffixTextBox_TextChanged);
            // 
            // PrefixRichTextBox
            // 
            this.PrefixRichTextBox.Location = new System.Drawing.Point(2, 35);
            this.PrefixRichTextBox.Multiline = false;
            this.PrefixRichTextBox.Name = "PrefixRichTextBox";
            this.PrefixRichTextBox.Size = new System.Drawing.Size(139, 24);
            this.PrefixRichTextBox.TabIndex = 5;
            this.PrefixRichTextBox.Text = "";
            this.PrefixRichTextBox.TextChanged += new System.EventHandler(this.PrefixRichTextBox_TextChanged);
            // 
            // MajorRichTextBox
            // 
            this.MajorRichTextBox.Location = new System.Drawing.Point(173, 35);
            this.MajorRichTextBox.Multiline = false;
            this.MajorRichTextBox.Name = "MajorRichTextBox";
            this.MajorRichTextBox.Size = new System.Drawing.Size(44, 24);
            this.MajorRichTextBox.TabIndex = 6;
            this.MajorRichTextBox.Text = "";
            this.MajorRichTextBox.TextChanged += new System.EventHandler(this.MajorRichTextBox_TextChanged);
            // 
            // SuffixLabel
            // 
            this.SuffixLabel.AutoSize = true;
            this.SuffixLabel.Location = new System.Drawing.Point(356, 15);
            this.SuffixLabel.Name = "SuffixLabel";
            this.SuffixLabel.Size = new System.Drawing.Size(46, 17);
            this.SuffixLabel.TabIndex = 3;
            this.SuffixLabel.Text = "Suffix:";
            // 
            // PrefixLabel
            // 
            this.PrefixLabel.AutoSize = true;
            this.PrefixLabel.Location = new System.Drawing.Point(48, 15);
            this.PrefixLabel.Name = "PrefixLabel";
            this.PrefixLabel.Size = new System.Drawing.Size(47, 17);
            this.PrefixLabel.TabIndex = 4;
            this.PrefixLabel.Text = "Prefix:";
            // 
            // MinorLabel
            // 
            this.MinorLabel.AutoSize = true;
            this.MinorLabel.Location = new System.Drawing.Point(238, 15);
            this.MinorLabel.Name = "MinorLabel";
            this.MinorLabel.Size = new System.Drawing.Size(47, 17);
            this.MinorLabel.TabIndex = 5;
            this.MinorLabel.Text = "Minor:";
            // 
            // MajorLabel
            // 
            this.MajorLabel.AutoSize = true;
            this.MajorLabel.Location = new System.Drawing.Point(170, 15);
            this.MajorLabel.Name = "MajorLabel";
            this.MajorLabel.Size = new System.Drawing.Size(47, 17);
            this.MajorLabel.TabIndex = 6;
            this.MajorLabel.Text = "Major:";
            // 
            // OutputGroupBox
            // 
            this.OutputGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputGroupBox.Controls.Add(this.OutputSelectBrowseButton);
            this.OutputGroupBox.Controls.Add(this.BackupPathTextBox);
            this.OutputGroupBox.Location = new System.Drawing.Point(6, 71);
            this.OutputGroupBox.Name = "OutputGroupBox";
            this.OutputGroupBox.Size = new System.Drawing.Size(783, 59);
            this.OutputGroupBox.TabIndex = 6;
            this.OutputGroupBox.TabStop = false;
            this.OutputGroupBox.Text = "Output Folder";
            // 
            // OutputSelectBrowseButton
            // 
            this.OutputSelectBrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputSelectBrowseButton.Location = new System.Drawing.Point(708, 15);
            this.OutputSelectBrowseButton.Name = "OutputSelectBrowseButton";
            this.OutputSelectBrowseButton.Size = new System.Drawing.Size(69, 29);
            this.OutputSelectBrowseButton.TabIndex = 4;
            this.OutputSelectBrowseButton.Text = "Browse";
            this.OutputSelectBrowseButton.UseVisualStyleBackColor = true;
            this.OutputSelectBrowseButton.Click += new System.EventHandler(this.OutputSelectBrowseButton_Click);
            // 
            // BackupPathTextBox
            // 
            this.BackupPathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BackupPathTextBox.Location = new System.Drawing.Point(6, 18);
            this.BackupPathTextBox.Name = "BackupPathTextBox";
            this.BackupPathTextBox.Size = new System.Drawing.Size(696, 22);
            this.BackupPathTextBox.TabIndex = 3;
            // 
            // SubGroupBox
            // 
            this.SubGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SubGroupBox.Controls.Add(this.SubSelectBrowseButton);
            this.SubGroupBox.Controls.Add(this.SubPathTextBox);
            this.SubGroupBox.Location = new System.Drawing.Point(6, 6);
            this.SubGroupBox.Name = "SubGroupBox";
            this.SubGroupBox.Size = new System.Drawing.Size(783, 59);
            this.SubGroupBox.TabIndex = 4;
            this.SubGroupBox.TabStop = false;
            this.SubGroupBox.Text = "Submarine Selection";
            // 
            // SubSelectBrowseButton
            // 
            this.SubSelectBrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SubSelectBrowseButton.Location = new System.Drawing.Point(708, 15);
            this.SubSelectBrowseButton.Name = "SubSelectBrowseButton";
            this.SubSelectBrowseButton.Size = new System.Drawing.Size(69, 29);
            this.SubSelectBrowseButton.TabIndex = 3;
            this.SubSelectBrowseButton.Text = "Browse";
            this.SubSelectBrowseButton.UseVisualStyleBackColor = true;
            this.SubSelectBrowseButton.Click += new System.EventHandler(this.SubSelectBrowseButton_Click);
            // 
            // SubPathTextBox
            // 
            this.SubPathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SubPathTextBox.Location = new System.Drawing.Point(6, 18);
            this.SubPathTextBox.Name = "SubPathTextBox";
            this.SubPathTextBox.Size = new System.Drawing.Size(696, 22);
            this.SubPathTextBox.TabIndex = 2;
            // 
            // RestorePage
            // 
            this.RestorePage.BackColor = System.Drawing.SystemColors.Control;
            this.RestorePage.Controls.Add(this.RemoveVersionCheckBox);
            this.RestorePage.Controls.Add(this.RestoreMsgLabel);
            this.RestorePage.Controls.Add(this.groupBox2);
            this.RestorePage.Controls.Add(this.RestoreSubNameLabel);
            this.RestorePage.Controls.Add(this.RestorePictureBox);
            this.RestorePage.Controls.Add(this.SubBackupList);
            this.RestorePage.Controls.Add(this.RestoreButton);
            this.RestorePage.Controls.Add(this.groupBox1);
            this.RestorePage.Location = new System.Drawing.Point(4, 25);
            this.RestorePage.Name = "RestorePage";
            this.RestorePage.Padding = new System.Windows.Forms.Padding(3);
            this.RestorePage.Size = new System.Drawing.Size(793, 432);
            this.RestorePage.TabIndex = 1;
            this.RestorePage.Text = "Restore";
            // 
            // RemoveVersionCheckBox
            // 
            this.RemoveVersionCheckBox.AutoSize = true;
            this.RemoveVersionCheckBox.Location = new System.Drawing.Point(602, 265);
            this.RemoveVersionCheckBox.Name = "RemoveVersionCheckBox";
            this.RemoveVersionCheckBox.Size = new System.Drawing.Size(132, 21);
            this.RemoveVersionCheckBox.TabIndex = 14;
            this.RemoveVersionCheckBox.Text = "Remove version";
            this.RemoveVersionCheckBox.UseVisualStyleBackColor = true;
            // 
            // RestoreMsgLabel
            // 
            this.RestoreMsgLabel.AutoSize = true;
            this.RestoreMsgLabel.Location = new System.Drawing.Point(6, 403);
            this.RestoreMsgLabel.Name = "RestoreMsgLabel";
            this.RestoreMsgLabel.Size = new System.Drawing.Size(0, 17);
            this.RestoreMsgLabel.TabIndex = 13;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.RestoreLocationBrowseButton);
            this.groupBox2.Controls.Add(this.RestorePathTextBox);
            this.groupBox2.Location = new System.Drawing.Point(6, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(783, 59);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Folder to Restore To";
            // 
            // RestoreLocationBrowseButton
            // 
            this.RestoreLocationBrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RestoreLocationBrowseButton.Location = new System.Drawing.Point(708, 15);
            this.RestoreLocationBrowseButton.Name = "RestoreLocationBrowseButton";
            this.RestoreLocationBrowseButton.Size = new System.Drawing.Size(69, 29);
            this.RestoreLocationBrowseButton.TabIndex = 5;
            this.RestoreLocationBrowseButton.Text = "Browse";
            this.RestoreLocationBrowseButton.UseVisualStyleBackColor = true;
            this.RestoreLocationBrowseButton.Click += new System.EventHandler(this.RestoreLocationBrowseButton_Click);
            // 
            // RestorePathTextBox
            // 
            this.RestorePathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RestorePathTextBox.Location = new System.Drawing.Point(6, 18);
            this.RestorePathTextBox.Name = "RestorePathTextBox";
            this.RestorePathTextBox.Size = new System.Drawing.Size(696, 22);
            this.RestorePathTextBox.TabIndex = 4;
            // 
            // RestoreSubNameLabel
            // 
            this.RestoreSubNameLabel.AutoSize = true;
            this.RestoreSubNameLabel.Location = new System.Drawing.Point(602, 188);
            this.RestoreSubNameLabel.Name = "RestoreSubNameLabel";
            this.RestoreSubNameLabel.Size = new System.Drawing.Size(0, 17);
            this.RestoreSubNameLabel.TabIndex = 12;
            // 
            // RestorePictureBox
            // 
            this.RestorePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RestorePictureBox.Location = new System.Drawing.Point(602, 136);
            this.RestorePictureBox.Name = "RestorePictureBox";
            this.RestorePictureBox.Size = new System.Drawing.Size(187, 123);
            this.RestorePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RestorePictureBox.TabIndex = 11;
            this.RestorePictureBox.TabStop = false;
            // 
            // SubBackupList
            // 
            this.SubBackupList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SubBackupList.FormattingEnabled = true;
            this.SubBackupList.ItemHeight = 16;
            this.SubBackupList.Location = new System.Drawing.Point(6, 135);
            this.SubBackupList.Name = "SubBackupList";
            this.SubBackupList.Size = new System.Drawing.Size(590, 260);
            this.SubBackupList.TabIndex = 6;
            this.SubBackupList.SelectedIndexChanged += new System.EventHandler(this.SubBackupList_SelectedIndexChanged);
            // 
            // RestoreButton
            // 
            this.RestoreButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RestoreButton.Location = new System.Drawing.Point(602, 396);
            this.RestoreButton.Name = "RestoreButton";
            this.RestoreButton.Size = new System.Drawing.Size(185, 30);
            this.RestoreButton.TabIndex = 7;
            this.RestoreButton.Text = "Restore";
            this.RestoreButton.UseVisualStyleBackColor = true;
            this.RestoreButton.Click += new System.EventHandler(this.RestoreButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.BackupLoadFolderBrowseButton);
            this.groupBox1.Controls.Add(this.BackupLoadPathTextBox);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(783, 59);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Backup Folder";
            // 
            // BackupLoadFolderBrowseButton
            // 
            this.BackupLoadFolderBrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BackupLoadFolderBrowseButton.Location = new System.Drawing.Point(708, 15);
            this.BackupLoadFolderBrowseButton.Name = "BackupLoadFolderBrowseButton";
            this.BackupLoadFolderBrowseButton.Size = new System.Drawing.Size(69, 29);
            this.BackupLoadFolderBrowseButton.TabIndex = 3;
            this.BackupLoadFolderBrowseButton.Text = "Browse";
            this.BackupLoadFolderBrowseButton.UseVisualStyleBackColor = true;
            this.BackupLoadFolderBrowseButton.Click += new System.EventHandler(this.BackupLoadFolderBrowseButton_Click);
            // 
            // BackupLoadPathTextBox
            // 
            this.BackupLoadPathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BackupLoadPathTextBox.Location = new System.Drawing.Point(6, 18);
            this.BackupLoadPathTextBox.Name = "BackupLoadPathTextBox";
            this.BackupLoadPathTextBox.Size = new System.Drawing.Size(696, 22);
            this.BackupLoadPathTextBox.TabIndex = 2;
            // 
            // BackupManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 459);
            this.Controls.Add(this.TabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "BackupManagerForm";
            this.Text = "Submarine Backup Manager";
            this.TabControl.ResumeLayout(false);
            this.BackupPage.ResumeLayout(false);
            this.BackupPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackupPictureBox)).EndInit();
            this.SettingsGroupBox.ResumeLayout(false);
            this.VersioningGroupBox.ResumeLayout(false);
            this.VersioningGroupBox.PerformLayout();
            this.OutputGroupBox.ResumeLayout(false);
            this.OutputGroupBox.PerformLayout();
            this.SubGroupBox.ResumeLayout(false);
            this.SubGroupBox.PerformLayout();
            this.RestorePage.ResumeLayout(false);
            this.RestorePage.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RestorePictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage BackupPage;
        private System.Windows.Forms.TabPage RestorePage;
        private System.Windows.Forms.Button BackupButton;
        private System.Windows.Forms.GroupBox SettingsGroupBox;
        private System.Windows.Forms.GroupBox VersioningGroupBox;
        private System.Windows.Forms.CheckBox SubNameCheckBox;
        private System.Windows.Forms.CheckBox AutoIncrementCheckBox;
        private System.Windows.Forms.RichTextBox MinorRichTextBox;
        private System.Windows.Forms.RichTextBox SuffixRichTextBox;
        private System.Windows.Forms.RichTextBox PrefixRichTextBox;
        private System.Windows.Forms.RichTextBox MajorRichTextBox;
        private System.Windows.Forms.Label SuffixLabel;
        private System.Windows.Forms.Label PrefixLabel;
        private System.Windows.Forms.Label MinorLabel;
        private System.Windows.Forms.Label MajorLabel;
        private System.Windows.Forms.GroupBox OutputGroupBox;
        private System.Windows.Forms.Button OutputSelectBrowseButton;
        private System.Windows.Forms.TextBox BackupPathTextBox;
        private System.Windows.Forms.GroupBox SubGroupBox;
        private System.Windows.Forms.Button SubSelectBrowseButton;
        private System.Windows.Forms.TextBox SubPathTextBox;
        private System.Windows.Forms.Label RestoreSubNameLabel;
        private System.Windows.Forms.PictureBox RestorePictureBox;
        private System.Windows.Forms.ListBox SubBackupList;
        private System.Windows.Forms.Button RestoreButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BackupLoadFolderBrowseButton;
        private System.Windows.Forms.TextBox BackupLoadPathTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox BackupPictureBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button RestoreLocationBrowseButton;
        private System.Windows.Forms.TextBox RestorePathTextBox;
        private System.Windows.Forms.Label BackupMsgLabel;
        private System.Windows.Forms.Label RestoreMsgLabel;
        private System.Windows.Forms.CheckBox RemoveVersionCheckBox;
    }
}

