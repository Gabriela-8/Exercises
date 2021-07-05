using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace theThreeHighestValues
{
    class Program
    {
        static void Main(string[] args)
        {
            // - да генерира 100 случайни числа;
            // - да са в интервала от 0 до 1000;
            // - да се изведат трите най-високи стойности;

            int num;
            Random randomNum = new Random();
            int[] array = new int[100];
            int maxNum1 = array[0];
            int maxNum2 = array[0];
            int maxNum3 = array[0];

            for (int i = 0; i < array.Length; i++)
            {

                num = randomNum.Next(1, 1000);
                array[i] = num;
                Console.WriteLine(num);

                if (array[i] > maxNum1)
                {
                    maxNum3 = maxNum2;
                    maxNum2 = maxNum1;
                    maxNum1 = array[i];
                }
                else if (array[i] > maxNum2)
                {
                    maxNum3 = maxNum2;
                    maxNum2 = array[i];
                }
                else if (array[i] > maxNum3)
                {
                    maxNum3 = array[i];
                }


            }
            Console.WriteLine();
            Console.WriteLine($"The first max num is:  {maxNum1}");
            Console.WriteLine($"The second max num is:  {maxNum2}");
            Console.WriteLine($"The third max num is:  {maxNum3}");
        }
    }
}
