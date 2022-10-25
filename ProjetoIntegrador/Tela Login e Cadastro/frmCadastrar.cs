using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoIntegrador
{

    // TELA DE CADASTRO NO MENU DE LOGIN
    public partial class frmCadastrar : Form
    {
        public frmCadastrar()
        {
            InitializeComponent();
        }
        // CONEXÃO BANCO

        SqlConnection sqlcon = null;
        private string strCon = "Data Source=DESKTOP-SO696E1\\SQLEXPRESS;Initial Catalog=ProjetoIntegradorDB;Integrated Security=True";
        private string strSql = string.Empty;


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

        private void checkBoxVisualizarSenha_CheckedChanged(object sender, EventArgs e)

        // ATIVAR / DESATIVAR VISUALIZAR SENHA
        {
            if (checkBoxVisualizarSenha.Checked)
            {
                txtSenha.UseSystemPasswordChar = false;
            }
            else
            {
                txtSenha.UseSystemPasswordChar = true;
            }
        }

        private void checkBoxVisualizarSenhaConfirmacao_CheckedChanged(object sender, EventArgs e)

        // ATIVAR / DESATIVAR VISUALIZAR SENHA (CONFIRMAÇAO)
        {
            if (checkBoxVisualizarSenhaConfirmacao.Checked)
            {
                txtSenhaConfirmacao.UseSystemPasswordChar = false;
            }
            else
            {
                txtSenhaConfirmacao.UseSystemPasswordChar = true;
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            // VALIDAÇÕES NO CADASTRO 

            //VALIDAR NOME

            if (txtNome.Text == "" || txtNome.Text.Length < 2 || txtNome.Text.Length > 100)
            {
                MessageBox.Show("Por favor, informe um nome válido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //VALIDAR CPF

            else if (txtCPF.Text == "" || txtCPF.Text.Length < 11 || txtCPF.Text.Length > 15)
            {
                MessageBox.Show("Por favor, informe um CPF válido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // VALIDAR EMAIL
            else if (txtEmail.Text == "" || txtEmail.Text.Length < 5 || txtEmail.Text.Length > 100)
            {
                MessageBox.Show("Por favor, informe um e-mail válido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            // VALIDAR CONFIRMAÇÃO SENHA

            else if (txtSenha.Text != txtSenhaConfirmacao.Text)
            {
                MessageBox.Show("As senhas não são correspondentes, por favor insira novamente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSenha.Focus();
                txtSenha.Clear();
                txtSenhaConfirmacao.Clear();

            }

            // SE VALIDAR TODOS OS CAMPOS ACIMA, IRÁ CADASTRAR NO BANCO:

            else
            {
                int saldo = 0;

                strSql = "USE ProjetoIntegradorDB";
                strSql = "INSERT INTO Usuario (nome, cpf, email, telefone, senha, saldoDisponivel) VALUES (@Nome,@Cpf,@Email,@Telefone,@Senha,@Saldo)";

                sqlcon = new SqlConnection(strCon);
                SqlCommand comando = new SqlCommand(strSql, sqlcon);

                comando.Parameters.Add("@Nome", SqlDbType.VarChar).Value = txtNome.Text;
                comando.Parameters.Add("@Cpf", SqlDbType.VarChar).Value = txtCPF.Text;
                comando.Parameters.Add("@Email", SqlDbType.VarChar).Value = txtEmail.Text;
                comando.Parameters.Add("@Telefone", SqlDbType.VarChar).Value = txtTelefone.Text;
                comando.Parameters.Add("@Senha", SqlDbType.VarChar).Value = txtSenha.Text;
                comando.Parameters.Add("@Saldo", SqlDbType.Int).Value = saldo;
                try
                {
                    sqlcon.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Cadastro efetuado com sucesso.");
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                finally
                {
                    sqlcon.Close();
                }

                // APÓS CADASTRO, LIMPA OS CAMPOS

                txtNome.Clear();
                txtCPF.Clear();
                txtEmail.Clear();
                txtTelefone.Clear();
                txtSenha.Clear();
                txtSenhaConfirmacao.Clear();
            }
        }

        private void frmCadastrar_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
            {
                Application.Exit();
            }
        }
    }
}


