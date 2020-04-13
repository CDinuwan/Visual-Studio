using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practising_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string charname = "Chanuka";
            int charage = 90;

            Console.WriteLine("Hello C#! "+charname);
            Console.WriteLine("Start "+charname+" C#");
            Console.WriteLine("// "+charage);
            Console.WriteLine("||");
            Console.WriteLine("\\");

            //Data Types
            string phase = "Chanuka";
            char grade = 'A';
            int age = 90;

            double d;
            bool isMale;
            float f;
            decimal dec;

            Console.WriteLine("Chanuka".Length);
            Console.WriteLine(phase.Length);
            Console.WriteLine(phase.Contains("C"));
            Console.WriteLine(phase[0]);
            Console.WriteLine(phase.IndexOf("a"));
            Console.WriteLine(phase.Substring(3));

            Console.WriteLine(Math.Abs(age));

            Console.Write("Enter string here :");
            string str = Console.ReadLine();
            Console.WriteLine(str);


            Console.WriteLine("Enter a value :");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a another value : ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sum of " + num1.ToString() + " and " + num2.ToString() + " is " + (num1+num2));
            
            float floatPI = 3.14f; 
            Console.WriteLine(floatPI);
            double nan = Double.NaN;
            Console.WriteLine(nan);
            double infinity = Double.PositiveInfinity;
            Console.WriteLine(infinity);
            char ch = 'a';
            Console.WriteLine("The code of '" + ch + "' is: " + (int)ch); ch = 'b';

            Console.ReadLine();

            
        }
    }
}
