using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        private string dirPath;
        private DirectoryInfo dirInfo;


        /*
         * **************************************************************************************
         * *                                  EVENTS HANDLER                                    *
         * **************************************************************************************
         */
        public event EventHandler DirectoryChanged;
        public event EventHandler FileSelectionChanged;

        /*
         * **************************************************************************************
         * *                                    CONSTRUCTORS                                    *
         * **************************************************************************************
        */
        public DirectoryContent()
        {
            InitializeComponent();
        }

        /*
         * **************************************************************************************
         * *                                    PROPERTIES                                      *
         * **************************************************************************************
        */
        public string DirPath
        {
            get => dirPath;
            set
            {
                string path = value == null || value.Length == 0 ? Environment.GetLogicalDrives()[0] : value;
                dirPath = path;
                dirInfo = new DirectoryInfo(path);
                Display();
                DirectoryChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        public int ElementCount { get => this.view.Items.Count; }
        public int SelectedElementCount { get => this.view.SelectedItems.Count; }


        /*
         * **************************************************************************************
         * *                                       METHODS                                      *
         * **************************************************************************************
        */
        private void AddRow(string name, int imageIndex, params string[] columns)
        {
            var item = new ListViewItem(name, imageIndex);
            foreach (string column in columns)
                item.SubItems.Add(column);
            this.view.Items.Add(item);
        }

        private void Display()
        {
            this.view.Items.Clear();
            this.view.Items.Add(new ListViewItem("..", 0));

            try
            {
                foreach (var info in dirInfo.GetDirectories())
                    AddRow(info.Name, 0, "-", "Directory", info.LastWriteTime.ToString());

                foreach (var info in dirInfo.GetFiles())
                    AddRow(info.Name, 1, Utils.File.FileSizeToString(info.Length), Utils.File.GetFileType(info.Extension), info.LastWriteTime.ToString());
            }
            catch (UnauthorizedAccessException uaEx)
            {
                MessageBox.Show(uaEx.Message, "Unauthorized access", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IOException ioEx)
            {
                MessageBox.Show(ioEx.Message, "IO exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Unhandled exception", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        /*
         * **************************************************************************************
         * *                                       EVENTS                                       *
         * **************************************************************************************
         */
        private void listView_MouseDoubleClick(object sender, MouseEventArgs e)
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
            FileSelectionChanged?.Invoke(sender, e);
        }
    }
}
