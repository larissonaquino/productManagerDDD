using AutoMapper;
using Products.Application.Dtos;
using Products.Application.Interfaces;
using Products.Application.Responses;
using Products.Domain.Entities;
using Products.Domain.Interfaces.Services;

namespace Products.Application
{
    public class ProductAppService : IProductAppService
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductAppService(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        public ProductResponseDto Get(PageDto pageDto)
        {
            var page = _mapper.Map<Page>(pageDto);
            var productResponse = _productService.Get(page);

            return _mapper.Map<ProductResponseDto>(productResponse);
        }

        public ProductDto GetById(int id)
        {
            var product = _productService.GetById(id);
            return _mapper.Map<ProductDto>(product);
        }

        public ProductDto Add(ProductDto productDto)
        {
            var product = _mapper.Map<Product>(productDto);
            var newProductDto = _productService.Post(product);
            
            return _mapper.Map<ProductDto>(newProductDto);
        }

        public ProductDto Update(ProductDto productDto)
        {
            var product = _mapper.Map<Product>(productDto);
            var updatedProductDto = _productService.Put(product);

            return _mapper.Map<ProductDto>(updatedProductDto);
        }

        public void Delete(int id)
        {
            _productService.Delete(id);
        }
    }
}
