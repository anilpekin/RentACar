using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentaldal;

        public RentalManager(IRentalDal rentaldal)
        {
            _rentaldal = rentaldal;
        }

        public IResult Add(Rental rental)
        {
            var isCarRented = _rentaldal.Get(p=>p.CarId==rental.CarId);
            if (isCarRented == null || isCarRented.ReturnDate < rental.RentDate)
            {
                _rentaldal.Add(rental);
                return new SuccessResult(Messages.RentalAdded);
                Console.WriteLine(Messages.RentalAdded);

            }
             return new ErrorResult(Messages.RentalFailed);
             Console.WriteLine(Messages.RentalFailed);
         
        }

        public IResult Delete(Rental rental)
        {
            _rentaldal.Delete(rental);
            return new SuccessResult();
        }

        public IResult Update(Rental rental)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Rental>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<Rental> GetRentalByCarId(int carId)
        {
            return new SuccessDataResult<Rental>(_rentaldal.Get(p => p.CarId == carId));
        }

     
    }
}
