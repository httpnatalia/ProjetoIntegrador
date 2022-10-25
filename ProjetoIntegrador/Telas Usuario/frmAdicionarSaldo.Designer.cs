
namespace ProjetoIntegrador
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
            this.btnCompar50 = new System.Windows.Forms.Button();
            this.imgComprar50 = new System.Windows.Forms.PictureBox();
            this.btnComprar25 = new System.Windows.Forms.Button();
            this.imgComprar25 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgComprar50)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgComprar25)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCompar50);
            this.groupBox1.Controls.Add(this.imgComprar50);
            this.groupBox1.Controls.Add(this.btnComprar25);
            this.groupBox1.Controls.Add(this.imgComprar25);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 370);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Comprar Saldo de Impressão";
            // 
            // btnCompar50
            // 
            this.btnCompar50.Location = new System.Drawing.Point(247, 247);
            this.btnCompar50.Name = "btnCompar50";
            this.btnCompar50.Size = new System.Drawing.Size(98, 23);
            this.btnCompar50.TabIndex = 13;
            this.btnCompar50.Text = "Comprar +50";
            this.btnCompar50.UseVisualStyleBackColor = true;
            this.btnCompar50.Click += new System.EventHandler(this.btnCompar50_Click);
            // 
            // imgComprar50
            // 
            this.imgComprar50.Image = ((System.Drawing.Image)(resources.GetObject("imgComprar50.Image")));
            this.imgComprar50.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.imgComprar50.Location = new System.Drawing.Point(209, 101);
            this.imgComprar50.Name = "imgComprar50";
            this.imgComprar50.Size = new System.Drawing.Size(172, 139);
            this.imgComprar50.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgComprar50.TabIndex = 12;
            this.imgComprar50.TabStop = false;
            // 
            // btnComprar25
            // 
            this.btnComprar25.Location = new System.Drawing.Point(65, 247);
            this.btnComprar25.Name = "btnComprar25";
            this.btnComprar25.Size = new System.Drawing.Size(98, 23);
            this.btnComprar25.TabIndex = 11;
            this.btnComprar25.Text = "Comprar +25";
            this.btnComprar25.UseVisualStyleBackColor = true;
            this.btnComprar25.Click += new System.EventHandler(this.btnComprar25_Click_1);
            // 
            // imgComprar25
            // 
            this.imgComprar25.Image = ((System.Drawing.Image)(resources.GetObject("imgComprar25.Image")));
            this.imgComprar25.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.imgComprar25.Location = new System.Drawing.Point(27, 101);
            this.imgComprar25.Name = "imgComprar25";
            this.imgComprar25.Size = new System.Drawing.Size(172, 139);
            this.imgComprar25.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgComprar25.TabIndex = 10;
            this.imgComprar25.TabStop = false;
            this.imgComprar25.Click += new System.EventHandler(this.imgComprar25_Click_1);
            // 
            // frmAdicionarSaldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 397);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAdicionarSaldo";
            this.Text = "Senac | Impressões";
           
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgComprar50)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgComprar25)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCompar50;
        private System.Windows.Forms.PictureBox imgComprar50;
        private System.Windows.Forms.Button btnComprar25;
        private System.Windows.Forms.PictureBox imgComprar25;
    }
}