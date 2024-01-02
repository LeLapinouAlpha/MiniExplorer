namespace MiniExplorer.Controls
{
    partial class MenuBar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuBar));
            menuStrip = new MenuStrip();
            fichierToolStripMenuItem = new ToolStripMenuItem();
            nouvelleToolStripMenuItem = new ToolStripMenuItem();
            dossierToolStripMenuItem = new ToolStripMenuItem();
            fichierToolStripMenuItem1 = new ToolStripMenuItem();
            ouvrirToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            quitterToolStripMenuItem = new ToolStripMenuItem();
            modifierToolStripMenuItem = new ToolStripMenuItem();
            annulerToolStripMenuItem = new ToolStripMenuItem();
            rétablirToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            couperToolStripMenuItem = new ToolStripMenuItem();
            copierToolStripMenuItem = new ToolStripMenuItem();
            collerToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            sélectionnertoutToolStripMenuItem = new ToolStripMenuItem();
            affichageToolStripMenuItem = new ToolStripMenuItem();
            dispositionToolStripMenuItem = new ToolStripMenuItem();
            détailsToolStripMenuItem = new ToolStripMenuItem();
            listeToolStripMenuItem = new ToolStripMenuItem();
            petitesIcônesToolStripMenuItem = new ToolStripMenuItem();
            grandesIcônesToolStripMenuItem = new ToolStripMenuItem();
            tuilesToolStripMenuItem = new ToolStripMenuItem();
            afficherLesFichierscachésToolStripMenuItem = new ToolStripMenuItem();
            aideToolStripMenuItem = new ToolStripMenuItem();
            àproposdeToolStripMenuItem = new ToolStripMenuItem();
            folderBrowserDialog = new FolderBrowserDialog();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.Dock = DockStyle.Fill;
            menuStrip.Items.AddRange(new ToolStripItem[] { fichierToolStripMenuItem, modifierToolStripMenuItem, affichageToolStripMenuItem, aideToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(658, 38);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            fichierToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nouvelleToolStripMenuItem, ouvrirToolStripMenuItem, toolStripSeparator2, quitterToolStripMenuItem });
            fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            fichierToolStripMenuItem.Size = new Size(54, 34);
            fichierToolStripMenuItem.Text = "&Fichier";
            // 
            // nouvelleToolStripMenuItem
            // 
            nouvelleToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dossierToolStripMenuItem, fichierToolStripMenuItem1 });
            nouvelleToolStripMenuItem.Image = (Image)resources.GetObject("nouvelleToolStripMenuItem.Image");
            nouvelleToolStripMenuItem.Name = "nouvelleToolStripMenuItem";
            nouvelleToolStripMenuItem.Size = new Size(122, 22);
            nouvelleToolStripMenuItem.Text = "&Nouveau";
            // 
            // dossierToolStripMenuItem
            // 
            dossierToolStripMenuItem.Name = "dossierToolStripMenuItem";
            dossierToolStripMenuItem.Size = new Size(112, 22);
            dossierToolStripMenuItem.Text = "&Dossier";
            dossierToolStripMenuItem.Click += dossierToolStripMenuItem_Click;
            // 
            // fichierToolStripMenuItem1
            // 
            fichierToolStripMenuItem1.Name = "fichierToolStripMenuItem1";
            fichierToolStripMenuItem1.Size = new Size(112, 22);
            fichierToolStripMenuItem1.Text = "&Fichier";
            fichierToolStripMenuItem1.Click += fichierToolStripMenuItem1_Click;
            // 
            // ouvrirToolStripMenuItem
            // 
            ouvrirToolStripMenuItem.Image = (Image)resources.GetObject("ouvrirToolStripMenuItem.Image");
            ouvrirToolStripMenuItem.Name = "ouvrirToolStripMenuItem";
            ouvrirToolStripMenuItem.Size = new Size(122, 22);
            ouvrirToolStripMenuItem.Text = "&Ouvrir";
            ouvrirToolStripMenuItem.Click += ouvrirToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(119, 6);
            // 
            // quitterToolStripMenuItem
            // 
            quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            quitterToolStripMenuItem.Size = new Size(122, 22);
            quitterToolStripMenuItem.Text = "&Quitter";
            quitterToolStripMenuItem.Click += quitterToolStripMenuItem_Click;
            // 
            // modifierToolStripMenuItem
            // 
            modifierToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { annulerToolStripMenuItem, rétablirToolStripMenuItem, toolStripSeparator3, couperToolStripMenuItem, copierToolStripMenuItem, collerToolStripMenuItem, toolStripSeparator4, sélectionnertoutToolStripMenuItem });
            modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            modifierToolStripMenuItem.Size = new Size(64, 34);
            modifierToolStripMenuItem.Text = "&Modifier";
            // 
            // annulerToolStripMenuItem
            // 
            annulerToolStripMenuItem.Name = "annulerToolStripMenuItem";
            annulerToolStripMenuItem.Size = new Size(164, 22);
            annulerToolStripMenuItem.Text = "&Annuler";
            // 
            // rétablirToolStripMenuItem
            // 
            rétablirToolStripMenuItem.Name = "rétablirToolStripMenuItem";
            rétablirToolStripMenuItem.Size = new Size(164, 22);
            rétablirToolStripMenuItem.Text = "&Rétablir";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(161, 6);
            // 
            // couperToolStripMenuItem
            // 
            couperToolStripMenuItem.Image = (Image)resources.GetObject("couperToolStripMenuItem.Image");
            couperToolStripMenuItem.Name = "couperToolStripMenuItem";
            couperToolStripMenuItem.Size = new Size(164, 22);
            couperToolStripMenuItem.Text = "&Couper";
            // 
            // copierToolStripMenuItem
            // 
            copierToolStripMenuItem.Image = (Image)resources.GetObject("copierToolStripMenuItem.Image");
            copierToolStripMenuItem.Name = "copierToolStripMenuItem";
            copierToolStripMenuItem.Size = new Size(164, 22);
            copierToolStripMenuItem.Text = "&Copier";
            // 
            // collerToolStripMenuItem
            // 
            collerToolStripMenuItem.Image = (Image)resources.GetObject("collerToolStripMenuItem.Image");
            collerToolStripMenuItem.Name = "collerToolStripMenuItem";
            collerToolStripMenuItem.Size = new Size(164, 22);
            collerToolStripMenuItem.Text = "&Coller";
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(161, 6);
            // 
            // sélectionnertoutToolStripMenuItem
            // 
            sélectionnertoutToolStripMenuItem.Name = "sélectionnertoutToolStripMenuItem";
            sélectionnertoutToolStripMenuItem.Size = new Size(164, 22);
            sélectionnertoutToolStripMenuItem.Text = "&Sélectionner tout";
            sélectionnertoutToolStripMenuItem.Click += sélectionnertoutToolStripMenuItem_Click;
            // 
            // affichageToolStripMenuItem
            // 
            affichageToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dispositionToolStripMenuItem, afficherLesFichierscachésToolStripMenuItem });
            affichageToolStripMenuItem.Name = "affichageToolStripMenuItem";
            affichageToolStripMenuItem.Size = new Size(70, 34);
            affichageToolStripMenuItem.Text = "&Affichage";
            // 
            // dispositionToolStripMenuItem
            // 
            dispositionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { détailsToolStripMenuItem, listeToolStripMenuItem, petitesIcônesToolStripMenuItem, grandesIcônesToolStripMenuItem, tuilesToolStripMenuItem });
            dispositionToolStripMenuItem.Name = "dispositionToolStripMenuItem";
            dispositionToolStripMenuItem.Size = new Size(213, 22);
            dispositionToolStripMenuItem.Text = "&Disposition";
            // 
            // détailsToolStripMenuItem
            // 
            détailsToolStripMenuItem.Checked = true;
            détailsToolStripMenuItem.CheckOnClick = true;
            détailsToolStripMenuItem.CheckState = CheckState.Checked;
            détailsToolStripMenuItem.Name = "détailsToolStripMenuItem";
            détailsToolStripMenuItem.Size = new Size(154, 22);
            détailsToolStripMenuItem.Text = "&Détails";
            // 
            // listeToolStripMenuItem
            // 
            listeToolStripMenuItem.CheckOnClick = true;
            listeToolStripMenuItem.Name = "listeToolStripMenuItem";
            listeToolStripMenuItem.Size = new Size(154, 22);
            listeToolStripMenuItem.Text = "&Liste";
            // 
            // petitesIcônesToolStripMenuItem
            // 
            petitesIcônesToolStripMenuItem.Name = "petitesIcônesToolStripMenuItem";
            petitesIcônesToolStripMenuItem.Size = new Size(154, 22);
            petitesIcônesToolStripMenuItem.Text = "&Petites icônes";
            // 
            // grandesIcônesToolStripMenuItem
            // 
            grandesIcônesToolStripMenuItem.Name = "grandesIcônesToolStripMenuItem";
            grandesIcônesToolStripMenuItem.Size = new Size(154, 22);
            grandesIcônesToolStripMenuItem.Text = "&Grandes icônes";
            // 
            // tuilesToolStripMenuItem
            // 
            tuilesToolStripMenuItem.Name = "tuilesToolStripMenuItem";
            tuilesToolStripMenuItem.Size = new Size(154, 22);
            tuilesToolStripMenuItem.Text = "&Mosaïques";
            // 
            // afficherLesFichierscachésToolStripMenuItem
            // 
            afficherLesFichierscachésToolStripMenuItem.Checked = true;
            afficherLesFichierscachésToolStripMenuItem.CheckOnClick = true;
            afficherLesFichierscachésToolStripMenuItem.CheckState = CheckState.Checked;
            afficherLesFichierscachésToolStripMenuItem.Name = "afficherLesFichierscachésToolStripMenuItem";
            afficherLesFichierscachésToolStripMenuItem.Size = new Size(213, 22);
            afficherLesFichierscachésToolStripMenuItem.Text = "&Afficher les fichiers cachés";
            afficherLesFichierscachésToolStripMenuItem.Click += afficherLesFichierscachésToolStripMenuItem_Click;
            // 
            // aideToolStripMenuItem
            // 
            aideToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { àproposdeToolStripMenuItem });
            aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            aideToolStripMenuItem.Size = new Size(43, 34);
            aideToolStripMenuItem.Text = "A&ide";
            // 
            // àproposdeToolStripMenuItem
            // 
            àproposdeToolStripMenuItem.Name = "àproposdeToolStripMenuItem";
            àproposdeToolStripMenuItem.Size = new Size(147, 22);
            àproposdeToolStripMenuItem.Text = "À pr&opos de...";
            àproposdeToolStripMenuItem.Click += àproposdeToolStripMenuItem_Click;
            // 
            // folderBrowserDialog
            // 
            folderBrowserDialog.ShowHiddenFiles = true;
            // 
            // MenuBar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(menuStrip);
            Name = "MenuBar";
            Size = new Size(658, 38);
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem fichierToolStripMenuItem;
        private ToolStripMenuItem nouvelleToolStripMenuItem;
        private ToolStripMenuItem ouvrirToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem quitterToolStripMenuItem;
        private ToolStripMenuItem modifierToolStripMenuItem;
        private ToolStripMenuItem annulerToolStripMenuItem;
        private ToolStripMenuItem rétablirToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem couperToolStripMenuItem;
        private ToolStripMenuItem copierToolStripMenuItem;
        private ToolStripMenuItem collerToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem sélectionnertoutToolStripMenuItem;
        private ToolStripMenuItem aideToolStripMenuItem;
        private ToolStripMenuItem àproposdeToolStripMenuItem;
        private ToolStripMenuItem dossierToolStripMenuItem;
        private ToolStripMenuItem fichierToolStripMenuItem1;
        private FolderBrowserDialog folderBrowserDialog;
        private ToolStripMenuItem affichageToolStripMenuItem;
        private ToolStripMenuItem dispositionToolStripMenuItem;
        private ToolStripMenuItem détailsToolStripMenuItem;
        private ToolStripMenuItem listeToolStripMenuItem;
        private ToolStripMenuItem petitesIcônesToolStripMenuItem;
        private ToolStripMenuItem grandesIcônesToolStripMenuItem;
        private ToolStripMenuItem tuilesToolStripMenuItem;
        private ToolStripMenuItem afficherLesFichierscachésToolStripMenuItem;
    }
}
