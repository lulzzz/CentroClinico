using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CentroClinico.Domain.Entities;
using CentroClinico.Infra.Data.EF;

namespace CentroClinico.UI.MVC.Controllers
{
    public class UnitiesController : Controller
    {
        private readonly EFContext _context;

        public UnitiesController(EFContext context)
        {
            _context = context;
        }

        // GET: Unities
        public async Task<IActionResult> Index()
        {
            return View(await _context.Unities.ToListAsync());
        }

        // GET: Unities/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var unity = await _context.Unities
                .FirstOrDefaultAsync(m => m.ID == id);
            if (unity == null)
            {
                return NotFound();
            }

            return View(unity);
        }

        // GET: Unities/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Unities/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,CEP,HouseNumber,AdditionalInfo,City")] Unity unity)
        {
            if (ModelState.IsValid)
            {
                unity.ID = Guid.NewGuid();
                _context.Add(unity);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(unity);
        }

        // GET: Unities/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var unity = await _context.Unities.FindAsync(id);
            if (unity == null)
            {
                return NotFound();
            }
            return View(unity);
        }

        // POST: Unities/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("ID,CEP,HouseNumber,AdditionalInfo,City")] Unity unity)
        {
            if (id != unity.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(unity);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UnityExists(unity.ID))
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
            return View(unity);
        }

        // GET: Unities/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var unity = await _context.Unities
                .FirstOrDefaultAsync(m => m.ID == id);
            if (unity == null)
            {
                return NotFound();
            }

            return View(unity);
        }

        // POST: Unities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var unity = await _context.Unities.FindAsync(id);
            _context.Unities.Remove(unity);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UnityExists(Guid id)
        {
            return _context.Unities.Any(e => e.ID == id);
        }
    }
}
