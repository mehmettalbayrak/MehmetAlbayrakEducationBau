using BooksApp.Business.Abstract;
using BooksApp.Data.Abstract;
using BooksApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksApp.Business.Concrete
{
    public class AuthorManager : IAuthorService
    {
        private readonly IAuthorRepository _authorRepository;

        public AuthorManager(IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }

        public async Task CreateAsync(Author author)
        {
            await _authorRepository.CreateAsync(author);
        }

        public void Delete(Author author)
        {
            _authorRepository.Delete(author);
        }

        public async Task<List<Author>> GetAllAsync()
        {
            var result = await _authorRepository.GetAllAsync();
            return result;
        }

        public async Task<Author> GetByIdAsync(int id)
        {
            var result = await _authorRepository.GetByIdAsync(id);
            return result;
        }

        public void Update(Author author)
        {
            _authorRepository.Update(author);
        }
    }
}
