using System.Collections.Generic;
using System.Threading.Tasks;
using Library.Domain.Model;

namespace Library.Domain.Repositories
{
    public interface IBookRepository
    {
        Task<IEnumerable<Book>> GetAllAsync();
        Task<Book> GetAsync(int id);
        Task<Book> CreateAsync(Book book);
        Task<Book> UpdateAsync(Book book);
        Task DeleteAsync(int id);
    }
}