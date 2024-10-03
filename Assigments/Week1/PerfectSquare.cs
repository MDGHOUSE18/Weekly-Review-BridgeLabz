using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Reviews.Week1
{
    internal class PerfectSquare
    {
        //Write a program that checks if a given integer is a perfect square.
        public static void perfectSquare()
        {
            Console.Write("Enter the number : ");
            int num = int.Parse(Console.ReadLine());

            double sqrt = Math.Sqrt(num);

            if (sqrt == (int)sqrt)
            {
                Console.WriteLine(num + " is a perfect square.");
            }
            else
            {
                Console.WriteLine(num + " is not a perfect square.");
            }
        }
    }
}
