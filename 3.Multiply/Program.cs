using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Multiply
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First number:");
            int n1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second number:");
            int n2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Third number:");
            int n3=Convert.ToInt32(Console.ReadLine());

            int multiply = n1 * n2 * n3;
            Console.WriteLine(multiply);
        }
    }
}
