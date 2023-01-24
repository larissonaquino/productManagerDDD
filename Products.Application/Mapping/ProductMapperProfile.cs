using AutoMapper;
using Products.Application.Dtos;
using Products.Application.Responses;
using Products.Domain.Entities;
using System.Diagnostics.CodeAnalysis;

namespace Products.Infrastructure.Mapping
{
    [ExcludeFromCodeCoverage]
    public class ProductMapperProfile : Profile
    {
        public ProductMapperProfile()
        {
            CreateMap<ProductDto, Product>().ReverseMap();
            CreateMap<PageDto, Page>().ReverseMap();
            CreateMap<PageResponseDto, Page>().ReverseMap();
            CreateMap<ProductResponseDto, ProductResponse>().ReverseMap();
        }
    }
}
