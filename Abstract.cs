using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Practice
{
  abstract class vegetabele
    {
        public abstract void color();
        public void shape()
        {
            Console.WriteLine("All vegetables are not of same shape");
        }
    }
    class tomato : vegetabele
    {
        public override void color()
        {
            Console.WriteLine("Tomato is red in color");
        }
    }

}
