namespace ModelLivre
{
    public class changementPrixEventArgs : System.EventArgs
    {
        private decimal ancienPrix, nouveauPrix, nouveauPrixTTC,hausse;

        public changementPrixEventArgs(decimal ancienPrix, decimal nouveauPrix, decimal nouveauPrixTTC,decimal hausse)
        {
            this.ancienPrix = ancienPrix;
            this.nouveauPrix = nouveauPrix;
            this.nouveauPrixTTC = nouveauPrixTTC;
            this.hausse = hausse;
        }

        public decimal AncienPrix { get => ancienPrix; set => ancienPrix = value; }
        public decimal NouveauPrix { get => nouveauPrix; set => nouveauPrix = value; }
        public decimal NouveauPrixTTC { get => nouveauPrixTTC; set => nouveauPrixTTC = value; }
        public decimal Hausse { get => hausse; set => hausse = value; }
    }
}