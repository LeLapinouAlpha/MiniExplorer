﻿using System;
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
    public partial class MenuBar : UserControl
    {
        /*
         * **************************************************************************************
         * *                                 INSTANCE VARIABLES                                 *
         * **************************************************************************************
         */

        /*
         * **************************************************************************************
         * *                                  EVENTS HANDLER                                    *
         * **************************************************************************************
         */

        /*
         * **************************************************************************************
         * *                                    CONSTRUCTORS                                    *
         * **************************************************************************************
        */
        public MenuBar()
        {
            InitializeComponent();
        }


        /*
          * **************************************************************************************
          * *                                    PROPERTIES                                      *
          * **************************************************************************************
         */
        public DirectoryContent? DirectoryContent { get; set; } = null;
        public DirectoryTree? DirectoryTree { get; set; } = null;

        /*
         * **************************************************************************************
         * *                                       METHODS                                      *
         * **************************************************************************************
        */

        /*
         * **************************************************************************************
         * *                                       EVENTS                                       *
         * **************************************************************************************
         */
        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void àproposdeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Forms.AboutForm().ShowDialog();
        }

        private void sélectionnertoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DirectoryContent?.SelectAll();
        }

        private void dossierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Forms.NewElement().ShowDialog();
        }

        private void fichierToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new Forms.NewElement().ShowDialog();
        }

        private void ouvrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                if (DirectoryContent != null)
                    DirectoryContent.DirPath = folderBrowserDialog.SelectedPath;
                if (DirectoryTree != null)
                    DirectoryTree.RootDirPath = folderBrowserDialog.SelectedPath;
            }
        }

        private void afficherLesFichierscachésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DirectoryContent != null)
                DirectoryContent.ShowHiddenFiles = affichageToolStripMenuItem.Checked;
        }

        private void détailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.détailsToolStripMenuItem.Checked = true;

            if (DirectoryContent != null)
                DirectoryContent.View = View.Details;

            this.listeToolStripMenuItem.Checked = false;
            this.petitesIcônesToolStripMenuItem.Checked = false;
            this.grandesIcônesToolStripMenuItem.Checked = false;
            this.mosaïquesToolStripMenuItem.Checked = false;
        }

        private void listeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.listeToolStripMenuItem.Checked = true;

            if (DirectoryContent != null)
                DirectoryContent.View = View.List;

            this.détailsToolStripMenuItem.Checked = false;
            this.petitesIcônesToolStripMenuItem.Checked = false;
            this.grandesIcônesToolStripMenuItem.Checked = false;
            this.mosaïquesToolStripMenuItem.Checked = false;
        }

        private void petitesIcônesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.petitesIcônesToolStripMenuItem.Checked = true;

            if (DirectoryContent != null)
                DirectoryContent.View = View.SmallIcon;

            this.détailsToolStripMenuItem.Checked = false;
            this.listeToolStripMenuItem.Checked = false;
            this.grandesIcônesToolStripMenuItem.Checked = false;
            this.mosaïquesToolStripMenuItem.Checked = false;
        }


        private void grandesIcônesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.grandesIcônesToolStripMenuItem.Checked = true;

            if (DirectoryContent != null)
                DirectoryContent.View = View.LargeIcon;

            this.détailsToolStripMenuItem.Checked = false;
            this.listeToolStripMenuItem.Checked = false;
            this.petitesIcônesToolStripMenuItem.Checked = false;
            this.mosaïquesToolStripMenuItem.Checked = false;
        }

        private void mosaïquesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.mosaïquesToolStripMenuItem.Checked = true;

            if (DirectoryContent != null)
                DirectoryContent.View = View.Tile;

            this.détailsToolStripMenuItem.Checked = false;
            this.listeToolStripMenuItem.Checked = false;
            this.petitesIcônesToolStripMenuItem.Checked = false;
            this.grandesIcônesToolStripMenuItem.Checked = false;
        }
    }
}
