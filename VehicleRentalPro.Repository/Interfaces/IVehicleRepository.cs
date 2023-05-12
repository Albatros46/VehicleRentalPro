using VehicleRentalPro.Models;

namespace VehicleRentalPro.Repository.Interfaces
{
	public interface IVehicleRepository
	{
		Task<IEnumerable<Vehicle>> GetVehicles();
		Task<Vehicle> GetVehicleById(int id);
		Task InsertVehicle(Vehicle vehicle);
		Task UpdateVehicle(Vehicle vehicle);
		Task DeleteVehicle(int id);
	}
}
