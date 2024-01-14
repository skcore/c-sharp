namespace Builder_pattern
{
    internal class TataCarBuilder : CarBuilder
    {
        public override decimal GetCarPrice()
        {
            return car.Price = 10;
        }

        public override string GetCarType()
        {
            return car.Name = "Tata";
        }
    }
}
