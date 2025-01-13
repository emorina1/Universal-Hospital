using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Universal_Hospital.Data;

namespace Universal_Hospital.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        // Constructor dhe veprime specifike për këtë kontrollues mund të shtohen këtu.
    }
}

namespace Universal_Hospital.Controllers
{
    public class UserController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UserController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            // Merr të gjithë përdoruesit
            var users = await _context.Users.ToListAsync();

            return View(users); // Sigurohu që ekziston View 'Index' në folderin 'Views/User'
        }
    }
}
