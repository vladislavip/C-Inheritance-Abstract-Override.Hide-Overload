using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task__3
{
    internal class Student:Person
    {

        public Student(string name, string surname, int age):base(name, surname, age) 
        { 
        base.Name = name;   
        base.Surname = surname; 
        base.Age = age;
        
     
        }

        

        public void Learning ()
        {
            Console.WriteLine( "Learning.....");
        }



    }
}
