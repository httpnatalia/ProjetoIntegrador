using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoIntegrador
{
    public partial class frmSolicitarImpressao : Form
    {
        public frmSolicitarImpressao()
        {
            InitializeComponent();
        }

    
        private void button1_Click(object sender, EventArgs e)
        {
            // abrir caixa de seleção de arquivo
            //    string texto = "";
            //    openfiledialog openfiledialog1 = new openfiledialog();
            //    if (openfiledialog1.showdialog() == dialogresult.ok)
            //       texto = file=(openfiledialog1.filename);
            
        }
        public void AbrirLink (string endereco)
        {
            System.Diagnostics.Process.Start(endereco);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AbrirLink("mailto:ana.nascimento@sc.senac..br?subject=Solicita%C3%A7%C3%A3o%20de%20Impress%C3%A3o%20-%20SENAC&body=Nome%3A%0D%0A%0D%0ACPF%3A%0D%0A%0D%0AQuantidade%20de%20impress%C3%B5es%3A%0D%0A%0D%0A%0D%0A%0D%0A-----------------------------------------------%0D%0A%2F%2F%20N%C3%A3o%20se%20esque%C3%A7a%20de%20anexar%20o%20arquivo%20desejado.");

        }

     
    }
}
