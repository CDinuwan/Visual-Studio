using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetMax(20,30));

            Console.ReadLine();

        }
        static int GetMax(int num1,int num2)
        {
            int result;
            if(num1>num2)
            {
                result=num1;
            }
            else
            {
                result=num2;
            }
            return result;
        }
    }
}
