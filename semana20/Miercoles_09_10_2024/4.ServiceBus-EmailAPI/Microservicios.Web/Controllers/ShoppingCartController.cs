﻿using Microservicios.Web.Models;
using Microservicios.Web.Service.IService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace Microservicios.Web.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IShoppingCartService _shoppingCartService;

        public ShoppingCartController(IShoppingCartService shoppingCartService)
        {
            _shoppingCartService = shoppingCartService;
        }

        [Authorize]
        public async Task<IActionResult> ShoppingCartIndex()
        {
            var item = await LoadCartDtoBasedOnLoggedUserId();
            return View(item);
        }

        [Authorize]
        public async Task<IActionResult> RemoveProduct(int cartDetailsId)
        {
            var userId = User.Claims.Where(x => x.Type == JwtRegisteredClaimNames.Sub)?.FirstOrDefault()?.Value;
            ResponseDto responseDto = await _shoppingCartService.RemoveFromCartAsync(cartDetailsId);
            if (responseDto != null && responseDto.IsSuccess)
            {
                TempData["success"] = "Producto eliminado del carrito correctamente";
                return RedirectToAction(nameof(ShoppingCartIndex));
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ApplyCoupon(CartDto cartDto)
        {
            ResponseDto responseDto = await _shoppingCartService.ApplyCouponAsync(cartDto);
            if(responseDto != null && responseDto.IsSuccess)
            {
                TempData["success"] = "Cupon aplicado correctamente";
                return RedirectToAction(nameof(ShoppingCartIndex));
            }
            TempData["error"] = responseDto.Message;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> RemoveCoupon(CartDto cartDto)
        {
            cartDto.CartHeaderDto.CouponCode = "";
            ResponseDto responseDto = await _shoppingCartService.ApplyCouponAsync(cartDto);
            if (responseDto != null && responseDto.IsSuccess)
            {
                TempData["success"] = "Cupon eliminado correctamente";
                return RedirectToAction(nameof(ShoppingCartIndex));
            }
            TempData["error"] = responseDto.Message;
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

        private async Task<CartDto> LoadCartDtoBasedOnLoggedUserId()
        {
            var userId = User.Claims.Where(x => x.Type == JwtRegisteredClaimNames.Sub)?.FirstOrDefault()?.Value;
            ResponseDto responseDto = await _shoppingCartService.GetCartByUserIdAsync(userId);
            if(responseDto != null && responseDto.IsSuccess)
            {
                CartDto cartDto = JsonConvert.DeserializeObject<CartDto>(Convert.ToString(responseDto.Result));
                return cartDto;
            }
            return new CartDto();
        }
    }
}