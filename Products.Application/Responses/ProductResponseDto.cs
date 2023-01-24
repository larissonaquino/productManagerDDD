using Products.Application.Dtos;
using System.Collections.Generic;

namespace Products.Application.Responses
{
    public class ProductResponseDto
    {
        public IEnumerable<ProductDto> Products { get; set; }
        public PageResponseDto Page { get; set; }
    }
}
