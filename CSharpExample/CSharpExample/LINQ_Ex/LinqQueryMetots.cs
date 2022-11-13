namespace CSharpExample.LINQ_Ex
{
    public class LinqQueryMetots
    {
        void Metot()
        {
            /* 
             * LINQ
             *  - Query 
             *  - Metot
             */

            int[] sayilar = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            /* Query */
            var kucuksayilar = from sayi in sayilar
                               where sayi < 5
                               select sayi;

            /* Metot */
            var metotkucukSayilar = sayilar.Where(x => x < 5);

            foreach (var item in metotkucukSayilar)
                Console.WriteLine(item);
        }

        void Where()
        {
            List<Kurs> kurslar = new List<Kurs>()
            {
                new Kurs() {Id=1, Subject= "C#", Order = 1},
                new Kurs() {Id=2, Subject= "LinQ", Order = 6},
                new Kurs() {Id=3, Subject= "React", Order = 5},
                new Kurs() {Id=4, Subject= ".Net Core", Order = 3},
                new Kurs() {Id=5, Subject= "Angular", Order = 2}
            };

            kurslar.Add(new Kurs() { Id = 6, Subject = "Müzik Learn", Order = 4 });

            /* Query */
            var result = from kurs in kurslar
                         where kurs.Order > 5
                         select kurs;

            /* Metot */
            // var result2 = kurslar.Where(x => x.Order > 3 && x.Subject.Contains("React"));
            var result2 = kurslar.Where(x => x.Order > 3 && x.Subject == "React");

            foreach (var item in result2)
                Console.WriteLine($"Id : {item.Id} - Subject : {item.Subject} - Order : {item.Order}");
        }

        void OfType()
        {
            /* OfType */
            object[] values = { "Kamil", "Ali", "Ömer", "Ceylan", "Elif", 12, 23, 45, 12.34, 24.56, 34.89 };
            var strresult = values.OfType<string>();
            var intresult = values.OfType<int>();
            var doubleresult = values.OfType<double>();
            foreach (var item in doubleresult)
                Console.WriteLine(item);

            List<Kurs> kurslar = new List<Kurs>()
            {
                new Kurs() {Id=1, Subject= "C#", Order = 2},
                new Kurs() {Id=2, Subject= "LinQ", Order = 1},
                new UcretliKurs(){Id=3, Subject = ".Net Core", Order = 4},
                new UcretsizKurs(){Id=4, Subject = "Css", Order = 3},
            };

            /* Query */
            var queryResult = from kurs in kurslar.OfType<UcretliKurs>()
                              select kurs;

            /* Metot */
            var metotResult = kurslar.OfType<UcretsizKurs>();

            foreach (var item in queryResult)
                Console.WriteLine(item.Subject);
        }

        void OrderBy()
        {
            /* Order By */
            var kurslar = Kurs.KursList();

            /* Query */
            var queryResult = from kurs in kurslar
                              orderby kurs.Order, kurs.Subject descending
                              select kurs;

            /* Metot */
            var metotResult = kurslar.OrderByDescending(kurs => kurs.Subject);
            var metotResult2 = kurslar.OrderBy(x => x.Subject).ThenBy(x => x.Order).ThenByDescending(x => x.Id);


            foreach (var item in queryResult)
                Console.WriteLine($"Id : {item.Id} - Subject : {item.Subject} - Order : {item.Order}");

            Console.WriteLine("-----------------------------------------");

            foreach (var item in metotResult2)
                Console.WriteLine($"Id : {item.Id} - Subject : {item.Subject} - Order : {item.Order}");

            var reverseQueryResult = (from kurs in kurslar
                                      orderby kurs.Order
                                      select kurs).Reverse();

            var reverseMetotResult = kurslar.OrderBy(x => x.Subject).Reverse();

            Console.WriteLine("-----------------------------------------");

            foreach (var item in reverseMetotResult)
                Console.WriteLine($"Id : {item.Id} - Subject : {item.Subject} - Order : {item.Order}");
        }

        void IQueryablevsIEnumerable()
        {
            /* 
             * IQueryable  : sorgular direkt SQL
             * IEnumerable : datayı öce belleğe alır ardından koşula göre nellekten datayı alır
             */
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            IEnumerable<int> queryIEnumerable = from number in numbers
                                                where number > 5
                                                select number;

            IQueryable<int> queryIQueryable = from number in numbers.AsQueryable()
                                              where number > 5
                                              select number;

            IQueryable<int> metotIQueryable = numbers.AsQueryable().Where(number => number > 5);
            foreach (var item in metotIQueryable)
                Console.WriteLine(item);
        }

        void Except_Union_Concat_Distict()
        {
            /* 
             * Except
                string[] k1 = { "", "" };
                string[] k2 = { "", "" };
                var exceptResult = k1.Except(k2);
             * Union
                var unionResult = k1.Union(k2);
             * Concat
                var concatResult = k1.Concat(k2);
             * Insersect
                
             * Distict
             */
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 1, 2, 4, 5, 6, 7 };
            foreach (var item in numbers.Distinct())
                Console.Write($"{item} ");
        }

        void Any_All_Contains()
        {
            /* Any(), 
             * All(), 
             * Contains() 
             */
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] numbers2 = { 10, 20, 30, 40 };
            string[] languages = { "Türkçe", "İngilizce", "Almancae" };

            var anyResult = numbers.Any();
            if (anyResult)
                Console.WriteLine($"{numbers.Count} değer var");
            else
                Console.WriteLine($"{numbers.Count} değer yok");

            var anyResult1 = numbers2.Any();
            var anyResult2 = numbers2.Any(x => x == 10);
            var anyResult3 = numbers2.Any(x => x == 40 || x == 65);
            var anyResult4 = numbers2.Any(x => x > 20);

            var allResult = numbers.All(x => x == 5);
            if (allResult)
                Console.WriteLine($"{numbers.Count} değer var");
            else
                Console.WriteLine($"{numbers.Count} değer yok");

            var allResult1 = languages.All(x => x == "Türkçe");
            var allResult2 = languages.All(x => x.Contains("e"));
            var allResult3 = languages.All(x => x.StartsWith("r"));

            var containsResult = numbers.Contains(9);
            if (containsResult)
                Console.WriteLine($"{numbers.Count} değer var");
            else
                Console.WriteLine($"{numbers.Count} değer yok");
        }

        void Select()
        {
            int[] numbers = { 0, 1, 2, 3 };

            var result = numbers.Select(x => x * 10);
            var result2 = from number in numbers
                          select (number * 10);

            foreach (var item in result)
                Console.WriteLine(item);
        }

        void SelectMany()
        {
            /* SelectMany */
            int[] numbers = { 0, 1, 2, 3, 5 };
            string[] countries = { "Türkiye", "Fransa", "Rusya", "Almanya" };

            var result = countries.SelectMany(x => numbers, (x, n) => new
            {
                country = x,
                number = n
            });

            foreach (var item in result)
                Console.WriteLine($"{item.number} - {item.country}");
        }

        void Sum_Count_Min_Max_Average()
        {
            /* Sum, Count, Min, Max, Average */
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var sumResult = numbers.Sum();

            var count = numbers.Count();

            var min = numbers.Min();

            var maxResult = numbers.Max();

            var averageResult = numbers.Average();

            Console.WriteLine("");
        }

        void Aggregate()
        {
            /* Aggregate */
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var aggregateReult = numbers.Aggregate((x, y) => x + y);
            Console.WriteLine(aggregateReult);

            string[] yetenekler = { "C#", "LinQ", "Ado.Net", "SQL" };
            var aggregateResult2 = yetenekler.Aggregate((x, y) => x + ", " + y);
            Console.WriteLine(aggregateResult2);

            int maas = Calisan.CalisanlariGetir().Aggregate<Calisan, int>(0, (toplamMaas, calisan) => toplamMaas += calisan.Maas);
            Console.WriteLine(maas);

            var calisanIsimleri = Calisan.CalisanlariGetir()
                                 .Aggregate<Calisan, string>("Çalışan İsimleri : ", (calisanisimleri, calisan) =>
                                    calisanisimleri = calisanisimleri + calisan.Ad + ", ");
            Console.WriteLine(calisanIsimleri);

            int lastIndex = calisanIsimleri.LastIndexOf(",");
            calisanIsimleri = calisanIsimleri.Remove(lastIndex);

            Console.WriteLine(calisanIsimleri);

        }

        void GroupBy()
        {
            // mettot
            IEnumerable<IGrouping<string, Ogrenci>> metotGroupBy = Ogrenci.GetirOgrenciler().GroupBy(x => x.Brans);

            // query
            var queryGroupBy = from ogr in Ogrenci.GetirOgrenciler()
                               group ogr by ogr.Brans;

            foreach (var grup in metotGroupBy)
            {
                Console.WriteLine(grup.Key + " : " + grup.Count());
                foreach (var item in grup)
                    Console.WriteLine($"{item.Isim}, {item.Yas}, {item.Cinsiyet}");
            }

            var groupByMulti = Ogrenci.GetirOgrenciler()
                                     .GroupBy(x => new { x.Brans, x.Cinsiyet })
                                     .Select(x => new
                                     {
                                         Brans = x.Key.Brans,
                                         Cinsiyet = x.Key.Cinsiyet,
                                         Ogrenciler = x.OrderBy(y => y.Isim)
                                     });
            foreach (var grup in groupByMulti)
            {
                Console.WriteLine($"{grup.Brans} - {grup.Cinsiyet} - {grup.Ogrenciler.Count()}");
                foreach (var item in grup.Ogrenciler)
                {
                    Console.WriteLine($"{item.Isim} - {item.Yas} - {item.Cinsiyet}");
                }
            }
        }

        void First_Last_Single_ElementAt()
        {
            /* First(), Last(), Single(), ElementAt() */
            string[] names = { "Hüseyin", "Ahmet", "Onur", "Tolgahan" };

            var firstOrDefaultResult = names.FirstOrDefault(); // eğer bir kayıt olmaz ise hata vermez ve default değeri alır.
            var firstResult = names.First(); // eğer bir kayıt olmazsa bu hata verir.

            var lastResult = names.Last();
            var lastOrDefaultResult = names.LastOrDefault();

            var singleResult = names.Single(x => x.Contains("Onur"));
            var singleResult2 = names.Single(x => x.EndsWith("r"));
            var singleOrDefaultResult = names.SingleOrDefault(x => x.EndsWith("r"));

            var elementResult = names.ElementAt(1);
            var elementOrDefaultResult = names.ElementAtOrDefault(4);

            Console.WriteLine();
        }

        void Take_TakeWhile_Skip_SkipWhile()
        {
            /* Take_TakeWhile_Skip_SkipWhile */
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var takeresult = numbers.Take(5);

            var takeWhileResult = numbers.TakeWhile(x => x < 4);

            var skipResult = numbers.Skip(3);

            var skipWhileResult = numbers.SkipWhile(x => x < 4);

            foreach (var item in skipWhileResult)
                Console.WriteLine($"{item}");
        }

        void ToArray_ToList_ToDictionary_Cast()
        {
            /* ToArray_ToList_ToDictionary_Cast */
            List<int> listNumbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var arrayResult = listNumbers.ToArray();

            int[] arrayNumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var listResult = arrayNumbers.ToList();

            var dictionaryResult = listNumbers.ToDictionary(x => x, y => (y % 2) == 1);
            foreach (var item in dictionaryResult)
                Console.WriteLine($"{item.Key} : {item.Value}");

            var months = new List<string> { "February", "March", "May", "June", "July", "August", "September", "October", "November", "December" };
            var castResult = months.Cast<string>();
            foreach (var item in castResult)
                Console.WriteLine($"{item}");
        }
    }
}
