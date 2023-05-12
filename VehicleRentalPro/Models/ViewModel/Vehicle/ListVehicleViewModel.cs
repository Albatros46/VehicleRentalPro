using VehicleRentalPro.Utility;

namespace VehicleRentalPro.Models.ViewModel.Vehicle
{
	public class ListVehicleViewModel
	{
        public IEnumerable<VehicleViewModel> VehicleList { get; set; }
        public PageInfo PageInfo { get; set; }
        public string SearchingText { get; set; }
    }
}
