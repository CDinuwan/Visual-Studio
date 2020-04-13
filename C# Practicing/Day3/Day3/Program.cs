using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Integer here : ");
            int num = Convert.ToInt32(Console.ReadLine());
            if(num%2==0)
            {
                Console.WriteLine("This is even number.");
            }
            else
            {
                Console.WriteLine("This is odd number.");
            }

            bool isDivideble;
            Console.WriteLine("Enter your number in here :");
            int num1 = Convert.ToInt32(Console.ReadLine());
            if((num1%5==0)&&(num1%7==0))
            {
                isDivideble = true;
                Console.WriteLine(isDivideble);
            }
            else
            {
                isDivideble = false;
                Console.WriteLine(isDivideble);
            }
            Console.ReadLine();


        }
    }
}
