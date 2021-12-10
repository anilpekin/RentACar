using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car {Id=1, BrandId=1, ColorId=1, ModelYear="2019", DailyPrice=200, Description="Diesel"},
                new Car {Id=2, BrandId=2, ColorId=2, ModelYear="2021", DailyPrice=250, Description="Diesel" },
                new Car {Id=3, BrandId=3, ColorId=3, ModelYear="2018", DailyPrice=180, Description="Gasoline" },
                new Car {Id=4, BrandId=4, ColorId=4, ModelYear="2017", DailyPrice=150, Description="Diesel" },
                new Car {Id=5, BrandId=5, ColorId=5, ModelYear="2015", DailyPrice=100, Description="Gas" }
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p => p.Id == car.Id);

            _cars.Remove(carToDelete);
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.Id == car.Id);
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.Description = car.Description;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ModelYear = car.ModelYear;
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(p => p.Id == id).ToList();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails(Expression<Func<CarDetailDto, bool>> filter = null)
        {
            throw new NotImplementedException();
        }
    }
}
