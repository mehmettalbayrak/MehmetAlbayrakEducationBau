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
    public class PublisherManager : IPublisherService
    {
        private readonly IPublisherRepository _publisherRepository;
        private readonly IMapper _mapper;

        public PublisherManager(IPublisherRepository publisherRepository, IMapper mapper)
        {
            _publisherRepository = publisherRepository;
            _mapper = mapper;
        }

        public async Task<Response<PublisherDto>> CreateAsync(PublisherCreateDto publisherCreateDto)
        {
            var publisherCreate = _mapper.Map<Publisher>(publisherCreateDto);
            await _publisherRepository.CreateAsync(publisherCreate);
            return Response<PublisherDto>.Success(_mapper.Map<PublisherDto>(publisherCreate));
        }

        public void Delete(Publisher publisher)
        {
            _publisherRepository.Delete(publisher);
        }

        public async Task<List<Publisher>> GetAllAsync()
        {

            var result = await _publisherRepository.GetAllAsync();
            return result;
        }

        public async Task<List<Publisher>> GetAllPublishersAsync(bool isDeleted, bool? isActive = null)
        {
            var result = await _publisherRepository.GetAllPublishersAsync(isDeleted, isActive);
            return result;
        }

        public async Task<Publisher> GetByIdAsync(int? id)
        {
            var result = await _publisherRepository.GetByIdAsync(id);
            return result;
        }

        public void Update(Publisher publisher)
        {
            _publisherRepository.Update(publisher);
        }
    }
}
