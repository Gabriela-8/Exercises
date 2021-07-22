using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evenOrOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please, enter your number: ");
            int num = int.Parse(Console.ReadLine());
            int result = num % 2;

            if (result == 0) 
            {
                Console.WriteLine($"{num} is even.");
            }
            else
            {
                Console.WriteLine($"{num} is odd.");
            }
        }
    }
}
