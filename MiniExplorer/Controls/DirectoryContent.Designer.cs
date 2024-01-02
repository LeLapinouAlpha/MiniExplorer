namespace MiniExplorer.Controls
{
    partial class DirectoryContent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DirectoryContent));
            view = new ListView();
            nameColumn = new ColumnHeader();
            typeColumn = new ColumnHeader();
            sizeColumn = new ColumnHeader();
            updatedAtColumn = new ColumnHeader();
            largeIcons = new ImageList(components);
            smallIcons = new ImageList(components);
            SuspendLayout();
            // 
            // view
            // 
            view.Columns.AddRange(new ColumnHeader[] { nameColumn, typeColumn, sizeColumn, updatedAtColumn });
            view.Dock = DockStyle.Fill;
            view.FullRowSelect = true;
            view.LargeImageList = largeIcons;
            view.Location = new Point(0, 0);
            view.Name = "view";
            view.Size = new Size(831, 208);
            view.SmallImageList = smallIcons;
            view.StateImageList = smallIcons;
            view.TabIndex = 0;
            view.UseCompatibleStateImageBehavior = false;
            view.View = View.Details;
            view.SelectedIndexChanged += view_SelectedIndexChanged;
            view.KeyDown += view_KeyDown;
            view.MouseDoubleClick += view_MouseDoubleClick;
            // 
            // nameColumn
            // 
            nameColumn.Text = "Nom";
            nameColumn.Width = 256;
            // 
            // typeColumn
            // 
            typeColumn.Text = "Type";
            typeColumn.Width = 256;
            // 
            // sizeColumn
            // 
            sizeColumn.Text = "Taille";
            sizeColumn.Width = 128;
            // 
            // updatedAtColumn
            // 
            updatedAtColumn.Text = "Modifié le";
            updatedAtColumn.Width = 128;
            // 
            // largeIcons
            // 
            largeIcons.ColorDepth = ColorDepth.Depth32Bit;
            largeIcons.ImageStream = (ImageListStreamer)resources.GetObject("largeIcons.ImageStream");
            largeIcons.TransparentColor = Color.Transparent;
            largeIcons.Images.SetKeyName(0, "icons8-dossier-480.png");
            largeIcons.Images.SetKeyName(1, "icons8-fichier-480.png");
            largeIcons.Images.SetKeyName(2, "icons8-document-480.png");
            largeIcons.Images.SetKeyName(3, "icons8-adobe-acrobat-480.png");
            largeIcons.Images.SetKeyName(4, "icons8-microsoft-word-2019-480.png");
            largeIcons.Images.SetKeyName(5, "icons8-microsoft-excel-2019-480.png");
            largeIcons.Images.SetKeyName(6, "icons8-microsoft-powerpoint-2019-480.png");
            // 
            // smallIcons
            // 
            smallIcons.ColorDepth = ColorDepth.Depth32Bit;
            smallIcons.ImageStream = (ImageListStreamer)resources.GetObject("smallIcons.ImageStream");
            smallIcons.TransparentColor = Color.Transparent;
            smallIcons.Images.SetKeyName(0, "icons8-dossier-480.png");
            smallIcons.Images.SetKeyName(1, "icons8-fichier-480.png");
            smallIcons.Images.SetKeyName(2, "icons8-document-480.png");
            smallIcons.Images.SetKeyName(3, "icons8-adobe-acrobat-480.png");
            smallIcons.Images.SetKeyName(4, "icons8-microsoft-word-2019-480.png");
            smallIcons.Images.SetKeyName(5, "icons8-microsoft-excel-2019-480.png");
            smallIcons.Images.SetKeyName(6, "icons8-microsoft-powerpoint-2019-480.png");
            // 
            // DirectoryContent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(view);
            Name = "DirectoryContent";
            Size = new Size(831, 208);
            ResumeLayout(false);
        }

        #endregion

        private ListView view;
        private ColumnHeader nameColumn;
        private ImageList smallIcons;
        private ColumnHeader sizeColumn;
        private ColumnHeader typeColumn;
        private ColumnHeader updatedAtColumn;
        private ImageList largeIcons;
    }
}
