using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace functions
{
    //polymorphism Method Overloading
    public class overloading
    {
        public void add()
        {
            int a = 2;
            int b = 3;
            int c = 4;
            int result = a + b + c;
            Console.WriteLine(result);
        }
        public void add(int a, int b)
        {
            int result = a + b;
            Console.WriteLine(result);
        }
        public void add(float a, int b)
        {
            Console.WriteLine(a + b);
        }
        public void add(float a, int b, int c)
        {
            Console.WriteLine(a + b + c);
        }
        public static int add(int x, int y, int z)
        {
            return x + y;
        }
    }
    internal class polymorphism
    {

        static void Main(string[] args)
        {
             overloading ad = new overloading();
            ad.add();
            ad.add(4,9);
            ad.add(4.7f, 9);
            ad.add(5.5f, 3, 2);
            
           
        }

  }
}

  
    

