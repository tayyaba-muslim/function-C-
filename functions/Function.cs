using function;

namespace functions
{
    internal class Function
    {
        //void does not value return
        void msg()
        {
            Console.WriteLine("simple msg");
        }
        //static method 
        public static void msg2()
        { 
        Console.WriteLine("Static method");
        }
        //parametrized method

        public static string fullname(string name1, string name2) 
        {
            return $"your fullname is {name1} {name2}";
        }

        public static string Person_Details(string fullname , string lastname , int age)
        {
            return $"your name is {fullname} {lastname} your age is {age}  ";
        }

        //class
        class Std_Details
        {
            public int Id;
            public string FirstName;
            public string LastName;
            public string @class;
            public int age;

            public void Details(int id, string Fname, string lname, string classs, int Age)
            {
                this.Id = id;
                this.FirstName = Fname;
                this.LastName = lname;
                this.@class = classs;
                this.age = Age;

                Console.WriteLine($"Student Detail =\n\n id = {id} \n\n Firstname = {Fname} \n\n LastName = {lname} \n\n class = {classs} \n\n age = {Age}\n");
            }
        }


        static void Main(string[] args)
        {
            //Std_Details std = new Std_Details();
            //std.Details(1, "Ayra", "Khan", "matric", 29);
            //Console.WriteLine(std);

            //Console.WriteLine("Hello, World!");
            //Program obj1 = new Program();
            //obj1.msg();
            //Program.msg2();
            ////Program.msg2();
            ////Program.msg2();
            ////Console.WriteLine(Program.fullname("sawera","ansari"));
            //var result = Program.Person_Details("sawera", "ansari" ,20);
            //Console.WriteLine(result);

            //Constructor

            //Class1 cl = new Class1();
            //Class1 cl1 = new Class1("tayyaba","muslim");
            Class1 cl2 = new Class1("Sawera", "Ansari", "22");
            cl2.FirstName = "Sawera";
            cl2.LastName = "Ansari";
            cl2.Age = "22";
            //cl.msg3();
            //cl.num1 = 50;
            //cl.num2 = 40;
            //cl.add();


            //inheritance
            Person p = new Person();
            Emp1 p1 = new Emp1();
            Emp2 p2 = new Emp2();


            p1.person_info(22, "Ali", "Male");
            p1.emp1_info(23, "Akram", "Male");
            p2.emp2_info(20, "Agha", "Male");

            //p.id = 19;
            //p.name = "Ali";
            //p.gender = "Male";
            //p.person_info();
            //p.id = 20;
            //p.name = "Aliya";
            //p.gender = "Female";
            //p.emp_info();

            //inheritance2
            manager m = new manager("Sawera ", "Ansari ", 21, " Manager");
            worker w = new("Sawera ", "Ansari ", 21);

        }

    }
}