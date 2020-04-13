using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practising3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your frist value : ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter your second value : ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter your operator : ");
            string op = Console.ReadLine();

            if(op=="+")
            {
                double sum = num1 + num2;
                Console.Write("Your answer is :" + sum);
            }
            else if(op=="-")
            {
                double minu = num1 - num2;
                Console.WriteLine("Your answer is :" + minu);
            }
            else if(op=="*")
            {
                double mul = num1 * num2;
                Console.WriteLine("Your answer is :" + mul);
            }
            else if(op=="/")
            {
                double div = num1 / num2;
                Console.WriteLine("Your answer is :" + div);
            }
            else
            {
                Console.WriteLine("Invalid Operator");
            }

            Console.ReadLine();
        }
    }
}
