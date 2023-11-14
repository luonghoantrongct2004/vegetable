using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Selling_Vegetable_26102023.Models;

namespace Selling_Vegetable_26102023.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminAccountsController : Controller
    {
        private readonly SellingVegetableContext _context;
        public INotyfService _notyfService { get; }

        public AdminAccountsController(SellingVegetableContext context, INotyfService notyfService)
        {
            _context = context;
            _notyfService = notyfService;
        }

        // GET: Admin/AdminAccounts
        public async Task<IActionResult> Index()
        {
            return View(await _context.AdminAccounts.ToListAsync());
        }

        // GET: Admin/AdminAccounts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var adminAccount = await _context.AdminAccounts
                .FirstOrDefaultAsync(m => m.AdminId == id);
            if (adminAccount == null)
            {
                return NotFound();
            }

            return View(adminAccount);
        }

        // GET: Admin/AdminAccounts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/AdminAccounts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AdminId,Username,Password,FullName,Email,Phone,LastLogin,CreatedAt,DeletedAt")] AdminAccount adminAccount)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Add(adminAccount);
                    await _context.SaveChangesAsync();
                    _notyfService.Success("Create admin account " + adminAccount.Username + " successful.");
                }
                catch(DbUpdateConcurrencyException)
                {
                    if(AdminAccountExists(adminAccount.AdminId))
                    {
                        _notyfService.Success("Was error occur.");
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(adminAccount);
        }

        // GET: Admin/AdminAccounts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var adminAccount = await _context.AdminAccounts.FindAsync(id);

            if (adminAccount == null)
            {
                return NotFound();
            }
            return View(adminAccount);
        }

        // POST: Admin/AdminAccounts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AdminId,Username,Password,FullName,Email,Phone,LastLogin,CreatedAt,DeletedAt")] AdminAccount adminAccount)
        {
            if (id != adminAccount.AdminId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(adminAccount);
                    await _context.SaveChangesAsync();
                    _notyfService.Success("Update admin account " + adminAccount.Username + " successful.");
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AdminAccountExists(adminAccount.AdminId))
                    {
                        _notyfService.Success("Was error occur.");
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(adminAccount);
        }

        // GET: Admin/AdminAccounts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var adminAccount = await _context.AdminAccounts
                .FirstOrDefaultAsync(m => m.AdminId == id);
            if (adminAccount == null)
            {
                return NotFound();
            }

            return View(adminAccount);
        }

        // POST: Admin/AdminAccounts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var adminAccount = await _context.AdminAccounts.FindAsync(id);
            _context.AdminAccounts.Remove(adminAccount);
            await _context.SaveChangesAsync();
            _notyfService.Success("Delete admin account " + adminAccount.Username + " successful.");
            return RedirectToAction(nameof(Index));
        }

        private bool AdminAccountExists(int id)
        {
            return _context.AdminAccounts.Any(e => e.AdminId == id);
        }
    }
}
