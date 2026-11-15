
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DormitoryManagementSystem.Models
{
    public class Room
    {
        public int Id { get; set; }

        [Required]
        public string RoomNumber { get; set; } = "";

        public int Capacity { get; set; }

        public List<Resident> Residents { get; set; } = new List<Resident>();
    }
}
