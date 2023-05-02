using Microsoft.EntityFrameworkCore;
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
        public async Task<List<Product>> GetHomePageProductsAsync()
        {
            var result = await _context
                .Products
                .Where(p => p.IsActive && !p.IsDeleted && p.IsHome)
                .ToListAsync();
            return result;
        }
    }
}
