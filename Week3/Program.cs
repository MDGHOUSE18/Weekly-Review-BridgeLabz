using System;

namespace Week3
{
    internal class Program
    {
        /*
            1. Create a simple ToDo list application where you can add, remove, and view tasks.
            2. Write a program that merges the contents of two files (file1.txt and file2.txt) into a third file (merged.txt).
            3. Create a program that manages student records, including reading and writing student data to and from 
               a text file (students.txt). Include functionality to add, delete, and update student records.
            4. Create a simple text editor that allows users to open, edit, and save text files. Include basic features like find and replace text.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Ghouse!");
            Console.WriteLine();

            //ToDoListApp.ToDoList();
            //FileHanling.MergeFiles();
            StudentMangement.StudentRecords();

            Console.WriteLine();
        }
    }
}
