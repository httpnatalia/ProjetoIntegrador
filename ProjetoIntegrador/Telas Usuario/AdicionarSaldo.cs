using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoIntegrador.Telas_Usuario
{
    public partial class frmAdicionarSaldo : Form
    {
        public frmAdicionarSaldo()
        {
            InitializeComponent();
        }

        public void AbrirLink(string endereco)
        {
            System.Diagnostics.Process.Start(endereco);
        }

        // COMPRAR 25 IMPRESSOES
        private void btnComprar25_Click(object sender, EventArgs e)
        {
            AbrirLink("https://www.paypal.com/invoice/s/pay/INV2-FCV3-TLCC-UU9G-YR2W");
        }

        private void imgComprar25_Click(object sender, EventArgs e)
        {
            AbrirLink("https://www.paypal.com/invoice/s/pay/INV2-FCV3-TLCC-UU9G-YR2W");
        }


        // COMPRAR 50 IMPRESSOES
        private void btnComprar50_Click(object sender, EventArgs e)
        {
            AbrirLink("https://www.paypal.com/invoice/s/details/INV2-WK3K-JV53-FU83-4F45");
        }

        private void imgComprar50_Click(object sender, EventArgs e)
        {
            AbrirLink("https://www.paypal.com/invoice/s/details/INV2-WK3K-JV53-FU83-4F45");
        }

        
    }
}
