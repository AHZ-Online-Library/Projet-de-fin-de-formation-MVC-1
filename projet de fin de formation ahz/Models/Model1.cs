using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace projet_de_fin_de_formation_ahz.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Book_info> Book_info { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book_info>()
                .Property(e => e.Book_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Book_info>()
                .Property(e => e.Language_)
                .IsUnicode(false);

            modelBuilder.Entity<Book_info>()
                .Property(e => e.Publisher_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Book_info>()
                .Property(e => e.Author_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Book_info>()
                .Property(e => e.Genre)
                .IsUnicode(false);

            modelBuilder.Entity<Book_info>()
                .Property(e => e.Edition)
                .IsUnicode(false);

            modelBuilder.Entity<Book_info>()
                .Property(e => e.Book_Description)
                .IsUnicode(false);

            modelBuilder.Entity<Book_info>()
                .Property(e => e.Image_Book)
                .IsUnicode(false);

            modelBuilder.Entity<Book_info>()
                .Property(e => e.file_book)
                .IsUnicode(false);
        }
    }
}
