using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            String a="Hi";
            Console.WriteLine("Chanuka" + "is cool");//Concatenate
            Console.WriteLine(a.Length);//In here We check Length
            Console.WriteLine(a.ToUpper());//Upper Case String
            Console.WriteLine(a.ToLower());//Lower Case String
            Console.WriteLine(a.Contains("Hi"));//Check the contains of String
            Console.WriteLine(a[0]);//Print one by one character in String
            Console.WriteLine(a.IndexOf("i"));//Check the Start Index
            Console.WriteLine(a.Substring(0, 1));//Get Start and End Characters in c#

            Console.ReadLine();
        }
    }
}
