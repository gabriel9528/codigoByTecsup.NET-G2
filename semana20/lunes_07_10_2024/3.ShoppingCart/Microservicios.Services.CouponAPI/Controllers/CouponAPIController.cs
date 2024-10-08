using AutoMapper;
using Azure;
using Microservicios.Services.CouponAPI.Data;
using Microservicios.Services.CouponAPI.Models;
using Microservicios.Services.CouponAPI.Models.Dto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Microservicios.Services.CouponAPI.Controllers
{
    [Route("api/coupon")]
    [ApiController]
    //[Authorize]
    public class CouponAPIController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        private ResponseDto _response;
        private readonly IMapper _mapper;
        public CouponAPIController(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _response = new ResponseDto();
            _mapper = mapper;
        }

        [HttpGet]
        public ResponseDto GetAll()
        {
            try
            {
                IEnumerable<Coupon> couponList = _db.Coupon.ToList();
                _response.Result = _mapper.Map<IEnumerable<CouponDto>>(couponList);
                _response.Message = "Cupones obtenidos con éxito.";
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = "Ocurrió un error al obtener los cupones.";
            }
            return _response;
        }


        [HttpGet]
        [Route("{id:int}")]
        public ResponseDto GetById(int id)
        {
            try
            {
                Coupon coupon = _db.Coupon.FirstOrDefault(c => c.CouponId == id);
                if (coupon != null)
                {
                    _response.Result = _mapper.Map<CouponDto>(coupon);
                    _response.IsSuccess = true;
                    _response.Message = $"Cupón {coupon.CouponCode} recuperado con éxito.";
                }
                else
                {
                    _response.IsSuccess = false;
                    _response.Message = "Cupón no encontrado.";
                }
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = "Ocurrió un error al obtener el cupón.";
            }
            return _response;
        }

        [HttpGet]
        [Route("GetByCode/{code}")]
        public ResponseDto GetByCode(string code)
        {
            try
            {
                Coupon coupon = _db.Coupon.FirstOrDefault(c => c.CouponCode.ToLower() == code.ToLower());
                if (coupon != null)
                {
                    _response.Result = _mapper.Map<CouponDto>(coupon);
                    _response.IsSuccess = true;
                    _response.Message = $"Cupón {coupon.CouponCode} recuperado con éxito.";
                }
                else
                {
                    _response.IsSuccess = false;
                    _response.Message = "Cupón no encontrado.";
                }
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = "Ocurrió un error al obtener el cupón.";
            }
            return _response;
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public ResponseDto Post([FromBody] CouponDto couponDto)
        {
            try
            {
                if (couponDto != null)
                {
                    Coupon coupon = _mapper.Map<Coupon>(couponDto);
                    _db.Coupon.Add(coupon);
                    _db.SaveChanges();

                    _response.Result = _mapper.Map<CouponDto>(coupon);
                    _response.Message = $"Cupón {couponDto.CouponCode} creado con éxito.";
                }
                else
                {
                    _response.IsSuccess = false;
                    _response.Message = "El cupón ingresado no es valido.";
                }
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = "Ocurrió un error al crear el cupón.";
            }
            return _response;
        }

        [HttpPut]
        [Authorize(Roles = "Admin")]
        public ResponseDto Put([FromBody] CouponDto couponDto)
        {
            try
            {
                if(couponDto != null)
                {
                    Coupon coupon = _mapper.Map<Coupon>(couponDto);
                    _db.Coupon.Update(coupon);
                    _db.SaveChanges();

                    _response.Result = _mapper.Map<CouponDto>(coupon);
                    _response.Message = $"Cupón {couponDto.CouponId} actualizado con éxito.";
                }
                else
                {
                    _response.IsSuccess = false;
                    _response.Message = "El cupón ingresado no es valido.";
                }
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = "Ocurrió un error al crear el cupón.";
            }
            return _response;
            
        }

        [HttpDelete]
        [Route("{id:int}")]
        [Authorize(Roles = "Admin")]
        public ResponseDto Delete(int id)
        {
            var response = new ResponseDto();
            try
            {
                if(id <= 0)
                {
                    _response.IsSuccess = false;
                    _response.Message = "El id del cupón no es válido.";
                }
                else
                {
                    Coupon coupon = _db.Coupon.FirstOrDefault(x => x.CouponId == id);
                    if(coupon != null)
                    {
                        _db.Coupon.Remove(coupon);
                        _db.SaveChanges();

                        _response.Result = _mapper.Map<CouponDto>(coupon);
                        _response.Message = $"Cupón {coupon.CouponCode} eliminado con éxito.";
                    }
                    else
                    {
                        _response.IsSuccess = false;
                        _response.Message = "El cupón no existe.";
                    }
                }
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

    }
}
