using MediatrFun.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace MediatrFun.Data.Repositories
{
    public class DataContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options) =>
        options.UseSqlite("Data Source=database.db");
        
    }
}