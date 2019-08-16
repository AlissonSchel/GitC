using CadastroAluno.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroAluno
{
    public partial class TelaDeCadastro : Form
    {
        public TelaDeCadastro()
        {
            InitializeComponent();
        }

        public Aluno novoAluno = new Aluno();

        private void Button1_Click(object sender, EventArgs e)
        {
            novoAluno.Nome = txbNome.Text;
            novoAluno.Idade = (int)numIdade.Value;

            this.Close();
        }
    }
}
