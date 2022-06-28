using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false;
            while (!endApp)
            {
                string a = "";
                string b = "";
                string oper = " ";
                double result = 0;

                Console.WriteLine("Calculator\nType a number:");
                a = Console.ReadLine();

                double cleana = 0;
                while (!double.TryParse(a, out cleana))
                {
                    Console.Write("This is not valid input. Please enter an integer value: ");
                    a = Console.ReadLine();
                }

                Console.WriteLine("Type a operator:");
                oper = Console.ReadLine();

                Console.WriteLine("Type another number:");
                b = Console.ReadLine();

                double cleanb = 0;
                while (!double.TryParse(b, out cleanb))
                {
                    Console.Write("This is not valid input. Please enter an integer value: ");
                    b = Console.ReadLine();
                }

                try
                {
                    result = Calculate(cleana, oper, cleanb);
                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("This operation will result in a mathematical error.\n");
                    }
                    else Console.WriteLine("Your result: {0:0.##}\n", result);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Oh no! An exception occurred trying to do the math.\n - Details: " + e.Message);
                    throw;
                }

                Console.Write("Press 'n' and Enter to close the app, or press any other key and Enter to continue: ");
                if (Console.ReadLine() == "n") endApp = true;

                Console.WriteLine("\n");
            }
        }

        public static double Calculate(double a, string oper, double b)
        {
            double result = double.NaN;
            switch (oper)
            {
                case "+":
                    result = a + b;
                    break;
                case "-":
                    result = a - b;
                    break;
                case "*":
                    result = a * b;
                    break;
                case "/":
                    while (b == 0)
                    {
                        Console.WriteLine("Enter a non - zero divisor: ");
                        b = Convert.ToDouble(Console.ReadLine());
                    }
                    if (b != 0) result = a / b;
                    break;
                default:
                    break;
            }
            return result;
        }
    }
}
