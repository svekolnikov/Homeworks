using System;

namespace MyLibrary
{
    public enum Cities
    {
        Suzhou,
        Moscow,
        LosAngeles,
        London
    }
    public static class DateTimeLibrary
    {
        public static void WhatTimeIn(Cities city)
        {
            DateTime currentTime = DateTime.Now;
            switch (city)
            {
                case Cities.Suzhou:
                    TimeZoneInfo.ConvertTimeBySystemTimeZoneId(currentTime, TimeZoneInfo.Local.Id, "China Standard Time");
                    break;
                case Cities.Moscow:
                    TimeZoneInfo.ConvertTimeBySystemTimeZoneId(currentTime, TimeZoneInfo.Local.Id, "Russian Standard Time");
                    break;
                case Cities.LosAngeles:
                    TimeZoneInfo.ConvertTimeBySystemTimeZoneId(currentTime, TimeZoneInfo.Local.Id, "Pacific Standard Time");
                    break;
                case Cities.London:
                    TimeZoneInfo.ConvertTimeBySystemTimeZoneId(currentTime, TimeZoneInfo.Local.Id, "GMT Standard Time");
                    break;
                default:
                    break;
            }

            Console.WriteLine($"Current time in {city.ToString()}: {currentTime}");
        }

        public static void GreetingFromLibrary()
        { 
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"Hi, {name}!");
        }
    }
}
