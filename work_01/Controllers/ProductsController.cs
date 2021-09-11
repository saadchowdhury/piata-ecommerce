using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using work_01.Data;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Microsoft.AspNetCore.Authorization;
using work_01.Models;
using work_01.ViewModels;

namespace work_01.Controllers
{
    [Authorize(Roles = "Admin,Product manager")]
    public class ProductsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IHostingEnvironment _hostEnv;

        public ProductsController(ApplicationDbContext context, IHostingEnvironment hostEnvironment )
        {
            _context = context;
            _hostEnv = hostEnvironment;
        }

        // GET: Products
        public async Task<IActionResult> Index()
        {
            return View(await _context.Products.ToListAsync());
        }

        // GET: Products/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: Products/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Unit,Type,Price,Quantity,Image,Description")] ProductView productView)
        {
            string msg = "";
            if (ModelState.IsValid)
            {
                Product p = new Product();
                p.Name = productView.Name;
                p.Unit = productView.Unit;
                p.Type = productView.Type;
                p.Price = productView.Price;
                p.Quantity = productView.Quantity;
                p.Description = productView.Description;

                //Image path
                string webroot = _hostEnv.WebRootPath;
                string folder = "image";
                string imgFileName = Path.GetFileName(productView.Image.FileName);
                string FileWrite = Path.Combine(webroot, folder, imgFileName);

                using(MemoryStream ms = new MemoryStream())
                {
                    await productView.Image.CopyToAsync(ms);
                    p.Image = ms.ToArray();
                    p.ImageFile = "/" + folder + "/" + imgFileName;
                }

                using(var stream = new FileStream(FileWrite, FileMode.Create))
                {
                    await productView.Image.CopyToAsync(stream);
                }

                _context.Add(p);
                await _context.SaveChangesAsync();
                msg = "Product is successfully saved!";
                TempData["msg"] = msg;
                return RedirectToAction(nameof(Index));
            }
            else
            {
                msg = "Product data is Incomplete! Please Try again!";
            }
            TempData["msg"] = msg;
            return RedirectToAction("Create");
        }

        // GET: Products/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var product = await _context.Products.FindAsync(id);
        //    if (product == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(product);
        //}

        // POST: Products/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Unit,Type,Price,Quantity,Image,Description")] Product product)
        {
            if (id != product.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(product);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        // GET: Products/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await _context.Products.FindAsync(id);
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.Id == id);
        }
    }
}
