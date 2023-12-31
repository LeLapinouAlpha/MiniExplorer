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
            directoryContent = new Controls.DirectoryContent();
            statusBar = new Controls.StatusBar();
            SuspendLayout();
            // 
            // directoryContent
            // 
            directoryContent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            directoryContent.DirPath = "C:\\";
            directoryContent.Location = new Point(0, 0);
            directoryContent.Name = "directoryContent";
            directoryContent.Size = new Size(800, 421);
            directoryContent.TabIndex = 0;
            directoryContent.DirectoryChanged += directoryContent_DirectoryChanged;
            directoryContent.Load += directoryContent_Load;
            // 
            // statusBar
            // 
            statusBar.Dock = DockStyle.Bottom;
            statusBar.ElementCount = 0;
            statusBar.Location = new Point(0, 419);
            statusBar.Name = "statusBar";
            statusBar.Size = new Size(800, 31);
            statusBar.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusBar);
            Controls.Add(directoryContent);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "MiniExplorer";
            ResumeLayout(false);
        }

        #endregion

        private Controls.DirectoryContent directoryContent;
        private Controls.StatusBar statusBar;
    }
}