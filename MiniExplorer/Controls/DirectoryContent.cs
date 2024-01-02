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
        private DirectoryInfo dirInfo;


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

        private void Display()
        {
            this.view.Items.Clear();
            this.view.Items.Add(new ListViewItem("..", 0));

            try
            {
                foreach (var info in dirInfo.GetDirectories())
                    AddRow(info.Name, 0, "Dossier", "-", info.LastWriteTime.ToString());

                foreach (var info in dirInfo.GetFiles())
                    AddRow(info.Name, Utils.File.GetImageIndex(info.Extension), Utils.File.GetFileType(info.Extension), Utils.File.SizeToString(info.Length), info.LastWriteTime.ToString());
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

        private void view_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
                SelectAll();
        }
    }
}
