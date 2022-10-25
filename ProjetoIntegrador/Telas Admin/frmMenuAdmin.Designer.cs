
namespace ProjetoIntegrador
{
    partial class frmMenuAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuAdmin));
            this.gbAdmin = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblSair = new System.Windows.Forms.Label();
            this.imgSair = new System.Windows.Forms.PictureBox();
            this.lblSaldoUsuario = new System.Windows.Forms.Label();
            this.imgSaldoUsuario = new System.Windows.Forms.PictureBox();
            this.lblSolicitacoesUsuario = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.gerenciarSaldosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciarUsuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciarSaldosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciarUsuáriosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciarSaldosToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciarUsuáriosToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciarSaldosToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciarUsuáriosToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.gbAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSaldoUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Menu.SuspendLayout();
            this.contextMenu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAdmin
            // 
            this.gbAdmin.Controls.Add(this.pictureBox2);
            this.gbAdmin.Controls.Add(this.lblSair);
            this.gbAdmin.Controls.Add(this.imgSair);
            this.gbAdmin.Controls.Add(this.lblSaldoUsuario);
            this.gbAdmin.Controls.Add(this.imgSaldoUsuario);
            this.gbAdmin.Controls.Add(this.lblSolicitacoesUsuario);
            this.gbAdmin.Controls.Add(this.pictureBox1);
            this.gbAdmin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbAdmin.Location = new System.Drawing.Point(12, 27);
            this.gbAdmin.Name = "gbAdmin";
            this.gbAdmin.Size = new System.Drawing.Size(652, 351);
            this.gbAdmin.TabIndex = 0;
            this.gbAdmin.TabStop = false;
            this.gbAdmin.Text = "Modo Administrador";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox2.Location = new System.Drawing.Point(94, 182);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(92, 83);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lblSair
            // 
            this.lblSair.AutoSize = true;
            this.lblSair.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSair.Location = new System.Drawing.Point(504, 268);
            this.lblSair.Name = "lblSair";
            this.lblSair.Size = new System.Drawing.Size(25, 13);
            this.lblSair.TabIndex = 8;
            this.lblSair.Text = "Sair";
            this.lblSair.Click += new System.EventHandler(this.lblSair_Click);
            // 
            // imgSair
            // 
            this.imgSair.Image = ((System.Drawing.Image)(resources.GetObject("imgSair.Image")));
            this.imgSair.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.imgSair.Location = new System.Drawing.Point(469, 182);
            this.imgSair.Name = "imgSair";
            this.imgSair.Size = new System.Drawing.Size(92, 83);
            this.imgSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgSair.TabIndex = 7;
            this.imgSair.TabStop = false;
            this.imgSair.Click += new System.EventHandler(this.imgSair_Click);
            // 
            // lblSaldoUsuario
            // 
            this.lblSaldoUsuario.AutoSize = true;
            this.lblSaldoUsuario.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSaldoUsuario.Location = new System.Drawing.Point(275, 268);
            this.lblSaldoUsuario.Name = "lblSaldoUsuario";
            this.lblSaldoUsuario.Size = new System.Drawing.Size(97, 13);
            this.lblSaldoUsuario.TabIndex = 6;
            this.lblSaldoUsuario.Text = "Gerenciar Usuários";
            this.lblSaldoUsuario.Click += new System.EventHandler(this.lblSaldoUsuario_Click);
            // 
            // imgSaldoUsuario
            // 
            this.imgSaldoUsuario.Image = ((System.Drawing.Image)(resources.GetObject("imgSaldoUsuario.Image")));
            this.imgSaldoUsuario.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.imgSaldoUsuario.Location = new System.Drawing.Point(278, 182);
            this.imgSaldoUsuario.Name = "imgSaldoUsuario";
            this.imgSaldoUsuario.Size = new System.Drawing.Size(92, 83);
            this.imgSaldoUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgSaldoUsuario.TabIndex = 5;
            this.imgSaldoUsuario.TabStop = false;
            this.imgSaldoUsuario.Click += new System.EventHandler(this.imgSaldoUsuario_Click);
            // 
            // lblSolicitacoesUsuario
            // 
            this.lblSolicitacoesUsuario.AutoSize = true;
            this.lblSolicitacoesUsuario.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSolicitacoesUsuario.Location = new System.Drawing.Point(98, 268);
            this.lblSolicitacoesUsuario.Name = "lblSolicitacoesUsuario";
            this.lblSolicitacoesUsuario.Size = new System.Drawing.Size(88, 13);
            this.lblSolicitacoesUsuario.TabIndex = 4;
            this.lblSolicitacoesUsuario.Text = "Gerenciar Saldos";
            this.lblSolicitacoesUsuario.Click += new System.EventHandler(this.lblSolicitacoesUsuario_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjetoIntegrador.Properties.Resources.senac_logo_4;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(251, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerenciarSaldosToolStripMenuItem,
            this.gerenciarUsuáriosToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(173, 70);
            // 
            // gerenciarSaldosToolStripMenuItem
            // 
            this.gerenciarSaldosToolStripMenuItem.Name = "gerenciarSaldosToolStripMenuItem";
            this.gerenciarSaldosToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.gerenciarSaldosToolStripMenuItem.Text = "Gerenciar Saldos";
            // 
            // gerenciarUsuáriosToolStripMenuItem
            // 
            this.gerenciarUsuáriosToolStripMenuItem.Name = "gerenciarUsuáriosToolStripMenuItem";
            this.gerenciarUsuáriosToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.gerenciarUsuáriosToolStripMenuItem.Text = "Gerenciar Usuários";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // contextMenu
            // 
            this.contextMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.gerenciarSaldosToolStripMenuItem1,
            this.gerenciarUsuáriosToolStripMenuItem1,
            this.sairToolStripMenuItem1});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(173, 92);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // gerenciarSaldosToolStripMenuItem1
            // 
            this.gerenciarSaldosToolStripMenuItem1.Name = "gerenciarSaldosToolStripMenuItem1";
            this.gerenciarSaldosToolStripMenuItem1.Size = new System.Drawing.Size(172, 22);
            this.gerenciarSaldosToolStripMenuItem1.Text = "Gerenciar Saldos";
            // 
            // gerenciarUsuáriosToolStripMenuItem1
            // 
            this.gerenciarUsuáriosToolStripMenuItem1.Name = "gerenciarUsuáriosToolStripMenuItem1";
            this.gerenciarUsuáriosToolStripMenuItem1.Size = new System.Drawing.Size(172, 22);
            this.gerenciarUsuáriosToolStripMenuItem1.Text = "Gerenciar Usuários";
            // 
            // sairToolStripMenuItem1
            // 
            this.sairToolStripMenuItem1.Name = "sairToolStripMenuItem1";
            this.sairToolStripMenuItem1.Size = new System.Drawing.Size(172, 22);
            this.sairToolStripMenuItem1.Text = "Sair";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem1,
            this.gerenciarSaldosToolStripMenuItem3,
            this.gerenciarUsuáriosToolStripMenuItem3});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(676, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem1
            // 
            this.menuToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerenciarSaldosToolStripMenuItem2,
            this.gerenciarUsuáriosToolStripMenuItem2,
            this.sairToolStripMenuItem2});
            this.menuToolStripMenuItem1.Name = "menuToolStripMenuItem1";
            this.menuToolStripMenuItem1.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem1.Text = "Menu";
            // 
            // gerenciarSaldosToolStripMenuItem2
            // 
            this.gerenciarSaldosToolStripMenuItem2.Name = "gerenciarSaldosToolStripMenuItem2";
            this.gerenciarSaldosToolStripMenuItem2.Size = new System.Drawing.Size(172, 22);
            this.gerenciarSaldosToolStripMenuItem2.Text = "Gerenciar Saldos";
            this.gerenciarSaldosToolStripMenuItem2.Click += new System.EventHandler(this.gerenciarSaldosToolStripMenuItem2_Click);
            // 
            // gerenciarUsuáriosToolStripMenuItem2
            // 
            this.gerenciarUsuáriosToolStripMenuItem2.Name = "gerenciarUsuáriosToolStripMenuItem2";
            this.gerenciarUsuáriosToolStripMenuItem2.Size = new System.Drawing.Size(172, 22);
            this.gerenciarUsuáriosToolStripMenuItem2.Text = "Gerenciar Usuários";
            this.gerenciarUsuáriosToolStripMenuItem2.Click += new System.EventHandler(this.gerenciarUsuáriosToolStripMenuItem2_Click);
            // 
            // sairToolStripMenuItem2
            // 
            this.sairToolStripMenuItem2.Name = "sairToolStripMenuItem2";
            this.sairToolStripMenuItem2.Size = new System.Drawing.Size(172, 22);
            this.sairToolStripMenuItem2.Text = "Sair";
            this.sairToolStripMenuItem2.Click += new System.EventHandler(this.sairToolStripMenuItem2_Click);
            // 
            // gerenciarSaldosToolStripMenuItem3
            // 
            this.gerenciarSaldosToolStripMenuItem3.Name = "gerenciarSaldosToolStripMenuItem3";
            this.gerenciarSaldosToolStripMenuItem3.Size = new System.Drawing.Size(106, 20);
            this.gerenciarSaldosToolStripMenuItem3.Text = "Gerenciar Saldos";
            this.gerenciarSaldosToolStripMenuItem3.Click += new System.EventHandler(this.gerenciarSaldosToolStripMenuItem3_Click);
            // 
            // gerenciarUsuáriosToolStripMenuItem3
            // 
            this.gerenciarUsuáriosToolStripMenuItem3.Name = "gerenciarUsuáriosToolStripMenuItem3";
            this.gerenciarUsuáriosToolStripMenuItem3.Size = new System.Drawing.Size(117, 20);
            this.gerenciarUsuáriosToolStripMenuItem3.Text = "Gerenciar Usuários";
            this.gerenciarUsuáriosToolStripMenuItem3.Click += new System.EventHandler(this.gerenciarUsuáriosToolStripMenuItem3_Click);
            // 
            // frmMenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 390);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.gbAdmin);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenuAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Senac | Impressões (Modo Administrador)";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMenuAdmin_FormClosing);
     
            this.gbAdmin.ResumeLayout(false);
            this.gbAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSaldoUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Menu.ResumeLayout(false);
            this.contextMenu.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAdmin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblSolicitacoesUsuario;
        private System.Windows.Forms.Label lblSaldoUsuario;
        private System.Windows.Forms.PictureBox imgSaldoUsuario;
        private System.Windows.Forms.Label lblSair;
        private System.Windows.Forms.PictureBox imgSair;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ContextMenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem gerenciarSaldosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciarUsuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciarSaldosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gerenciarUsuáriosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gerenciarSaldosToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem gerenciarUsuáriosToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem gerenciarSaldosToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem gerenciarUsuáriosToolStripMenuItem3;
    }
}