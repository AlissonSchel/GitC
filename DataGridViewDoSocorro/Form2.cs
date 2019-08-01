using DataGridViewDoSocorro.Edicao;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'parteFinalLocadoraTSQLDataSet.Carros' table. You can move, or remove it, as needed.
            this.carrosTableAdapter.CustomQuery(this.parteFinalLocadoraTSQLDataSet.Carros);

        }

        private void BtnCarros_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var carSelect = ((System.Data.DataRowView)this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row 
                as DataGridViewDoSocorro.ParteFinalLocadoraTSQLDataSet.CarrosRow;

            switch (e.ColumnIndex)
            {
            case 0:
            {
                this.carrosTableAdapter.SetNaoAtivoQuery(carSelect.Id);
                this.carrosTableAdapter.CustomQuery(parteFinalLocadoraTSQLDataSet.Carros);
            }
            break;
                case 1:
                    {
                        frmEdicaoCarros editCarro = new frmEdicaoCarros();
                        editCarro.CarrosRow = carSelect;
                        editCarro.ShowDialog();
                    }
            break;
            }

            
        }
    }
}
