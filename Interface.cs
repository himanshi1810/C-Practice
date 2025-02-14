using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Practice
{
    interface IBook
    {
        void Read();
        void Write();
    }

    class Book : IBook
    {
        public void Read()
        {
            Console.WriteLine("Reading a book");
        }
        public void Write()
        {
            Console.WriteLine("Writing a book");
        }
    }

    interface IFirstInterface
    {
        void myMethod(); // interface method
    }

    interface ISecondInterface
    {
        void myOtherMethod(); // interface method
    }

    // Implement multiple interfaces
    class DemoClass : IFirstInterface, ISecondInterface
    {
        public void myMethod()
        {
            Console.WriteLine("Some text..");
        }
        public void myOtherMethod()
        {
            Console.WriteLine("Some other text...");
        }
    }
}
