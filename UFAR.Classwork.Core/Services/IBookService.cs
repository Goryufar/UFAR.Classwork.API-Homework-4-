using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UFAR.Classwork.Data.Entities;

namespace UFAR.Classwork.Core.Services
{
    public interface IBookService
    {
        void AddBook(BooksEntity book);
        void RemoveBook(int bookId);
        void UpdateBook(BooksEntity book);

        void DeleteBook(BooksEntity entity);
        List<BooksEntity> GetBooks();
        BooksEntity GetBookById(int bookId);
        BooksEntity GetBookByTitle(string title);
        BooksEntity GetBookByAuthor(string name);
        List<BooksEntity> GetBooksByLibraryId(int libraryId);
      
    }
}
