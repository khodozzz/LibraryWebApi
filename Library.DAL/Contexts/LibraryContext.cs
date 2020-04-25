using Library.Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace Library.DAL.Contexts
{
    public class LibraryContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=libr.db");
        
    }
}