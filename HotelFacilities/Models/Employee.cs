using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace HotelFacilities.Models
{
    public partial class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int? Age { get; set; }
        public string Position { get; set; }
        public int? Salary { get; set; }
        public DateTime? HireDate { get; set; }
        public int? DepartmentId { get; set; }
        public int? IncentiveId { get; set; }
    }
}
