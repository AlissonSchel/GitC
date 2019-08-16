using MVCProject.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCProject.View.Adicionar
{
    public partial class frmAddLocacao : Form
    {
        public frmAddLocacao()
        {
            InitializeComponent();
        }

        public Locacao modelLocacao = new Locacao();

        private void FrmAddLocacao_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistemaBibliotecaDBDataSet.Usuarios'. Você pode movê-la ou removê-la conforme necessário.
            this.usuariosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Usuarios);
            // TODO: esta linha de código carrega dados na tabela 'sistemaBibliotecaDBDataSet.Livros'. Você pode movê-la ou removê-la conforme necessário.
            this.livrosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Livros);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            modelLocacao = new Locacao
            {
                Livro = (int)boxLivro.SelectedValue,
                Usuario = (int)boxUsuario.SelectedValue,
                Tipo = (int)numTipo.Value,
                Devolucao = dtpDevolucao.Value
            };
            this.Close();
        }

        private void BoxLivro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BoxUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NumTipo_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
