using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PagedList.Core;
using Selling_Vegetable_26102023.Models;
using System.Collections.Generic;
using System.Linq;

namespace Selling_Vegetable_26102023.Controllers
{
	public class ShopController : Controller
	{
        private readonly SellingVegetableContext _context;
        public ShopController(SellingVegetableContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var pageNumber = int.TryParse(Request.Query["page"], out int page) ? page : 1;
            var pageSize = 10;
            List<Product> products = _context.Products.ToList();
            PagedList<Product> models = new PagedList<Product>(products.AsQueryable(), pageNumber, pageSize);
            ViewBag.CurrentPage = pageNumber;
            return View(models);
        }
        public IActionResult Details(int id) 
        {
            try
            {
                var product = _context.Products.FirstOrDefault(p => p.ProductId == id);
                if (product == null)
                {
                    return RedirectToAction("Index");
                }
                var lsProduct = _context.Products.AsNoTracking()
                    .Where(p => p.ProductId != id && p.Active == true)
                    .OrderByDescending(p => p.CreatedAt)
                    .Take(10).ToList();
                ViewBag.Products = lsProduct;
                return View(product);
            }
            catch
            {
                return RedirectToAction("Index", "Home");
            }
        }
    }
}
