using System;
using System.Collections.Generic;

namespace MyFirstProject.Models
{
    public partial class Student
    {
        public long Id { get; set; }
        public string Name { get; set; } = null!;
        public int CourseId { get; set; }
    }
}
