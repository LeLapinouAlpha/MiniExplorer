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
        private void Display()
        {
            view.Items.Clear();
            view.Items.Add(new ListViewItem("..", 0));

            try
            {
                foreach (var info in dirInfo.GetDirectories())
                {
                    var item = new ListViewItem(info.Name, 0);
                    item.SubItems.Add("Directory"); // Type
                    item.SubItems.Add("-"); // Size
                    view.Items.Add(item);
                }

                foreach (var info in dirInfo.GetFiles())
                {
                    var item = new ListViewItem(info.Name, 1);
                    item.SubItems.Add(Utils.File.GetFileType(info.Extension)); // Type
                    item.SubItems.Add(Utils.File.FileSizeToString(info.Length)); // Size
                    view.Items.Add(item);
                }
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
                    MessageBox.Show("Open file is not handle yet.", "Not implemented", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
