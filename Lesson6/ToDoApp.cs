using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace Lesson6
{
    public class ToDoApp
    {
        private List<ToDo> tasks;
        private string filename = "tasks.json";

        public ToDoApp()
        {
            try
            {
                tasks = UploadFromJson();
                ShowTasks(tasks);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Список задач отсутствует");
                tasks = CreateDefaultList();
                SaveToJson(tasks);
            }
        }

        private List<ToDo> CreateDefaultList()
        {
            return new List<ToDo>
                {
                    new ToDo { Title="Сходить в магазин", IsDone = false},
                    new ToDo { Title="Выполнить уборку", IsDone = false},
                    new ToDo { Title="Покормить кота", IsDone = false},
                    new ToDo { Title="Сделать домашнюю работу", IsDone = false},
                    new ToDo { Title="Посмотреть кино", IsDone = false}
                };
        }

        private void SaveToJson(List<ToDo> tasks)
        {
            string json = JsonSerializer.Serialize(tasks, typeof(List<ToDo>));
            File.WriteAllText(filename, json);
        }

        private List<ToDo> UploadFromJson()
        {
            string json = File.ReadAllText(filename);
            return JsonSerializer.Deserialize<List<ToDo>>(json);
        }

        public void CreateTask(string title)
        {
            Console.WriteLine($"Новая задача: {title}");
            tasks.Add(new ToDo { IsDone = false, Title = title });
            SaveToJson(tasks);
            tasks = UploadFromJson();
            ShowTasks(tasks);
        }

        public void CompleteTask()
        {
            int num = 0;
            do
            {
                Console.WriteLine($"Введите номер от 1 до {tasks.Count} выполненной задачи:");
                num = Convert.ToInt32(Console.ReadLine());
            } while (num < 1 || num > tasks.Count);

            tasks[num - 1].IsDone = true;
            SaveToJson(tasks);
            ShowTasks(tasks);
        }

        public void ShowTasks(List<ToDo> tasks)
        {
            string prefix = "";
            for (int i = 0; i < tasks.Count; i++)
            {
                if (tasks[i].IsDone)
                {
                    prefix = "[x]";
                }
                Console.WriteLine($"{prefix} {i + 1}. {tasks[i].Title}");
                prefix = "";
            }

            Console.WriteLine("");
        }
    }
}
