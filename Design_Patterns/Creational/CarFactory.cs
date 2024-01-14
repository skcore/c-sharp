namespace Factory_method
{
    internal abstract class CarFactory 
    {
        public abstract ICar MakeCar();

        public ICar CreateCar()
        {
            ICar car=this.MakeCar();
            return car;

        }
    }
}
