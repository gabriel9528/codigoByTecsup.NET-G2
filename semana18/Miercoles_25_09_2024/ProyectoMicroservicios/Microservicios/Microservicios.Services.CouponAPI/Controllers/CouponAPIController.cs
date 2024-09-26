using AutoMapper;
using Microservicios.Services.CouponAPI.Data;
using Microservicios.Services.CouponAPI.Models;
using Microservicios.Services.CouponAPI.Models.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Microservicios.Services.CouponAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CouponAPIController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        private ResponseDto _response;
        private readonly IMapper _mapper;

        public CouponAPIController(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
            _response = new ResponseDto();
        }

        [HttpGet]
        public ResponseDto GetAll()
        {
            try
            {
                IEnumerable<Coupon> couponList = _db.Coupon.ToList();
                _response.Result = _mapper.Map<IEnumerable<CouponDto>>(couponList);
                _response.Message = "Cupones recuperados con exito";
            }
            catch(Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = "Ocurrio un error al obtener los cupones";
            }

            return _response;
        }

        [HttpGet]
        [Route("{id:int}")]
        public ResponseDto GetById(int id)
        {
            try
            {
                Coupon coupon = _db.Coupon.FirstOrDefault(x => x.CouponId == id);
                if (coupon != null)
                {
                    _response.Result = _mapper.Map<CouponDto>(coupon);
                    _response.Message = $"Cupon {coupon.CouponCode} recuperado con exito";
                }
                else
                {
                    _response.IsSuccess = false;
                    _response.Message = "Cupon no encontrado";
                }

            }catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = "Ocurrio un error al obtener el cupon";
            }

            return _response;
        }

        [HttpGet]
        [Route("GetByCode/{code}")]
        public ResponseDto GetByCode(string code)
        {
            try
            {
                Coupon coupon = _db.Coupon.FirstOrDefault(x => x.CouponCode == code);
                if (coupon != null)
                {
                    _response.Result = _mapper.Map<CouponDto>(coupon);
                    _response.Message = $"Cupon {coupon.CouponCode} recuperado con exito";
                }
                else
                {
                    _response.IsSuccess = false;
                    _response.Message = "Cupon no encontrado";
                }

            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = "Ocurrio un error al obtener el cupon";
            }

            return _response;
        }


    }
}
