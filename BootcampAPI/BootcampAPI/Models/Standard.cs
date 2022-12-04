namespace BootcampAPI.Models
{
    public class Standard
    {
        public int Key { get; set; }
        public string Name { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}
