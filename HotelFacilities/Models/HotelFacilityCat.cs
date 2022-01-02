using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelFacilities.Models
{
   public class HotelFacilityCat
   {
      [Key]
      public int Id { get; set; }
      [Column("catName")]
      public string Name { get; set; }
      public virtual ICollection<HotelFacility> HotelFacility { get; set; }
   }
}
