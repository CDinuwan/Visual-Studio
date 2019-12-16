using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication14
{
    class Program
    {
        static void Main(string[] args)
        {
            int index = 1;
            while (index <= 5)
            {
                Console.WriteLine(index);
                index++;
            }
            do
            {
                Console.WriteLine(index);
                index++;
            }
            while (index <= 5);


            Console.ReadLine();
        }
    }
}
