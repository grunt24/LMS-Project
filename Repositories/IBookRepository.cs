using Roles.Entities;
using Roles.Models;

namespace Roles.Repositories
{
    public interface IBookRepository
    {
        void Add(Book book);
        int Update(Book book);
        void Delete(int Id);
        Book GetBookById(int Id);
        IEnumerable<Book> GetAllBooks();
        IEnumerable<Book> Search(string searchString);
    }
}
