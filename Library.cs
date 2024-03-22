using System.Collections.Generic;

namespace Team_1_Library_Create
{
    class Library
    {
        List<Book> books = new List<Book>();
        public void addBook(string name, string autor, int publishYear)
        {
            books.Add(new Book(name, autor, publishYear));
        }
        public Book searchBookByName(string name)
        {
            return books.Find(b => b.Name.Contains(name));
        }
        
    }
}
