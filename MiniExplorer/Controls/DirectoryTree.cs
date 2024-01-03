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
        private DirectoryInfo rootDirInfo;
        private bool showHiddenDirectories;

        /*
         * **************************************************************************************
         * *                                  EVENTS HANDLER                                    *
         * **************************************************************************************
         */
        public event EventHandler SelectionChanged;

        /*
         * **************************************************************************************
         * *                                    CONSTRUCTORS                                    *
         * **************************************************************************************
        */
        public DirectoryTree()
        {
            InitializeComponent();
            RootDirPath = Environment.GetLogicalDrives()[0];
            showHiddenDirectories = true;
        }

        /*
         * **************************************************************************************
         * *                                    PROPERTIES                                      *
         * **************************************************************************************
        */
        public string RootDirPath
        {
            get => rootDirInfo.Name;
            set
            {
                string path = string.IsNullOrEmpty(value) ? Environment.GetLogicalDrives()[0] : value;
                rootDirInfo = new DirectoryInfo(path);
                InitDirectoryTree();
            }
        }

        public bool ShowHiddenDirectories
        {
            get => showHiddenDirectories;
            set
            {
                showHiddenDirectories = value;
                InitDirectoryTree();
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

        private void InitDirectoryTree()
        {
            var root = InitDirectoryNode(rootDirInfo);
            this.view.Nodes.Clear();
            this.view.Nodes.Add(root);
        }

        private void BuildDirectoryTree(TreeNode node)
        {
            node.Nodes.Clear();
            try
            {
                var dirInfo = (DirectoryInfo)node.Tag;
                if (ShowHiddenDirectories)
                    foreach (var info in dirInfo.GetDirectories())
                        node.Nodes.Add(InitDirectoryNode(info));
                else
                    foreach (var info in dirInfo.GetDirectories())
                        if (info.Name[0] != '.')
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

        private void view_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            SelectionChanged?.Invoke(sender, e);
        }
    }
}
