
namespace DormitoryManagementSystem.Models
{
    public class MaintenanceRequest
    {
        public int Id { get; set; }

        public int RoomId { get; set; }

        public Room? Room { get; set; }

        public string ResidentName { get; set; } = "";

        public string Category { get; set; } = "";

        public string Description { get; set; } = "";

        public string Priority { get; set; } = "Medium";

        public string Status { get; set; } = "Pending";

        public DateTime CreatedDate { get; set; } = DateTime.Today;
    }
}
