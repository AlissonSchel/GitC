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
    public partial class frmEditLocacao : Form
    {
        public frmEditLocacao()
        {
            InitializeComponent();
        }

        public MVCProject.SistemaBibliotecaDBDataSet.LocacaoRow LocacaoRow;

        private void FrmEditLocacao_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistemaBibliotecaDBDataSet.Usuarios'. Você pode movê-la ou removê-la conforme necessário.
            this.usuariosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Usuarios);
            // TODO: esta linha de código carrega dados na tabela 'sistemaBibliotecaDBDataSet.Livros'. Você pode movê-la ou removê-la conforme necessário.
            this.livrosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Livros);

            try
            {
                boxLivro.SelectedValue = LocacaoRow.Livro;
                boxUsuario.SelectedValue = LocacaoRow.Usuario;
                numTipo.Value = LocacaoRow.Tipo;
                dtpDevolucao.Value = LocacaoRow.Devolucao;
            }
            catch (Exception)
            {
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            LocacaoRow.Livro = (int)boxLivro.SelectedValue;
            LocacaoRow.Usuario = (int)boxUsuario.SelectedValue;
            LocacaoRow.Tipo = (int)numTipo.Value;
            LocacaoRow.Devolucao = dtpDevolucao.Value;
            this.Close();
        }
    }
}
