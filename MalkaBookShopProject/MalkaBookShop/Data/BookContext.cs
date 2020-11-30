using MalkaBookShop.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MalkaBookShop.Data
{
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions options) : base(options) { }
        
        public DbSet<Books> Books { get; set; }

        //override tables names to singular
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Books>().ToTable("Book");
        }
    }
}
