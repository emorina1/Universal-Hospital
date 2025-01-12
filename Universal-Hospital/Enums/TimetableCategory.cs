using System;
using System.ComponentModel.DataAnnotations;

namespace Universal_Hospital.Models
{
    // Enum për llojet e ndryshme të orarit
    public enum ShiftType
    {
        Morning,  // Orari i mëngjesit
        Evening,  // Orari i mbrëmjes
        Night     // Orari i natës
    }

    // Klasë për regjistrin e orarit
    public class TimetableCategory
    {
        [Key] // Përcakto TimetableId si çelësin kryesor
        public int TimetableId { get; set; } // Identifikuesi unik për regjistrin e orarit

        public int DoctorId { get; set; } // Çelësi i huaj për mjekun e caktuar në orar
        public Doctor Doctor { get; set; } // Pronë navigimi për mjekun e caktuar

        public DateTime Date { get; set; } // Data për takimin e caktuar ose orarin e punës
        public TimeSpan StartTime { get; set; } // Koha e fillimit për orarin e caktuar
        public TimeSpan EndTime { get; set; } // Koha e përfundimit për orarin e caktuar
        public string RoomNumber { get; set; } // Numri i dhomës ku mjeku do të jetë gjatë orarit të punës

        public ShiftType Shift { get; set; } // Kategoria e orarit (Morning, Evening, Night)

        // Konstruktor për të inicializuar regjistrin e orarit
        public TimetableCategory(Doctor doctor, DateTime date, TimeSpan startTime, TimeSpan endTime, string roomNumber, ShiftType shift)
        {
            Doctor = doctor;
            Date = date;
            StartTime = startTime;
            EndTime = endTime;
            RoomNumber = roomNumber;
            Shift = shift;
        }

        // Konstruktor i zbrazët për raste të tjera (p.sh., Entity Framework)
        public TimetableCategory() { }
    }
}
