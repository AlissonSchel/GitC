using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCProject.View.Editar
{
    public partial class frmEditAutores : Form
    {
        public frmEditAutores()
        {
            InitializeComponent();
        }

        public MVCProject.SistemaBibliotecaDBDataSet.AutoresRow AutoresRow;

        private void Button1_Click(object sender, EventArgs e)
        {
            AutoresRow.Nome = txbNome.Text;
            AutoresRow.Descricao = txbDescricao.Text;
            this.autoresTableAdapter1.Update(AutoresRow);
            this.Close();
        }

        private void FrmEditAutores_Load(object sender, EventArgs e)
        {
            try
            {
                txbNome.Text = AutoresRow.Nome;
                txbDescricao.Text = AutoresRow.Descricao;
            }
            catch (Exception)
            {
                
            }
        }
    }
}
