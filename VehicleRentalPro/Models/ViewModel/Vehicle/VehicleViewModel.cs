namespace VehicleRentalPro.Models.ViewModel.Vehicle
{
	public class VehicleViewModel
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Type { get; set; }
		public string Model { get; set; }
		public string Number { get; set; }
		public string Color { get; set; }
		public string Description { get; set; }
		public string Image { get; set; }
		public double Price { get; set; }
		public bool isAvaible { get; set; } = true;
		public bool isDeleted { get; set; }=false;
		public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
		public DateTime? UpdatedAt { get; set; }
	}
}
