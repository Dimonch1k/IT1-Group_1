using System.Collections.Generic;

namespace Team_1_Library_Create
{
    class Library
    {
        List<Book> books = new List<Book>();
        public void addBook(string name, string autor, string publishYear)
        {
            books.Add(new Book(name, autor, publishYear));
        }
        public List<Book> searchBook(string name)
        {
            return Search.searchBooks(name, books);
        }
        
    }
}
