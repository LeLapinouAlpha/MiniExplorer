namespace MiniExplorer.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            statusBar = new Controls.StatusBar();
            menuBar = new Controls.MenuBar();
            directoryContent = new Controls.DirectoryContent();
            directoryTree = new Controls.DirectoryTree();
            splitContainer = new SplitContainer();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            SuspendLayout();
            // 
            // statusBar
            // 
            statusBar.Dock = DockStyle.Bottom;
            statusBar.ElementCount = 0;
            statusBar.Location = new Point(0, 462);
            statusBar.Name = "statusBar";
            statusBar.SelectedElementCount = 0;
            statusBar.Size = new Size(883, 31);
            statusBar.TabIndex = 1;
            // 
            // menuBar
            // 
            menuBar.DirectoryContent = directoryContent;
            menuBar.DirectoryTree = directoryTree;
            menuBar.Dock = DockStyle.Top;
            menuBar.Location = new Point(0, 0);
            menuBar.Name = "menuBar";
            menuBar.Size = new Size(883, 28);
            menuBar.TabIndex = 2;
            // 
            // directoryContent
            // 
            directoryContent.DirPath = "C:\\";
            directoryContent.Dock = DockStyle.Fill;
            directoryContent.Location = new Point(0, 0);
            directoryContent.Name = "directoryContent";
            directoryContent.Size = new Size(670, 434);
            directoryContent.TabIndex = 0;
            directoryContent.View = View.Details;
            directoryContent.DirectoryChanged += directoryContent_DirectoryChanged;
            directoryContent.SelectionChanged += directoryContent_FileSelectionChanged;
            directoryContent.Load += directoryContent_Load;
            // 
            // directoryTree
            // 
            directoryTree.Dock = DockStyle.Fill;
            directoryTree.Location = new Point(0, 0);
            directoryTree.Name = "directoryTree";
            directoryTree.RootDirPath = "C:\\";
            directoryTree.Size = new Size(209, 434);
            directoryTree.TabIndex = 0;
            directoryTree.SelectionChanged += directoryTree_SelectionChanged;
            // 
            // splitContainer
            // 
            splitContainer.Dock = DockStyle.Fill;
            splitContainer.Location = new Point(0, 28);
            splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            splitContainer.Panel1.Controls.Add(directoryTree);
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.Controls.Add(directoryContent);
            splitContainer.Size = new Size(883, 434);
            splitContainer.SplitterDistance = 209;
            splitContainer.TabIndex = 3;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(883, 493);
            Controls.Add(splitContainer);
            Controls.Add(menuBar);
            Controls.Add(statusBar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "MiniExplorer";
            splitContainer.Panel1.ResumeLayout(false);
            splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Controls.StatusBar statusBar;
        private Controls.MenuBar menuBar;
        private SplitContainer splitContainer;
        private Controls.DirectoryTree directoryTree;
        private Controls.DirectoryContent directoryContent;
    }
}