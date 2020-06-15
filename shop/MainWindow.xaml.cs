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

namespace shop
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

        private void ButtonFechar_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void GridBarraTitulo_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

            if (keyPrice.Text != "" && keytoPeso.Text != "" && gamePrice.Text !="")
            {

                double a = Convert.ToDouble(keyPrice.Text) / Convert.ToDouble(keytoPeso.Text);
                a = Math.Round(a, 3);
                oPtT.Content = Convert.ToString(a) + " Toman ";

                double b = a * Convert.ToDouble(gamePrice.Text);
                priceToman.Text = Convert.ToString(b);

                int c = Convert.ToInt32(b) / 100 ;
                

                finalPrice.Content = Convert.ToString(c) + Convert.ToString(b);

            }

            else
            {
                MessageBox.Show("Please fill in the values.", "Warning", MessageBoxButton.OK,MessageBoxImage.Warning);
            }
        }

        private void keyPrice_LostFocus(object sender, RoutedEventArgs e)
        {
            if (keyPrice.Text != "")
            {
                keyPrice.Text = double.Parse(keyPrice.Text).ToString("0,0");
            }
        }

        private void priceToman_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (priceToman.Text != "")
            {
                priceToman.Text = double.Parse(priceToman.Text).ToString("0,0");
            }
        }
    }
}
