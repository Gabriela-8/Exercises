using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[3, 3];
            int i, j;

            Console.Write("Please, enter a value for the elements in the matrix.\n");
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write($"Element - [{i},{j}]: ");
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("The matrix is: ");
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                    Console.Write($"{array[i,j]}\t");
                Console.Write("\n");
            }
            Console.WriteLine();
        }
    }
}
