namespace MiniExplorer.Controls
{
    partial class StatusBar
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
            statusStrip = new StatusStrip();
            elementCountLabel = new ToolStripStatusLabel();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip
            // 
            statusStrip.Dock = DockStyle.Fill;
            statusStrip.Items.AddRange(new ToolStripItem[] { elementCountLabel });
            statusStrip.Location = new Point(0, 0);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(420, 31);
            statusStrip.TabIndex = 0;
            statusStrip.Text = "statusStrip1";
            // 
            // elementCountLabel
            // 
            elementCountLabel.Name = "elementCountLabel";
            elementCountLabel.Size = new Size(72, 26);
            elementCountLabel.Text = "0 element(s)";
            // 
            // StatusBar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(statusStrip);
            Name = "StatusBar";
            Size = new Size(420, 31);
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip;
        private ToolStripStatusLabel elementCountLabel;
    }
}
