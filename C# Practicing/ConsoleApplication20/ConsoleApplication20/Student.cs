using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication20
{
    class Student
    {
        public string name;
        public string major;
        private double gpa;

        public Student(string aName, string amajor, double aGpa)
        {
            name = aName;
            major = amajor;
            gpa = aGpa;
        }
        public bool HasHonors()
        {
            if (gpa >= 3.3)
            {
                return true;
            }
            else
                return false;
        }
        public String Rating//Getters and setters
        {
            get { return name; }//In here we can accesses every attribute using attributs not a object
            set
            {
                if (name == "Chanuka")
                {
                    name = "Again";
                }
                else
                {
                    name = "Hi";
                }
            }
        }

    }
}

