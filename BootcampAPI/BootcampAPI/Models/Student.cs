using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BootcampAPI.Models;

namespace BootcampAPI.Models
{
    //[Table("StudentInfo", Schema = "Bootacamp")]
    public class Student : BaseModel
    {
        //[Key]
        public int Id { get; set; }

        //[Column("StudentName", TypeName = "nchar(10) || ntext")]
        //[MaxLength(10)]
        //[Required]
        public string Name { get; set; }
        public DateTime? BirthDate { get; set; }
        //[NotMapped]
        //[Column(Order = 4)]
        public decimal Height { get; set; }
        public float Weight { get; set; }


        public int GradeId { get; set; }
        //[ForeignKey("GradeId")]
        public Grade Grade { get; set; }
        public int StandardId { get; set; }
        public Standard Standard { get; set; }
    }

