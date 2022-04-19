using System;
using System.Collections.Generic;
using System.Text;
using BookDotnetCore.DAL.Repositories;
using BookDotnetCore.Entity;
namespace BookDotnetCore.BAL.services
{
    public class BookDetailsService
    {
        private IBookRepository _bookRepository;
        public BookDetailsService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        public string SaveBook(BookDetails bookDetails)
        {
            return _bookRepository.SaveBook(bookDetails); 
        }
    }
}
