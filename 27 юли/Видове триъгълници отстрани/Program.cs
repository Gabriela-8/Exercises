using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace typesOfTrianglesBySide
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please, enter a value for the 1-st side of triangle: ");
            double sideA = double.Parse(Console.ReadLine());
            Console.Write("Please, enter a value for the 2-nd side of triangle: ");
            double sideB = double.Parse(Console.ReadLine());
            Console.Write("Please, enter a value for the 3-rd side of triangle: ");
            double sideC = double.Parse(Console.ReadLine());

            if (sideA == sideB && sideB == sideC)
            {
                Console.WriteLine("This triangle is an equilateral.");
            }
            else if (sideA == sideB || sideB == sideC || sideC == sideA)
            {
                Console.WriteLine("This triangle is an isoceles.");
            }
            else
            {
                Console.WriteLine("This triangle is a scalene.");
            }
        }
    }
}
