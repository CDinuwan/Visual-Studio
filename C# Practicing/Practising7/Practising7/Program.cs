using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practising7
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter your  value : ");
                int num = Convert.ToInt32(Console.ReadLine());

                int a = num % 10;
                int b = (num / 10) % 10;
                int c = (num / 100) % 10;
                int d = (num / 1000) % 10;

                Console.WriteLine("Sum : " + (a + b + c + d));

                Console.WriteLine("Reverse : " + a+b+c+d );

                Console.WriteLine("Execute : "+d + b + c + a);

                Console.WriteLine("Execute : " + d + b + c + a);
                Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("This is not four digit number.");
            }

            
        }
    }
}
