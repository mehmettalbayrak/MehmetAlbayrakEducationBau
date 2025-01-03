﻿using Microsoft.EntityFrameworkCore;
using MiniShopApp.Data.Abstract;
using MiniShopApp.Data.Concrete.EFCore.Contexts;
using MiniShopApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShopApp.Data.Concrete.EFCore.Repisotories
{
    public class EFCoreProductRepository : EFCoreGenericRepisotory<Product>, IProductRepository
    {
        MiniShopAppContext _context = new MiniShopAppContext();

        public async Task<List<Product>> GetActiveProductAsync(string categoryUrl)
        {
            List<Product> result;
            if (categoryUrl == null)
            {
                result = await _context
                    .Products
                    .Where(p => p.IsActive && !p.IsDeleted)
                    .ToListAsync();
                
            }else 
            {
                result = await _context
            .Products
            .Where(p => p.IsActive && !p.IsDeleted)
            .Include(p=>p.ProductCategories)
            .ThenInclude(pc=>pc.Category)
            .Where(p=>p.ProductCategories.Any(pc=>pc.Category.Url == categoryUrl))
            .ToListAsync();
            }
            ;
            return result;
        }

        public async Task<List<Product>> GetHomePageProductsAsync()
        {
            var result = await _context
                .Products
                .Where(p => p.IsActive && !p.IsDeleted && p.IsHome)
                .ToListAsync();
            return result;
        }

        public async Task<Product> GetProductByUrlAsync(string url)
        {
            var result = await _context
            .Products
            .Where(p => p.IsActive && !p.IsDeleted && p.Url == url)
            .Include(p => p.ProductCategories)
            .ThenInclude(pc => pc.Category)
            .FirstOrDefaultAsync();
            return result;
        }
    }
}
