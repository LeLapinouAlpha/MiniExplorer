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
            inverserLaSéléctionToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            supprimerToolStripMenuItem = new ToolStripMenuItem();
            renommerToolStripMenuItem = new ToolStripMenuItem();
            affichageToolStripMenuItem = new ToolStripMenuItem();
            dispositionToolStripMenuItem = new ToolStripMenuItem();
            détailsToolStripMenuItem = new ToolStripMenuItem();
            listeToolStripMenuItem = new ToolStripMenuItem();
            petitesIcônesToolStripMenuItem = new ToolStripMenuItem();
            grandesIcônesToolStripMenuItem = new ToolStripMenuItem();
            mosaïquesToolStripMenuItem = new ToolStripMenuItem();
            afficherLesFichierscachésToolStripMenuItem = new ToolStripMenuItem();
            actualiserToolStripMenuItem = new ToolStripMenuItem();
            aideToolStripMenuItem = new ToolStripMenuItem();
            àproposdeToolStripMenuItem = new ToolStripMenuItem();
            folderBrowserDialog = new FolderBrowserDialog();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.BackColor = SystemColors.ButtonFace;
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
            nouvelleToolStripMenuItem.Image = Properties.Resources.plus_small;
            nouvelleToolStripMenuItem.Name = "nouvelleToolStripMenuItem";
            nouvelleToolStripMenuItem.Size = new Size(153, 22);
            nouvelleToolStripMenuItem.Text = "&Nouveau";
            // 
            // dossierToolStripMenuItem
            // 
            dossierToolStripMenuItem.Image = Properties.Resources.dossier_small;
            dossierToolStripMenuItem.Name = "dossierToolStripMenuItem";
            dossierToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            dossierToolStripMenuItem.Size = new Size(214, 22);
            dossierToolStripMenuItem.Text = "&Dossier";
            dossierToolStripMenuItem.Click += dossierToolStripMenuItem_Click;
            // 
            // fichierToolStripMenuItem1
            // 
            fichierToolStripMenuItem1.Image = Properties.Resources.fichier_small;
            fichierToolStripMenuItem1.Name = "fichierToolStripMenuItem1";
            fichierToolStripMenuItem1.ShortcutKeys = Keys.Control | Keys.Shift | Keys.N;
            fichierToolStripMenuItem1.Size = new Size(214, 22);
            fichierToolStripMenuItem1.Text = "&Fichier";
            fichierToolStripMenuItem1.Click += fichierToolStripMenuItem1_Click;
            // 
            // ouvrirToolStripMenuItem
            // 
            ouvrirToolStripMenuItem.Image = Properties.Resources.ouvrir_small;
            ouvrirToolStripMenuItem.Name = "ouvrirToolStripMenuItem";
            ouvrirToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            ouvrirToolStripMenuItem.Size = new Size(153, 22);
            ouvrirToolStripMenuItem.Text = "&Ouvrir";
            ouvrirToolStripMenuItem.Click += ouvrirToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(150, 6);
            // 
            // quitterToolStripMenuItem
            // 
            quitterToolStripMenuItem.Image = Properties.Resources.quitter_small;
            quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            quitterToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.F4;
            quitterToolStripMenuItem.Size = new Size(153, 22);
            quitterToolStripMenuItem.Text = "&Quitter";
            quitterToolStripMenuItem.Click += quitterToolStripMenuItem_Click;
            // 
            // modifierToolStripMenuItem
            // 
            modifierToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { annulerToolStripMenuItem, rétablirToolStripMenuItem, toolStripSeparator3, couperToolStripMenuItem, copierToolStripMenuItem, collerToolStripMenuItem, toolStripSeparator4, sélectionnertoutToolStripMenuItem, inverserLaSéléctionToolStripMenuItem, toolStripSeparator1, supprimerToolStripMenuItem, renommerToolStripMenuItem });
            modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            modifierToolStripMenuItem.Size = new Size(64, 34);
            modifierToolStripMenuItem.Text = "&Modifier";
            // 
            // annulerToolStripMenuItem
            // 
            annulerToolStripMenuItem.Image = Properties.Resources.annuler_small;
            annulerToolStripMenuItem.Name = "annulerToolStripMenuItem";
            annulerToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
            annulerToolStripMenuItem.Size = new Size(406, 22);
            annulerToolStripMenuItem.Text = "&Annuler";
            // 
            // rétablirToolStripMenuItem
            // 
            rétablirToolStripMenuItem.Image = Properties.Resources.rétablir_small;
            rétablirToolStripMenuItem.Name = "rétablirToolStripMenuItem";
            rétablirToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Y;
            rétablirToolStripMenuItem.Size = new Size(406, 22);
            rétablirToolStripMenuItem.Text = "&Rétablir";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(403, 6);
            // 
            // couperToolStripMenuItem
            // 
            couperToolStripMenuItem.Image = Properties.Resources.couper_small;
            couperToolStripMenuItem.Name = "couperToolStripMenuItem";
            couperToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            couperToolStripMenuItem.Size = new Size(406, 22);
            couperToolStripMenuItem.Text = "&Couper";
            couperToolStripMenuItem.Click += couperToolStripMenuItem_Click;
            // 
            // copierToolStripMenuItem
            // 
            copierToolStripMenuItem.Image = Properties.Resources.copier_small;
            copierToolStripMenuItem.Name = "copierToolStripMenuItem";
            copierToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            copierToolStripMenuItem.Size = new Size(406, 22);
            copierToolStripMenuItem.Text = "&Copier";
            copierToolStripMenuItem.Click += copierToolStripMenuItem_Click;
            // 
            // collerToolStripMenuItem
            // 
            collerToolStripMenuItem.Image = Properties.Resources.coller_small;
            collerToolStripMenuItem.Name = "collerToolStripMenuItem";
            collerToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V;
            collerToolStripMenuItem.Size = new Size(406, 22);
            collerToolStripMenuItem.Text = "&Coller";
            collerToolStripMenuItem.Click += collerToolStripMenuItem_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(403, 6);
            // 
            // sélectionnertoutToolStripMenuItem
            // 
            sélectionnertoutToolStripMenuItem.Image = Properties.Resources.cocher_tout_small;
            sélectionnertoutToolStripMenuItem.Name = "sélectionnertoutToolStripMenuItem";
            sélectionnertoutToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.A;
            sélectionnertoutToolStripMenuItem.Size = new Size(406, 22);
            sélectionnertoutToolStripMenuItem.Text = "&Sélectionner tout";
            sélectionnertoutToolStripMenuItem.Click += sélectionnertoutToolStripMenuItem_Click;
            // 
            // inverserLaSéléctionToolStripMenuItem
            // 
            inverserLaSéléctionToolStripMenuItem.Image = Properties.Resources.inverser_selection;
            inverserLaSéléctionToolStripMenuItem.Name = "inverserLaSéléctionToolStripMenuItem";
            inverserLaSéléctionToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.A;
            inverserLaSéléctionToolStripMenuItem.Size = new Size(406, 22);
            inverserLaSéléctionToolStripMenuItem.Text = "Inverser la séléction";
            inverserLaSéléctionToolStripMenuItem.Click += inverserLaSéléctionToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(403, 6);
            // 
            // supprimerToolStripMenuItem
            // 
            supprimerToolStripMenuItem.Image = Properties.Resources.effacer_small;
            supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            supprimerToolStripMenuItem.ShortcutKeys = Keys.Delete;
            supprimerToolStripMenuItem.Size = new Size(406, 22);
            supprimerToolStripMenuItem.Text = "&Déplacer les éléments séléctionnés dans la corbeille";
            supprimerToolStripMenuItem.Click += supprimerToolStripMenuItem_Click;
            // 
            // renommerToolStripMenuItem
            // 
            renommerToolStripMenuItem.Image = Properties.Resources.renommer_small;
            renommerToolStripMenuItem.Name = "renommerToolStripMenuItem";
            renommerToolStripMenuItem.ShortcutKeys = Keys.F2;
            renommerToolStripMenuItem.Size = new Size(406, 22);
            renommerToolStripMenuItem.Text = "&Renommer";
            renommerToolStripMenuItem.Click += renommerToolStripMenuItem_Click;
            // 
            // affichageToolStripMenuItem
            // 
            affichageToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dispositionToolStripMenuItem, afficherLesFichierscachésToolStripMenuItem, actualiserToolStripMenuItem });
            affichageToolStripMenuItem.Name = "affichageToolStripMenuItem";
            affichageToolStripMenuItem.Size = new Size(70, 34);
            affichageToolStripMenuItem.Text = "&Affichage";
            // 
            // dispositionToolStripMenuItem
            // 
            dispositionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { détailsToolStripMenuItem, listeToolStripMenuItem, petitesIcônesToolStripMenuItem, grandesIcônesToolStripMenuItem, mosaïquesToolStripMenuItem });
            dispositionToolStripMenuItem.Name = "dispositionToolStripMenuItem";
            dispositionToolStripMenuItem.Size = new Size(213, 22);
            dispositionToolStripMenuItem.Text = "&Disposition";
            // 
            // détailsToolStripMenuItem
            // 
            détailsToolStripMenuItem.Checked = true;
            détailsToolStripMenuItem.CheckOnClick = true;
            détailsToolStripMenuItem.CheckState = CheckState.Checked;
            détailsToolStripMenuItem.Image = Properties.Resources.détails_small;
            détailsToolStripMenuItem.Name = "détailsToolStripMenuItem";
            détailsToolStripMenuItem.Size = new Size(180, 22);
            détailsToolStripMenuItem.Text = "&Détails";
            détailsToolStripMenuItem.Click += détailsToolStripMenuItem_Click;
            // 
            // listeToolStripMenuItem
            // 
            listeToolStripMenuItem.CheckOnClick = true;
            listeToolStripMenuItem.Image = Properties.Resources.liste_small;
            listeToolStripMenuItem.Name = "listeToolStripMenuItem";
            listeToolStripMenuItem.Size = new Size(180, 22);
            listeToolStripMenuItem.Text = "&Liste";
            listeToolStripMenuItem.Click += listeToolStripMenuItem_Click;
            // 
            // petitesIcônesToolStripMenuItem
            // 
            petitesIcônesToolStripMenuItem.Image = Properties.Resources.petites_icônes_small;
            petitesIcônesToolStripMenuItem.Name = "petitesIcônesToolStripMenuItem";
            petitesIcônesToolStripMenuItem.Size = new Size(180, 22);
            petitesIcônesToolStripMenuItem.Text = "&Petites icônes";
            petitesIcônesToolStripMenuItem.Click += petitesIcônesToolStripMenuItem_Click;
            // 
            // grandesIcônesToolStripMenuItem
            // 
            grandesIcônesToolStripMenuItem.Image = Properties.Resources.grandes_icônes_small;
            grandesIcônesToolStripMenuItem.Name = "grandesIcônesToolStripMenuItem";
            grandesIcônesToolStripMenuItem.Size = new Size(180, 22);
            grandesIcônesToolStripMenuItem.Text = "&Grandes icônes";
            grandesIcônesToolStripMenuItem.Click += grandesIcônesToolStripMenuItem_Click;
            // 
            // mosaïquesToolStripMenuItem
            // 
            mosaïquesToolStripMenuItem.Image = Properties.Resources.mosaïque_small;
            mosaïquesToolStripMenuItem.Name = "mosaïquesToolStripMenuItem";
            mosaïquesToolStripMenuItem.Size = new Size(180, 22);
            mosaïquesToolStripMenuItem.Text = "&Mosaïques";
            mosaïquesToolStripMenuItem.Click += mosaïquesToolStripMenuItem_Click;
            // 
            // afficherLesFichierscachésToolStripMenuItem
            // 
            afficherLesFichierscachésToolStripMenuItem.Checked = true;
            afficherLesFichierscachésToolStripMenuItem.CheckOnClick = true;
            afficherLesFichierscachésToolStripMenuItem.CheckState = CheckState.Checked;
            afficherLesFichierscachésToolStripMenuItem.Name = "afficherLesFichierscachésToolStripMenuItem";
            afficherLesFichierscachésToolStripMenuItem.Size = new Size(213, 22);
            afficherLesFichierscachésToolStripMenuItem.Text = "Afficher les fichiers &cachés";
            afficherLesFichierscachésToolStripMenuItem.Click += afficherLesFichierscachésToolStripMenuItem_Click;
            // 
            // actualiserToolStripMenuItem
            // 
            actualiserToolStripMenuItem.Image = Properties.Resources.rafraîchir_small;
            actualiserToolStripMenuItem.Name = "actualiserToolStripMenuItem";
            actualiserToolStripMenuItem.ShortcutKeys = Keys.F5;
            actualiserToolStripMenuItem.Size = new Size(213, 22);
            actualiserToolStripMenuItem.Text = "&Actualiser";
            actualiserToolStripMenuItem.Click += actualiserToolStripMenuItem_Click;
            // 
            // aideToolStripMenuItem
            // 
            aideToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { àproposdeToolStripMenuItem });
            aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            aideToolStripMenuItem.Size = new Size(24, 34);
            aideToolStripMenuItem.Text = "&?";
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
        private ToolStripMenuItem mosaïquesToolStripMenuItem;
        private ToolStripMenuItem afficherLesFichierscachésToolStripMenuItem;
        private ToolStripMenuItem actualiserToolStripMenuItem;
        private ToolStripMenuItem inverserLaSéléctionToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem supprimerToolStripMenuItem;
        private ToolStripMenuItem renommerToolStripMenuItem;
    }
}
