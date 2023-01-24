using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Products.Domain.Entities;

namespace Products.Domain.Interfaces
{
    public interface IAppDbContext
    {
        DbSet<Product> Products { get; set; }

        void SaveProductChanges();
    }
}
