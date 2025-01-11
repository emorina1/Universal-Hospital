namespace Universal_Hospital.Models
{
    public class Timetable
    {
        public int TimetableId { get; set; } // Unique identifier for the timetable entry
        public int DoctorId { get; set; } // Foreign key to the doctor assigned to the timetable
        public Doctor Doctor { get; set; } // Navigation property to the assigned doctor
        public DateTime Date { get; set; } // Date for the scheduled appointment or shift
        public TimeSpan StartTime { get; set; } // Start time of the scheduled shift or appointment
        public TimeSpan EndTime { get; set; } // End time of the scheduled shift or appointment
        public string ShiftType { get; set; } // Type of shift (e.g., Morning, Evening, Night)
        public string RoomNumber { get; set; } // Room number where the doctor will be located during the shift or appointment

        // Constructor to initialize the timetable entry
        public Timetable(Doctor doctor, DateTime date, TimeSpan startTime, TimeSpan endTime, string shiftType, string roomNumber)
        {
            Doctor = doctor;
            Date = date;
            StartTime = startTime;
            EndTime = endTime;
            ShiftType = shiftType;
            RoomNumber = roomNumber;
        }

        // Empty constructor for other cases (e.g., Entity Framework)
        public Timetable() { }
    }
}
