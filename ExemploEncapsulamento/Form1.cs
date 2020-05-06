using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploEncapsulamento
{
    public partial class FrmAluno : Form
    {
        public FrmAluno()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            Aluno objAluno = new Aluno();

            objAluno.Matricula = int.Parse(txtMatricula.Text);      //quando se faz uma atribuição está acontecendo um SET
            objAluno.Nome = txtNome.Text;
            objAluno.Email = txtEmail.Text;
            objAluno.NumChamada = int.Parse(txtNumCh.Text);

            MessageBox.Show("Dados do aluno: \n\n" + objAluno.Nome + "\nE-mail: " + objAluno.Email);    //GET para buscar os valores armazenados

        }
    }
}
