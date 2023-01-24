using Products.Application.Dtos;
using Products.Application.Responses;

namespace Products.Application.Interfaces
{
    public interface IProductAppService
    {
        ProductResponseDto Get(PageDto pageDto);

        ProductDto GetById(int id);

        ProductDto Add(ProductDto productDto);

        ProductDto Update(ProductDto productDto);

        void Delete(int id);
    }
}
