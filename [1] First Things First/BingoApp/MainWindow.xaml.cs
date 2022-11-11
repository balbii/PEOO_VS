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

namespace BingoApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Class1 b;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            txtNumBolas.Text = slider.Value.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            b = new Class1();
            b.Iniciar(int.Parse(txtNumBolas.Text));
            btnIniciar.IsEnabled = false;
            btnSortear.IsEnabled = true;
            txtSorteio.Clear();
            txtNum.Clear();
        }

        private void btnSortear_Click(object sender, RoutedEventArgs e)
        {
            int x = b.Proximo();
            if (x == -1)
            {
                txtNum.Text = "Fim";
                btnIniciar.IsEnabled = true;
                btnSortear.IsEnabled = false;
            }
            else
            {
                txtNum.Text = x.ToString();
                string s = "";
                foreach (int i in b.Sorteados())
                {
                    s += i + "-";
                }
                txtSorteio.Text = s;
            }
        }
    }
}
