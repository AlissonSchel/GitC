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
    public partial class CadastrarCarro : Form
    {
        public CadastrarCarro()
        {
            InitializeComponent();
        }

        public Carro novoCarro = new Carro();

        private void Button1_Click(object sender, EventArgs e)
        {
            novoCarro.Modelo = txbModelo.Text;
            novoCarro.Ano = (int)numAno.Value;
            novoCarro.Placa = txbModelo.Text;

            this.Close();
        }
    }
}
