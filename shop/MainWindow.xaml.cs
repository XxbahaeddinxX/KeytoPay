using MaterialDesignColors.Recommended;
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
            //moneyConvertOnline.Navigate("https://www.xe.com/currencyconverter/convert/?Amount=1&From=ARS&To=IRR");
            //روی نمایش انلاین قیمت پزو به ریال یه سرچی بزن - یکی دو نمونه پیدا کردم . تست کردم جواب نداد 
            // فردا یه
            //API
            // پیدا میکنم که در لحظه قیمت پزو و ریال رو بهت بده

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
            if (string.IsNullOrWhiteSpace(keyPrice.Text) ||
                string.IsNullOrWhiteSpace(keytoPeso.Text) ||
                string.IsNullOrWhiteSpace(gamePrice.Text) ||
                string.IsNullOrWhiteSpace(Percent.Text)
                )
            {
                //MessageBox.Show("Please fill in the values.", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                statusLabel.Content = "Please enter the required values.";
                statusLabel.Foreground = Brushes.Red;
                return;

            }

            double divisionKeyPriceByKeytoPeso = Convert.ToDouble(keyPrice.Text) / Convert.ToDouble(keytoPeso.Text);
            double divisionRoundValue = Math.Round(divisionKeyPriceByKeytoPeso, 3);
            oPtT.Content = Convert.ToString(divisionRoundValue) + " Toman ";

            double number = divisionRoundValue * Convert.ToDouble(gamePrice.Text);
            priceToman.Content = number.ToString("#,#");

        }

        private void keyPrice_LostFocus(object sender, RoutedEventArgs e)
        {
            if (keyPrice.Text != "")
            {
                keyPrice.Text = double.Parse(keyPrice.Text).ToString("0,0");
            }
        }

        private void minimizeButton_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
    }
}
