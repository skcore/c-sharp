namespace Builder_pattern
{
    internal class CarShop
    {
        public void ConstructCar(CarBuilder builder)
        {
            builder.GetCarType();
            builder.GetCarPrice();
        }
    }
}
