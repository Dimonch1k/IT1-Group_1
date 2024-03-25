using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team_1_Library_Create
{
    class Search
    {
        private Search() { }
        private static Search instance;
        public static Search GetInstance()
        {
            if (instance == null)
            {
                instance = new Search();
            }
            return instance;
        }
        public static List<Book> searchBooks(string parameters, List<Book> libraryBooks )
        {
            List<Book> foundedBooks = new List<Book>();
            searchByName(parameters, libraryBooks, foundedBooks);
            searchByAutor(parameters, libraryBooks, foundedBooks);
            searchByYear(parameters, libraryBooks, foundedBooks);
            return foundedBooks;
        }
        private static void searchByName(string parameters, List<Book> libraryBooks, List<Book> foundedBooks)
        {
            foundedBooks.AddRange(libraryBooks.FindAll(b => b.Name.ToLower().Contains(parameters.ToLower())));
        }

        private static void searchByAutor(string parameters, List<Book> libraryBooks, List<Book> foundedBooks)
        {
            foundedBooks.AddRange(libraryBooks.FindAll(b => b.Autor.ToLower().Contains(parameters.ToLower())));
        }

        private static void searchByYear(string parameters, List<Book> libraryBooks, List<Book> foundedBooks)
        {
            foundedBooks.AddRange(libraryBooks.FindAll(b => b.PublishYear.ToLower().Contains(parameters.ToLower())));
        }
    }
}
