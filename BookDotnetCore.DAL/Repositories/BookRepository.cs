using BookDotnetCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using BookDotnetCore.DAL.Data;

namespace BookDotnetCore.DAL.Repositories
{
    public class BookRepository : IBookRepository
    {
        private BookDbContext _dbContext;
        public BookRepository(BookDbContext bookDbContext)
        {
            _dbContext = bookDbContext;
        }
        public string DeleteBook(int bookId)
        {
            return "Deleted";
        }

        public List<BookDetails> GetAllBooks()
        {
            return new List<BookDetails>();
        }

        public BookDetails GetBook(int bookId)
        {
            BookDetails bookDetails = new BookDetails();
            return bookDetails;
        }

        public string SaveBook(BookDetails bookDetails)
        {
            _dbContext.bookDetails.Add(bookDetails);
            _dbContext.SaveChanges();
            return "Saved";
        }

        public string UpdateBook(BookDetails bookDetails)
        {
            return "Updated";
        }
    }
}
