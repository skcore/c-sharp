using Builder_pattern;

CarShop shop = new CarShop();

CarBuilder builder = new TataCarBuilder();

shop.ConstructCar(builder);

Car car = builder.GetCar();

car.ShowCarInformation();    