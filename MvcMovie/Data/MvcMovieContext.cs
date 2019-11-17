using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;


namespace MvcMovie.Data
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext()
        {
        }

        public MvcMovieContext(DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
        }
        public DbSet<Movie> Movie { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Warehouse> Warehouse { get; set; }
        public DbSet<Sell> Sell { get; set; }        
    }
    public class AspnetNoteDbContext : DbContext

    {
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=AspnetNoteDb;User Id=sa;
Password = 1q2w3e4r; ");
        }

    }
}