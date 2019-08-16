using MVCProject.Classes;
using MVCProject.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCProject.View.Adicionar
{
    public partial class frmAddUsuario : Form
    {
        public frmAddUsuario()
        {
            InitializeComponent();
        }

        public Usuario modelUsuario = new Usuario();

        private void Button1_Click(object sender, EventArgs e)
        {
            passwordHashing encryptPassword = new passwordHashing();

            var senha = encryptPassword.PasswordHash(txbSenha.Text);

            modelUsuario = new Usuario
            {
                Nome = txbNome.Text,
                Email = txbEmail.Text,
                Login = txbLogin.Text,
                Senha = senha
            };

            this.Close();
        }
    }
}
