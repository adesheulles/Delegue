using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLivre
{
    public delegate void ChangementPrixPrototype(object o, changementPrixEventArgs e);
    public class Livre
    {
        private string titre;
        private decimal prixHt;
        private decimal tauxTva;

        public Livre(string titre, decimal prixHt, decimal tauxTva)
        {
            this.titre = titre;
            this.prixHt = prixHt;
            this.tauxTva = tauxTva;
        }
        public void HausseAnnuelle()
        {
            decimal ancienPrix = this.prixHt;
            prixHt = prixHt * (decimal)1.1;
            onChangementPrix(ancienPrix, prixHt, this.PrixTTC,(decimal)10);
        }

        public event ChangementPrixPrototype ChangementPrix;
        private void onChangementPrix(decimal ancienPrix, decimal nouveauPrix, decimal nouveauPrixTTC,decimal hausse)
        {
            if (ChangementPrix != null)
            {
                ChangementPrix(this, new changementPrixEventArgs(ancienPrix, nouveauPrix, nouveauPrixTTC,hausse));
            }
        }
        public decimal PrixTTC
        {
            get { return (1 + this.tauxTva / 100) * this.prixHt; }
        }
        public override string ToString()
        {
            return this.titre;
        }
        public string Titre { get => titre; set => titre = value; }
        public decimal PrixHt
        {
            get => prixHt; set
            {
                decimal ancienPrix = prixHt;
                prixHt = value;
                decimal hausse = ((prixHt-ancienPrix)/ancienPrix)*100;
                onChangementPrix(ancienPrix, value, this.PrixTTC,hausse);
            }
        }
        public decimal TauxTva { get => tauxTva; set => tauxTva = value; }

    }
}
