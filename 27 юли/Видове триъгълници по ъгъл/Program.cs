using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace typesOfTrianglesByAngle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please, enter a value for the 1-st angle of triangle: ");
            int angleA = int.Parse(Console.ReadLine());
            Console.Write("Please, enter a value for the 2-nd angle of triangle: ");
            int angleB = int.Parse(Console.ReadLine());
            Console.Write("Please, enter a value for the 3-rd angle of triangle: ");
            int angleC = int.Parse(Console.ReadLine());

            if (angleA + angleB + angleC == 180)
            {
                if (angleA + angleB > angleC)
                {
                    Console.WriteLine("This triangle is an acute.");
                }
                else if (angleA + angleB == angleC)
                {
                    Console.WriteLine("This triangle is a right.");
                }
                else
                {
                    Console.WriteLine("This triangle is an obtuse.");
                }
            }
            else
            {
                Console.WriteLine("The sum of angles must be equal to 180.");
            }
        }
    }
}
