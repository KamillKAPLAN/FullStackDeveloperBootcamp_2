namespace CSharpExample.GenelOrnek
{
    class Arac
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public DateTime Yil { get; set; }

        public List<Arac> GetAracList()
        {
            List<Arac> aracs = new List<Arac>()
            {
                new Arac() { Id = 1, Adi = "X1", Yil = DateTime.Now.Date },
                new Arac() { Id = 2, Adi = "X2", Yil = DateTime.Now.Date },
                new Arac() { Id = 3, Adi = "X3", Yil = DateTime.Now.Date },
                new Kamyonet() {Id = 4, Adi = "Y1", Yil = DateTime.Now.Date, Yuk = 1},
                new Kamyonet() {Id = 5, Adi = "Y2", Yil = DateTime.Now.Date, Yuk = 2},
                new Kamyonet() {Id = 6, Adi = "Y3", Yil = DateTime.Now.Date, Yuk = 3},
                new Taksi() {Id = 7, Adi = "Z1", Yil = DateTime.Now.Date, Plaka = "34T"},
                new Taksi() {Id = 8, Adi = "Z2", Yil = DateTime.Now.Date, Plaka = "44T"},
                new Taksi() {Id = 9, Adi = "Z3", Yil = DateTime.Now.Date, Plaka = "64T"},
            };
            return aracs;
        }

        void Calismalar()
        {
            Arac aracObject = new Arac();
            var aracList = aracObject.GetAracList();
            /* Tipi : 
               - var aracList = arac.GetAracList().Where(x => x.GetType() == typeof(Taksi)); 
               - var aracList = arac.GetAracList().OfType<Taksi>();
               - var aracList = arac.GetAracList().OfType<Taksi>();
               - var list = from narac in arac.GetAracList()
                            where narac.Id > 5
                            select narac;
               - foreach (var item in aracList)
                     Console.WriteLine(item.Adi);
               - var query = from x in aracList
                             orderby x.Id descending, x.Adi
                             select x;     
               - var metot = aracList.OrderByDescending(x => x.Adi).OrderBy(x=> x.Id).ThenBy(x=> x.Adi);
               - List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 1, 2, 4, 5, 6, 7 };
                 // distinct, Any, Contains
                 var distinctResult = numbers.Distinct();
                 var anyResult = numbers.Any();
                 var anyResult2 = numbers.Any(x => x == 10);
                 var containsResult = numbers.Contains(6);
               - int[] numbers = { 0, 1, 2, 3 };
                 var result = numbers.Select(x => x * 5);
                 var result2 = from nun in numbers
                               select nun * 5;
               - var result = aracList.GroupBy(x => x.GetType());
                 foreach (var item in result)
                 {
                     Console.WriteLine($"{item.Key} - {item.Count()}");
                 }
               - var query = from arac in aracList
                             group arac by arac.GetType();

               - var indexFirt = aracList.ElementAt(5);
             *  
             */
        }
    }

    class Kamyonet : Arac
    {
        public int Yuk { get; set; }
    }

    class Taksi : Arac
    {
        public string Plaka { get; set; }
    }
}
