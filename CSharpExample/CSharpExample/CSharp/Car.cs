namespace CSharpExample.CSharp
{
    public class Car
    {
        public Car()
        {

        }
        public Car(string color, int speed)
        {

        }

        private string _color;
        public string Color
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
            }
        }

        int speed = 200;
        public int MaxSpeed()
        {
            return speed + 100;
        }

        int maxSpeed => speed + 100;
    }
}
