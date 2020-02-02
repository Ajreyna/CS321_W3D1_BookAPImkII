using System;
using System.Collections.Generic;
using System.Linq;
using CS321_W3D1_BookAPI.Data;
using CS321_W3D1_BookAPI.Models;

namespace CS321_W3D1_BookAPI.Services
{
    public class BookService : IBookService
    {
        private readonly BookContext _bookContext;

        public BookService(BookContext bookContext)
        {
            _bookContext = bookContext;
        }
        public void Delete(Book deletedBook)
        {
            //throw new NotImplementedException();
            _bookContext.Books.Remove(deletedBook);
            _bookContext.SaveChanges();

        }

        public Book Get(int bookId)
        {
            return _bookContext.Books.FirstOrDefault(b => b.Id == bookId);
        }

        public IEnumerable<Book> GetAll()
        {
            return _bookContext.Books.ToList();

        }

        //private int nextInt = 3;
        public Book Add(Book newBook)
        {
            //throw new NotImplementedException();
            //newBook.Id = nextInt++;
            //newBook.Post(newBook);
            _bookContext.Books.Add(newBook);
            _bookContext.SaveChanges();
            return newBook;
        }

        public Book Update(Book updatedBook)
        {
            //throw new NotImplementedException
            var currentBook = _bookContext.Books.FirstOrDefault(b => b.Id == updatedBook.Id);
            if (currentBook == null) return null;
            _bookContext.Entry(currentBook).CurrentValues.SetValues(updatedBook);
            _bookContext.SaveChanges();
            return updatedBook;


        }
    }
}
