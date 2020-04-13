using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.WriteLine(1);
            Console.WriteLine(1121);


            DateTime str = DateTime.Now;
            Console.WriteLine(str);

            Console.WriteLine(Math.Sqrt(12345));

            for(int i=2;i<100;i++)
            {
                if(i%2==1)
                {
                    Console.WriteLine(i * -1);
                }
                else
                {
                    Console.WriteLine(i);
                }
            }


            Console.Write("Enter your age : ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("After 10 years your age is " + (age+10));

            Console.ReadLine();
        }
    }
}
