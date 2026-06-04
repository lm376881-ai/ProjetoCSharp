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
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }
        public decimal Resultado { get; set; }
        public decimal Valor { get; set; }

        public Operacao OperacaoSelecionada { get; set; }

        public enum Operacao
        {
            Adicao,
            Subtracao,
            Divisao,
            Multiplicacao
        }

        public void Calculadora_Load(object sender, EventArgs e)
        {
         
        }

        public void btnUm_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        public void btnDois_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";

        }

        public void btnTres_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        public void btnQuatro_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        public void btnCinco_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        public void btnSeis_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        public void btnSete_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }


        public void btnOito_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        public void btnNove_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        public void btnZero_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }

        public void btnVirgula_Click(object sender, EventArgs e)
        {
            if (!txtResultado.Text.Contains(","))
                txtResultado.Text += ",";
        }

        public void btnAdicao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Adicao;
            Valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
            lblOperador.Text = "+";
        }

        public void btnSubtracao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Subtracao;
            Valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
            lblOperador.Text = "-";
        }

        public void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Multiplicacao;
            Valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
            lblOperador.Text = "*";
        }

        public void btnDivisao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Divisao;
            Valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
            lblOperador.Text = "/";
        }
        

        public void btnResultado_Click(object sender, EventArgs e)
        {
            switch (OperacaoSelecionada)
            {
                case Operacao.Adicao:
                    Resultado = Valor + Convert.ToDecimal(txtResultado.Text);
                    break;
                case Operacao.Subtracao:
                    Resultado = Valor - Convert.ToDecimal(txtResultado.Text);
                    break;
                case Operacao.Multiplicacao:
                    Resultado = Valor * Convert.ToDecimal(txtResultado.Text);
                    break;
                case Operacao.Divisao:
                    decimal divisor = Convert.ToDecimal(txtResultado.Text);
                    if (divisor == 0)
                    {
                        MessageBox.Show("Não é possível dividir por zero!");
                        return;
                    }
                    Resultado = Valor / divisor;
                    break;
            }
            txtResultado.Text = Convert.ToString(Resultado);
            lblOperador.Text = "=";
        }
    
        public void btnLimpar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            lblOperador.Text = "";
        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblOperador_Click(object sender, EventArgs e)
        {

        }
    }
}
