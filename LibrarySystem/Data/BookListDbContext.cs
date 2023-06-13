
using LibrarySystem.Models;
using Microsoft.EntityFrameworkCore;

namespace LibrarySystem.Data
{
    public class BookListDbContext : DbContext
    {
        public BookListDbContext(DbContextOptions<BookListDbContext> options) : base(options)
        {
        }

        public DbSet<BookListModel> bookList { get; set; }




        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=BookListDb;Trusted_Connection=True;", option => option.EnableRetryOnFailure(
                maxRetryCount: 10,
                maxRetryDelay: TimeSpan.FromSeconds(30),
                errorNumbersToAdd: null));
            base.OnConfiguring(optionsBuilder);
        }
    }
}
