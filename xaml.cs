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
using AbastecimentoApp;

namespace WpfApp2
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
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double KmRodados, ValorPago, ValorLitro;
            if (!double.TryParse(txtKmRodados.Text, out KmRodados))
            {
                MessageBox.Show("Valor informado não é válido");
                txtKmRodados.Focus();
                return;
            }
            if (!double.TryParse(txtValorPago.Text, out ValorPago))
            {
                MessageBox.Show("Valor informado não é válido");
                txtValorPago.Focus();
                return;
            }
            if (!double.TryParse(txtValorLitro.Text, out ValorLitro))
            {
                MessageBox.Show("Valor informado não é válido");
                txtValorLitro.Focus();
                return;
            }
            Abastecimento a = new Abastecimento(KmRodados, ValorPago, ValorLitro);
        }
    }
}
