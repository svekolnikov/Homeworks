using System;
using System.IO;
using System.Text.Json;

namespace Lesson6
{
    class Program
    {
        static string workDir = @"D:\ExampleDir";

        static void Main(string[] args)
        {
            //Task1
            SaveDirectoryToTxt();

            //Task2
            ToDoApp toDoApp = new ToDoApp();
            toDoApp.CompleteTask();
            toDoApp.CreateTask("Позвонить другу");

            //Task3
            object[,] array1 = { { 1, 2, 3, 4 }, { 1, 2, 3, 4 }, { 1, 2, 3, 4 }, { 1, 2, 3, 4 } };
            object[,] array2 = { { 1, 2, 3, 4 }, { 1, 2, 3, 4 }, { 1, 2, 3, 4 } };
            object[,] array3 = { { "I'm string", 2, 3, 4 }, { 1, 2, 3, 4 }, { 1, 2, 3, 4 }, { 1, 2, 3, 4 } };
            int sum = ArraySum(array3);
            Console.WriteLine(sum);

            //Task4
            PersonsArray();
        }

        private static void SaveDirectoryToTxt()
        {
            string[] entries = Directory.GetFileSystemEntries(workDir, "*",SearchOption.AllDirectories);
            string filename = "entries.txt";
            File.AppendAllLines(filename, entries);
        }

        private static int ArraySum(object[,] arr)
        {
            try
            {
                if (IsArraySizeOk(arr.GetLength(0), arr.GetLength(1)))
                {
                    Console.WriteLine("Массив верного размера.");
                }
            }
            catch (MyException ex) when (ex.Code == ErrorCodes.MyArraySizeException)
            {
                Console.WriteLine("Массив неверного размера.");
            }

            int sum = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int k = 0; k < arr.GetLength(1); k++)
                {
                    try
                    {
                        sum += ConvertToInt32(arr[i, k]);
                    }
                    catch (MyException ex) when (ex.Code ==  ErrorCodes.MyArrayDataException)
                    {
                        Console.WriteLine($"В ячейке [{i},{k}] лежат неверные данные");
                        sum = 0;
                    }
                }
            }

            return sum;
        }  
        
        private static bool IsArraySizeOk(int x, int y)
        {
            if (x != 4 || y != 4)
            {
                throw new MyException(ErrorCodes.MyArraySizeException);
            }

            return true;
        }

        private static int ConvertToInt32(object obj)
        {
            int result = 0;
            try
            {
                result = Convert.ToInt32(obj);
            }
            catch (FormatException)
            {

                throw new MyException(ErrorCodes.MyArrayDataException);
            }

            return result;
        }

        private static void PersonsArray()
        {
            Person[] persons = new Person[5];
            persons[0] = new Person("Свекольников Алексей", "инженер-программист", "alexey.svekolnikov@gmail.com", "+79161113337777", 80000, 31);
            persons[1] = new Person("Михайлов Андрей", "стажёр", "andrey.mihailov@gmail.com", "+79162225551111", 40000, 25);
            persons[2] = new Person("Куклин Илья", "менеджер", "ilya.kuklin@gmail.com", "+79163337773333", 85000, 45);
            persons[3] = new Person("Токарев Дмитрий", "тим лидер", "dmitry.tokarev@gmail.com", "+79165559995555", 90000, 52);
            persons[4] = new Person("Нефёдов Даниил", "java программист", "daniil.nefedov@gmail.com", "+79167771112345", 81000, 35);

            for (int i = 0; i < persons.Length; i++)
            {
                if (persons[i].Age > 40)
                {
                    persons[i].GetInfo();
                }
            }
        }
    }
}
