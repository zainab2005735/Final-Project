
namespace DormitoryManagementSystem.Models
{
    public class Allocation
    {
        public int Id { get; set; }

        public int ResidentId { get; set; }

        public Resident? Resident { get; set; }

        public int RoomId { get; set; }

        public Room? Room { get; set; }

        public DateTime CheckInDate { get; set; }

        public DateTime? CheckOutDate { get; set; }

        public string Status { get; set; } = "Active";
    }
}
