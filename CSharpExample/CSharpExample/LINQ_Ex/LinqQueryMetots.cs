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
    }
}
