using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text;

namespace Week3
{
    internal class FileHanling
    {

        //2. Write a program that merges the contents of two
        //files(file1.txt and file2.txt) into a third file(merged.txt).

        public static void MergeFiles()
        {
            string path1 = @"C:\Users\Mahammed Ghouse\source\repos\Assigments\Week3\File1.txt";
            string path2 = @"C:\Users\Mahammed Ghouse\source\repos\Assigments\Week3\File2.txt";
            string mergeFilepath = @"C:\Users\Mahammed Ghouse\source\repos\Assigments\Week3\merged.txt";
            
            string file1Content = File.ReadAllText(path1);

            string file2Content = File.ReadAllText(path2);

            string mergeContent ="\n\n"+ file1Content+"\n\n" + file2Content;

            File.WriteAllText(mergeFilepath,mergeContent);

            Console.WriteLine("Merged File Content ");
            Console.WriteLine(File.ReadAllText(mergeFilepath));
        }
    }
}
