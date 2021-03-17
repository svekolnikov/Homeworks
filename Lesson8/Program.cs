using System;
using MyLibrary;
using System.Threading.Tasks;

namespace Lesson8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1
            TaskManager taskManager = new TaskManager();
            taskManager.PrintProcesses();
            Console.WriteLine("Введите номер процесса который завершить:");
            int pid = Int32.Parse(Console.ReadLine());
            taskManager.KillProcessById(pid);
            Console.WriteLine("Введите имя процесса который завершить:");
            string procName = Console.ReadLine();
            taskManager.KillProcessByName(procName);

            //Task2
            DateTimeLibrary.GreetingFromLibrary();
            DateTimeLibrary.WhatTimeIn(Cities.London);
            DateTimeLibrary.WhatTimeIn(Cities.LosAngeles);
            DateTimeLibrary.WhatTimeIn(Cities.Moscow);
            DateTimeLibrary.WhatTimeIn(Cities.Suzhou);
        }
    }
}
