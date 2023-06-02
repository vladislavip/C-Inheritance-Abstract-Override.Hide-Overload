using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task__3
{
    internal class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }


        public Person(string name,string Surname , int age)
        
        {

            this.Name = name;
            this.Surname = Surname; 
            this.Age = age; 
        }

    }
}
