using Microservicios.Services.ShoppingCartAPI.Models.Dto;
using Microservicios.Services.ShoppingCartAPI.Service.IService;
using Newtonsoft.Json;

namespace Microservicios.Services.ShoppingCartAPI.Service
{
    public class CouponService : ICouponService
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public CouponService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<CouponDto> GetCoupon(string couponCode)
        {
            var client = _httpClientFactory.CreateClient("Coupon");
            var response = await client.GetAsync($"/api/coupon/GetByCode/{couponCode}");
            var apiContent = await response.Content.ReadAsStringAsync();
            var responseDto = JsonConvert.DeserializeObject<ResponseDto>(apiContent);
            if(responseDto != null && responseDto.IsSuccess)
            {
                return JsonConvert.DeserializeObject<CouponDto>(Convert.ToString(responseDto.Result));
            }

            return new CouponDto();
        }
    }
}
