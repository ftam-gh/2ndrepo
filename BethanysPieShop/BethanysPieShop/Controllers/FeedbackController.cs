using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BethanysPieShop.Models;
using BethanysPieShop.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BethanysPieShop.Controllers
{
    public class FeedbackController : Controller
    {
        private readonly IFeedbackRepository _feedback;

        public FeedbackController(IFeedbackRepository feedBack)
        {
            _feedback = feedBack;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Feedback feedback)
        {
            if (ModelState.IsValid)
            {
                _feedback.AddFeedback(feedback);
                return RedirectToAction("FeedbackComplete");

            }
            return View();
        }

        public IActionResult FeedbackComplete()
        {
            return View();
        }
    }
}
