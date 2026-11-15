
using System.ComponentModel.DataAnnotations;

namespace DormitoryManagementSystem.Models
{
    public class Resident
    {
        public int Id { get; set; }

        [Required]
        public string FullName { get; set; } = "";

        [Required]
        public string StudentId { get; set; } = "";

        public int? RoomId { get; set; }

        public Room? Room { get; set; }
    }
}
