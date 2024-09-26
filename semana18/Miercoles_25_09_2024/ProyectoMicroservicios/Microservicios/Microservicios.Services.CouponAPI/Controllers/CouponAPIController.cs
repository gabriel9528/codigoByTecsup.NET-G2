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
            catch (Exception ex)
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

            }
            catch (Exception ex)
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

        [HttpPost]
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
                    _response.Message = $"Cupon {coupon.CouponCode} creado con exito";

                }
                else
                {
                    _response.IsSuccess = false;
                    _response.Message = "El cupon ingresado no es valido";
                }

            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = "Ocurrio un error al crear el cupon";
            }

            return _response;
        }

        [HttpPut]
        public ResponseDto Put([FromBody] CouponDto couponDto)
        {
            try
            {
                if (couponDto != null)
                {
                    Coupon coupon = _mapper.Map<Coupon>(couponDto);
                    _db.Coupon.Update(coupon);
                    _db.SaveChanges();

                    _response.Result = _mapper.Map<CouponDto>(coupon);
                    _response.Message = $"Cupon {coupon.CouponCode} actualizado con exito";
                }
                else
                {
                    _response.IsSuccess = false;
                    _response.Message = "El cupon ingresado no es valido";
                }

            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = "Ocurrio un error al actualizar el cupon";
            }

            return _response;
        }

        [HttpDelete]
        [Route("{id:int}")]
        public ResponseDto Delete(int id)
        {
            try
            {
                if (id <= 0)
                {
                    _response.IsSuccess = false;
                    _response.Message = "El id del cupon no es valido";
                }
                else
                {
                    Coupon coupon = _db.Coupon.FirstOrDefault(x => x.CouponId == id);
                    if (coupon != null)
                    {
                        _db.Coupon.Remove(coupon);
                        _db.SaveChanges();

                        _response.Result = _mapper.Map<CouponDto>(coupon);
                        _response.Message = $"Cupon {coupon.CouponCode} eliminado con exito";

                    }
                    else
                    {
                        _response.IsSuccess = false;
                        _response.Message = "EL cupon no existe";
                    }
                }
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = "Ocurrio un error al eliminar el cupon";
            }

            return _response;
        }
    }
}
