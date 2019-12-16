using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your Name:");//In here All the Inputs from user get as a String
            String name=Console.ReadLine();
            Console.WriteLine("Hello " + name);

            int num = Convert.ToInt32("45");
            Console.WriteLine("34"+"65");

            Console.Write("Enter Your Number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Your Second Number:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(num1 + num2);

            Console.ReadLine();

        }
    }
}
