using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Practice
{
    class Classes
    {
       public string color = "red";
        public int maxSpeed = 200;
        public int year;
        public string model;
        public Classes()
        {
            model = "Ford";
        }
        public Classes(string modelName,string colorName, int modelYear)
        {
            model = modelName;
            color = colorName;
            year = modelYear;   
        }
        public void fullThrottle()
        {
            Console.WriteLine("The car is going as fast as it can!" + maxSpeed);
        }
    }

    class Person
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
