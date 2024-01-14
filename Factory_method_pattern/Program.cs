using Factory_method;

ICar tata=new TataFactory().CreateCar();

if (tata != null) 
    Console.Write($"India safety car  { tata.GetCarType()} and price is {tata.GetCarPrice()}");

Console.ReadLine();

ICar maruthi = new MaruthiFactory().CreateCar();

if (maruthi != null)
    Console.Write($"India safety car  {maruthi.GetCarType()} and price is {maruthi.GetCarPrice()}");
