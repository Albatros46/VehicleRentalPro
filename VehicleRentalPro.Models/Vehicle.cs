using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalPro.Models
{
	public class Vehicle
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
		public bool isAvaible { get; set; }
		public bool isDeleted { get; set; }
		public DateTime CreatedAt { get; set; }
		public DateTime? UpdatedAt { get; set; }

		//Navigation Properties
		public virtual ICollection<Rental> Rentals { get; set; }
	}
}
