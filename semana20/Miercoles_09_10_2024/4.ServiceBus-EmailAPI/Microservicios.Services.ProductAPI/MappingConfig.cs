using AutoMapper;
using Microservicios.Services.ProductAPI.Models;
using Microservicios.Services.ProductAPI.Models.Dto;

namespace Microservicios.Services.ProductAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<Product, ProductDto>().ReverseMap();
            });

            return mappingConfig;
        }
    }
}
