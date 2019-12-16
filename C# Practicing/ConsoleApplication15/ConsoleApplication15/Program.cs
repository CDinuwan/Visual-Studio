using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication15
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretword = "Chanuka";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuesses = false;


            while (guess != secretword && !outOfGuesses)
            {
                if (guessCount < guessLimit)
                {
                    Console.Write("Enter guess:");
                    guess = Console.ReadLine();
                    guessCount++;
                }
                else
                {
                    outOfGuesses = true;

                }
            }
                if (outOfGuesses)
                {
                    Console.Write("You Lose!");
                }
                else
                {
                    Console.Write("You Win!");
                }

            Console.ReadLine();
        }
    }
}
