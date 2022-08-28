using AspectOriented.Entity.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace AspectOriented.Dal.EfCore.Abstract
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        IQueryable<T> GetAll();

        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);
    }
}
