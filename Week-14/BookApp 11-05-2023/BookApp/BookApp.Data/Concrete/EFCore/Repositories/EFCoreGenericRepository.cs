using BooksApp.Data.Abstract;
using BooksApp.Data.Concrete.EFCore.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksApp.Data.Concrete.EFCore.Repositories
{
    public class EFCoreGenericRepository<TEntity>: IGenericRepository<TEntity> where TEntity : class
    {
        BooksAppContext _context = new BooksAppContext();

        public async Task CreateAsync(TEntity entity)
        {
            await _context.Set<TEntity>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public void Delete (TEntity entity) 
        {
            _context.Set<TEntity>().Remove(entity);
            _context.SaveChanges();
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
            return await _context.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await _context.Set<TEntity>().FirstAsync();
        }

        public void Update(TEntity entity)
        {
            _context.Set<TEntity>().Update(entity);
            _context.SaveChangesAsync();
        }
    }
}
