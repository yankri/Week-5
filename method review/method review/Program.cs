using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_review
{
    class Program
    {
        //First Challenge
        static void AddNumbers (int x, int y)
        {
            int sum = x + y;
            Console.WriteLine(sum);
        }

        //second challenge
        static double Add (double x, double y)
        {
            double sum = x + y;
            return sum;
        }
        
        static double Subtract (double x, double y)
        {
            double sum = x - y;
            return sum;
        }

        static double Multiply (double x, double y)
        {
            double sum = x * y;
            return sum;
        }

        static double Divide(double x, double y)
        {
            double sum = x / y;
            return sum;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            double x = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            double y = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the operation you wish to perform: + - * /");
            string operation = Console.ReadLine();

            double total; 

            switch (operation)
            {
                case "+":
                    total = Add(x, y);
                    Console.WriteLine(Add(x, y));
                    break;
                case "-":
                    total = Subtract(x, y);
                    Console.WriteLine(total);
                    break;
                case "*":
                    total = Multiply(x, y);
                    Console.WriteLine(total);
                    break;
                case "/":
                    total = Divide(x, y);
                    Console.WriteLine(total);
                    break;
                default:
                    Console.WriteLine("You didn't enter a valid operation");
                    break;
            }
        }
    }
}
