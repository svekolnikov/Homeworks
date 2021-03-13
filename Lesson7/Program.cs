using System;

namespace Lesson7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1 Написать любое приложение, произвести его сборку с помощью MSBuild 
            BookLibrary library = new BookLibrary();
            library.AddBook(new BookModel { Author = "Рей Брэдбери", Title = "451° по Фаренгейту" });       // rate 10.0
            library.AddBook(new BookModel { Author = "Джордж Оруэлл", Title = "1984" });                    // rate 7.75
            library.AddBook(new BookModel { Author = "Михаил Булгаков", Title = "Мастер и Маргарита" });    // rate 6.75
            library.ShowList();
        }
    }
}
