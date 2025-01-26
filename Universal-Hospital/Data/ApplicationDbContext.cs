using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Universal_Hospital.Models;

namespace Universal_Hospital.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Universal_Hospital.Models.Doctor> Doctor { get; set; } = default!;

        public DbSet<Universal_Hospital.Models.Nurse> Nurse { get; set; } = default!;
        public DbSet<Universal_Hospital.Models.Departament> Departament { get; set; } = default!;
        public DbSet<Universal_Hospital.Models.Medical> MedicalStaff { get; set; } = default!;


       
    }
}
