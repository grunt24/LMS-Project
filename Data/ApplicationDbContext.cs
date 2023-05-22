using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Roles.Entities;
using Roles.Models;
using System.Reflection.Emit;
using Book = Roles.Entities.Book;

namespace Roles.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Genre> Genres { get; set; }

        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    builder.Entity<Book>().HasData(
        //        new Book
        //        {
        //            BookId = 2,
        //            BookName = "testing book",
        //            BookAuthor = "me",
        //            BookPublication = "siya",
        //            BookPurchaseDate = DateTime.Now,
        //            BookPrice = 96,
        //            Quantity = 2,
        //            GenreId = 1
                    
        //        });
        //}
    }
}