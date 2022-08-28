using AspectOriented.Bll.Abstract;
using AspectOriented.Dal.EfCore;
using AspectOriented.Dal.EfCore.Abstract;
using AspectOriented.Dal.EfCore.Concrete;
using AspectOriented.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AspectOriented.Bll.Concrete
{
    public class ProductRepository : EntityBaseRepository<Product>, IProductRepository
    {
        public ProductRepository(AspectOrientedContext context) : base(context)
        {
        }

        public void Add(Product entity)
        {
           
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
