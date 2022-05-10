using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySecondProject
{
    internal class StudentDetails
    {
        public long SNo { get; set; }
        public long Sid { get; set; }
        public string SFirstname { get; set; } = null!;
        public string SLastname { get; set; } = null!;
        public int SAge { get; set; }
        public char SGender { get; set; }
        public string SCourse { get; set; } = null!;
        public string SAddress { get; set; } = null!;
        public long SPhone { get; set; }
        public DateTime DOB { get; set; }
        public DateTime DateOfJoining { get; set; }
    }
}






