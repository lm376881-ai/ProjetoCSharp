using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjetoCSharp
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }

        private void txtNomeCompleto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefoneEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtNomeCompleto.Text))
            {
                MessageBox.Show("O campo Nome Completo é obrigatório.");
            }
            if (String.IsNullOrWhiteSpace(txtTelefoneEmail.Text))
            {
                MessageBox.Show("O campo Telefone/E-mail é obrigatório.");
            }

            if (String.IsNullOrWhiteSpace(txtSenha.Text))
            {
                MessageBox.Show("O campo Senha é obrigatório.");
            }
            if ((!ckMasculino.Checked) && (!ckFeminino.Checked) && (!ckOutro.Checked))
            {
                MessageBox.Show("O campo Sexo é obrigatório.");
            }
            else
            {
                MessageBox.Show("Cadastro realizado com sucesso!");
            }
        }
        private void ckMasculino_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ckFeminino_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ckOutro_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
