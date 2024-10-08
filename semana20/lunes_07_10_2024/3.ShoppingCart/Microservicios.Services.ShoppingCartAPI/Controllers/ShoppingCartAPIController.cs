using AutoMapper;
using Microservicios.Services.ShoppingCartAPI.Data;
using Microservicios.Services.ShoppingCartAPI.Models;
using Microservicios.Services.ShoppingCartAPI.Models.Dto;
using Microservicios.Services.ShoppingCartAPI.Service.IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Microservicios.Services.ShoppingCartAPI.Controllers
{
    [Route("api/shoppingCart")]
    [ApiController]
    public class ShoppingCartAPIController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public ResponseDto _responseDto;
        private readonly IMapper _mapper;
        private readonly ICouponService _couponService;
        private readonly IProductService _productService;
        private readonly IConfiguration _configuration;

        public ShoppingCartAPIController(ApplicationDbContext db, IMapper mapper, ICouponService couponService, IProductService productService, IConfiguration configuration)
        {
            _db = db;
            _mapper = mapper;
            _couponService = couponService;
            _productService = productService;
            _configuration = configuration;
            _responseDto = new ResponseDto();
        }

        [HttpPost("ApplyCoupon")]
        public async Task<ResponseDto> ApplyCoupon([FromBody] CartDto cartDto)
        {
            try
            {
                var cartHeaderFromDb = await _db.CartHeaders.FirstAsync(x => x.UserId == cartDto.CartHeaderDto.UserId);
                cartHeaderFromDb.CouponCode = cartDto.CartHeaderDto.CouponCode;
                _db.CartHeaders.Update(cartHeaderFromDb);
                await _db.SaveChangesAsync();
                _responseDto.Result = true;

            }
            catch (Exception ex)
            {
                _responseDto.IsSuccess = false;
                _responseDto.Message = ex.Message.ToString();
            }

            return _responseDto;
        }

        [HttpPost("RemoveCoupon")]
        public async Task<ResponseDto> RemoveCoupon([FromBody] CartDto cartDto)
        {
            try
            {
                var cartHeaderFromDb = await _db.CartHeaders.FirstAsync(x => x.UserId == cartDto.CartHeaderDto.UserId);
                cartHeaderFromDb.CouponCode = "";
                _db.CartHeaders.Update(cartHeaderFromDb);
                await _db.SaveChangesAsync();
                _responseDto.Result = true;

            }
            catch (Exception ex)
            {
                _responseDto.IsSuccess = false;
                _responseDto.Message = ex.Message.ToString();
            }

            return _responseDto;
        }

        [HttpPost("CartUpsert")]
        public async Task<ResponseDto> CartUpsert(CartDto cartDto)
        {
            try
            {
                var cartHeaderFromdDb = await _db.CartHeaders.AsNoTracking().FirstOrDefaultAsync(x => x.UserId == cartDto.CartHeaderDto.UserId);
                if (cartHeaderFromdDb == null)
                {
                    //Crear la cabezera y los details
                    CartHeader cartHeader = _mapper.Map<CartHeader>(cartDto.CartHeaderDto);
                    _db.CartHeaders.Add(cartHeader);
                    await _db.SaveChangesAsync();

                    //Relacionar la cabezera con cada uno de los details
                    cartDto.CartDetailsDto.First().CartHeaderId = cartHeader.CartHeaderId;
                    CartDetails cartDetails = _mapper.Map<CartDetails>(cartDto.CartDetailsDto.First());
                    _db.CartDetails.Add(cartDetails);
                    await _db.SaveChangesAsync();

                    _responseDto.Result = cartDto;

                }
                else
                {
                    //si la cabezera ya existe, revisar si los details tienen el mismo producto
                    var cartDetailsFromDb = await _db.CartDetails.AsNoTracking().FirstOrDefaultAsync(
                        x => x.ProductId == cartDto.CartDetailsDto.First().ProductId &&
                        x.CartHeaderId == cartHeaderFromdDb.CartHeaderId);

                    if (cartDetailsFromDb == null)
                    {
                        //creamos los details
                        cartDto.CartDetailsDto.First().CartHeaderId = cartHeaderFromdDb.CartHeaderId;
                        _db.CartDetails.Add(_mapper.Map<CartDetails>(cartDto.CartDetailsDto.First()));
                        await _db.SaveChangesAsync();
                    }
                    else
                    {
                        //actualizamos la cantidad y los details
                        cartDto.CartDetailsDto.First().Count += cartDetailsFromDb.Count;
                        cartDto.CartDetailsDto.First().CartHeaderId = cartHeaderFromdDb.CartHeaderId;
                        cartDto.CartDetailsDto.First().CarDetailsId = cartDetailsFromDb.CarDetailsId;
                        _db.CartDetails.Update(_mapper.Map<CartDetails>(cartDto.CartDetailsDto.First()));
                        await _db.SaveChangesAsync();

                    }

                    _responseDto.Result = cartDto;

                }


            }
            catch (Exception ex)
            {
                _responseDto.IsSuccess = false;
                _responseDto.Message = ex.Message.ToString();
            }

            return _responseDto;
        }

        [HttpGet("GetCart/{userId}")]
        public async Task<ResponseDto> GetCart(string userId)
        {
            try
            {
                CartDto cartDto = new CartDto()
                {
                    CartHeaderDto = _mapper.Map<CartHeaderDto>(_db.CartHeaders.First(x => x.UserId == userId)),
                };

                cartDto.CartDetailsDto = _mapper.Map<IEnumerable<CartDetailsDto>>(_db.CartDetails
                    .Where(x => x.CartHeaderId == cartDto.CartHeaderDto.CartHeaderId));

                //IProductService
                IEnumerable<ProductDto> productDtoList = await _productService.GetProducts();
                foreach (var item in cartDto.CartDetailsDto)
                {
                    item.Product = productDtoList.FirstOrDefault(x => x.ProductId == item.ProductId);
                    cartDto.CartHeaderDto.CartTotal += (item.Product.Price * item.Count);
                }

                //ICouponService - valida si existe el coupon
                if (!string.IsNullOrEmpty(cartDto.CartHeaderDto.CouponCode))
                {
                    CouponDto couponDto = await _couponService.GetCoupon(cartDto.CartHeaderDto.CouponCode);
                    if (couponDto != null && cartDto.CartHeaderDto.CartTotal > couponDto.MinimumAmount)
                    {
                        cartDto.CartHeaderDto.CartTotal -= couponDto.DiscountAmount;
                        cartDto.CartHeaderDto.Discount = couponDto.DiscountAmount;
                    }
                }

                _responseDto.Result = cartDto;

            }
            catch (Exception ex)
            {
                _responseDto.IsSuccess = false;
                _responseDto.Message = ex.Message.ToString();
            }

            return _responseDto;
        }

        [HttpPost("RemoveFromCart")]
        public async Task<ResponseDto> RemoveCart([FromBody] int cartDetailsId)
        {
            try
            {
                CartDetails cartDetails = _db.CartDetails.First(x => x.CarDetailsId == cartDetailsId);

                int totalCountOfCartItems = _db.CartDetails.Where(x => x.CartHeaderId == cartDetails.CartHeaderId).Count();
                _db.CartDetails.Remove(cartDetails);

                if (totalCountOfCartItems == 1)
                {
                    var carHeaderFromDb = await _db.CartHeaders.FirstAsync(x => x.CartHeaderId == cartDetails.CartHeaderId);
                    _db.CartHeaders.Remove(carHeaderFromDb);
                }

                await _db.SaveChangesAsync();
                _responseDto.Result = true;

            }
            catch (Exception ex)
            {
                _responseDto.IsSuccess = false;
                _responseDto.Message = ex.Message.ToString();
            }

            return _responseDto;
        }
    }
}
