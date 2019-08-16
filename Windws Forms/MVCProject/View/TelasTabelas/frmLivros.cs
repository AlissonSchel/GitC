using MVCProject.View.Adicionar;
using MVCProject.View.Editar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCProject.View
{
    public partial class frmLivros : Form
    {
        public frmLivros()
        {
            InitializeComponent();
        }

        private void FrmLivros_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet3.Livros' table. You can move, or remove it, as needed.
            this.livrosTableAdapter.FillBy(this.sistemaBibliotecaDBDataSet3.Livros);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAddLivros telaAddLivros = new frmAddLivros();

            telaAddLivros.ShowDialog();

            if (!string.IsNullOrEmpty(telaAddLivros.modelLivro?.Titulo))
            {
                this.livrosTableAdapter.Insert(
                telaAddLivros.modelLivro.Registro,
                telaAddLivros.modelLivro.Titulo,
                telaAddLivros.modelLivro.Isbn,
                telaAddLivros.modelLivro.Genero,
                telaAddLivros.modelLivro.Editoria,
                telaAddLivros.modelLivro.Sinopse,
                telaAddLivros.modelLivro.Observacoes,
                telaAddLivros.modelLivro.Ativo,
                telaAddLivros.modelLivro.UsuInc,
                telaAddLivros.modelLivro.UsuAlt,
                telaAddLivros.modelLivro.DatInc,
                telaAddLivros.modelLivro.DatAlt
                );
                this.livrosTableAdapter.SelectAtivos(this.sistemaBibliotecaDBDataSet.Livros);
            }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var livroSelect = ((System.Data.DataRowView)this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row as MVCProject.SistemaBibliotecaDBDataSet.LivrosRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    {
                        this.livrosTableAdapter.SetNaoAtivoQuery(livroSelect.Id);
                        this.livrosTableAdapter.SelectAtivos(sistemaBibliotecaDBDataSet.Livros);
                    }
                    break;
                case 1:
                    {
                        frmEditLivros telaEditarLivro = new frmEditLivros();
                        telaEditarLivro.LivrosRow = livroSelect;
                        telaEditarLivro.ShowDialog();
                        this.livrosTableAdapter.SelectAtivos(this.sistemaBibliotecaDBDataSet.Livros);
                    }
                    break;
            }
        }
    }
}
