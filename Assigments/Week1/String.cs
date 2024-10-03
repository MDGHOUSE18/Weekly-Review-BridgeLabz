using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Reviews.Week1
{
    internal class String
    {
        //Write a program that checks if all characters in a given string are unique

        public static void uniqueChar()
        {
            Console.Write("Enter the string : ");
            string input = Console.ReadLine();

            char[] char_arr = input.ToCharArray();

            Array.Sort(char_arr);
            bool flag = false;
            for (int i = 0; i < char_arr.Length - 1; i++)
            {
                if (char_arr[i] == char_arr[i + 1])
                {
                    flag = true;
                    break;
                }
            }
            if (flag)
            {
                Console.WriteLine(input + " have duplicates.");
            }
            else
            {
                Console.WriteLine(input + " have unique characters");
            }
        }
    }
}
