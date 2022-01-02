using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelFacilities.Models
{
    public class HotelFacility
    {
        [Key]
        public int Id { get; set; }
        public int CatId { get; set; }
        [Column("title")]
        public string Name { get; set; }
    }
}