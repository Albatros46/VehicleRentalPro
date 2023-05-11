using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalPro.Models
{
	public class ApplicationUser:IdentityUser
	{
        public string FullName { get; set; }
        public string Adress { get; set; }

        //Navigation Properties
        //public virtual ICollection<Booking> Bookings { get; set; }
    }
}
