using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isMale = true;
            bool isTall = true;


            if (isMale && isTall)
            {
                Console.WriteLine("You are Male");
            }
            else if (isMale && !isTall)
            {
                Console.WriteLine("You are foolish");
            }
            else
            {
                Console.WriteLine("You are female");
            }

            Console.ReadLine();

        }
    }
}
