
using LibrarySystem.Models;
using Microsoft.EntityFrameworkCore;

namespace LibrarySystem.Data
{
    public class SignUpDbContext : DbContext
    {
        public SignUpDbContext(DbContextOptions<SignUpDbContext> options) : base(options)
        {
        }
        public DbSet<SignUpModel> signUpModels { get; set; }
    }

}