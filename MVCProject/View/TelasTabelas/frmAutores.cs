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
    public partial class frmAutores : Form
    {
        public frmAutores()
        {
            InitializeComponent();
        }

        private void FrmAutores_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Autores' table. You can move, or remove it, as needed.
            this.autoresTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Autores);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAddAutores telaAddAutores = new frmAddAutores();

            telaAddAutores.ShowDialog();

            if (!string.IsNullOrEmpty(telaAddAutores.modelAutores?.Nome))
            {
                this.autoresTableAdapter.Insert(
                    telaAddAutores.modelAutores.Nome,
                    telaAddAutores.modelAutores.Descicao
                    );
                this.autoresTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Autores);
            }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var autorSelect = ((System.Data.DataRowView)this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row as MVCProject.SistemaBibliotecaDBDataSet.AutoresRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    {
                        frmEditAutores telaEditAutor = new frmEditAutores();
                        telaEditAutor.AutoresRow = autorSelect;
                        telaEditAutor.ShowDialog();
                        this.autoresTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Autores);
                    }
                    break;
            }

        }
    }
}
