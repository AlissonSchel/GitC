using MVCProject.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCProject.View.Adicionar
{
    public partial class frmAddEditoras : Form
    {
        public frmAddEditoras()
        {
            InitializeComponent();
        }
        public Editora modelEditora = new Editora();
        private void Button1_Click(object sender, EventArgs e)
        {
            modelEditora = new Editora
            {
                Nome = txbNome.Text,
                Descricao = txbDescricao.Text
            };
            this.Close();
        }
    }
}
