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
    public partial class DirectoryTree : UserControl
    {
        /*
         * **************************************************************************************
         * *                                 INSTANCE VARIABLES                                 *
         * **************************************************************************************
         */
        private string rootDirPath;
        private DirectoryInfo rootDirInfo;

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
        public DirectoryTree()
        {
            InitializeComponent();
            rootDirPath = Environment.GetLogicalDrives()[0];
            rootDirInfo = new DirectoryInfo(rootDirPath);
        }

        /*
         * **************************************************************************************
         * *                                    PROPERTIES                                      *
         * **************************************************************************************
        */
        public string RootDirPath
        {
            get => rootDirPath;
            set
            {
                string path = value == "" ? Environment.GetLogicalDrives()[0] : value;
                rootDirPath = path;
                rootDirInfo = new DirectoryInfo(path);
                var root = InitDirectoryNode(rootDirInfo);
                this.view.Nodes.Clear();
                this.view.Nodes.Add(root);
            }
        }


        /*
         * **************************************************************************************
         * *                                       METHODS                                      *
         * **************************************************************************************
        */
        private TreeNode InitDirectoryNode(DirectoryInfo dirInfo)
        {
            var node = new TreeNode(dirInfo.Name) { ImageIndex = 0, Tag = dirInfo };
            node.Nodes.Add("...");
            return node;
        }

        private void BuildDirectoryTree(TreeNode node)
        {
            node.Nodes.Clear();
            try
            {
                var dirInfo = (DirectoryInfo)node.Tag;
                foreach (var info in dirInfo.GetDirectories())
                    node.Nodes.Add(InitDirectoryNode(info));
            }
            catch (Exception)
            {

            }
        }

        /*
         * **************************************************************************************
         * *                                       EVENTS                                       *
         * **************************************************************************************
         */
        private void view_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node != null)
                BuildDirectoryTree(e.Node);
        }
    }
}
