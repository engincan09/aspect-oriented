using AspectOriented.Core.Utilities.Results.Abstract;
using AspectOriented.Dal.EfCore.Abstract;
using AspectOriented.Dal.EfCore.Concrete;
using AspectOriented.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AspectOriented.Bll.Abstract
{
    public interface ICategoryRepository : IEntityRepository<Category>
    {
        IResult Add(Category category);
        IDataResult<List<Category>> GetAll();
        IResult Delete(Category category);
    }

}
