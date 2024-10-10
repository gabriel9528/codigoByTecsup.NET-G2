using Microservicios.Services.ShoppingCartAPI.Models.Dto;

namespace Microservicios.Services.ShoppingCartAPI.Service.IService
{
    public interface ICouponService
    {
        Task<CouponDto> GetCoupon(string couponCode);
    }
}
