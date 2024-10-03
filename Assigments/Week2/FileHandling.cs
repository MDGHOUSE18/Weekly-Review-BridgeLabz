using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Assigments.Week2
{

    //Write a program that takes user input and writes it to a text file (output.txt).
    internal class FileHandling
    {
        public static void HandlingFile()
        {
            string path = @"C:\Users\Mahammed Ghouse\source\repos\Assigments\Assigments\Week2\output.txt";

            if (File.Exists(path)) {
                Console.WriteLine("File is exists ");
            }
            else
            {
                File.Create(path);
                Console.WriteLine("New file created ");
            }
            Console.WriteLine("Enter the input for file ");
            string input = Console.ReadLine();

            File.WriteAllText(path, input);

            Console.WriteLine("File data :");
            var filedata =  File.ReadAllText(path);
            Console.WriteLine(filedata);
        }
    }
}
