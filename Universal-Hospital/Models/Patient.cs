namespace Universal_Hospital.Models
{
    public class Patient
    {
        public int PatientId { get; set; } // Unique identifier for the patient
        public string FirstName { get; set; } // Patient's first name
        public string LastName { get; set; } // Patient's last name
        public string Gender { get; set; } // Gender of the patient (e.g., Male, Female, Other)
        public DateTime DateOfBirth { get; set; } // Date of birth of the patient
        public string PhoneNumber { get; set; } // Contact phone number for the patient
        public string Email { get; set; } // Email address for the patient
        public string Address { get; set; } // Address of the patient
        public string MedicalHistory { get; set; } // Patient's medical history
        public int DoctorId { get; set; } // Foreign key to the doctor assigned to the patient
        public Doctor Doctor { get; set; } // Navigation property to the associated doctor

        // Constructor to initialize a patient with essential details
        public Patient(string firstName, string lastName, string gender, DateTime dateOfBirth, string phoneNumber, string email, string address, string medicalHistory, Doctor doctor)
        {
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            DateOfBirth = dateOfBirth;
            PhoneNumber = phoneNumber;
            Email = email;
            Address = address;
            MedicalHistory = medicalHistory;
            Doctor = doctor;
        }

        // Empty constructor for other cases (e.g., Entity Framework)
        public Patient() { }
    }
}
