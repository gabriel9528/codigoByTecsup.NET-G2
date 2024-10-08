using AutoMapper;
using Microservicios.Services.CouponAPI.Models;
using Microservicios.Services.CouponAPI.Models.Dto;

namespace Microservicios.Services.CouponAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<Coupon, CouponDto>().ReverseMap();
            });

            return mappingConfig;
        }
    }
}
