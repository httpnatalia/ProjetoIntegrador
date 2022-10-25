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
    public partial class frmSaldo : Form
    {
        public frmSaldo()
        {
            InitializeComponent();
        }

        private void fmUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'projetoIntegradorDBDataSet.Usuario'. Você pode movê-la ou removê-la conforme necessário.
            this.usuarioTableAdapter.Fill(this.projetoIntegradorDBDataSet.Usuario);

        }

        private void button2_Click(object sender, EventArgs e)

        {
            // BOTAO NAVEGAR NA TABELA DO BANCO (ANTERIOR)
            usuarioBindingSource.MovePrevious();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {

            // BOTAO NAVEGAR NA TABELA DO BANCO (PRÓXIMO)
            usuarioBindingSource.MoveNext();

        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {

            //BOTAO DELETAR USUARIO DO BANCO 

            DialogResult retorno = MessageBox.Show("Tem certeza que deseja DELETAR? Todos os Dados serão perdidos", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (retorno == DialogResult.Yes)
            {
                usuarioBindingSource.RemoveCurrent();
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            // BOTAO DE CRIAR NOVA LINHA NO BANCO (UseGridView)

            usuarioBindingSource.AddNew();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //BOTAO DE SALVAR ALTERAÇÕES

            usuarioBindingSource.EndEdit();
            usuarioTableAdapter.Update(projetoIntegradorDBDataSet);
            MessageBox.Show("Alteração efetuada com sucesso.");

            try
            {
                // DEIXAR VAZIO

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void txtCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            // PERMITIR SÓ NÚMEROS NO INPUT 
            Program.IntNumber(e);
        }

        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            // PERMITIR SÓ NÚMEROS NO INPUT 
            Program.IntNumber(e);
        }

        private void txtCPF_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            // PERMITIR SÓ NÚMEROS NO INPUT 
            Program.IntNumber(e);
        }

        private void btn25_Click(object sender, EventArgs e)
        {

            //BOTAO ADICIONAR 25 DE SALDO 

            DialogResult retorno = MessageBox.Show("O usuário realizou o pagamento? A alteração será efetuada somente após clicar em 'SALVAR ALTERAÇÕES'", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (retorno == DialogResult.Yes)
            {
                int ficha25 = 25;
                int saldoAtual;
                int novoSaldo;
                saldoAtual = Convert.ToInt32(txtSaldoDisponivel.Text);
                novoSaldo = saldoAtual + ficha25;
                txtSaldoDisponivel.Clear();
                txtSaldoDisponivel.Text = novoSaldo.ToString();
            }
        }

        private void btn50_Click(object sender, EventArgs e)

        // BOTAO ADICIONAR 50 DE SALDO 
        {
            DialogResult retorno = MessageBox.Show("O usuário realizou o pagamento? A alteração será efetuada somente após clicar em 'SALVAR ALTERAÇÕES'", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (retorno == DialogResult.Yes)
            {
                int ficha25 = 50;
                int saldoAtual;
                int novoSaldo;
                saldoAtual = Convert.ToInt32(txtSaldoDisponivel.Text);
                novoSaldo = saldoAtual + ficha25;
                txtSaldoDisponivel.Clear();
                txtSaldoDisponivel.Text = novoSaldo.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // CASO TENHA SALDO 

            DialogResult retorno = MessageBox.Show("Tem certeza que quer diminuir o saldo do usuário? A alteração será efetuada somente após clicar em 'SALVAR ALTERAÇÕES'", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (retorno == DialogResult.Yes)
            {
                int saldoDisponivel;
                int removerSaldo;
                removerSaldo = Convert.ToInt32(txtRemoverSaldo.Text);
                saldoDisponivel = Convert.ToInt32(txtSaldoDisponivel.Text);
                saldoDisponivel = saldoDisponivel - removerSaldo;
                txtRemoverSaldo.Clear();
                txtSaldoDisponivel.Text = saldoDisponivel.ToString();

                // SE O NÚMERO DE IMPRESSÃO FOR MAIR O QUE O SAQUE

                if (saldoDisponivel < 0)
                {
                    txtRemoverSaldo.Clear();
                    MessageBox.Show("Não é possível realizar a impressão, pois não há saldo suficiente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Visible = false;
                    var menuSaldo = new frmSaldo();
                    menuSaldo.ShowDialog();

                }

            }

        }

        private void frmSaldo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Visible = false;
            }

        }

    }
}



