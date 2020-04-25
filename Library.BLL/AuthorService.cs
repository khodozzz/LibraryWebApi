using System.Collections.Generic;
using System.Threading.Tasks;
using Library.Domain.Model;
using Library.Domain.Repositories;
using Library.Domain.Services;

namespace Library.BLL
{
    public class AuthorService : IAuthorService
    {
        private readonly IAuthorRepository _authorRepository;

        public AuthorService(IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }

        public async Task<IEnumerable<Author>> GetAllAsync()
        {
            return await _authorRepository.GetAllAsync();
        }

        public async Task<Author> GetAsync(int id)
        {
            return await _authorRepository.GetAsync(id);
        }

        public async Task<Author> CreateAsync(Author author)
        {
            return await _authorRepository.CreateAsync(author);
        }

        public async Task<Author> UpdateAsync(Author author)
        {
            return await _authorRepository.UpdateAsync(author);
        }

        public async Task DeleteAsync(int id)
        { 
            await _authorRepository.DeleteAsync(id);
        }
    }
}