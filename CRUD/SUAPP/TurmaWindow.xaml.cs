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
using System.Windows.Shapes;

namespace SUAPP
{
    /// <summary>
    /// Lógica interna para TurmaWindow.xaml
    /// </summary>
    public partial class TurmaWindow : Window
    {
        public TurmaWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Turma t = new Turma { };
            t.Id = int.Parse(txtId.Text);
            t.Curso = txtCurso.Text;
            t.Descricao = txtTurma.Text;
            t.AnoLetivo = int.Parse(txtAnoLetivo.Text);

        }
    }
}
