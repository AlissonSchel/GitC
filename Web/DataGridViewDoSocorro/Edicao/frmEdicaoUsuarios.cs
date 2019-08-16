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
    public partial class frmEdicaoUsuarios : Form
    {
        public frmEdicaoUsuarios()
        {
            InitializeComponent();
        }

        public ParteFinalLocadoraTSQLDataSet.UsuariosRow UsuariosRow { get; internal set; }

        private void FrmEdicaoUsuarios_Load(object sender, EventArgs e)
        {
            txbNome.Text = UsuariosRow.Nome;
        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            UsuariosRow.Nome = txbNome.Text;
            UsuariosRow.DatAlt = DateTime.Now;

            this.usuariosTableAdapter1.Update(UsuariosRow);
        }
    }
}
