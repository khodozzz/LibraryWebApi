using System.Collections.Generic;
using System.Threading.Tasks;
using Library.DAL.Contexts;
using Library.Domain.Model;
using Library.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Library.DAL.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly LibraryContext _libraryContext;

        public BookRepository(LibraryContext libraryContext)
        {
            _libraryContext = libraryContext;
        }

        public async Task<IEnumerable<Book>> GetAllAsync()
        {
            return await _libraryContext.Books.ToListAsync();
        }

        public async Task<Book> GetAsync(int id)
        {
            return await _libraryContext.Books.FirstOrDefaultAsync(b => b.BookId == id);
        }

        public async Task<Book> CreateAsync(Book book)
        {
            _libraryContext.Books.Add(book);
            await _libraryContext.SaveChangesAsync();

            return book;
        }

        public async Task<Book> UpdateAsync(Book update)
        {
            var book = await GetAsync(update.BookId);
            if (book == null) return null;
            
            book.Title = update.Title;
            book.Author = update.Author;
            book.Description = update.Description;
            
            await _libraryContext.SaveChangesAsync();
            return book;
        }

        public async Task DeleteAsync(int id)
        {
            _libraryContext.Remove(await GetAsync(id));
            await _libraryContext.SaveChangesAsync();
        }
    }
}