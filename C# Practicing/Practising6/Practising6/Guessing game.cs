using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practising6
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "Dilini";
            string guess = "";
            int count = 0;
            int guesslimit = 5;
            bool outguessing = false;

            while (guess!=secretWord && count<guesslimit) 
            {
                Console.Write("Enter your guessing : ");
                guess=Console.ReadLine();
                count++;

                if (secretWord == guess)
                {
                    Console.WriteLine("You are successfull");
                    Console.WriteLine("You try this word " + count + " times");
                }else
                {
                    outguessing = true;
                }
                
            }
            if(outguessing)
            {
                Console.WriteLine("You are loss");
            }
            else
            {
                Console.WriteLine("You are won");
            }


            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(i);
            }

            int[] arr = { 1, 2, 3, 4, 5, 6 };
            for(int i=0;i<arr.Length;i++)
            {
                Console.WriteLine("Num is "+arr[i]);
            }

            Console.WriteLine(GetPower(2, 2));

            Console.ReadLine();
        }
        static int GetPower(int bas,int pow)
        {
            int result = 1;
            for(int i=0;i<pow;i++)
            {
                result=result* bas;
            }

            return result;
        }
    }
}
