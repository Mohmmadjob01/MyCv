using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyCv.Data;
using MyCv.Models;

namespace MyCv.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class EducationsController : Controller
    {
        private readonly CvDb _context;

        public EducationsController(CvDb context)
        {
            _context = context;
        }

        // GET: Admin/Educations
        public async Task<IActionResult> Index()
        {
              return _context.Educations != null ? 
                          View(await _context.Educations.ToListAsync()) :
                          Problem("Entity set 'CvDb.Educations'  is null.");
        }

        // GET: Admin/Educations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Educations == null)
            {
                return NotFound();
            }

            var education = await _context.Educations
                .FirstOrDefaultAsync(m => m.EducationId == id);
            if (education == null)
            {
                return NotFound();
            }

            return View(education);
        }

        // GET: Admin/Educations/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Educations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EducationId,EducationDescription")] Education education)
        {
            if (ModelState.IsValid)
            {
                _context.Add(education);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(education);
        }

        // GET: Admin/Educations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Educations == null)
            {
                return NotFound();
            }

            var education = await _context.Educations.FindAsync(id);
            if (education == null)
            {
                return NotFound();
            }
            return View(education);
        }

        // POST: Admin/Educations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EducationId,EducationDescription")] Education education)
        {
            if (id != education.EducationId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(education);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EducationExists(education.EducationId))
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
            return View(education);
        }

        // GET: Admin/Educations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Educations == null)
            {
                return NotFound();
            }

            var education = await _context.Educations
                .FirstOrDefaultAsync(m => m.EducationId == id);
            if (education == null)
            {
                return NotFound();
            }

            return View(education);
        }

        // POST: Admin/Educations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Educations == null)
            {
                return Problem("Entity set 'CvDb.Educations'  is null.");
            }
            var education = await _context.Educations.FindAsync(id);
            if (education != null)
            {
                _context.Educations.Remove(education);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EducationExists(int id)
        {
          return (_context.Educations?.Any(e => e.EducationId == id)).GetValueOrDefault();
        }
    }
}
