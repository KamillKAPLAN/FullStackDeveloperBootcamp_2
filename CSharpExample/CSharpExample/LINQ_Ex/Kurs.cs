namespace CSharpExample.LINQ_Ex
{
    public class Kurs
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public int Order { get; set; }

        public static List<Kurs> KursList()
        {
            return new List<Kurs>()
            {
                new Kurs() {Id=1, Subject= "C#", Order = 2},
                new Kurs() {Id=2, Subject= "LinQ", Order = 1},
                new Kurs() {Id=3, Subject= "React", Order = 5},
                new Kurs() {Id=4, Subject= ".Net Core", Order = 3},
                new Kurs() {Id=5, Subject= "Angular", Order = 6},
                new UcretliKurs(){Id=6, Subject = ".Net Core", Order = 4},
                new UcretsizKurs(){Id=7, Subject = "Css", Order = 7},
            };
        }
    }

    public class UcretliKurs : Kurs
    {
        public decimal Price { get; set; }
    }

    public class UcretsizKurs : Kurs
    {

    }
}
