using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using UFAR.Classwork.Core.Services;
using UFAR.Classwork.Data.Entities;

namespace UFAR.Classwork.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet("List")]
        public IActionResult GetBooks()
        {
            return Ok(_bookService.GetBooks());
        }

        [HttpGet("GetBookById")]
        public IActionResult GetBookById(int bookId)
        {
            return Ok(_bookService.GetBookById(bookId));
        }
        [HttpGet("GetBookByTitle")]
        public IActionResult GetBookByTitle(string title)
        {
            return Ok(_bookService.GetBookByTitle(title));
        }
        [HttpGet("GetBookByAuthor")]
        public IActionResult GetBookByAuthor(string name)
        {
            return Ok(_bookService.GetBookByTitle(name));
        }
        [HttpPost("AddBook")]
        public IActionResult AddBook(BooksEntity book)
        {
            _bookService.AddBook(book);
            return Ok();
        }

        [HttpDelete("RemoveBook")]
        public IActionResult RemoveBook(int bookId)
        {
            _bookService.RemoveBook(bookId);
            return Ok();
        }

        [HttpPut("UpdateBook")]
        public IActionResult UpdateBook(BooksEntity book)
        {
            _bookService.UpdateBook(book);
            return Ok();
        }

        [HttpDelete("DeleteBook")]
        public IActionResult DeleteBook(BooksEntity book)
        {
            _bookService.DeleteBook(book);
            return Ok();
        }
        [HttpGet("FindBooksByLibraryId")]
        public IActionResult GetBooksByLibraryId(int libraryId)
        {
            _bookService.GetBooksByLibraryId(libraryId);
            return Ok();
        }
    }
       
}
