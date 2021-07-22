using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace equalOrNot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please, enter your first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Please, enter your second number: ");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 == num2)
            {
                Console.WriteLine($"The first number {num1} and the second number {num2} are equal.");
            }
            else
            {
                Console.WriteLine($"The first number {num1} and the second number {num2} aren`t equal.");
            }

        }
    }
}
