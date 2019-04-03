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
    public partial class FLivre : Form
    {
        Livre Livre;
        public FLivre(Livre unLivre)
        {
            Livre = unLivre;
            InitializeComponent();
            tbTitre.Text = unLivre.Titre;
            tbPrix.Text = Convert.ToString(unLivre.PrixHt);
            tbPrixTTC.Text = Convert.ToString(unLivre.PrixTTC);
            unLivre.ChangementPrix += UnLivre_ChangementPrix;
            btnModifierPrix.Click += BtnModifierPrix_Click;
            btnHausseAnnuelle.Click += BtnHausseAnnuelle_Click;
        }

        private void BtnHausseAnnuelle_Click(object sender, EventArgs e)
        {
            this.Livre.HausseAnnuelle();
        }

        private void BtnModifierPrix_Click(object sender, EventArgs e)
        {
            this.Livre.PrixHt = Convert.ToDecimal(this.tbPrix.Text);
        }

        private void UnLivre_ChangementPrix(object o, changementPrixEventArgs e)
        {
            this.tbPrix.Text = e.NouveauPrix.ToString();
            this.tbPrixTTC.Text = e.NouveauPrixTTC.ToString();
            FHausse fhausse = new FHausse(Convert.ToInt32(e.Hausse));
            fhausse.Show();
        }
    }
}
