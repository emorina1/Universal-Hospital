namespace Universal_Hospital.Models
{
    public class Doctor
    {
        public int DoctorId { get; set; } // Unique identifier for the doctor
        public string FirstName { get; set; } // Doctor's first name
        public string LastName { get; set; } // Doctor's last name
        public string Specialty { get; set; } // The medical specialty of the doctor (e.g., Cardiologist, Surgeon)
        public string PhoneNumber { get; set; } // Contact phone number for the doctor
        public string Email { get; set; } // Email address for the doctor
        public int DepartamentId { get; set; } // Foreign key to the department the doctor belongs to
        public Departament Departament { get; set; } // Navigation property to the associated department

        // Constructor to initialize with a department
        public Doctor(string firstName, string lastName, string specialty, string phoneNumber, string email, Departament departament)
        {
            FirstName = firstName;
            LastName = lastName;
            Specialty = specialty;
            PhoneNumber = phoneNumber;
            Email = email;
            Departament = departament;
        }

        // Empty constructor for other cases (e.g., Entity Framework)
        public Doctor() { }
    }
}
