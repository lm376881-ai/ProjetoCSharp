using System;
using System.Windows.Forms;

namespace ProjetoCSharp
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
        private void modulo1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro cadastroForm = new Cadastro();
            cadastroForm.Show();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculadora calcForm = new Calculadora();
            calcForm.Show();
        }

        private void idadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Idade idadeForm = new Idade();
            idadeForm.Show();
        }

        private void imparParToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImparPar imparParForm = new ImparPar();
            imparParForm.Show();
        }

        private void tabuadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tabuada tabuadaForm = new Tabuada();
            tabuadaForm.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void convocacaoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Convocacao convocacaoForm = new Convocacao();
            convocacaoForm.Show();
        }

        private void analiseDesempenhoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AnaliseDesempenho analiseDesempenhoForm = new AnaliseDesempenho();
            analiseDesempenhoForm.Show();
        }

        private void modulo2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void verificadorDePosicaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerificadorDePosicao verificadorPosicao = new VerificadorDePosicao();
            verificadorPosicao.Show();
        }

        private void selecaoDeCampeonatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelecaoDeCampeonato selCampeonato = new SelecaoDeCampeonato();
            selCampeonato.Show();
        }

        private void requisitoTecnicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RequisitoTecnicos requisitosTecnicos = new RequisitoTecnicos();
            requisitosTecnicos.Show();
        }
    }
}