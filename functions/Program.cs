namespace functions
{
    internal class Program
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
            Std_Details std = new Std_Details();
            std.Details(1, "Ayra", "Khan", "matric", 29);
            Console.WriteLine(std);

            Console.WriteLine("Hello, World!");
            Program obj1 = new Program();
            obj1.msg();
            Program.msg2();
            //Program.msg2();
            //Program.msg2();
            //Console.WriteLine(Program.fullname("sawera","ansari"));
            var result = Program.Person_Details("sawera", "ansari" ,20);
            Console.WriteLine(result);

        }

    }
}