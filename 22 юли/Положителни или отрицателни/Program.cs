using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace positiveOrNegative
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please, enter your number: ");
            int num = int.Parse(Console.ReadLine());

            if (num > 0) 
            {
                Console.WriteLine($"{num} is positive number.");
            }
            else
            {
                Console.WriteLine($"{num} is negative number.");
            }
        }
    }
}
