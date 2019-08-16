using MVCProject.Classes;
using MVCProject.Model;
using MVCProject.View;
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

namespace MVCProject
{
    public partial class telaLogin : Form
    {
        public telaLogin()
        {
            InitializeComponent();
        }

        public bool isLogged { get; set; } = false;

        public static string nomeUsuario { get; set; }

        public Usuario modelUsuario = new Usuario();

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            var login = txbLogin.Text;
            var senha = txbSenha.Text;

            // Verifica se login foi informado
            if (this.usuariosTableAdapter1.verificaLogin(login) != null)
            {
                // Pega a senha do banco e converte para Bytes
                var senhaDB = this.usuariosTableAdapter1.GetSenhaFromDB(login).ToString();
                byte[] hashBytes = Convert.FromBase64String(senhaDB);

                // Pega a senha digitada no login para comparar com a do banco
                byte[] salt = new byte[16];
                Array.Copy(hashBytes, 0, salt, 0, 16);
                var pbkdf2 = new Rfc2898DeriveBytes(senha, salt, 10000);
                byte[] hash = pbkdf2.GetBytes(20);

                // Realiza a comparação entre a senha digitada e a do banco de dados
                for (int i = 0; i < 20; i++)
                {
                    if (hashBytes[i + 16] != hash[i])
                    {
                        isLogged = false;
                    }
                    else
                    {
                        isLogged = true;
                        nomeUsuario = this.usuariosTableAdapter1.GetNome(login);
                        this.Close();
                    }

                    if (isLogged == false)
                        MessageBox.Show("Senha incorreta!");
                }
            }
            else
            {
                MessageBox.Show("Usuário Incorreto!");
            }
        }
    }
}
