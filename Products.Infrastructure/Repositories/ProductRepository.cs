using Microsoft.EntityFrameworkCore;
using Products.Domain.Entities;
using Products.Domain.Interfaces;
using Products.Domain.Interfaces.Repositories;
using System.Linq;

namespace Products.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly IAppDbContext _appContext;

        public ProductRepository(IAppDbContext appContext)
        {
            _appContext = appContext;
        }

        public ProductResponse Get(Page page)
        {
            var products = _appContext.Products.Where(p => p.Situation).Skip(page.Offset).Take(page.PageSize).AsEnumerable();
            page.TotalElements = products.Count();

            var productResponse = new ProductResponse()
            {
                Products = products,
                Page = page
            };

            return productResponse;
        }

        public Product GetById(int id)
        {

            return _appContext.Products.Find(id);
        }

        public Product Add(Product entity)
        {
            _appContext.Products.Add(entity);

            return entity;
        }

        public Product Update(Product entity)
        {
            var product = _appContext.Products.Where(p => p.Id == entity.Id).AsNoTracking();

            if (product is null)
            {
                return null;
            }

            _appContext.Products.Update(entity);

            return entity;
        }

        public void Delete(int id)
        {
            var product = GetById(id);

            product.Situation = false;

            _ = Update(product);
        }

        public void Save()
        {
            _appContext.SaveProductChanges();
        }
    }
}
