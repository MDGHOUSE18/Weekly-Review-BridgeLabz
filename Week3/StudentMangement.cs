using Microsoft.VisualBasic;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Week3
{
    class Student
    {

    }
    internal class StudentMangement
    {
        /*
         * 3. Create a program that manages student records, including reading and writing student data to and from 
         * a text file(students.txt). Include functionality to add, delete, and update student records.
        */

        public static string path = @"C:\Users\Mahammed Ghouse\source\repos\Assigments\Week3\StudentRecords.txt";

        public static void StudentRecords()
        {
            bool running = true;
            Console.WriteLine("\n Student Management \n");
            while (running)
            {

                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Delete Student");
                Console.WriteLine("3. Update Student");
                Console.WriteLine("4. View Students");
                Console.WriteLine("5. Exit");

                Console.WriteLine("\nChoose the option : \n");
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1: 
                        AddStudent();
                        break;
                    case 2:
                        DeleteStudent();
                        break;
                    case 3:
                        UpdateStudent();
                        break;
                    case 4:
                        ViewStudents();
                        break;
                    case 5:
                        running= false;
                        Console.WriteLine("Exit the file");
                        break;
                    default: 
                        Console.WriteLine("Invalid option, Give Valid option ");
                        break;
                }
            }
        }

        public static void AddStudent()
        {
            Console.WriteLine("Enter the student Details ");
        }

        public static void DeleteStudent()
        {
            Console.WriteLine("Delete student");
        }

        public static void UpdateStudent()
        {
            Console.WriteLine("Update student");
        }

        public static void ViewStudents()
        {
            Console.WriteLine("View students");
        }
    }
}
