﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewDoSocorro
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'parteFinalLocadoraTSQLDataSet.Usuarios' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter.CustomQuery(this.parteFinalLocadoraTSQLDataSet.Usuarios);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var userSelect = ((System.Data.DataRowView)this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row as DataGridViewDoSocorro.ParteFinalLocadoraTSQLDataSet.UsuariosRow;

            switch (e.ColumnIndex)
            {
            case 0:
                {
                    this.usuariosTableAdapter.SetNaoAtivoQuery(userSelect.Id);
                    this.usuariosTableAdapter.CustomQuery(parteFinalLocadoraTSQLDataSet.Usuarios);
                }
            break;
            }
        }
    }
}
