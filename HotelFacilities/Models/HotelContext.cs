using HotelFacilities.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelFacilities.Models
{
    public class HotelContext : DbContext
    {

        public HotelContext(DbContextOptions<HotelContext> options)
      : base(options)
        {
        }
        //Using Fluent API for defining Two Pks
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<FacilityOfHotel>()
            //    .HasKey(e => new { e.HotelId, e.FacilityId });
        }


        #region facilities
        public DbSet<tblHotelFacilitiesCats> HotelFacilitiesCats { get; set; }
        public DbSet<tblHotelFacilities> HotelFacilities { get; set; }
        public DbSet<HotelFacilities.Models.HotelFacilitiesViewModel> HotelFacilitiesViewModel { get; set; }
        #endregion

}

    }