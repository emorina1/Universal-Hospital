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
    public class MedicalStaffsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MedicalStaffsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: MedicalStaffs
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.MedicalStaff.Include(m => m.Departament);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: MedicalStaffs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var medicalStaff = await _context.MedicalStaff
                .Include(m => m.Departament)
                .FirstOrDefaultAsync(m => m.MedicalStaffId == id);
            if (medicalStaff == null)
            {
                return NotFound();
            }

            return View(medicalStaff);
        }

        // GET: MedicalStaffs/Create
        public IActionResult Create()
        {
            ViewData["DepartamentId"] = new SelectList(_context.Departament, "DepartamentId", "DepartamentId");
            return View();
        }

        // POST: MedicalStaffs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MedicalStaffId,FirstName,LastName,Role,PhoneNumber,Email,DepartamentId")] MedicalStaff medicalStaff)
        {
            if (ModelState.IsValid)
            {
                _context.Add(medicalStaff);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DepartamentId"] = new SelectList(_context.Departament, "DepartamentId", "DepartamentId", medicalStaff.DepartamentId);
            return View(medicalStaff);
        }

        // GET: MedicalStaffs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var medicalStaff = await _context.MedicalStaff.FindAsync(id);
            if (medicalStaff == null)
            {
                return NotFound();
            }
            ViewData["DepartamentId"] = new SelectList(_context.Departament, "DepartamentId", "DepartamentId", medicalStaff.DepartamentId);
            return View(medicalStaff);
        }

        // POST: MedicalStaffs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MedicalStaffId,FirstName,LastName,Role,PhoneNumber,Email,DepartamentId")] MedicalStaff medicalStaff)
        {
            if (id != medicalStaff.MedicalStaffId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(medicalStaff);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MedicalStaffExists(medicalStaff.MedicalStaffId))
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
            ViewData["DepartamentId"] = new SelectList(_context.Departament, "DepartamentId", "DepartamentId", medicalStaff.DepartamentId);
            return View(medicalStaff);
        }

        // GET: MedicalStaffs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var medicalStaff = await _context.MedicalStaff
                .Include(m => m.Departament)
                .FirstOrDefaultAsync(m => m.MedicalStaffId == id);
            if (medicalStaff == null)
            {
                return NotFound();
            }

            return View(medicalStaff);
        }

        // POST: MedicalStaffs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var medicalStaff = await _context.MedicalStaff.FindAsync(id);
            if (medicalStaff != null)
            {
                _context.MedicalStaff.Remove(medicalStaff);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MedicalStaffExists(int id)
        {
            return _context.MedicalStaff.Any(e => e.MedicalStaffId == id);
        }
    }
}
