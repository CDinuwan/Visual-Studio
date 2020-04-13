using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practising9
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum=0;
            int[] number = new int[3];
            for(int i=0;i<3;i++)
            {
                Console.WriteLine("Enter your value : ");
                int num = Int32.Parse(Console.ReadLine());
                number[i] = num;
            }
            for(int j=0;j<3;j++)
            {
                sum = sum + number[j];
                if(j==2)
                {
                    Console.WriteLine("Your answer is : "+sum);
                }
            }
            

            Console.ReadLine();
        }
    }
}
