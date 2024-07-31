using System.ComponentModel.Design;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) 
            {
                try
                {
                    Console.Write("Enter a number: ");
                    int num = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter a symbol (+, -, *, /): ");
                    string symbol = Console.ReadLine();

                    Console.Write("Enter another number: ");
                    int num0 = Convert.ToInt32(Console.ReadLine());

                    int result = 0;
                    bool validOperation = true;

                    switch (symbol)
                    {
                        case "+":
                            result = num + num0;
                            break;

                        case "-":
                            result = num - num0;
                            break;

                        case "*":
                            result = num * num0;
                            break;

                        case "/":
                            if (num0 == 0)
                            {
                                Console.WriteLine("Error: Division by zero is not allowed.");
                                validOperation = false;
                            }
                            else
                            {
                                result = num / num0;
                            }
                            break;

                        default:
                            Console.WriteLine("Incorrect symbol, please try again.");
                            validOperation = false;
                            break;
                    }

                    if (validOperation)
                    {
                        Console.WriteLine("Result: " + result);
                        break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter valid numbers.");
                }
            }

            Console.ReadLine();



        }
        
    }
}
