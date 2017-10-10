using Microsoft.AspNetCore.Mvc;
using MyBusinessLayer;
using MyBusinessLayer.Models;

namespace CoreDemo.Controllers
{
    [Route("api/[controller]")]
    public class StarshipsController : Controller
    {
        private static SwapiAccess swapiAccess = new SwapiAccess();

        [HttpGet]
        public Starship Get()
        {
            return swapiAccess.GetRandomStarship();
        }
    }
}