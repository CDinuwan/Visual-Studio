using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication18
{
    class Program
    {
        static void Main(string[] args)//Exception Handling
        {
            Console.Write("Enter a Number");
            int num1=Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Enter a Number");
            int num2=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(num1 / num2);
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            //In here can execute without any exception in here--Finally



            Console.ReadLine();
        }
    }
}
