using AspectOriented.Entity.Shared;
using System;

namespace AspectOriented.Entity.Models
{
    public class Category:IEntity
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
