
namespace ProjetoIntegrador
{
    partial class frmSaldo
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSaldo));
            this.groupBoxUsuarios = new System.Windows.Forms.GroupBox();
            this.dataGridUsuario = new System.Windows.Forms.DataGridView();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senhaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldoDisponivelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projetoIntegradorDBDataSet = new ProjetoIntegrador.ProjetoIntegradorDBDataSet();
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.usuarioTableAdapter = new ProjetoIntegrador.ProjetoIntegradorDBDataSetTableAdapters.UsuarioTableAdapter();
            this.groupBoxCadastro = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSaldoDisponivel = new System.Windows.Forms.TextBox();
            this.groupBoxSaldo = new System.Windows.Forms.GroupBox();
            this.btn50 = new System.Windows.Forms.Button();
            this.btn25 = new System.Windows.Forms.Button();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRemoverSaldo = new System.Windows.Forms.TextBox();
            this.btnConfirmarNovoSaldo = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBoxSaldoDosUsuarios = new System.Windows.Forms.GroupBox();
            this.groupBoxUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetoIntegradorDBDataSet)).BeginInit();
            this.groupBoxCadastro.SuspendLayout();
            this.groupBoxSaldo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxSaldoDosUsuarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxUsuarios
            // 
            this.groupBoxUsuarios.Controls.Add(this.dataGridUsuario);
            this.groupBoxUsuarios.Controls.Add(this.btnProximo);
            this.groupBoxUsuarios.Controls.Add(this.btnVoltar);
            this.groupBoxUsuarios.Location = new System.Drawing.Point(40, 34);
            this.groupBoxUsuarios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxUsuarios.Name = "groupBoxUsuarios";
            this.groupBoxUsuarios.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxUsuarios.Size = new System.Drawing.Size(965, 433);
            this.groupBoxUsuarios.TabIndex = 0;
            this.groupBoxUsuarios.TabStop = false;
            this.groupBoxUsuarios.Text = "Usuários Cadastrados";
            // 
            // dataGridUsuario
            // 
            this.dataGridUsuario.AllowUserToOrderColumns = true;
            this.dataGridUsuario.AutoGenerateColumns = false;
            this.dataGridUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.cpfDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.senhaDataGridViewTextBoxColumn,
            this.saldoDisponivelDataGridViewTextBoxColumn});
            this.dataGridUsuario.DataSource = this.usuarioBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridUsuario.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridUsuario.Location = new System.Drawing.Point(27, 33);
            this.dataGridUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridUsuario.Name = "dataGridUsuario";
            this.dataGridUsuario.RowHeadersWidth = 51;
            this.dataGridUsuario.RowTemplate.Height = 24;
            this.dataGridUsuario.Size = new System.Drawing.Size(905, 334);
            this.dataGridUsuario.TabIndex = 0;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "codigo";
            this.codigoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoDataGridViewTextBoxColumn.Visible = false;
            this.codigoDataGridViewTextBoxColumn.Width = 125;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "nome";
            this.nomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.Width = 125;
            // 
            // cpfDataGridViewTextBoxColumn
            // 
            this.cpfDataGridViewTextBoxColumn.DataPropertyName = "cpf";
            this.cpfDataGridViewTextBoxColumn.HeaderText = "cpf";
            this.cpfDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cpfDataGridViewTextBoxColumn.Name = "cpfDataGridViewTextBoxColumn";
            this.cpfDataGridViewTextBoxColumn.ReadOnly = true;
            this.cpfDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "telefone";
            this.telefoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            this.telefoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.telefoneDataGridViewTextBoxColumn.Width = 125;
            // 
            // senhaDataGridViewTextBoxColumn
            // 
            this.senhaDataGridViewTextBoxColumn.DataPropertyName = "senha";
            this.senhaDataGridViewTextBoxColumn.HeaderText = "senha";
            this.senhaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.senhaDataGridViewTextBoxColumn.Name = "senhaDataGridViewTextBoxColumn";
            this.senhaDataGridViewTextBoxColumn.ReadOnly = true;
            this.senhaDataGridViewTextBoxColumn.Visible = false;
            this.senhaDataGridViewTextBoxColumn.Width = 125;
            // 
            // saldoDisponivelDataGridViewTextBoxColumn
            // 
            this.saldoDisponivelDataGridViewTextBoxColumn.DataPropertyName = "saldoDisponivel";
            this.saldoDisponivelDataGridViewTextBoxColumn.HeaderText = "saldoDisponivel";
            this.saldoDisponivelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.saldoDisponivelDataGridViewTextBoxColumn.Name = "saldoDisponivelDataGridViewTextBoxColumn";
            this.saldoDisponivelDataGridViewTextBoxColumn.ReadOnly = true;
            this.saldoDisponivelDataGridViewTextBoxColumn.Width = 125;
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "Usuario";
            this.usuarioBindingSource.DataSource = this.projetoIntegradorDBDataSet;
            // 
            // projetoIntegradorDBDataSet
            // 
            this.projetoIntegradorDBDataSet.DataSetName = "ProjetoIntegradorDBDataSet";
            this.projetoIntegradorDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnProximo
            // 
            this.btnProximo.Location = new System.Drawing.Point(501, 371);
            this.btnProximo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(161, 49);
            this.btnProximo.TabIndex = 3;
            this.btnProximo.Text = "Próximo";
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(334, 371);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(161, 49);
            this.btnVoltar.TabIndex = 2;
            this.btnVoltar.Text = "Anterior";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.button2_Click);
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // groupBoxCadastro
            // 
            this.groupBoxCadastro.Controls.Add(this.label2);
            this.groupBoxCadastro.Controls.Add(this.txtSaldoDisponivel);
            this.groupBoxCadastro.Controls.Add(this.groupBoxSaldo);
            this.groupBoxCadastro.Controls.Add(this.btnConfirmarNovoSaldo);
            this.groupBoxCadastro.Controls.Add(this.txtCPF);
            this.groupBoxCadastro.Controls.Add(this.txtTelefone);
            this.groupBoxCadastro.Controls.Add(this.lblTelefone);
            this.groupBoxCadastro.Controls.Add(this.txtEmail);
            this.groupBoxCadastro.Controls.Add(this.lblEmail);
            this.groupBoxCadastro.Controls.Add(this.lblCPF);
            this.groupBoxCadastro.Controls.Add(this.txtNome);
            this.groupBoxCadastro.Controls.Add(this.lblNome);
            this.groupBoxCadastro.Controls.Add(this.groupBox1);
            this.groupBoxCadastro.Location = new System.Drawing.Point(40, 473);
            this.groupBoxCadastro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxCadastro.Name = "groupBoxCadastro";
            this.groupBoxCadastro.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxCadastro.Size = new System.Drawing.Size(965, 393);
            this.groupBoxCadastro.TabIndex = 0;
            this.groupBoxCadastro.TabStop = false;
            this.groupBoxCadastro.Text = "Informações Usuário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Saldo Disponível:";
            // 
            // txtSaldoDisponivel
            // 
            this.txtSaldoDisponivel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "saldoDisponivel", true));
            this.txtSaldoDisponivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaldoDisponivel.Location = new System.Drawing.Point(29, 319);
            this.txtSaldoDisponivel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSaldoDisponivel.MaxLength = 11;
            this.txtSaldoDisponivel.Name = "txtSaldoDisponivel";
            this.txtSaldoDisponivel.ReadOnly = true;
            this.txtSaldoDisponivel.Size = new System.Drawing.Size(160, 53);
            this.txtSaldoDisponivel.TabIndex = 15;
            this.txtSaldoDisponivel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBoxSaldo
            // 
            this.groupBoxSaldo.Controls.Add(this.btn50);
            this.groupBoxSaldo.Controls.Add(this.btn25);
            this.groupBoxSaldo.Location = new System.Drawing.Point(584, 21);
            this.groupBoxSaldo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxSaldo.Name = "groupBoxSaldo";
            this.groupBoxSaldo.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxSaldo.Size = new System.Drawing.Size(348, 188);
            this.groupBoxSaldo.TabIndex = 14;
            this.groupBoxSaldo.TabStop = false;
            this.groupBoxSaldo.Text = "Adicionar Saldo";
            // 
            // btn50
            // 
            this.btn50.BackColor = System.Drawing.Color.ForestGreen;
            this.btn50.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn50.ForeColor = System.Drawing.SystemColors.Window;
            this.btn50.Location = new System.Drawing.Point(197, 39);
            this.btn50.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn50.Name = "btn50";
            this.btn50.Size = new System.Drawing.Size(112, 121);
            this.btn50.TabIndex = 1;
            this.btn50.Text = "Adicionar +50";
            this.btn50.UseVisualStyleBackColor = false;
            this.btn50.Click += new System.EventHandler(this.btn50_Click);
            // 
            // btn25
            // 
            this.btn25.BackColor = System.Drawing.Color.ForestGreen;
            this.btn25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn25.ForeColor = System.Drawing.SystemColors.Window;
            this.btn25.Location = new System.Drawing.Point(55, 39);
            this.btn25.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn25.Name = "btn25";
            this.btn25.Size = new System.Drawing.Size(112, 121);
            this.btn25.TabIndex = 0;
            this.btn25.Text = "Adicionar +25";
            this.btn25.UseVisualStyleBackColor = false;
            this.btn25.Click += new System.EventHandler(this.btn25_Click);
            // 
            // txtCPF
            // 
            this.txtCPF.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "cpf", true));
            this.txtCPF.Location = new System.Drawing.Point(27, 122);
            this.txtCPF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCPF.MaxLength = 11;
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.ReadOnly = true;
            this.txtCPF.Size = new System.Drawing.Size(452, 22);
            this.txtCPF.TabIndex = 3;
            this.txtCPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCPF_KeyPress_1);
            // 
            // txtTelefone
            // 
            this.txtTelefone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "telefone", true));
            this.txtTelefone.Location = new System.Drawing.Point(28, 247);
            this.txtTelefone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTelefone.Mask = "(00)00000\\-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.ReadOnly = true;
            this.txtTelefone.Size = new System.Drawing.Size(451, 22);
            this.txtTelefone.TabIndex = 8;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(25, 226);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(64, 17);
            this.lblTelefone.TabIndex = 7;
            this.lblTelefone.Text = "Telefone";
            // 
            // txtEmail
            // 
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "email", true));
            this.txtEmail.Location = new System.Drawing.Point(28, 187);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(451, 22);
            this.txtEmail.TabIndex = 6;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(24, 167);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 17);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(24, 102);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(34, 17);
            this.lblCPF.TabIndex = 3;
            this.lblCPF.Text = "CPF";
            // 
            // txtNome
            // 
            this.txtNome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "nome", true));
            this.txtNome.HideSelection = false;
            this.txtNome.Location = new System.Drawing.Point(27, 63);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNome.MaxLength = 100;
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(452, 22);
            this.txtNome.TabIndex = 2;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(25, 43);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(45, 17);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtRemoverSaldo);
            this.groupBox1.Location = new System.Drawing.Point(584, 234);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(348, 138);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Realizar Impressão";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Firebrick;
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(95, 86);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 34);
            this.button1.TabIndex = 18;
            this.button1.Text = "Diminuir Saldo";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Quantidade Impressa:";
            // 
            // txtRemoverSaldo
            // 
            this.txtRemoverSaldo.Location = new System.Drawing.Point(159, 42);
            this.txtRemoverSaldo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRemoverSaldo.MaxLength = 11;
            this.txtRemoverSaldo.Name = "txtRemoverSaldo";
            this.txtRemoverSaldo.Size = new System.Drawing.Size(160, 22);
            this.txtRemoverSaldo.TabIndex = 16;
            // 
            // btnConfirmarNovoSaldo
            // 
            this.btnConfirmarNovoSaldo.Location = new System.Drawing.Point(205, 319);
            this.btnConfirmarNovoSaldo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConfirmarNovoSaldo.Name = "btnConfirmarNovoSaldo";
            this.btnConfirmarNovoSaldo.Size = new System.Drawing.Size(161, 53);
            this.btnConfirmarNovoSaldo.TabIndex = 13;
            this.btnConfirmarNovoSaldo.Text = "Salvar Novo Saldo";
            this.btnConfirmarNovoSaldo.UseVisualStyleBackColor = true;
            this.btnConfirmarNovoSaldo.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBoxSaldoDosUsuarios
            // 
            this.groupBoxSaldoDosUsuarios.Controls.Add(this.groupBoxCadastro);
            this.groupBoxSaldoDosUsuarios.Controls.Add(this.groupBoxUsuarios);
            this.groupBoxSaldoDosUsuarios.Location = new System.Drawing.Point(16, 15);
            this.groupBoxSaldoDosUsuarios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxSaldoDosUsuarios.Name = "groupBoxSaldoDosUsuarios";
            this.groupBoxSaldoDosUsuarios.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxSaldoDosUsuarios.Size = new System.Drawing.Size(1035, 894);
            this.groupBoxSaldoDosUsuarios.TabIndex = 17;
            this.groupBoxSaldoDosUsuarios.TabStop = false;
            this.groupBoxSaldoDosUsuarios.Text = "Gerenciar Saldos";
            // 
            // frmSaldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1076, 926);
            this.Controls.Add(this.groupBoxSaldoDosUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSaldo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Senac | Impressões (Modo Administrador)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSaldo_FormClosing);
            this.Load += new System.EventHandler(this.fmUsuario_Load);
            this.groupBoxUsuarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetoIntegradorDBDataSet)).EndInit();
            this.groupBoxCadastro.ResumeLayout(false);
            this.groupBoxCadastro.PerformLayout();
            this.groupBoxSaldo.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxSaldoDosUsuarios.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxUsuarios;
        private ProjetoIntegradorDBDataSet projetoIntegradorDBDataSet;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private ProjetoIntegradorDBDataSetTableAdapters.UsuarioTableAdapter usuarioTableAdapter;
        private System.Windows.Forms.GroupBox groupBoxCadastro;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.DataGridView dataGridUsuario;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Button btnConfirmarNovoSaldo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.GroupBox groupBoxSaldo;
        private System.Windows.Forms.Button btn50;
        private System.Windows.Forms.Button btn25;
        private System.Windows.Forms.TextBox txtSaldoDisponivel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtRemoverSaldo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn senhaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldoDisponivelDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBoxSaldoDosUsuarios;
    }
}