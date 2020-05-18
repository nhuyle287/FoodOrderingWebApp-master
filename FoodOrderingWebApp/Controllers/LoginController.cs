using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodOrderingWebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FoodOrderingWebApp.Controllers
{
    public class LoginController : Controller
    {
       /*private readonly FoodOrderingWebAppDbContext context;

        public LoginController(FoodOrderingWebAppDbContext context)
        {
            this.context = context;
        }
        */
        public IActionResult Index()
        {
            return View();
        }

    }
}