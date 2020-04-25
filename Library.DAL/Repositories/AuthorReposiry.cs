using System.Collections.Generic;
using System.Threading.Tasks;
using Library.DAL.Contexts;
using Library.Domain.Model;
using Library.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Library.DAL.Repositories
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly LibraryContext _libraryContext;

        public AuthorRepository(LibraryContext libraryContext)
        {
            _libraryContext = libraryContext;
        }

        public async Task<IEnumerable<Author>> GetAllAsync()
        {
            return await _libraryContext.Authors.ToListAsync();
        }

        public async Task<Author> GetAsync(int id)
        {
            return await _libraryContext.Authors.FirstOrDefaultAsync(a => a.AuthorId == id);
        }

        public async Task<Author> CreateAsync(Author author)
        {
            _libraryContext.Authors.Add(author);
            await _libraryContext.SaveChangesAsync();

            return author;
        }

        public async Task<Author> UpdateAsync(Author update)
        {
            var author = await GetAsync(update.AuthorId);
            if (author == null) return null;
            
            author.Name = update.Name;
            author.Description = update.Description;

            await _libraryContext.SaveChangesAsync();
            return author;
        }

        public async Task DeleteAsync(int id)
        {
            _libraryContext.Remove(await GetAsync(id));
            await _libraryContext.SaveChangesAsync();
        }
    }
}