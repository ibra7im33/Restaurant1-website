﻿using Microsoft.AspNetCore.Mvc;

namespace Restorent.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
