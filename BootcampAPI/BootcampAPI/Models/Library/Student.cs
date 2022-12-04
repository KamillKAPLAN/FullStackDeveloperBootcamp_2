namespace BootcampAPI.Models.Library
{
    /*
     {
         "ogrno": 1,
         "ograd": "Hülya     ",
         "ogrsoyad": "Yiğit               ",
         "cinsiyet": "K",
         "dtarih": "1990-04-08T00:00:00",
         "sinif": "10A ",
         "puan": 0
     }
     */
    public class Student
    {
        public int ogrno { get; set; }
        public string ograd { get; set; }
        public string ogrsoyad { get; set; }
        public char cinsiyet { get; set; }
        public DateTime dtarih { get; set; }
        public string sinif { get; set; }
        public Int16 puan { get; set; }

        public ICollection<Process> Processes { get; set; }
    }
}
