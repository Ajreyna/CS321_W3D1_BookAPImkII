using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using CS321_W3D1_BookAPI.Models;

namespace CS321_W3D1_BookAPI.Services
{
    public interface IBookService
    {
        IEnumerable<Book> GetAll();

        Book Get(int bookId);

        Book Add(Book newBook);

        Book Update(Book updatedBook);

        void Delete(Book deletedBook);

    }
}
