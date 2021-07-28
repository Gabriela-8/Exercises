using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spiralMatrix
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Please, enter a value for the dimension of the matrix.\nIt must be in a range of 3 to 9.\nYour input: ");
            int n = int.Parse(Console.ReadLine());
            int[,] array = new int[n, n];
            int x = 0;
            int y = n - 1;
            int direction = 1;

            if (n >= 3 && n <= 9) 
            {
                while (direction <= n * n)
                {
                    for (int i = x; i <= y; i++)
                        array[x, i] = direction++;
                    for (int j = x + 1; j <= y; j++)
                        array[j, y] = direction++;
                    for (int i = y - 1; i >= x; i--)
                        array[y, i] = direction++;
                    for (int j = y - 1; j >= x + 1; j--)
                        array[j, x] = direction++;
                    x++;
                    y--;
                }
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write($"{array[i, j]}\t");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Your input are incorrect!\nThe value for the dimension of the matrix must be in a range of 3 to 9.");
            }
        }
    }
}
