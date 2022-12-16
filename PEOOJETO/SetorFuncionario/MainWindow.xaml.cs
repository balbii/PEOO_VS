using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace SetorFuncionario
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private Setor set;
        private void criarsetor_Click(object sender, RoutedEventArgs e)
        {
            set = new Setor(nomesetor.Text, siglasetor.Text);
            adicionarfuncionario.IsEnabled = true;
            lista.Items.Clear();
        }
        private void adicionarfuncionario_Click(object sender, RoutedEventArgs e)
        {
            Funcionario f1 = new Funcionario(nomeFuncionario.Text, matriculafuncionario.Text, emailfuncionario.Text, double.Parse(salariofuncionario.Text));
            set.Inserir(f1);
            lista.Items.Add(f1);
            nomeFuncionario.Text = "";
            matriculafuncionario.Text = "";
            emailfuncionario.Text = "";
            salariofuncionario.Text = "";
        }

        private void btnMedia_Click(object sender, RoutedEventArgs e)
        {
            mostrarMedia.Text = "R$" + set.MediaSalario().ToString("0.00");
        }
    }
}
