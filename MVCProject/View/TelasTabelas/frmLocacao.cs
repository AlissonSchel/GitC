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

namespace MVCProject.View.TelasTabelas
{
    public partial class frmLocacao : Form
    {
        public frmLocacao()
        {
            InitializeComponent();
        }

        private void FrmLocacao_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistemaBibliotecaDBDataSet.Locacao'. Você pode movê-la ou removê-la conforme necessário.
            this.locacaoTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Locacao);
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            frmAddLocacao telaAddLocacao = new frmAddLocacao();

            telaAddLocacao.ShowDialog();

            if (!string.IsNullOrEmpty(telaAddLocacao.modelLocacao?.Livro.ToString()))
            {
                this.locacaoTableAdapter.Insert(
                telaAddLocacao.modelLocacao.Livro,
                telaAddLocacao.modelLocacao.Usuario,
                telaAddLocacao.modelLocacao.Tipo,
                telaAddLocacao.modelLocacao.Devolucao,
                telaAddLocacao.modelLocacao.Ativo,
                telaAddLocacao.modelLocacao.UsuInc,
                telaAddLocacao.modelLocacao.UsuAlt,
                telaAddLocacao.modelLocacao.DatInc,
                telaAddLocacao.modelLocacao.DatAlt
                );
                this.locacaoTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Locacao);
            }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var locacaoSelect = ((System.Data.DataRowView)this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row as MVCProject.SistemaBibliotecaDBDataSet.LocacaoRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    {
                        this.locacaoTableAdapter.SetNaoAtivoQuery(locacaoSelect.Id);
                        this.locacaoTableAdapter.SelectAtivos(sistemaBibliotecaDBDataSet.Locacao);
                    }
                    break;
                case 1:
                    {
                        frmEditLocacao telaEditarLocacao = new frmEditLocacao();
                        telaEditarLocacao.LocacaoRow = locacaoSelect;
                        telaEditarLocacao.ShowDialog();
                        this.locacaoTableAdapter.SelectAtivos(this.sistemaBibliotecaDBDataSet.Locacao);
                    }
                    break;
            }
        }
    }
}
