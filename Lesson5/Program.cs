using System;
using System.IO;
using System.Text.Json;

namespace Lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1
            SaveStringToTxt();

            //Task2
            TimeLog();

            //Task3
            WriteBinToFile();
        }

        static void SaveStringToTxt()
        {
            Console.WriteLine("Введите строку для сохранения:");
            string data = Console.ReadLine();
            Console.WriteLine("Введите имя файла:");
            string filename = Console.ReadLine() + ".txt";
            File.WriteAllText(filename, data);
        }

        private static void TimeLog()
        {
            string filename = "startup.txt";
            string[] startTime = { DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") };
            File.AppendAllLines(filename, startTime);
        }        

        private static void WriteBinToFile()
        {
            Console.WriteLine("Введите исла от 0 до 255 через пробел:");
            string[] s = Console.ReadLine().Trim().Split();
            byte[] b = new byte[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                b[i] = byte.Parse(s[i]);
            }
            File.WriteAllBytes("bytes.bin", b);
        }
    }
}
