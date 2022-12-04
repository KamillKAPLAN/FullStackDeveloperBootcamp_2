namespace BootcampAPI.Models.Library
{
    /*
     {
        "islemno": 1,
        "ogrno": 73,
        "kitapno": 10,
        "atarih": "2006-01-01T00:00:00",
        "vtarih": "2006-01-17T00:00:00"
     },
     */
    public class Process
    {
        public int islemno { get; set; }
        public DateTime atarih { get; set; }
        public DateTime vtarih { get; set; }

        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
    }
}
