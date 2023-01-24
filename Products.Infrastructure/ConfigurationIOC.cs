using Autofac;
using AutoMapper;
using Products.Application;
using Products.Application.Interfaces;
using Products.Domain.Interfaces.Repositories;
using Products.Domain.Interfaces.Services;
using Products.Domain.Services;
using Products.Infrastructure.Repositories;

namespace Products.Infrastructure
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ProductAppService>().As<IProductAppService>().InstancePerDependency();
            builder.RegisterType<ProductService>().As<IProductService>().InstancePerDependency();
            builder.RegisterType<ProductRepository>().As<IProductRepository>().InstancePerDependency();
            builder.RegisterType<Mapper>().As<IMapper>().InstancePerDependency();
        }
    }
}
