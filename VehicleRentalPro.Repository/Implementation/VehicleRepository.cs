using Microsoft.EntityFrameworkCore;
using VehicleRentalPro.Models;
using VehicleRentalPro.Repository.Interfaces;

namespace VehicleRentalPro.Repository.Implementation
{
	public class VehicleRepository : IVehicleRepository
	{
		private readonly CarContext _context;

		public VehicleRepository(CarContext carContext)
		{
			_context = carContext;
		}

		public async Task DeleteVehicle(int id)
		{
			var vehicle = await _context.Vehicles.FindAsync(id);
			if (vehicle != null)
			{
				_context.Vehicles.Remove(vehicle);
				_context.SaveChanges();
			}

		}

		public async Task<Vehicle> GetVehicleById(int id)
		{
			var vehicle = await _context.Vehicles.FindAsync(id);
			if (vehicle != null)
			{
				return vehicle;
			}
			throw new Exception($"Vhicle with ID : {id} not found!");
		}

		public async Task<IEnumerable<Vehicle>> GetVehicles()
		{
			var vehicles = await _context.Vehicles.ToListAsync();
			if (vehicles.Count == 0)
			{
				throw new Exception($"Vehicle Table is Empty");
			}
			return vehicles;
		}

		public async Task InsertVehicle(Vehicle vehicle)
		{
			await _context.AddAsync(vehicle);
			await _context.SaveChangesAsync();
		}

		public async Task UpdateVehicle(Vehicle vehicle)
		{
			var vehicleFromDb = await _context.Vehicles.FindAsync(vehicle.Id);
			if (vehicleFromDb != null)
			{
				vehicleFromDb.Name = vehicle.Name;
				vehicleFromDb.Type = vehicle.Type;
				vehicleFromDb.Model = vehicle.Model;
				vehicleFromDb.Number = vehicle.Number;
				vehicleFromDb.Color = vehicle.Color;
				vehicleFromDb.Description = vehicle.Description;
				if (vehicle.Image != null)
				{
					vehicleFromDb.Image = vehicle.Image;

				}
				vehicleFromDb.Price = vehicle.Price;
				vehicleFromDb.isAvaible = vehicle.isAvaible;
				vehicleFromDb.isDeleted = vehicle.isDeleted;
				vehicleFromDb.CreatedAt = vehicle.CreatedAt;
				vehicleFromDb.UpdatedAt = DateTime.UtcNow;
				
			}
		}
	}
}
