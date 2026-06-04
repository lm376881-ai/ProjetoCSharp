using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjetoCSharp
{
    public partial class Idade : Form
    {
        public Idade()
        {
            InitializeComponent();
        }

        private void rdSaoPaulo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdRiodeJaneiro_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblIdade_Click(object sender, EventArgs e)
        {
      
        }

        private void lblEstado_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtIdade.Text))
            {
                MessageBox.Show("Você precisa informar a sua idade! ");
                return;
            }

            int idade;

            if (!int.TryParse(txtIdade.Text, out idade))
            {
                MessageBox.Show("Digite um número válido! ");
                return;
            }
            if (idade >= 0 && idade <= 17)
            {
                lblIdade.Text = "Você é menor de idade: " + idade;
            }
            else
            {
                lblIdade.Text = "Você é maior de idade: " + idade;
            }
            lblIdade.Visible = true;

            if (rdSaoPaulo.Checked)
            {
                lblEstado.Text = "Você mora em São Paulo";
                pctSaoPaulo.Visible = true;
                pctRiodeJaneiro.Visible = false;
            }
            else if (rdRiodeJaneiro.Checked)
            {
                lblEstado.Text = "Você mora no Rio de Janeiro";
                pctSaoPaulo.Visible = false;
                pctRiodeJaneiro.Visible = true;
            }
            else
            {
                lblEstado.Text = "Você não selecionou um estado";
            }
        }

        private void txtIdade_TextChanged(object sender, EventArgs e)
        {

        }

        private void pctRiodeJaneiro_Click(object sender, EventArgs e)
        {

        }

        private void pctSaoPaulo_Click(object sender, EventArgs e)
        {

        }
    }
}
