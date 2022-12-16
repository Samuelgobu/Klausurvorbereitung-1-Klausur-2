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

namespace Klausurvorbereitung_Klausur_2
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
        private void canvas_bewegung_KeyDown(object sender, KeyEventArgs
        e)
        {
            double x = Canvas.GetLeft(box);
            double y = Canvas.GetBottom(box);
            switch (e.Key)
            {
                
                case Key.Enter:
                    //hier steht der Code
                    Canvas.SetLeft(box, 20);
                    Canvas.SetBottom(box, 50);
                    break;


                case Key.W:
                    if(y <= canvas_bewegung.ActualHeight - box.ActualHeight - 5)
                    {
                        Canvas.SetBottom(box, y + 5);
                    }
                    break;


                case Key.S:
                    if (y >=  5)
                    {
                        Canvas.SetBottom(box, y - 5);
                    }
                    break;


                case Key.A:
                    if (x >= 5)
                    {
                        Canvas.SetLeft(box, x - 5);
                    }
                    break;


                case Key.D:
                    if (x <= canvas_bewegung.ActualWidth - box.ActualWidth - 5)
                    {
                        Canvas.SetLeft(box, x + 5);
                    }
                    break;
            }
        }

        private void btn_rechnen_Click(object sender, RoutedEventArgs e)
        {
            double.TryParse(tb_zahl.Text, out double zahl1);
            
            double.TryParse(tb_zahl2.Text, out double zahl2);
            string op = Convert.ToString(tb_operation.Text);
            switch (op)
            {
                case "+":
                    lb_ergebnis.Content = zahl1 + zahl2;
                        break;
                case "-":
                    lb_ergebnis.Content = zahl2 - zahl1;
                    break;
                case "*":
                    lb_ergebnis.Content = zahl1 * zahl2;
                    break;
                case "/":
                    lb_ergebnis.Content = zahl1/ zahl2;
                    break;
                default:
                    lb_ergebnis.Content = "Fehler";
                    break;
            }
        }

    }
}
