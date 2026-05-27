using System;
using System.Collections.Generic;

namespace Myprogram
{
    class Program
    {
        static List<string> tasks = new List<string>();

        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("TO DO LIST!!");

                Console.WriteLine("1. Add task ");
                Console.WriteLine("2. View tasks");
                Console.WriteLine("3. Remove tasks");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Choose an option:");

                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    AddTask();
                }
                else if (choice == 2)
                {
                    ViewTask();
                }
                else if (choice == 3)
                {
                    RemoveTask();
                }
                else if (choice == 4)
                {
                    running = false;
                    Console.WriteLine("app closed");
                }
                else
                {
                    Console.WriteLine("Invalid Option");
                }
            }
        }

        static void AddTask()
        {
            Console.WriteLine("Add your task");

            string task = Console.ReadLine();

            tasks.Add(task);
        }

        static void ViewTask()
        {
            Console.WriteLine(" -------Tasks-------");

            if (tasks.Count == 0)
            {
                Console.WriteLine("NO tasks available");
            }
            else
            {
                for (int i = 0; i < tasks.Count; i++)
                {
                    Console.WriteLine((i + 1) + " . " + tasks[i]);
                }
            }
        }

        static void RemoveTask()
        {
            ViewTask();

            int taskNumber = 0;

            if (tasks.Count > 0)
            {
                Console.WriteLine(" enter task no to be removed");

                taskNumber = Convert.ToInt32(Console.ReadLine());

                if (taskNumber > 0 && taskNumber <= tasks.Count)
                {
                    tasks.RemoveAt(taskNumber - 1);

                    Console.WriteLine("task got removed");
                }
                else
                {
                    Console.WriteLine("Invalid no");
                }
            }
        }
    }
}