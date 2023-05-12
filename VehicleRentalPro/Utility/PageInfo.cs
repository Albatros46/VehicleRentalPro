namespace VehicleRentalPro.Utility
{
	public class PageInfo
	{//Sayfalama islemi
        public int TotalItems { get; set; }
        public int ItemsPergePage { get; set; }
        public int CurrentPage { get; set; }
        //-------------
        public int TotalPages => (int)Math.Ceiling((double)TotalItems/ItemsPergePage);
        public bool HasPreviousPage => CurrentPage > 1;
        public bool HasNextPage => CurrentPage < TotalPages;
    }
}
