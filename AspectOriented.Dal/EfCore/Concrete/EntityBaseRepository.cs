using AspectOriented.Dal.EfCore.Abstract;
using AspectOriented.Entity.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace AspectOriented.Dal.EfCore.Concrete
{
    public class EntityBaseRepository<T> : IEntityRepository<T> where T : class, IEntity, new()
    {
        private readonly DbContext _context;

        public EntityBaseRepository(DbContext context)
        {
            _context = context;
        }

        public virtual IQueryable<T> GetAll()
        {
            return _context.Set<T>().AsQueryable();
        }
        public virtual void Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }
        public virtual void Update(T entity)
        {
            _context.Update<T>(entity);
        }
        public virtual void Delete(T entity)
        {
            _context.Remove<T>(entity);
        }
    }
}
