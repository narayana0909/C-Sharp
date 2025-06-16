using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Average
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");
            int n1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second number:");
            int n2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Third number:");
            int n3=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Fourth number:");
            int n4=Convert.ToInt32(Console.ReadLine());

            int Average = (n1 + n2 + n3 + n4) / 4;
            Console.WriteLine(Average);
        }
    }
}
