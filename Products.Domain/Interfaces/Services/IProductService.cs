using Products.Domain.Entities;

namespace Products.Domain.Interfaces.Services
{
    public interface IProductService
    {
        ProductResponse Get(Page page);

        Product GetById(int id);

        Product Post(Product product);

        Product Put(Product product);

        void Delete(int id);
    }
}
