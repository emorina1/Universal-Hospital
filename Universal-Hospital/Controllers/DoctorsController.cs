using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Universal_Hospital.Data;
using Universal_Hospital.Models;
using System.Threading.Tasks;

namespace Universal_Hospital.Controllers
{
    public class DoctorsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DoctorsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var doctors = _context.Doctor.Include(d => d.Departament);
            return View(await doctors.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
                return NotFound();

            var doctor = await _context.Doctor
                .Include(d => d.Departament)
                .FirstOrDefaultAsync(m => m.DoctorId == id);

            if (doctor == null)
                return NotFound();

            return View(doctor);
        }

        public IActionResult Create()
        {
            ViewData["DepartamentId"] = new SelectList(_context.Departament, "DepartamentId", "Name");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DoctorId,FirstName,LastName,Specialty,PhoneNumber,Email,DepartamentId")] Doctor doctor)
        {
            if (ModelState.IsValid)
            {
                _context.Add(doctor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DepartamentId"] = new SelectList(_context.Departament, "DepartamentId", "Name", doctor.DepartamentId);
            return View(doctor);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
                return NotFound();

            var doctor = await _context.Doctor.FindAsync(id);
            if (doctor == null)
                return NotFound();

            ViewData["DepartamentId"] = new SelectList(_context.Departament, "DepartamentId", "Name", doctor.DepartamentId);
            return View(doctor);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DoctorId,FirstName,LastName,Specialty,PhoneNumber,Email,DepartamentId")] Doctor doctor)
        {
            if (id != doctor.DoctorId)
                return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(doctor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DoctorExists(doctor.DoctorId))
                        return NotFound();

                    throw;
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["DepartamentId"] = new SelectList(_context.Departament, "DepartamentId", "Name", doctor.DepartamentId);
            return View(doctor);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return NotFound();

            var doctor = await _context.Doctor
                .Include(d => d.Departament)
                .FirstOrDefaultAsync(m => m.DoctorId == id);

            if (doctor == null)
                return NotFound();

            return View(doctor);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var doctor = await _context.Doctor.FindAsync(id);
            if (doctor != null)
                _context.Doctor.Remove(doctor);

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DoctorExists(int id)
        {
            return _context.Doctor.Any(e => e.DoctorId == id);
        }
    }
}
