using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Arthimetic_operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter First number:");
            int n1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter Second number:");
            int n2=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Addition:"+(n1 + n2));
            Console.WriteLine("Subtraction:" + (n1 - n2));
            Console.WriteLine("Multiply:" + (n1 * n2));
            if (n2!=0)
            {
                Console.WriteLine("Division:" + (n1 / n2));
                Console.WriteLine("Modulo:" + (n1 % n2));
            }
            else
            {
                Console.WriteLine("cannot divide by zero")
            }
        }
    }
}
