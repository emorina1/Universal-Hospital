namespace Universal_Hospital.Models
{
    public class Nurse
    {
        public int NurseId { get; set; } // Unique identifier for the nurse
        public string FirstName { get; set; } // Nurse's first name
        public string LastName { get; set; } // Nurse's last name
        public string PhoneNumber { get; set; } // Contact phone number for the nurse
        public string Email { get; set; } // Email address for the nurse
        public string Shift { get; set; } // Shift assigned to the nurse (e.g., Morning, Evening, Night)
        public int DepartamentId { get; set; } // Foreign key to the department the nurse belongs to
        public Departament Departament { get; set; } // Navigation property to the associated department

        // Constructor to initialize the nurse with all necessary details
        public Nurse(string firstName, string lastName, string phoneNumber, string email, string shift, Departament departament)
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Email = email;
            Shift = shift;
            Departament = departament;
        }

        // Empty constructor for other cases (e.g., Entity Framework)
        public Nurse() { }
    }
}
