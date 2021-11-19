using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

CarManager carManager = new CarManager(new EfCarDal());

foreach (var car in carManager.GetCarDetails())
{
    Console.WriteLine(car.BrandName + " / " + car.CarName + " / " + car.ColorName + " / " + car.DailyPrice );
}