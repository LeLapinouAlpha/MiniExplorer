namespace MiniExplorer.Forms
{
    partial class NewElement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewElement));
            cancelButton = new Button();
            createButton = new Button();
            elementNameTextBox = new TextBox();
            elementNameLabel = new Label();
            SuspendLayout();
            // 
            // cancelButton
            // 
            cancelButton.DialogResult = DialogResult.Cancel;
            cancelButton.Location = new Point(327, 80);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(80, 24);
            cancelButton.TabIndex = 1;
            cancelButton.Text = "Annuler";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // createButton
            // 
            createButton.DialogResult = DialogResult.OK;
            createButton.Location = new Point(165, 80);
            createButton.Name = "createButton";
            createButton.Size = new Size(157, 24);
            createButton.TabIndex = 0;
            createButton.Text = "Créer un nouvel élément";
            createButton.UseVisualStyleBackColor = true;
            // 
            // elementNameTextBox
            // 
            elementNameTextBox.Location = new Point(12, 39);
            elementNameTextBox.Name = "elementNameTextBox";
            elementNameTextBox.Size = new Size(395, 23);
            elementNameTextBox.TabIndex = 2;
            // 
            // elementNameLabel
            // 
            elementNameLabel.AutoSize = true;
            elementNameLabel.Location = new Point(12, 9);
            elementNameLabel.Name = "elementNameLabel";
            elementNameLabel.Size = new Size(142, 15);
            elementNameLabel.TabIndex = 3;
            elementNameLabel.Text = "Nom du nouvel élément :";
            // 
            // NewElement
            // 
            AcceptButton = createButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = cancelButton;
            ClientSize = new Size(419, 116);
            Controls.Add(elementNameLabel);
            Controls.Add(elementNameTextBox);
            Controls.Add(createButton);
            Controls.Add(cancelButton);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "NewElement";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Nouvel élément";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cancelButton;
        private Button createButton;
        private TextBox elementNameTextBox;
        private Label elementNameLabel;
    }
}