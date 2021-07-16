using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace improvedDice
{
    class Program
    {
        static void Main(string[] args)
        {
            Random dice = new Random();

            int roll1 = dice.Next(1, 7);
            int roll2 = dice.Next(1, 7);
            int roll3 = dice.Next(1, 7);

            int result = roll1 + roll2 + roll3;

            if (roll1 == roll2 || roll2 == roll3 || roll3 == roll1)
            {
                if (roll1 == roll2 && roll2 == roll3)
                {
                    Console.WriteLine("You rolled triples! Now, you have +5 points.");
                    result = result + 5;
                }
                else
                {
                    Console.WriteLine("You rolled doubles! Now, you have +2 points.");
                    result = result + 2;
                }
            }

            if (result >= 15)
            {
                Console.WriteLine($"Congratulation, you win this game with {result} points.");

            }
            else
            {
                Console.WriteLine($"Sorry, you lose! You only have {result} points.");
            }
           
        }
    }
}
