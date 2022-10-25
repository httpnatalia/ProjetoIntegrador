
namespace ProjetoIntegrador
{
    partial class frmAlterarCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlterarCadastro));
            this.groupBoxCadastro = new System.Windows.Forms.GroupBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblSenhaTemporaria = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.checkBoxVisualizarSenhaConfirmacao = new System.Windows.Forms.CheckBox();
            this.checkBoxVisualizarSenha = new System.Windows.Forms.CheckBox();
            this.txtSenhaConfirmacao = new System.Windows.Forms.TextBox();
            this.lblConfirmeSenha = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtTelefoneNovo = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSenhaNova = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxCadastro.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCadastro
            // 
            this.groupBoxCadastro.Controls.Add(this.txtTelefone);
            this.groupBoxCadastro.Controls.Add(this.txtCPF);
            this.groupBoxCadastro.Controls.Add(this.lblTelefone);
            this.groupBoxCadastro.Controls.Add(this.txtNome);
            this.groupBoxCadastro.Controls.Add(this.lblNome);
            this.groupBoxCadastro.Controls.Add(this.lblCPF);
            this.groupBoxCadastro.Controls.Add(this.lblSenhaTemporaria);
            this.groupBoxCadastro.Controls.Add(this.txtEmail);
            this.groupBoxCadastro.Controls.Add(this.lblEmail);
            this.groupBoxCadastro.Controls.Add(this.txtSenha);
            this.groupBoxCadastro.Location = new System.Drawing.Point(12, 13);
            this.groupBoxCadastro.Name = "groupBoxCadastro";
            this.groupBoxCadastro.Size = new System.Drawing.Size(405, 295);
            this.groupBoxCadastro.TabIndex = 0;
            this.groupBoxCadastro.TabStop = false;
            this.groupBoxCadastro.Text = "Suas informações";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Enabled = false;
            this.txtTelefone.Location = new System.Drawing.Point(21, 200);
            this.txtTelefone.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelefone.Mask = "(00)00000\\-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.ReadOnly = true;
            this.txtTelefone.Size = new System.Drawing.Size(360, 20);
            this.txtTelefone.TabIndex = 15;
            // 
            // txtCPF
            // 
            this.txtCPF.Enabled = false;
            this.txtCPF.Location = new System.Drawing.Point(20, 99);
            this.txtCPF.MaxLength = 11;
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.ReadOnly = true;
            this.txtCPF.Size = new System.Drawing.Size(361, 20);
            this.txtCPF.TabIndex = 2;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(18, 185);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(75, 13);
            this.lblTelefone.TabIndex = 6;
            this.lblTelefone.Text = "Telefone atual";
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(21, 50);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
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
            // lblSenhaTemporaria
            // 
            this.lblSenhaTemporaria.AutoSize = true;
            this.lblSenhaTemporaria.Location = new System.Drawing.Point(18, 237);
            this.lblSenhaTemporaria.Name = "lblSenhaTemporaria";
            this.lblSenhaTemporaria.Size = new System.Drawing.Size(38, 13);
            this.lblSenhaTemporaria.TabIndex = 8;
            this.lblSenhaTemporaria.Text = "Senha";
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(21, 149);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
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
            // txtSenha
            // 
            this.txtSenha.Enabled = false;
            this.txtSenha.Location = new System.Drawing.Point(21, 252);
            this.txtSenha.MaxLength = 16;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.ReadOnly = true;
            this.txtSenha.Size = new System.Drawing.Size(361, 20);
            this.txtSenha.TabIndex = 9;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // checkBoxVisualizarSenhaConfirmacao
            // 
            this.checkBoxVisualizarSenhaConfirmacao.AutoSize = true;
            this.checkBoxVisualizarSenhaConfirmacao.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkBoxVisualizarSenhaConfirmacao.Location = new System.Drawing.Point(273, 201);
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
            this.checkBoxVisualizarSenha.Location = new System.Drawing.Point(273, 135);
            this.checkBoxVisualizarSenha.Name = "checkBoxVisualizarSenha";
            this.checkBoxVisualizarSenha.Size = new System.Drawing.Size(104, 17);
            this.checkBoxVisualizarSenha.TabIndex = 13;
            this.checkBoxVisualizarSenha.Text = "Visualizar Senha";
            this.checkBoxVisualizarSenha.UseVisualStyleBackColor = true;
            this.checkBoxVisualizarSenha.CheckedChanged += new System.EventHandler(this.checkBoxVisualizarSenha_CheckedChanged);
            // 
            // txtSenhaConfirmacao
            // 
            this.txtSenhaConfirmacao.Location = new System.Drawing.Point(16, 175);
            this.txtSenhaConfirmacao.MaxLength = 16;
            this.txtSenhaConfirmacao.Name = "txtSenhaConfirmacao";
            this.txtSenhaConfirmacao.Size = new System.Drawing.Size(361, 20);
            this.txtSenhaConfirmacao.TabIndex = 12;
            this.txtSenhaConfirmacao.UseSystemPasswordChar = true;
            // 
            // lblConfirmeSenha
            // 
            this.lblConfirmeSenha.AutoSize = true;
            this.lblConfirmeSenha.Location = new System.Drawing.Point(13, 159);
            this.lblConfirmeSenha.Name = "lblConfirmeSenha";
            this.lblConfirmeSenha.Size = new System.Drawing.Size(89, 13);
            this.lblConfirmeSenha.TabIndex = 11;
            this.lblConfirmeSenha.Text = "Confirme a senha";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(161, 532);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 12;
            this.btnCadastrar.Text = "Alterar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtTelefoneNovo
            // 
            this.txtTelefoneNovo.Location = new System.Drawing.Point(16, 56);
            this.txtTelefoneNovo.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelefoneNovo.Mask = "(00)00000\\-0000";
            this.txtTelefoneNovo.Name = "txtTelefoneNovo";
            this.txtTelefoneNovo.Size = new System.Drawing.Size(360, 20);
            this.txtTelefoneNovo.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Novo Telefone";
            // 
            // txtSenhaNova
            // 
            this.txtSenhaNova.Location = new System.Drawing.Point(17, 109);
            this.txtSenhaNova.MaxLength = 16;
            this.txtSenhaNova.Name = "txtSenhaNova";
            this.txtSenhaNova.Size = new System.Drawing.Size(361, 20);
            this.txtSenhaNova.TabIndex = 19;
            this.txtSenhaNova.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nova Senha";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSenhaNova);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblConfirmeSenha);
            this.groupBox1.Controls.Add(this.txtSenhaConfirmacao);
            this.groupBox1.Controls.Add(this.txtTelefoneNovo);
            this.groupBox1.Controls.Add(this.checkBoxVisualizarSenha);
            this.groupBox1.Controls.Add(this.checkBoxVisualizarSenhaConfirmacao);
            this.groupBox1.Location = new System.Drawing.Point(13, 315);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 279);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alterar informações";
            // 
            // frmAlterarCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 606);
            this.Controls.Add(this.groupBoxCadastro);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAlterarCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Senac | Impressões";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAlterarCadastro_FormClosing);
            this.groupBoxCadastro.ResumeLayout(false);
            this.groupBoxCadastro.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCadastro;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblSenhaTemporaria;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblConfirmeSenha;
        private System.Windows.Forms.CheckBox checkBoxVisualizarSenhaConfirmacao;
        private System.Windows.Forms.CheckBox checkBoxVisualizarSenha;
        public System.Windows.Forms.TextBox txtNome;
        public System.Windows.Forms.TextBox txtEmail;
        public System.Windows.Forms.TextBox txtSenha;
        public System.Windows.Forms.TextBox txtCPF;
        public System.Windows.Forms.TextBox txtSenhaConfirmacao;
        public System.Windows.Forms.MaskedTextBox txtTelefone;
        public System.Windows.Forms.MaskedTextBox txtTelefoneNovo;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtSenhaNova;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}