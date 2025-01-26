using System.ComponentModel.DataAnnotations;

namespace Universal_Hospital.Models
{
    public class Doctor
    {
        [Key]
        public int IdD { get; set; } // Identifikues unikal

        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;

        public string Position { get; set; } = string.Empty; // P.sh. Kirurg, Pediatër, etj.
        public string Specialization { get; set; } = string.Empty;

       

       
    }
}
