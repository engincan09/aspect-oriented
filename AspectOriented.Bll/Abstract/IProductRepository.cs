using AspectOriented.Dal.EfCore.Abstract;
using AspectOriented.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AspectOriented.Bll.Abstract
{
    public interface IProductRepository : IEntityRepository<Product>
    {
    }
}
