using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebTeste.Controllers
{
    public class SellersController : Controller
    {
        public IActionResult Index()
        {
            ViewData["NamePage"] = "Sellers";
            return View();
        }
    }
}