using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TabelaDeVisualizacaoDeValores.Model;

namespace TabelaDeVisualizacaoDeValores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Contrac> listContracs = new List<Contrac>();

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            listContracs.Add(new Contrac()
            {
                Id = listContracs.Count,
                Value = new Random().Next(100),
                DatInc = DateTime.Now
            });
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listContracs;
        }



        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                var CollumId = dataGridView1.Rows[e.RowIndex].Cells[0];
                var CollumValue = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];

                switch (e.ColumnIndex)
                {
                    case 0: { MessageBox.Show("Nao é possível ajustar a coluna."); }break;
                    case 1: {
                        if (MessageBox.Show("Deseja realmente ajustar este valor?", " Edição", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            listContracs.FirstOrDefault(x => x.Id == (int)CollumId.Value).Value = (int)CollumValue.Value;
                        }
                    } break;
                    case 2: {
                            var dataInformada = DateTime.Parse(CollumValue.Value.ToString());
                            if (MessageBox.Show("Deseja realmente ajustar este valor?", " Edição", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                listContracs.FirstOrDefault(x => x.Id == (int)CollumId.Value).DatInc = DateTime.Parse(CollumValue.Value.ToString());
                            } else
                            {
                                MessageBox.Show("Não foi possível alterar o registro de data.");
                            }
                        }
                        break;
                }
            }
        }
    }
}
