using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Universal_Hospital.Data;
using Microsoft.AspNetCore.Identity;


namespace Universal_Hospital.Controllers
{
    //[Authorize] // Siguron që vetëm përdoruesit e autentikuar mund të hyjnë.
    public class UserController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UserController(ApplicationDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<IActionResult> Index()
        {
            try
            {
                // Merr të gjithë përdoruesit nga baza e të dhënave.
                var users = await _context.Users.ToListAsync();
                return View(users); // Sigurohu që ekziston një View 'Index' në 'Views/User/Index.cshtml'.
            }
            catch (Exception ex)
            {
                // Trajto gabimin dhe dërgo një faqe error.
                // Shto një pamje error në 'Views/Shared/Error.cshtml'.
                return View("Error", new { message = ex.Message });
            }
        }
    }
}
