using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Data.Repository
{
    public interface IModelRepository
    {
        T Add<T>(T entity) where T : class;
        IQueryable<T> Fetch<T>() where T : class;
        void Remove<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void SaveChanges();
        DbContext ModelDbContext();
    }
}
