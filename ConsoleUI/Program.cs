using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

CarManager carManager = new CarManager(new EfCarDal());

foreach (var car in carManager.GetCarsByBrandId(1))
{
    Console.WriteLine(car.DailyPrice);
}

foreach (var car in carManager.GetCarsByColorId(3))
{
    Console.WriteLine(car.DailyPrice);
}

carManager.Add(new Car { BrandId = 2, ColorId = 2, CarName = "Polo", DailyPrice = 180, ModelYear = "2015", Description = "Diesel" });
