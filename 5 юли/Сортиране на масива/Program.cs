using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraySort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 3, 7, 12, 3, 78, 0 };
            int num;

            for (int i = 0; i < array.Length; i++)  
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        num = array[i];
                        array[i] = array[j];
                        array[j] = num;
                    }
                }
            }
            foreach (int result in array)
            {
                Console.Write($" {result} ");
            }
        }
    }
}
