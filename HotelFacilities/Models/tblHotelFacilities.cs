using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace HotelFacilities.Models
{
    public partial class tblHotelFacilities
    {
        public int Id { get; set; }
        public int CatId { get; set; }

        [Display(Name = "امکانات هتل")]
        public string Title { get; set; }

      //  public virtual tblHotelFacilitiesCats Cat { get; set; }
 }
}
