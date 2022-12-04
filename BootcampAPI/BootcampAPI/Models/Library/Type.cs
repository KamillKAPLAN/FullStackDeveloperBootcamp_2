namespace BootcampAPI.Models.Library
{
    /*
     {
        "turno": 1,
        "turadi": "Dram                          "
     }
     */
    public class Type
    {
        public int turno { get; set; }
        public string turadi { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}
