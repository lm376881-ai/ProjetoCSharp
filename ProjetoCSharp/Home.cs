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
            Cadastro cadastroForm = new Cadastro(); // instanciando o form Cadastro
            cadastroForm.Show(); // abre em janela normal
                                 // cadastroForm.ShowDialog(); // abre como janela modal (bloqueia até fechar)
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

        private void convocacaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Convocacao convocacaoForm = new Convocacao();
            convocacaoForm.Show();
        }
    }
}
