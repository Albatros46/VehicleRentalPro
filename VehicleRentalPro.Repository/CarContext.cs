using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleRentalPro.Models;

namespace VehicleRentalPro.Repository
{
	public class CarContext : IdentityDbContext<ApplicationUser>
	{
		public CarContext(DbContextOptions<CarContext> options) : base(options)
		{
			 
		}
		public DbSet<Vehicle> Vehicles { get; set; }

	}
}
