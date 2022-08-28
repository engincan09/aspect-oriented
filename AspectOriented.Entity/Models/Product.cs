using AspectOriented.Entity.Shared;
using System;

namespace AspectOriented.Entity.Models
{
    public class Product:IEntity
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int CategoryId { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }
        public DateTime CreatedAt { get; set; }
    }

}
