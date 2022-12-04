namespace BootcampAPI.Models.Library
{
    /*
     {
        "kitapno": 1,
        "isbnno": "253-335-3934-16-4   ",
        "kitapadi": "Abdülhamidin Kurtlarla Dansı",
        "yazarno": 26,
        "turno": 3,
        "sayfasayisi": 368,
        "puan": 22,
        "img": "1.jpg"
     }
     */
    public class Book
    {
        public int kitapno { get; set; }
        public string isbnno { get; set; }
        public string kitapadi { get; set; }
        public int sayfasayisi { get; set; }
        public int puan { get; set; }
        public string img { get; set; }

        public int WriterId { get; set; }
        public Writer Writer { get; set; }

        public ICollection<Type> Types { get; set; }
        public ICollection<Process> Processes { get; set; }
    }
}
