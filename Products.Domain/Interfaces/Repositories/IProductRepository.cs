using Products.Domain.Entities;

namespace Products.Domain.Interfaces.Repositories
{
    public interface IProductRepository
    {
        ProductResponse Get(Page page);

        Product GetById(int id);

        Product Add(Product entity);

        Product Update(Product entity);

        void Delete(int id);

        void Save();
    }
}
