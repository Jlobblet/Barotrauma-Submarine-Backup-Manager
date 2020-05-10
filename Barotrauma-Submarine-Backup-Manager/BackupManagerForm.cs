﻿using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using NaturalSort.Extension;

namespace Barotrauma_Submarine_Backup_Manager
{
    public partial class BackupManagerForm : Form
    {
        // Version Number Variables
        private string prefix = "";
        private int? majorVersionNumber = null;
        private int? minorVersionNumber = null;
        private string suffix = "";
        public string Prefix { get => prefix; set => prefix = value; }
        public int? MajorVersionNumber { get => majorVersionNumber; set => majorVersionNumber = value; }
        public int? MinorVersionNumber { get => minorVersionNumber; set => minorVersionNumber = value; }
        public string Suffix { get => suffix; set => suffix = value; }

        // Filepaths
        private string subFilePath = "";
        private string backupFilePath = "";
        private string backupLoadFolderPath = "";
        private string backupLoadFilePath = "";
        private string restoreFilePath = "";
        public string SubFilePath { get => subFilePath; set => subFilePath = value; }
        public string BackupFilePath { get => backupFilePath; set => backupFilePath = value; }
        public string BackupLoadFolderPath { get => backupLoadFolderPath; set => backupLoadFolderPath = value; }
        public string BackupLoadFilePath { get => backupLoadFilePath; set => backupLoadFilePath = value; }
        public string RestoreFilePath { get => restoreFilePath; set => restoreFilePath = value; }

        public BackupManagerForm()
        {
            InitializeComponent();
        }

        private void MajorRichTextBox_TextChanged(object sender, EventArgs e)
        {
            bool empty = MajorRichTextBox.Text == string.Empty;
            if (!int.TryParse(MajorRichTextBox.Text, out int result) && !empty)
            {
                int returnpoint = MajorRichTextBox.SelectionStart - 1;
                MajorRichTextBox.Text = MajorVersionNumber.ToString();
                MajorRichTextBox.SelectionStart = returnpoint;
            }
            else
            {
                MajorVersionNumber = empty ? (int?)null : result;
            }
        }

        private void MinorRichTextBox_TextChanged(object sender, EventArgs e)
        {
            bool empty = MinorRichTextBox.Text == string.Empty;
            if (!int.TryParse(MinorRichTextBox.Text, out int result) && !empty)
            {
                int returnpoint = MinorRichTextBox.SelectionStart - 1;
                MinorRichTextBox.Text = MinorVersionNumber.ToString();
                MinorRichTextBox.SelectionStart = returnpoint;
            }
            else
            {
                MinorVersionNumber = empty ? (int?)null : result;
            }
        }

        private void PrefixRichTextBox_TextChanged(object sender, EventArgs e)
        {
            Prefix = PrefixRichTextBox.Text;
        }

        private void SuffixTextBox_TextChanged(object sender, EventArgs e)
        {
            Suffix = SuffixRichTextBox.Text;
        }

        private void SubSelectBrowseButton_Click(object sender, EventArgs e)
        {
            string result = FormUtils.ShowFileBrowserDialog(".sub");
            if (result != "")
            {
                SubFilePath = SubPathTextBox.Text = result;
                XDocument sub = SaveUtils.LoadSub(SubFilePath);
                if (sub.Root.Attribute("previewimage") != null)
                {
                    BackupPictureBox.Image = FormUtils.GetImageFromString(sub.Root.Attribute("previewimage").Value);
                }
                else
                {
                    BackupPictureBox.Image = null;
                }
            }
        }

        private void OutputSelectBrowseButton_Click(object sender, EventArgs e)
        {
            BackupFilePath = BackupPathTextBox.Text = FormUtils.ShowFolderBrowserDialog();
        }

        private void BackupButton_Click(object sender, EventArgs e)
        {
            if (BackupFilePath != "" && SubFilePath != "")
            {
                string version = FormUtils.CalculateVersion(Prefix, MajorVersionNumber, MinorVersionNumber, Suffix);
                string target = Path.Combine(BackupFilePath, Path.GetFileNameWithoutExtension(SubFilePath) + "_" + version + ".sub");
                SaveUtils.MakeBackup(SubNameCheckBox.Checked, SubFilePath, target);
                UpdateSubBackupListItems();
                SetFeedbackMsg("Backed up " + Path.GetFileName(SubFilePath) + " to " + Path.GetFileName(target) + ".");
                if (AutoIncrementCheckBox.Checked)
                {
                    MinorVersionNumber++;
                    MinorRichTextBox.Text = MinorVersionNumber.ToString();
                }
            }
        }

        private void UpdateSubBackupListItems()
        {
            if (BackupLoadFolderPath != "")
            {
                string[] newItems = Directory.EnumerateFiles(BackupLoadFolderPath, "*.sub", SearchOption.TopDirectoryOnly)
                    .Select(s => Path.GetFileName(s))
                    .OrderBy(s => s, StringComparer.OrdinalIgnoreCase.WithNaturalSort())
                    .ToArray();
                SubBackupList.Items.Clear();
                SubBackupList.Items.AddRange(newItems);
            }
        }

        private void BackupLoadFolderBrowseButton_Click(object sender, EventArgs e)
        {
            BackupLoadFolderPath = BackupLoadPathTextBox.Text = FormUtils.ShowFolderBrowserDialog();
            UpdateSubBackupListItems();
        }

        private void RestoreLocationBrowseButton_Click(object sender, EventArgs e)
        {
            RestoreFilePath = RestorePathTextBox.Text = FormUtils.ShowFolderBrowserDialog();
        }

        private void SubBackupList_SelectedIndexChanged(object sender, EventArgs e)
        {
            BackupLoadFilePath = Path.Combine(BackupLoadFolderPath, SubBackupList.SelectedItem.ToString());
            XDocument sub = SaveUtils.LoadSub(BackupLoadFilePath);
            if (sub.Root.Attribute("previewimage") != null)
            {
                RestorePictureBox.Image = FormUtils.GetImageFromString(sub.Root.Attribute("previewimage").Value);
            }
            else
            {
                RestorePictureBox.Image = null;
            }

        }

        private void RestoreButton_Click(object sender, EventArgs e)
        {
            if (BackupLoadFilePath != "")
            {
                File.Copy(BackupLoadFilePath, Path.Combine(RestoreFilePath, Path.GetFileName(BackupLoadFilePath)));
                SetFeedbackMsg("Restored sub " + Path.GetFileName(BackupLoadFilePath) + ".");
            }
        }

        private void SetFeedbackMsg(string s)
        {
            BackupMsgLabel.Text = RestoreMsgLabel.Text = s;
        }
    }
}
