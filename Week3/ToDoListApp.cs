using System;
using System.Collections.Generic;
using System.Text;

namespace Week3
{
    //1. Create a simple ToDo list application where you can add, remove, and view tasks.
    internal class ToDoListApp
    {
        public static List<String> todoList = new List<string>();
        public static void ToDoList()
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("To Do List Application");
                Console.WriteLine("1. View Task");
                Console.WriteLine("2. Add Task");
                Console.WriteLine("3. Remove Task");
                Console.WriteLine("4. Exit ");
                Console.Write("Choose the option : ");
                int option  = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (option) 
                {
                    case 1:
                        ViewTasks();
                        //Console.WriteLine("View Task");
                        break;
                    case 2:
                        AddTask();
                        //Console.WriteLine("Add Task");
                        break ;
                    case 3:
                        RemoveTask();
                        //Console.WriteLine("Remove task");
                        break ;
                    case 4:
                        running = false;
                        Console.WriteLine("Exit from application");
                        break ;
                    default:
                        Console.WriteLine("Invalid Option, Choose the correct option");
                        break ;
                }
                Console.WriteLine();

            }
        }

        public static void ViewTasks()
        {
            if (todoList.Count == 0)
            {
                Console.WriteLine("Your Todo list is empty");
                return;
            }
            Console.WriteLine("To DO List are : \n");
            for(int i=0; i<todoList.Count;i++)
            {
                Console.WriteLine($"Task {i+1} : {todoList[i]}");
            }
        }
        public static void AddTask()
        {
            Console.WriteLine("\nWrite the task ");
            string task = Console.ReadLine();
            todoList.Add(task);
            Console.WriteLine($"Task : {task}  added to your to list");
        }

        public static void RemoveTask()
        {
            if (todoList.Count == 0)
            {
                Console.WriteLine("Your Todo list is empty");
                return;
            }
            Console.WriteLine("Enter the task number you want to remove ");
            int tasknum =int.Parse(Console.ReadLine());

            if(tasknum < 0 || todoList.Count < tasknum)
            {
                Console.WriteLine("Invalid tasknumber");
                return;
            }
            todoList.RemoveAt(tasknum - 1);
            Console.WriteLine($"Task {tasknum} removed from your list ");
        }
    }
}
