using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication20
{
    class Program
    {
        static void Main(string[] args)
        {
            Student Student1 = new Student("Chanuka", "IT", 3.35);
            Student Student2 = new Student("Dinuwan", "Python", 3.32);

            Console.WriteLine(Student1.HasHonors());
            Console.WriteLine(Student2.HasHonors());
            Console.ReadLine();
        }
    }
    //Static class owened their methods and cant create instance of the class.
}
