using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Swapping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");
            int num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            int num2=Convert.ToInt32(Console.ReadLine());

            int temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine("After Swapping:");
            Console.WriteLine("First number:" + num1);
            Console.WriteLine("Second number:" + num2);
        }
    }
}
