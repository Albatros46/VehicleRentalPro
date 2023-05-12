using AutoMapper;
using VehicleRentalPro.Models;
using VehicleRentalPro.Models.ViewModel.Vehicle;

namespace VehicleRentalPro.Mapper
{
	public class VehicleProfile:Profile
	{//Profile AutoMapper 
        public VehicleProfile()
        {
            CreateMap<Vehicle,VehicleViewModel>();
        }
    }
}
