using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            String color, pluralNoun, celebrity;

            Console.Write("Enter a color:");
            color = Console.ReadLine();

            Console.Write("Enter a plural Noun:");
            pluralNoun = Console.ReadLine();

            Console.Write("Enter a celebrity:");
            celebrity = Console.ReadLine();

            Console.WriteLine("Roses are Red");
            Console.WriteLine("{plural noun} are blue");
            Console.WriteLine("I Love {celebrity}");

            Console.ReadLine();
        }
    }
}
