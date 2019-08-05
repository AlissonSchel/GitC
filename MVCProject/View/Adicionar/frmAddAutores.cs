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
    public partial class frmAddAutores : Form
    {
        public frmAddAutores()
        {
            InitializeComponent();
        }

        public Autor modelAutores = new Autor();

        private void Button1_Click(object sender, EventArgs e)
        {
            modelAutores = new Autor
            {
                Nome = txbNome.Text,
                Descicao = txbDescricao.Text
            };
            this.Close();
        }
    }
}
