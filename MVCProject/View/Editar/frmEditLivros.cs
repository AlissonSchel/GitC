using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCProject.View.Editar
{
    public partial class frmEditLivros : Form
    {
        public frmEditLivros()
        {
            InitializeComponent();
        }

        public MVCProject.SistemaBibliotecaDBDataSet.LivrosRow LivrosRow;

        private void FrmEditLivros_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistemaBibliotecaDBDataSet.Editoras'. Você pode movê-la ou removê-la conforme necessário.
            this.editorasTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Editoras);
            // TODO: esta linha de código carrega dados na tabela 'sistemaBibliotecaDBDataSet.Generos'. Você pode movê-la ou removê-la conforme necessário.
            this.generosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Generos);
            try
            {
                txbTitulo.Text = LivrosRow.Titulo;
                txbIsbn.Text = LivrosRow.Isbn;
                txbObs.Text = LivrosRow.Observacoes;
                txbSinopse.Text = LivrosRow.Sinopse;
                numRegistro.Value = LivrosRow.Registro;
                boxEditora.SelectedValue = LivrosRow.Editora;
                boxGenero.SelectedValue = LivrosRow.Genero;
            }
            catch (Exception)
            {

            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            LivrosRow.Titulo = txbTitulo.Text;
            LivrosRow.Isbn = txbIsbn.Text;
            LivrosRow.Observacoes = txbObs.Text;
            LivrosRow.Sinopse = txbSinopse.Text;
            LivrosRow.Registro = (int)numRegistro.Value;
            LivrosRow.Editora = (int)boxEditora.SelectedValue;
            LivrosRow.Genero = (int)boxGenero.SelectedValue;

            this.livrosTableAdapter1.Update(LivrosRow);
            this.Close();
        }
    } 
}           
            
            
            