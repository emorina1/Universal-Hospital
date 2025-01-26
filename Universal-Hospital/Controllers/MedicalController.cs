using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Universal_Hospital.Data;
using Universal_Hospital.Models;

namespace Universal_Hospital.Controllers
{
    public class MedicalController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MedicalController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Medical
        public async Task<IActionResult> Index()
        {
            return View(await _context.MedicalStaff.ToListAsync());
        }

        // GET: Medical/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var medical = await _context.MedicalStaff
                .FirstOrDefaultAsync(m => m.Id == id);
            if (medical == null)
            {
                return NotFound();
            }

            return View(medical);
        }

        // GET: Medical/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Medical/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,Position,Specialization,EmploymentDate,PhoneNumber,Comments")] Medical medical)
        {
            if (ModelState.IsValid)
            {
                _context.Add(medical);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(medical);
        }

        // GET: Medical/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var medical = await _context.MedicalStaff.FindAsync(id);
            if (medical == null)
            {
                return NotFound();
            }
            return View(medical);
        }

        // POST: Medical/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,Position,Specialization,EmploymentDate,PhoneNumber,Comments")] Medical medical)
        {
            if (id != medical.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(medical);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MedicalExists(medical.Id))
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
            return View(medical);
        }

        // GET: Medical/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var medical = await _context.MedicalStaff
                .FirstOrDefaultAsync(m => m.Id == id);
            if (medical == null)
            {
                return NotFound();
            }

            return View(medical);
        }

        // POST: Medical/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var medical = await _context.MedicalStaff.FindAsync(id);
            if (medical != null)
            {
                _context.MedicalStaff.Remove(medical);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MedicalExists(int id)
        {
            return _context.MedicalStaff.Any(e => e.Id == id);
        }
    }
}
