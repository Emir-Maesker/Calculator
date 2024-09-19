using System;
using System.Text;
using System.ComponentModel.Design;
using System.Globalization;
using System.Collections.Generic;
using System.Collections;
using System.Linq.Expressions;

namespace Advanced_Calculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter an expression: ");   // The user input will be an Infix expression, We will need to convert it to Postfix
                string expression = Console.ReadLine().Replace(" ", "");  // Grab user input and remove spaces

                string temp = InfixToPostfix(expression);
                Console.WriteLine("Postfix Expression: " + temp.Trim());   // Postfix Expression Result

                try
                {
                    double result = EvaluatePostfix(temp.ToString());   // Process the Postfix expression using the EvaluatePostFix method
                    Console.WriteLine("Result: " + result);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message + " Please try again.");
                }
            }
        }

        // This method assigns a precedence level (a number) to the symbols (whether high priority or low priority), so Higher Symbols will have 2 and Low Symbols will have 1, because 2>1
        public static int GetPrecedence(char c)
        {
            switch (c)
            {
                case '(':
                    return 1;   // Left bracket will be the lowest priority with a 1

                case '+':
                case '-':
                    return 2;   // Low priority symbol will be 2

                case '*':
                case '/':
                    return 3;   // high priority symbol will be 3

                default:
                    return 0;   // Invalid operator    
            }
        }


        // This method converts the input operations from Infix to Postfix
        public static string InfixToPostfix(string expression)
        {
            Stack<char> Symbols = new Stack<char>();   // Start a stack for the symbols
            StringBuilder temp = new StringBuilder();    // Create a temporary string where we will append the numbers and Symbols

            for (int i = 0; i < expression.Length; i++)   // Start scanning the expression
            {
                if ((expression[i] >= '0' && expression[i] <= '9') || expression[i] == '.')   // If a number is found, append it to the temporary string
                {
                    while (i < expression.Length && ((expression[i] >= '0' && expression[i] <= '9') || expression[i] == '.'))
                    {
                        temp.Append(expression[i]);
                        i++;
                    }
                    temp.Append(' ');  // Add a space between characters to seperate them
                    i--;
                }
                else if (expression[i] == '(')  // If the expression is a '(', push it to the stack
                {
                    Symbols.Push(expression[i]);
                    temp.Append(' ');
                }
                else if (expression[i] == ')')  // If the expression is a ')', run a loop
                {
                    while (Symbols.Count > 0 && Symbols.Peek()!='(')  // Pop items currently on the stack and append them to the postfix until you encounter a '('
                    {
                        temp.Append(Symbols.Pop());
                        temp.Append(' ');
                    }

                    if (Symbols.Count > 0 && Symbols.Peek() == '(')
                    {
                        Symbols.Pop();
                    }
                }
                else if (expression[i] == '+' || expression[i] == '-' || expression[i] == '*' || expression[i] == '/')   // If a symbol is found, add it to the stack
                {
                    while (Symbols.Count > 0 && GetPrecedence(Symbols.Peek()) >= GetPrecedence(expression[i]))     // Check if the stack is not empty, and if the top of the stack already has a higher precedence symbol than the one currently being scanned 
                    {
                        temp.Append(Symbols.Pop());   // if so, pop out the top symbol from the stack and append it to the temporary string, as well as any other low priority symbol left in the stack if any exists
                        temp.Append(' ');
                    }
                    Symbols.Push(expression[i]);   // If the stack is empty however, push the current symbol into the stack
                    
                }
                else
                {
                    return "Invalid character.";    // Throw error message if invalid character encountered
                }
            }

            while (Symbols.Count > 0 )  // With the first loop finished, we will have one last symbol in the stack, therefore we need to pop it into the temporary string
            {   
                temp.Append(Symbols.Pop());  // Now the temporary string contains the full Postfix expression
                temp.Append(' ');
            }
            return temp.ToString();
        }


        // This method will check the precedence level, do a simple 2>1 comparison (in case of high vs low), or an associativity comparison (in case of + vs -) then returns a true or false boolean
        public static bool HasHigherPrecedence(char c1, char c2)
        {
            return GetPrecedence(c1) >= GetPrecedence(c2);
        }


        // This method will handle the math, can be called when needed
        public static double DoMath(double num1, double num2, char op)
        {
            switch (op)
            {
                case '+':
                    return num1 + num2;

                case '-':
                    return num1 - num2;

                case '*':
                    return num1 * num2;

                case '/':
                    if (num2 == 0)
                    {
                        throw new DivideByZeroException("Cannot divide by zero.");
                    }
                    return num1 / num2;

                default:
                    throw new InvalidOperationException("Invalid symbol."); //"Invalid symbol.");
            }
        }

        public static double EvaluatePostfix(string postfix)
        {
            Stack<double> stack = new Stack<double>();  // Create a new stack for evaluation
            string[] tokens = postfix.Split(' ');  // Split the postfix expression into tokens (numbers and symbols)

            foreach (string token in tokens) // Processing each token
            {
                if (double.TryParse(token, out double number))  // If the token is a number, push it into the stack
                {
                    stack.Push(number);
                }
                else if (token.Length == 1)   // If the token is a symbol
                {
                    if (stack.Count < 2)  // Handle potential errors if there are not enough numbers
                    {
                        //throw new InvalidOperationException("Insufficient operands.");
                        continue;
                    }
                    double num2 = stack.Pop();   // pop the two numbers from the top of the stack and store them
                    double num1 = stack.Pop();

                    char op = token[0];   // Get the operator from the token string
                    double result = DoMath(num1, num2, op); ;// Call the math function and do the math, then assign it to a result var
                    stack.Push(result);    // push the result of the operation back into the stack, and do more operations
                }
            }
            return stack.Pop();   // The final result should be the only value left in the stack, so pop it and return it
        }

        

        


      
        

    }
}
    










