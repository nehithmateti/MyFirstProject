using System;
using System.Collections.Generic;

namespace MyThirdProject.Models
{
    public partial class TblStudentDetail
    {
        public long SNo { get; set; }
        public long SId { get; set; }
        public string? SFirstName { get; set; }
        public string? SLastName { get; set; }
        public int? SAge { get; set; }
        public string? SGender { get; set; }
        public string? SCourse { get; set; }
        public string? SAddress { get; set; }
        public long? SPhone { get; set; }
        public DateTime? Dob { get; set; }
        public DateTime? DateOfJoining { get; set; }
    }
}
