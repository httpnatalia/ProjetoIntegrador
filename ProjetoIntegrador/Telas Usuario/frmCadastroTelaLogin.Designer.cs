
namespace ProjetoIntegrador
{
    partial class frmCadastroTelaLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroTelaLogin));
            this.groupBoxCadastro = new System.Windows.Forms.GroupBox();
            this.checkBoxVisualizarSenhaConfirmacao = new System.Windows.Forms.CheckBox();
            this.checkBoxVisualizarSenha = new System.Windows.Forms.CheckBox();
            this.txtSenhaConfirmacao = new System.Windows.Forms.TextBox();
            this.lblConfirmeSenha = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblSenhaTemporaria = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.groupBoxCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCadastro
            // 
            this.groupBoxCadastro.Controls.Add(this.txtTelefone);
            this.groupBoxCadastro.Controls.Add(this.checkBoxVisualizarSenhaConfirmacao);
            this.groupBoxCadastro.Controls.Add(this.checkBoxVisualizarSenha);
            this.groupBoxCadastro.Controls.Add(this.txtSenhaConfirmacao);
            this.groupBoxCadastro.Controls.Add(this.lblConfirmeSenha);
            this.groupBoxCadastro.Controls.Add(this.txtCPF);
            this.groupBoxCadastro.Controls.Add(this.btnCadastrar);
            this.groupBoxCadastro.Controls.Add(this.txtSenha);
            this.groupBoxCadastro.Controls.Add(this.lblSenhaTemporaria);
            this.groupBoxCadastro.Controls.Add(this.lblTelefone);
            this.groupBoxCadastro.Controls.Add(this.txtNome);
            this.groupBoxCadastro.Controls.Add(this.lblNome);
            this.groupBoxCadastro.Controls.Add(this.lblCPF);
            this.groupBoxCadastro.Controls.Add(this.txtEmail);
            this.groupBoxCadastro.Controls.Add(this.lblEmail);
            this.groupBoxCadastro.Location = new System.Drawing.Point(12, 13);
            this.groupBoxCadastro.Name = "groupBoxCadastro";
            this.groupBoxCadastro.Size = new System.Drawing.Size(405, 419);
            this.groupBoxCadastro.TabIndex = 0;
            this.groupBoxCadastro.TabStop = false;
            this.groupBoxCadastro.Text = "Cadastro";
            // 
            // checkBoxVisualizarSenhaConfirmacao
            // 
            this.checkBoxVisualizarSenhaConfirmacao.AutoSize = true;
            this.checkBoxVisualizarSenhaConfirmacao.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkBoxVisualizarSenhaConfirmacao.Location = new System.Drawing.Point(277, 344);
            this.checkBoxVisualizarSenhaConfirmacao.Name = "checkBoxVisualizarSenhaConfirmacao";
            this.checkBoxVisualizarSenhaConfirmacao.Size = new System.Drawing.Size(104, 17);
            this.checkBoxVisualizarSenhaConfirmacao.TabIndex = 14;
            this.checkBoxVisualizarSenhaConfirmacao.Text = "Visualizar Senha";
            this.checkBoxVisualizarSenhaConfirmacao.UseVisualStyleBackColor = true;
            this.checkBoxVisualizarSenhaConfirmacao.CheckedChanged += new System.EventHandler(this.checkBoxVisualizarSenhaConfirmacao_CheckedChanged);
            // 
            // checkBoxVisualizarSenha
            // 
            this.checkBoxVisualizarSenha.AutoSize = true;
            this.checkBoxVisualizarSenha.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkBoxVisualizarSenha.Location = new System.Drawing.Point(277, 278);
            this.checkBoxVisualizarSenha.Name = "checkBoxVisualizarSenha";
            this.checkBoxVisualizarSenha.Size = new System.Drawing.Size(104, 17);
            this.checkBoxVisualizarSenha.TabIndex = 13;
            this.checkBoxVisualizarSenha.Text = "Visualizar Senha";
            this.checkBoxVisualizarSenha.UseVisualStyleBackColor = true;
            this.checkBoxVisualizarSenha.CheckedChanged += new System.EventHandler(this.checkBoxVisualizarSenha_CheckedChanged);
            // 
            // txtSenhaConfirmacao
            // 
            this.txtSenhaConfirmacao.Location = new System.Drawing.Point(20, 318);
            this.txtSenhaConfirmacao.MaxLength = 16;
            this.txtSenhaConfirmacao.Name = "txtSenhaConfirmacao";
            this.txtSenhaConfirmacao.Size = new System.Drawing.Size(361, 20);
            this.txtSenhaConfirmacao.TabIndex = 12;
            this.txtSenhaConfirmacao.UseSystemPasswordChar = true;
            // 
            // lblConfirmeSenha
            // 
            this.lblConfirmeSenha.AutoSize = true;
            this.lblConfirmeSenha.Location = new System.Drawing.Point(17, 302);
            this.lblConfirmeSenha.Name = "lblConfirmeSenha";
            this.lblConfirmeSenha.Size = new System.Drawing.Size(89, 13);
            this.lblConfirmeSenha.TabIndex = 11;
            this.lblConfirmeSenha.Text = "Confirme a senha";
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(20, 99);
            this.txtCPF.MaxLength = 11;
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(361, 20);
            this.txtCPF.TabIndex = 2;
            this.txtCPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCPF_KeyPress);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(158, 375);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 12;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(21, 255);
            this.txtSenha.MaxLength = 16;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(361, 20);
            this.txtSenha.TabIndex = 9;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // lblSenhaTemporaria
            // 
            this.lblSenhaTemporaria.AutoSize = true;
            this.lblSenhaTemporaria.Location = new System.Drawing.Point(18, 240);
            this.lblSenhaTemporaria.Name = "lblSenhaTemporaria";
            this.lblSenhaTemporaria.Size = new System.Drawing.Size(38, 13);
            this.lblSenhaTemporaria.TabIndex = 8;
            this.lblSenhaTemporaria.Text = "Senha";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(18, 185);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(49, 13);
            this.lblTelefone.TabIndex = 6;
            this.lblTelefone.Text = "Telefone";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(21, 50);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(361, 20);
            this.txtNome.TabIndex = 1;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(18, 34);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(18, 82);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(27, 13);
            this.lblCPF.TabIndex = 2;
            this.lblCPF.Text = "CPF";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(21, 149);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(361, 20);
            this.txtEmail.TabIndex = 5;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(18, 132);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(109, 13);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "E-mail (Usuário Login)";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(21, 200);
            this.txtTelefone.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelefone.Mask = "(00)00000\\-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(360, 20);
            this.txtTelefone.TabIndex = 15;
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 444);
            this.Controls.Add(this.groupBoxCadastro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Senac | Impressões";
            this.groupBoxCadastro.ResumeLayout(false);
            this.groupBoxCadastro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCadastro;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblSenhaTemporaria;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Label lblConfirmeSenha;
        private System.Windows.Forms.TextBox txtSenhaConfirmacao;
        private System.Windows.Forms.CheckBox checkBoxVisualizarSenhaConfirmacao;
        private System.Windows.Forms.CheckBox checkBoxVisualizarSenha;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
    }
}