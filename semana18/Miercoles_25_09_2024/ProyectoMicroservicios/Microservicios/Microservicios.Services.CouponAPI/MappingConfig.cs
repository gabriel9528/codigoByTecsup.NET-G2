using AutoMapper;
using Microservicios.Services.CouponAPI.Models;
using Microservicios.Services.CouponAPI.Models.Dto;

namespace Microservicios.Services.CouponAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingconfig = new MapperConfiguration(config =>
            {
                config.CreateMap<Coupon, CouponDto>().ReverseMap();
            });

            return mappingconfig;

        }
    }
}
