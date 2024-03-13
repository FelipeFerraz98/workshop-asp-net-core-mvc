using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Services;

namespace SalesWebMvc.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellerService _selerService;

        public SellersController(SellerService selerService)
        {
            _selerService = selerService;
        }

        public IActionResult Index()
        {
            var list = _selerService.FindAll();
            return View(list);
        }
    }
}
