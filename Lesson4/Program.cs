using System;

namespace Lesson4
{
    class Program
    {
        enum Seasons
        {
            Winter, Spring, Summer, Autumn
        }

        static void Main(string[] args)
        {
            //Task1
            Console.WriteLine(GetFullName("Свекольников", "Алексей", "Сергеевич"));
            Console.WriteLine(GetFullName("Пушкин", "Александр", "Сергеевич"));
            Console.WriteLine(GetFullName("Чехов", "Антон", "Павлович"));

            //Task2
            Console.WriteLine(GetSumString(" 1 3  5 "));

            //Task3
            int month = 0;
            Console.WriteLine("Введите число от 1 до 12");
            while (true)
            {
                month = Int32.Parse(Console.ReadLine());
                if (month < 1 || month > 12)
                {
                    Console.WriteLine("Ошибка: введите число от 1 до 12");
                }
                else
                    break;
            }
            Seasons season = WhatSeasonIs(month);
            Console.WriteLine(WhatSeasonWrap(season));

            //Task4
            Console.WriteLine(GetFib(5));
        }

        static string GetFullName(string firstName, string lastName, string patronymic)
        {
            return $"ФИО: {lastName} {firstName} {patronymic}";
        }

        static string GetSumString(string values)
        {
            int result = 0;
            string[] splited = values.Trim().Split(" ");

            foreach (string s in splited)
            {
               result += int.TryParse(s, out int res) ? res : 0;
            }

            return result.ToString();
        }


        static string WhatSeasonWrap(Seasons season)
        {
            string month = "";
            switch (season)
            {
                case Seasons.Winter:
                    month = "Зима";
                    break;
                case Seasons.Spring:
                    month = "Весна";
                    break;
                case Seasons.Summer:
                    month = "Лето";
                    break;
                case Seasons.Autumn:
                    month = "Осень";
                    break;
                default:
                    break;
            }

            return $"Это {month}";
        }
        static Seasons WhatSeasonIs(int month)
        {
            Console.WriteLine($"Месяц №{month}");
            Seasons season = Seasons.Winter;
            if (month > 2 && month < 6)
            {
                season =  Seasons.Spring;
            }
            else if (month > 5 && month < 9)
            {
                season = Seasons.Summer;
            }
            else if (month > 8 && month < 12)
            {
                season = Seasons.Autumn;
            }
            else if (month == 12 || (month > 0 && month < 3))
            {
                season = Seasons.Winter;
            }

            return season;
        }

        static int GetFib(int n)
        {
            if (n <= 1)
                return 1;
            else
                return GetFib(n - 1) + GetFib(n - 2);
        }
    }
}
