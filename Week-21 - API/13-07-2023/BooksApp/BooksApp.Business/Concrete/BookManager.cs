using AutoMapper;
using BooksApp.Business.Abstract;
using BooksApp.Data.Abstract;
using BooksApp.Entity.Concrete;
using BooksApp.Shared.DTOs;
using BooksApp.Shared.ResponseDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksApp.Business.Concrete
{
    public class BookManager : IBookService
    {
        private readonly IBookRepository _bookRepository;
        private readonly IAuthorRepository _authorRepository;
        private readonly IPublisherRepository _publisherRepository;
        private readonly IMapper _mapper;

        public BookManager(IBookRepository bookRepository, IMapper mapper, IAuthorRepository authorRepository, IPublisherRepository publisherRepository)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
            _authorRepository = authorRepository;
            _publisherRepository = publisherRepository;
        }

        public async Task<Response<BookDto>> CreateAsync(BookCreateDto bookCreateDto)
        {
            var newBook = _mapper.Map<Book>(bookCreateDto);
            newBook.CreatedDate = DateTime.Now;
            newBook.Author = await _authorRepository.GetByIdAsync(newBook.AuthorId);
            newBook.Publisher = await _publisherRepository.GetByIdAsync(newBook.PublisherId);
            await _bookRepository.CreateAsync(newBook);
            return Response<BookDto>.Success(_mapper.Map<BookDto>(newBook), 201);
        }

        public async Task<Response<NoContent>> DeleteAsync(int id)
        {
            var deletedBook = await _bookRepository.GetByIdAsync(id);
            if (deletedBook != null)
            {
                return Response<NoContent>.Fail("Böyle bir kitap yok", 401);
            }
            return Response<NoContent>.Success(200);

        }

        public async Task<Response<List<BookDto>>> GetAllAsync()
        {
            var bookList = await _bookRepository.GetAllAsync();
            if (bookList.Any())
            {
                foreach (var book in bookList)
                {
                    book.Author = await _authorRepository.GetByIdAsync(book.AuthorId);
                    book.Publisher = await _publisherRepository.GetByIdAsync(book.PublisherId);
                }
                return Response<List<BookDto>>.Success(_mapper.Map<List<BookDto>>(bookList), 201);
            }
            return Response<List<BookDto>>.Fail("Kayıtlı kitap bulunamadı.", 401);

        }

        public async Task<Response<BookDto>> GetByIdAsync(int id)
        {
            var bookId = await _bookRepository.GetByIdAsync(id);
            if (bookId != null)
            {
                bookId.Author = await _authorRepository.GetByIdAsync(bookId.AuthorId);
                bookId.Publisher = await _publisherRepository.GetByIdAsync(bookId.PublisherId);

                var bookDto = _mapper.Map<BookDto>(bookId);
                return Response<BookDto>.Success(bookDto, 200);

            }
            return Response<BookDto>.Fail("Kitap bulunamadı", 401);
        }

        public async Task<Response<NoContent>> UpdateAsync(BookUpdateDto bookUpdateDto)
        {
            var isThere = await _bookRepository.AnyAsync(bookUpdateDto.Id);
            if (isThere)
            {
                var book = _mapper.Map<Book>(bookUpdateDto);
                book.ModifiedDate = DateTime.Now;
                _bookRepository.Update(book);
            }
            return Response<NoContent>.Success(204);
        }
    }
}
