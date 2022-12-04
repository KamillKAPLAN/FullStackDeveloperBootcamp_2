using System;
using System.Collections.Generic;

namespace BootcampAPI.DbFirstExx
{
    public partial class Standard
    {
        public Standard()
        {
            Students = new HashSet<Student>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Student> Students { get; set; }
    }
}
