using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CuaHangHung.Models;

namespace CuaHangHung.Controllers
{
    public class KhoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public KhoController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Kho
        public async Task<IActionResult> Index()
        {
              return _context.Kho != null ? 
                          View(await _context.Kho.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Kho'  is null.");
        }

        // GET: Kho/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.Kho == null)
            {
                return NotFound();
            }

            var kho = await _context.Kho
                .FirstOrDefaultAsync(m => m.KhoID == id);
            if (kho == null)
            {
                return NotFound();
            }

            return View(kho);
        }

        // GET: Kho/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Kho/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("KhoID,SanPhamName,NumberbKho,KhoStoreExists,InventoryKho,ExportKho")] Kho kho)
        {
            if (ModelState.IsValid)
            {
                _context.Add(kho);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(kho);
        }

        // GET: Kho/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.Kho == null)
            {
                return NotFound();
            }

            var kho = await _context.Kho.FindAsync(id);
            if (kho == null)
            {
                return NotFound();
            }
            return View(kho);
        }

        // POST: Kho/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("KhoID,SanPhamName,NumberbKho,KhoStoreExists,InventoryKho,ExportKho")] Kho kho)
        {
            if (id != kho.KhoID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(kho);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KhoExists(kho.KhoID))
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
            return View(kho);
        }

        // GET: Kho/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.Kho == null)
            {
                return NotFound();
            }

            var kho = await _context.Kho
                .FirstOrDefaultAsync(m => m.KhoID == id);
            if (kho == null)
            {
                return NotFound();
            }

            return View(kho);
        }

        // POST: Kho/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.Kho == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Kho'  is null.");
            }
            var kho = await _context.Kho.FindAsync(id);
            if (kho != null)
            {
                _context.Kho.Remove(kho);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KhoExists(string id)
        {
          return (_context.Kho?.Any(e => e.KhoID == id)).GetValueOrDefault();
        }
    }
}
