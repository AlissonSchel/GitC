﻿using MVCProject.Model;
using MVCProject.View;
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
    public partial class telaLogin : Form
    {
        public telaLogin()
        {
            InitializeComponent();
        }

        public bool isLogged { get; set; } = false;

        public Usuario modelUsuario = new Usuario();

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            var login = txbLogin.Text;
            var senha = txbSenha.Text;

            

            if (this.usuariosTableAdapter1.verificaLogin(login, senha) != null)
            {
                isLogged = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário não encontrado.");
            }
        }
    }
}