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
    public partial class frmAddLivros : Form
    {
        public frmAddLivros()
        {
            InitializeComponent();
        }
        public Livro modelLivro = new Livro();
        private void Button1_Click(object sender, EventArgs e)
        {
            modelLivro = new Livro
            {
                Titulo = txbTitulo.Text,
                Registro = (int)numRegistro.Value,
                Isbn = txbIsbn.Text,
                Genero = (int)boxGenero.SelectedValue,
                Editoria = (int)boxEditora.SelectedValue,
                Sinopse = txbSinopse.Text,
                Observacoes = txbObs.Text
            };
            this.Close();
        }
        private void FrmAddLivros_Load_1(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistemaBibliotecaDBDataSet.Editoras'. Você pode movê-la ou removê-la conforme necessário.
            this.editorasTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Editoras);
            // TODO: esta linha de código carrega dados na tabela 'sistemaBibliotecaDBDataSet.Generos'. Você pode movê-la ou removê-la conforme necessário.
            this.generosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Generos);
        }
    }
}
