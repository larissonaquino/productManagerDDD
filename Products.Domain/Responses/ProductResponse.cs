using System.Collections.Generic;

namespace Products.Domain.Entities
{
    public class ProductResponse
    {
        public IEnumerable<Product> Products { get; set; }
        public Page Page { get; set; } 
    }
}
