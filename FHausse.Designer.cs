namespace tp_evenement_objet
{
    partial class FHausse
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
            this.lblHausse = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHausse
            // 
            this.lblHausse.AutoSize = true;
            this.lblHausse.Location = new System.Drawing.Point(104, 85);
            this.lblHausse.Name = "lblHausse";
            this.lblHausse.Size = new System.Drawing.Size(35, 13);
            this.lblHausse.TabIndex = 0;
            this.lblHausse.Text = "label1";
            // 
            // FHausse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 190);
            this.Controls.Add(this.lblHausse);
            this.Name = "FHausse";
            this.Text = "taux de hausse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHausse;
    }
}