using System;
using Microsoft.AspNetCore.Mvc;

namespace DrinkAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DrinkController: ControllerBase
    {
        private static readonly string[] Drinks = new[]
        {
            "Beer", "Coke", "Soda", "Wine", "Red Wine", "Cooktail"
        };

    
        [HttpGet]
        public ActionResult Get()
        {
            var rng = new Random();
            
            return Ok(Drinks[rng.Next(Drinks.Length)]);
        }
    }
}