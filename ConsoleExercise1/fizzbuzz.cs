using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 1. Print all numbers from 1 to 100
// 2. If the number is divisible by 7, print "Pippo"
// 3. If the number is a perfect square, print "Pluto"
// 4. If both conditions are met, print "Paperone"

namespace ConsoleExercise1
{
    internal class fizzbuzz
    {
        public static void PrintNumber()
        {
            for (int i = 0; i <= 100; i++)
            {
                bool isPerfectSquare = Math.Sqrt(i) % 1 == 0;
                var isMultipleOf7 = i % 7 == 0;

                string output = i.ToString();

                if (isMultipleOf7 && isPerfectSquare)
                {
                    output = "Paperone";

                }
                else if (isMultipleOf7)
                {
                    output = "Pippo";
                }
                else if (isPerfectSquare)
                {
                    output = "Pluto";
                }

                Console.WriteLine(output);
            }
        }
    }
}
