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
            createdAtColumn = new ColumnHeader();
            SuspendLayout();
            // 
            // view
            // 
            view.Columns.AddRange(new ColumnHeader[] { nameColumn, typeColumn, sizeColumn, updatedAtColumn, createdAtColumn });
            view.Dock = DockStyle.Fill;
            view.FullRowSelect = true;
            view.LargeImageList = largeIcons;
            view.Location = new Point(0, 0);
            view.Name = "view";
            view.Size = new Size(1002, 208);
            view.SmallImageList = smallIcons;
            view.StateImageList = smallIcons;
            view.TabIndex = 0;
            view.UseCompatibleStateImageBehavior = false;
            view.View = View.Details;
            view.SelectedIndexChanged += view_SelectedIndexChanged;
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
            largeIcons.Images.SetKeyName(0, "dossier.png");
            largeIcons.Images.SetKeyName(1, "fichier.png");
            largeIcons.Images.SetKeyName(2, "fichier-3ds.png");
            largeIcons.Images.SetKeyName(3, "fichier-aac.png");
            largeIcons.Images.SetKeyName(4, "fichier-ai.png");
            largeIcons.Images.SetKeyName(5, "fichier-avi.png");
            largeIcons.Images.SetKeyName(6, "fichier-bin.png");
            largeIcons.Images.SetKeyName(7, "fichier-bmp.png");
            largeIcons.Images.SetKeyName(8, "fichier-brut.png");
            largeIcons.Images.SetKeyName(9, "fichier-css.png");
            largeIcons.Images.SetKeyName(10, "fichier-csv.png");
            largeIcons.Images.SetKeyName(11, "fichier-dat.png");
            largeIcons.Images.SetKeyName(12, "fichier-dll.png");
            largeIcons.Images.SetKeyName(13, "fichier-dmg.png");
            largeIcons.Images.SetKeyName(14, "fichier-doc.png");
            largeIcons.Images.SetKeyName(15, "fichier-eps.png");
            largeIcons.Images.SetKeyName(16, "fichier-exe.png");
            largeIcons.Images.SetKeyName(17, "fichier-flv.png");
            largeIcons.Images.SetKeyName(18, "fichier-gif.png");
            largeIcons.Images.SetKeyName(19, "fichier-html.png");
            largeIcons.Images.SetKeyName(20, "fichier-ini.png");
            largeIcons.Images.SetKeyName(21, "fichier-iso.png");
            largeIcons.Images.SetKeyName(22, "fichier-jar.png");
            largeIcons.Images.SetKeyName(23, "fichier-java.png");
            largeIcons.Images.SetKeyName(24, "fichier-jpg.png");
            largeIcons.Images.SetKeyName(25, "fichier-js.png");
            largeIcons.Images.SetKeyName(26, "fichier-midi.png");
            largeIcons.Images.SetKeyName(27, "fichier-mkv.png");
            largeIcons.Images.SetKeyName(28, "fichier-mov.png");
            largeIcons.Images.SetKeyName(29, "fichier-mp3.png");
            largeIcons.Images.SetKeyName(30, "fichier-mp4.png");
            largeIcons.Images.SetKeyName(31, "fichier-pdb.png");
            largeIcons.Images.SetKeyName(32, "fichier-pdf.png");
            largeIcons.Images.SetKeyName(33, "fichier-png.png");
            largeIcons.Images.SetKeyName(34, "fichier-ppt.png");
            largeIcons.Images.SetKeyName(35, "fichier-ps.png");
            largeIcons.Images.SetKeyName(36, "fichier-psd.png");
            largeIcons.Images.SetKeyName(37, "fichier-rar.png");
            largeIcons.Images.SetKeyName(38, "fichier-sql.png");
            largeIcons.Images.SetKeyName(39, "fichier-svg.png");
            largeIcons.Images.SetKeyName(40, "fichier-tif.png");
            largeIcons.Images.SetKeyName(41, "fichier-txt.png");
            largeIcons.Images.SetKeyName(42, "fichier-xls.png");
            largeIcons.Images.SetKeyName(43, "fichier-xml.png");
            largeIcons.Images.SetKeyName(44, "fichier-zip.png");
            // 
            // smallIcons
            // 
            smallIcons.ColorDepth = ColorDepth.Depth32Bit;
            smallIcons.ImageStream = (ImageListStreamer)resources.GetObject("smallIcons.ImageStream");
            smallIcons.TransparentColor = Color.Transparent;
            smallIcons.Images.SetKeyName(0, "dossier.png");
            smallIcons.Images.SetKeyName(1, "fichier.png");
            smallIcons.Images.SetKeyName(2, "fichier-3ds.png");
            smallIcons.Images.SetKeyName(3, "fichier-aac.png");
            smallIcons.Images.SetKeyName(4, "fichier-ai.png");
            smallIcons.Images.SetKeyName(5, "fichier-avi.png");
            smallIcons.Images.SetKeyName(6, "fichier-bin.png");
            smallIcons.Images.SetKeyName(7, "fichier-bmp.png");
            smallIcons.Images.SetKeyName(8, "fichier-brut.png");
            smallIcons.Images.SetKeyName(9, "fichier-css.png");
            smallIcons.Images.SetKeyName(10, "fichier-csv.png");
            smallIcons.Images.SetKeyName(11, "fichier-dat.png");
            smallIcons.Images.SetKeyName(12, "fichier-dll.png");
            smallIcons.Images.SetKeyName(13, "fichier-dmg.png");
            smallIcons.Images.SetKeyName(14, "fichier-doc.png");
            smallIcons.Images.SetKeyName(15, "fichier-eps.png");
            smallIcons.Images.SetKeyName(16, "fichier-exe.png");
            smallIcons.Images.SetKeyName(17, "fichier-flv.png");
            smallIcons.Images.SetKeyName(18, "fichier-gif.png");
            smallIcons.Images.SetKeyName(19, "fichier-html.png");
            smallIcons.Images.SetKeyName(20, "fichier-ini.png");
            smallIcons.Images.SetKeyName(21, "fichier-iso.png");
            smallIcons.Images.SetKeyName(22, "fichier-jar.png");
            smallIcons.Images.SetKeyName(23, "fichier-java.png");
            smallIcons.Images.SetKeyName(24, "fichier-jpg.png");
            smallIcons.Images.SetKeyName(25, "fichier-js.png");
            smallIcons.Images.SetKeyName(26, "fichier-midi.png");
            smallIcons.Images.SetKeyName(27, "fichier-mkv.png");
            smallIcons.Images.SetKeyName(28, "fichier-mov.png");
            smallIcons.Images.SetKeyName(29, "fichier-mp3.png");
            smallIcons.Images.SetKeyName(30, "fichier-mp4.png");
            smallIcons.Images.SetKeyName(31, "fichier-pdb.png");
            smallIcons.Images.SetKeyName(32, "fichier-pdf.png");
            smallIcons.Images.SetKeyName(33, "fichier-png.png");
            smallIcons.Images.SetKeyName(34, "fichier-ppt.png");
            smallIcons.Images.SetKeyName(35, "fichier-ps.png");
            smallIcons.Images.SetKeyName(36, "fichier-psd.png");
            smallIcons.Images.SetKeyName(37, "fichier-rar.png");
            smallIcons.Images.SetKeyName(38, "fichier-sql.png");
            smallIcons.Images.SetKeyName(39, "fichier-svg.png");
            smallIcons.Images.SetKeyName(40, "fichier-tif.png");
            smallIcons.Images.SetKeyName(41, "fichier-txt.png");
            smallIcons.Images.SetKeyName(42, "fichier-xls.png");
            smallIcons.Images.SetKeyName(43, "fichier-xml.png");
            smallIcons.Images.SetKeyName(44, "fichier-zip.png");
            // 
            // createdAtColumn
            // 
            createdAtColumn.Text = "Créer le";
            createdAtColumn.Width = 128;
            // 
            // DirectoryContent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(view);
            Name = "DirectoryContent";
            Size = new Size(1002, 208);
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
        private ColumnHeader createdAtColumn;
    }
}
