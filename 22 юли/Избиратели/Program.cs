using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace voters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please, enter your age: ");
            int age = int.Parse(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("You can vote this year, congrats!");
            }
            else if (age==17)
            {
                Console.WriteLine("Sorry, you are too young to vote this year. Try it the next year.");
            }
            else
            {
                Console.WriteLine("Sorry, you can`t vote.");
            }
        }
    }
}
