﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCProject.View.Editar
{
    public partial class frmEditGenero : Form
    {
        public frmEditGenero()
        {
            InitializeComponent();
        }

        public MVCProject.SistemaBibliotecaDBDataSet.GenerosRow GenerosRow;

        private void FrmEditGenero_Load(object sender, EventArgs e)
        {
            try
            {
                txbNome.Text = GenerosRow.Tipo;
                txbDescricao.Text = GenerosRow.Descricao;
            }
            catch (Exception)
            {

            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            GenerosRow.Tipo = txbNome.Text;
            GenerosRow.Descricao = txbDescricao.Text;
            this.generosTableAdapter1.Update(GenerosRow);
            this.Close();
        }
    }
}
