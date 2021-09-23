using System;
using Microsoft.AspNetCore.Mvc;

namespace FoodAPI.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class FoodController: ControllerBase
    {
        private static readonly string[] Foods = new[]
        {
            "Pizza", "Burger", "French Fry", "Pasta", "Cookie", "BBQ Rib", "Smoke Salmon"
        };

    
        [HttpGet]
        public ActionResult Get()
        {
            var rng = new Random();
            
            return Ok(Foods[rng.Next(Foods.Length)]);
        }
    }
}