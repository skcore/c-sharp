namespace Factory_method
{
    internal class Maruthi : ICar
    {
        public int GetCarPrice()
        {
            return 100;
        }

        public string GetCarType()
        {
            return "Maruthi Suzuki";
        }
    }
}
