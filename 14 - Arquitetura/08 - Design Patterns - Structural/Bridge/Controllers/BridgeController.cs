using AwesomeShopPatterns.API.Core.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AwesomeShopPatterns.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BridgeController : ControllerBase
    {
        [HttpGet("products")]
        public IActionResult GetProducts()
        {
            // Produto medido em quantidade (ex: unidades)
            var quantityUnit = new Quantity { Minimum = 1, Maximum = 10 };
            var productByQuantity = new Product(quantityUnit)
            {
                Title = "Caneta Azul",
                Category = "Papelaria",
                PricePerUnit = 2.50m
            };

            // Produto medido em peso (ex: kg)
            var kgUnit = new Kg { Minimum = 0, Maximum = 5 };
            var productByKg = new Product(kgUnit)
            {
                Title = "Arroz Tipo 1",
                Category = "Alimentos",
                PricePerUnit = 6.90m
            };

            // Calcula preços
            var priceByQuantity = productByQuantity.GetTotalPrice(5); // 5 unidades
            var priceByKg = productByKg.GetTotalPrice(2); // 2 kg

            return Ok(new
            {
                ProductByQuantity = new
                {
                    productByQuantity.Title,
                    Units = 5,
                    TotalPrice = priceByQuantity
                },
                ProductByKg = new
                {
                    productByKg.Title,
                    Units = 2,
                    TotalPrice = priceByKg
                }
            });
        }
    }
}
