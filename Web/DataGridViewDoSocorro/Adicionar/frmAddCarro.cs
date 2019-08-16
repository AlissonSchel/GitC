using DataGridViewDoSocorro.Model;
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
    public partial class frmAddCarro : Form
    {
        public frmAddCarro()
        {
            InitializeComponent();
        }
        public ModelCarro carrosRow = new ModelCarro();
        private void FrmAddCarro_Load(object sender, EventArgs e)
        {

        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            carrosRow = new ModelCarro
            {
                Nome = tbxNome.Text,
                Observacao = txbObs.Text
            };
            this.Close();
        }
    }
}
