using Microsoft.EntityFrameworkCore;
using MiniShopApp.Data.Abstract;
using MiniShopApp.Data.Concrete.EFCore.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShopApp.Data.Concrete.EFCore.Repisotories
{
    public class EFCoreGenericRepisotory<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        MiniShopAppContext _context = new MiniShopAppContext();
        public void Create(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            _context.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
            _context.SaveChanges();
        }

        public List<TEntity> GetAll()
        {
            return _context.Set<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public void Update(TEntity entity)
        {
            //_context.Entry(entity).State = EntityState.Modified; 
            _context.Set<TEntity>().Update(entity);
            _context.SaveChanges();
        }
    }
}
