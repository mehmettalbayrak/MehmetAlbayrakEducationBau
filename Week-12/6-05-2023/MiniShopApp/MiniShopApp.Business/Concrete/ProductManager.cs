using MiniShopApp.Business.Abstract;
using MiniShopApp.Data.Abstract;
using MiniShopApp.Data.Concrete.EFCore.Repisotories;
using MiniShopApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShopApp.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductManager(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task CreateAsync(Product product)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteAsync(Product product)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Product>> GetActiveProductsAsync(string categoryUrl = null)
        {
            return await _productRepository.GetActiveProductAsync(categoryUrl);
        }

        public async Task<List<Product>> GetAllAsync()
        {
            return await _productRepository.GetAllAsync();
        }

        public async Task<Product> GetByIdAsync(int id)
        {
            return await _productRepository.GetByIdAsync(id);
        }

        public async Task<List<Product>> GetHomePageProductsAsync()
        {
            return await _productRepository.GetHomePageProductsAsync();
        }

        public async Task<Product> GetProductByUrlAsync(string url)
        {
            return await _productRepository.GetProductByUrlAsync(url);
        }

        public Task UpdateAsync(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
