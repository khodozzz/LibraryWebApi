using System.Collections.Generic;
using System.Threading.Tasks;
using Library.Domain.Model;
using Library.Domain.Repositories;
using Library.Domain.Services;

namespace Library.BLL
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task<IEnumerable<Book>> GetAllAsync()
        {
            return await _bookRepository.GetAllAsync();
        }

        public async Task<Book> GetAsync(int id)
        {
            return await _bookRepository.GetAsync(id);
        }

        public async Task<Book> CreateAsync(Book book)
        {
            return await _bookRepository.CreateAsync(book);
        }

        public async Task<Book> UpdateAsync(Book book)
        {
            return await _bookRepository.UpdateAsync(book);
        }
        
        public async Task DeleteAsync(int id)
        {
            await _bookRepository.DeleteAsync(id);
        }
    }
}