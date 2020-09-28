using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspdotNetBakery_Proj2.Controllers
{
    public class customercontroller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
