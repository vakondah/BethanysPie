using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSC237_ahrechka_Bethanys.Models;
using CSC237_ahrechka_Bethanys.ViewModels;
using Microsoft.AspNetCore.Mvc;


namespace CSC237_ahrechka_Bethanys.Controllers
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
            var homeViewModel = new HomeViewModel
            {
                PiesOfTheWeek = _pieRepository.PiesOfTheWeek
            };
            return View(homeViewModel);
        }
    }
}
