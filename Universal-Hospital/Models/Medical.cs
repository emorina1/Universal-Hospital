using System.ComponentModel.DataAnnotations;

namespace Universal_Hospital.Models
{
    public class Medical
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public string Specialization { get; set; }
        public DateTime EmploymentDate { get; set; }
        public string PhoneNumber { get; set; }
        public string Comments { get; set; }
    }
}
