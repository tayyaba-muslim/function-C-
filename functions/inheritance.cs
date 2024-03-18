using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functions
{
    //hierarical inheritance
    public class Person
    {
        //public int id;
        //public string name;
        //public string gender;

        //protected
        protected int id;
        protected string name;
        protected string gender;

        public void person_info(int id, string name, string gender)
        {

            this.id = id;
            this.name = name;
            this.gender = gender;

            Console.WriteLine($"person details are \n {id} \n {name} \n {gender}");
        }
    }

    public class Emp1 : Person
    {
        public void emp1_info(int id, string name, string gender)
        {
            Console.WriteLine($"Employee details are \n {id} \n {name} \n {gender}");
        }
    }
    public class Emp2 : Person
    {
        public void emp2_info(int id, string name, string gender)
        {
            Console.WriteLine($"Employee details are \n {id} \n {name} \n {gender}");
        }
    }

}
