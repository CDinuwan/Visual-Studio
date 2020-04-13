using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practising12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first value : ");
            int a = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter your second value : ");
            int b = Int32.Parse(Console.ReadLine());

            if (a < b)
            {
                Console.WriteLine("Values dont need to exchange");
            }
            else
            {
                a = b;
                Console.WriteLine("Values exchanged. Now a is : " + a);
            }
            

            int num1 = 1;
            int num2 = 2;
            int num3 = 3;

            if (num1 < num2)
            {
                if (num1 < num3)
                {
                    if (num2 < num3)
                    {
                        Console.WriteLine(num3 + " " + num2 + " " + num1);
                    }
                    else
                    {
                        Console.WriteLine(num3 + " " + num1 + " " + num2);
                    }
                }
                else
                {
                    if (num3 < num2)
                    {
                        Console.WriteLine(num2 + " " + num3 + " " + num1);
                    }
                    else
                    {
                        Console.WriteLine(num3 + " " + num2 + " " + num1);
                    }
                }
            }
            else
            {
                if (num2 < num3)
                {
                    if (num2 < num3)
                    {
                        Console.WriteLine(num3 + " " + num1 + " " + num2);
                    }
                    else
                    {
                        Console.WriteLine(num3 + " " + num2 + " " + num1);
                    }
                }
                else
                {
                    if (num3 < num2)
                    {
                        Console.WriteLine(num2 + " " + num3 + " " + num1);
                    }
                    else
                    {
                        Console.WriteLine(num3 + " " + num2 + " " + num1);
                    }
                }
            }
            Console.WriteLine("Enter your value :");
            int number = Int32.Parse(Console.ReadLine());

            switch(number)
            {
                case 1:
                    Console.WriteLine("Hi");
                    break;
                case 2:
                    Console.WriteLine("Hello");
                    break;
                case 3:
                    Console.WriteLine("Enter");
                    break;
                case 4:
                    Console.WriteLine("Programmer");
                    break;
                case 5:
                    Console.WriteLine("Clever");
                    break;
                default:
                    Console.WriteLine("Invalid Number");
                    break;
            }

            Console.ReadLine();
        }
    }
}
