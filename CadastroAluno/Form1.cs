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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public List<Aluno> alunos = new List<Aluno>();

        private void Button1_Click(object sender, EventArgs e)
        {
            TelaDeCadastro cadastro = new TelaDeCadastro();
            cadastro.ShowDialog();
            alunos.Add(cadastro.novoAluno);
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
