using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        Random rand;

        public Form1()
        {
            InitializeComponent();
            rand = new Random();
        }

        private byte[] GetRandomBytes(int n)
        {
            var randomBytes = new byte[n];
            rand.NextBytes(randomBytes);
            return randomBytes;
        }

        private void Diga_Ola_Click(object sender, EventArgs e)
        {
            byte[] rgb = GetRandomBytes(3);

            // Cria uma cor sólida aleatória usando 3 numeros aleatorios.
            var corAleatoria = new SolidColorBrush(Color.FromArgb(255, rgb[0], rgb[1], rgb[2]));
        }
    }
}
