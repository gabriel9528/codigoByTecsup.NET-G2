﻿using Microservicios.Services.ShoppingCartAPI.Models.Dto;

namespace Microservicios.Services.ShoppingCartAPI.Service.IService
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetProducts();
    }
}
