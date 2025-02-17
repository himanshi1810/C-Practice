using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Practice
{
    interface ITestInterface1
    {
        void Add(int a, int b);
    }
    interface ITestInterface2 : ITestInterface1
    {
        void Sub(int a, int b);
    }
    public class ImplementationClass : ITestInterface2
    {
        public void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public void Sub(int a, int b)
        {
            Console.WriteLine(a - b);
        }
    }

    interface IInterface1
    {
        void Test();
        void Show();
    }
    interface IInterface2
    {
        void Test();
        void Show();
    }
    public class InterfaceClass : IInterface1, IInterface2
    {
        public void Test()
        {
            Console.WriteLine("Test method");
        }
        void IInterface1.Show()
        {
            Console.WriteLine("Show method of IInterface1");
        }
        void IInterface2.Show()
        {
            Console.WriteLine("Show method of IInterface2");
        }
    }
}
