using System;
using System.Collections.Generic;

namespace MyThirdProject.Models
{
    public partial class TblStudentMark
    {
        public int SerialNo { get; set; }
        public long StudentId { get; set; }
        public decimal? SFeesPaid { get; set; }
        public int? SMathsMarks { get; set; }
        public int? SPhysicsMarks { get; set; }
        public int? SChemistryMarks { get; set; }
        public int? SScienceMarks { get; set; }
        public int? SEnglishMarks { get; set; }
        public int? STotalMarks { get; set; }
        public double? SPercentage { get; set; }

        public virtual TblStudentDetail Student { get; set; } = null!;
    }
}
