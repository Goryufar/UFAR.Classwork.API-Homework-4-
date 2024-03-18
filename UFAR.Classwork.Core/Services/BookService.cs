using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using UFAR.Classwork.Data.DAO;
using UFAR.Classwork.Data.Entities;

namespace UFAR.Classwork.Core.Services
{
    public class BookService : IBookService
    {
        private readonly ApplicationDbContext context;

        public BookService(ApplicationDbContext _context)
        {
            context = _context;
        }

        public void AddBook(BooksEntity book)
        {
            context.Add(book);
            context.SaveChanges();
        }
        public void RemoveBook(int bookId)
        {
            context.Books.FirstOrDefault(x => x.Id == bookId).isDeleted = true;
            context.SaveChanges();
        }
        public void UpdateBook(BooksEntity entity)
        {
            context.Update(entity);
            context.SaveChanges();
        }
        public void DeleteBook(BooksEntity entity) 
        {
            context.Remove(entity);
            context.SaveChanges();
        }
        public List<BooksEntity> GetBooks()
        {
            return context.Books.ToList();
        }
        public BooksEntity GetBookById(int bookId)
        {
            return context.Books.FirstOrDefault(x => x.Id == bookId);
        }

        public BooksEntity GetBookByTitle(string bookName)
        {
            return context.Books.FirstOrDefault(x => x.Name == bookName);
        }

        public BooksEntity GetBookByAuthor(string authorName)
        {
            return context.Books.FirstOrDefault(x => x.Author == authorName);
        }
        public List<BooksEntity> GetBooksByLibraryId(int libraryId)
        {
            return context.Books.Where(x => x.LibraryId == libraryId).ToList();
        }
    }
}
