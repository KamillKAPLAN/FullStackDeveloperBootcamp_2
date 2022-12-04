using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BootcampAPI.Models
{
    [Table("StudentInfo")]
    public class Student : BaseModel
    {
        [Key]
        public int Id { get; set; }
        [Column("StudentName", TypeName ="nchar(10) || ntext")]
        [MaxLength(10)]
        public string Name { get; set; }
        public DateTime? BirthDate { get; set; }
        //public decimal Height { get; set; }
        public float Weight { get; set; }


        public int GradeId { get; set; }
        public Grade Grade { get; set; }
    }
}
