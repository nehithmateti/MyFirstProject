using System;
using System.Collections.Generic;

namespace MyThirdProject.Models
{
    public partial class TblEmployee
    {
        public long EmpId { get; set; }
        public string Name { get; set; } = null!;
        public int Age { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; } = null!;
        public string? PresentAddress { get; set; }
        public string PermanentAddress { get; set; } = null!;
        public decimal Salary { get; set; }
        public bool IsActive { get; set; }
        public DateTime? JoiningDate { get; set; }
        public long ManagerId { get; set; }
        public string? Dept { get; set; }
    }
}
