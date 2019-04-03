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
    public partial class FHistorique : Form
    {
        public FHistorique(Livre unLivre)
        {
            InitializeComponent();
            unLivre.ChangementPrix += UnLivre_ChangementPrix;
        }

        private void UnLivre_ChangementPrix(object o, changementPrixEventArgs e)
        {
            lbHistorique.Items.Add(e.NouveauPrix);
        }
    }
}
