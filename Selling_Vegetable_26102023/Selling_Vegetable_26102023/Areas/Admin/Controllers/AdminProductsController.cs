using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PagedList.Core;
using Selling_Vegetable_26102023.Helper;
using Selling_Vegetable_26102023.Models;

namespace Selling_Vegetable_26102023.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminProductsController : Controller
    {
        private readonly SellingVegetableContext _context;
        public AdminProductsController(SellingVegetableContext context)
        {
            _context = context;
        }

        // GET: Admin/AdminProducts
        public IActionResult Index(int CategoryId = 0)
        {
            var pageNumber = int.TryParse(Request.Query["page"], out int page) ? page : 1;
            CategoryId = int.TryParse(Request.Query["CategoryId"], out int catId) ? catId : 0;
            var pageSize = 10;
            List<Product> IsProducts = new List<Product>();
            if (CategoryId != 0)
            {
                IsProducts = _context.Products
                    .AsNoTracking()
                    .Where(p => p.CategoryId == CategoryId)
                    .Include(x => x.Category)
                    .OrderByDescending(x => x.ProductId) // Sắp xếp theo giảm dần
                    .ToList();
            }
            else
            {
                IsProducts = _context.Products
                    .AsNoTracking()
                    .Include(x => x.Category)
                    .OrderByDescending(x => x.ProductId) // Sắp xếp theo giảm dần
                    .ToList();
            }

            PagedList<Product> models = new PagedList<Product>(IsProducts.AsQueryable(), pageNumber, pageSize);

            ViewBag.CurrentCategoryId = CategoryId;
            ViewBag.CurrentPage = pageNumber;
            ViewData["Category"] = new SelectList(_context.Categories, "CategoryId", "CategoryName", CategoryId);
            return View(models);
        }

        //Admin/AdminProducts/Filter
        [ActionName("Filter")]
        [HttpGet]
        public IActionResult Filter(int CategoryId = 0)
        {
            var url = $"/Admin/AdminProducts?CategoryId={CategoryId}";
            if (CategoryId == 0)
            {
                url = $"/Admin/AdminProducts";
            }
            return Json(new { status = "success", redirectUrl = url });
        }

        // GET: Admin/AdminProducts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .Include(p => p.Category)
                .FirstOrDefaultAsync(m => m.ProductId == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: Admin/AdminProducts/Create
        public IActionResult Create()
        {
            ViewData["Category"] = new SelectList(_context.Categories, "CategoryId", "CategoryName");
            ViewData["Brand"] = new SelectList(_context.Brands, "BrandId", "BrandName");
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProductId,ProductName,Title,Description,Price,Image,Video,CategoryId,BrandId,StockQuantity,CreatedAt,DeletedAt,Active")]
        Product product,IFormFile fileThumb)
        {
            if (ModelState.IsValid)
            {
                if (fileThumb != null && fileThumb.Length > 0)
                {
                            product.ProductName = Utilities.ToTitleCase(product.ProductName);
                            string extension = Path.GetExtension(fileThumb.FileName);
                            string image = Utilities.SEOUrl(product.ProductName) + extension;
                            product.Image = await Utilities.UploadFile(fileThumb, "ImageProducts", image.ToLower());
                }

                if (string.IsNullOrEmpty(product.Image))
                {
                    product.Image = "default.jpg";
                }
                product.CreatedAt = DateTime.Now;

                _context.Add(product);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }

            ViewData["Category"] = new SelectList(_context.Categories, "CategoryId", "CategoryName", product.CategoryId);

            return View(product);
        }


        // GET: Admin/AdminProducts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            ViewData["Category"] = new SelectList(_context.Categories, "CategoryId", "CategoryName", product.CategoryId);
            return View(product);
        }

        // POST: Admin/AdminProducts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProductId,ProductName,Title,Description,Price,Image,Video," +
            "CategoryId,BrandId,StockQuantity,CreatedAt,DeletedAt,Active")]Product product, Microsoft.AspNetCore.
            Http.IFormFile fileThumb)
        {
            if (id != product.ProductId)
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
                    if (!ProductExists(product.ProductId))
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
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "CategoryName", product.CategoryId);
            return View(product);
        }

        // GET: Admin/AdminProducts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .Include(p => p.Category)
                .FirstOrDefaultAsync(m => m.ProductId == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Admin/AdminProducts/Delete/5
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
            return _context.Products.Any(e => e.ProductId == id);
        }
    }
}
