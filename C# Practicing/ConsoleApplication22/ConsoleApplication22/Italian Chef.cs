using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication22
{
    class Italian_Chef:Chef//Inheritance
    {
        public void MakePasta()
        {
            Console.WriteLine("Make Pasta");
        }
        public override void MakeSpecialDish()
        {
            Console.WriteLine("The Chef makes chicken parm");
        }
    }
}
