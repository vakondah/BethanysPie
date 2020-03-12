// CSC237
// Aliaksandra Hrechka
// 02/03/2020
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSC237_ahrechka_Bethanys.Models;
using CSC237_ahrechka_Bethanys.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CSC237_ahrechka_Bethanys.Controllers
{
    public class PieController : Controller
    {
        //private fields for pie and mock repositories:
        private readonly IPieRepository _pieRepository;
        private readonly ICategoryRepository _categoryRepository;

        // constructor
        public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
        {
            _pieRepository = pieRepository;
            _categoryRepository = categoryRepository;
        }

        // the action method of the controller:
        public ViewResult List()
        {
            //Using ViewModels: PiesListViewModel instead of ViewBag
            PiesListViewModel piesListViewModel = new PiesListViewModel();
            piesListViewModel.Pies = _pieRepository.AllPies;

            piesListViewModel.CurrentCategory = "Cheese cakes";
            return View(piesListViewModel);
        }

    }
}

