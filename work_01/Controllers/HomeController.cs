using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using work_01.Models;
using work_01.Data;

namespace work_01.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Aboutus()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Login()
        {
            return View();
        }

        //public async Task<IActionResult> Login(Login Login)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var result = await SignInManager.PasswordSignInAsync(Login.email, Login.Password, false, false);
        //        if (result.succeeded)
        //        {
        //            return RedirectToAction("Index");
        //        }
        //        ModelState.AddModelError("", "Invalid username or password");
        //    }
        //    return View(login);
        //}

    }
}
