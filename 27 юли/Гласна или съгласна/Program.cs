using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vowelOrConsonant
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please, enter your character: ");
            char ch = char.Parse(Console.ReadLine().ToLower());

            switch(ch)
            {
                case 'a':
                    Console.WriteLine("The character is vowel.");
                    break;
                case 'e':
                    Console.WriteLine("The character is vowel.");
                    break;
                case 'i':
                    Console.WriteLine("The character is vowel.");
                    break;
                case 'o':
                    Console.WriteLine("The character is vowel.");
                    break;
                case 'u':
                    Console.WriteLine("The character is vowel.");
                    break;
                default:
                    Console.WriteLine("The character is consonant.");
                    break;
            }
        }
    }
}
