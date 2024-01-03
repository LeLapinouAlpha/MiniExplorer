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
    public partial class NewElement : Form
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
        public NewElement()
        {
            InitializeComponent();
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
        private void createButton_Click(object sender, EventArgs e)
        {
            if(this.ValidateChildren())
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
