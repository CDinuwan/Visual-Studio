using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practising11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter value : ");
            int val = int.Parse(Console.ReadLine());
            for(int i=1;i<val+1;i++)
            {
                Console.WriteLine(i);
            }

            

            double summ = 0;

            for(int i=1;i<10;i++)
            {
                double valu = 1 / i;
                summ = summ + valu;
                Console.WriteLine(val);
            }



            Console.ReadLine();
        }
    }
}
