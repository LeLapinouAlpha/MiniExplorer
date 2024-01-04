using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniExplorer.Controls
{
    public partial class DirectoryContent : UserControl
    {
        /*
         * **************************************************************************************
         * *                                 INSTANCE VARIABLES                                 *
         * **************************************************************************************
         */
        private DirectoryInfo dirInfo;
        private bool showHiddenFiles;


        /*
         * **************************************************************************************
         * *                                  EVENTS HANDLER                                    *
         * **************************************************************************************
         */
        public event EventHandler DirectoryChanged;
        public event EventHandler SelectionChanged;

        /*
         * **************************************************************************************
         * *                                    CONSTRUCTORS                                    *
         * **************************************************************************************
        */
        public DirectoryContent()
        {
            InitializeComponent();
            DirPath = @"C:\";
            ShowHiddenFiles = true;
        }

        /*
         * **************************************************************************************
         * *                                    PROPERTIES                                      *
         * **************************************************************************************
        */
        public string DirPath
        {
            get => dirInfo.FullName;
            set
            {
                string path = value == null || value.Length == 0 ? Environment.GetLogicalDrives()[0] : value;
                dirInfo = new DirectoryInfo(path);
                Display();
                DirectoryChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        public int ElementCount { get => this.view.Items.Count; }

        public int SelectedElementCount { get => this.view.SelectedItems.Count; }

        public View View { get => this.view.View; set => this.view.View = value; }

        public bool ShowHiddenFiles
        {
            get => showHiddenFiles;
            set
            {
                showHiddenFiles = value;
                Display();
            }
        }

        /*
         * **************************************************************************************
         * *                                       METHODS                                      *
         * **************************************************************************************
        */
        public void AddRow(string name, int imageIndex, params string[] columns)
        {
            var item = new ListViewItem(name, imageIndex);
            foreach (string column in columns)
                item.SubItems.Add(column);
            this.view.Items.Add(item);
        }

        public void Display()
        {
            this.view.Items.Clear();
            this.view.Items.Add(new ListViewItem("..", 0));

            try
            {
                if (!ShowHiddenFiles)
                {
                    foreach (var info in dirInfo.GetDirectories())
                        if (info.Name[0] != '.')
                            AddRow(info.Name, 0, "Dossier", "-", info.LastWriteTime.ToString());

                    foreach (var info in dirInfo.GetFiles())
                        if (info.Name[0] != '.')
                            AddRow(info.Name, Utils.File.GetImageIndex(info.Extension), Utils.File.GetFileType(info.Extension), Utils.File.SizeToString(info.Length), info.LastWriteTime.ToString());
                }
                else
                {
                    foreach (var info in dirInfo.GetDirectories())
                        AddRow(info.Name, 0, "Dossier", "-", info.LastWriteTime.ToString());

                    foreach (var info in dirInfo.GetFiles())
                        AddRow(info.Name, Utils.File.GetImageIndex(info.Extension), Utils.File.GetFileType(info.Extension), Utils.File.SizeToString(info.Length), info.LastWriteTime.ToString());
                }

            }
            catch (UnauthorizedAccessException uaEx)
            {
                MessageBox.Show(uaEx.Message, "Accès non autorisé", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception non gérée", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public void SelectAll()
        {
            foreach (ListViewItem item in this.view.Items)
                item.Selected = true;
        }

        public void ReverseSelection()
        {
            foreach (ListViewItem item in this.view.Items)
                item.Selected = !item.Selected;
        }

        public void CreateFile(string name)
        {
            var newFileInfo = new FileInfo(Path.Join(this.DirPath, name));
            try
            {
                using (newFileInfo.Create())
                    Display();
            }
            catch (IOException ioEx)
            {
                MessageBox.Show(
                    ioEx.Message,
                    $"Erreur de création du fichier '{name}'",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        public void CreateDirectory(string name)
        {
            var newDirInfo = new DirectoryInfo(Path.Join(this.DirPath, name));
            try
            {
                newDirInfo.Create();
                Display();
            }
            catch (IOException ioEx)
            {
                MessageBox.Show(
                    ioEx.Message,
                    $"Erreur de création du dossier '{name}'",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        public void RemoveSelectedElements()
        {
            if (this.view.SelectedItems.Count == 0)
                return;

            var dialogResult = MessageBox.Show(
                "Êtes-vous sûr de vouloir supprimer les éléments sélectionnés ?",
                "Confirmer la suppression",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                foreach (ListViewItem item in this.view.SelectedItems)
                {
                    if (item.Text == "..")
                        continue;

                    var path = Path.Combine(DirPath, item.Text);
                    try
                    {
                        if (Directory.Exists(path))
                            Directory.Delete(path, true);
                        else if (File.Exists(path))
                            File.Delete(path);
                    }
                    catch (UnauthorizedAccessException uaEx)
                    {
                        MessageBox.Show(
                            uaEx.Message,
                            "Accès non autorisé",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    catch (IOException ioEx)
                    {
                        MessageBox.Show(
                            ioEx.Message,
                            "Erreur lors de la suppression",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                Display();
            }
        }

        public void CopySelectedElements()
        {
            var copiedPaths = new StringCollection();
            foreach (ListViewItem item in this.view.SelectedItems)
                copiedPaths.Add(Path.Combine(DirPath, item.Text));
            Clipboard.SetFileDropList(copiedPaths);
        }

        public void PasteElements()
        {
            foreach (string? sourcePath in Clipboard.GetFileDropList())
            {
                if (sourcePath == null)
                    continue;

                try
                {
                    string fileName = Path.GetFileName(sourcePath);
                    string destPath = Path.Combine(DirPath, fileName);

                    if (sourcePath == destPath)
                        MessageBox.Show(
                            "Les chemins de départs et d'arrivés sont identiques.",
                            "Erreur lors de la copie",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    else if (File.Exists(sourcePath))
                        File.Copy(sourcePath, destPath, false);
                    else if (Directory.Exists(sourcePath))
                        CopyDirectory(sourcePath, destPath);
                    else
                        MessageBox.Show(
                            $"Impossible de coller l'élément '{sourcePath}'.",
                            "Erreur lors de la copie",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur lors de la copie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            Display();
        }

        private void CopyDirectory(string sourceDir, string destinationDir)
        {
            var sourceDirInfo = new DirectoryInfo(sourceDir);

            if (!sourceDirInfo.Exists)
                throw new DirectoryNotFoundException($"Le dossier source n'existe pas: {sourceDir}");

            Directory.CreateDirectory(destinationDir);
            foreach (var fileInfo in sourceDirInfo.GetFiles())
                fileInfo.CopyTo(Path.Combine(destinationDir, fileInfo.Name), false);
            foreach (var dirInfo in sourceDirInfo.GetDirectories())
                CopyDirectory(dirInfo.FullName, Path.Combine(destinationDir, dirInfo.Name));
        }

        /*
         * **************************************************************************************
         * *                                       EVENTS                                       *
         * **************************************************************************************
         */
        private void view_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.view.SelectedItems.Count > 0)
            {
                var selectedFile = this.view.SelectedItems[0];
                var path = Path.Join(DirPath, selectedFile.Text);
                if (Directory.Exists(path))
                    DirPath = path;
                else if (File.Exists(path))
                    throw new NotImplementedException();
            }
        }

        private void view_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectionChanged?.Invoke(sender, e);
        }
    }
}
