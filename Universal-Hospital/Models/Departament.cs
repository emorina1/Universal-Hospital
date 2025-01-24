using System.ComponentModel.DataAnnotations;

namespace Universal_Hospital.Models
{
    public class Departament
    {
        [Key]
        public int DepartamentId { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [Range(1, 10)] // Përcaktoni një gamë të arsyeshme për katin
        public int Floor { get; set; }
    }
}