using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Selling_Vegetable_26102023.Models;
using System.Collections.Generic;
using System.Linq;

namespace Selling_Vegetable_26102023.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SearchController : Controller
    {
        private readonly SellingVegetableContext _context;
        public SearchController(SellingVegetableContext context)
        {
            _context = context;
        }
        [HttpPost]
        [ActionName("FindProduct")]
        public IActionResult FindProduct(string keyword)
        {
            List<Product> ls = new List<Product>();
            if (string.IsNullOrEmpty(keyword) || keyword.Length < 1)
            {
                return PartialView("ListProductSearchPartial", null);
            }
            ls = _context.Products
                .AsNoTracking()
                .Include(p => p.Category)
                .Where(p => p.ProductName.Contains(keyword))
                .OrderByDescending(x => x.ProductName)
                .Take(10).ToList();

            return PartialView("ListProductSearchPartial", ls != null ? ls : null);
        }

    }
}