using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Roles.Data;
using Roles.Entities;
using Roles.Models;

namespace Roles.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly ApplicationDbContext _context;

        public BookRepository(ApplicationDbContext context)
        {
            this._context = context;
        }

        public void Add(Book book)
        {
            _context.Books.Add(book);
            _context.SaveChanges();
        }

        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> GetAllBooks()
        {
            var books = _context.Books.ToList();
            return books;
        }

        public Book GetBookById(int Id)
        {
            var books = _context.Books.Find(Id);
            return books;
        }

        public IEnumerable<Book> Search(string searchString)
        {
            var searchBooks = GetAllBooks().Where(x=>x.BookName.Contains(searchString)).ToList();
            return searchBooks;
        }

        public int Update(Book book)
        {
            _context.Entry(book).State = EntityState.Modified;
            _context.SaveChanges();
            return 1;
        }
        //public void Add(BookViewModel book)
        //{
        //    var newBook = new Book()
        //    {
        //        BookName = book.BookName,
        //        BookAuthor = book.BookAuthor,
        //        BookPublication = book.BookPublication,
        //        BookPurchaseDate = book.BookPurchaseDate,
        //        BookPrice = book.BookPrice,
        //        Quantity = book.Quantity,
        //        GenreId = book.GenreId,
        //    };
        //    _context.Books.AddAsync(newBook);
        //    _context.SaveChangesAsync();
        //}
        //public void Delete(int Id)
        //{
        //    Book book = _context.Books.Find(Id);
        //    if (book != null)
        //    {
        //        _context.Books.Remove(book);
        //        _context.SaveChanges();
        //    }
        //}
        //public async Task<IEnumerable<Book>> GetAllBooks()
        //{
        //    return await _context.Books.ToListAsync();
        //}

        //public async Task<IEnumerable<Genre>> GetAllGenre()
        //{
        //    return await _context.Genres.ToListAsync();
        //}
        //public async Task<Book> GetBookById(int Id)
        //{
        //    return await _context.Books.FindAsync(Id);
        //}

        //public async Task<IEnumerable<Book>> GetBookByGenreId(int genreId)
        //{
        //    return await _context.Books.Where(b => b.GenreId == genreId).ToListAsync();
        //}

        //public Book Update(Book book)
        //{
        //    _context.Update(book);
        //    _context.SaveChanges();
        //    return book;
        //}


    }

}

