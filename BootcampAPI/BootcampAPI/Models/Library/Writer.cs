namespace BootcampAPI.Models.Library
{
    /*
     {
        "yazarno": 1,
        "yazarad": "Leyla               ",
        "yazarsoyad": "Çelik               "
     }
     */
    public class Writer
    {
        public int yazarno { get; set; }
        public string yazarad { get; set; }
        public string yazarsoyad { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}
