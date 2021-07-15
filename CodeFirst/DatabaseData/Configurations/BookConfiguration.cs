using CodeFirst.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.DatabaseData.Configurations
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            //Table Name
            builder.ToTable("Book");

            //Primary Key
            builder.HasKey(x => x.Id);

            builder.HasOne<Author>(a => a.Author)
                .WithMany(x => x.Books)
                .HasForeignKey(f => f.AuthorId);

           
            
        }
    }
}
