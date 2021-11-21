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
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerdal;

        public CustomerManager(ICustomerDal customerdal)
        {
            _customerdal = customerdal;
        }

        public IResult Add(Customer customer)
        {
            _customerdal.Add(customer);
            return new SuccessResult(Messages.CustomerAdded);
        }

        public IResult Delete(Customer customer)
        {
            _customerdal.Delete(customer);
            return new SuccessResult(Messages.CustomerDeleted);
        }

        public IResult Update(Customer customer)
        {
            _customerdal.Update(customer);
            return new SuccessResult(Messages.CustomerUpdated);
        }

        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>>(_customerdal.GetAll(),Messages.CustomersListed);
        }

        public IDataResult<Customer> GetCustomerById(int id)
        {
            return new SuccessDataResult<Customer>(_customerdal.Get(p=>p.Id==id));
        }

        public IDataResult<List<Customer>> GetCustomersByUserId(int userId)
        {
            return new SuccessDataResult<List<Customer>>(_customerdal.GetAll(p=>p.UserId==userId));
        }

    }
}
