using System;
using System.Collections.Generic;

namespace BootcampAPI.DbFirstExx
{
    public partial class Grade
    {
        public Grade()
        {
            Students = new HashSet<Student>();
        }

        public int GradeId { get; set; }
        public string GradeName { get; set; } = null!;
        public string Section { get; set; } = null!;
        public DateTime CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public DateTime UptatedAt { get; set; }
        public int UptatedBy { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
