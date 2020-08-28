using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UWP_K3.Models
{
    public class BookManager
    {
        public static List<Book> GetBooks()
        {
            var books = new List<Book>();

            books.Add(new Book {BookId = 1, Title = "Tuan", Author = "Furture", CoverImage = "/Assets/Financial.png" });
            books.Add(new Book { BookId = 2, Title = "Tuan1", Author = "Furture1", CoverImage = "/Assets/Food.png" });
            books.Add(new Book { BookId = 3, Title = "Tuan2", Author = "Furture2", CoverImage = "/Assets/background.jpg" });

            return books;
        }
    }
}
