using BookDotnetCore.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookDotnetCore.DAL.Data
{
    public class BookDbContext:DbContext
    {
        public BookDbContext(DbContextOptions<BookDbContext> options):base (options)
        {

        }
        public DbSet<BookDetails> bookDetails { get; set; }
    }
}
