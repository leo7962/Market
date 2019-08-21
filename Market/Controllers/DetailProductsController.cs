using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Market.Models;

namespace Market.Controllers
{
    public class DetailProductsController : Controller
    {
        private readonly MarketContext _context;

        public DetailProductsController(MarketContext context)
        {
            _context = context;
        }

        // GET: DetailProducts
        public async Task<IActionResult> Index()
        {
            return View(await _context.DetailProduct.ToListAsync());
        }

        // GET: DetailProducts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var detailProduct = await _context.DetailProduct
                .FirstOrDefaultAsync(m => m.Id == id);
            if (detailProduct == null)
            {
                return NotFound();
            }

            return View(detailProduct);
        }

        // GET: DetailProducts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DetailProducts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,MyProperty")] DetailProduct detailProduct)
        {
            if (ModelState.IsValid)
            {
                _context.Add(detailProduct);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(detailProduct);
        }

        // GET: DetailProducts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var detailProduct = await _context.DetailProduct.FindAsync(id);
            if (detailProduct == null)
            {
                return NotFound();
            }
            return View(detailProduct);
        }

        // POST: DetailProducts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,MyProperty")] DetailProduct detailProduct)
        {
            if (id != detailProduct.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(detailProduct);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DetailProductExists(detailProduct.Id))
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
            return View(detailProduct);
        }

        // GET: DetailProducts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var detailProduct = await _context.DetailProduct
                .FirstOrDefaultAsync(m => m.Id == id);
            if (detailProduct == null)
            {
                return NotFound();
            }

            return View(detailProduct);
        }

        // POST: DetailProducts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var detailProduct = await _context.DetailProduct.FindAsync(id);
            _context.DetailProduct.Remove(detailProduct);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DetailProductExists(int id)
        {
            return _context.DetailProduct.Any(e => e.Id == id);
        }
    }
}
