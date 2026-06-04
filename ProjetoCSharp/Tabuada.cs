using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCSharp
{
    public partial class Tabuada : Form
    {
        public Tabuada()
        {
            InitializeComponent();
        }

        private void Tabuada_Load(object sender, EventArgs e)
        {

        }

        private void lblTabuada_Click(object sender, EventArgs e)
        {

        }

        private void txtResultadoTabuada_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(txtNumero.Text);

            txtResultadoTabuada.Clear();

            for (int i = 1; i <= 10; i++)
            {
                txtResultadoTabuada.Text += ($"{numero} x {i} = {numero * i}\r\n");

            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNumero.Text = "";
            txtResultadoTabuada.Text = "";
            txtNumero.Focus();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
