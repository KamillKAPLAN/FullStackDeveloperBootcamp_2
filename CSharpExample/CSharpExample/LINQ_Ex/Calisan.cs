namespace CSharpExample.LINQ_Ex
{
    public class Calisan
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public int Maas { get; set; }
        public string Departman { get; set; }

        public static List<Calisan> CalisanlariGetir()
        {
            List<Calisan> result = new List<Calisan>()
            {
                new Calisan{Id= 101,Ad = "Preety", Maas = 100, Departman = "IT"},
                new Calisan{Id= 102,Ad = "Priyanka", Maas = 150, Departman = "Sales"},
                new Calisan{Id= 103,Ad = "James", Maas = 50, Departman = "Sales"},
                new Calisan{Id= 104,Ad = "Hina", Maas = 20, Departman = "IT"},
                new Calisan{Id= 105,Ad = "Anurag", Maas = 30, Departman = "IT"},
            };
            return result;
        }
    }
}
