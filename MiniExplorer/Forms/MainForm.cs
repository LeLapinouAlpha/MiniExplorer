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
            this.statusBar.ElementCount = this.directoryContent.ElementCount - 1;
            this.statusBar.SelectedElementCount = this.directoryContent.SelectedElementCount;
        }

        /*
         * **************************************************************************************
         * *                                       EVENTS                                       *
         * **************************************************************************************
         */
        private void directoryContent_DirectoryChanged(object sender, EventArgs e)
        {
            SyncStatusBar();
        }

        private void directoryContent_Load(object sender, EventArgs e)
        {
            SyncStatusBar();
        }

        private void directoryContent_FileSelectionChanged(object sender, EventArgs e)
        {
            SyncStatusBar();
        }
    }
}
