using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace HotelFacilities.Models
{
    public partial class New_IranHotelOnlineDB_realContext : DbContext
    {
        public New_IranHotelOnlineDB_realContext()
        {
        }

        public New_IranHotelOnlineDB_realContext(DbContextOptions<New_IranHotelOnlineDB_realContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<HotelFacilities> HotelFacilities { get; set; }
        public virtual DbSet<HotelFacilitiesCats> HotelFacilitiesCats { get; set; }
        public virtual DbSet<HotelFacilitiesView> HotelFacilitiesView { get; set; }
        public virtual DbSet<Incentive> Incentive { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-0BBCI3J; Initial Catalog = New_IranHotelOnlineDB_real; user Id = Raheleh; Password = Sh091023$#;Trusted_Connection=True;");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>(entity =>
            {
                entity.Property(e => e.DepartmentName).HasMaxLength(50);
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.Property(e => e.DepartmentId).HasColumnName("Department_Id");

                entity.Property(e => e.Gender)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HireDate).HasColumnType("datetime");

                entity.Property(e => e.IncentiveId).HasColumnName("Incentive_Id");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Position).HasMaxLength(50);
            });

            modelBuilder.Entity<HotelFacilities>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CatId).HasColumnName("CatID");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.HasOne(d => d.Cat)
                    .WithMany(p => p.HotelFacilities)
                    .HasForeignKey(d => d.CatId)
                    .HasConstraintName("FK_HotelFacilities_HotelFacilitiesCats");
            });

            modelBuilder.Entity<HotelFacilitiesCats>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CatName)
                    .HasColumnName("catName")
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HotelFacilitiesView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("HotelFacilitiesView");

                entity.Property(e => e.Name)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
