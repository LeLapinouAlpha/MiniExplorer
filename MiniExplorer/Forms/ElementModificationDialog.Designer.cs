namespace MiniExplorer.Forms
{
    partial class ElementModificationDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ElementModificationDialog));
            cancelButton = new Button();
            modifyElementButton = new Button();
            elementNameTextBox = new TextBox();
            elementNameLabel = new Label();
            SuspendLayout();
            // 
            // cancelButton
            // 
            cancelButton.CausesValidation = false;
            cancelButton.DialogResult = DialogResult.Cancel;
            cancelButton.Location = new Point(327, 56);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(80, 24);
            cancelButton.TabIndex = 2;
            cancelButton.Text = "Annuler";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // modifyElementButton
            // 
            modifyElementButton.DialogResult = DialogResult.OK;
            modifyElementButton.Location = new Point(164, 56);
            modifyElementButton.Name = "modifyElementButton";
            modifyElementButton.Size = new Size(157, 24);
            modifyElementButton.TabIndex = 1;
            modifyElementButton.Text = "Créer un nouvel élément";
            modifyElementButton.UseVisualStyleBackColor = true;
            modifyElementButton.Click += createButton_Click;
            // 
            // elementNameTextBox
            // 
            elementNameTextBox.Location = new Point(12, 27);
            elementNameTextBox.Name = "elementNameTextBox";
            elementNameTextBox.Size = new Size(395, 23);
            elementNameTextBox.TabIndex = 0;
            elementNameTextBox.Validating += elementNameTextBox_Validating;
            // 
            // elementNameLabel
            // 
            elementNameLabel.AutoSize = true;
            elementNameLabel.Location = new Point(12, 9);
            elementNameLabel.Name = "elementNameLabel";
            elementNameLabel.Size = new Size(142, 15);
            elementNameLabel.TabIndex = 2;
            elementNameLabel.Text = "Nom du nouvel élément :";
            // 
            // ElementModificationDialog
            // 
            AcceptButton = modifyElementButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = cancelButton;
            ClientSize = new Size(419, 91);
            Controls.Add(elementNameLabel);
            Controls.Add(elementNameTextBox);
            Controls.Add(modifyElementButton);
            Controls.Add(cancelButton);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ElementModificationDialog";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Nouvel élément";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cancelButton;
        private Button modifyElementButton;
        private TextBox elementNameTextBox;
        private Label elementNameLabel;
    }
}