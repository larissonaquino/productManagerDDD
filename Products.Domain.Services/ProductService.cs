using Products.Domain.Entities;
using Products.Domain.Interfaces.Repositories;
using Products.Domain.Interfaces.Services;

namespace Products.Domain.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public ProductResponse Get(Page page)
        {
            return _productRepository.Get(page);
        }

        public Product GetById(int id)
        {
            return _productRepository.GetById(id);
        }
        public Product Post(Product product)
        {
            var newProduct = _productRepository.Add(product);
            _productRepository.Save();

            return newProduct;
        }

        public Product Put(Product product)
        {
            var updatedProduct = _productRepository.Update(product);
            _productRepository.Save();
            
            return updatedProduct;
        }

        public void Delete(int id)
        {
            _productRepository.Delete(id);
            _productRepository.Save();
        }
    }
}
