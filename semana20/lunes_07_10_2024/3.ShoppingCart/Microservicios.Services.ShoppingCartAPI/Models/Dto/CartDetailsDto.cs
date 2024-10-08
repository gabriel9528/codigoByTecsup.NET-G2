using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Microservicios.Services.ShoppingCartAPI.Models.Dto
{
    public class CartDetailsDto
    {
        public int CarDetailsId { get; set; }
        public int CartHeaderId { get; set; }
        public CartHeader? CartHeader { get; set; }
        public int ProductId { get; set; }
        public ProductDto? Product { get; set; }
        public int Count { get; set; }
    }
}
