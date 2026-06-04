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
    public partial class Convocacao : Form
    {
        public Convocacao()
        {
            InitializeComponent();
        }

        private void Convocacao_Load(object sender, EventArgs e)
        {
            // Adicionar Posições ao combo Box
            cbxPosição.Items.Add("Goleiro");
            cbxPosição.Items.Add("Zagueiro");
            cbxPosição.Items.Add("Meio-Campo");
            cbxPosição.Items.Add("Atacante");

            // verificar idade minima e maxima
            nmrIdade.Minimum = 16;
            nmrIdade.Maximum = 43;

            // Desativar botoes via codigo
            btnConvocacao.Enabled = false;
            btnEspera.Enabled = false;


            txtNomeJogador.TabIndex = 0;
            nmrIdade.TabIndex = 1;
            cbxPosição.TabIndex = 2;
            btnConvocacao.TabIndex = 3;
            btnEspera.TabIndex = 4;

            

        }

        private void VerificarFormulario()
        {
            int idade;

            bool nomeOk = !string.IsNullOrEmpty(txtNomeJogador.Text);
            bool idadeOK = int.TryParse(nmrIdade.Text, out idade);
            bool posicaoOk = cbxPosição.SelectedIndex != -1;

            if (nomeOk && idadeOK && posicaoOk)
            {

                btnConvocacao.Enabled = true;
                btnEspera.Enabled = true;
            }
            else
            {
                btnConvocacao.Enabled = false;
                btnEspera.Enabled = false;
            }
        }

        private void listEspera_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listConvocação_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEspera_Click(object sender, EventArgs e)
        {
            int idade = (int)nmrIdade.Value;
            string posicao = cbxPosição.Text;
            string nome = txtNomeJogador.Text;



            bool apto = JogadorApto(idade, posicao);



            if (apto)
            {
                listEspera.Items.Add("Nome: " + nome + " Idade: " + idade + " Posição: " + posicao);
                MessageBox.Show(nome + " Espera ai amigao: ");
            }
            else
            {
                MessageBox.Show("Goleiro dever ter no minimo 20 anos para ser convocado.");
            }


            LimparFormulario();

        }

        private void btnConvocacao_Click(object sender, EventArgs e)
        {
            int idade = (int)nmrIdade.Value;
            string posicao = cbxPosição.Text;
            string nome = txtNomeJogador.Text;

            bool apto = JogadorApto(idade, posicao);

            if (apto)
            {
                listConvocação.Items.Add("Nome: " + nome + " Idade: " + idade + " Posição: " + posicao);
                MessageBox.Show(nome + " Convocado Campeão ");
            }
            else
            {
                MessageBox.Show("Goleiro dever ter no minimo 20 anos para ser convocado.");
            }



            LimparFormulario();
        }

        private void cbxPosição_SelectedIndexChanged(object sender, EventArgs e)
        {
            VerificarFormulario();
        }

        private void nmrIdade_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtNomeJogador_TextChanged(object sender, EventArgs e)
        {
            VerificarFormulario();
        }

        private void lblNomeJogador_Click(object sender, EventArgs e)
        {

        }

        private void lblIdade_Click(object sender, EventArgs e)
        {

        }

        private void lblPosição_Click(object sender, EventArgs e)
        {

        }
        private void LimparFormulario()
        {
            txtNomeJogador.Focus();
            txtNomeJogador.Clear();
            nmrIdade.Value = nmrIdade.Minimum;
            cbxPosição.SelectedIndex = -1;
            btnConvocacao.Enabled = false;
            btnEspera.Enabled = false;

        }
        private bool JogadorApto(int idade, string posicao)
        {
            if (posicao == "Goleiro")
            {
                return idade >= 20;
            }
            else
            {
                return true;
            }
        }

        private void pctBrasil_Click(object sender, EventArgs e)
        {

            pctBrasil.BackColor = Color.Transparent;
            pctBrasil.SizeMode = PictureBoxSizeMode.Zoom;

        }
    }
}
