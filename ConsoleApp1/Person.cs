using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task_1
{
    internal  class Person
    {

        public string Name { get; private set; }

        public string Surname { get; private set; }
        public int Age { get; private   set; }

        public double Weight { get; private set; }

        public  double Height { get; private set; }

        public Person(string name, string surname, int age, double weight,double height )
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
            this.Weight = weight;
            this.Height = height;
        }

        public override string ToString()
        {
            return $"Name:{Name}, Surname {Surname},Age {Age}, Weght {Weight}, Heght{Height}";
        }



    }
}
