using functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functions
{
    
        public class Employee
        {
            public string firstname;
            public string lastname;
            public int Age;
            public string desination;
            //public Employee() 
            //{
            //    //this.firstname = fname;
            //    //this.lastname = lname;
            //    //this.Age= age;
            //    //Console.WriteLine("Employee class");
            //}
            public void msg1()
            {
                Console.WriteLine($"method1 {firstname}{lastname}{Age}");
            }
        }
    }

    public class worker : Employee
    {
        public worker(string fname, string lname, int age)
        {
            this.firstname = fname;
            this.lastname = lname;
            this.Age = age;
            Console.WriteLine($"Employee class {firstname}{lastname}{Age}");
        }

        public void msg2()
        {
            Console.WriteLine($"method1 {firstname}{lastname}{Age}");
        }
    }

    public class manager : Employee
    {
        public manager(string fname, string lname, int age, string desinations)
        {
            this.firstname = fname;
            this.lastname = lname;
            this.Age = age;
            this.desination = desinations;
            Console.WriteLine($"Manager {firstname}{lastname}{Age}{desination}");
        }
        public void msg3()
        {
            Console.WriteLine($"method2 {firstname}{lastname}{Age}{desination}");
        }
    }

