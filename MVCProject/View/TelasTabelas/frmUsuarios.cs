using MVCProject.View.Adicionar;
using MVCProject.View.Editar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCProject.View
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Usuarios' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Usuarios);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var usuarioLocacao = ((System.Data.DataRowView)this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row as MVCProject.SistemaBibliotecaDBDataSet.UsuariosRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    {
                        this.usuariosTableAdapter.SetNaoAtivoQuery(usuarioLocacao.Id);
                        this.usuariosTableAdapter.SelectAtivos(sistemaBibliotecaDBDataSet.Usuarios);
                    }
                    break;
                case 1:
                    {
                        frmEditUsuario telaEditarLocacao = new frmEditUsuario();
                        telaEditarLocacao.UsuariosRow = usuarioLocacao;
                        telaEditarLocacao.ShowDialog();
                        this.usuariosTableAdapter.SelectAtivos(this.sistemaBibliotecaDBDataSet.Usuarios);
                    }
                    break;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAddUsuario telaAddUsuario = new frmAddUsuario();

            telaAddUsuario.ShowDialog();

            if (!string.IsNullOrEmpty(telaAddUsuario.modelUsuario?.Nome))
            {
                this.usuariosTableAdapter.Insert(
                    telaAddUsuario.modelUsuario.Nome,
                    telaAddUsuario.modelUsuario.Login,
                    telaAddUsuario.modelUsuario.Email,
                    telaAddUsuario.modelUsuario.Senha,
                    telaAddUsuario.modelUsuario.Ativo,
                    telaAddUsuario.modelUsuario.UsuAlt,
                    telaAddUsuario.modelUsuario.UsuInc,
                    telaAddUsuario.modelUsuario.DatAlt,
                    telaAddUsuario.modelUsuario.DatInc
                    );
            }
        }
    }
}
