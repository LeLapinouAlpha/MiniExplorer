using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniExplorer.Forms
{
    public partial class MainForm : Form
    {
        /*
         * **************************************************************************************
         * *                                 INSTANCE VARIABLES                                 *
         * **************************************************************************************
         */

        /*
         * **************************************************************************************
         * *                                  EVENTS HANDLER                                    *
         * **************************************************************************************
         */

        /*
         * **************************************************************************************
         * *                                    CONSTRUCTORS                                    *
         * **************************************************************************************
        */
        public MainForm()
        {
            InitializeComponent();
        }

        /*
         * **************************************************************************************
         * *                                      PROPERTIES                                    *
         * **************************************************************************************
        */

        /*
         * **************************************************************************************
         * *                                       METHODS                                      *
         * **************************************************************************************
        */
        private void SyncStatusBar()
        {
            this.statusBar.ElementCount = this.directoryContent.ElementCount;
            this.statusBar.SelectedElementCount = this.directoryContent.SelectedElementCount;
        }

        private void SyncTitle()
        {
            string filename = Path.GetFileName(this.directoryContent.DirPath);
            string path = filename == "" ? this.directoryContent.DirPath : filename;
                this.Text = $"MiniExplorer - {path}";
        }

        /*
         * **************************************************************************************
         * *                                       EVENTS                                       *
         * **************************************************************************************
         */
        private void directoryContent_FileSelectionChanged(object sender, EventArgs e)
        {
            SyncStatusBar();
        }

        private void directoryContent_DirectoryChanged(object sender, EventArgs e)
        {
            SyncStatusBar();
            SyncTitle();
        }

        private void directoryContent_Load(object sender, EventArgs e)
        {
            SyncStatusBar();
            SyncTitle();
        }

        private void directoryTree_SelectionChanged(object sender, EventArgs e)
        {
            var nodeEventArgs = (TreeViewCancelEventArgs)e;
            if (nodeEventArgs.Node != null)
            {
                var dirInfo = (DirectoryInfo)nodeEventArgs.Node.Tag;
                this.directoryContent.DirPath = dirInfo.FullName;
            }
        }
    }
}
