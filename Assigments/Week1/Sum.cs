using System;
using System.Collections.Generic;
using System.Text;

namespace Reviews.Week1
{
    internal class Sum
    {

        //Write a program that calculates the sum of even and odd digits in a given integer separately.

        public static void EvenAndOddSum()
        {
            Console.Write("Enter the length of array : ");
            int len = int.Parse(Console.ReadLine());

            int[] arr = new int[len];

            Console.WriteLine("Enter elements for array one by one");
            for (int i = 0; i < len; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int evenSum = 0;
            int oddSum = 0;

            foreach (int a in arr)
            {
                if (a % 2 == 0)
                {
                    evenSum += a;
                }
                else
                {
                    oddSum += a;
                }
            }

            Console.WriteLine("Even sum is " + evenSum);
            Console.WriteLine("Odd sum is " + oddSum);
        }
    }
}
