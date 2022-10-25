using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoIntegrador
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

        // CLICAR BOTAO COMPRAR 25
        private void btnComprar25_Click_1(object sender, EventArgs e)
        {
            AbrirLink("https://www.paypal.com/invoice/s/pay/INV2-FCV3-TLCC-UU9G-YR2W");
        }

        // CLICAR IMAGEM COMPRAR 25
        private void imgComprar25_Click_1(object sender, EventArgs e)
        {
            AbrirLink("https://www.paypal.com/invoice/s/pay/INV2-FCV3-TLCC-UU9G-YR2W");
        }

        // CLICAR BOTAO COMPRAR 50
        private void btnCompar50_Click(object sender, EventArgs e)
        {
            AbrirLink("https://www.paypal.com/invoice/p/#WK3KJV53FU834F45");
        }

        // CLICAR IMAGEM COMPRAR 50
        private void imgComprar50_Click(object sender, EventArgs e)
        {
            AbrirLink("https://www.paypal.com/invoice/p/#WK3KJV53FU834F45");
        }

    }
}
