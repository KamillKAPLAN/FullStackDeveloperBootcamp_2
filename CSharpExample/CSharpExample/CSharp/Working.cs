namespace CSharpExample.CSharp
{
    public class Working
    {
        void Ex()
        {
            Console.WriteLine("Hello, World!");
            // 
            /**/
            int intValue = 123;
            double doubleValue = 5.99;
            char charValue = 'D';
            bool boolValue = false;
            string stringValue = "Tech";

            const int number = 15;
            // number = 20;

            int iValue = 9;
            double dValue = iValue;

            double dValue2 = 9.78;
            int iValue2 = (int)dValue2;

            Console.WriteLine(!(iValue < 5 && dValue > 10));

            string s1 = "Tech";
            string s2 = "Career";
            Console.WriteLine(s1 + s2);
            Console.WriteLine(string.Concat(s1, s2));
            string totalValue = $"{s1} {s2}";
            String s = new String(totalValue.ToCharArray(), 2, 4);
            Console.WriteLine(s);


            if (iValue > intValue)
                Console.WriteLine("");
            else
                Console.WriteLine("");
            Console.WriteLine((intValue > iValue) ? (7 > 6) ? "büyük" : "büyük değil" : "hiçbiri");

            switch (iValue)
            {
                case 1: Console.WriteLine("1"); break;
                case 2: Console.WriteLine("2"); break;
                default: Console.WriteLine("hiçbiri"); break;
            }

            var result = iValue switch
            {
                1 => "bir",
                2 => "iki",
                _ => "değildir."
            };
            Console.WriteLine(result);

            /* do-while, while, for, foreach */
            int i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i > 5);

            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }

            for (int j = 0; j < 5; j++)
                Console.WriteLine(j);

            string[] names = { "Ali", "Ceylan", "Kamil" };
            foreach (var item in names)
                Console.WriteLine(item);

            for (int ii = 0; ii < 10; ii++)
            {
                if (ii == 3)
                    continue;
                if (ii == 4)
                    break;
                Console.WriteLine(ii);
            }

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            numbers[0] = 5;
            Array.Sort(numbers);
            Console.WriteLine();

            //VoidMetot();
            void VoidMetot()
            {
                Console.WriteLine("Void Metot");
            }

            // params
            //StaticMetot();
            static void StaticMetot()
            {
                Console.WriteLine("Static Void Metot");
            }

            void PMetot(int s1, int s2 = 2)
            {
                Console.WriteLine(s1 + s2);
            }
            int CalMetot(int s1, int s2, string operat)
            {
                /* operat : +, -, * ve / */
                //switch (operat)
                //{
                //    case "+": return (s1 + s2);
                //    case "-": return (s1 - s2);
                //    case "*": return (s1 * s2);
                //    default:
                //        return (s2 != 0 ? s1 / s2 : 0);
                //}
                return operat switch
                {
                    "+" => s1 + s2,
                    "-" => s1 - s2,
                    "*" => s1 * s2,
                    "/" => (s2 != 0) ? s1 / s2 : 0,

                };
            }
            //Console.WriteLine(CalMetot(5, 10, "*"));

            /* CLASSES */

            //Car car = new Car();
            //car.Color = "Kırmızı";

            /*
             * public 
             * private
             * protected
             * internal : assembly erişim sağlar.
             * protected internal
             */

            /*
             * abstract class 
             * abstract metot
             * sealed class
             * inheritance
             * polymorphism
             * 
             */

            //Person student = new Student();
            //student.MetotC();

            /*
             * Animal animal = new Animal();
             * Animal catAnimal = new Cat();
             * animal.AnimalSound();
             * catAnimal.AnimalSound(); 
             */

            //Dog dog = new Dog();
            //dog.AnimalSound();

            EnmLevel enmLevel = EnmLevel.Low;
            Console.WriteLine(enmLevel);

            Console.WriteLine((int)EnmMonth.May);
            Console.WriteLine((int)EnmMonth.July);

            var enmValue = EnmLevel.Low;
            var reuslt = enmValue switch
            {
                EnmLevel.Low => "Low Level",
                EnmLevel.Medium => "Medium Level",
                EnmLevel.High => "High LEvel",
                _ => ""
            };

            switch (enmValue)
            {
                case EnmLevel.Low: Console.Write("Low Level"); break;
                case EnmLevel.Medium: Console.Write("Medium Level"); break;
                case EnmLevel.High: Console.Write("High Level"); break;
                default: break;
            }
            try
            {
                Console.WriteLine(numbers[10]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //throw;
            }
            finally
            {
                Console.WriteLine("'try catch tamamlandı.");
            }
        }
    }
}
