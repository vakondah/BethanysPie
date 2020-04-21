// CSC237
// Aliaksandra Hrechka
// 04/21/2020
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSC237_ahrechka_Bethanys.Controllers
{
    public class ContactController: Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
