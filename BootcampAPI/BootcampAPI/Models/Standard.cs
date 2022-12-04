using System.ComponentModel.DataAnnotations;

namespace BootcampAPI.Models
{
    public class Standard
    {
        //[Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}
