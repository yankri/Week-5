using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    class Program
    {
        static void SayHi()
        {
            Console.WriteLine("Hi!");
        }

        static int Add (int one, int two)
        {
            int sum = one + two;
            return sum;
        }

        static int Subtract (int one, int two)
        {
            int diff = one - two;
            return diff;
        }

        static int Multiply (int one, int two)
        {
            int multi = one * two;
            return multi;
        }

        static double Divide (double one, double two)
        {
            if (two == 0)
            {
                return 0;
            }
            else
            {
                double diff = one / two;
                return diff;
            }
        }

        static string HelloName (string name)
        {
            string print = "Hello, " + name;
            return print;
        }

        static void SayIt (string name)
        {
            Console.WriteLine("Hello, " + name);
        }

        static void Main(string[] args)
        {
            SayHi();

            Console.WriteLine(Add(1, 2));
            Console.WriteLine(Subtract(5, 4));
            Console.WriteLine(Multiply(6, 7));
            Console.WriteLine(Divide(5, 9));

            string name = "Krista";

            Console.WriteLine(HelloName(name));
            SayIt(name);

            double num = 4.5969540;
            Console.WriteLine(ReverseDigits(num));
            string textnum = "34.4400";
            Console.WriteLine(ReverseDigits(textnum));

            string[] text = { "45", "4", "15", "30" };
            int[] numbers = ReturnInt(text);

            foreach (int num3 in numbers)
            {
                Console.WriteLine(num3);
            }


        }


        //Write a method that reverses the digits of a given decimal number in and returns the numbers (reversed).
        //Call that method then print the result from Main.

        static string ReverseDigits (double num)
        {
            string text = num.ToString();

            StringBuilder sb = new StringBuilder();
            for (int i = text.Length - 1; i >= 0; i--)
            {
                sb.Append(text[i]);
            }

            return sb.ToString();
        }

        static string ReverseDigits(string text)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = text.Length - 1; i >= 0; i--)
            {
                sb.Append(text[i]);
            }

            return sb.ToString();
        }

        //Write a static method called ReturnInt. It takes 1 parameter of string array. 
        //In the body, it creates an int array of the same length.Then, parses the string array as type int, and saves the ints to the new int array.
        // It returns the int array.

        static int[] ReturnInt(string [] text)
        {
            int[] numbers = new int [text.Length];

            for (int i = 0; i < text.Length; i++)
            {
                numbers[i] = Convert.ToInt32(text[i]);
            }

            return numbers;
        }


    }
}

