using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Practice
{

    class Methods
    {
        public static void MyMethod()
        {
            Console.WriteLine("I just got executed! Himanshi");
        }
        public void name(string fname)
        {
            Console.WriteLine(fname + " Refsnes");
        }
        public void nameAge(string fname, int age)
        {
            Console.WriteLine(fname + " is " + age);
        }
        public void Country(string country = "Norway")
        {
            Console.WriteLine(country);
        }
        public int sum(int a, int b)
        {
            return a + b;
        }
        public void namedArguments(string child1, string child2, string child3)
        {
            Console.WriteLine("The youngest child is: " + child3);
        }
        public int plusMethod(int x, int y)
        {
            return x + y;
        }
        public double plusMethod(double x, double y)
        {
            return x + y;
        }
      
    }
}
