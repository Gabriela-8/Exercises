using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dice
{
    class Program
    {
        static void Main(string[] args)
        {
            Random dice = new Random();
            int roll = dice.Next(1, 7);
            Console.WriteLine(roll);
        }
    }
}
