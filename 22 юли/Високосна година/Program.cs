using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please, enter the year you want to check with numeric data type.\nEnter: ");
            int year = int.Parse(Console.ReadLine());

            if ((year % 4) == 0) 
            {
                Console.WriteLine($"The {year} is a leap year.");
            }
            else
            {
                Console.WriteLine($"The {year} isn`t a leap year.");
            }

        }
    }
}
