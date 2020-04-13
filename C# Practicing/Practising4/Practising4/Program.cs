using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practising4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Day Name is :" + GetDay(1));

            Console.ReadLine();
        }
        static string GetDay(int dayNum)
        {
            string dayName;
            switch(dayNum)
            {
                case 1:
                    dayName = "Sunday";
                    break;
                case 2:
                    dayName = "Monday";
                    break;
                case 3:
                    dayName = "Tuesday";
                    break;
                case 4:
                    dayName = "Wednesday";
                    break;
                default:
                    dayName = "Invalid Daynumber";
                    break;
            }
            return dayName;
        }
    }
}
