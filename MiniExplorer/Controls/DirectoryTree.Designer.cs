namespace MiniExplorer.Controls
{
    partial class DirectoryTree
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DirectoryTree));
            view = new TreeView();
            folderIcons = new ImageList(components);
            SuspendLayout();
            // 
            // view
            // 
            view.Dock = DockStyle.Fill;
            view.FullRowSelect = true;
            view.ImageIndex = 0;
            view.ImageList = folderIcons;
            view.Location = new Point(0, 0);
            view.Name = "view";
            view.SelectedImageIndex = 0;
            view.Size = new Size(243, 350);
            view.TabIndex = 0;
            view.BeforeExpand += view_BeforeExpand;
            view.BeforeSelect += view_BeforeSelect;
            // 
            // folderIcons
            // 
            folderIcons.ColorDepth = ColorDepth.Depth32Bit;
            folderIcons.ImageStream = (ImageListStreamer)resources.GetObject("folderIcons.ImageStream");
            folderIcons.TransparentColor = Color.Transparent;
            folderIcons.Images.SetKeyName(0, "dossier.png");
            // 
            // DirectoryTree
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(view);
            Name = "DirectoryTree";
            Size = new Size(243, 350);
            ResumeLayout(false);
        }

        #endregion

        private TreeView view;
        private ImageList folderIcons;
    }
}
