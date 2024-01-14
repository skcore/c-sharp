namespace Builder_pattern
{
    internal class Car
    {
        public decimal Price { get; set; }
        public string? Name { get; set; }
        public void ShowCarInformation()
        {
            Console.WriteLine($"India safety car is: {Name}");
            Console.WriteLine($"Price of the car is: {Price}");
            Console.ReadLine();
        }
    }
}
