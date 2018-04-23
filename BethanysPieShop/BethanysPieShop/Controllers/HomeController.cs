using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BethanysPieShop.Services;
using BethanysPieShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BethanysPieShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPieRepository _pieRepository;

        public HomeController(IPieRepository pieRepository)
        {
            _pieRepository = pieRepository;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            //ViewBag.Title = "Pie Overview";
            var model = new HomeViewModel();
            model.Pies = _pieRepository.GetAllPie();
            model.Title = "Welcome to Bethany's Pie Shop";
            return View(model);
        }

        public IActionResult Detail(int id)
        {
            var model = _pieRepository.GetPieById(id);
            if (model == null)
                return NotFound();
            return View(model);
        }
    }
}
