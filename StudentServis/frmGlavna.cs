using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentServis
{
    public partial class frmGlavna : Form
    {
        private frmStudenti formaStudenti;
        private frmFakulteti formaFakulteti;
        private frmPartneri formaPartneri;
        private frmRacuni formaRacuni;

        public frmGlavna()
        {
            InitializeComponent();
        }

        private void btnStudenti_Click(object sender, EventArgs e)
        {
            formaStudenti = new frmStudenti();
            formaStudenti.Show();
        }

        private void btnFakulteti_Click(object sender, EventArgs e)
        {
            formaFakulteti = new frmFakulteti();
            formaFakulteti.Show();
        }

        private void btnPartneri_Click(object sender, EventArgs e)
        {
            formaPartneri = new frmPartneri();
            formaPartneri.Show();
        }

        private void btnRacuni_Click(object sender, EventArgs e)
        {
            formaRacuni = new frmRacuni();
            formaRacuni.Show();
        }
    }
}
