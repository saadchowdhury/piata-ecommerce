using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using work_01.Data;
using work_01.Models;

namespace work_01.Controllers
{
    public class ShoppingController : Controller
    {
        private readonly IHttpContextAccessor _httpContext;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext dbContext;
        public ShoppingController(ApplicationDbContext context, UserManager<ApplicationUser> userManager, IHttpContextAccessor httpContext)
        {
            dbContext = context;
            this._userManager = userManager;
            this._httpContext = httpContext;
        }
        public async Task<IActionResult> Index(string usertext, int page)
        {
            ViewBag.sword = usertext;
            IQueryable<Product> pro = dbContext.Products;
            if (!string.IsNullOrEmpty(usertext))
            {
                usertext = usertext.ToLower();
                pro = pro.Where(p => p.Name.ToLower().Contains(usertext) || p.Type.ToLower().Contains(usertext));
            }
            ViewBag.count = pro.Count();
            if (page <= 0) page = 1;
            int pageSize = 4;
            ViewBag.psize = pageSize;


            return View(await PaginatedList<Product>.CreateAsync(pro, page, pageSize));
        }
        //public async Task<IActionResult> Index(string usertext, int page)
        //{
        //    ViewBag.sword = usertext;
        //    IQueryable<Product> pro = dbContext.Products;
        //    if (!string.IsNullOrEmpty(usertext))
        //    {
        //        usertext = usertext.ToLower();
        //        pro = pro.Where(p => p.Name.ToLower().Contains(usertext) || p.Type.ToLower().Contains(usertext));
        //    }
        //    ViewBag.count = pro.Count();
        //    if (page <= 0) page = 1;
        //    int pageSize = 4;
        //    ViewBag.psize = pageSize;


        //    return View(await PaginatedList<Product>.CreateAsync(pro, page, pageSize));
        //}
        //public async Task<IActionResult> Index(string usertext, string sortOrder, int page)
        //{
        //    ViewBag.sword = usertext;

        //    ViewBag.sortparam = string.IsNullOrEmpty(sortOrder) ? "desc_name" : "";
        //    ViewBag.sortsalary = sortOrder == "sal_asc" ? "sal_desc" : "sal_asc";

        //    IQueryable<Product> emp = dbContext.Products;
        //    if (!string.IsNullOrEmpty(usertext))
        //    {
        //        usertext = usertext.ToLower();
        //        emp = emp.Where(e => e.Name.ToLower().Contains(usertext) || e.Description.ToLower().Contains(usertext));
        //    }
        //    switch (sortOrder)
        //        case "desc_name":
        //    {
        //            emp = emp.OrderByDescending(e => e.Name);
        //            break;
        //        case "sal_asc":
        //            emp = emp.OrderBy(e => e.Description);
        //            break;
        //        case "sal_desc":
        //            emp = emp.OrderByDescending(e => e.Name);
        //            break;
        //        default:
        //            emp = emp.OrderBy(e => e.Name);
        //            break;
        //    }
        //    ViewBag.count = emp.Count();
        //    if (page <= 0) page = 1;
        //    int pageSize = 10;
        //    ViewBag.psize = pageSize;

        //    return View(await PaginatedList<Product>.CreateAsync(emp, page, pageSize));
        //}


        public IActionResult ShowCart()
        {
            List<Product> items = new List<Product>();
            var xitems = HttpContext.Session.GetObject<List<Product>>("myCart");
            if (xitems != null)
            {
                return View(xitems);
            }
            else
            {
                return View();
            }
        }
        public async Task<IActionResult> DetailsProduct(int? pid)
        {
            if (pid == null)
            {
                return NotFound();
            }

            var product = await dbContext.Products
                .FirstOrDefaultAsync(m => m.Id == pid);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }
        //this is for check out purpose

        //public IActionResult CheckOut()
        //{
        //    var us = HttpContext.Session.GetString("un");
        //    var id = HttpContext.Session.GetString("id");

        //    if (us != null)
        //    {
        //        return View();
        //    }
        //    else
        //    {
        //        return RedirectToAction("Login");
        //        return RedirectToAction("LogIn", "Account", new { area = "" });
        //        return RedirectToAction("Login", "Account");
        //    }
        //}
        [Authorize]
        public IActionResult CheckOut()
        {
            HttpContext.Session.Clear();
            return View();
        }



        //this part of code is written for removing a product from cart

        public IActionResult RemoveFromCart(int id)
        {
            if (id > 0)
            {
                List<Product> items = new List<Product>();
                var cartitem = HttpContext.Session.GetObject<List<Product>>("myCart");
                if (cartitem != null)
                {
                    var remitem = cartitem.FirstOrDefault(p => p.Id == id);
                    if (remitem != null)
                    {
                        cartitem.Remove(remitem);
                    }
                    HttpContext.Session.SetObject("myCart", cartitem);
                    return RedirectToAction("showcart");
                }
            }
            return RedirectToAction("Index");
        }

        //--------till here!!-------

        public IActionResult AddToCart(int pid, double qty)
        {
            bool itemFound = false;
            string msg = "";

            if (pid > 0 && qty > 0)
            {
                var prod = dbContext.Products.FirstOrDefault(p => p.Id == pid);
                if (prod != null)
                {
                    List<Product> items = new List<Product>();
                    var xitems = HttpContext.Session.GetObject<List<Product>>("myCart");
                    if (xitems != null)
                    {
                        foreach (var item in xitems)
                        {
                            if (pid == item.Id)
                            {
                                item.Quantity += qty;
                                itemFound = true;
                                msg = "New Quantity added with the existing item";
                            }
                            items.Add(item);
                        }
                        if (!itemFound)
                        {
                            prod.Quantity = qty;
                            items.Add(prod);
                            msg = "New item added with existing items";
                        }
                        HttpContext.Session.SetObject("myCart", items);
                    }
                    else
                    {
                        prod.Quantity = qty;
                        items.Add(prod);
                        HttpContext.Session.SetObject("myCart", items);
                        msg = "New item is added to the empty cart";
                    }
                }
                else
                {
                    msg = "Item is not found!";
                }
            }
            else
            {
                msg = "Please add an Item First";
            }

            TempData["msg"] = msg;
            return RedirectToAction("Index");
        }

    }


}