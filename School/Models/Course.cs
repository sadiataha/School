using System;
using System.Collections.Generic;

#nullable disable

namespace School.Models
{
    public partial class Course
    {
        public Course()
        {
            Students = new HashSet<Student>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public DateTime? AddedDate { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
