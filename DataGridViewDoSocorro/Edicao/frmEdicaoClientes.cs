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
    public partial class frmEdicaoClientes : Form
    {
        public frmEdicaoClientes()
        {
            InitializeComponent();
        }

        public DataGridViewDoSocorro.ParteFinalLocadoraTSQLDataSet.ClientesRow ClientesRow;

        private void FrmEdicaoCarros_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'parteFinalLocadoraTSQLDataSet.Clientes' table. You can move, or remove it, as needed.
            this.clientesTableAdapter.Fill(this.parteFinalLocadoraTSQLDataSet.Clientes);

            textBox1.Text = ClientesRow.Cliente;
        }

        private void FillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.clientesTableAdapter.FillBy(this.parteFinalLocadoraTSQLDataSet.Clientes);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ClientesRow.Cliente = textBox1.Text;
            ClientesRow.DatAlt = DateTime.Now;

            this.clientesTableAdapter.Update(ClientesRow);
        }
    }
}
