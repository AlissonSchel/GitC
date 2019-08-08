using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace cadastroWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public string Email { get; set; }
        public string Telefone { get; set; }
        public bool EmailCheck { get; set; }
        public bool TelefoneCheck { get; set; }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Email = tbxEmail.Text;
            Telefone = tbxTelefone.Text;

            var resultEmail = Regex.IsMatch(Email, "^[\\w!#$%&'*+/=?`{|}~^-]+(?:\\.[\\w!#$%&'*+/=?`{|}~^-]+)*@(?:[a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$");

            var resultTelefone = Regex.IsMatch(Telefone, @"\d{2}\s+\d{2}\s+\d{9}");
            

            if (resultEmail && resultTelefone)
            {
                MessageBox.Show("Sucesso!");
            }
            else
            {
                MessageBox.Show("Fail!");
            }
        }
    }
}
