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
    public partial class frmMenuUsuario : Form
    {
        public frmMenuUsuario()
        {
            InitializeComponent();

        }

        private void imgSair_Click(object sender, EventArgs e)
        {

            Application.Exit();

        }

        private void menuUsuario_Load(object sender, EventArgs e)
        {

            // APARECER NOME E SALDO DO USUARIO NO MENU DO USUARIO 

            lblSaldoDisponível.Text = frmLogin.saldo;
            lblNomeUsuario.Text = frmLogin.nome;


        }

        private void imgSolicitacoesUsuario_Click(object sender, EventArgs e)
        {
            var solicitarImpressao = new frmSolicitarImpressao();
            solicitarImpressao.ShowDialog();
        }

        private void imgSaldoUsuario_Click(object sender, EventArgs e)
        {
            var comprarSaldo = new frmAdicionarSaldo();
            comprarSaldo.ShowDialog();
        }

        private void lblSolicitacoesUsuario_Click(object sender, EventArgs e)
        {
            var comprarSaldo = new frmAdicionarSaldo();
            comprarSaldo.ShowDialog();
        }

        private void imgCadastrar_Click(object sender, EventArgs e)
        {
            var alterarCadastro = new frmAlterarCadastro();
            alterarCadastro.ShowDialog();
        }

        private void lblCadastrar_Click(object sender, EventArgs e)
        {
            var alterarCadastro = new frmAlterarCadastro();
            alterarCadastro.ShowDialog();
        }

        private void frmMenuUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void lblSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void alterarCadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var alterarCadastro = new frmAlterarCadastro();
            alterarCadastro.ShowDialog();
        }

        private void solicitarImpressãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var solicitarImpressao = new frmSolicitarImpressao();
            solicitarImpressao.ShowDialog();
        }

        private void comprarSaldoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var comprarSaldo = new frmAdicionarSaldo();
            comprarSaldo.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void solicitarImpressãoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var solicitarImpressao = new frmSolicitarImpressao();
            solicitarImpressao.ShowDialog();
        }

        private void comprarSaldoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var comprarSaldo = new frmAdicionarSaldo();
            comprarSaldo.ShowDialog();
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
