using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http;
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
        private static readonly string API_KEY = "cur_live_pYWl4uKBnTXuCCDyPDl9yy2mCW7QWb3D0zOaOA2G";  // API key
        
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
        double result = 0.0;
        double baseRate = 0.0;
        double targetRate = 0.0;
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

        // Switch To Calculator Window
        private void OpenCalculatorWindow(object sender, RoutedEventArgs e)
        {
            MainWindow calcualtor = new MainWindow();
            this.Visibility = Visibility.Hidden;
            calcualtor.Show();
        }

        // Base currency Combobox (selection change)
        private async void CurrencyComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = (ComboBoxItem)BaseCurrencyComboBox.SelectedValue;
            string currency = (string)item.Content;
            baseRate = Convert.ToDouble(await GetCurrencyRate(currency));
        }

        // Target currency Combobox (selection change)
        private async void TargetCurrencyComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedCurrencyItem = (ComboBoxItem)TargetCurrencyComboBox.SelectedValue;
            string currency = (string)selectedCurrencyItem.Content;
            targetRate = Convert.ToDouble(await GetCurrencyRate(currency));
        }

        // Convert button
        private void Convertbtn(object sender, RoutedEventArgs e)
        {
            try
            {
                double updatedRate = Convert.ToDouble(bCurrency);
                double conversionToTarget = targetRate / baseRate;
                double finalConversionAmount = conversionToTarget * updatedRate;
                TargetCurrency.Text = finalConversionAmount.ToString();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Request error: " + ex.Message);
            }

        }

        //Function to call an API and store the currency rates into a Json text file, then extract the rates from it
        public static async Task<string> GetCurrencyRate(string currency)
        {
            CurrencyData info; // Variable to store data from inside the CurrencyData class (Object)
            string? jsonString = null;
            var fileInfo = new FileInfo("CurrencyData.json");

            var lastTimeWrite = File.GetLastWriteTime("CurrencyData.json");  // Check the last time the file has been updated
            double timeSinceLastWrite = (DateTime.Now.Subtract(lastTimeWrite).TotalMinutes);  // Substract it from current time

            try
            {
                if (timeSinceLastWrite > 1440.0)  // If one day has passed since the last time the API was called
                {
                    using (HttpClient client = new HttpClient()) // Call the API again to get updated rates
                    {
                        client.BaseAddress = new Uri("https://api.currencyapi.com/v3/latest?apikey=" + API_KEY); // Intializing the http Client with a base address
                        var response = await client.GetAsync("https://api.currencyapi.com/v3/latest?apikey=" + API_KEY); // Send a GET request to get the currency rates
                        response.EnsureSuccessStatusCode(); // Throw an exception if something is wrong with the response

                        jsonString = await response.Content.ReadAsStringAsync(); // Read the response as a string and store it inside a variable
                        File.WriteAllText("CurrencyData.json", jsonString); // Store the Json string into a file
                        info = JsonConvert.DeserializeObject<CurrencyData>(jsonString); // Deserialize the JSON string into the CurrencyData object (info)
                    }
                }

                else  // If one day has not passed since last API call
                {
                    jsonString = File.ReadAllText("CurrencyData.json");  // Read the contents of the Json file
                    info = JsonConvert.DeserializeObject<CurrencyData>(jsonString);  // Deserialize the JSON string into the CurrencyData class
                }

                return currency switch
                {
                    "USD" => info.data.USD.value.ToString(), // US Dollar
                    "EUR" => info.data.EUR.value.ToString(), // Euro
                    "DZD" => info.data.DZD.value.ToString(), // Algerian Dinar
                    "TND" => info.data.TND.value.ToString(), // Tunisian Dinar
                    "GBP" => info.data.GBP.value.ToString(), // British Pound
                    "CAD" => info.data.CAD.value.ToString(), // Canadian Dollar
                    "AUD" => info.data.AUD.value.ToString(), // Australian Dollar
                    "JPY" => info.data.JPY.value.ToString(), // Japenese Yen
                    "NZD" => info.data.NZD.value.ToString(), // New Zealand Dollar
                    "RUB" => info.data.RUB.value.ToString(), // Russian Ruble
                    "CNY" => info.data.CNY.value.ToString(), // Chinese Yuan
                    "INR" => info.data.INR.value.ToString(), // Indian Rupee
                    "BTC" => info.data.BTC.value.ToString(), // Bitcoin
                };
            }

            // Catch any HTTP-Client request related error
            catch (HttpRequestException ex)
            {
                return ("Request error: " + ex.Message);
            }

            // Catch any general error
            catch (Exception ex)
            {
                return ("An error occurred: " + ex.Message);
            }
        }
    }

}
