using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functions
{
    //practical : 01
    //public class Bank
    //{
    //    string name = "Tayyaba";
    //    int accountNo = 123432123;
    //    int acc = 200000;
    //    public void setacc(int name , int accountNo , int account)
    //    {
    //        name = name;
    //        accountNo = accountNo;
    //        acc = account;
    //    }
    //    public void getacc()
    //    {
    //        Console.WriteLine($"Your Account Title is : {name}\n");
    //        Console.WriteLine($"Your Account NO is : {accountNo}\n");
    //        Console.WriteLine($"Your Account balance is : {acc}\n");
    //    }

    //}
    //practical : 02
    public class bank
    {
        public int acc = 2000;

        public int number
        {
            set
            {
                acc = value;
            }
            get
            {
                return acc;
            }
        }

    }
    internal class Encapsulation
    {
        static void Main(string[] args)
        {
            //practical : 01  
            
            //Bank acc = new();
            ////acc.setacc(10000);
            //acc.getacc();

            //practical : 02

            bank acc2 = new bank();
            acc2.acc = 12000;
            Console.WriteLine(acc2.number);

        }
    }
}
