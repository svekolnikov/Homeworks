using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson6
{
    public class Person
    {
        public string FIO { get; set; }
        public string Position { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int Salary { get; set; }
        public int Age { get; set; }

        public Person(string fIO, string position, string email, string phone, int salary, int age)
        {
            FIO = fIO;
            Position = position;
            Email = email;
            Phone = phone;
            Salary = salary;
            Age = age;
        }

        public void GetInfo()
        {
            Console.WriteLine($"ФИО: {FIO}, Должность: {Position}, Email: {Email}, Телефон: {Phone}, Зарплата: {Salary}, Возраст: {Age}");
        }
    }
}
