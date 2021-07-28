using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rootOFQuadraticEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please, enter a value for a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Please, enter a value for b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Please, enter a value for c: ");
            double c = double.Parse(Console.ReadLine());

            double D, x1, x2, dSup1, dSup2;
            D = b * b - 4 * a * c;
            dSup1 = (-b / 2 * a);
            dSup2 = (Math.Sqrt(D) / 2 * a);

            if (D > 0)
            {
                x1 = dSup1 + dSup2;
                x2 = dSup1 - dSup2;

                Console.WriteLine($"The first root is: {x1}\nThe second root is: {x2}");
            }
            else if (D == 0)
            {
                x1 = dSup1;
                x2 = x1;

                Console.WriteLine($"The first root and the second root are equal: {x1}");
            }
            else
            {
                Console.WriteLine($"Has no real roots.");
            }
        }
    }
}
