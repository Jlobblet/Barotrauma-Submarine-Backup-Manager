using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace Barotrauma_Submarine_Backup_Manager
{
    class FormUtils
    {
        public static string ShowFolderBrowserDialog()
        {
            using (CommonOpenFileDialog dialog = new CommonOpenFileDialog
            {
                IsFolderPicker = true,
                EnsureFileExists = true,
                EnsurePathExists = true,
            })
            {
                return dialog.ShowDialog() == CommonFileDialogResult.Ok ? dialog.FileName : "";
            }
        }

        public static string ShowFileBrowserDialog(string extension = "")
        {
            using (CommonOpenFileDialog dialog = new CommonOpenFileDialog
            {
                EnsureFileExists = true,
                EnsurePathExists = true,
            })
            {
                dialog.FileOk += (sender, parameter) =>
                {
                    CommonOpenFileDialog Dialog = (CommonOpenFileDialog)sender;
                    var filenames = new Collection<string>();
                    typeof(CommonOpenFileDialog)
                        .GetMethod("PopulateWithFileNames", BindingFlags.Instance | BindingFlags.NonPublic)
                        .Invoke(dialog, new[] { filenames });
                    string filename = filenames[0];
                    if (Path.GetExtension(filename) != extension && extension != "")
                    {
                        parameter.Cancel = true;
                        MessageBox.Show("The selected file does not have the extension " + extension + ".", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                };
                return dialog.ShowDialog() == CommonFileDialogResult.Ok ? dialog.FileName : "";
            }
        }

        public static Image GetImageFromString(string s)
        {
            byte[] bytes = Convert.FromBase64String(s);
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                return Image.FromStream(ms);
            }
        }
        public static string CalculateVersion(string prefix, int? major, int? minor, string suffix)
        {
            string version = "";
            version += prefix;
            if (prefix != "" && (major != null || minor != null || suffix != "")) { version += "-"; }
            if (major != null) { version += "v" + major; }
            if (minor != null) { version += "." + minor; }
            if (suffix != "" && (major != null || minor != null)) { version += "-"; }
            version += suffix;
            return version;
        }

    }
}
