using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;
using SalesWebMvc.Services;
using SalesWebMvc.Models.ViewModels;

namespace SalesWebMvc.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellerService _selerService;
        private readonly DepartmentService _departmentService;

        public SellersController(SellerService selerService, DepartmentService departmentService)

        {
            _selerService = selerService;
            _departmentService = departmentService;
        }

        public IActionResult Index()
        {
            var list = _selerService.FindAll();
            return View(list);
        }

        public IActionResult Create()
        {
            var departments = _departmentService.FindAll();
            var viewModel = new SellerFormViewModel { Departments = departments };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Seller seller)
        {
            _selerService.Insert(seller);
            return RedirectToAction(nameof(Index));
        }
    }
}
