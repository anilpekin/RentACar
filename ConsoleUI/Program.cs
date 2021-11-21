using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

//CarManager carManager = new CarManager(new EfCarDal());

//foreach (var car in carManager.GetCarDetails().Data)
//{
//    Console.WriteLine(car.BrandName + " / " + car.CarName + " / " + car.ColorName + " / " + car.DailyPrice );
//}

//UserManager userManager = new UserManager(new EfUserDal());
//userManager.Add(new User { FirstName = "Arda", LastName = "Pekin", Email = "ardapekin@gmail.com", Password = "135790" });

//CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
//customerManager.Add(new Customer { UserId = 5, CompanyName = "Arda Holding" });


RentalManager rentalManager = new RentalManager(new EfRentalDal());

rentalManager.Add(new Rental { CarId = 3, CustomerId = 1, RentDate = new DateTime(2021, 11, 29), ReturnDate = null });
