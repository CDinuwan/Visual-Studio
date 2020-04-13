using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practising5
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while(i<=5)
            {
                Console.WriteLine(i);
                i++;
            }

            do
            {
                Console.WriteLine("Hi");
            } while (i == 1);

   

            Console.ReadLine();
        }
    }
}
