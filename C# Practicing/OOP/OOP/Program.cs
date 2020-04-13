using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Person
    {
        private int age;
        private string name;

        public Person(int age,string name)
        {
            this.age = age;
            this.name = name;
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person( 23,"Chanuka");
            Person person2 = new Person(24, "Dinuwan");

            Console.WriteLine(person1.Age);

            Console.ReadLine();
        }
    }
}
