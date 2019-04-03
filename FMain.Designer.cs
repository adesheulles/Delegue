namespace tp_evenement_objet
{
    partial class FMain
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNouveauLivre = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNouveauLivre
            // 
            this.btnNouveauLivre.Location = new System.Drawing.Point(95, 73);
            this.btnNouveauLivre.Name = "btnNouveauLivre";
            this.btnNouveauLivre.Size = new System.Drawing.Size(75, 23);
            this.btnNouveauLivre.TabIndex = 0;
            this.btnNouveauLivre.Text = "Nouveau Livre";
            this.btnNouveauLivre.UseVisualStyleBackColor = true;
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 177);
            this.Controls.Add(this.btnNouveauLivre);
            this.Name = "FMain";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNouveauLivre;
    }
}

