using System.Collections.Generic;
using System.Threading.Tasks;
using Library.BLL;
using Library.Domain.Model;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers
{
    public class BookController
    {
        private readonly BookService _bookService;

        public BookController(BookService bookService)
        {
            _bookService = bookService;
        }


        [HttpPut]
        [Route("")]
        public async Task<Book> PutAsync(Book book)
        {
            return await _bookService.CreateAsync(book);
        }

        [HttpPatch]
        [Route("")]
        public async Task<Book> PatchAsync(Book book)
        {
            return await _bookService.UpdateAsync(book);
        }

        [HttpGet]
        [Route("")]
        public async Task<IEnumerable<Book>> GetAsync()
        {
            return await _bookService.GetAllAsync();
        }

        [HttpGet]
        [Route("{bookId}")]
        public async Task<Book> GetAsync(int bookId)
        {
            return await _bookService.GetAsync(bookId);
        }
    }
}