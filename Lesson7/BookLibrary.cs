using System.Collections.Generic;

namespace Lesson7
{
    public class BookLibrary
    {
        public List<BookModel> Books { get; }

        public BookLibrary()
        {
            Books = new List<BookModel>();
        }

        public void AddBook(BookModel book)
        {
            Books.Add(book);
        }

        public BookModel GetBookByAuthor(string author)
        {
            return Books.Find(book => book.Author == author);
        }

        public void ShowList()
        {
            for (int i = 0; i < Books.Count; i++)
            {
                System.Console.WriteLine($"#{i+1} {Books[i].Author} - {Books[i].Title}");
            }
        }
    }

    public class BookModel
    {
        public string Author { get; set; }
        public string Title { get; set; }
    }
}
