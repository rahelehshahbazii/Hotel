using System.ComponentModel.DataAnnotations;

namespace HotelFacilitiesDataLayer.Entities
{
    //[ClassName("HotelFacilities")]
    
    public class HotelFacility
    {
       
        [Key]
        public int Id { get; set; }
        public int CatId { get; set; }
        public string Name { get; set; }
        //public string NameEn { get; set; }
        //public string NameAr { get; set; }
        //public int ViewOrder { get; set; }
        //public bool AskFree { get; set; }
        //public string IconClassName { get; set; }
        //public int FamilyScore { get; set; }
        //public bool HasTag { get; set; }
        //public bool HasPicture { get; set; }

        //[Description("NotIncluded")]
        //public bool IsHighlightForHotelType { get; set; }

        //[Description("NotIncluded")]
        //public int ViewOrderForHotelType { get; set; }

        //[Description("NotIncluded")]
        //public string CatName { get; set; }

        //[Description("NotIncluded")]
        //public string CatComment { get; set; }

        //[Description("NotIncluded")]
        //public string CatIconClassName { get; set; }

      //  public HotelFacilityCat Group { get; set; }
    }
}