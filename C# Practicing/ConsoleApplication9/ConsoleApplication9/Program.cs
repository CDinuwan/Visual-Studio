using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)//Method Creation
        {
            SayHi("Chanuka",23);
            SayHi("Dina", 56);

            Console.WriteLine(cube(2));

            Console.ReadLine();
        }
        static void SayHi(string name,int age)
        {
            Console.WriteLine("Hello " +name+" User "+age);
        }
        static int cube(int num)
        {
            int result = num * num * num;
            return result;
        }
        static double cub(int num)
        {
            double result = num * num * num;
            return result;
        }
    }
}
