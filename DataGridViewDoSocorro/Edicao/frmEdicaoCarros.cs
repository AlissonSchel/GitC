using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewDoSocorro.Edicao
{
    public partial class frmEdicaoCarros : Form
    {
        public frmEdicaoCarros()
        {
            InitializeComponent();
        }

        public DataGridViewDoSocorro.ParteFinalLocadoraTSQLDataSet.CarrosRow CarrosRow;

        private void FrmEdicaoCarros_Load(object sender, EventArgs e)
        {
            try
            {
                txbNome.Text = CarrosRow.Nome;
                txbObs.Text = CarrosRow.Observacao;
            }
            catch (Exception)
            {

            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            CarrosRow.Nome = txbNome.Text;
            CarrosRow.Observacao = txbObs.Text;
            CarrosRow.DatAlt = DateTime.Now;

            this.carrosTableAdapter1.Update(CarrosRow);
        }
    }
}
