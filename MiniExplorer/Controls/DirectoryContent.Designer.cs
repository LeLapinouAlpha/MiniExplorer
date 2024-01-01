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
            largeImageList = new ImageList(components);
            smallImageList = new ImageList(components);
            SuspendLayout();
            // 
            // view
            // 
            view.Columns.AddRange(new ColumnHeader[] { nameColumn, typeColumn, sizeColumn, updatedAtColumn });
            view.Dock = DockStyle.Fill;
            view.FullRowSelect = true;
            view.LargeImageList = largeImageList;
            view.Location = new Point(0, 0);
            view.Name = "view";
            view.Size = new Size(646, 208);
            view.SmallImageList = smallImageList;
            view.TabIndex = 0;
            view.UseCompatibleStateImageBehavior = false;
            view.View = View.Details;
            view.SelectedIndexChanged += view_SelectedIndexChanged;
            view.MouseDoubleClick += listView_MouseDoubleClick;
            // 
            // nameColumn
            // 
            nameColumn.Text = "Name";
            nameColumn.Width = 256;
            // 
            // typeColumn
            // 
            typeColumn.DisplayIndex = 2;
            typeColumn.Text = "Type";
            typeColumn.Width = 128;
            // 
            // sizeColumn
            // 
            sizeColumn.DisplayIndex = 1;
            sizeColumn.Text = "Size";
            sizeColumn.Width = 128;
            // 
            // updatedAtColumn
            // 
            updatedAtColumn.Text = "Updated At";
            updatedAtColumn.Width = 128;
            // 
            // largeImageList
            // 
            largeImageList.ColorDepth = ColorDepth.Depth32Bit;
            largeImageList.ImageStream = (ImageListStreamer)resources.GetObject("largeImageList.ImageStream");
            largeImageList.TransparentColor = Color.Transparent;
            largeImageList.Images.SetKeyName(0, "icons8-dossier-windows-11-color-310.png");
            largeImageList.Images.SetKeyName(1, "icons8-fichier-windows-11-color-310.png");
            // 
            // smallImageList
            // 
            smallImageList.ColorDepth = ColorDepth.Depth32Bit;
            smallImageList.ImageStream = (ImageListStreamer)resources.GetObject("smallImageList.ImageStream");
            smallImageList.TransparentColor = Color.Transparent;
            smallImageList.Images.SetKeyName(0, "icons8-dossier-windows-11-color-70.png");
            smallImageList.Images.SetKeyName(1, "icons8-fichier-windows-11-color-70.png");
            // 
            // DirectoryContent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(view);
            Name = "DirectoryContent";
            Size = new Size(646, 208);
            ResumeLayout(false);
        }

        #endregion

        private ListView view;
        private ColumnHeader nameColumn;
        private ImageList largeImageList;
        private ImageList smallImageList;
        private ColumnHeader sizeColumn;
        private ColumnHeader typeColumn;
        private ColumnHeader updatedAtColumn;
    }
}
