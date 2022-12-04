using System.ComponentModel.DataAnnotations;

namespace BootcampAPI.Models
{
    public class Grade : BaseModel /* Sınıf */
    {
        public int GradeId { get; set; }
        [StringLength(15)]
        public string GradeName { get; set; }
        public string Section { get; set; }


        public ICollection<Student> Students { get; set; }
    }
}
