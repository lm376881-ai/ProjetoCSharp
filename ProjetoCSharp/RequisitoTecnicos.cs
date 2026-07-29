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
    public partial class RequisitoTecnicos : Form
    {
        public RequisitoTecnicos()
        {
            InitializeComponent();
        }

        private void OpcoesRequisitos_Load(object sender, EventArgs e)
        {
            cbBoxNumero.Items.Clear();
            cbBoxNumero.Items.Add("1 - Mostrar Escalação");
            cbBoxNumero.Items.Add("2 - Avaliar Jogador");
            cbBoxNumero.Items.Add("3 - Ver Histórico");
            cbBoxNumero.Items.Add("4 - Substituição");
            cbBoxNumero.Items.Add("5 - Encerrar");
            cbBoxNumero.SelectedIndex = 0;
        }

       // Mostrar Escalação
        private void MostrarEscalacao()
        {
            Limpar();

            lstHistorico.Items.Add("--- GOLEIROS ---");
            lstHistorico.Items.Add("1. Dida – Goleiro");
            lstHistorico.Items.Add("12. Ceni – Goleiro");
            lstHistorico.Items.Add("22. Júlio César – Goleiro");

            lstHistorico.Items.Add("");
            lstHistorico.Items.Add("--- DEFESAS ---");
            lstHistorico.Items.Add("2. Cafu – Lateral Direito");
            lstHistorico.Items.Add("3. Lúcio – Zagueiro");
            lstHistorico.Items.Add("4. Juan – Zagueiro");
            lstHistorico.Items.Add("6. Roberto Carlos – Lateral Esquerdo");
            lstHistorico.Items.Add("13. Cícero – Lateral Direito");
            lstHistorico.Items.Add("14. Luisão – Zagueiro");
            lstHistorico.Items.Add("15. Cris – Zagueiro");
            lstHistorico.Items.Add("16. Gilberto – Lateral Esquerdo");

            lstHistorico.Items.Add("");
            lstHistorico.Items.Add("--- MEIO-CAMPO ---");
            lstHistorico.Items.Add("5. Emerson – Volante");
            lstHistorico.Items.Add("8. Kaká – Meia");
            lstHistorico.Items.Add("10. Ronaldinho Gaúcho – Meia");
            lstHistorico.Items.Add("11. Zé Roberto – Volante/Meia");
            lstHistorico.Items.Add("17. Gilberto Silva – Volante");
            lstHistorico.Items.Add("18. Mineiro – Volante");
            lstHistorico.Items.Add("19. Juninho Pernambucano – Meia");
            lstHistorico.Items.Add("20. Ricardinho – Meia");

            lstHistorico.Items.Add("");
            lstHistorico.Items.Add("--- ATACANTES ---");
            lstHistorico.Items.Add("7. Adriano – Atacante");
            lstHistorico.Items.Add("9. Ronaldo – Atacante");
            lstHistorico.Items.Add("21. Fred – Atacante");
            lstHistorico.Items.Add("23. Robinho – Atacante");
        }

        // Avaliar Jogador
        private void AvaliarJogador()
        {
            Limpar();

            lstHistorico.Items.Add("Dida – Nota: 8.0 – Seguro nas defesas e firme no gol.");
            lstHistorico.Items.Add("Lúcio – Nota: 8.5 – Craque na zaga, ótimo poder de recuperação.");
            lstHistorico.Items.Add("Juan – Nota: 8.0 – Muito técnico e eficiente no desarme.");
            lstHistorico.Items.Add("Cafu – Nota: 6.5 – Regular, sofreu com o ritmo físico.");
            lstHistorico.Items.Add("Roberto Carlos – Nota: 6.0 – Ficou marcado no jogo decisivo.");
            lstHistorico.Items.Add("Zé Roberto – Nota: 9.0 – O melhor jogador do Brasil no torneio.");
            lstHistorico.Items.Add("Gilberto Silva – Nota: 7.5 – Cumpriu bem a função tática.");
            lstHistorico.Items.Add("Kaká – Nota: 8.0 – Decisivo com gol na estreia e boas jogadas.");
            lstHistorico.Items.Add("Ronaldinho Gaúcho – Nota: 6.0 – Abaixo da expectativa gerada.");
            lstHistorico.Items.Add("Ronaldo – Nota: 8.0 – Craque, marcou 3 gols e bateu recordes.");
            lstHistorico.Items.Add("Adriano – Nota: 7.0 – Razoável, marcou gols importantes.");
            lstHistorico.Items.Add("Robinho – Nota: 7.5 – Excelente vindo do banco de reservas.");
            lstHistorico.Items.Add("Juninho Pernambucano – Nota: 7.5 – Titularidade importante contra o Japão.");
        }

        // Ver Histórico
        private void VerHistorico()
        {
            Limpar();

            lstHistorico.Items.Add("--- RESUMO DA COPA DE 2006 ---");
            lstHistorico.Items.Add("Partidas: 5 | Vitórias: 4 | Derrotas: 1 | Gols Pró: 10 | Gols Contra: 2");
            lstHistorico.Items.Add("");
            lstHistorico.Items.Add("--- FASE DE GRUPOS ---");
            lstHistorico.Items.Add("13/06/2006: Brasil 1 x 0 Croácia (Gol: Kaká)");
            lstHistorico.Items.Add("18/06/2006: Brasil 2 x 0 Austrália (Gols: Adriano, Fred)");
            lstHistorico.Items.Add("22/06/2006: Japão 1 x 4 Brasil (Gols: Ronaldo 2x, Juninho, Gilberto)");
            lstHistorico.Items.Add("");
            lstHistorico.Items.Add("--- OITAVAS DE FINAL ---");
            lstHistorico.Items.Add("27/06/2006: Brasil 3 x 0 Gana (Gols: Ronaldo, Adriano, Zé Roberto)");
            lstHistorico.Items.Add("");
            lstHistorico.Items.Add("--- QUARTAS DE FINAL ---");
            lstHistorico.Items.Add("01/07/2006: Brasil 0 x 1 França (Eliminação)");
        }

        // Substituição
        private void Substituicao()
        {
            Limpar();


            lstHistorico.Items.Add("Substituições!!!");
            lstHistorico.Items.Add("");
            lstHistorico.Items.Add("Brasil x Croácia:");
            lstHistorico.Items.Add(" - Sai: Ronaldo | Entra: Robinho");
            lstHistorico.Items.Add("");
            lstHistorico.Items.Add("Brasil x Austrália:");
            lstHistorico.Items.Add(" - Sai: Adriano | Entra: Fred (Gol logo após entrar)");
            lstHistorico.Items.Add(" - Sai: Emerson | Entra: Gilberto Silva");
            lstHistorico.Items.Add("");
            lstHistorico.Items.Add("Brasil x Gana:");
            lstHistorico.Items.Add(" - Sai: Emerson | Entra: Gilberto Silva");
            lstHistorico.Items.Add(" - Sai: Adriano | Entra: Ricardinho");
            lstHistorico.Items.Add("");
            lstHistorico.Items.Add("Brasil x França:");
            lstHistorico.Items.Add(" - Sai: Cafu | Entra: Cícero");
            lstHistorico.Items.Add(" - Sai: Juninho | Entra: Adriano");
            lstHistorico.Items.Add(" - Sai: Kaká | Entra: Robinho");
        }

        // Encerrar
        private void Encerrar()
        {
            DialogResult resposta = MessageBox.Show(
                "Tem certeza que deseja encerrar o sistema do técnico?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resposta == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Limpar()
        {
            lstHistorico.Items.Clear();
        }
        private void btnVerificar_Click(object sender, EventArgs e)
        {
            string textoDigitado = cbBoxNumero.Text.Trim();

            // Pega o primeiro dígito para funcionar tanto digitado quanto selecionado
            if (!string.IsNullOrEmpty(textoDigitado) && char.IsDigit(textoDigitado[0]))
            {
                int opcao = int.Parse(textoDigitado[0].ToString());

                // switch 
                switch (opcao)
                {
                    case 1:
                        MostrarEscalacao();
                        break;

                    case 2:
                        AvaliarJogador();
                        break;

                    case 3:
                        VerHistorico();
                        break;

                    case 4:
                        Substituicao();
                        break;

                    case 5:
                        Encerrar();
                        break;

                    default:
                        MessageBox.Show("Selecione uma opção válida entre 1 e 5.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                }
            }
            else
            {
                MessageBox.Show("Por favor, digite ou selecione um número de 1 a 5.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Encerrar();
        }

        private void btnSubstituição_Click(object sender, EventArgs e)
        {
            Substituicao();
        }

        private void cbBoxNumero_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void lstHistorico_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}