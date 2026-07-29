using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ProjetoCSharp
{
    public partial class SelecaoDeCampeonato : Form
    {
        public SelecaoDeCampeonato()
        {
            InitializeComponent();
        }
        private string ObterTipoCompeticao(int opcao)
        {
            switch (opcao)
            {
                case 1:
                    return "Amistoso";
                case 2:
                    return "Eliminatórias";
                case 3:
                    return "Copa América";
                case 4:
                    return "Copa do Mundo";
                default:
                    return "Opção inválida";
            }
        }
        private string ObterNomeArquivoImagem(int opcao)
        {
            switch (opcao)
            {
                case 1:
                    return "amistoso.jpg";
                case 2:
                    return "Eliminatorias.jpg";
                case 3:
                    return "CopaAmerica.jpg";
                case 4:
                    return "CopadoMundo.jpg";
                default:
                    return null;
            }
        }

        private void btnVerificarCompeticao_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int opcao))
            {
                string competicao = ObterTipoCompeticao(opcao);
                string nomeImagem = ObterNomeArquivoImagem(opcao);

                if (!string.IsNullOrEmpty(nomeImagem))
                {
                    string caminhoImagem = Path.Combine(Application.StartupPath, "Resources", nomeImagem);

                    if (File.Exists(caminhoImagem))
                    {
                        if (pictureBox1.Image != null)
                        {
                            pictureBox1.Image.Dispose();
                        }

                        pictureBox1.Image = Image.FromFile(caminhoImagem);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox1.Visible = true;
                    }
                    else
                    {
                        pictureBox1.Visible = false;
                        MessageBox.Show($"Imagem não encontrada no caminho:\n{caminhoImagem}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    pictureBox1.Visible = false;
                }

                MessageBox.Show($"Competição: {competicao}", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                pictureBox1.Visible = false;
                MessageBox.Show("Por favor, insira um número de opção válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
    }
}