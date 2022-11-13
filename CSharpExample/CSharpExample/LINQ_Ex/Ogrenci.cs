namespace CSharpExample.LINQ_Ex
{
    public class Ogrenci
    {
        public int ID { get; set; }
        public string Isim { get; set; }
        public string Cinsiyet { get; set; }
        public string Brans { get; set; }
        public int Yas { get; set; }
        public static List<Ogrenci> GetirOgrenciler()
        {
            return new List<Ogrenci>()
            {
                new Ogrenci { ID = 1001, Isim = "Preety", Cinsiyet = "Kadın", Brans = "CSE", Yas = 20 },
                new Ogrenci { ID = 1002, Isim = "Snurag", Cinsiyet = "Erkek", Brans = "ETC", Yas = 21  },
                new Ogrenci { ID = 1003, Isim = "Pranaya", Cinsiyet = "Erkek", Brans = "CSE", Yas = 21  },
                new Ogrenci { ID = 1004, Isim = "Anurag", Cinsiyet = "Erkek", Brans = "CSE", Yas = 20  },
                new Ogrenci { ID = 1005, Isim = "Hina", Cinsiyet = "Kadın", Brans = "ETC", Yas = 20 },
                new Ogrenci { ID = 1006, Isim = "Priyanka", Cinsiyet = "Kadın", Brans = "CSE", Yas = 21 },
                new Ogrenci { ID = 1007, Isim = "santosh", Cinsiyet = "Erkek", Brans = "CSE", Yas = 22  },
                new Ogrenci { ID = 1008, Isim = "Tina", Cinsiyet = "Kadın", Brans = "CSE", Yas = 20  },
                new Ogrenci { ID = 1009, Isim = "Celina", Cinsiyet = "Kadın", Brans = "ETC", Yas = 22 },
                new Ogrenci { ID = 1010, Isim = "Sambit", Cinsiyet = "Erkek", Brans = "ETC", Yas = 21 }
            };
        }
    }
}
