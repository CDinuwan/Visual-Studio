using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practising13
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            double result;
            Console.WriteLine("Enter value for A : ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter value for B : ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter value for C : ");
            double c = double.Parse(Console.ReadLine());

            double d = (b * b) - 4 * a * c;

            if(d==0)
            {
                result=(-b)/(2*a);
                Console.WriteLine("root is 0");
            }
            else if(d==1.0)
            {
                Console.WriteLine("root is Positive");
            }
            else
            {
                Console.WriteLine("root is Negetive");
            }
            */
            int max = 0;
            int[] num = new int[5];
            for(int i=0;i<5;i++)
            {
                Console.WriteLine("Enter value : ");
                int number = Int32.Parse(Console.ReadLine());

                num[i]= number;
            }

            for(int j=0;j<5;j++)
            {
                int number = num[j];
                if(max<number)
                {
                    max = number;
                }

            }
            Console.WriteLine("Max Number is : "+max);

            

            Console.ReadLine();
        }
    }
}
