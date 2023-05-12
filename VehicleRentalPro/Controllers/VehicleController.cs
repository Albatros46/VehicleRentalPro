using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using VehicleRentalPro.Models.ViewModel.Vehicle;
using VehicleRentalPro.Repository.Interfaces;

namespace VehicleRentalPro.Controllers
{
	public class VehicleController : Controller
	{
		private readonly IVehicleRepository _vehicleRepository;
		private IMapper _mapper;

		public VehicleController(IVehicleRepository vehicleRepository, IMapper mapper)
		{
			_vehicleRepository = vehicleRepository;
			_mapper = mapper;
		}

		public async Task<IActionResult> Index(int pageNumber = 1, int pageSize = 10,string SearchingText=null)
		{//Sayfalandirma islemi
			IEnumerable<VehicleViewModel> viewModelList;
			var vehicles =  _vehicleRepository.GetVehicles().GetAwaiter().GetResult()
				.Skip((pageNumber*pageSize)-pageSize).Take(pageSize);
			var viewModel=_mapper.Map<IEnumerable<VehicleViewModel>>(vehicles);
			if (!String.IsNullOrEmpty(SearchingText))
			{
				viewModelList = viewModel.Where(x => x.Number.Equals(SearchingText));
			}
			var vehicleViewModel = new ListVehicleViewModel
			{
				VehicleList = viewModel,
				PageInfo = new Utility.PageInfo
				{
					ItemsPergePage = pageSize,
					CurrentPage = pageNumber,
					TotalItems = _vehicleRepository.GetVehicles().GetAwaiter().GetResult().Count(),
				},
				
			};
			return View();
		}
	}
}
