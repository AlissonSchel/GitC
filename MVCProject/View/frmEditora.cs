﻿using MVCProject.View.Adicionar;
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
    public partial class frmEditora : Form
    {
        public frmEditora()
        {
            InitializeComponent();
        }

        private void FrmEditora_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Editoras' table. You can move, or remove it, as needed.
            this.editorasTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Editoras);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAddEditora telaAddEditora = new frmAddEditora();

            telaAddEditora.ShowDialog();
        }
    }
}
