using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Library.BLL;
using Library.Domain.Model;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthorController
    {
        private readonly AuthorService _authorService;

        public AuthorController(AuthorService authorService)
        {
            _authorService = authorService;
        }

        [HttpPut]
        [Route("")]
        public async Task<Author> PutAsync(Author author)
        {
            return await _authorService.CreateAsync(author);
        }

        [HttpPatch]
        [Route("")]
        public async Task<Author> PatchAsync(Author author)
        {
            return await _authorService.UpdateAsync(author);
        }

        [HttpGet]
        [Route("")]
        public async Task<IEnumerable<Author>> GetAsync()
        {
            return await _authorService.GetAllAsync();
        }

        [HttpGet]
        [Route("{authorId}")]
        public async Task<Author> GetAsync(int authorId)
        {
            return await _authorService.GetAsync(authorId);
        }
    }
}