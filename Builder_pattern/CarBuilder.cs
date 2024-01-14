namespace Builder_pattern
{
    internal abstract class CarBuilder
    {
        public Car car = new Car();

        public abstract decimal GetCarPrice();
        public abstract string GetCarType();

        public Car GetCar()
        {
            return car;
        }
    }
}
