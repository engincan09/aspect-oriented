using AspectOriented.Bll.Abstract;
using AspectOriented.Bll.ValidationRule.FluentValidation;
using AspectOriented.Core.Aspects.Autofac.Caching;
using AspectOriented.Core.Aspects.Autofac.Validation;
using AspectOriented.Core.Constants;
using AspectOriented.Core.Utilities.Results.Abstract;
using AspectOriented.Core.Utilities.Results.Concrete;
using AspectOriented.Dal.EfCore;
using AspectOriented.Dal.EfCore.Concrete;
using AspectOriented.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AspectOriented.Bll.Concrete
{
    public class CategoryRepository : EntityBaseRepository<Category>, ICategoryRepository
    {
        private List<Category> productList;
        public CategoryRepository():base(null)
        {
            productList = new List<Category>
            {
                new Category  { Id = 1, CategoryName = "Soğuk Kahveler",CreatedAt = DateTime.Now},
                new Category  { Id = 2, CategoryName = "Sıcak Kahveler",CreatedAt = DateTime.Now},
                new Category  { Id = 3, CategoryName = "Yemekler",CreatedAt = DateTime.Now},
           };
        }

        [CacheRemoveAspect("ICategoryRepository.Get")]
        public IResult Delete(Category category)
        {
            productList.Remove(category);
            return new SuccessResult(Messages.DeletedMessage);
        }

        [ValidationAspect(typeof(CategoryValidation))]
        [CacheRemoveAspect("ICategoryRepository.Get")]
        public IResult Add(Category category)
        {
            productList.Add(category);
            return new SuccessResult(Messages.AddedMessage);
        }


        [CacheAspect(duration: 10)]
        public IDataResult<List<Category>> GetAll()
        {
            return new SuccessDataResult<List<Category>>(productList,Messages.ListedMessage);
        }
    }
}
