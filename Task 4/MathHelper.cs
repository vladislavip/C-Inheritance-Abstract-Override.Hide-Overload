using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class MathHelper
    {

       public int  PrintValue(int a, int b)
        {
            return a+ b;    
        }
        public int PrintValue(bool test)
        {
            if (test==true)
            {
                return 1;
            }

            else
            {
                return 0;
            }

        }
        public void PrintValue(string a, string b)
        {
            Console.WriteLine(a+b);
        }
        public int PrintValue(int a, int b , int c)
        {
            return a * b * c;
        }

    }
}
