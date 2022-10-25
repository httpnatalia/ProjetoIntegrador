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
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void fmUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'projetoIntegradorDBDataSet.Usuario'. Você pode movê-la ou removê-la conforme necessário.
            this.usuarioTableAdapter.Fill(this.projetoIntegradorDBDataSet.Usuario);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            usuarioBindingSource.MovePrevious();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            usuarioBindingSource.MoveNext();

        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            DialogResult retorno = MessageBox.Show("Todos os dados do usuário serão perdidos, tem certeza?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (retorno == DialogResult.Yes)
            {
                usuarioBindingSource.RemoveCurrent();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            //VALIDAR NOME

            if (txtNome.Text == "" || txtNome.Text.Length < 2 || txtNome.Text.Length > 100)
            {
                MessageBox.Show("Por favor, informe um nome válido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // VALIDAR EMAIL
            else if (txtEmail.Text == "" || txtEmail.Text.Length < 5 || txtEmail.Text.Length > 100)
            {
                MessageBox.Show("Por favor, informe um e-mail válido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //VALIDAR CPF

            else if (txtCPF.Text == "" || txtCPF.Text.Length < 11 || txtCPF.Text.Length > 15)
            {
                MessageBox.Show("Por favor, informe um CPF válido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // VALIDAR TELEFONE
            else if (txtTelefone.Text == "" || txtTelefone.Text.Length < 10 || txtTelefone.Text.Length > 15)
            {
                MessageBox.Show("Por favor, informe um telefone válido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //VALIDAR SENHA
            else if (txtSenha.Text == "" || txtSenha.Text.Length < 5 || txtSenha.Text.Length > 16)
            {
                MessageBox.Show("Por favor, informe uma senha válida. A senha deve ter no mínimo 5 caractéres.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            // SE AS SENHAS NÃO FOREM IGUAIS 
            else if (txtSenha.Text != txtSenhaConfirmacao.Text)
            {
                MessageBox.Show("As senhas não são correspondentes, por favor insira novamente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSenha.Focus();
                txtSenha.Clear();
                txtSenhaConfirmacao.Clear();
            }




            else
            {
                // SE VALIDAR TUDO, CONECTA NO BANCO E SALVA (DataGridView)
                usuarioBindingSource.EndEdit();
                usuarioTableAdapter.Update(projetoIntegradorDBDataSet);
                MessageBox.Show("Alteração efetuada com sucesso.");


            }
            try
            {


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void txtCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            // SÓ PERMITIR NÚMEROS NO INPUT
            Program.IntNumber(e);
        }


        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            // SÓ PERMITIR NÚMEROS NO INPUT
            Program.IntNumber(e);
        }


        private void txtCPF_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            // SÓ PERMITIR NÚMEROS NO INPUT
            Program.IntNumber(e);
        }

        private void btnNovo_Click(object sender, EventArgs e)

        // QUANDO FAZ UM NOVO REGISTRO, O SALDO INICIAL FICA 0
        {
            int saldoInicial = 0;
            usuarioBindingSource.AddNew();
            txtSaldoDisponivel.Text = saldoInicial.ToString();

        }

        private void dataGridUsuario_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["saldoDisponivel"].Value = 0;
        }

      
        private void frmUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Visible = false;
            }

        }
    }
}