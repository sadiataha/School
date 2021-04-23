using System;
using System.Collections.Generic;

#nullable disable

namespace School.Models
{
    public partial class Student
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Image { get; set; }
        public long? CourseId { get; set; }

        public virtual Course Course { get; set; }
    }
}
