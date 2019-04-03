using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModelLivre;

namespace tp_evenement_objet
{
    public partial class FMain : Form
    {
        public FMain()
        {
            InitializeComponent();
            btnNouveauLivre.Click += BtnNouveauLivre_Click;

        }

        private void BtnNouveauLivre_Click(object sender, EventArgs e)
        {
            Livre unLivre = new Livre("Loup", (decimal)60, (decimal)15);
            FLivre flivre = new FLivre(unLivre);
            flivre.Show();
            FHistorique fhistorique = new FHistorique(unLivre);
            fhistorique.Show();
            this.Hide();
        }
    }
}
