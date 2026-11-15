
namespace DormitoryManagementSystem.Models
{
    public class Payment
    {
        public int Id { get; set; }

        public int ResidentId { get; set; }

        public Resident? Resident { get; set; }

        public decimal Amount { get; set; }

        public DateTime PaymentDate { get; set; }

        public string PaymentMethod { get; set; } = "";

        public string Status { get; set; } = "Paid";
    }
}
