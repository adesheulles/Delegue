namespace tp_evenement_objet
{
    partial class FHistorique
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
            this.lbHistorique = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbHistorique
            // 
            this.lbHistorique.FormattingEnabled = true;
            this.lbHistorique.Location = new System.Drawing.Point(13, 25);
            this.lbHistorique.Name = "lbHistorique";
            this.lbHistorique.Size = new System.Drawing.Size(269, 225);
            this.lbHistorique.TabIndex = 0;
            // 
            // FHistorique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 263);
            this.Controls.Add(this.lbHistorique);
            this.Name = "FHistorique";
            this.Text = "FHistorique";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbHistorique;
    }
}