using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniExplorer.Forms
{
    public partial class ElementModificationDialog : Form
    {
        /*
         * **************************************************************************************
         * *                                  NESTED CLASSES                                    *
         * **************************************************************************************
        */
        public enum ModificationType
        {
            NEW_DIRECTORY,
            NEW_FILE,
            RENAME
        }

        /*
         * **************************************************************************************
         * *                                 INSTANCE VARIABLES                                 *
         * **************************************************************************************
         */
        private ModificationType modification;

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
        public ElementModificationDialog()
        {
            InitializeComponent();
            Modification = ModificationType.NEW_DIRECTORY;
        }

        public ElementModificationDialog(ModificationType modification) : this()
        {
            Modification = modification;
        }

        /*
         * **************************************************************************************
         * *                                      PROPERTIES                                    *
         * **************************************************************************************
        */
        public string ElementName
        {
            get => this.elementNameTextBox.Text;
        }

        public ModificationType Modification
        {
            get => this.modification;
            set
            {
                this.modification = value;
                Display();
            }
        }

        /*
         * **************************************************************************************
         * *                                       METHODS                                      *
         * **************************************************************************************
        */
        private void Display()
        {
            switch (this.modification)
            {
                case ModificationType.NEW_DIRECTORY:
                    this.Text = "Créer un nouveau dossier";
                    this.elementNameLabel.Text = "Nom du nouveau dossier :";
                    this.modifyElementButton.Text = "Créer un nouveau dossier";
                    break;
                case ModificationType.NEW_FILE:
                    this.Text = "Créer un nouveau fichier";
                    this.elementNameLabel.Text = "Nom du nouveau fichier :";
                    this.modifyElementButton.Text = "Créer un nouveau fichier";
                    break;
                case ModificationType.RENAME:
                    this.Text = "Renommer un élément";
                    this.elementNameLabel.Text = "Nouveau nom de l'élément :";
                    this.modifyElementButton.Text = "Renommer l'élément";
                    break;
            }
        }

        /*
         * **************************************************************************************
         * *                                       EVENTS                                       *
         * **************************************************************************************
         */
        private void createButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
                this.DialogResult = DialogResult.OK;
        }

        private void elementNameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(ElementName))
            {
                e.Cancel = true;
                this.DialogResult = DialogResult.Cancel;
                return;
            }

            foreach (char invalidChar in Path.GetInvalidFileNameChars())
            {
                if (ElementName.Contains(invalidChar))
                {
                    e.Cancel = true;
                    MessageBox.Show(
                        $"Le nom indiqué contient le caractère invalide suivant : '{invalidChar}'",
                        "Nom d'élément invalide",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error); ;
                    return;
                }
            }
        }
    }
}
