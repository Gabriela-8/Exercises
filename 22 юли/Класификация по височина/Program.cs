using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heightClassification
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please, enter your height: ");
            int height = int.Parse(Console.ReadLine());

            if (height <= 150)
            {
                Console.WriteLine("You are a minion. ^^");
            }
            else if (height > 150 && height < 170)
            {
                Console.WriteLine("You have a normal height.");
            }
            else if (height >= 170 && height <= 190)
            {
                Console.WriteLine("You are very tall.");
            }
            else
            {
                Console.WriteLine("You are a mutant!");
            }
        }
    }
}
