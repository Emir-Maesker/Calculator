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

namespace GCSCalculator
{
    /// <summary>
    /// Interaction logic for CurrencyConverter.xaml
    /// </summary>
    public partial class CurrencyConverter : Window
    {
        public CurrencyConverter()
        {
            InitializeComponent();
        }
        // Exit button
        private void Exitbtn(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        // Fullscreen button
        private void Fullscreenbtn(object sender, RoutedEventArgs e)
        {
            if (WindowState == WindowState.Maximized)
                WindowState = WindowState.Normal;
            else WindowState = WindowState.Maximized;
        }
        // Minimize button
        private void Minimizebtn(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }
        // Variables 
        static string bCurrency = string.Empty;
        static string tCurrency = string.Empty;
        double result = 0;
        bool displayedResult = false;
        bool errorMessage = false;
        // Button Clicks
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;

            bCurrency += button.Tag.ToString();
            tCurrency = "";
            BaseCurrency.Text = bCurrency;
            TargetCurrency.Text = TargetCurrency.Text + tCurrency;
        }
        // Back button
        private void backbtn(object sender, RoutedEventArgs e)
        {
            if (bCurrency.Length > 0)
            {
                bCurrency = bCurrency.Substring(0, bCurrency.Length - 1);
                BaseCurrency.Text = bCurrency;
                TargetCurrency.Text = tCurrency;
            }
        }
        // Clear button
        private void Clearbtn_Click(object sender, RoutedEventArgs e)
        {
            BaseCurrency.Text = "";
            TargetCurrency.Text = "";
            bCurrency = string.Empty;
            tCurrency = string.Empty;
            result = 0;
        }
        // Base currency Combobox (selection change)
        private void CurrencyComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string currentBCurrency = BaseCurrencyComboBox.SelectedItem.ToString();



        }
        // Target currency Combobox (selection change)
        private async void TargetCurrencyComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string currentTCurrency = BaseCurrencyComboBox.SelectedItem.ToString();

        }
    }
}
