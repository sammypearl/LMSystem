using System.Collections.Generic;
using LMSystem.Data.Models;

namespace LMSystem.Data
{
    public interface IBookService
    {
        IEnumerable<Book> GetAll();
        IEnumerable<Book> GetByAuthor(string author);
        IEnumerable<Book> GetByIsbn(string isbn);
        Book Get(int id);
        void Add(Book newBook);
    }
}