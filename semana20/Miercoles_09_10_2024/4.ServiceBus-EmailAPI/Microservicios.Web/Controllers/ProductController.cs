using Microservicios.Web.Models;
using Microservicios.Web.Service.IService;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Microservicios.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> ProductIndex()
        {
            List<ProductDto>? listProducts = new();
            ResponseDto? responseDto = await _productService.GetALLProductAsync();
            if(responseDto != null && responseDto.IsSuccess)
            {
                listProducts = JsonConvert.DeserializeObject<List<ProductDto>>(Convert.ToString(responseDto.Result));
            }
            else
            {
                TempData["error"] = responseDto?.Message;
            }

            return View(listProducts);
        }

        [HttpGet]
        public async Task<IActionResult> ProductCreate()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ProductCreate(ProductDto productDto)
        {
            if (ModelState.IsValid)
            {
                ResponseDto? responseDto = await _productService.CreateProductAsync(productDto);
                if (responseDto != null && responseDto.IsSuccess)
                {
                    TempData["success"] = "Producto creado con exito";
                    return RedirectToAction(nameof(ProductIndex));
                }
                else
                {
                    TempData["error"] = responseDto?.Message;
                }
            }

            return View(productDto);
        }

        [HttpGet]
        public async Task<IActionResult>ProductEdit(int productId)
        {
            ResponseDto? responseDto = await _productService.GetProductByIdAsync(productId);
            if(responseDto != null && responseDto.IsSuccess)
            {
                ProductDto? productDto = JsonConvert.DeserializeObject<ProductDto>(Convert.ToString(responseDto.Result));
                return View(productDto);
            }
            else
            {
                TempData["error"] = responseDto?.Message;
            }

            return NotFound();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ProductEdit(ProductDto productDto)
        {
            if (ModelState.IsValid)
            {
                ResponseDto? responseDto = await _productService.UpdateProductAsync(productDto);
                if (responseDto != null && responseDto.IsSuccess)
                {
                    TempData["success"] = "Producto actualizado con exito";
                    return RedirectToAction(nameof(ProductIndex));
                }
                else
                {
                    TempData["error"] = responseDto?.Message;
                }
            }

            return View(productDto);
        }

        [HttpGet]
        public async Task<IActionResult> ProductDelete(int productId)
        {
            ResponseDto? responseDto = await _productService.GetProductByIdAsync(productId);
            if (responseDto != null && responseDto.IsSuccess)
            {
                ProductDto? productDto = JsonConvert.DeserializeObject<ProductDto>(Convert.ToString(responseDto.Result));
                return View(productDto);
            }
            else
            {
                TempData["error"] = responseDto?.Message;
            }
            return NotFound();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ProductDelete(ProductDto productDto)
        {
            ResponseDto? responseDto = await _productService.DeleteProductAsync(productDto.ProductId);
            if (responseDto != null && responseDto.IsSuccess)
            {
                TempData["success"] = "Producto eliminado con exito";
                return RedirectToAction(nameof(ProductIndex));
            }
            else
            {
                TempData["error"] = responseDto?.Message;
            }

            return View(productDto);
        }


    }
}
