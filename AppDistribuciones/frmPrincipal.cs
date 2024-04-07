using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDistribuciones
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void distribuciónBinomialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBinomial frmBinomial = new frmBinomial();
            frmBinomial.ShowDialog();
        }

        private void distribuciónHipergeométricaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHipergeometrica frmHipergeometrica = new frmHipergeometrica();
            frmHipergeometrica.ShowDialog();
        }

        private void distribuciónDePoissonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPoisson frmPoisson = new frmPoisson();
            frmPoisson.ShowDialog();
        }

        private void modeloMM1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMM1 frmMM1 = new frmMM1();
            frmMM1.ShowDialog();
        }
    }
}
