using Microsoft.EntityFrameworkCore;

namespace LibraryProject_Razor.Model
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
                .Property(b => b.BookId)
                .HasColumnName("book_id");

            modelBuilder.Entity<Book>()
                .Property(b => b.Title)
                .HasColumnName("title");

            modelBuilder.Entity<Book>()
                .Property(b => b.FirstName)
                .HasColumnName("first_name");

            modelBuilder.Entity<Book>()
                .Property(b => b.LastName)
                .HasColumnName("last_name");

            modelBuilder.Entity<Book>()
                .Property(b => b.TotalCopies)
                .HasColumnName("total_copies");

            modelBuilder.Entity<Book>()
                .Property(b => b.CopiesInUse)
                .HasColumnName("copies_in_use");

            modelBuilder.Entity<Book>()
                .Property(b => b.Type)
                .HasColumnName("type");

            modelBuilder.Entity<Book>()
                .Property(b => b.Isbn)
                .HasColumnName("isbn");

            modelBuilder.Entity<Book>()
               .Property(b => b.Category)
               .HasColumnName("category");
        }

        public DbSet<Book> Books { get; set; }
    }
}
