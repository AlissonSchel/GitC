using MVCProject.Model;
using MVCProject.View;
using MVCProject.View.Adicionar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmPrincipal telaPrincipal = new frmPrincipal();
            telaLogin telalogin = new telaLogin();

            telalogin.ShowDialog();

            if (telalogin.isLogged == true)
            {
                telaPrincipal.ShowDialog();
            }
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            frmAddUsuario telaAddUsuario = new frmAddUsuario();

            telaAddUsuario.ShowDialog();

            if (telaAddUsuario.modelUsuario.Nome != null)
            {
                this.usuariosTableAdapter1.Insert(
                    telaAddUsuario.modelUsuario.Nome,
                    telaAddUsuario.modelUsuario.Login,
                    telaAddUsuario.modelUsuario.Senha,
                    telaAddUsuario.modelUsuario.Email,
                    telaAddUsuario.modelUsuario.Ativo,
                    telaAddUsuario.modelUsuario.UsuInc,
                    telaAddUsuario.modelUsuario.UsuAlt,
                    telaAddUsuario.modelUsuario.DatInc,
                    telaAddUsuario.modelUsuario.DatAlt);
            }
        }
    }
}
