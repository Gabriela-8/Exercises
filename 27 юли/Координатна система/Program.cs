using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coordinateSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please, enter a value for X coordinate: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Please, enter a value for Y coordinate: ");
            double y = double.Parse(Console.ReadLine());

            if (x > 0 && y > 0)
            {
                Console.WriteLine($"The coordinate point ({x}, {y}) lies in the 1-st quandrant.");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine($"The coordinate point ({x}, {y}) lies in the 2-nd quandrant.");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine($"The coordinate point ({x}, {y}) lies in the 3-rd quandrant.");
            }
            else
            {
                Console.WriteLine($"The coordinate point ({x}, {y}) lies in the 4-th quandrant.");
            }
        }
    }
}
