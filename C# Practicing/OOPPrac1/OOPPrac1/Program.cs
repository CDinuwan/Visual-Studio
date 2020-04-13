using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrac1
{
    public abstract class Laptop
    {
        public virtual void TurnOn()
        {
            Console.WriteLine("Turn On");
        }
        public void TurnOff()
        {
            Console.WriteLine("TurnOff");
        }public abstract bool TouchScreen
        {
            get;
        }
    }
    public class MacBook:Laptop
    {
        public override bool TouchScreen => false;
    }
    public class AsusZenBook : Laptop
    {
        public override bool TouchScreen => true;
        public override void TurnOn()
        {
            Console.WriteLine("Turning On specific to Azus");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Laptop macBook = new MacBook();
            Laptop azusZenBook = new AsusZenBook();

            macBook.TurnOn();
            macBook.TurnOff();

            azusZenBook.TurnOn();
            azusZenBook.TurnOff();

            Console.WriteLine(macBook.TouchScreen);
            Console.WriteLine(azusZenBook.TouchScreen);

            Console.ReadLine();
        }
    }
}
