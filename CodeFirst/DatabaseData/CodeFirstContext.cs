using CodeFirst.DatabaseData.Configurations;
using CodeFirst.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.DatabaseData
{
    public class CodeFirstContext : DbContext
    {
        public CodeFirstContext()
        {

        }
        public CodeFirstContext(DbContextOptions<CodeFirstContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=LAPTOP-JE21CP1B\SQLEXPRESS;Database=CodeFirst;User Id=av;Password=1qaz2wsx@;");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AuthorConfiguration());
            modelBuilder.ApplyConfiguration(new BookConfiguration());
        }


        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}
