using System.Net.Mail;

namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var math = new MathHelper();

            Console.WriteLine(math.PrintValue(1, 2));
            Console.WriteLine(math.PrintValue(true));
            math.PrintValue("I am", "ok");
            Console.WriteLine(math.PrintValue(1,2,3));  



        }
           

      
        
    }
}