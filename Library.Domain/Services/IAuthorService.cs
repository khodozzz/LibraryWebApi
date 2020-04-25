using System.Collections.Generic;
using System.Threading.Tasks;
using Library.Domain.Model;

namespace Library.Domain.Services
{
    public interface IAuthorService
    {
        Task<IEnumerable<Author>> GetAllAsync();
        Task<Author> GetAsync(int id);
        Task<Author> CreateAsync(Author author);
        Task<Author> UpdateAsync(Author author);
        Task DeleteAsync(int id);
    }
}