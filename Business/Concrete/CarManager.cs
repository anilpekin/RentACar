using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _cardal;

        public CarManager(ICarDal cardal)
        {
            _cardal = cardal;
        }

        public void Add(Car car)
        {
            if (car.CarName.Length>=2 && car.DailyPrice>0)
            {
                _cardal.Add(car);
                Console.WriteLine("Car's successfully added!");
            }
            else
            {
                Console.WriteLine("Failed!!!");
            }
        }

        public void Delete(Car car)
        {
            _cardal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _cardal.GetAll();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _cardal.GetCarDetails();
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _cardal.GetAll(p => p.BrandId == id);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _cardal.GetAll(p => p.ColorId == id);
        }

        public void Update(Car car)
        {
            _cardal.Update(car);
        }
    }
}
