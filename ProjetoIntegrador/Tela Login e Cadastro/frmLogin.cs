using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjetoIntegrador
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();

        }
        // CONEXÃO BANCO
        SqlConnection sqlcon = null;
        private string strCon = "Data Source=DESKTOP-SO696E1\\SQLEXPRESS;Initial Catalog=ProjetoIntegradorDB;Integrated Security=True";
        private string strSql = string.Empty;

        public static string email;
        public static string cpf;
        public static string nome;
        public static string telefone;
        public static string saldo;
        public static string senha;

        public void FazerLogin()
        {
            string emailLogin = txtEmail.Text;
            string senhaLogin = txtSenha.Text;
            sqlcon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlcon);
            string query = "SELECT * FROM Usuario WHERE email ='" + emailLogin + "' AND senha = '" + senhaLogin + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, sqlcon);
            DataTable dt = new DataTable();
            da.Fill(dt);


            if (dt.Rows.Count == 1)
            {
                email = dt.Rows[0]["email"].ToString();
                nome = dt.Rows[0]["nome"].ToString();
                cpf = dt.Rows[0]["cpf"].ToString();
                telefone = dt.Rows[0]["telefone"].ToString();
                senha = dt.Rows[0]["senha"].ToString();
                saldo = dt.Rows[0]["saldoDisponivel"].ToString();
                this.Visible = false;
                var menuUsuario = new frmMenuUsuario();
                menuUsuario.Show();


            }

            // LOGIN DO ADM
            else if (txtEmail.Text.Equals("admin") && txtSenha.Text.Equals("123"))
            {

                var menuAdmin = new frmMenuAdmin();
                menuAdmin.Show();
                this.Visible = false;
            }

            else
            {
                MessageBox.Show("Usuário ou senha incorretos. Por favor, tente novamente.", "Não foi possível conectar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                txtSenha.Text = "";
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        public void btnEntrar_Click(object sender, EventArgs e)
        {
            FazerLogin();
        }


        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            var cadastrar = new frmCadastrar();
            cadastrar.Show();

        }

        private void checkBoxVisualizarSenha_CheckedChanged(object sender, EventArgs e)
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

        private void checkBoxVisualizarSenha_CheckedChanged_1(object sender, EventArgs e)
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

        private void btnCadastrar_Click_1(object sender, EventArgs e)
        {
            var cadastro = new frmCadastrar();
            cadastro.ShowDialog();


        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}

