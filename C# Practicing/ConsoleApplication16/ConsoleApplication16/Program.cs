using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication16
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }

            int[] lucky = { 4, 5, 8, 75, 65 };

            for(int i=0;i<lucky.Length;i++)
            {
                Console.WriteLine(lucky[i]);
            }


            Console.ReadLine();
        }
    }
}
