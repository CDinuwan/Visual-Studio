using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication19
{
    class Program
    {
        static void Main(string[] args)
        {

            Book book1 = new Book("Harry","Potter",320);

            Book book2 = new Book("Load","Rings",890);
           
            Console.WriteLine(book2.author);


            Console.ReadLine();
        }
    }
}
