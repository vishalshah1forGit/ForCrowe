using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Data.Repository
{
    public class ModelDbRepository : IModelRepository
    {
        private readonly DbContext _context;

        public ModelDbRepository(DbContext context)
        {
            _context = context;
        }
        public DbContext ModelDbContext()
        {
            return _context;
        }

        public T Add<T>(T entity) where T : class
        {
            return _context.Set<T>().Add(entity);
        }

        public IQueryable<T> Fetch<T>() where T : class
        {
            return _context.Set<T>();
        }

        public void Remove<T>(T entity) where T : class
        {
            _context.Set<T>().Remove(entity);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
        public void Update<T>(T entity) where T : class
        {
            _context.Entry(entity).State = EntityState.Modified;
        }
    }
}