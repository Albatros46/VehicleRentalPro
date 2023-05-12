using Microsoft.AspNetCore.Mvc;
using VehicleRentalPro.Repository.Interfaces;

namespace VehicleRentalPro.Controllers
{
	public class VehicleController : Controller
	{
		private readonly IVehicleRepository _vehicleRepository;

		public VehicleController(IVehicleRepository vehicleRepository)
		{
			_vehicleRepository = vehicleRepository;
		}

		public IActionResult Index()
		{
			var vehicles=_vehicleRepository.GetVehicles();
			return View();
		}
	}
}
