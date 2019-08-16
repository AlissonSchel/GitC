using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewDoSocorro
{
    public partial class Lixeira : Form
    {
        public Lixeira()
        {
            InitializeComponent();
        }

        private void Lixeira_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'parteFinalLocadoraTSQLDataSet.DataTable1' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter.GetAllInativo(this.parteFinalLocadoraTSQLDataSet.DataTable1);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var lixeiraGlobal = ((System.Data.DataRowView)this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row as DataGridViewDoSocorro.ParteFinalLocadoraTSQLDataSet.DataTable1Row;

            switch (lixeiraGlobal.Tabela)
            {
                case "clientes":
                    {
                        this.clientesTableAdapter1.SetAtivoQuery(lixeiraGlobal.Id);
                    }
                    break;
            }

            this.dataTable1TableAdapter.GetAllInativo(this.parteFinalLocadoraTSQLDataSet.DataTable1);
        }
    }
}
