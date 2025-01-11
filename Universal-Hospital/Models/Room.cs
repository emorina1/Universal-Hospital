namespace Universal_Hospital.Models
{
    public class Room
    {
        public int RoomId { get; set; } // Unique identifier for the room
        public string RoomNumber { get; set; } // Room number or name (e.g., 101, 202A)
        public string RoomType { get; set; } // Type of room (e.g., ICU, General, Private)
        public bool IsAvailable { get; set; } // Whether the room is available for patients
        public int DepartamentId { get; set; } // Foreign key to the department the room belongs to
        public Departament Departament { get; set; } // Navigation property to the associated department

        // Constructor to initialize the room with all necessary details
        public Room(string roomNumber, string roomType, bool isAvailable, Departament departament)
        {
            RoomNumber = roomNumber;
            RoomType = roomType;
            IsAvailable = isAvailable;
            Departament = departament;
        }

        // Empty constructor for other cases (e.g., Entity Framework)
        public Room() { }
    }
}
