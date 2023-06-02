using System;
using Task_1;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)

        {
            string name, surname;
            int age;
            double weight, height;

            

            Console.WriteLine("Enter Name:");
             name = Console.ReadLine();   

            Console.WriteLine("Ebter Surname");
             surname= Console.ReadLine();


            Console.WriteLine("Enter Age:");

             age = Convert.ToInt32(Console.ReadLine());  

            Console.WriteLine("Enter Weight:");

             weight= Convert.ToDouble(Console.ReadLine());    


            Console.WriteLine("Enter Height:");

             height= Convert.ToDouble(Console.ReadLine());

            Person person = new Person(name, surname, age, weight, height);


            Console.WriteLine(person.ToString());

           




        }

        

        
    }
}