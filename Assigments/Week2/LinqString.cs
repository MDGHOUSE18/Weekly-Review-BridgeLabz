using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Assigments.Week2
{

    /*
        Given a sentence as a string, write a C# LINQ query using lambda expressions to:

        Split the sentence into words.
        Count how many words are longer than 5 characters.
        Return the count.
     */

    internal class LinqString
    {
        public static void StringQury()
        {
            string sentence = "Create a Car class with properties like Make, Model, Year, and Speed.Add methods to accelerate, decelerate, and display the current speed.";

            var result = sentence.Split(" ").Where(word => word.Length>5).Count();

            Console.WriteLine(result);
        }

    }
}
