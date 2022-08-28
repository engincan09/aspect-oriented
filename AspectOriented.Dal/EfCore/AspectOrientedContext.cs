using AspectOriented.Entity.Models;
using Microsoft.EntityFrameworkCore;

namespace AspectOriented.Dal.EfCore
{
    public class AspectOrientedContext : DbContext
    {
        public AspectOrientedContext(DbContextOptions<AspectOrientedContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }


}
