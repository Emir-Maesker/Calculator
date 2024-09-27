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

            var jsonString = File.ReadAllText("CurrencyData.json"); 
            dynamic responseObject = JsonConvert.DeserializeObject(jsonString);  

            foreach (var item in responseObject.data)   // Populate the ComboBoxes
            {
                BaseCurrencyComboBox.Items.Add(item.First.code.ToString());
                TargetCurrencyComboBox.Items.Add(item.First.code.ToString());
            }
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
            if (BaseCurrencyComboBox.SelectedItem is string selectedBaseCurrency)
            {
                string currency = selectedBaseCurrency;
                baseRate = Convert.ToDouble(await GetCurrencyRate(currency));
            }
            
        }
        // Target currency Combobox (selection change)
        private async void TargetCurrencyComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (TargetCurrencyComboBox.SelectedItem is string selectedTargetCurrency)
            {
                string currency = selectedTargetCurrency;
                targetRate = Convert.ToDouble(await GetCurrencyRate(currency));
            }
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
            Dictionary<string, double> currencyData = new Dictionary<string, double>();  // Dictionary to store currency data
            string jsonString = null;  // Variable to store json data from the API call
            dynamic responseObject;  // Dynamic variable to hold the deserialized JSON response, for easy access to its properties

            var fileInfo = new FileInfo("CurrencyData.json");  // Initialize a new file to store JSON data
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
                        responseObject = JsonConvert.DeserializeObject(jsonString);  // Deserialize the JSON string into a dynamic variable 
                    }
                }
                else  // If one day has not passed since last API call
                {
                    jsonString = File.ReadAllText("CurrencyData.json");  // Read the contents of the Json file
                    responseObject = JsonConvert.DeserializeObject(jsonString);  // Deserialize the JSON string fron the file into a dynamic variable
                }
                foreach (var item in responseObject.data)  // Loop to add the data from the Json response or the Json file to the dictionary
                {
                    currencyData.Add(item.First.code.ToString(), item.First.value.Value);
                }
                string value = string.Empty; // Variable to store the fetched value from the Dictionary
                return value = currencyData.First(c => c.Key == currency).Value.ToString(); // Fetch the value from the Dictionary according to the key and return it
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
