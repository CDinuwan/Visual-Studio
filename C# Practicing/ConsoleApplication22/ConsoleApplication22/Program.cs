using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication22
{
    class Program
    {
        static void Main(string[] args)
        {
            Chef chef = new Chef();
            chef.MakeChicken();

            Italian_Chef Italianchef = new Italian_Chef();
            Italianchef.MakeChicken();
            Italianchef.MakePasta();
            chef.MakeSpecialDish();
            Italianchef.MakeSpecialDish();

            Console.ReadLine();
        }
    }
}
