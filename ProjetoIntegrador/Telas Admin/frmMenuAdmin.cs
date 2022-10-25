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
    public partial class frmMenuAdmin : Form
    {
        public frmMenuAdmin()
        {
            InitializeComponent();
        }

        private void imgCadastrar_Click(object sender, EventArgs e)
        {
            var cadastro = new frmCadastrar();
            cadastro.Show();
        }

        private void imgSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblSair_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void lblCadastrar_Click(object sender, EventArgs e)
        {
            var cadastro = new frmCadastrar();
            cadastro.Show();
        }

        private void imgSaldoUsuario_Click(object sender, EventArgs e)
        {
            var usuarios = new frmUsuario();
            usuarios.ShowDialog();
        }

        private void lblSaldoUsuario_Click(object sender, EventArgs e)
        {
            var usuarios = new frmUsuario();
            usuarios.ShowDialog();
        }

        private void lblSolicitacoesUsuario_Click(object sender, EventArgs e)
        {
            var gerenciarSaldo = new frmSaldo();
            gerenciarSaldo.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var gerenciarSaldo = new frmSaldo();
            gerenciarSaldo.ShowDialog();
        }


        private void gerenciarSaldosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var gerenciarSaldo = new frmSaldo();
            gerenciarSaldo.ShowDialog();
        }

        private void gerenciarUsuáriosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var usuarios = new frmUsuario();
            usuarios.ShowDialog();
        }

        private void sairToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Application.Exit();
           
        }

        private void gerenciarUsuáriosToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            var usuarios = new frmUsuario();
            usuarios.ShowDialog();
        }

        private void gerenciarSaldosToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            var gerenciarSaldo = new frmSaldo();
            gerenciarSaldo.ShowDialog();
        }

        private void frmMenuAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
