using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewDoSocorro.Adicionar
{
    public partial class frmAddCliente : Form
    {
        public frmAddCliente()
        {
            InitializeComponent();
        }

        DataGridViewDoSocorro.ParteFinalLocadoraTSQLDataSet.ClientesRow carrosRow;

        public string novoCliente;

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            novoCliente = tbxNome.Text;

            this.clientesTableAdapter1.InsertCliente(novoCliente);

            this.Close();
        }

        private void FrmAddCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
