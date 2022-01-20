using PreAcademyAEquazione2Grado.Core;
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

namespace PreAcademyAEquazione2Grado.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double a;
        private double b;
        private double c;
        Equation eq = new Equation();
        public MainWindow()
        {
            InitializeComponent();
        }
        private void NumericText_Validate(object sender, TextCompositionEventArgs e)
        {
            if (Char.IsNumber(e.Text, 0) || Char.IsPunctuation(e.Text, 0))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnCalcola_Click(object sender, RoutedEventArgs e)
        {
            a = string.IsNullOrEmpty(textValueA.Text) ? 0 : double.Parse(textValueA.Text);
            b = string.IsNullOrEmpty(textValueB.Text) ? 0 : double.Parse(textValueB.Text);
            c = string.IsNullOrEmpty(textValueC.Text) ? 0 : double.Parse(textValueC.Text);


            var esito = eq.RisolviEquazioneDiSecondoGrado(a, b, c);


            if (esito == null)
            {
                lblSoluzioni.Content = "Impossibile";
            }

            else if (esito.Length == 1)
            {
                lblSoluzioni.Content = $"Soluzioni coincidenti: \nx1=x2= {esito[0]}";
            }
            else if (esito.Length == 2)
            {
                lblSoluzioni.Content = $"Soluzioni distinte:\nx1= {esito[0]} \nx2={esito[1]}";
            }
        }

        private void textValueA_Changed(object sender, TextChangedEventArgs e)
        {
          
           // e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-';
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            textValueA.Clear();
            textValueB.Clear();
            textValueC.Clear();
            lblSoluzioni.Content = "";
        }

        private void Numeric(object sender, TextCompositionEventArgs e)
        {

        }

        private void NumericText_Validate(object sender, TextChangedEventArgs e)
        {

        }
    }
}
