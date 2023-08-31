using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteAPP1524005
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nome = "Nome: " + textBox1.Text;
            string qtd = "Quantidade: " + textBox2.Text;
            string preco = "Preço: " + textBox3.Text;

            string info2 = $"\n{nome}\n{qtd}\n{preco}";

            MessageBox.Show($"O produto cadastrado tem as seguintes informações: {info2}");
        }
    }
}
