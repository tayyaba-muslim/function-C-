using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace function
{
    internal class Class1
    {
        public int num1;
        public int num2;

        // Constructor Function
        //public Class1()
        //{
        //    Console.WriteLine("\nConstructor Function");
        //}

        //public Class1(string cons)
        //{
        //    Console.WriteLine("\nSecond Constructor Function" + cons);
        //}

        //public Class1(string cons1 , string cons2)
        //{
        //    Console.WriteLine("\nThird Constructor Function" + cons1 + cons2);
        //}
        // multiple Constructor
        public string FirstName;
        public string LastName;
        public string Age;
        public Class1()
        {
            Console.WriteLine("\nInitialized the object");
        }

        public Class1(string fname, string lname) : this()
        {
            this.FirstName = fname;
            this.LastName = lname;
            Console.WriteLine($"\n First Name = {fname} ,lastName = {lname}");
        }

        public Class1(string fname, string lname, string age) : 
            this(fname, lname)
        {
            this.Age = age;
            Console.WriteLine($"\nAge= {age} ");
        }
        public void msg3()
        {
            Console.WriteLine("\nStudent Class 1");
        }
        public void add()
        {
            Console.WriteLine(num1 + num2);
        }
    }
}