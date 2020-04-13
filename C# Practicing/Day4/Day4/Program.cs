using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your value : ");
            int num = Convert.ToInt32(Console.ReadLine());

            int val = num / 100;
            if(val==7)
            {
                Console.WriteLine(val);
            }
            else
            {
                Console.WriteLine("The 3rd Digit is not equal to seven");
            }

            Console.WriteLine("Enter your value:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            if((num1&8)!=0)
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine("0");
            }


            Console.Write("Enter value of width : ");
            double width = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter value of length : ");
            double length = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter value of Height : ");
            double height = Convert.ToDouble(Console.ReadLine());

            double sur = (length + width) * height / 2;
            Console.WriteLine("Surface is : " + sur);


            Console.WriteLine("Enter your weight : ");
            double weight = Convert.ToDouble(Console.ReadLine());

            double monWeight = weight * 0.17;

            Console.WriteLine("Weight in the moon " + monWeight);

            Console.WriteLine("Enter your value for x : ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter your value for y : ");
            double y = Convert.ToDouble(Console.ReadLine());

            while((x*x)+(y*y)<=(5*5))
            {
                Console.WriteLine("The point is in circle");
                if((x*x)+(y*y)==0)
                {
                    Console.WriteLine("That point is center of the circle");
                }
            }



            Console.ReadLine();


        }
    }
}
