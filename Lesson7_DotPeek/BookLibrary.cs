// Decompiled with JetBrains decompiler
// Type: Lesson7.BookLibrary
// Assembly: Lesson7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E61BA933-C531-4F49-B9E1-CCE36A5B18C5
// Assembly location: D:\5. Geekbrains\Homeworks\Lesson7\bin\Release\netcoreapp3.1\Lesson7.dll

using System;
using System.Collections.Generic;

namespace Lesson7
{
  public class BookLibrary
  {
    public List<BookModel> Books { get; }

    public BookLibrary() => this.Books = new List<BookModel>();

    public void AddBook(BookModel book) => this.Books.Add(book);

    public BookModel GetBookByAuthor(float rate) => this.Books.Find((Predicate<BookModel>) (book => book.Rate >= rate));

    public void ShowList()
    {
            for (int i = 0; i < Books.Count; i++)
            {
                System.Console.WriteLine($"#{i + 1} {Books[i].Author} - {Books[i].Title} - [{Books[i].Rate}]");
            }
        }
  }
}
