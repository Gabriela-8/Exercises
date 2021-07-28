using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace theLargestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please, enter your first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Please, enter your second number: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Please, enter your third number: ");
            int num3 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine($"The largest number is {num1}");
                }
            }
            else if (num2 > num3)
            {
                Console.WriteLine($"The largest number is {num2}");
            }
            else
            {
                Console.WriteLine($"The largest number is {num3}");
            }
        }
    }
}
