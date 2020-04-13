using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practising2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] luckyNumber = {4,8,75,65 };
            Console.WriteLine(luckyNumber[1]);
            luckyNumber[1] = 10;
            Console.WriteLine(luckyNumber[1]);

            string[] friends = new string[5];
            friends[0] = "Chanuka";
            friends[1] = "Dinuwan";
            friends[2] = "Hewa";

            Console.WriteLine(friends);
            SayHi("Chanuka",25);
            Console.WriteLine(Power(5.0));

            int num = Convert.ToInt32(Console.ReadLine());
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            MaxValue(num, num1, num2);

            IsMale(true);

            Console.ReadLine();
        }
        static void SayHi(string str,int age)
        {
            Console.WriteLine("Hello "+str+" your age is "+age);
        }
        static double Power(double i)
        {
            double pow = i * i;
            return pow;
        }

        

        static void MaxValue(int num,int num1,int num2)
        {
            if(num1>num2)
            {
                if(num1>num)
                {
                    Console.WriteLine(num1);
                }
                else
                {
                    Console.WriteLine(num);
                }
            }
            else
            {
                if(num2>num)
                {
                    Console.WriteLine(num2);
                }
                else
                {
                    Console.WriteLine(num);
                }
            }
        }

        static bool IsMale(bool Male)
        {
            if(Male==true)
            {
                Console.WriteLine("You are male!");
            }
            else
            {
                Console.WriteLine("You are not male!");
            }
            return Male;
        }
    }
}
