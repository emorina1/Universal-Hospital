namespace Universal_Hospital.Models
{
    public class MedicalStaff
    {
        public int MedicalStaffId { get; set; } // Unique identifier for the medical staff member
        public string FirstName { get; set; } // First name of the staff member
        public string LastName { get; set; } // Last name of the staff member
        public string Role { get; set; } // The role of the staff member (e.g., Nurse, Technician)
        public string PhoneNumber { get; set; } // Contact phone number for the staff member
        public string Email { get; set; } // Email address for the staff member
        public int DepartamentId { get; set; } // Foreign key to the department the staff member belongs to
        public Departament Departament { get; set; } // Navigation property to the associated department

        // Constructor to initialize the medical staff with a department
        public MedicalStaff(string firstName, string lastName, string role, string phoneNumber, string email, Departament departament)
        {
            FirstName = firstName;
            LastName = lastName;
            Role = role;
            PhoneNumber = phoneNumber;
            Email = email;
            Departament = departament;
        }

        // Empty constructor for other cases (e.g., Entity Framework)
        public MedicalStaff() { }
    }
}
