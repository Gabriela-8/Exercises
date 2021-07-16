using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace improvedDayOfTheWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] days = new string[7] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            Console.Write("Please, enter number between 1-7: ");
            int dayNum = int.Parse(Console.ReadLine());

            if (dayNum > 0 && dayNum < 8)
            {
                Console.WriteLine($"{days[dayNum - 1]}");
            }
        }
    }
}
