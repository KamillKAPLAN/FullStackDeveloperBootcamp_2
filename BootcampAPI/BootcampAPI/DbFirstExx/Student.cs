using System;
using System.Collections.Generic;

namespace BootcampAPI.DbFirstExx
{
    public partial class Student
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public DateTime? BirthDate { get; set; }
        public decimal Height { get; set; }
        public float Weight { get; set; }
        public int GradeId { get; set; }
        public int StandardId { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public DateTime UptatedAt { get; set; }
        public int UptatedBy { get; set; }
        public bool IsDeleted { get; set; }

        public virtual Grade Grade { get; set; } = null!;
        public virtual Standard Standard { get; set; } = null!;
    }
}
