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
    public partial class AnaliseDesempenho : Form
    {
        public AnaliseDesempenho()
        {
            InitializeComponent();
        }

        private void txtNomeJogador_TextChanged(object sender, EventArgs e)
        {
            txtNomeJogador.Focus();
            ativarBotoes();
        }

        private void cbxPosição_SelectedIndexChanged(object sender, EventArgs e)
        {
            ativarBotoes();
        }

        private void txtPartidas_TextChanged(object sender, EventArgs e)
        {
            ativarBotoes();
        }

        private void txtGols_TextChanged(object sender, EventArgs e)
        {
            ativarBotoes();
        }

        private void txtAssistencia_TextChanged(object sender, EventArgs e)
        {
            ativarBotoes();
        }

        private void lblAssistencia_Click(object sender, EventArgs e)
        {

        }

        private void lblGols_Click(object sender, EventArgs e)
        {

        }

        private void lblJogos_Click(object sender, EventArgs e)
        {

        }

        private void lblPosição_Click(object sender, EventArgs e)
        {

        }

        private void lblNomeJogador_Click(object sender, EventArgs e)
        {

        }

        private void listAvaliacao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAvaliação_Click(object sender, EventArgs e)
        {
            ativarBotoes();
            classificarJogador();
        }

        private void AnaliseDesempenho_Load(object sender, EventArgs e)
        {
            cbxPosição.Items.Add("Goleiro");
            cbxPosição.Items.Add("Zagueiro");
            cbxPosição.Items.Add("Meio-Campo");
            cbxPosição.Items.Add("Atacante");

            btnAvaliar.Enabled = false;
            btnLimpar.Enabled = false;

            txtNomeJogador.TabIndex = 0;
            cbxPosição.TabIndex = 1;
            txtPartidas.TabIndex = 2;
            txtGols.TabIndex = 3;
            txtAssistencia.TabIndex = 4;
            btnAvaliar.TabIndex = 5;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        { 
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparFormulário(); 
        }

        private void limparFormulário()
        {
            txtNomeJogador.Clear();
            txtGols.Clear();
            txtPartidas.Clear();
            txtAssistencia.Clear();
            cbxPosição.SelectedIndex = -1;
        }

        private void ativarBotoes()
        {
            bool camposPreenchidos =

                !string.IsNullOrWhiteSpace(txtNomeJogador.Text) &&
                cbxPosição.SelectedIndex != -1 &&
                !string.IsNullOrWhiteSpace(txtPartidas.Text) &&
                !string.IsNullOrWhiteSpace(txtGols.Text) &&
                !string.IsNullOrWhiteSpace(txtAssistencia.Text);

            btnAvaliar.Enabled = camposPreenchidos;
            btnLimpar.Enabled = true;


        }

        private void classificarJogador()
        {
          
        }

    }
}
