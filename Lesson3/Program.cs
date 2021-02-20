using System;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1
            int[,] arr1 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr1.GetLength(1); j++)
                {
                    if (j==i)
                    {
                        Console.WriteLine(arr1[i,j]);
                    }                    
                }
            }          

            //Task2
            string[,] phoneBook = {
                {"Alexey", "+79161470298" },
                {"Boris", "+79154441234" },
                {"Michail", "+79143338812" },
                {"Alexander", "+79139993412" },
                {"Vladimir", "+79127733661" }
            };

            for (int i = 0; i < phoneBook.GetLength(0); i++)
            {
                Console.WriteLine($"Name: {phoneBook[i,0]}, Phone: {phoneBook[i, 1]}");
            }

            //Task3
            string str = "Hello";
            string rev_str = "";
            for (int i = str.Length - 1; i >= 0 ; i--)
            {
                rev_str += str[i];
            }
            Console.WriteLine($"String: {str}, reversed string: {rev_str}");

            //Task *
            string x = " X ";
            string o = " O ";
            string[,] field = {
                { o,x,o,o,o,o,o,o,o,o },
                { o,x,o,o,o,x,x,x,o,o },
                { o,o,x,o,o,o,o,o,o,o },
                { o,o,x,o,o,o,o,o,o,o },
                { o,o,x,o,o,o,o,o,x,x },
                { o,o,x,o,o,o,o,o,o,o },
                { o,o,o,o,o,o,o,o,o,o },
                { o,o,o,o,o,o,o,o,o,o },
                { o,o,o,x,x,x,o,o,o,o },
                { o,o,o,o,o,o,o,o,x,x },
            };

            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    Console.Write(field[i,j]);
                }
                Console.WriteLine();
            }


            //Task4
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int n = 5;
            int temp;
            for (int shift = 0; shift < n; shift++)
            {
                temp = arr[arr.Length - 1];
                for (int i = arr.Length - 1; i > 0; i--)
                {
                    arr[i] = arr[i - 1];
                }
                arr[0] = temp;
            }
            foreach (int item in arr)
            {
                Console.Write($"{item} ");
            }
            
            Console.ReadKey();
        }
    }
}
