using DataGridViewDoSocorro.Adicionar;
using DataGridViewDoSocorro.Edicao;
using System;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace DataGridViewDoSocorro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            login telaLogin = new login();

          


            // TODO: This line of code loads data into the 'parteFinalLocadoraTSQLDataSet.Clientes' table. You can move, or remove it, as needed.
            this.clientesTableAdapter.CustomQuery(this.parteFinalLocadoraTSQLDataSet.Clientes);
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            frmAddCliente frmNovoCliente = new frmAddCliente();

            frmNovoCliente.ShowDialog();

            this.clientesTableAdapter.CustomQuery(this.parteFinalLocadoraTSQLDataSet.Clientes);
        }

        private void BtnCarros_Click(object sender, EventArgs e)
        {
            Form2 frmCarros = new Form2();

            frmCarros.ShowDialog();
        }

        private void BtnUsuarios_Click(object sender, EventArgs e)
        {
            Form3 frmUsuarios = new Form3();

            frmUsuarios.ShowDialog();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var clientSelect = ((System.Data.DataRowView)this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row as DataGridViewDoSocorro.ParteFinalLocadoraTSQLDataSet.ClientesRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    {
                        this.clientesTableAdapter.SetNaoAtivoQuery(clientSelect.Id);
                        this.clientesTableAdapter.CustomQuery(parteFinalLocadoraTSQLDataSet.Clientes);
                    }
                    break;
                case 1:
                    {
                        frmEdicaoClientes editCliente = new frmEdicaoClientes();
                        editCliente.ClientesRow = clientSelect;
                        editCliente.ShowDialog();
                    }
                    break;
            }
        }
        private void BtnLixeira_Click(object sender, EventArgs e)
        {
            Lixeira lixo = new Lixeira();

            lixo.ShowDialog();

            this.clientesTableAdapter.CustomQuery(parteFinalLocadoraTSQLDataSet.Clientes);
        }
    }
}
