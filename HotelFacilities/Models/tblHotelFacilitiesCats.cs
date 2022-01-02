using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace HotelFacilities.Models
{
    public partial class tblHotelFacilitiesCats
    {
        public tblHotelFacilitiesCats()
        {
           // HotelFacilities = new HashSet<tblHotelFacilities>();
        }

        public int Id { get; set; }
        public string CatName { get; set; }

       // public virtual ICollection<tblHotelFacilities> HotelFacilities { get; set; }
    }
}
