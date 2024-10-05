using AutoMapper;
using Microservicios.Services.ShoppingCartAPI.Models;
using Microservicios.Services.ShoppingCartAPI.Models.Dto;

namespace Microservicios.Services.ShoppingCartAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<CartHeader, CartHeaderDto>().ReverseMap();
                config.CreateMap<CartDetails, CartDetailsDto>().ReverseMap();
            });

            return mappingConfig;
        }
    }
}
