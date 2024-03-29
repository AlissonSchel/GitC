﻿using MVCProject.View.Adicionar;
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
    public partial class frmEditoras : Form
    {
        public frmEditoras()
        {
            InitializeComponent();
        }

        private void FrmEditoras_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistemaBibliotecaDBDataSet.Editoras'. Você pode movê-la ou removê-la conforme necessário.
            this.editorasTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Editoras);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAddEditoras telaAddEditoras = new frmAddEditoras();

            telaAddEditoras.ShowDialog();

            if (!string.IsNullOrEmpty(telaAddEditoras.modelEditora?.Nome))
            {
                this.editorasTableAdapter.Insert(
                telaAddEditoras.modelEditora.Nome,
                telaAddEditoras.modelEditora.Descricao
                );
                this.editorasTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Editoras);
            }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var EditoraSelect = ((System.Data.DataRowView)this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row as MVCProject.SistemaBibliotecaDBDataSet.EditorasRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    {
                        frmEditEditora telaEditarEditora = new frmEditEditora();
                        telaEditarEditora.EditorasRow = EditoraSelect;
                        telaEditarEditora.ShowDialog();
                        this.editorasTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Editoras);
                    }
                    break;
            }
        }
    }
}
