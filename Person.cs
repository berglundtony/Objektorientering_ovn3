using System;
using System.Collections.Generic;
using System.Text;

namespace Objektorientering_ovn3
{
    public class Person
    {
        private double age;
        private string fname;
        private string lname;
        private double height;
        private double weight;

        public Person()
        {
        }

        public Person(double age, string fname, string lname, double height, double weight)
        {
            this.age = age;
            this.fname = fname;
            this.lname = lname;
            this.height = height;
            this.weight = weight;
        } 

        public double Age
        {
            get
            {
                return age;
            }
            set
            {
                if (age >= 0)
                {
                    age = value;
                }
                else
                {
                        Console.WriteLine("Age must have a value");
                }

            }
        }
        public string fName
        {
            get
            {
                if (string.IsNullOrEmpty(fname))
                {
                   return "Forname must have a value";
                }
                else if (fname.Length < 2 || fname.Length > 10)
                {
                    return "Forname must have at least 2 charcters or not more than 10 characters";
                }
                else
                {
                    return fname;
                }
            }
            set
            {
                fName = value;
            }
        }
        public string lName
        {
            get
            {
                if (string.IsNullOrEmpty(lname))
                {
                    return "Lastname must have a value";
                }
                else if (lname.Length < 3 || lname.Length > 15)
                {
                    return "Lastname must have at least 3 charcters or not more than 15 characters";
                }
                else
                {
                    return lname;
                }
            }
            set
            {
                lname = value;
            }
        }



        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }

        }
        public double Weight
        {
            get
            {
                return weight;
            }
            set
            {
                weight = value;
            }
        }
    }
}
