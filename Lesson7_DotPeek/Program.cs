// Decompiled with JetBrains decompiler
// Type: Lesson7.Program
// Assembly: Lesson7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E61BA933-C531-4F49-B9E1-CCE36A5B18C5
// Assembly location: D:\5. Geekbrains\Homeworks\Lesson7\bin\Release\netcoreapp3.1\Lesson7.dll

using System;

namespace Lesson7
{
  public class Program
  {
    private static void Main(string[] args)
    {
      BookLibrary bookLibrary = new BookLibrary();
      bookLibrary.AddBook(new BookModel()
      {
        Author = "Рей Брэдбери",
        Title = "451° по Фаренгейту",
        Rate = 10.0f
      });
      bookLibrary.AddBook(new BookModel()
      {
        Author = "Джордж Оруэлл",
        Title = "1984",
          Rate = 7.75f
      });
      bookLibrary.AddBook(new BookModel()
      {
        Author = "Михаил Булгаков",
        Title = "Мастер и Маргарита",
          Rate = 6.75f
      });
      bookLibrary.ShowList();

            Console.ReadLine(); 
    }
  }
}
