namespace MiniExplorer.Controls
{
    partial class ToolBar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolBar));
            toolStrip = new ToolStrip();
            previousButton = new ToolStripButton();
            nextButton = new ToolStripButton();
            parentButton = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            navigationBarTextBox = new ToolStripTextBox();
            reloadButton = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            searchBarTextBox = new ToolStripTextBox();
            searchButton = new ToolStripButton();
            toolStrip.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip
            // 
            toolStrip.Dock = DockStyle.Fill;
            toolStrip.Items.AddRange(new ToolStripItem[] { previousButton, nextButton, parentButton, toolStripSeparator1, navigationBarTextBox, reloadButton, toolStripSeparator2, searchBarTextBox, searchButton });
            toolStrip.Location = new Point(0, 0);
            toolStrip.Name = "toolStrip";
            toolStrip.RenderMode = ToolStripRenderMode.System;
            toolStrip.Size = new Size(760, 31);
            toolStrip.TabIndex = 0;
            toolStrip.Text = "toolStrip1";
            // 
            // previousButton
            // 
            previousButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            previousButton.Image = (Image)resources.GetObject("previousButton.Image");
            previousButton.ImageTransparentColor = Color.Magenta;
            previousButton.Name = "previousButton";
            previousButton.Size = new Size(23, 28);
            previousButton.ToolTipText = "Précédent";
            // 
            // nextButton
            // 
            nextButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            nextButton.Image = (Image)resources.GetObject("nextButton.Image");
            nextButton.ImageTransparentColor = Color.Magenta;
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(23, 28);
            nextButton.ToolTipText = "Suivant";
            // 
            // parentButton
            // 
            parentButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            parentButton.Image = (Image)resources.GetObject("parentButton.Image");
            parentButton.ImageTransparentColor = Color.Magenta;
            parentButton.Name = "parentButton";
            parentButton.Size = new Size(23, 28);
            parentButton.ToolTipText = "Dossier parent";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 31);
            // 
            // navigationBarTextBox
            // 
            navigationBarTextBox.BorderStyle = BorderStyle.FixedSingle;
            navigationBarTextBox.Name = "navigationBarTextBox";
            navigationBarTextBox.Size = new Size(500, 31);
            // 
            // reloadButton
            // 
            reloadButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            reloadButton.Image = (Image)resources.GetObject("reloadButton.Image");
            reloadButton.ImageTransparentColor = Color.Magenta;
            reloadButton.Name = "reloadButton";
            reloadButton.Size = new Size(23, 28);
            reloadButton.ToolTipText = "Actualiser";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 31);
            // 
            // searchBarTextBox
            // 
            searchBarTextBox.BorderStyle = BorderStyle.FixedSingle;
            searchBarTextBox.Name = "searchBarTextBox";
            searchBarTextBox.Size = new Size(100, 31);
            // 
            // searchButton
            // 
            searchButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            searchButton.Image = (Image)resources.GetObject("searchButton.Image");
            searchButton.ImageTransparentColor = Color.Magenta;
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(23, 28);
            searchButton.ToolTipText = "Rechercher";
            // 
            // ToolBar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(toolStrip);
            Name = "ToolBar";
            Size = new Size(760, 31);
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip;
        private ToolStripButton previousButton;
        private ToolStripButton nextButton;
        private ToolStripButton parentButton;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripTextBox navigationBarTextBox;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton reloadButton;
        private ToolStripTextBox searchBarTextBox;
        private ToolStripButton searchButton;
    }
}
