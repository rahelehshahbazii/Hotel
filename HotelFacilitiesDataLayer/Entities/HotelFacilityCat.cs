using System.ComponentModel.DataAnnotations;

namespace HotelFacilitiesDataLayer.Entities
{
    // [ClassName("HotelFacilitiesCats")]
    public class HotelFacilityCat
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        //public string NameEn { get; set; }
        //public string NameAr { get; set; }
        //public string IconClassName { get; set; }
        //public int ViewOrder { get; set; }
        //public string Comment { get; set; }
      //  public List<HotelFacilityCat> HotelFacilityCats { get; set; }
    }
}
