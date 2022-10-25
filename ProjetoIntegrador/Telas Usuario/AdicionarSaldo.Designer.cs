
namespace ProjetoIntegrador.Telas_Usuario
{
    partial class frmAdicionarSaldo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdicionarSaldo));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnComprar50 = new System.Windows.Forms.Button();
            this.btnComprar25 = new System.Windows.Forms.Button();
            this.imgComprar50 = new System.Windows.Forms.PictureBox();
            this.imgComprar25 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgComprar50)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgComprar25)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnComprar50);
            this.groupBox1.Controls.Add(this.btnComprar25);
            this.groupBox1.Controls.Add(this.imgComprar50);
            this.groupBox1.Controls.Add(this.imgComprar25);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(532, 306);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adicionar Saldo de Impressões";
            // 
            // btnComprar50
            // 
            this.btnComprar50.Location = new System.Drawing.Point(337, 235);
            this.btnComprar50.Name = "btnComprar50";
            this.btnComprar50.Size = new System.Drawing.Size(96, 23);
            this.btnComprar50.TabIndex = 9;
            this.btnComprar50.Text = "Compar +50";
            this.btnComprar50.UseVisualStyleBackColor = true;
            this.btnComprar50.Click += new System.EventHandler(this.btnComprar50_Click);
            // 
            // btnComprar25
            // 
            this.btnComprar25.Location = new System.Drawing.Point(95, 235);
            this.btnComprar25.Name = "btnComprar25";
            this.btnComprar25.Size = new System.Drawing.Size(96, 23);
            this.btnComprar25.TabIndex = 8;
            this.btnComprar25.Text = "Comprar +25";
            this.btnComprar25.UseVisualStyleBackColor = true;
            this.btnComprar25.Click += new System.EventHandler(this.btnComprar25_Click);
            // 
            // imgComprar50
            // 
            this.imgComprar50.Image = ((System.Drawing.Image)(resources.GetObject("imgComprar50.Image")));
            this.imgComprar50.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.imgComprar50.InitialImage = ((System.Drawing.Image)(resources.GetObject("imgComprar50.InitialImage")));
            this.imgComprar50.Location = new System.Drawing.Point(299, 61);
            this.imgComprar50.Name = "imgComprar50";
            this.imgComprar50.Size = new System.Drawing.Size(185, 168);
            this.imgComprar50.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgComprar50.TabIndex = 7;
            this.imgComprar50.TabStop = false;
            this.imgComprar50.Click += new System.EventHandler(this.imgComprar50_Click);
            // 
            // imgComprar25
            // 
            this.imgComprar25.Image = ((System.Drawing.Image)(resources.GetObject("imgComprar25.Image")));
            this.imgComprar25.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.imgComprar25.Location = new System.Drawing.Point(56, 61);
            this.imgComprar25.Name = "imgComprar25";
            this.imgComprar25.Size = new System.Drawing.Size(185, 168);
            this.imgComprar25.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgComprar25.TabIndex = 6;
            this.imgComprar25.TabStop = false;
            this.imgComprar25.Click += new System.EventHandler(this.imgComprar25_Click);
            // 
            // frmAdicionarSaldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(557, 333);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAdicionarSaldo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Senac | Impressões";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgComprar50)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgComprar25)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox imgComprar25;
        private System.Windows.Forms.Button btnComprar50;
        private System.Windows.Forms.Button btnComprar25;
        private System.Windows.Forms.PictureBox imgComprar50;
    }
}