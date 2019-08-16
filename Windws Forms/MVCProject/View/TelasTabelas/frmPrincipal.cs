using MVCProject.View.TelasTabelas;
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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void UsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarios telaUsuarios = new frmUsuarios();

            telaUsuarios.ShowDialog();
        }

        private void AutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAutores telaAutores = new frmAutores();

            telaAutores.ShowDialog();
        }

        private void GênerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGeneros telaGeneros = new frmGeneros();

            telaGeneros.ShowDialog();
        }

        private void LivrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLivros telaLivros = new frmLivros();

            telaLivros.ShowDialog();
        }

        private void LocaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLocacao telaLocacao = new frmLocacao();

            telaLocacao.ShowDialog();
        }

        private void EditorasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditoras telaEditoras = new frmEditoras();

            telaEditoras.ShowDialog();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            timer1.Start();
            label2.Text = "Olá " + telaLogin.nomeUsuario + ". Seja bem-vindo(a)!";
        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}