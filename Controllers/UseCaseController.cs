using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjectManagementSoftware.Data;
using ProjectManagementSoftware.Models;

namespace ProjectManagementSoftware.Controllers_
{
    public class UseCaseController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UseCaseController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: UseCase
        public async Task<IActionResult> Index()
        {
            return View(await _context.UseCase.ToListAsync());
        }

        // GET: UseCase/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var useCase = await _context.UseCase
                .SingleOrDefaultAsync(m => m.UseCaseID == id);
            if (useCase == null)
            {
                return NotFound();
            }

            return View(useCase);
        }

        // GET: UseCase/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: UseCase/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UseCaseID,UseCaseDesc,CreatedDate,CreatedByEmpNum,ModifiedDate,ModifiedByEmpNum")] UseCase useCase)
        {
            if (ModelState.IsValid)
            {
                _context.Add(useCase);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(useCase);
        }

        // GET: UseCase/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var useCase = await _context.UseCase.SingleOrDefaultAsync(m => m.UseCaseID == id);
            if (useCase == null)
            {
                return NotFound();
            }
            return View(useCase);
        }

        // POST: UseCase/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("UseCaseID,UseCaseDesc,CreatedDate,CreatedByEmpNum,ModifiedDate,ModifiedByEmpNum")] UseCase useCase)
        {
            if (id != useCase.UseCaseID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(useCase);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UseCaseExists(useCase.UseCaseID))
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
            return View(useCase);
        }

        // GET: UseCase/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var useCase = await _context.UseCase
                .SingleOrDefaultAsync(m => m.UseCaseID == id);
            if (useCase == null)
            {
                return NotFound();
            }

            return View(useCase);
        }

        // POST: UseCase/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var useCase = await _context.UseCase.SingleOrDefaultAsync(m => m.UseCaseID == id);
            _context.UseCase.Remove(useCase);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UseCaseExists(int id)
        {
            return _context.UseCase.Any(e => e.UseCaseID == id);
        }
    }
}
