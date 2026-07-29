using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoCSharp.Properties;

namespace ProjetoCSharp
{
    public partial class VerificadorDePosicao : Form
    {
        public VerificadorDePosicao()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void numPosicoes_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnVerificarPosição_Click(object sender, EventArgs e)
        {
            int numero = (int)numPosicoes.Value;

            string posicao;
            Bitmap imagemJogador = null;

            switch (numero)
            {
                case 1:
                    posicao = "Goleiro";
                    imagemJogador = new Bitmap(@"Resources\goleiro1.jpg");
                    break;

                case 2:
                case 3:
                case 4:
                case 5:
                    posicao = "Defesa";
                    imagemJogador = new Bitmap(@"Resources\zagueiro.jpg");
                    break;

                case 6:
                case 7:
                case 8:
                    posicao = "Meio-campo";
                    imagemJogador = new Bitmap(@"Resources\meiocampo.jpg");
                    break;

                case 9:
                case 10:
                case 11:
                    posicao = "Ataque";
                    imagemJogador = new Bitmap(@"Resources\atacante.jpg");
                    break;

                default:
                    posicao = "Número inválido (escolha de 1 a 11)";
                    imagemJogador = null;
                    break;
            }

            if (imagemJogador != null)
            {
                picPosicao.Image = imagemJogador;
                picPosicao.Visible = true;
            }
            else
            {
                picPosicao.Visible = false;
            }

            MessageBox.Show($"Posição: {posicao}", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}