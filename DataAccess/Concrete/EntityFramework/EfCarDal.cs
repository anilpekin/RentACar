using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarsContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails(Expression<Func<CarDetailDto, bool>> filter = null)
        {
            using (CarsContext context = new CarsContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join r in context.Colors
                             on c.ColorId equals r.ColorId
                             select new CarDetailDto { 
                                 Id = c.Id,
                                 BrandId = b.BrandId,
                                 ColorId = r.ColorId,
                                 BrandName = b.BrandName, 
                                 ColorName = r.ColorName, 
                                 CarName = c.CarName,
                                 ModelYear = c.ModelYear,
                                 DailyPrice = c.DailyPrice,
                                 Description = c.Description
                             };
                return filter==null ? result.ToList() : result.Where(filter).ToList() ;
            }
        }
    }
}
