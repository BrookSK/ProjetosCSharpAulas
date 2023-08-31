using System;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class frmPPrincipal : Form
    {
        public frmPPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            minhaBiblioteca.minhaClasse minhaClasse = new minhaBiblioteca.minhaClasse();

            MessageBox.Show(minhaClasse.texto);
        }
    }
}

namespace minhaBiblioteca
{
    public class minhaClasse
    {
        public string texto = "Texto da classe";
    }
}