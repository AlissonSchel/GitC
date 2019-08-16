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
    public partial class frmAddUsuario : Form
    {
        public frmAddUsuario()
        {
            InitializeComponent();
        }
        public modelUsuario usuariosRow;
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            usuariosRow = new modelUsuario
            {
                Nome = tbxNome.Text
            };

            this.Close();
        }
    }
}
