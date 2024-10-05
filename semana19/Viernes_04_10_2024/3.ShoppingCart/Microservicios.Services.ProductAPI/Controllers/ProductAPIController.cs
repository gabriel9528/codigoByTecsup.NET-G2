using AutoMapper;
using Microservicios.Services.ProductAPI.Data;
using Microservicios.Services.ProductAPI.Models;
using Microservicios.Services.ProductAPI.Models.Dto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Microservicios.Services.ProductAPI.Controllers
{
    [Route("api/product")]
    [ApiController]
    [Authorize(Roles ="Admin")]
    public class ProductAPIController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public ResponseDto _response;
        private readonly IMapper _mapper;

        public ProductAPIController(ApplicationDbContext db, IMapper mapper)
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
                IEnumerable<Product> productList = _db.Products.ToList();
                _response.Result = _mapper.Map<List<ProductDto>>(productList);
                _response.Message = "Productos obtenidos con exito";

            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = "Ocurrio un error al intentar obtener los productos";
            }
            return _response;
        }

        [HttpGet]
        [Route("{id:int}")]
        public ResponseDto GetById(int id)
        {
            try
            {
                Product product = _db.Products.FirstOrDefault(x => x.ProductId == id);
                if (product != null)
                {
                    _response.Result = _mapper.Map<ProductDto>(product);
                    _response.Message = $"Producto {product.Name} obtenido con exito";
                }
                else
                {
                    _response.IsSuccess = false;
                    _response.Message = "Producto no encontrado";
                }

            }
            catch
            {
                _response.IsSuccess = false;
                _response.Message = "Ocurrio un error al intentar obtener el producto";
            }

            return _response;
        }

        [HttpPost]
        public ResponseDto Post([FromBody] ProductDto productDto)
        {
            try
            {
                if (productDto != null)
                {
                    Product product = _mapper.Map<Product>(productDto);
                    _db.Products.Add(product);
                    _db.SaveChanges();

                    _response.Result = _mapper.Map<ProductDto>(product);
                    _response.Message = $"Producto {productDto.Name} creado con exito";

                }
                else
                {
                    _response.IsSuccess = false;
                    _response.Message = "El producto ingresado no es valido";
                }
            }
            catch
            {
                _response.IsSuccess = false;
                _response.Message = "Ocurrio un error al intentar crear el producto";
            }
            return _response;
        }

        [HttpPut]
        public ResponseDto Put([FromBody] ProductDto productDto)
        {
            try
            {
                if (productDto != null)
                {
                    Product product = _mapper.Map<Product>(productDto);
                    _db.Products.Update(product);
                    _db.SaveChanges();

                    _response.Result = _mapper.Map<ProductDto>(product);
                    _response.Message = $"Producto {productDto.Name} actualizado con exito";
                }
                else
                {
                    _response.IsSuccess = false;
                    _response.Message = "El producto ingresado no es valido";
                }

            }
            catch
            {
                _response.IsSuccess = false;
                _response.Message = "Ocurrio un error al intentar actualizar el producto";
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
                    _response.Message = "El id del producto no es valido";
                }
                else
                {
                    Product product = _db.Products.FirstOrDefault(x => x.ProductId == id);
                    if (product != null)
                    {
                        _db.Products.Remove(product);
                        _db.SaveChanges();

                        _response.Result = _mapper.Map<ProductDto>(product);
                        _response.Message = $"Producto {product.Name} eliminado con exito";
                    }
                    else
                    {
                        _response.IsSuccess = false;
                        _response.Message = "Producto no encontrado";
                    }
                }
            }
            catch
            {
                _response.IsSuccess = false;
                _response.Message = "Ocurrio un error al intentar eliminar el producto";
            }

            return _response;
        }
    }
}
