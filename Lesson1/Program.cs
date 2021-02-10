using System;

namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Как тебя зовут?"); //выводим в консоль вопрос
            string name = Console.ReadLine();        // получаем строку с именем и сохраняем в переменную name 
            Console.WriteLine($"Привет, {name}, сегодня {DateTime.Now}"); //выводим строку с именем и текщей датой
        }
    }
}
