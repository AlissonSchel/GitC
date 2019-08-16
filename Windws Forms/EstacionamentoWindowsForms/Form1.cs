using EstacionamentoWindowsForms.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstacionamentoWindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public List<Carro> listaCarros = new List<Carro>();
        private void Button1_Click(object sender, EventArgs e)
        {
            CadastrarCarro cadastro = new CadastrarCarro();
            cadastro.ShowDialog();
            listaCarros.Add(cadastro.novoCarro);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
