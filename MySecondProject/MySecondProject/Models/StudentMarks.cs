using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySecondProject.Models
{
    internal class StudentMarks
    {
        public int SerialNo { get; set; }
        public long StudentId { get; set; }
        public decimal? FeesPaid { get; set; }
        public int? Mathsmarks { get; set; }
        public int? Physicsmarks { get; set; }
        public int? ChemistryMarks { get; set; }
        public int? ScienceMarks { get; set; }
        public int? EnglishMarks { get; set; }
        public int? TotalMarks { get; set; }

        public double? Percentage { get; set; }




    }
}
