using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace improvedNumberWithWords
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Please, enter a number between 1 and 100 000: ");
            int suppportNum = int.Parse(Console.ReadLine());

            if (suppportNum >= 1 && suppportNum <= 100000)
            {
                string[] num1 = new string[] { ",", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeeen", "eighteen", "nineteen" };
                string[] num2 = new string[] { ",", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
                string numWithWords = "";

                if ((suppportNum / 1000) > 0)
                {
                    numWithWords = numWithWords+(suppportNum / 1000) + " thousand ";
                    suppportNum %= 1000;
                }
                if ((suppportNum / 100) > 0)
                {
                    numWithWords = numWithWords + (suppportNum / 100) + " hundred ";
                    suppportNum %= 100;
                }
                if (suppportNum > 0)
                {
                    if (numWithWords != "")
                    {
                        numWithWords = numWithWords + "and ";
                    }
                    if (suppportNum < 20)
                    {
                        numWithWords = numWithWords + num1[suppportNum];
                    }
                    else
                    {
                        numWithWords = numWithWords + num2[suppportNum / 10];
                        if ((suppportNum % 10) > 0)
                            numWithWords += "-" + num1[suppportNum % 10];
                    }
                }
                Console.WriteLine(numWithWords);
            }
            else
            {
                Console.WriteLine("Your number isn't between 1 and 1 000 000!");
            }
        }
    }
}


  
    


