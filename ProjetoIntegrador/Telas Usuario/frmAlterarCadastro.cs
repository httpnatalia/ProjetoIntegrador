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
    public partial class frmAlterarCadastro : Form
    {
        public frmAlterarCadastro()
        {
            InitializeComponent();
            txtNome.Text = frmLogin.nome;
            txtCPF.Text = frmLogin.cpf;
            txtSenha.Text = frmLogin.senha;
            txtTelefone.Text = frmLogin.telefone;
            txtEmail.Text = frmLogin.email;
        }
        // CONEXÃO BANCO

        SqlConnection sqlcon = null;
        private string strCon = "Data Source=DESKTOP-SO696E1\\SQLEXPRESS;Initial Catalog=ProjetoIntegradorDB;Integrated Security=True";
        private string strSql = string.Empty;

        private void checkBoxVisualizarSenha_CheckedChanged(object sender, EventArgs e)

        // ATIVAR / DESATIVAR VISUALIZAR SENHA
        {
            if (checkBoxVisualizarSenha.Checked)
            {
                txtSenhaNova.UseSystemPasswordChar = false;
            }
            else
            {
                txtSenhaNova.UseSystemPasswordChar = true;
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

            // VALIDAR TELEFONE
            if (txtTelefone.Text == "" || txtTelefone.Text.Length < 10 || txtTelefone.Text.Length > 15)
            {
                MessageBox.Show("Por favor, informe um telefone válido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //VALIDAR SENHA
            else if (txtSenhaNova.Text == "" || txtSenhaNova.Text.Length < 5 || txtSenha.Text.Length > 16)
            {
                MessageBox.Show("Por favor, informe uma senha válida. A senha deve ter no mínimo 5 caractéres.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // VALIDAR CONFIRMAÇÃO SENHA

            else if (txtSenhaNova.Text != txtSenhaConfirmacao.Text)
            {
                MessageBox.Show("As senhas não são correspondentes, por favor insira novamente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSenha.Focus();
                txtSenha.Clear();
                txtSenhaConfirmacao.Clear();

            }

            // VALIDAR SE SENHA ANTIGA É IGUAL A NOVA QUE FOI INSERIDA 
            else if (txtSenha.Text == txtSenhaNova.Text)
            {
                MessageBox.Show("Nova senha não pode ser a mesma que a senha antiga. Por favor, insira novamente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSenha.Focus();
                txtSenha.Clear();
                txtSenhaConfirmacao.Clear();

            }

            // VALIDAR O NÚMERO DE TELEFONE ANTIGO É IGUAL A NOVO QUE FOI INSERIDO
            else if (txtTelefone.Text == txtTelefoneNovo.Text)
            {
                MessageBox.Show("Esse número de telefone já está cadastrado. Por favor, insira outro número.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSenha.Focus();
                txtSenha.Clear();
                txtSenhaConfirmacao.Clear();

            }

            // SE VALIDAR TODOS OS CAMPOS ACIMA, IRÁ CADASTRAR NO BANCO:

            else
            {


                strSql = "USE ProjetoIntegradorDB";
                //strSql = "INSERT INTO Usuario (nome, cpf, email, telefone, senha, saldoDisponivel) VALUES (@Nome,@Cpf,@Email,@Telefone,@Senha,@Saldo)";
                strSql = "UPDATE Usuario SET telefone= @Telefone WHERE email = @Email";
                strSql = "UPDATE Usuario SET senha= @Senha WHERE email = @Email";

                sqlcon = new SqlConnection(strCon);
                SqlCommand comando = new SqlCommand(strSql, sqlcon);

                comando.Parameters.Add("@Nome", SqlDbType.VarChar).Value = txtNome.Text;
                comando.Parameters.Add("@Cpf", SqlDbType.VarChar).Value = txtCPF.Text;
                comando.Parameters.Add("@Email", SqlDbType.VarChar).Value = txtEmail.Text;
                comando.Parameters.Add("@Telefone", SqlDbType.VarChar).Value = txtTelefoneNovo.Text;
                comando.Parameters.Add("@Senha", SqlDbType.VarChar).Value = txtSenhaNova.Text;

                try
                {
                    sqlcon.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Alteração efetuada com sucesso.");


                    txtSenha.Text = txtSenhaNova.Text;
                    txtTelefone.Text = txtTelefoneNovo.Text;

                    txtTelefoneNovo.Clear();
                    txtSenhaNova.Clear();
                    txtSenhaConfirmacao.Clear();
                  
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

            }
        }

        private void frmAlterarCadastro_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Visible = false;
            }
        }
    }
}

