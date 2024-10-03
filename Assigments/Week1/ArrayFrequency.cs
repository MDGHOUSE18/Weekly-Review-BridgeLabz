using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace Reviews.Week1
{
    internal class ArrayFrequency
    {

        //Write a C# Sharp program to count the frequency of each element in an array.
        public static void frequency()
        {
            Console.Write("Enter the length of array : ");
            int len = int.Parse(Console.ReadLine());

            int[] arr = new int[len];

            for (int i = 0; i < len; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int[] unique = new int[len];
            int[] freq = new int[len];


            int count = 0;


            for (int i = 0; i < len; i++)
            {
                bool flag = false;

                for (int j = 0; j < count; j++)
                {
                    if (arr[i] == unique[j])
                    {
                        freq[j]++;
                        flag = true;
                        break;
                    }

                }

                if (!flag)
                {
                    unique[count] = arr[i];
                    freq[count] = 1;
                    count++;
                }
            }


            Console.WriteLine("Elements Frequency are ");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(unique[i] + " : " + freq[i]);
            }
        }
    }
}
