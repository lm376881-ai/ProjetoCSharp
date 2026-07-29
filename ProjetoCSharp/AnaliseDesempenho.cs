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

        private void btnAvaliação_Click(object sender, EventArgs e)
        {
            ativarBotoes();
            classificarJogador();
        }

        private void AnaliseDesempenho_Load(object sender, EventArgs e)
        {
            cbxPosição.Items.Clear();
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
            btnAvaliar.Enabled = false;
            btnLimpar.Enabled = false;
            txtNomeJogador.Focus();
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

            // Ativa o botão de limpar caso qualquer campo tenha algo digitado
            btnLimpar.Enabled = !string.IsNullOrWhiteSpace(txtNomeJogador.Text) ||
                                cbxPosição.SelectedIndex != -1 ||
                                !string.IsNullOrWhiteSpace(txtPartidas.Text) ||
                                !string.IsNullOrWhiteSpace(txtGols.Text) ||
                                !string.IsNullOrWhiteSpace(txtAssistencia.Text);
        }

        private void classificarJogador()
        {
            // Validar conversões de números
            if (!int.TryParse(txtPartidas.Text, out int jogos) || jogos <= 0 ||
                !int.TryParse(txtGols.Text, out int gols) || gols < 0 ||
                !int.TryParse(txtAssistencia.Text, out int assistencias) || assistencias < 0)
            {
                MessageBox.Show("Por favor, insira valores numéricos válidos (jogos deve ser maior que 0).", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nome = txtNomeJogador.Text;
            string posicao = cbxPosição.SelectedItem.ToString();

            // Cálculo do Desempenho
            double media = CalcularMedia(gols, assistencias, jogos);

            // Classificação
            string classificacao = ObterClassificacao(media);

            // Decisão da Convocação (Regra: média >= 2 E gols >= 3)
            bool convocado = VerificarConvocacao(media, gols);
            string statusConvocacao = convocado ? "CONVOCADO" : "NÃO CONVOCADO";

            // Exibir e Armazenar no ListBox
            ExibirHistorico(nome, posicao, media, classificacao, statusConvocacao);
        }

        private double CalcularMedia(int gols, int assistencias, int jogos)
        {
            // 2 pts, Assistência = 1 pt. Média = pontos / jogos
            double pontos = (gols * 2) + (assistencias * 1);
            return pontos / jogos;
        }

        private string ObterClassificacao(double media)
        {
            // 0-1 Ruim | 1,1-2 Regular | 2,1-3 Bom | acima de 3 Craque
            if (media <= 1.0)
                return "Ruim";
            else if (media <= 2.0)
                return "Regular";
            else if (media <= 3.0)
                return "Bom";
            else
                return "Craque";
        }

        private bool VerificarConvocacao(double media, int gols)
        {
            //Convocado somente se média >= 2 E gols >= 3
            return media >= 2.0 && gols >= 3;
        }

        private void ExibirHistorico(string nome, string posicao, double media, string classificacao, string status)
        {
            string resultado = $"{nome} ({posicao}) | Média: {media:F2} | Classificação: {classificacao} | Status: {status}";
            listAvaliacao.Items.Add(resultado);
        }

        // Eventos vazios não utilizados
        private void lblAssistencia_Click(object sender, EventArgs e) { }
        private void lblGols_Click(object sender, EventArgs e) { }
        private void lblJogos_Click(object sender, EventArgs e) { }
        private void lblPosição_Click(object sender, EventArgs e) { }
        private void lblNomeJogador_Click(object sender, EventArgs e) { }
        private void listAvaliacao_SelectedIndexChanged(object sender, EventArgs e) { }
        private void groupBox1_Enter(object sender, EventArgs e) { }
    }
}