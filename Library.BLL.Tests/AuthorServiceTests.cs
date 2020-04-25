using System.Linq;
using System.Threading.Tasks;
using Library.DAL.Contexts;
using Library.DAL.Repositories;
using Library.Domain.Model;
using NUnit.Framework;
using Moq;

namespace Library.BLL.Tests
{
    public class Tests
    {
        private readonly AuthorService _authorService = new AuthorService(new AuthorRepository(new LibraryContext()));

        [Test]
        public async Task CreateAuthor_ShouldCreateAuthor()
        {
            const string name = "name", descr = "descr";

            var created = await _authorService.CreateAsync(
                new Author
                {
                    Name = name,
                    Description = descr
                }
            );
            
            Assert.AreEqual(created.Name, name);
            Assert.AreEqual(created.Description, descr);
        }

        [Test]
        public async Task DeleteAuthor_ShouldDeleteAuthor()
        {
            var get = (await _authorService.GetAllAsync()).First();

            await _authorService.DeleteAsync(get.AuthorId);
            
            Assert.IsNull(await _authorService.GetAsync(get.AuthorId));
        }
    }
}