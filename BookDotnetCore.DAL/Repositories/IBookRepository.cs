using System;
using System.Collections.Generic;
using System.Text;
using BookDotnetCore.Entity;

namespace BookDotnetCore.DAL.Repositories
{
    public interface IBookRepository
    {
        string SaveBook(BookDetails bookDetails);
        string UpdateBook(BookDetails bookDetails);
        string DeleteBook(int bookId);

        BookDetails GetBook(int bookId);
        List<BookDetails> GetAllBooks();
        
    }
}
