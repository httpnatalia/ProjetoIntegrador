
namespace ProjetoIntegrador
{
    partial class frmLogin
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.gBoxLogin = new System.Windows.Forms.GroupBox();
            this.checkBoxVisualizarSenha = new System.Windows.Forms.CheckBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.logoSenacInicio = new System.Windows.Forms.PictureBox();
            this.gBoxLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoSenacInicio)).BeginInit();
            this.SuspendLayout();
            // 
            // gBoxLogin
            // 
            this.gBoxLogin.Controls.Add(this.checkBoxVisualizarSenha);
            this.gBoxLogin.Controls.Add(this.btnCadastrar);
            this.gBoxLogin.Controls.Add(this.btnCancelar);
            this.gBoxLogin.Controls.Add(this.btnEntrar);
            this.gBoxLogin.Controls.Add(this.txtSenha);
            this.gBoxLogin.Controls.Add(this.lblSenha);
            this.gBoxLogin.Controls.Add(this.txtEmail);
            this.gBoxLogin.Controls.Add(this.lblEmail);
            resources.ApplyResources(this.gBoxLogin, "gBoxLogin");
            this.gBoxLogin.Name = "gBoxLogin";
            this.gBoxLogin.TabStop = false;
            // 
            // checkBoxVisualizarSenha
            // 
            resources.ApplyResources(this.checkBoxVisualizarSenha, "checkBoxVisualizarSenha");
            this.checkBoxVisualizarSenha.Name = "checkBoxVisualizarSenha";
            this.checkBoxVisualizarSenha.UseVisualStyleBackColor = true;
            this.checkBoxVisualizarSenha.CheckedChanged += new System.EventHandler(this.checkBoxVisualizarSenha_CheckedChanged_1);
            // 
            // btnCadastrar
            // 
            resources.ApplyResources(this.btnCadastrar, "btnCadastrar");
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click_1);
            // 
            // btnCancelar
            // 
            resources.ApplyResources(this.btnCancelar, "btnCancelar");
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEntrar
            // 
            resources.ApplyResources(this.btnEntrar, "btnEntrar");
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // txtSenha
            // 
            resources.ApplyResources(this.txtSenha, "txtSenha");
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // lblSenha
            // 
            resources.ApplyResources(this.lblSenha, "lblSenha");
            this.lblSenha.Name = "lblSenha";
            // 
            // txtEmail
            // 
            resources.ApplyResources(this.txtEmail, "txtEmail");
            this.txtEmail.Name = "txtEmail";
            // 
            // lblEmail
            // 
            resources.ApplyResources(this.lblEmail, "lblEmail");
            this.lblEmail.Name = "lblEmail";
            // 
            // logoSenacInicio
            // 
            resources.ApplyResources(this.logoSenacInicio, "logoSenacInicio");
            this.logoSenacInicio.Name = "logoSenacInicio";
            this.logoSenacInicio.TabStop = false;
            // 
            // frmLogin
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.logoSenacInicio);
            this.Controls.Add(this.gBoxLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLogin_FormClosing);
            this.gBoxLogin.ResumeLayout(false);
            this.gBoxLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoSenacInicio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxLogin;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.PictureBox logoSenacInicio;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.CheckBox checkBoxVisualizarSenha;
    }
}

