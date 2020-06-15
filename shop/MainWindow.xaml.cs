﻿using System;
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

            if (keyPrice.Text != "" && keytoPeso.Text != "" && gamePrice.Text !="" && Percent.Text !="")
            {

                double a = Convert.ToDouble(keyPrice.Text) / Convert.ToDouble(keytoPeso.Text);
                a = Math.Round(a, 3);
                oPtT.Content = Convert.ToString(a) + " Toman ";

                double number = a * Convert.ToDouble(gamePrice.Text);        
                priceToman.Content = number.ToString("#,#");



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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
    }
}
