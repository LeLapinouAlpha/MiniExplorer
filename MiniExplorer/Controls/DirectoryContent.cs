using Microsoft.VisualBasic.FileIO;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MiniExplorer.Controls
{
    public partial class DirectoryContent : UserControl
    {
        /*
         * **************************************************************************************
         * *                                  NESTED CLASSES                                    *
         * **************************************************************************************
        */
        private enum FileOperation
        {
            Copy,
            Cut
        }

        private class ClipboardData
        {
            public StringCollection Paths { get; set; }
            public FileOperation Operation { get; set; }
        }

        /*
         * **************************************************************************************
         * *                                 INSTANCE VARIABLES                                 *
         * **************************************************************************************
         */
        private DirectoryInfo dirInfo;
        private bool showHiddenFiles;
        private ClipboardData clipboardData = new ClipboardData();


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
                string path = string.IsNullOrEmpty(value) ? Environment.GetLogicalDrives()[0] : value;
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
                            AddRow(info.Name, 0, "Dossier", "-", info.LastWriteTime.ToString(), info.CreationTime.ToString());

                    foreach (var info in dirInfo.GetFiles())
                        if (info.Name[0] != '.')
                            AddRow(info.Name, Utils.File.GetImageIndex(info.Extension), Utils.File.GetFileType(info.Extension), Utils.File.SizeToString(info.Length), info.LastWriteTime.ToString(), info.CreationTime.ToString());
                }
                else
                {
                    foreach (var info in dirInfo.GetDirectories())
                        AddRow(info.Name, 0, "Dossier", "-", info.LastWriteTime.ToString(), info.LastWriteTime.ToString());

                    foreach (var info in dirInfo.GetFiles())
                        AddRow(info.Name, Utils.File.GetImageIndex(info.Extension), Utils.File.GetFileType(info.Extension), Utils.File.SizeToString(info.Length), info.LastWriteTime.ToString(), info.CreationTime.ToString());
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

        public void PutElementInRecycleBin()
        {
            if (this.view.SelectedItems.Count == 0)
                return;

            var dialogResult = MessageBox.Show(
                "Êtes-vous sûr de vouloir déplacer les éléments sélectionnés dans la corbeille ?",
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
                        {
                            FileSystem.DeleteDirectory(
                                path,
                                UIOption.OnlyErrorDialogs,
                                RecycleOption.SendToRecycleBin);
                        }
                        else if (File.Exists(path))
                        {
                            FileSystem.DeleteFile(
                                path,
                                UIOption.OnlyErrorDialogs,
                                RecycleOption.SendToRecycleBin);
                        }
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
                            "Erreur lors du déplacement dans la corbeille",
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

        public void CutSelectedElements()
        {
            clipboardData.Paths = new StringCollection();
            foreach (ListViewItem item in this.view.SelectedItems)
                clipboardData.Paths.Add(Path.Combine(DirPath, item.Text));
            clipboardData.Operation = FileOperation.Cut;
        }

        public void PasteClipboardElements()
        {
            if (clipboardData.Paths == null || clipboardData.Paths.Count == 0)
                return;

            foreach (string? sourcePath in clipboardData.Paths)
            {
                string? fileName = Path.GetFileName(sourcePath);
                if (fileName == null)
                    continue;

                string destPath = Path.Combine(DirPath, fileName);
                try
                {
                    if (File.Exists(sourcePath) || Directory.Exists(sourcePath))
                    {
                        if (clipboardData.Operation == FileOperation.Cut)
                            FileSystem.MoveFile(sourcePath, destPath, UIOption.AllDialogs);
                        else
                        {
                            if (File.Exists(sourcePath))
                                File.Copy(sourcePath, destPath, true);
                            else if (Directory.Exists(sourcePath))
                                CopyDirectory(sourcePath, destPath);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur lors du collage", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (clipboardData.Operation == FileOperation.Cut)
                clipboardData.Paths.Clear();

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

        public void RenameFirstSelectedElement(string newName)
        {
            if (this.view.SelectedItems.Count > 0)
            {
                var selectedItem = this.view.SelectedItems[0];
                    if (newName == selectedItem.Text)
                        return;

                    string path = Path.Combine(DirPath, selectedItem.Text);
                    try
                    {
                        if (File.Exists(path))
                            FileSystem.RenameFile(path, newName);
                        else if (Directory.Exists(path))
                            FileSystem.RenameDirectory(path, newName);
                        else
                            MessageBox.Show(
                                $"L'élément '{selectedItem.Text}' n'existe pas.",
                                "Erreur lors du renommage de l'élément",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(
                            ex.Message,
                            "Erreur lors du renommage de l'élément",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                            );
                    }
                }
                Display();
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

        private void view_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            switch (this.view.Sorting)
            {
                case SortOrder.None:
                    this.view.Sorting = SortOrder.Ascending;
                    break;
                case SortOrder.Ascending:
                    this.view.Sorting = SortOrder.Descending;
                    break;
                case SortOrder.Descending:
                    this.view.Sorting = SortOrder.Ascending;
                    break;
            }

            this.view.ListViewItemSorter = new Utils.ListViewItemComparer(e.Column, this.view.Sorting);
            this.view.Sort();
        }
    }
}
