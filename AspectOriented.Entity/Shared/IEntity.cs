using System;
using System.Collections.Generic;
using System.Text;

namespace AspectOriented.Entity.Shared
{
    public interface IEntity
    {
        public DateTime CreatedAt { get; set; }
    }
}
