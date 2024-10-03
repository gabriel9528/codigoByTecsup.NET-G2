using Microservicios.Web.Models;

namespace Microservicios.Web.Service.IService
{
    public interface IProductService
    {
        Task<ResponseDto?> GetALLProductAsync();
        Task<ResponseDto?> GetProductByIdAsync(int id);
        Task<ResponseDto?> CreateProductAsync(ProductDto productDto);
        Task<ResponseDto?> UpdateProductAsync(ProductDto productDto);
        Task<ResponseDto?> DeleteProductAsync(int id);
    }
}
