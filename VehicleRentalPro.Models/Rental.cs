namespace VehicleRentalPro.Models
{
	public class Rental
	{
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public double TotalPrice { get; set; }
        public bool isPaid { get; set; }
        public bool isApproved { get; set; }
        public bool isDeleted { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        //Navigation Properties
        public virtual Vehicle Vehicle { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}