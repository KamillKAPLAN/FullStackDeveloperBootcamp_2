namespace CSharpExample
{
    public abstract class BaseTbl // base class -Vehicle
    {
        public int Id { get; set; }
        public abstract void MetotA();
        public void MetotB()
        {
            Console.WriteLine("Abstract Void Metot");
        }
        /*
         * Id
         * CreatedAt
         * CreatedBy
         * UpdatedAt
         * UpdatedBy
         * DeletedAt
         * DeletedBy
         * IsDeleted
         */
    }
    public class Person : BaseTbl
    {
        public override void MetotA()
        {
            throw new NotImplementedException();
        }

        public virtual void MetotC()
        {
            Console.WriteLine("Virtual MetotC");
        }
    }
    public class Student : Person
    {
        public override void MetotC()
        {
            Console.WriteLine("Student Override Virtual MetotC");
        }
    }
    public class Teacher : BaseTbl
    {
        public override void MetotA()
        {
            throw new NotImplementedException();
        }
    }
    public sealed class ClassSealed
    {

    }

    /* Inheritance - Polymorphism */
    class Animal
    {
        public virtual void AnimalSound()
        {
            Console.WriteLine("Animal ses yaptı");
        }
    }

    class Cat : Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("Animal Cat Miav Miav");
        }
    }

    class Dog : IAnimal, IDog
    {
        public void AnimalSound()
        { }

        public void Run()
        { }
    }
    class Bird : IAnimal, IBird
    {
        public void AnimalSound()
        { }

        public void Uc()
        { }
    }
    class Fish : IAnimal, IFish
    {
        public void AnimalSound()
        { }

        public void Yuz()
        { }
    }
}
