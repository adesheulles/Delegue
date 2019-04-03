namespace tp_evenement_objet
{
    partial class FLivre
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
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblPrix = new System.Windows.Forms.Label();
            this.lblPrixTTC = new System.Windows.Forms.Label();
            this.tbTitre = new System.Windows.Forms.TextBox();
            this.tbPrix = new System.Windows.Forms.TextBox();
            this.tbPrixTTC = new System.Windows.Forms.TextBox();
            this.btnHausseAnnuelle = new System.Windows.Forms.Button();
            this.btnModifierPrix = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Location = new System.Drawing.Point(66, 53);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(30, 13);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "titre :";
            // 
            // lblPrix
            // 
            this.lblPrix.AutoSize = true;
            this.lblPrix.Location = new System.Drawing.Point(66, 88);
            this.lblPrix.Name = "lblPrix";
            this.lblPrix.Size = new System.Drawing.Size(29, 13);
            this.lblPrix.TabIndex = 1;
            this.lblPrix.Text = "prix :";
            // 
            // lblPrixTTC
            // 
            this.lblPrixTTC.AutoSize = true;
            this.lblPrixTTC.Location = new System.Drawing.Point(66, 123);
            this.lblPrixTTC.Name = "lblPrixTTC";
            this.lblPrixTTC.Size = new System.Drawing.Size(53, 13);
            this.lblPrixTTC.TabIndex = 2;
            this.lblPrixTTC.Text = "prix TTC :";
            // 
            // tbTitre
            // 
            this.tbTitre.Location = new System.Drawing.Point(140, 46);
            this.tbTitre.Name = "tbTitre";
            this.tbTitre.Size = new System.Drawing.Size(100, 20);
            this.tbTitre.TabIndex = 3;
            // 
            // tbPrix
            // 
            this.tbPrix.Location = new System.Drawing.Point(140, 80);
            this.tbPrix.Name = "tbPrix";
            this.tbPrix.Size = new System.Drawing.Size(100, 20);
            this.tbPrix.TabIndex = 4;
            // 
            // tbPrixTTC
            // 
            this.tbPrixTTC.Location = new System.Drawing.Point(140, 115);
            this.tbPrixTTC.Name = "tbPrixTTC";
            this.tbPrixTTC.Size = new System.Drawing.Size(100, 20);
            this.tbPrixTTC.TabIndex = 5;
            // 
            // btnHausseAnnuelle
            // 
            this.btnHausseAnnuelle.Location = new System.Drawing.Point(44, 194);
            this.btnHausseAnnuelle.Name = "btnHausseAnnuelle";
            this.btnHausseAnnuelle.Size = new System.Drawing.Size(115, 23);
            this.btnHausseAnnuelle.TabIndex = 6;
            this.btnHausseAnnuelle.Text = "Hausse annuelle";
            this.btnHausseAnnuelle.UseVisualStyleBackColor = true;
            // 
            // btnModifierPrix
            // 
            this.btnModifierPrix.Location = new System.Drawing.Point(190, 194);
            this.btnModifierPrix.Name = "btnModifierPrix";
            this.btnModifierPrix.Size = new System.Drawing.Size(75, 23);
            this.btnModifierPrix.TabIndex = 7;
            this.btnModifierPrix.Text = "Modifier prix";
            this.btnModifierPrix.UseVisualStyleBackColor = true;
            // 
            // FLivre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 238);
            this.Controls.Add(this.btnModifierPrix);
            this.Controls.Add(this.btnHausseAnnuelle);
            this.Controls.Add(this.tbPrixTTC);
            this.Controls.Add(this.tbPrix);
            this.Controls.Add(this.tbTitre);
            this.Controls.Add(this.lblPrixTTC);
            this.Controls.Add(this.lblPrix);
            this.Controls.Add(this.lblTitre);
            this.Name = "FLivre";
            this.Text = "Livre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblPrix;
        private System.Windows.Forms.Label lblPrixTTC;
        private System.Windows.Forms.TextBox tbTitre;
        private System.Windows.Forms.TextBox tbPrix;
        private System.Windows.Forms.TextBox tbPrixTTC;
        private System.Windows.Forms.Button btnHausseAnnuelle;
        private System.Windows.Forms.Button btnModifierPrix;
    }
}