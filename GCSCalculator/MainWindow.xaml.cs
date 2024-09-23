using System.Dynamic;
using System.Linq.Expressions;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Advanced_Calculator;

namespace GCSCalculator
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
        static string postfixexpression = string.Empty;
        static string expression = string.Empty;
        string Infixexpression = string.Empty;
        double result = 0.0;
        bool displayedResult = false;
        bool errorMessage = false;
        
        // Button Clicks
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;

            if (errorMessage is true)
            {
                result = 0;
                postfixexpression = string.Empty;
                expression = string.Empty;
                operationTxtbox.Text = postfixexpression;
                resultTxtBox.Text = expression;
                errorMessage = false;
            }

            if (displayedResult is true)
            {

                if (button.Tag.ToString() == "+" || button.Tag.ToString() == "-" || button.Tag.ToString() == "*" || button.Tag.ToString() == "/" || button.Tag.ToString() == "(")
                {   
                    postfixexpression = result.ToString();
                    expression = button.Tag.ToString();
                    displayedResult = false;
                }

                else
                {
                    result = 0;
                    postfixexpression = string.Empty;
                    expression = string.Empty;
                    operationTxtbox.Text = postfixexpression;
                    resultTxtBox.Text = expression;
                    displayedResult = false;
                }
            }
            postfixexpression += button.Tag.ToString();
            expression = button.Tag.ToString();
            operationTxtbox.Text= postfixexpression;
            resultTxtBox.Text = resultTxtBox.Text + expression;
        }

        // Back button
        private void backbtn(object sender, RoutedEventArgs e)
        {
            if (postfixexpression.Length > 0)
            {
                postfixexpression = postfixexpression.Substring(0, postfixexpression.Length - 1);
                operationTxtbox.Text = postfixexpression;
                resultTxtBox.Text = postfixexpression;
            }
        }

        // Result button
        private void Resultbtn(object sender, RoutedEventArgs e)
        {
            try
            {
                Infixexpression = Advanced_Calculator.Program.InfixToPostfix(postfixexpression);
                result = Advanced_Calculator.Program.EvaluatePostfix(Infixexpression);
                resultTxtBox.Text = result.ToString();
                operationTxtbox.Text = postfixexpression;
                displayedResult = true;
            }

            catch (Exception ex)
            {
                resultTxtBox.Text = ex.Message;
                operationTxtbox.Text = postfixexpression;
                errorMessage = true;
            }

        }

        // Clear button
        private void Clearbtn_Click(object sender, RoutedEventArgs e)
        {
            resultTxtBox.Text = "";
            operationTxtbox.Text = "";
            postfixexpression = string.Empty;
            expression = string.Empty;
            result = 0.0;
        }

        // C button
        private void Cbtn(object sender, RoutedEventArgs e)
        {
            resultTxtBox.Text = "";
            operationTxtbox.Text = "";
            postfixexpression = string.Empty;
            expression = string.Empty;
            result = 0.0;
        }

        // Open the CurrencyConverter window
        private void OpenCurrencyConverterWindow(object sender, RoutedEventArgs e)
        {
            CurrencyConverter converter = new CurrencyConverter();
            this.Visibility = Visibility.Hidden;
            converter.Show();
        }
    }
}