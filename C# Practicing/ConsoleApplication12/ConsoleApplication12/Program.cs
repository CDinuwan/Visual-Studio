using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter a number:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter a operator:");
            String Op=Console.ReadLine();


            if (Op == "+")
            {
                Console.WriteLine(num1 + num2);
            }
            else if (Op == "-") 
            {
                Console.WriteLine(num1 - num2);
            }
            else if (Op == "/") 
            {
                Console.WriteLine(num1 / num2);
            }
            else if (Op == "*") 
            {
                Console.WriteLine(num1 * num2);
            }
            else
            {
                Console.WriteLine("You can not do it here");
            }
            Console.ReadLine();
        }
    }
}
