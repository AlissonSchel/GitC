using System;
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
    public partial class frmEditEditora : Form
    {
        public frmEditEditora()
        {
            InitializeComponent();
        }
        public MVCProject.SistemaBibliotecaDBDataSet.EditorasRow EditorasRow;
        private void Button1_Click(object sender, EventArgs e)
        {
            EditorasRow.Nome = txbNome.Text;
            EditorasRow.Descricao = txbDescricao.Text;
            this.editorasTableAdapter1.Update(EditorasRow);
            this.Close();
        }

        private void FrmEditEditora_Load(object sender, EventArgs e)
        {
            try
            {
                txbNome.Text = EditorasRow.Nome;
                txbDescricao.Text = EditorasRow.Descricao;
            }
            catch (Exception)
            {

            }
        }
    }
}
